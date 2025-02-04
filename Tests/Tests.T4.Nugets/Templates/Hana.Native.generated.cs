﻿//---------------------------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated by T4Model template for T4 (https://github.com/linq2db/linq2db).
//    Changes to this file may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
//---------------------------------------------------------------------------------------------------

#pragma warning disable 1573, 1591

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;

using LinqToDB;
using LinqToDB.Common;
using LinqToDB.Configuration;
using LinqToDB.Data;
using LinqToDB.DataProvider.SapHana;
using LinqToDB.Mapping;

namespace SapHana.Native
{
	public partial class SYSTEMDBDB : LinqToDB.Data.DataConnection
	{
		#region Tables

		public ITable<AllType>                   AllTypes                   { get { return this.GetTable<AllType>(); } }
		public ITable<AllTypesGeo>               AllTypesGeos               { get { return this.GetTable<AllTypesGeo>(); } }
		public ITable<BulkInsertLowerCaseColumn> BulkInsertLowerCaseColumns { get { return this.GetTable<BulkInsertLowerCaseColumn>(); } }
		public ITable<BulkInsertUpperCaseColumn> BulkInsertUpperCaseColumns { get { return this.GetTable<BulkInsertUpperCaseColumn>(); } }
		public ITable<Child>                     Children                   { get { return this.GetTable<Child>(); } }
		public ITable<CollatedTable>             CollatedTables             { get { return this.GetTable<CollatedTable>(); } }
		public ITable<Doctor>                    Doctors                    { get { return this.GetTable<Doctor>(); } }
		public ITable<GrandChild>                GrandChildren              { get { return this.GetTable<GrandChild>(); } }
		public ITable<IndexTable>                IndexTables                { get { return this.GetTable<IndexTable>(); } }
		public ITable<IndexTable2>               IndexTable2                { get { return this.GetTable<IndexTable2>(); } }
		public ITable<InheritanceChild>          InheritanceChildren        { get { return this.GetTable<InheritanceChild>(); } }
		public ITable<InheritanceParent>         InheritanceParents         { get { return this.GetTable<InheritanceParent>(); } }
		public ITable<LinqDataType>              LinqDataTypes              { get { return this.GetTable<LinqDataType>(); } }
		public ITable<Parent>                    Parents                    { get { return this.GetTable<Parent>(); } }
		public ITable<ParentChildView>           ParentChildViews           { get { return this.GetTable<ParentChildView>(); } }
		public ITable<ParentView>                ParentViews                { get { return this.GetTable<ParentView>(); } }
		public ITable<Patient>                   Patients                   { get { return this.GetTable<Patient>(); } }
		public ITable<Person>                    People                     { get { return this.GetTable<Person>(); } }
		public ITable<PrdGlobalEccCvMara>        PrdGlobalEccCvMaras        { get { return this.GetTable<PrdGlobalEccCvMara>(); } }
		public ITable<TestIdentity>              TestIdentities             { get { return this.GetTable<TestIdentity>(); } }
		public ITable<TestMerge1>                TestMerge1                 { get { return this.GetTable<TestMerge1>(); } }
		public ITable<TestMerge2>                TestMerge2                 { get { return this.GetTable<TestMerge2>(); } }

		#endregion

		#region .ctor

		public SYSTEMDBDB()
		{
			InitDataContext();
			InitMappingSchema();
		}

		public SYSTEMDBDB(string configuration)
			: base(configuration)
		{
			InitDataContext();
			InitMappingSchema();
		}

		public SYSTEMDBDB(DataOptions options)
			: base(options)
		{
			InitDataContext();
			InitMappingSchema();
		}

		public SYSTEMDBDB(DataOptions<SYSTEMDBDB> options)
			: base(options.Options)
		{
			InitDataContext();
			InitMappingSchema();
		}

		partial void InitDataContext  ();
		partial void InitMappingSchema();

		#endregion

		#region Table Functions

		#region GetParentByID

		[Sql.TableFunction(Schema="TESTDB", Name="GetParentByID")]
		public ITable<Parent> GetParentByID(int? id)
		{
			return this.TableFromExpression(() => GetParentByID(id));
		}

		#endregion

		#region TestTableFunction

		[Sql.TableFunction(Schema="TESTDB", Name="TEST_TABLE_FUNCTION")]
		public ITable<TestTableFUNCTIONResult> TestTableFunction(int? i)
		{
			return this.TableFromExpression(() => TestTableFunction(i));
		}

		public partial class TestTableFUNCTIONResult
		{
			public int? O { get; set; }
		}

		#endregion

		#endregion
	}

	[Table(Schema="TESTDB", Name="AllTypes")]
	public partial class AllType
	{
		[Column(),                       PrimaryKey, Identity] public int       ID                   { get; set; } // INTEGER
		[Column("bigintDataType"),       Nullable            ] public long?     BigintDataType       { get; set; } // BIGINT
		[Column("smallintDataType"),     Nullable            ] public short?    SmallintDataType     { get; set; } // SMALLINT
		[Column("decimalDataType"),      Nullable            ] public decimal?  DecimalDataType      { get; set; } // DECIMAL(34, 0)
		[Column("smalldecimalDataType"), Nullable            ] public decimal?  SmalldecimalDataType { get; set; } // SMALLDECIMAL(16, 0)
		[Column("intDataType"),          Nullable            ] public int?      IntDataType          { get; set; } // INTEGER
		[Column("tinyintDataType"),      Nullable            ] public byte?     TinyintDataType      { get; set; } // TINYINT
		[Column("floatDataType"),        Nullable            ] public double?   FloatDataType        { get; set; } // DOUBLE
		[Column("realDataType"),         Nullable            ] public float?    RealDataType         { get; set; } // REAL
		[Column("dateDataType"),         Nullable            ] public DateTime? DateDataType         { get; set; } // DATE
		[Column("timeDataType"),         Nullable            ] public TimeSpan? TimeDataType         { get; set; } // TIME
		[Column("seconddateDataType"),   Nullable            ] public DateTime? SeconddateDataType   { get; set; } // SECONDDATE
		[Column("timestampDataType"),    Nullable            ] public DateTime? TimestampDataType    { get; set; } // TIMESTAMP
		[Column("charDataType"),         Nullable            ] public char?     CharDataType         { get; set; } // CHAR(1)
		[Column("char20DataType"),       Nullable            ] public string    Char20DataType       { get; set; } // CHAR(20)
		[Column("varcharDataType"),      Nullable            ] public string    VarcharDataType      { get; set; } // VARCHAR(20)
		[Column("textDataType"),         Nullable            ] public string    TextDataType         { get; set; } // TEXT
		[Column("shorttextDataType"),    Nullable            ] public string    ShorttextDataType    { get; set; } // SHORTTEXT
		[Column("ncharDataType"),        Nullable            ] public char?     NcharDataType        { get; set; } // NCHAR(1)
		[Column("nchar20DataType"),      Nullable            ] public string    Nchar20DataType      { get; set; } // NCHAR(20)
		[Column("nvarcharDataType"),     Nullable            ] public string    NvarcharDataType     { get; set; } // NVARCHAR(20)
		[Column("alphanumDataType"),     Nullable            ] public string    AlphanumDataType     { get; set; } // ALPHANUM
		[Column("binaryDataType"),       Nullable            ] public byte[]    BinaryDataType       { get; set; } // BINARY(10)
		[Column("varbinaryDataType"),    Nullable            ] public byte[]    VarbinaryDataType    { get; set; } // VARBINARY(10)
		[Column("blobDataType"),         Nullable            ] public byte[]    BlobDataType         { get; set; } // BLOB
		[Column("clobDataType"),         Nullable            ] public string    ClobDataType         { get; set; } // CLOB
		[Column("nclobDataType"),        Nullable            ] public string    NclobDataType        { get; set; } // NCLOB
	}

	[Table(Schema="TESTDB", Name="AllTypesGeo")]
	public partial class AllTypesGeo
	{
		[Column(),                     PrimaryKey, Identity] public int    ID                 { get; set; } // INTEGER
		[Column("dataType"),           Nullable            ] public string DataType           { get; set; } // VARCHAR(20)
		[Column("stgeometryDataType"), Nullable            ] public byte[] StgeometryDataType { get; set; } // ST_GEOMETRY
	}

	[Table(Schema="TESTDB", Name="BulkInsertLowerCaseColumns")]
	public partial class BulkInsertLowerCaseColumn
	{
		[Column, Nullable] public int?      ID            { get; set; } // INTEGER
		[Column, Nullable] public decimal?  MoneyValue    { get; set; } // DECIMAL(10, 4)
		[Column, Nullable] public DateTime? DateTimeValue { get; set; } // TIMESTAMP
		[Column, Nullable] public byte?     BoolValue     { get; set; } // TINYINT
		[Column, Nullable] public string    GuidValue     { get; set; } // VARCHAR(36)
		[Column, Nullable] public byte[]    BinaryValue   { get; set; } // VARBINARY(5000)
		[Column, Nullable] public short?    SmallIntValue { get; set; } // SMALLINT
		[Column, Nullable] public int?      IntValue      { get; set; } // INTEGER
		[Column, Nullable] public long?     BigIntValue   { get; set; } // BIGINT
	}

	[Table(Schema="TESTDB", Name="BulkInsertUpperCaseColumns")]
	public partial class BulkInsertUpperCaseColumn
	{
		[Column, Nullable] public int?      ID            { get; set; } // INTEGER
		[Column, Nullable] public decimal?  MONEYVALUE    { get; set; } // DECIMAL(10, 4)
		[Column, Nullable] public DateTime? DATETIMEVALUE { get; set; } // TIMESTAMP
		[Column, Nullable] public byte?     BOOLVALUE     { get; set; } // TINYINT
		[Column, Nullable] public string    GUIDVALUE     { get; set; } // VARCHAR(36)
		[Column, Nullable] public byte[]    BINARYVALUE   { get; set; } // VARBINARY(5000)
		[Column, Nullable] public short?    SMALLINTVALUE { get; set; } // SMALLINT
		[Column, Nullable] public int?      INTVALUE      { get; set; } // INTEGER
		[Column, Nullable] public long?     BIGINTVALUE   { get; set; } // BIGINT
	}

	[Table(Schema="TESTDB", Name="Child")]
	public partial class Child
	{
		[Column, Nullable] public int? ParentID { get; set; } // INTEGER
		[Column, Nullable] public int? ChildID  { get; set; } // INTEGER
	}

	[Table(Schema="TESTDB", Name="CollatedTable")]
	public partial class CollatedTable
	{
		[Column, NotNull] public int    Id              { get; set; } // INTEGER
		[Column, NotNull] public string CaseSensitive   { get; set; } // NVARCHAR(20)
		[Column, NotNull] public string CaseInsensitive { get; set; } // NVARCHAR(20)
	}

	[Table(Schema="TESTDB", Name="Doctor")]
	public partial class Doctor
	{
		[PrimaryKey, NotNull] public int    PersonID { get; set; } // INTEGER
		[Column,     NotNull] public string Taxonomy { get; set; } // NVARCHAR(50)

		#region Associations

		/// <summary>
		/// FK_Doctor_Person (TESTDB.Person)
		/// </summary>
		[Association(ThisKey=nameof(PersonID), OtherKey=nameof(SapHana.Native.Person.PersonID), CanBeNull=false)]
		public Person Person { get; set; }

		#endregion
	}

	[Table(Schema="TESTDB", Name="GrandChild")]
	public partial class GrandChild
	{
		[Column, Nullable] public int? ParentID     { get; set; } // INTEGER
		[Column, Nullable] public int? ChildID      { get; set; } // INTEGER
		[Column, Nullable] public int? GrandChildID { get; set; } // INTEGER
	}

	[Table(Schema="TESTDB", Name="IndexTable")]
	public partial class IndexTable
	{
		[PrimaryKey(1), NotNull] public int PKField1    { get; set; } // INTEGER
		[PrimaryKey(2), NotNull] public int PKField2    { get; set; } // INTEGER
		[Column,        NotNull] public int UniqueField { get; set; } // INTEGER
		[Column,        NotNull] public int IndexField  { get; set; } // INTEGER

		#region Associations

		/// <summary>
		/// FK_Patient2_IndexTable_BackReference (TESTDB.IndexTable2)
		/// </summary>
		[Association(ThisKey=nameof(PKField1) + ", " + nameof(PKField2), OtherKey=nameof(SapHana.Native.IndexTable2.PKField1) + ", " + nameof(SapHana.Native.IndexTable2.PKField2), CanBeNull=true)]
		public IndexTable2 Patient { get; set; }

		#endregion
	}

	[Table(Schema="TESTDB", Name="IndexTable2")]
	public partial class IndexTable2
	{
		[PrimaryKey(1), NotNull] public int PKField1 { get; set; } // INTEGER
		[PrimaryKey(2), NotNull] public int PKField2 { get; set; } // INTEGER

		#region Associations

		/// <summary>
		/// FK_Patient2_IndexTable (TESTDB.IndexTable)
		/// </summary>
		[Association(ThisKey=nameof(PKField1) + ", " + nameof(PKField2), OtherKey=nameof(SapHana.Native.IndexTable.PKField1) + ", " + nameof(SapHana.Native.IndexTable.PKField2), CanBeNull=false)]
		public IndexTable Patient2IndexTable { get; set; }

		#endregion
	}

	[Table(Schema="TESTDB", Name="InheritanceChild")]
	public partial class InheritanceChild
	{
		[PrimaryKey, NotNull    ] public int    InheritanceChildId  { get; set; } // INTEGER
		[Column,     NotNull    ] public int    InheritanceParentId { get; set; } // INTEGER
		[Column,        Nullable] public int?   TypeDiscriminator   { get; set; } // INTEGER
		[Column,        Nullable] public string Name                { get; set; } // NVARCHAR(50)
	}

	[Table(Schema="TESTDB", Name="InheritanceParent")]
	public partial class InheritanceParent
	{
		[PrimaryKey, NotNull    ] public int    InheritanceParentId { get; set; } // INTEGER
		[Column,        Nullable] public int?   TypeDiscriminator   { get; set; } // INTEGER
		[Column,        Nullable] public string Name                { get; set; } // NVARCHAR(50)
	}

	[Table(Schema="TESTDB", Name="LinqDataTypes")]
	public partial class LinqDataType
	{
		[Column, Nullable] public int?      ID             { get; set; } // INTEGER
		[Column, Nullable] public decimal?  MoneyValue     { get; set; } // DECIMAL(10, 4)
		[Column, Nullable] public DateTime? DateTimeValue  { get; set; } // TIMESTAMP
		[Column, Nullable] public DateTime? DateTimeValue2 { get; set; } // TIMESTAMP
		[Column, Nullable] public byte?     BoolValue      { get; set; } // TINYINT
		[Column, Nullable] public string    GuidValue      { get; set; } // VARCHAR(36)
		[Column, Nullable] public byte[]    BinaryValue    { get; set; } // VARBINARY(5000)
		[Column, Nullable] public short?    SmallIntValue  { get; set; } // SMALLINT
		[Column, Nullable] public int?      IntValue       { get; set; } // INTEGER
		[Column, Nullable] public long?     BigIntValue    { get; set; } // BIGINT
		[Column, Nullable] public string    StringValue    { get; set; } // NVARCHAR(50)
	}

	[Table(Schema="TESTDB", Name="Parent")]
	public partial class Parent
	{
		[Column, Nullable] public int? ParentID { get; set; } // INTEGER
		[Column, Nullable] public int? Value1   { get; set; } // INTEGER
	}

	[Table(Schema="TESTDB", Name="ParentChildView", IsView=true)]
	public partial class ParentChildView
	{
		[Column, Nullable] public int? ParentID { get; set; } // INTEGER
		[Column, Nullable] public int? Value1   { get; set; } // INTEGER
		[Column, Nullable] public int? ChildID  { get; set; } // INTEGER
	}

	[Table(Schema="TESTDB", Name="ParentView", IsView=true)]
	public partial class ParentView
	{
		[Column, Nullable] public int? ParentID { get; set; } // INTEGER
		[Column, Nullable] public int? Value1   { get; set; } // INTEGER
	}

	[Table(Schema="TESTDB", Name="Patient")]
	public partial class Patient
	{
		[PrimaryKey, NotNull] public int    PersonID  { get; set; } // INTEGER
		[Column,     NotNull] public string Diagnosis { get; set; } // NVARCHAR(256)

		#region Associations

		/// <summary>
		/// FK_Patient_Person (TESTDB.Person)
		/// </summary>
		[Association(ThisKey=nameof(PersonID), OtherKey=nameof(SapHana.Native.Person.PersonID), CanBeNull=false)]
		public Person Person { get; set; }

		#endregion
	}

	[Table(Schema="TESTDB", Name="Person")]
	public partial class Person
	{
		[PrimaryKey, Identity   ] public int    PersonID   { get; set; } // INTEGER
		[Column,     NotNull    ] public string FirstName  { get; set; } // NVARCHAR(50)
		[Column,     NotNull    ] public string LastName   { get; set; } // NVARCHAR(50)
		[Column,        Nullable] public string MiddleName { get; set; } // NVARCHAR(50)
		[Column,     NotNull    ] public char   Gender     { get; set; } // CHAR(1)

		#region Associations

		/// <summary>
		/// FK_Doctor_Person_BackReference (TESTDB.Doctor)
		/// </summary>
		[Association(ThisKey=nameof(PersonID), OtherKey=nameof(SapHana.Native.Doctor.PersonID), CanBeNull=true)]
		public Doctor Doctor { get; set; }

		/// <summary>
		/// FK_Patient_Person_BackReference (TESTDB.Patient)
		/// </summary>
		[Association(ThisKey=nameof(PersonID), OtherKey=nameof(SapHana.Native.Patient.PersonID), CanBeNull=true)]
		public Patient Patient { get; set; }

		#endregion
	}

	[Table(Schema="TESTDB", Name="prd.global.ecc/CV_MARA")]
	public partial class PrdGlobalEccCvMara
	{
		[PrimaryKey, NotNull] public int Id { get; set; } // INTEGER
	}

	[Table(Schema="TESTDB", Name="TestIdentity")]
	public partial class TestIdentity
	{
		[PrimaryKey, Identity] public int ID { get; set; } // INTEGER
	}

	[Table(Schema="TESTDB", Name="TestMerge1")]
	public partial class TestMerge1
	{
		[PrimaryKey, NotNull    ] public int       Id              { get; set; } // INTEGER
		[Column,        Nullable] public int?      Field1          { get; set; } // INTEGER
		[Column,        Nullable] public int?      Field2          { get; set; } // INTEGER
		[Column,        Nullable] public int?      Field3          { get; set; } // INTEGER
		[Column,        Nullable] public int?      Field4          { get; set; } // INTEGER
		[Column,        Nullable] public int?      Field5          { get; set; } // INTEGER
		[Column,        Nullable] public long?     FieldInt64      { get; set; } // BIGINT
		[Column,        Nullable] public byte?     FieldBoolean    { get; set; } // TINYINT
		[Column,        Nullable] public string    FieldString     { get; set; } // VARCHAR(20)
		[Column,        Nullable] public string    FieldNString    { get; set; } // NVARCHAR(20)
		[Column,        Nullable] public char?     FieldChar       { get; set; } // CHAR(1)
		[Column,        Nullable] public char?     FieldNChar      { get; set; } // NCHAR(1)
		[Column,        Nullable] public float?    FieldFloat      { get; set; } // REAL
		[Column,        Nullable] public double?   FieldDouble     { get; set; } // DOUBLE
		[Column,        Nullable] public DateTime? FieldDateTime   { get; set; } // TIMESTAMP
		[Column,        Nullable] public byte[]    FieldBinary     { get; set; } // VARBINARY(20)
		[Column,        Nullable] public string    FieldGuid       { get; set; } // CHAR(36)
		[Column,        Nullable] public decimal?  FieldDecimal    { get; set; } // DECIMAL(24, 10)
		[Column,        Nullable] public DateTime? FieldDate       { get; set; } // DATE
		[Column,        Nullable] public TimeSpan? FieldTime       { get; set; } // TIME
		[Column,        Nullable] public string    FieldEnumString { get; set; } // VARCHAR(20)
		[Column,        Nullable] public int?      FieldEnumNumber { get; set; } // INTEGER
	}

	[Table(Schema="TESTDB", Name="TestMerge2")]
	public partial class TestMerge2
	{
		[PrimaryKey, NotNull    ] public int       Id              { get; set; } // INTEGER
		[Column,        Nullable] public int?      Field1          { get; set; } // INTEGER
		[Column,        Nullable] public int?      Field2          { get; set; } // INTEGER
		[Column,        Nullable] public int?      Field3          { get; set; } // INTEGER
		[Column,        Nullable] public int?      Field4          { get; set; } // INTEGER
		[Column,        Nullable] public int?      Field5          { get; set; } // INTEGER
		[Column,        Nullable] public long?     FieldInt64      { get; set; } // BIGINT
		[Column,        Nullable] public byte?     FieldBoolean    { get; set; } // TINYINT
		[Column,        Nullable] public string    FieldString     { get; set; } // VARCHAR(20)
		[Column,        Nullable] public string    FieldNString    { get; set; } // NVARCHAR(20)
		[Column,        Nullable] public char?     FieldChar       { get; set; } // CHAR(1)
		[Column,        Nullable] public char?     FieldNChar      { get; set; } // NCHAR(1)
		[Column,        Nullable] public float?    FieldFloat      { get; set; } // REAL
		[Column,        Nullable] public double?   FieldDouble     { get; set; } // DOUBLE
		[Column,        Nullable] public DateTime? FieldDateTime   { get; set; } // TIMESTAMP
		[Column,        Nullable] public byte[]    FieldBinary     { get; set; } // VARBINARY(20)
		[Column,        Nullable] public string    FieldGuid       { get; set; } // CHAR(36)
		[Column,        Nullable] public decimal?  FieldDecimal    { get; set; } // DECIMAL(24, 10)
		[Column,        Nullable] public DateTime? FieldDate       { get; set; } // DATE
		[Column,        Nullable] public TimeSpan? FieldTime       { get; set; } // TIME
		[Column,        Nullable] public string    FieldEnumString { get; set; } // VARCHAR(20)
		[Column,        Nullable] public int?      FieldEnumNumber { get; set; } // INTEGER
	}

	public static partial class SYSTEMDBDBStoredProcedures
	{
		#region AddIssue792Record

		public static int AddIssue792Record(this SYSTEMDBDB dataConnection)
		{
			return dataConnection.ExecuteProc("\"TESTDB\".\"AddIssue792Record\"");
		}

		#endregion

		#region DROPCONSTRAINTFROMTABLE

		public static int DROPCONSTRAINTFROMTABLE(this SYSTEMDBDB dataConnection, string tablename, string constraintname, string schemaname)
		{
			var parameters = new []
			{
				new DataParameter("TABLENAME",      tablename,      LinqToDB.DataType.VarChar, 50),
				new DataParameter("CONSTRAINTNAME", constraintname, LinqToDB.DataType.VarChar, 100),
				new DataParameter("SCHEMANAME",     schemaname,     LinqToDB.DataType.VarChar, 50)
			};

			return dataConnection.ExecuteProc("\"TESTDB\".\"DROPCONSTRAINTFROMTABLE\"", parameters);
		}

		#endregion

		#region DROPEXISTINGFUNCTION

		public static int DROPEXISTINGFUNCTION(this SYSTEMDBDB dataConnection, string functionname, string schemaname)
		{
			var parameters = new []
			{
				new DataParameter("FUNCTIONNAME", functionname, LinqToDB.DataType.VarChar, 50),
				new DataParameter("SCHEMANAME",   schemaname,   LinqToDB.DataType.VarChar, 50)
			};

			return dataConnection.ExecuteProc("\"TESTDB\".\"DROPEXISTINGFUNCTION\"", parameters);
		}

		#endregion

		#region DROPEXISTINGPROCEDURE

		public static int DROPEXISTINGPROCEDURE(this SYSTEMDBDB dataConnection, string procedurename, string schemaname)
		{
			var parameters = new []
			{
				new DataParameter("PROCEDURENAME", procedurename, LinqToDB.DataType.VarChar, 50),
				new DataParameter("SCHEMANAME",    schemaname,    LinqToDB.DataType.VarChar, 50)
			};

			return dataConnection.ExecuteProc("\"TESTDB\".\"DROPEXISTINGPROCEDURE\"", parameters);
		}

		#endregion

		#region DROPEXISTINGTABLE

		public static int DROPEXISTINGTABLE(this SYSTEMDBDB dataConnection, string tablename, string schemaname)
		{
			var parameters = new []
			{
				new DataParameter("TABLENAME",  tablename,  LinqToDB.DataType.VarChar, 50),
				new DataParameter("SCHEMANAME", schemaname, LinqToDB.DataType.VarChar, 50)
			};

			return dataConnection.ExecuteProc("\"TESTDB\".\"DROPEXISTINGTABLE\"", parameters);
		}

		#endregion

		#region DROPEXISTINGVIEW

		public static int DROPEXISTINGVIEW(this SYSTEMDBDB dataConnection, string viewname, string schemaname)
		{
			var parameters = new []
			{
				new DataParameter("VIEWNAME",   viewname,   LinqToDB.DataType.VarChar, 50),
				new DataParameter("SCHEMANAME", schemaname, LinqToDB.DataType.VarChar, 50)
			};

			return dataConnection.ExecuteProc("\"TESTDB\".\"DROPEXISTINGVIEW\"", parameters);
		}

		#endregion

		#region DuplicateColumnNames

		public static IEnumerable<DuplicateColumnNamesResult> DuplicateColumnNames(this SYSTEMDBDB dataConnection)
		{
			var ms = dataConnection.MappingSchema;

			return dataConnection.QueryProc(dataReader =>
				new DuplicateColumnNamesResult
				{
					Id      = Converter.ChangeTypeTo<int?>  (dataReader.GetValue(0), ms),
					Column2 = Converter.ChangeTypeTo<string>(dataReader.GetValue(1), ms),
				},
				"\"TESTDB\".\"DuplicateColumnNames\"");
		}

		public partial class DuplicateColumnNamesResult
		{
			[Column("id")] public int?   Id      { get; set; }
			[Column("id")] public string Column2 { get; set; }
		}

		#endregion

		#region OutRefEnumTest

		public static int OutRefEnumTest(this SYSTEMDBDB dataConnection, string str, out string outputstr, ref string inputoutputstr)
		{
			var parameters = new []
			{
				new DataParameter("STR",            str,            LinqToDB.DataType.VarChar, 50),
				new DataParameter("OUTPUTSTR", null,      LinqToDB.DataType.VarChar, 50)
				{
					Direction = ParameterDirection.Output
				},
				new DataParameter("INPUTOUTPUTSTR", inputoutputstr, LinqToDB.DataType.VarChar, 50)
				{
					Direction = ParameterDirection.InputOutput
				}
			};

			var ret = dataConnection.ExecuteProc("\"TESTDB\".\"OutRefEnumTest\"", parameters);

			outputstr      = Converter.ChangeTypeTo<string>(parameters[1].Value);
			inputoutputstr = Converter.ChangeTypeTo<string>(parameters[2].Value);

			return ret;
		}

		#endregion

		#region OutRefTest

		public static int OutRefTest(this SYSTEMDBDB dataConnection, int? id, out int? outputid, ref int? inputoutputid, string str, out string outputstr, ref string inputoutputstr)
		{
			var parameters = new []
			{
				new DataParameter("ID",             id,             LinqToDB.DataType.Int32, 10),
				new DataParameter("OUTPUTID", null,       LinqToDB.DataType.Int32, 10)
				{
					Direction = ParameterDirection.Output
				},
				new DataParameter("INPUTOUTPUTID",  inputoutputid,  LinqToDB.DataType.Int32, 10)
				{
					Direction = ParameterDirection.InputOutput
				},
				new DataParameter("STR",            str,            LinqToDB.DataType.VarChar, 50),
				new DataParameter("OUTPUTSTR", null,      LinqToDB.DataType.VarChar, 50)
				{
					Direction = ParameterDirection.Output
				},
				new DataParameter("INPUTOUTPUTSTR", inputoutputstr, LinqToDB.DataType.VarChar, 50)
				{
					Direction = ParameterDirection.InputOutput
				}
			};

			var ret = dataConnection.ExecuteProc("\"TESTDB\".\"OutRefTest\"", parameters);

			outputid       = Converter.ChangeTypeTo<int?>  (parameters[1].Value);
			inputoutputid  = Converter.ChangeTypeTo<int?>  (parameters[2].Value);
			outputstr      = Converter.ChangeTypeTo<string>(parameters[4].Value);
			inputoutputstr = Converter.ChangeTypeTo<string>(parameters[5].Value);

			return ret;
		}

		#endregion

		#region PatientSelectAll

		public static IEnumerable<PatientSelectAllResult> PatientSelectAll(this SYSTEMDBDB dataConnection)
		{
			return dataConnection.QueryProc<PatientSelectAllResult>("\"TESTDB\".\"Patient_SelectAll\"");
		}

		public partial class PatientSelectAllResult
		{
			public int?   PersonID   { get; set; }
			public string FirstName  { get; set; }
			public string LastName   { get; set; }
			public string MiddleName { get; set; }
			public string Gender     { get; set; }
			public string Diagnosis  { get; set; }
		}

		#endregion

		#region PatientSelectByName

		public static IEnumerable<PatientSelectByNameResult> PatientSelectByName(this SYSTEMDBDB dataConnection, string firstname, string lastname)
		{
			var parameters = new []
			{
				new DataParameter("FIRSTNAME", firstname, LinqToDB.DataType.NVarChar, 50),
				new DataParameter("LASTNAME",  lastname,  LinqToDB.DataType.NVarChar, 50)
			};

			return dataConnection.QueryProc<PatientSelectByNameResult>("\"TESTDB\".\"Patient_SelectByName\"", parameters);
		}

		public partial class PatientSelectByNameResult
		{
			public int?   PersonID   { get; set; }
			public string FirstName  { get; set; }
			public string LastName   { get; set; }
			public string MiddleName { get; set; }
			public string Gender     { get; set; }
			public string Diagnosis  { get; set; }
		}

		#endregion

		#region PersonDelete

		public static int PersonDelete(this SYSTEMDBDB dataConnection, int? personid)
		{
			var parameters = new []
			{
				new DataParameter("PERSONID", personid, LinqToDB.DataType.Int32, 10)
			};

			return dataConnection.ExecuteProc("\"TESTDB\".\"Person_Delete\"", parameters);
		}

		#endregion

		#region PersonInsert

		public static int PersonInsert(this SYSTEMDBDB dataConnection, string firstname, string lastname, string middlename, char? gender)
		{
			var parameters = new []
			{
				new DataParameter("FIRSTNAME",  firstname,  LinqToDB.DataType.NVarChar, 50),
				new DataParameter("LASTNAME",   lastname,   LinqToDB.DataType.NVarChar, 50),
				new DataParameter("MIDDLENAME", middlename, LinqToDB.DataType.NVarChar, 50),
				new DataParameter("GENDER",     gender,     LinqToDB.DataType.Char, 1)
			};

			return dataConnection.ExecuteProc("\"TESTDB\".\"Person_Insert\"", parameters);
		}

		#endregion

		#region PersonInsertOutputParameter

		public static int PersonInsertOutputParameter(this SYSTEMDBDB dataConnection, string firstname, string lastname, string middlename, char? gender, out int? personid)
		{
			var parameters = new []
			{
				new DataParameter("FIRSTNAME", firstname, LinqToDB.DataType.NVarChar, 50),
				new DataParameter("LASTNAME", lastname, LinqToDB.DataType.NVarChar, 50),
				new DataParameter("MIDDLENAME", middlename, LinqToDB.DataType.NVarChar, 50),
				new DataParameter("GENDER",   gender,   LinqToDB.DataType.Char, 1),
				new DataParameter("PERSONID", null, LinqToDB.DataType.Int32, 10)
				{
					Direction = ParameterDirection.Output
				}
			};

			var ret = dataConnection.ExecuteProc("\"TESTDB\".\"Person_Insert_OutputParameter\"", parameters);

			personid = Converter.ChangeTypeTo<int?>(parameters[4].Value);

			return ret;
		}

		#endregion

		#region PersonSelectAll

		public static IEnumerable<PersonSelectAllResult> PersonSelectAll(this SYSTEMDBDB dataConnection)
		{
			return dataConnection.QueryProc<PersonSelectAllResult>("\"TESTDB\".\"Person_SelectAll\"");
		}

		public partial class PersonSelectAllResult
		{
			public int    PersonID   { get; set; }
			public string FirstName  { get; set; }
			public string LastName   { get; set; }
			public string MiddleName { get; set; }
			public string Gender     { get; set; }
		}

		#endregion

		#region PersonSelectByKey

		public static IEnumerable<PersonSelectByKeyResult> PersonSelectByKey(this SYSTEMDBDB dataConnection, int? id)
		{
			var parameters = new []
			{
				new DataParameter("ID", id, LinqToDB.DataType.Int32, 10)
			};

			return dataConnection.QueryProc<PersonSelectByKeyResult>("\"TESTDB\".\"Person_SelectByKey\"", parameters);
		}

		public partial class PersonSelectByKeyResult
		{
			public int    PersonID   { get; set; }
			public string FirstName  { get; set; }
			public string LastName   { get; set; }
			public string MiddleName { get; set; }
			public string Gender     { get; set; }
		}

		#endregion

		#region PersonSelectByName

		public static IEnumerable<PersonSelectByNameResult> PersonSelectByName(this SYSTEMDBDB dataConnection, string firstname, string lastname)
		{
			var parameters = new []
			{
				new DataParameter("FIRSTNAME", firstname, LinqToDB.DataType.NVarChar, 50),
				new DataParameter("LASTNAME",  lastname,  LinqToDB.DataType.NVarChar, 50)
			};

			return dataConnection.QueryProc<PersonSelectByNameResult>("\"TESTDB\".\"Person_SelectByName\"", parameters);
		}

		public partial class PersonSelectByNameResult
		{
			public int    PersonID   { get; set; }
			public string FirstName  { get; set; }
			public string LastName   { get; set; }
			public string MiddleName { get; set; }
			public string Gender     { get; set; }
		}

		#endregion

		#region PersonSelectListByName

		public static IEnumerable<PersonSelectListByNameResult> PersonSelectListByName(this SYSTEMDBDB dataConnection, string firstname, string lastname)
		{
			var parameters = new []
			{
				new DataParameter("FIRSTNAME", firstname, LinqToDB.DataType.NVarChar, 50),
				new DataParameter("LASTNAME",  lastname,  LinqToDB.DataType.NVarChar, 50)
			};

			return dataConnection.QueryProc<PersonSelectListByNameResult>("\"TESTDB\".\"Person_SelectListByName\"", parameters);
		}

		public partial class PersonSelectListByNameResult
		{
			public int    PersonID   { get; set; }
			public string FirstName  { get; set; }
			public string LastName   { get; set; }
			public string MiddleName { get; set; }
			public string Gender     { get; set; }
		}

		#endregion

		#region PersonUpdate

		public static int PersonUpdate(this SYSTEMDBDB dataConnection, int? personid, string firstname, string lastname, string middlename, char? gender)
		{
			var parameters = new []
			{
				new DataParameter("PERSONID",   personid,   LinqToDB.DataType.Int32, 10),
				new DataParameter("FIRSTNAME",  firstname,  LinqToDB.DataType.NVarChar, 50),
				new DataParameter("LASTNAME",   lastname,   LinqToDB.DataType.NVarChar, 50),
				new DataParameter("MIDDLENAME", middlename, LinqToDB.DataType.NVarChar, 50),
				new DataParameter("GENDER",     gender,     LinqToDB.DataType.Char, 1)
			};

			return dataConnection.ExecuteProc("\"TESTDB\".\"Person_Update\"", parameters);
		}

		#endregion

		#region PrdGlobalEccCvMARAproc

		public static IEnumerable<PrdGlobalEccCvMARAprocResult> PrdGlobalEccCvMARAproc(this SYSTEMDBDB dataConnection)
		{
			var ms = dataConnection.MappingSchema;

			return dataConnection.QueryProc(dataReader =>
				new PrdGlobalEccCvMARAprocResult
				{
					Id      = Converter.ChangeTypeTo<int?>  (dataReader.GetValue(0), ms),
					Column2 = Converter.ChangeTypeTo<string>(dataReader.GetValue(1), ms),
				},
				"\"TESTDB\".\"prd.global.ecc/CV_MARAproc\"");
		}

		public partial class PrdGlobalEccCvMARAprocResult
		{
			[Column("id")] public int?   Id      { get; set; }
			[Column("id")] public string Column2 { get; set; }
		}

		#endregion

		#region SelectImplicitColumn

		public static IEnumerable<SelectImplicitColumnResult> SelectImplicitColumn(this SYSTEMDBDB dataConnection)
		{
			return dataConnection.QueryProc<SelectImplicitColumnResult>("\"TESTDB\".\"SelectImplicitColumn\"");
		}

		public partial class SelectImplicitColumnResult
		{
			[Column("123")] public int? _123 { get; set; }
		}

		#endregion

		#region TestProcedure

		public static IEnumerable<TestPROCEDUREResult> TestProcedure(this SYSTEMDBDB dataConnection, int? i)
		{
			var parameters = new []
			{
				new DataParameter("I", i, LinqToDB.DataType.Int32, 10)
			};

			var ms = dataConnection.MappingSchema;

			return dataConnection.QueryProc(dataReader =>
				new TestPROCEDUREResult
				{
					Column1 = Converter.ChangeTypeTo<int?>(dataReader.GetValue(0), ms),
				},
				"\"TESTDB\".\"TEST_PROCEDURE\"", parameters);
		}

		public partial class TestPROCEDUREResult
		{
			[Column("")] public int? Column1 { get; set; }
		}

		#endregion
	}

	public static partial class SqlFunctions
	{
		#region TestFunction

		[Sql.Function(Name="\"TESTDB\".\"TEST_FUNCTION\"", ServerSideOnly=true)]
		public static int? TestFunction(int? i)
		{
			throw new InvalidOperationException();
		}

		#endregion
	}

	public static partial class TableExtensions
	{
		public static AllType Find(this ITable<AllType> table, int ID)
		{
			return table.FirstOrDefault(t =>
				t.ID == ID);
		}

		public static AllTypesGeo Find(this ITable<AllTypesGeo> table, int ID)
		{
			return table.FirstOrDefault(t =>
				t.ID == ID);
		}

		public static Doctor Find(this ITable<Doctor> table, int PersonID)
		{
			return table.FirstOrDefault(t =>
				t.PersonID == PersonID);
		}

		public static IndexTable Find(this ITable<IndexTable> table, int PKField1, int PKField2)
		{
			return table.FirstOrDefault(t =>
				t.PKField1 == PKField1 &&
				t.PKField2 == PKField2);
		}

		public static IndexTable2 Find(this ITable<IndexTable2> table, int PKField1, int PKField2)
		{
			return table.FirstOrDefault(t =>
				t.PKField1 == PKField1 &&
				t.PKField2 == PKField2);
		}

		public static InheritanceChild Find(this ITable<InheritanceChild> table, int InheritanceChildId)
		{
			return table.FirstOrDefault(t =>
				t.InheritanceChildId == InheritanceChildId);
		}

		public static InheritanceParent Find(this ITable<InheritanceParent> table, int InheritanceParentId)
		{
			return table.FirstOrDefault(t =>
				t.InheritanceParentId == InheritanceParentId);
		}

		public static Patient Find(this ITable<Patient> table, int PersonID)
		{
			return table.FirstOrDefault(t =>
				t.PersonID == PersonID);
		}

		public static Person Find(this ITable<Person> table, int PersonID)
		{
			return table.FirstOrDefault(t =>
				t.PersonID == PersonID);
		}

		public static PrdGlobalEccCvMara Find(this ITable<PrdGlobalEccCvMara> table, int Id)
		{
			return table.FirstOrDefault(t =>
				t.Id == Id);
		}

		public static TestIdentity Find(this ITable<TestIdentity> table, int ID)
		{
			return table.FirstOrDefault(t =>
				t.ID == ID);
		}

		public static TestMerge1 Find(this ITable<TestMerge1> table, int Id)
		{
			return table.FirstOrDefault(t =>
				t.Id == Id);
		}

		public static TestMerge2 Find(this ITable<TestMerge2> table, int Id)
		{
			return table.FirstOrDefault(t =>
				t.Id == Id);
		}
	}
}
