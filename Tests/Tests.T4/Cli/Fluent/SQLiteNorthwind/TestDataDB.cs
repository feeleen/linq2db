// ---------------------------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by LinqToDB scaffolding tool (https://github.com/linq2db/linq2db).
// Changes to this file may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
// ---------------------------------------------------------------------------------------------------

using LinqToDB;
using LinqToDB.Data;
using LinqToDB.Mapping;

#pragma warning disable 1573, 1591
#nullable enable

namespace Cli.Fluent.SQLiteNorthwind
{
	public partial class TestDataDB : DataConnection
	{
		static TestDataDB()
		{
			var builder = new FluentMappingBuilder(ContextSchema);

			builder
				.Entity<Category>()
					.HasAttribute(new TableAttribute("Categories"))
					.Member(e => e.CategoryId)
						.HasAttribute(new ColumnAttribute("CategoryID")
						{
							IsPrimaryKey = true
						})
					.Member(e => e.CategoryName)
						.HasAttribute(new ColumnAttribute("CategoryName")
						{
							CanBeNull = false
						})
					.Member(e => e.Description)
						.HasAttribute(new ColumnAttribute("Description"))
					.Member(e => e.Picture)
						.HasAttribute(new ColumnAttribute("Picture"));

			builder
				.Entity<CustomerCustomerDemo>()
					.HasAttribute(new TableAttribute("CustomerCustomerDemo"))
					.Member(e => e.CustomerId)
						.HasAttribute(new ColumnAttribute("CustomerID")
						{
							CanBeNull = false,
							IsPrimaryKey = true,
							PrimaryKeyOrder = 0
						})
					.Member(e => e.CustomerTypeId)
						.HasAttribute(new ColumnAttribute("CustomerTypeID")
						{
							CanBeNull = false,
							IsPrimaryKey = true,
							PrimaryKeyOrder = 1
						});

			builder
				.Entity<CustomerDemographic>()
					.HasAttribute(new TableAttribute("CustomerDemographics"))
					.Member(e => e.CustomerTypeId)
						.HasAttribute(new ColumnAttribute("CustomerTypeID")
						{
							CanBeNull = false,
							IsPrimaryKey = true
						})
					.Member(e => e.CustomerDesc)
						.HasAttribute(new ColumnAttribute("CustomerDesc"));

			builder
				.Entity<Customer>()
					.HasAttribute(new TableAttribute("Customers"))
					.Member(e => e.CustomerId)
						.HasAttribute(new ColumnAttribute("CustomerID")
						{
							CanBeNull = false,
							IsPrimaryKey = true
						})
					.Member(e => e.CompanyName)
						.HasAttribute(new ColumnAttribute("CompanyName")
						{
							CanBeNull = false
						})
					.Member(e => e.ContactName)
						.HasAttribute(new ColumnAttribute("ContactName"))
					.Member(e => e.ContactTitle)
						.HasAttribute(new ColumnAttribute("ContactTitle"))
					.Member(e => e.Address)
						.HasAttribute(new ColumnAttribute("Address"))
					.Member(e => e.City)
						.HasAttribute(new ColumnAttribute("City"))
					.Member(e => e.Region)
						.HasAttribute(new ColumnAttribute("Region"))
					.Member(e => e.PostalCode)
						.HasAttribute(new ColumnAttribute("PostalCode"))
					.Member(e => e.Country)
						.HasAttribute(new ColumnAttribute("Country"))
					.Member(e => e.Phone)
						.HasAttribute(new ColumnAttribute("Phone"))
					.Member(e => e.Fax)
						.HasAttribute(new ColumnAttribute("Fax"));

			builder
				.Entity<EmployeeTerritory>()
					.HasAttribute(new TableAttribute("EmployeeTerritories"))
					.Member(e => e.EmployeeId)
						.HasAttribute(new ColumnAttribute("EmployeeID")
						{
							IsPrimaryKey = true,
							PrimaryKeyOrder = 0
						})
					.Member(e => e.TerritoryId)
						.HasAttribute(new ColumnAttribute("TerritoryID")
						{
							CanBeNull = false,
							IsPrimaryKey = true,
							PrimaryKeyOrder = 1
						});

			builder
				.Entity<Employee>()
					.HasAttribute(new TableAttribute("Employees"))
					.Member(e => e.EmployeeId)
						.HasAttribute(new ColumnAttribute("EmployeeID")
						{
							IsPrimaryKey = true
						})
					.Member(e => e.LastName)
						.HasAttribute(new ColumnAttribute("LastName")
						{
							CanBeNull = false
						})
					.Member(e => e.FirstName)
						.HasAttribute(new ColumnAttribute("FirstName")
						{
							CanBeNull = false
						})
					.Member(e => e.Title)
						.HasAttribute(new ColumnAttribute("Title"))
					.Member(e => e.TitleOfCourtesy)
						.HasAttribute(new ColumnAttribute("TitleOfCourtesy"))
					.Member(e => e.BirthDate)
						.HasAttribute(new ColumnAttribute("BirthDate")
						{
							SkipOnInsert = true,
							SkipOnUpdate = true
						})
					.Member(e => e.HireDate)
						.HasAttribute(new ColumnAttribute("HireDate")
						{
							SkipOnInsert = true,
							SkipOnUpdate = true
						})
					.Member(e => e.Address)
						.HasAttribute(new ColumnAttribute("Address"))
					.Member(e => e.City)
						.HasAttribute(new ColumnAttribute("City"))
					.Member(e => e.Region)
						.HasAttribute(new ColumnAttribute("Region"))
					.Member(e => e.PostalCode)
						.HasAttribute(new ColumnAttribute("PostalCode"))
					.Member(e => e.Country)
						.HasAttribute(new ColumnAttribute("Country"))
					.Member(e => e.HomePhone)
						.HasAttribute(new ColumnAttribute("HomePhone"))
					.Member(e => e.Extension)
						.HasAttribute(new ColumnAttribute("Extension"))
					.Member(e => e.Photo)
						.HasAttribute(new ColumnAttribute("Photo"))
					.Member(e => e.Notes)
						.HasAttribute(new ColumnAttribute("Notes"))
					.Member(e => e.ReportsTo)
						.HasAttribute(new ColumnAttribute("ReportsTo"))
					.Member(e => e.PhotoPath)
						.HasAttribute(new ColumnAttribute("PhotoPath"));

			builder
				.Entity<OrderDetail>()
					.HasAttribute(new TableAttribute("Order Details"))
					.Member(e => e.OrderId)
						.HasAttribute(new ColumnAttribute("OrderID")
						{
							IsPrimaryKey = true,
							PrimaryKeyOrder = 0
						})
					.Member(e => e.ProductId)
						.HasAttribute(new ColumnAttribute("ProductID")
						{
							IsPrimaryKey = true,
							PrimaryKeyOrder = 1
						})
					.Member(e => e.UnitPrice)
						.HasAttribute(new ColumnAttribute("UnitPrice"))
					.Member(e => e.Quantity)
						.HasAttribute(new ColumnAttribute("Quantity"))
					.Member(e => e.Discount)
						.HasAttribute(new ColumnAttribute("Discount"));

			builder
				.Entity<Order>()
					.HasAttribute(new TableAttribute("Orders"))
					.Member(e => e.OrderId)
						.HasAttribute(new ColumnAttribute("OrderID")
						{
							IsPrimaryKey = true
						})
					.Member(e => e.CustomerId)
						.HasAttribute(new ColumnAttribute("CustomerID"))
					.Member(e => e.EmployeeId)
						.HasAttribute(new ColumnAttribute("EmployeeID"))
					.Member(e => e.OrderDate)
						.HasAttribute(new ColumnAttribute("OrderDate")
						{
							SkipOnInsert = true,
							SkipOnUpdate = true
						})
					.Member(e => e.RequiredDate)
						.HasAttribute(new ColumnAttribute("RequiredDate")
						{
							SkipOnInsert = true,
							SkipOnUpdate = true
						})
					.Member(e => e.ShippedDate)
						.HasAttribute(new ColumnAttribute("ShippedDate")
						{
							SkipOnInsert = true,
							SkipOnUpdate = true
						})
					.Member(e => e.ShipVia)
						.HasAttribute(new ColumnAttribute("ShipVia"))
					.Member(e => e.Freight)
						.HasAttribute(new ColumnAttribute("Freight"))
					.Member(e => e.ShipName)
						.HasAttribute(new ColumnAttribute("ShipName"))
					.Member(e => e.ShipAddress)
						.HasAttribute(new ColumnAttribute("ShipAddress"))
					.Member(e => e.ShipCity)
						.HasAttribute(new ColumnAttribute("ShipCity"))
					.Member(e => e.ShipRegion)
						.HasAttribute(new ColumnAttribute("ShipRegion"))
					.Member(e => e.ShipPostalCode)
						.HasAttribute(new ColumnAttribute("ShipPostalCode"))
					.Member(e => e.ShipCountry)
						.HasAttribute(new ColumnAttribute("ShipCountry"));

			builder
				.Entity<Product>()
					.HasAttribute(new TableAttribute("Products"))
					.Member(e => e.ProductId)
						.HasAttribute(new ColumnAttribute("ProductID")
						{
							IsPrimaryKey = true
						})
					.Member(e => e.ProductName)
						.HasAttribute(new ColumnAttribute("ProductName")
						{
							CanBeNull = false
						})
					.Member(e => e.SupplierId)
						.HasAttribute(new ColumnAttribute("SupplierID"))
					.Member(e => e.CategoryId)
						.HasAttribute(new ColumnAttribute("CategoryID"))
					.Member(e => e.QuantityPerUnit)
						.HasAttribute(new ColumnAttribute("QuantityPerUnit"))
					.Member(e => e.UnitPrice)
						.HasAttribute(new ColumnAttribute("UnitPrice"))
					.Member(e => e.UnitsInStock)
						.HasAttribute(new ColumnAttribute("UnitsInStock"))
					.Member(e => e.UnitsOnOrder)
						.HasAttribute(new ColumnAttribute("UnitsOnOrder"))
					.Member(e => e.ReorderLevel)
						.HasAttribute(new ColumnAttribute("ReorderLevel"))
					.Member(e => e.Discontinued)
						.HasAttribute(new ColumnAttribute("Discontinued"));

			builder
				.Entity<Region>()
					.HasAttribute(new TableAttribute("Region"))
					.Member(e => e.RegionId)
						.HasAttribute(new ColumnAttribute("RegionID")
						{
							IsPrimaryKey = true
						})
					.Member(e => e.RegionDescription)
						.HasAttribute(new ColumnAttribute("RegionDescription")
						{
							CanBeNull = false
						});

			builder
				.Entity<Shipper>()
					.HasAttribute(new TableAttribute("Shippers"))
					.Member(e => e.ShipperId)
						.HasAttribute(new ColumnAttribute("ShipperID")
						{
							IsPrimaryKey = true
						})
					.Member(e => e.CompanyName)
						.HasAttribute(new ColumnAttribute("CompanyName")
						{
							CanBeNull = false
						})
					.Member(e => e.Phone)
						.HasAttribute(new ColumnAttribute("Phone"));

			builder
				.Entity<Supplier>()
					.HasAttribute(new TableAttribute("Suppliers"))
					.Member(e => e.SupplierId)
						.HasAttribute(new ColumnAttribute("SupplierID")
						{
							IsPrimaryKey = true
						})
					.Member(e => e.CompanyName)
						.HasAttribute(new ColumnAttribute("CompanyName")
						{
							CanBeNull = false
						})
					.Member(e => e.ContactName)
						.HasAttribute(new ColumnAttribute("ContactName"))
					.Member(e => e.ContactTitle)
						.HasAttribute(new ColumnAttribute("ContactTitle"))
					.Member(e => e.Address)
						.HasAttribute(new ColumnAttribute("Address"))
					.Member(e => e.City)
						.HasAttribute(new ColumnAttribute("City"))
					.Member(e => e.Region)
						.HasAttribute(new ColumnAttribute("Region"))
					.Member(e => e.PostalCode)
						.HasAttribute(new ColumnAttribute("PostalCode"))
					.Member(e => e.Country)
						.HasAttribute(new ColumnAttribute("Country"))
					.Member(e => e.Phone)
						.HasAttribute(new ColumnAttribute("Phone"))
					.Member(e => e.Fax)
						.HasAttribute(new ColumnAttribute("Fax"))
					.Member(e => e.HomePage)
						.HasAttribute(new ColumnAttribute("HomePage"));

			builder
				.Entity<Territory>()
					.HasAttribute(new TableAttribute("Territories"))
					.Member(e => e.TerritoryId)
						.HasAttribute(new ColumnAttribute("TerritoryID")
						{
							CanBeNull = false,
							IsPrimaryKey = true
						})
					.Member(e => e.TerritoryDescription)
						.HasAttribute(new ColumnAttribute("TerritoryDescription")
						{
							CanBeNull = false
						})
					.Member(e => e.RegionId)
						.HasAttribute(new ColumnAttribute("RegionID"));

			builder
				.Entity<AlphabeticalListOfProduct>()
					.HasAttribute(new TableAttribute("Alphabetical list of products")
					{
						IsView = true
					})
					.Member(e => e.ProductId)
						.HasAttribute(new ColumnAttribute("ProductID"))
					.Member(e => e.ProductName)
						.HasAttribute(new ColumnAttribute("ProductName")
						{
							CanBeNull = false
						})
					.Member(e => e.SupplierId)
						.HasAttribute(new ColumnAttribute("SupplierID"))
					.Member(e => e.CategoryId)
						.HasAttribute(new ColumnAttribute("CategoryID"))
					.Member(e => e.QuantityPerUnit)
						.HasAttribute(new ColumnAttribute("QuantityPerUnit"))
					.Member(e => e.UnitPrice)
						.HasAttribute(new ColumnAttribute("UnitPrice"))
					.Member(e => e.UnitsInStock)
						.HasAttribute(new ColumnAttribute("UnitsInStock"))
					.Member(e => e.UnitsOnOrder)
						.HasAttribute(new ColumnAttribute("UnitsOnOrder"))
					.Member(e => e.ReorderLevel)
						.HasAttribute(new ColumnAttribute("ReorderLevel"))
					.Member(e => e.Discontinued)
						.HasAttribute(new ColumnAttribute("Discontinued"))
					.Member(e => e.CategoryName)
						.HasAttribute(new ColumnAttribute("CategoryName")
						{
							CanBeNull = false
						});

			builder
				.Entity<CurrentProductList>()
					.HasAttribute(new TableAttribute("Current Product List")
					{
						IsView = true
					})
					.Member(e => e.ProductId)
						.HasAttribute(new ColumnAttribute("ProductID"))
					.Member(e => e.ProductName)
						.HasAttribute(new ColumnAttribute("ProductName")
						{
							CanBeNull = false
						});

			builder
				.Entity<CustomerAndSuppliersByCity>()
					.HasAttribute(new TableAttribute("Customer and Suppliers by City")
					{
						IsView = true
					})
					.Member(e => e.City)
						.HasAttribute(new ColumnAttribute("City"))
					.Member(e => e.CompanyName)
						.HasAttribute(new ColumnAttribute("CompanyName")
						{
							CanBeNull = false
						})
					.Member(e => e.ContactName)
						.HasAttribute(new ColumnAttribute("ContactName"))
					.Member(e => e.Relationship)
						.HasAttribute(new ColumnAttribute("Relationship"));

			builder
				.Entity<OrderDetailsExtended>()
					.HasAttribute(new TableAttribute("Order Details Extended")
					{
						IsView = true
					})
					.Member(e => e.OrderId)
						.HasAttribute(new ColumnAttribute("OrderID"))
					.Member(e => e.ProductId)
						.HasAttribute(new ColumnAttribute("ProductID"))
					.Member(e => e.ProductName)
						.HasAttribute(new ColumnAttribute("ProductName")
						{
							CanBeNull = false
						})
					.Member(e => e.UnitPrice)
						.HasAttribute(new ColumnAttribute("UnitPrice"))
					.Member(e => e.Quantity)
						.HasAttribute(new ColumnAttribute("Quantity"))
					.Member(e => e.Discount)
						.HasAttribute(new ColumnAttribute("Discount"))
					.Member(e => e.ExtendedPrice)
						.HasAttribute(new ColumnAttribute("ExtendedPrice"));

			builder
				.Entity<OrderSubtotal>()
					.HasAttribute(new TableAttribute("Order Subtotals")
					{
						IsView = true
					})
					.Member(e => e.OrderId)
						.HasAttribute(new ColumnAttribute("OrderID"))
					.Member(e => e.Subtotal)
						.HasAttribute(new ColumnAttribute("Subtotal"));

			builder
				.Entity<OrdersQry>()
					.HasAttribute(new TableAttribute("Orders Qry")
					{
						IsView = true
					})
					.Member(e => e.OrderId)
						.HasAttribute(new ColumnAttribute("OrderID"))
					.Member(e => e.CustomerId)
						.HasAttribute(new ColumnAttribute("CustomerID"))
					.Member(e => e.EmployeeId)
						.HasAttribute(new ColumnAttribute("EmployeeID"))
					.Member(e => e.OrderDate)
						.HasAttribute(new ColumnAttribute("OrderDate")
						{
							SkipOnInsert = true,
							SkipOnUpdate = true
						})
					.Member(e => e.RequiredDate)
						.HasAttribute(new ColumnAttribute("RequiredDate")
						{
							SkipOnInsert = true,
							SkipOnUpdate = true
						})
					.Member(e => e.ShippedDate)
						.HasAttribute(new ColumnAttribute("ShippedDate")
						{
							SkipOnInsert = true,
							SkipOnUpdate = true
						})
					.Member(e => e.ShipVia)
						.HasAttribute(new ColumnAttribute("ShipVia"))
					.Member(e => e.Freight)
						.HasAttribute(new ColumnAttribute("Freight"))
					.Member(e => e.ShipName)
						.HasAttribute(new ColumnAttribute("ShipName"))
					.Member(e => e.ShipAddress)
						.HasAttribute(new ColumnAttribute("ShipAddress"))
					.Member(e => e.ShipCity)
						.HasAttribute(new ColumnAttribute("ShipCity"))
					.Member(e => e.ShipRegion)
						.HasAttribute(new ColumnAttribute("ShipRegion"))
					.Member(e => e.ShipPostalCode)
						.HasAttribute(new ColumnAttribute("ShipPostalCode"))
					.Member(e => e.ShipCountry)
						.HasAttribute(new ColumnAttribute("ShipCountry"))
					.Member(e => e.CompanyName)
						.HasAttribute(new ColumnAttribute("CompanyName")
						{
							CanBeNull = false
						})
					.Member(e => e.Address)
						.HasAttribute(new ColumnAttribute("Address"))
					.Member(e => e.City)
						.HasAttribute(new ColumnAttribute("City"))
					.Member(e => e.Region)
						.HasAttribute(new ColumnAttribute("Region"))
					.Member(e => e.PostalCode)
						.HasAttribute(new ColumnAttribute("PostalCode"))
					.Member(e => e.Country)
						.HasAttribute(new ColumnAttribute("Country"));

			builder
				.Entity<ProductsAboveAveragePrice>()
					.HasAttribute(new TableAttribute("Products Above Average Price")
					{
						IsView = true
					})
					.Member(e => e.ProductName)
						.HasAttribute(new ColumnAttribute("ProductName")
						{
							CanBeNull = false
						})
					.Member(e => e.UnitPrice)
						.HasAttribute(new ColumnAttribute("UnitPrice"));

			builder
				.Entity<ProductsByCategory>()
					.HasAttribute(new TableAttribute("Products by Category")
					{
						IsView = true
					})
					.Member(e => e.CategoryName)
						.HasAttribute(new ColumnAttribute("CategoryName")
						{
							CanBeNull = false
						})
					.Member(e => e.ProductName)
						.HasAttribute(new ColumnAttribute("ProductName")
						{
							CanBeNull = false
						})
					.Member(e => e.QuantityPerUnit)
						.HasAttribute(new ColumnAttribute("QuantityPerUnit"))
					.Member(e => e.UnitsInStock)
						.HasAttribute(new ColumnAttribute("UnitsInStock"))
					.Member(e => e.Discontinued)
						.HasAttribute(new ColumnAttribute("Discontinued"));

			builder
				.Entity<SummaryOfSalesByQuarter>()
					.HasAttribute(new TableAttribute("Summary of Sales by Quarter")
					{
						IsView = true
					})
					.Member(e => e.ShippedDate)
						.HasAttribute(new ColumnAttribute("ShippedDate")
						{
							SkipOnInsert = true,
							SkipOnUpdate = true
						})
					.Member(e => e.OrderId)
						.HasAttribute(new ColumnAttribute("OrderID"))
					.Member(e => e.Subtotal)
						.HasAttribute(new ColumnAttribute("Subtotal"));

			builder
				.Entity<SummaryOfSalesByYear>()
					.HasAttribute(new TableAttribute("Summary of Sales by Year")
					{
						IsView = true
					})
					.Member(e => e.ShippedDate)
						.HasAttribute(new ColumnAttribute("ShippedDate")
						{
							SkipOnInsert = true,
							SkipOnUpdate = true
						})
					.Member(e => e.OrderId)
						.HasAttribute(new ColumnAttribute("OrderID"))
					.Member(e => e.Subtotal)
						.HasAttribute(new ColumnAttribute("Subtotal"));

			builder.Build();
		}
		public static MappingSchema ContextSchema { get; } = new MappingSchema();

		public TestDataDB()
			: base(new DataOptions().UseMappingSchema(ContextSchema))
		{
			InitDataContext();
		}

		public TestDataDB(string configuration)
			: base(new DataOptions().UseConfiguration(configuration, ContextSchema))
		{
			InitDataContext();
		}

		public TestDataDB(DataOptions<TestDataDB> options)
			: base(options.Options.UseMappingSchema(options.Options.ConnectionOptions.MappingSchema == null ? ContextSchema : MappingSchema.CombineSchemas(options.Options.ConnectionOptions.MappingSchema, ContextSchema)))
		{
			InitDataContext();
		}

		partial void InitDataContext();

		public ITable<Category>                   Categories                   => this.GetTable<Category>();
		public ITable<CustomerCustomerDemo>       CustomerCustomerDemos        => this.GetTable<CustomerCustomerDemo>();
		public ITable<CustomerDemographic>        CustomerDemographics         => this.GetTable<CustomerDemographic>();
		public ITable<Customer>                   Customers                    => this.GetTable<Customer>();
		public ITable<EmployeeTerritory>          EmployeeTerritories          => this.GetTable<EmployeeTerritory>();
		public ITable<Employee>                   Employees                    => this.GetTable<Employee>();
		public ITable<OrderDetail>                OrderDetails                 => this.GetTable<OrderDetail>();
		public ITable<Order>                      Orders                       => this.GetTable<Order>();
		public ITable<Product>                    Products                     => this.GetTable<Product>();
		public ITable<Region>                     Regions                      => this.GetTable<Region>();
		public ITable<Shipper>                    Shippers                     => this.GetTable<Shipper>();
		public ITable<Supplier>                   Suppliers                    => this.GetTable<Supplier>();
		public ITable<Territory>                  Territories                  => this.GetTable<Territory>();
		public ITable<AlphabeticalListOfProduct>  AlphabeticalListOfProducts   => this.GetTable<AlphabeticalListOfProduct>();
		public ITable<CurrentProductList>         CurrentProductLists          => this.GetTable<CurrentProductList>();
		public ITable<CustomerAndSuppliersByCity> CustomerAndSuppliersByCities => this.GetTable<CustomerAndSuppliersByCity>();
		public ITable<OrderDetailsExtended>       OrderDetailsExtendeds        => this.GetTable<OrderDetailsExtended>();
		public ITable<OrderSubtotal>              OrderSubtotals               => this.GetTable<OrderSubtotal>();
		public ITable<OrdersQry>                  OrdersQries                  => this.GetTable<OrdersQry>();
		public ITable<ProductsAboveAveragePrice>  ProductsAboveAveragePrices   => this.GetTable<ProductsAboveAveragePrice>();
		public ITable<ProductsByCategory>         ProductsByCategories         => this.GetTable<ProductsByCategory>();
		public ITable<SummaryOfSalesByQuarter>    SummaryOfSalesByQuarters     => this.GetTable<SummaryOfSalesByQuarter>();
		public ITable<SummaryOfSalesByYear>       SummaryOfSalesByYears        => this.GetTable<SummaryOfSalesByYear>();
	}
}
