// ---------------------------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by LinqToDB scaffolding tool (https://github.com/linq2db/linq2db).
// Changes to this file may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
// ---------------------------------------------------------------------------------------------------

using FirebirdSql.Data.Types;
using LinqToDB;
using LinqToDB.Common;
using LinqToDB.Data;
using System;
using System.Data;
using System.Linq;
using System.Numerics;
using System.Threading;
using System.Threading.Tasks;

#pragma warning disable 1573, 1591
#nullable enable

namespace Cli.NoMetadata.Firebird
{
	public partial class TestDataDB : DataConnection
	{
		public TestDataDB()
		{
		}

		public TestDataDB(string configuration)
			: base(configuration)
		{
		}

		public TestDataDB(DataOptions<TestDataDB> options)
			: base(options.Options)
		{
		}

		public ITable<AllType>           AllTypes            => this.GetTable<AllType>();
		public ITable<CamelCaseName>     CamelCaseNames      => this.GetTable<CamelCaseName>();
		public ITable<Child>             Children            => this.GetTable<Child>();
		public ITable<CollatedTable>     CollatedTables      => this.GetTable<CollatedTable>();
		public ITable<DataTypeTest>      DataTypeTests       => this.GetTable<DataTypeTest>();
		public ITable<Doctor>            Doctors             => this.GetTable<Doctor>();
		public ITable<Dual>              Duals               => this.GetTable<Dual>();
		public ITable<GrandChild>        GrandChildren       => this.GetTable<GrandChild>();
		public ITable<InheritanceChild>  InheritanceChildren => this.GetTable<InheritanceChild>();
		public ITable<InheritanceParent> InheritanceParents  => this.GetTable<InheritanceParent>();
		public ITable<LinqDataType>      LinqDataTypes       => this.GetTable<LinqDataType>();
		public ITable<Parent>            Parents             => this.GetTable<Parent>();
		public ITable<Patient>           Patients            => this.GetTable<Patient>();
		public ITable<Person>            People              => this.GetTable<Person>();
		public ITable<SequenceTest>      SequenceTests       => this.GetTable<SequenceTest>();
		public ITable<TestIdentity>      TestIdentities      => this.GetTable<TestIdentity>();
		public ITable<TestMerge1>        TestMerge1          => this.GetTable<TestMerge1>();
		public ITable<TestMerge2>        TestMerge2          => this.GetTable<TestMerge2>();
		public ITable<PersonView>        PersonViews         => this.GetTable<PersonView>();

		#region Table Functions
		#region OutRefEnumTest
		public IQueryable<OutRefEnumTestResult> OutRefEnumTest(string? str, string? inInputoutputstr)
		{
			return this.QueryFromExpression<OutRefEnumTestResult>(() => OutRefEnumTest(str, inInputoutputstr));
		}

		public partial class OutRefEnumTestResult
		{
			public string? Inputoutputstr { get; set; }
			public string? Outputstr      { get; set; }
		}
		#endregion

		#region OutRefTest
		public IQueryable<OutRefTestResult> OutRefTest(int? id, int? inInputoutputid, string? str, string? inInputoutputstr)
		{
			return this.QueryFromExpression<OutRefTestResult>(() => OutRefTest(id, inInputoutputid, str, inInputoutputstr));
		}

		public partial class OutRefTestResult
		{
			public int?    Inputoutputid  { get; set; }
			public string? Inputoutputstr { get; set; }
			public int?    Outputid       { get; set; }
			public string? Outputstr      { get; set; }
		}
		#endregion

		#region PatientSelectAll
		public IQueryable<PatientSelectAllResult> PatientSelectAll()
		{
			return this.QueryFromExpression<PatientSelectAllResult>(() => PatientSelectAll());
		}

		public partial class PatientSelectAllResult
		{
			public int?    Personid   { get; set; }
			public string? Firstname  { get; set; }
			public string? Lastname   { get; set; }
			public string? Middlename { get; set; }
			public string? Gender     { get; set; }
			public string? Diagnosis  { get; set; }
		}
		#endregion

		#region PatientSelectByName
		public IQueryable<PatientSelectByNameResult> PatientSelectByName(string? firstname, string? lastname)
		{
			return this.QueryFromExpression<PatientSelectByNameResult>(() => PatientSelectByName(firstname, lastname));
		}

		public partial class PatientSelectByNameResult
		{
			public int?    Personid   { get; set; }
			public string? Middlename { get; set; }
			public string? Gender     { get; set; }
			public string? Diagnosis  { get; set; }
		}
		#endregion

		#region PersonInsert
		public IQueryable<PersonInsertResult> PersonInsert(string? firstname, string? lastname, string? middlename, char? gender)
		{
			return this.QueryFromExpression<PersonInsertResult>(() => PersonInsert(firstname, lastname, middlename, gender));
		}

		public partial class PersonInsertResult
		{
			public int? Personid { get; set; }
		}
		#endregion

		#region PersonInsertOutputParameter
		public IQueryable<PersonInsertOutputParameterResult> PersonInsertOutputParameter(string? firstname, string? lastname, string? middlename, char? gender)
		{
			return this.QueryFromExpression<PersonInsertOutputParameterResult>(() => PersonInsertOutputParameter(firstname, lastname, middlename, gender));
		}

		public partial class PersonInsertOutputParameterResult
		{
			public int? Personid { get; set; }
		}
		#endregion

		#region PersonSelectAll
		public IQueryable<PersonSelectAllResult> PersonSelectAll()
		{
			return this.QueryFromExpression<PersonSelectAllResult>(() => PersonSelectAll());
		}

		public partial class PersonSelectAllResult
		{
			public int?    Personid   { get; set; }
			public string? Firstname  { get; set; }
			public string? Lastname   { get; set; }
			public string? Middlename { get; set; }
			public string? Gender     { get; set; }
		}
		#endregion

		#region PersonSelectByKey
		public IQueryable<PersonSelectByKeyResult> PersonSelectByKey(int? id)
		{
			return this.QueryFromExpression<PersonSelectByKeyResult>(() => PersonSelectByKey(id));
		}

		public partial class PersonSelectByKeyResult
		{
			public int?    Personid   { get; set; }
			public string? Firstname  { get; set; }
			public string? Lastname   { get; set; }
			public string? Middlename { get; set; }
			public string? Gender     { get; set; }
		}
		#endregion

		#region PersonSelectByName
		public IQueryable<PersonSelectByNameResult> PersonSelectByName(string? inFirstname, string? inLastname)
		{
			return this.QueryFromExpression<PersonSelectByNameResult>(() => PersonSelectByName(inFirstname, inLastname));
		}

		public partial class PersonSelectByNameResult
		{
			public int?    Personid   { get; set; }
			public string? Firstname  { get; set; }
			public string? Lastname   { get; set; }
			public string? Middlename { get; set; }
			public string? Gender     { get; set; }
		}
		#endregion

		#region ScalarDataReader
		public IQueryable<ScalarDataReaderResult> ScalarDataReader()
		{
			return this.QueryFromExpression<ScalarDataReaderResult>(() => ScalarDataReader());
		}

		public partial class ScalarDataReaderResult
		{
			public int?    Intfield    { get; set; }
			public string? Stringfield { get; set; }
		}
		#endregion

		#region ScalarOutputParameter
		public IQueryable<ScalarOutputParameterResult> ScalarOutputParameter()
		{
			return this.QueryFromExpression<ScalarOutputParameterResult>(() => ScalarOutputParameter());
		}

		public partial class ScalarOutputParameterResult
		{
			public int?    Outputint    { get; set; }
			public string? Outputstring { get; set; }
		}
		#endregion

		#region ScalarReturnParameter
		public IQueryable<ScalarReturnParameterResult> ScalarReturnParameter()
		{
			return this.QueryFromExpression<ScalarReturnParameterResult>(() => ScalarReturnParameter());
		}

		public partial class ScalarReturnParameterResult
		{
			public int? ReturnValue { get; set; }
		}
		#endregion

		#region TestTableFunction
		public IQueryable<TestTableFunctionResult> TestTableFunction(int? i)
		{
			return this.QueryFromExpression<TestTableFunctionResult>(() => TestTableFunction(i));
		}

		public partial class TestTableFunctionResult
		{
			public int? O { get; set; }
		}
		#endregion

		#region TestV4Types
		public IQueryable<TestV4TypesResult> TestV4Types(FbZonedDateTime? tstz, FbZonedTime? ttz, FbDecFloat? decfloat16, FbDecFloat? decfloat34, BigInteger? int128)
		{
			return this.QueryFromExpression<TestV4TypesResult>(() => TestV4Types(tstz, ttz, decfloat16, decfloat34, int128));
		}

		public partial class TestV4TypesResult
		{
			public FbZonedDateTime? ColTstz       { get; set; }
			public FbZonedTime?     ColTtz        { get; set; }
			public FbDecFloat?      ColDecfloat16 { get; set; }
			public FbDecFloat?      ColDecfloat34 { get; set; }
			public BigInteger?      ColInt128     { get; set; }
		}
		#endregion

		#region TestPackage1TestTableFunction
		public IQueryable<TestPackage1TestTableFunctionResult> TestPackage1TestTableFunction(int? i)
		{
			return this.QueryFromExpression<TestPackage1TestTableFunctionResult>(() => TestPackage1TestTableFunction(i));
		}

		public partial class TestPackage1TestTableFunctionResult
		{
			public int? O { get; set; }
		}
		#endregion

		#region TestPackage2TestTableFunction
		public IQueryable<TestPackage2TestTableFunctionResult> TestPackage2TestTableFunction(int? i)
		{
			return this.QueryFromExpression<TestPackage2TestTableFunctionResult>(() => TestPackage2TestTableFunction(i));
		}

		public partial class TestPackage2TestTableFunctionResult
		{
			public int? O { get; set; }
		}
		#endregion
		#endregion
	}

	public static partial class ExtensionMethods
	{
		#region Associations
		#region Doctor Associations
		/// <summary>
		/// FK_Doctor_Person
		/// </summary>
		public static Person Person(this Doctor obj, IDataContext db)
		{
			return db.GetTable<Person>().First(t => obj.PersonId == t.PersonId);
		}
		#endregion

		#region Person Associations
		/// <summary>
		/// FK_Doctor_Person backreference
		/// </summary>
		public static Doctor? Doctor(this Person obj, IDataContext db)
		{
			return db.GetTable<Doctor>().FirstOrDefault(t => t.PersonId == obj.PersonId);
		}

		/// <summary>
		/// INTEG_18 backreference
		/// </summary>
		public static Patient? Patient(this Person obj, IDataContext db)
		{
			return db.GetTable<Patient>().FirstOrDefault(t => t.PersonId == obj.PersonId);
		}
		#endregion

		#region Patient Associations
		/// <summary>
		/// INTEG_18
		/// </summary>
		public static Person Integ(this Patient obj, IDataContext db)
		{
			return db.GetTable<Person>().First(t => obj.PersonId == t.PersonId);
		}
		#endregion
		#endregion

		#region Stored Procedures
		#region AddIssue792Record
		public static int AddIssue792Record(this TestDataDB dataConnection)
		{
			return dataConnection.ExecuteProc("\"AddIssue792Record\"");
		}

		public static Task<int> AddIssue792RecordAsync(this TestDataDB dataConnection, CancellationToken cancellationToken = default)
		{
			return dataConnection.ExecuteProcAsync("\"AddIssue792Record\"", cancellationToken);
		}
		#endregion

		#region PersonDelete
		public static int PersonDelete(this TestDataDB dataConnection, int? personId)
		{
			var parameters = new []
			{
				new DataParameter("PersonID", personId, DataType.Int32)
				{
					Size = 4
				}
			};
			return dataConnection.ExecuteProc("\"Person_Delete\"", parameters);
		}

		public static Task<int> PersonDeleteAsync(this TestDataDB dataConnection, int? personId, CancellationToken cancellationToken = default)
		{
			var parameters = new []
			{
				new DataParameter("PersonID", personId, DataType.Int32)
				{
					Size = 4
				}
			};
			return dataConnection.ExecuteProcAsync("\"Person_Delete\"", cancellationToken, parameters);
		}
		#endregion

		#region PersonUpdate
		public static int PersonUpdate(this TestDataDB dataConnection, int? personid, string? firstname, string? lastname, string? middlename, char? gender)
		{
			var parameters = new []
			{
				new DataParameter("PERSONID", personid, DataType.Int32)
				{
					Size = 4
				},
				new DataParameter("FIRSTNAME", firstname, DataType.NVarChar)
				{
					Size = 50
				},
				new DataParameter("LASTNAME", lastname, DataType.NVarChar)
				{
					Size = 50
				},
				new DataParameter("MIDDLENAME", middlename, DataType.NVarChar)
				{
					Size = 50
				},
				new DataParameter("GENDER", gender, DataType.NChar)
				{
					Size = 1
				}
			};
			return dataConnection.ExecuteProc("\"Person_Update\"", parameters);
		}

		public static Task<int> PersonUpdateAsync(this TestDataDB dataConnection, int? personid, string? firstname, string? lastname, string? middlename, char? gender, CancellationToken cancellationToken = default)
		{
			var parameters = new []
			{
				new DataParameter("PERSONID", personid, DataType.Int32)
				{
					Size = 4
				},
				new DataParameter("FIRSTNAME", firstname, DataType.NVarChar)
				{
					Size = 50
				},
				new DataParameter("LASTNAME", lastname, DataType.NVarChar)
				{
					Size = 50
				},
				new DataParameter("MIDDLENAME", middlename, DataType.NVarChar)
				{
					Size = 50
				},
				new DataParameter("GENDER", gender, DataType.NChar)
				{
					Size = 1
				}
			};
			return dataConnection.ExecuteProcAsync("\"Person_Update\"", cancellationToken, parameters);
		}
		#endregion

		#region TestProcedure
		public static int TestProcedure(this TestDataDB dataConnection, int? i, out int? o)
		{
			var parameters = new []
			{
				new DataParameter("I", i, DataType.Int32)
				{
					Size = 4
				},
				new DataParameter("O", null, DataType.Int32)
				{
					Direction = ParameterDirection.Output,
					Size = 4
				}
			};
			var ret = dataConnection.ExecuteProc("TEST_PROCEDURE", parameters);
			o = Converter.ChangeTypeTo<int?>(parameters[1].Value);
			return ret;
		}

		public static async Task<TestProcedureResults> TestProcedureAsync(this TestDataDB dataConnection, int? i, int? o, CancellationToken cancellationToken = default)
		{
			var parameters = new []
			{
				new DataParameter("I", i, DataType.Int32)
				{
					Size = 4
				},
				new DataParameter("O", null, DataType.Int32)
				{
					Direction = ParameterDirection.Output,
					Size = 4
				}
			};
			var result = await dataConnection.ExecuteProcAsync("TEST_PROCEDURE", cancellationToken, parameters);
			return new TestProcedureResults()
			{
				Result = result,
				O = Converter.ChangeTypeTo<int?>(parameters[1].Value)
			};
		}

		public class TestProcedureResults
		{
			public int  Result { get; set; }
			public int? O      { get; set; }
		}
		#endregion

		#region TestPackage1TestProcedure
		public static int TestPackage1TestProcedure(this TestDataDB dataConnection, int? i, out int? o)
		{
			var parameters = new []
			{
				new DataParameter("I", i, DataType.Int32)
				{
					Size = 4
				},
				new DataParameter("O", null, DataType.Int32)
				{
					Direction = ParameterDirection.Output,
					Size = 4
				}
			};
			var ret = dataConnection.ExecuteProc("TEST_PACKAGE1.TEST_PROCEDURE", parameters);
			o = Converter.ChangeTypeTo<int?>(parameters[1].Value);
			return ret;
		}

		public static async Task<TestProcedureResults1> TestPackage1TestProcedureAsync(this TestDataDB dataConnection, int? i, int? o, CancellationToken cancellationToken = default)
		{
			var parameters = new []
			{
				new DataParameter("I", i, DataType.Int32)
				{
					Size = 4
				},
				new DataParameter("O", null, DataType.Int32)
				{
					Direction = ParameterDirection.Output,
					Size = 4
				}
			};
			var result = await dataConnection.ExecuteProcAsync("TEST_PACKAGE1.TEST_PROCEDURE", cancellationToken, parameters);
			return new TestProcedureResults1()
			{
				Result = result,
				O = Converter.ChangeTypeTo<int?>(parameters[1].Value)
			};
		}

		public class TestProcedureResults1
		{
			public int  Result { get; set; }
			public int? O      { get; set; }
		}
		#endregion

		#region TestPackage2TestProcedure
		public static int TestPackage2TestProcedure(this TestDataDB dataConnection, int? i, out int? o)
		{
			var parameters = new []
			{
				new DataParameter("I", i, DataType.Int32)
				{
					Size = 4
				},
				new DataParameter("O", null, DataType.Int32)
				{
					Direction = ParameterDirection.Output,
					Size = 4
				}
			};
			var ret = dataConnection.ExecuteProc("TEST_PACKAGE2.TEST_PROCEDURE", parameters);
			o = Converter.ChangeTypeTo<int?>(parameters[1].Value);
			return ret;
		}

		public static async Task<TestProcedureResults2> TestPackage2TestProcedureAsync(this TestDataDB dataConnection, int? i, int? o, CancellationToken cancellationToken = default)
		{
			var parameters = new []
			{
				new DataParameter("I", i, DataType.Int32)
				{
					Size = 4
				},
				new DataParameter("O", null, DataType.Int32)
				{
					Direction = ParameterDirection.Output,
					Size = 4
				}
			};
			var result = await dataConnection.ExecuteProcAsync("TEST_PACKAGE2.TEST_PROCEDURE", cancellationToken, parameters);
			return new TestProcedureResults2()
			{
				Result = result,
				O = Converter.ChangeTypeTo<int?>(parameters[1].Value)
			};
		}

		public class TestProcedureResults2
		{
			public int  Result { get; set; }
			public int? O      { get; set; }
		}
		#endregion
		#endregion

		#region Scalar Functions
		#region Ltrim
		public static string? Ltrim(string? par2)
		{
			throw new InvalidOperationException("Scalar function cannot be called outside of query");
		}
		#endregion

		#region Rtrim
		public static string? Rtrim(string? par4)
		{
			throw new InvalidOperationException("Scalar function cannot be called outside of query");
		}
		#endregion

		#region TestFunction
		public static int? TestFunction(int? i)
		{
			throw new InvalidOperationException("Scalar function cannot be called outside of query");
		}
		#endregion

		#region TestPackage1TestFunction
		public static int? TestPackage1TestFunction(int? i)
		{
			throw new InvalidOperationException("Scalar function cannot be called outside of query");
		}
		#endregion

		#region TestPackage2TestFunction
		public static int? TestPackage2TestFunction(int? i)
		{
			throw new InvalidOperationException("Scalar function cannot be called outside of query");
		}
		#endregion
		#endregion
	}
}
