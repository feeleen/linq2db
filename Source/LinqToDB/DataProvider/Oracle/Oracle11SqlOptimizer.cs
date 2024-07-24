﻿using System;

namespace LinqToDB.DataProvider.Oracle
{
	using Common;
	using Mapping;
	using SqlProvider;
	using SqlQuery;

	public class Oracle11SqlOptimizer : BasicSqlOptimizer
	{
		public Oracle11SqlOptimizer(SqlProviderFlags sqlProviderFlags) : base(sqlProviderFlags)
		{
		}

		public override SqlExpressionConvertVisitor CreateConvertVisitor(bool allowModify)
		{
			return new OracleSqlExpressionConvertVisitor(allowModify);
		}

		public override SqlStatement TransformStatement(SqlStatement statement, DataOptions dataOptions, MappingSchema mappingSchema)
		{
			switch (statement.QueryType)
			{
				case QueryType.Delete : statement = GetAlternativeDelete((SqlDeleteStatement) statement, dataOptions); break;
				case QueryType.Update : statement = GetAlternativeUpdate((SqlUpdateStatement) statement, dataOptions, mappingSchema); break;
			}

			statement = ReplaceTakeSkipWithRowNum(statement, false);

			return statement;
		}

		public override bool IsParameterDependedElement(NullabilityContext nullability, IQueryElement element, DataOptions dataOptions)
		{
			if (base.IsParameterDependedElement(nullability, element, dataOptions))
				return true;

			switch (element.ElementType)
			{
				case QueryElementType.ExprExprPredicate:
				{
					var (a, op, b, withNull) = (SqlPredicate.ExprExpr)element;

					// This condition matches OracleSqlExpressionConvertVisitor.ConvertExprExprPredicate, 
					// where we transform empty strings "" into null-handling expressions.
					if (withNull != null ||
						(dataOptions.LinqOptions.CompareNulls != CompareNulls.LikeSql &&
							op is SqlPredicate.Operator.Equal or SqlPredicate.Operator.NotEqual))
					{
						if (a.SystemType == typeof(string) && a.CanBeEvaluated(true))
							return true;
						if (b.SystemType == typeof(string) && b.CanBeEvaluated(true))
							return true;
					}
					break;
				}
			}

			return false;
		}

		static readonly ISqlExpression RowNumExpr = new SqlExpression(typeof(long), "ROWNUM", Precedence.Primary,
			SqlFlags.IsAggregate | SqlFlags.IsWindowFunction, ParametersNullabilityType.NotNullable, null);

		/// <summary>
		/// Replaces Take/Skip by ROWNUM usage.
		/// See <a href="https://blogs.oracle.com/oraclemagazine/on-rownum-and-limiting-results">'Pagination with ROWNUM'</a> for more information.
		/// </summary>
		/// <param name="statement">Statement which may contain take/skip modifiers.</param>
		/// <param name="onlySubqueries">Indicates when transformation needed only for subqueries.</param>
		/// <returns>The same <paramref name="statement"/> or modified statement when optimization has been performed.</returns>
		protected SqlStatement ReplaceTakeSkipWithRowNum(SqlStatement statement, bool onlySubqueries)
		{
			return QueryHelper.WrapQuery(
				(object?)null,
				statement,
				static (_, query, _) =>
				{
					if (query.Select.TakeValue == null && query.Select.SkipValue == null)
						return 0;
					if (query.Select.SkipValue != null)
						return 2;

					if (query.Select.TakeValue != null && query.Select.OrderBy.IsEmpty && query.GroupBy.IsEmpty && !query.Select.IsDistinct)
					{
						query.Select.Where.EnsureConjunction().AddLessOrEqual(RowNumExpr, query.Select.TakeValue, CompareNulls.LikeSql);

						query.Select.Take(null, null);
						return 0;
					}

					return 1;
				},
				static (_, queries) =>
				{
					var query = queries[queries.Count - 1];
					var processingQuery = queries[queries.Count - 2];

					if (query.Select.SkipValue != null)
					{
						var rnColumn = processingQuery.Select.AddNewColumn(RowNumExpr);
						rnColumn.Alias = "RN";

						if (query.Select.TakeValue != null)
						{
							processingQuery.Where.EnsureConjunction().AddLessOrEqual(RowNumExpr, new SqlBinaryExpression(query.Select.SkipValue.SystemType!,
									query.Select.SkipValue, "+", query.Select.TakeValue), CompareNulls.LikeSql);
						}

						queries[queries.Count - 3].Where.SearchCondition.AddGreater(rnColumn, query.Select.SkipValue, CompareNulls.LikeSql);
					}
					else
					{
						processingQuery.Where.EnsureConjunction().AddLessOrEqual(RowNumExpr, query.Select.TakeValue!, CompareNulls.LikeSql);
					}

					query.Select.SkipValue = null;
					query.Select.Take(null, null);

				},
				allowMutation: true,
				withStack: false);
		}
	}
}
