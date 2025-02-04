// ---------------------------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by LinqToDB scaffolding tool (https://github.com/linq2db/linq2db).
// Changes to this file may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
// ---------------------------------------------------------------------------------------------------

using LinqToDB;
using LinqToDB.Mapping;
using LinqToDB.Tools.Comparers;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;

#pragma warning disable 1573, 1591
#nullable enable

namespace Cli.All.SqlServerNorthwind
{
	[Table("Products")]
	public class Product : IEquatable<Product>
	{
		[Column("ProductID"      , DataType = DataType.Int32   , DbType = "int"         , IsPrimaryKey = true, IsIdentity = true, SkipOnInsert = true, SkipOnUpdate = true)] public SqlInt32   ProductId       { get; set; } // int
		[Column("ProductName"    , DataType = DataType.NVarChar, DbType = "nvarchar(40)", Length       = 40                                                               )] public SqlString  ProductName     { get; set; } // nvarchar(40)
		[Column("SupplierID"     , DataType = DataType.Int32   , DbType = "int"                                                                                           )] public SqlInt32?  SupplierId      { get; set; } // int
		[Column("CategoryID"     , DataType = DataType.Int32   , DbType = "int"                                                                                           )] public SqlInt32?  CategoryId      { get; set; } // int
		[Column("QuantityPerUnit", DataType = DataType.NVarChar, DbType = "nvarchar(20)", Length       = 20                                                               )] public SqlString? QuantityPerUnit { get; set; } // nvarchar(20)
		[Column("UnitPrice"      , DataType = DataType.Money   , DbType = "money"                                                                                         )] public SqlMoney?  UnitPrice       { get; set; } // money
		[Column("UnitsInStock"   , DataType = DataType.Int16   , DbType = "smallint"                                                                                      )] public SqlInt16?  UnitsInStock    { get; set; } // smallint
		[Column("UnitsOnOrder"   , DataType = DataType.Int16   , DbType = "smallint"                                                                                      )] public SqlInt16?  UnitsOnOrder    { get; set; } // smallint
		[Column("ReorderLevel"   , DataType = DataType.Int16   , DbType = "smallint"                                                                                      )] public SqlInt16?  ReorderLevel    { get; set; } // smallint
		[Column("Discontinued"   , DataType = DataType.Boolean , DbType = "bit"                                                                                           )] public SqlBoolean Discontinued    { get; set; } // bit

		#region IEquatable<T> support
		private static readonly IEqualityComparer<Product> _equalityComparer = ComparerBuilder.GetEqualityComparer<Product>(c => c.ProductId);

		public bool Equals(Product? other)
		{
			return _equalityComparer.Equals(this, other!);
		}

		public override int GetHashCode()
		{
			return _equalityComparer.GetHashCode(this);
		}

		public override bool Equals(object? obj)
		{
			return Equals(obj as Product);
		}
		#endregion

		#region Associations
		/// <summary>
		/// FK_Order_Details_Products backreference
		/// </summary>
		[Association(ThisKey = nameof(ProductId), OtherKey = nameof(OrderDetail.ProductId))]
		public IEnumerable<OrderDetail> OrderDetails { get; set; } = null!;

		/// <summary>
		/// FK_Products_Categories
		/// </summary>
		[Association(ThisKey = nameof(CategoryId), OtherKey = nameof(SqlServerNorthwind.Category.CategoryId))]
		public Category? Category { get; set; }

		/// <summary>
		/// FK_Products_Suppliers
		/// </summary>
		[Association(ThisKey = nameof(SupplierId), OtherKey = nameof(SqlServerNorthwind.Supplier.SupplierId))]
		public Supplier? Supplier { get; set; }
		#endregion
	}
}
