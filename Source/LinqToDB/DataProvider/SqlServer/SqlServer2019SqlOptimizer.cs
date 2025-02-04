﻿namespace LinqToDB.DataProvider.SqlServer
{
	using SqlProvider;

	class SqlServer2019SqlOptimizer : SqlServer2012SqlOptimizer
	{
		public SqlServer2019SqlOptimizer(SqlProviderFlags sqlProviderFlags) : base(sqlProviderFlags, SqlServerVersion.v2019)
		{
		}

		protected SqlServer2019SqlOptimizer(SqlProviderFlags sqlProviderFlags, SqlServerVersion version) : base(sqlProviderFlags, version)
		{
		}
	}
}
