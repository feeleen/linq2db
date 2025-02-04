// ---------------------------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by LinqToDB scaffolding tool (https://github.com/linq2db/linq2db).
// Changes to this file may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
// ---------------------------------------------------------------------------------------------------

using LinqToDB;
using LinqToDB.Mapping;
using System.Data.SqlTypes;

#pragma warning disable 1573, 1591
#nullable enable

namespace Cli.All.SqlServerNorthwind
{
	[Table("Sales Totals by Amount", IsView = true)]
	public class SalesTotalsByAmount
	{
		[Column("SaleAmount" , DataType = DataType.Money   , DbType = "money"                    )] public SqlMoney?    SaleAmount  { get; set; } // money
		[Column("OrderID"    , DataType = DataType.Int32   , DbType = "int"                      )] public SqlInt32     OrderId     { get; set; } // int
		[Column("CompanyName", DataType = DataType.NVarChar, DbType = "nvarchar(40)", Length = 40)] public SqlString    CompanyName { get; set; } // nvarchar(40)
		[Column("ShippedDate", DataType = DataType.DateTime, DbType = "datetime"                 )] public SqlDateTime? ShippedDate { get; set; } // datetime
	}
}
