﻿//---------------------------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated by T4Model template for T4 (https://github.com/linq2db/linq2db).
//    Changes to this file may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
//---------------------------------------------------------------------------------------------------

#pragma warning disable 1573, 1591
#nullable enable

using System;
using System.Linq;

using LinqToDB;
using LinqToDB.Configuration;
using LinqToDB.Mapping;

namespace SqlCeDataContext
{
	public partial class TestDataDB : LinqToDB.Data.DataConnection
	{
		#region Tables

		public ITable<AllType>           AllTypes            { get { return this.GetTable<AllType>(); } }
		public ITable<Child>             Children            { get { return this.GetTable<Child>(); } }
		public ITable<DataType>          DataTypes           { get { return this.GetTable<DataType>(); } }
		public ITable<Doctor>            Doctors             { get { return this.GetTable<Doctor>(); } }
		public ITable<GrandChild>        GrandChildren       { get { return this.GetTable<GrandChild>(); } }
		public ITable<InheritanceChild>  InheritanceChildren { get { return this.GetTable<InheritanceChild>(); } }
		public ITable<InheritanceParent> InheritanceParents  { get { return this.GetTable<InheritanceParent>(); } }
		public ITable<Issue695>          Issue695s           { get { return this.GetTable<Issue695>(); } }
		public ITable<Issue695Parent>    Issue695Parents     { get { return this.GetTable<Issue695Parent>(); } }
		public ITable<LinqDataType>      LinqDataTypes       { get { return this.GetTable<LinqDataType>(); } }
		public ITable<Parent>            Parents             { get { return this.GetTable<Parent>(); } }
		public ITable<Patient>           Patients            { get { return this.GetTable<Patient>(); } }
		public ITable<Person>            People              { get { return this.GetTable<Person>(); } }
		public ITable<TestIdentity>      TestIdentities      { get { return this.GetTable<TestIdentity>(); } }
		public ITable<TestMerge1>        TestMerge1s         { get { return this.GetTable<TestMerge1>(); } }
		public ITable<TestMerge2>        TestMerge2s         { get { return this.GetTable<TestMerge2>(); } }

		#endregion

		#region .ctor

		public TestDataDB()
		{
			InitDataContext();
			InitMappingSchema();
		}

		public TestDataDB(string configuration)
			: base(configuration)
		{
			InitDataContext();
			InitMappingSchema();
		}

		partial void InitDataContext  ();
		partial void InitMappingSchema();

		#endregion
	}

	[Table("AllTypes")]
	public partial class AllType
	{
		[Column(),                           PrimaryKey,  NotNull] public int       ID                       { get; set; } // int
		[Column("bigintDataType"),              Nullable         ] public long?     BigintDataType           { get; set; } // bigint
		[Column("numericDataType"),             Nullable         ] public decimal?  NumericDataType          { get; set; } // numeric(18, 0)
		[Column("bitDataType"),                 Nullable         ] public bool?     BitDataType              { get; set; } // bit
		[Column("smallintDataType"),            Nullable         ] public short?    SmallintDataType         { get; set; } // smallint
		[Column("decimalDataType"),             Nullable         ] public decimal?  DecimalDataType          { get; set; } // numeric(18, 0)
		[Column("intDataType"),                 Nullable         ] public int?      IntDataType              { get; set; } // int
		[Column("tinyintDataType"),             Nullable         ] public byte?     TinyintDataType          { get; set; } // tinyint
		[Column("moneyDataType"),               Nullable         ] public decimal?  MoneyDataType            { get; set; } // money
		[Column("floatDataType"),               Nullable         ] public double?   FloatDataType            { get; set; } // float
		[Column("realDataType"),                Nullable         ] public float?    RealDataType             { get; set; } // real
		[Column("datetimeDataType"),            Nullable         ] public DateTime? DatetimeDataType         { get; set; } // datetime
		[Column("ncharDataType"),               Nullable         ] public string?   NcharDataType            { get; set; } // nchar(20)
		[Column("nvarcharDataType"),            Nullable         ] public string?   NvarcharDataType         { get; set; } // nvarchar(20)
		[Column("ntextDataType"),               Nullable         ] public string?   NtextDataType            { get; set; } // ntext
		[Column("binaryDataType"),              Nullable         ] public byte[]?   BinaryDataType           { get; set; } // binary(1)
		[Column("varbinaryDataType"),           Nullable         ] public byte[]?   VarbinaryDataType        { get; set; } // varbinary(1)
		[Column("imageDataType"),               Nullable         ] public byte[]?   ImageDataType            { get; set; } // image
		[Column("timestampDataType"),           Nullable         ] public byte[]?   TimestampDataType        { get; set; } // rowversion
		[Column("uniqueidentifierDataType"),    Nullable         ] public Guid?     UniqueidentifierDataType { get; set; } // uniqueidentifier
	}

	[Table("Child")]
	public partial class Child
	{
		[Column, Nullable] public int? ParentID { get; set; } // int
		[Column, Nullable] public int? ChildID  { get; set; } // int
	}

	[Table("DataTypes")]
	public partial class DataType
	{
		[Column, Nullable] public int?     ID         { get; set; } // int
		[Column, Nullable] public decimal? MoneyValue { get; set; } // numeric(10, 4)
	}

	[Table("Doctor")]
	public partial class Doctor
	{
		[PrimaryKey, NotNull] public int    PersonID { get; set; } // int
		[Column,     NotNull] public string Taxonomy { get; set; } = null!; // nvarchar(50)

		#region Associations

		/// <summary>
		/// FK_Doctor_Person (Person)
		/// </summary>
		[Association(ThisKey=nameof(SqlCeDataContext.Doctor.PersonID), OtherKey=nameof(SqlCeDataContext.Person.PersonID), CanBeNull=false)]
		public Person Person { get; set; } = null!;

		#endregion
	}

	[Table("GrandChild")]
	public partial class GrandChild
	{
		[Column, Nullable] public int? ParentID     { get; set; } // int
		[Column, Nullable] public int? ChildID      { get; set; } // int
		[Column, Nullable] public int? GrandChildID { get; set; } // int
	}

	[Table("InheritanceChild")]
	public partial class InheritanceChild
	{
		[PrimaryKey, NotNull    ] public int     InheritanceChildId  { get; set; } // int
		[Column,     NotNull    ] public int     InheritanceParentId { get; set; } // int
		[Column,        Nullable] public int?    TypeDiscriminator   { get; set; } // int
		[Column,        Nullable] public string? Name                { get; set; } // nvarchar(50)
	}

	[Table("InheritanceParent")]
	public partial class InheritanceParent
	{
		[PrimaryKey, NotNull    ] public int     InheritanceParentId { get; set; } // int
		[Column,        Nullable] public int?    TypeDiscriminator   { get; set; } // int
		[Column,        Nullable] public string? Name                { get; set; } // nvarchar(50)
	}

	[Table("Issue695")]
	public partial class Issue695
	{
		[PrimaryKey, NotNull] public int ID          { get; set; } // int
		[Column,     NotNull] public int UniqueValue { get; set; } // int

		#region Associations

		/// <summary>
		/// FK_Issue695_Parent (Issue695Parent)
		/// </summary>
		[Association(ThisKey=nameof(SqlCeDataContext.Issue695.ID), OtherKey=nameof(SqlCeDataContext.Issue695Parent.ID), CanBeNull=false)]
		public Issue695Parent Issue695Parent { get; set; } = null!;

		#endregion
	}

	[Table("Issue695Parent")]
	public partial class Issue695Parent
	{
		[PrimaryKey, NotNull] public int ID { get; set; } // int

		#region Associations

		/// <summary>
		/// FK_Issue695_Parent_BackReference (Issue695)
		/// </summary>
		[Association(ThisKey=nameof(SqlCeDataContext.Issue695Parent.ID), OtherKey=nameof(SqlCeDataContext.Issue695.ID), CanBeNull=true)]
		public Issue695? FKIssue695ParentBackReference { get; set; }

		#endregion
	}

	[Table("LinqDataTypes")]
	public partial class LinqDataType
	{
		[Column, Nullable] public int?      ID             { get; set; } // int
		[Column, Nullable] public decimal?  MoneyValue     { get; set; } // numeric(10, 4)
		[Column, Nullable] public DateTime? DateTimeValue  { get; set; } // datetime
		[Column, Nullable] public DateTime? DateTimeValue2 { get; set; } // datetime
		[Column, Nullable] public bool?     BoolValue      { get; set; } // bit
		[Column, Nullable] public Guid?     GuidValue      { get; set; } // uniqueidentifier
		[Column, Nullable] public byte[]?   BinaryValue    { get; set; } // varbinary(5000)
		[Column, Nullable] public short?    SmallIntValue  { get; set; } // smallint
		[Column, Nullable] public int?      IntValue       { get; set; } // int
		[Column, Nullable] public long?     BigIntValue    { get; set; } // bigint
		[Column, Nullable] public string?   StringValue    { get; set; } // nvarchar(50)
	}

	[Table("Parent")]
	public partial class Parent
	{
		[Column, Nullable] public int? ParentID { get; set; } // int
		[Column, Nullable] public int? Value1   { get; set; } // int
	}

	[Table("Patient")]
	public partial class Patient
	{
		[PrimaryKey, NotNull] public int    PersonID  { get; set; } // int
		[Column,     NotNull] public string Diagnosis { get; set; } = null!; // nvarchar(256)

		#region Associations

		/// <summary>
		/// FK_Patient_Person (Person)
		/// </summary>
		[Association(ThisKey=nameof(SqlCeDataContext.Patient.PersonID), OtherKey=nameof(SqlCeDataContext.Person.PersonID), CanBeNull=false)]
		public Person Person { get; set; } = null!;

		#endregion
	}

	[Table("Person")]
	public partial class Person
	{
		[PrimaryKey, NotNull    ] public int     PersonID   { get; set; } // int
		[Column,     NotNull    ] public string  FirstName  { get; set; } = null!; // nvarchar(50)
		[Column,     NotNull    ] public string  LastName   { get; set; } = null!; // nvarchar(50)
		[Column,        Nullable] public string? MiddleName { get; set; } // nvarchar(50)
		[Column,     NotNull    ] public char    Gender     { get; set; } // nchar(1)

		#region Associations

		/// <summary>
		/// FK_Doctor_Person_BackReference (Doctor)
		/// </summary>
		[Association(ThisKey=nameof(SqlCeDataContext.Person.PersonID), OtherKey=nameof(SqlCeDataContext.Doctor.PersonID), CanBeNull=true)]
		public Doctor? Doctor { get; set; }

		/// <summary>
		/// FK_Patient_Person_BackReference (Patient)
		/// </summary>
		[Association(ThisKey=nameof(SqlCeDataContext.Person.PersonID), OtherKey=nameof(SqlCeDataContext.Patient.PersonID), CanBeNull=true)]
		public Patient? Patient { get; set; }

		#endregion
	}

	[Table("TestIdentity")]
	public partial class TestIdentity
	{
		[PrimaryKey, NotNull] public int ID { get; set; } // int
	}

	[Table("TestMerge1")]
	public partial class TestMerge1
	{
		[PrimaryKey, NotNull    ] public int       Id              { get; set; } // int
		[Column,        Nullable] public int?      Field1          { get; set; } // int
		[Column,        Nullable] public int?      Field2          { get; set; } // int
		[Column,        Nullable] public int?      Field3          { get; set; } // int
		[Column,        Nullable] public int?      Field4          { get; set; } // int
		[Column,        Nullable] public int?      Field5          { get; set; } // int
		[Column,        Nullable] public long?     FieldInt64      { get; set; } // bigint
		[Column,        Nullable] public bool?     FieldBoolean    { get; set; } // bit
		[Column,        Nullable] public string?   FieldString     { get; set; } // nvarchar(20)
		[Column,        Nullable] public string?   FieldNString    { get; set; } // nvarchar(20)
		[Column,        Nullable] public char?     FieldChar       { get; set; } // nchar(1)
		[Column,        Nullable] public char?     FieldNChar      { get; set; } // nchar(1)
		[Column,        Nullable] public float?    FieldFloat      { get; set; } // real
		[Column,        Nullable] public double?   FieldDouble     { get; set; } // float
		[Column,        Nullable] public DateTime? FieldDateTime   { get; set; } // datetime
		[Column,        Nullable] public byte[]?   FieldBinary     { get; set; } // varbinary(20)
		[Column,        Nullable] public Guid?     FieldGuid       { get; set; } // uniqueidentifier
		[Column,        Nullable] public decimal?  FieldDecimal    { get; set; } // numeric(24, 10)
		[Column,        Nullable] public string?   FieldEnumString { get; set; } // nvarchar(20)
		[Column,        Nullable] public int?      FieldEnumNumber { get; set; } // int
	}

	[Table("TestMerge2")]
	public partial class TestMerge2
	{
		[PrimaryKey, NotNull    ] public int       Id              { get; set; } // int
		[Column,        Nullable] public int?      Field1          { get; set; } // int
		[Column,        Nullable] public int?      Field2          { get; set; } // int
		[Column,        Nullable] public int?      Field3          { get; set; } // int
		[Column,        Nullable] public int?      Field4          { get; set; } // int
		[Column,        Nullable] public int?      Field5          { get; set; } // int
		[Column,        Nullable] public long?     FieldInt64      { get; set; } // bigint
		[Column,        Nullable] public bool?     FieldBoolean    { get; set; } // bit
		[Column,        Nullable] public string?   FieldString     { get; set; } // nvarchar(20)
		[Column,        Nullable] public string?   FieldNString    { get; set; } // nvarchar(20)
		[Column,        Nullable] public char?     FieldChar       { get; set; } // nchar(1)
		[Column,        Nullable] public char?     FieldNChar      { get; set; } // nchar(1)
		[Column,        Nullable] public float?    FieldFloat      { get; set; } // real
		[Column,        Nullable] public double?   FieldDouble     { get; set; } // float
		[Column,        Nullable] public DateTime? FieldDateTime   { get; set; } // datetime
		[Column,        Nullable] public byte[]?   FieldBinary     { get; set; } // varbinary(20)
		[Column,        Nullable] public Guid?     FieldGuid       { get; set; } // uniqueidentifier
		[Column,        Nullable] public decimal?  FieldDecimal    { get; set; } // numeric(24, 10)
		[Column,        Nullable] public string?   FieldEnumString { get; set; } // nvarchar(20)
		[Column,        Nullable] public int?      FieldEnumNumber { get; set; } // int
	}

	public static partial class TableExtensions
	{
		public static AllType? Find(this ITable<AllType> table, int ID)
		{
			return table.FirstOrDefault(t =>
				t.ID == ID);
		}

		public static Doctor? Find(this ITable<Doctor> table, int PersonID)
		{
			return table.FirstOrDefault(t =>
				t.PersonID == PersonID);
		}

		public static InheritanceChild? Find(this ITable<InheritanceChild> table, int InheritanceChildId)
		{
			return table.FirstOrDefault(t =>
				t.InheritanceChildId == InheritanceChildId);
		}

		public static InheritanceParent? Find(this ITable<InheritanceParent> table, int InheritanceParentId)
		{
			return table.FirstOrDefault(t =>
				t.InheritanceParentId == InheritanceParentId);
		}

		public static Issue695? Find(this ITable<Issue695> table, int ID)
		{
			return table.FirstOrDefault(t =>
				t.ID == ID);
		}

		public static Issue695Parent? Find(this ITable<Issue695Parent> table, int ID)
		{
			return table.FirstOrDefault(t =>
				t.ID == ID);
		}

		public static Patient? Find(this ITable<Patient> table, int PersonID)
		{
			return table.FirstOrDefault(t =>
				t.PersonID == PersonID);
		}

		public static Person? Find(this ITable<Person> table, int PersonID)
		{
			return table.FirstOrDefault(t =>
				t.PersonID == PersonID);
		}

		public static TestIdentity? Find(this ITable<TestIdentity> table, int ID)
		{
			return table.FirstOrDefault(t =>
				t.ID == ID);
		}

		public static TestMerge1? Find(this ITable<TestMerge1> table, int Id)
		{
			return table.FirstOrDefault(t =>
				t.Id == Id);
		}

		public static TestMerge2? Find(this ITable<TestMerge2> table, int Id)
		{
			return table.FirstOrDefault(t =>
				t.Id == Id);
		}

		#region Associations

		#region Doctor Associations

		/// <summary>
		/// FK_Doctor_Person
		/// </summary>
		[Association(ThisKey=nameof(SqlCeDataContext.Doctor.PersonID), OtherKey=nameof(SqlCeDataContext.Person.PersonID), CanBeNull=false)]
		public static IQueryable<Person> People(this Doctor obj, IDataContext db)
		{
			return db.GetTable<Person>().Where(c => c.PersonID == obj.PersonID);
		}

		/// <summary>
		/// FK_Doctor_Person
		/// </summary>
		[Association(ThisKey=nameof(SqlCeDataContext.Doctor.PersonID), OtherKey=nameof(SqlCeDataContext.Person.PersonID), CanBeNull=false)]
		public static Doctor Person(this Person obj, IDataContext db)
		{
			return db.GetTable<Doctor>().Where(c => c.PersonID == obj.PersonID).First();
		}

		#endregion

		#region Issue695 Associations

		/// <summary>
		/// FK_Issue695_Parent
		/// </summary>
		[Association(ThisKey=nameof(SqlCeDataContext.Issue695.ID), OtherKey=nameof(SqlCeDataContext.Issue695Parent.ID), CanBeNull=false)]
		public static IQueryable<Issue695Parent> Issue695Parents(this Issue695 obj, IDataContext db)
		{
			return db.GetTable<Issue695Parent>().Where(c => c.ID == obj.ID);
		}

		/// <summary>
		/// FK_Issue695_Parent
		/// </summary>
		[Association(ThisKey=nameof(SqlCeDataContext.Issue695.ID), OtherKey=nameof(SqlCeDataContext.Issue695Parent.ID), CanBeNull=false)]
		public static Issue695 Issue695Parent(this Issue695Parent obj, IDataContext db)
		{
			return db.GetTable<Issue695>().Where(c => c.ID == obj.ID).First();
		}

		#endregion

		#region Issue695Parent Associations

		/// <summary>
		/// FK_Issue695_Parent_BackReference
		/// </summary>
		[Association(ThisKey=nameof(SqlCeDataContext.Issue695Parent.ID), OtherKey=nameof(SqlCeDataContext.Issue695.ID), CanBeNull=true)]
		public static IQueryable<Issue695> FKIssue695ParentBackReferences(this Issue695Parent obj, IDataContext db)
		{
			return db.GetTable<Issue695>().Where(c => c.ID == obj.ID);
		}

		/// <summary>
		/// FK_Issue695_Parent_BackReference
		/// </summary>
		[Association(ThisKey=nameof(SqlCeDataContext.Issue695Parent.ID), OtherKey=nameof(SqlCeDataContext.Issue695.ID), CanBeNull=true)]
		public static Issue695Parent? FKIssue695ParentBackReference(this Issue695 obj, IDataContext db)
		{
			return db.GetTable<Issue695Parent>().Where(c => c.ID == obj.ID).FirstOrDefault();
		}

		#endregion

		#region Patient Associations

		/// <summary>
		/// FK_Patient_Person
		/// </summary>
		[Association(ThisKey=nameof(SqlCeDataContext.Patient.PersonID), OtherKey=nameof(SqlCeDataContext.Person.PersonID), CanBeNull=false)]
		public static IQueryable<Person> People0(this Patient obj, IDataContext db)
		{
			return db.GetTable<Person>().Where(c => c.PersonID == obj.PersonID);
		}

		/// <summary>
		/// FK_Patient_Person
		/// </summary>
		[Association(ThisKey=nameof(SqlCeDataContext.Patient.PersonID), OtherKey=nameof(SqlCeDataContext.Person.PersonID), CanBeNull=false)]
		public static Patient Person0(this Person obj, IDataContext db)
		{
			return db.GetTable<Patient>().Where(c => c.PersonID == obj.PersonID).First();
		}

		#endregion

		#region Person Associations

		/// <summary>
		/// FK_Doctor_Person_BackReference
		/// </summary>
		[Association(ThisKey=nameof(SqlCeDataContext.Person.PersonID), OtherKey=nameof(SqlCeDataContext.Doctor.PersonID), CanBeNull=true)]
		public static IQueryable<Doctor> Doctors(this Person obj, IDataContext db)
		{
			return db.GetTable<Doctor>().Where(c => c.PersonID == obj.PersonID);
		}

		/// <summary>
		/// FK_Doctor_Person_BackReference
		/// </summary>
		[Association(ThisKey=nameof(SqlCeDataContext.Person.PersonID), OtherKey=nameof(SqlCeDataContext.Doctor.PersonID), CanBeNull=true)]
		public static Person? Doctor(this Doctor obj, IDataContext db)
		{
			return db.GetTable<Person>().Where(c => c.PersonID == obj.PersonID).FirstOrDefault();
		}

		/// <summary>
		/// FK_Patient_Person_BackReference
		/// </summary>
		[Association(ThisKey=nameof(SqlCeDataContext.Person.PersonID), OtherKey=nameof(SqlCeDataContext.Patient.PersonID), CanBeNull=true)]
		public static IQueryable<Patient> Patients(this Person obj, IDataContext db)
		{
			return db.GetTable<Patient>().Where(c => c.PersonID == obj.PersonID);
		}

		/// <summary>
		/// FK_Patient_Person_BackReference
		/// </summary>
		[Association(ThisKey=nameof(SqlCeDataContext.Person.PersonID), OtherKey=nameof(SqlCeDataContext.Patient.PersonID), CanBeNull=true)]
		public static Person? Patient(this Patient obj, IDataContext db)
		{
			return db.GetTable<Person>().Where(c => c.PersonID == obj.PersonID).FirstOrDefault();
		}

		#endregion

		#endregion
	}
}
