// ---------------------------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by LinqToDB scaffolding tool (https://github.com/linq2db/linq2db).
// Changes to this file may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
// ---------------------------------------------------------------------------------------------------

using System;

#pragma warning disable 1573, 1591
#nullable enable

namespace Cli.Fluent.SqlServerNorthwind
{
	public class OrdersQry
	{
		public int       OrderId        { get; set; } // int
		public string?   CustomerId     { get; set; } // nchar(5)
		public int?      EmployeeId     { get; set; } // int
		public DateTime? OrderDate      { get; set; } // datetime
		public DateTime? RequiredDate   { get; set; } // datetime
		public DateTime? ShippedDate    { get; set; } // datetime
		public int?      ShipVia        { get; set; } // int
		public decimal?  Freight        { get; set; } // money
		public string?   ShipName       { get; set; } // nvarchar(40)
		public string?   ShipAddress    { get; set; } // nvarchar(60)
		public string?   ShipCity       { get; set; } // nvarchar(15)
		public string?   ShipRegion     { get; set; } // nvarchar(15)
		public string?   ShipPostalCode { get; set; } // nvarchar(10)
		public string?   ShipCountry    { get; set; } // nvarchar(15)
		public string    CompanyName    { get; set; } = null!; // nvarchar(40)
		public string?   Address        { get; set; } // nvarchar(60)
		public string?   City           { get; set; } // nvarchar(15)
		public string?   Region         { get; set; } // nvarchar(15)
		public string?   PostalCode     { get; set; } // nvarchar(10)
		public string?   Country        { get; set; } // nvarchar(15)
	}
}
