// ---------------------------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by LinqToDB scaffolding tool (https://github.com/linq2db/linq2db).
// Changes to this file may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
// ---------------------------------------------------------------------------------------------------

using LinqToDB;
using LinqToDB.Data;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

#pragma warning disable 1573, 1591
#nullable enable

namespace Cli.All.ClickHouse.MySql
{
	public partial class TestDataDB : DataConnection
	{
		public TestDataDB()
		{
			InitDataContext();
		}

		public TestDataDB(string configuration)
			: base(configuration)
		{
			InitDataContext();
		}

		public TestDataDB(DataOptions options)
			: base(options)
		{
			InitDataContext();
		}

		public TestDataDB(DataOptions<TestDataDB> options)
			: base(options.Options)
		{
			InitDataContext();
		}

		partial void InitDataContext();

		public ITable<AllType>                 AllTypes                 => this.GetTable<AllType>();
		public ITable<Child>                   Children                 => this.GetTable<Child>();
		public ITable<CollatedTable>           CollatedTables           => this.GetTable<CollatedTable>();
		public ITable<Doctor>                  Doctors                  => this.GetTable<Doctor>();
		public ITable<GrandChild>              GrandChildren            => this.GetTable<GrandChild>();
		public ITable<InheritanceChild>        InheritanceChildren      => this.GetTable<InheritanceChild>();
		public ITable<InheritanceParent>       InheritanceParents       => this.GetTable<InheritanceParent>();
		public ITable<LinqDataType>            LinqDataTypes            => this.GetTable<LinqDataType>();
		public ITable<Parent>                  Parents                  => this.GetTable<Parent>();
		public ITable<Patient>                 Patients                 => this.GetTable<Patient>();
		public ITable<Person>                  People                   => this.GetTable<Person>();
		public ITable<ReplacingMergeTreeTable> ReplacingMergeTreeTables => this.GetTable<ReplacingMergeTreeTable>();
		public ITable<TestMerge1>              TestMerge1               => this.GetTable<TestMerge1>();
		public ITable<TestMerge2>              TestMerge2               => this.GetTable<TestMerge2>();
	}

	public static partial class ExtensionMethods
	{
		#region Table Extensions
		public static AllType? Find(this ITable<AllType> table, int id)
		{
			return table.FirstOrDefault(e => e.Id == id);
		}

		public static Task<AllType?> FindAsync(this ITable<AllType> table, int id, CancellationToken cancellationToken = default)
		{
			return table.FirstOrDefaultAsync(e => e.Id == id, cancellationToken);
		}

		public static IQueryable<AllType> FindQuery(this ITable<AllType> table, int id)
		{
			return table.Where(e => e.Id == id);
		}

		public static AllType? Find(this ITable<AllType> table, AllType @record)
		{
			return table.FirstOrDefault(e => e.Id == @record.Id);
		}

		public static Task<AllType?> FindAsync(this ITable<AllType> table, AllType @record, CancellationToken cancellationToken = default)
		{
			return table.FirstOrDefaultAsync(e => e.Id == @record.Id, cancellationToken);
		}

		public static IQueryable<AllType> FindQuery(this ITable<AllType> table, AllType @record)
		{
			return table.Where(e => e.Id == @record.Id);
		}

		public static AllType? FindAllType(this TestDataDB db, int id)
		{
			return db.GetTable<AllType>().FirstOrDefault(e => e.Id == id);
		}

		public static Task<AllType?> FindAllTypeAsync(this TestDataDB db, int id, CancellationToken cancellationToken = default)
		{
			return db.GetTable<AllType>().FirstOrDefaultAsync(e => e.Id == id, cancellationToken);
		}

		public static IQueryable<AllType> FindAllTypeQuery(this TestDataDB db, int id)
		{
			return db.GetTable<AllType>().Where(e => e.Id == id);
		}

		public static AllType? Find(this TestDataDB db, AllType @record)
		{
			return db.GetTable<AllType>().FirstOrDefault(e => e.Id == @record.Id);
		}

		public static Task<AllType?> FindAsync(this TestDataDB db, AllType @record, CancellationToken cancellationToken = default)
		{
			return db.GetTable<AllType>().FirstOrDefaultAsync(e => e.Id == @record.Id, cancellationToken);
		}

		public static IQueryable<AllType> FindQuery(this TestDataDB db, AllType @record)
		{
			return db.GetTable<AllType>().Where(e => e.Id == @record.Id);
		}

		public static CollatedTable? Find(this ITable<CollatedTable> table, int id)
		{
			return table.FirstOrDefault(e => e.Id == id);
		}

		public static Task<CollatedTable?> FindAsync(this ITable<CollatedTable> table, int id, CancellationToken cancellationToken = default)
		{
			return table.FirstOrDefaultAsync(e => e.Id == id, cancellationToken);
		}

		public static IQueryable<CollatedTable> FindQuery(this ITable<CollatedTable> table, int id)
		{
			return table.Where(e => e.Id == id);
		}

		public static CollatedTable? Find(this ITable<CollatedTable> table, CollatedTable @record)
		{
			return table.FirstOrDefault(e => e.Id == @record.Id);
		}

		public static Task<CollatedTable?> FindAsync(this ITable<CollatedTable> table, CollatedTable @record, CancellationToken cancellationToken = default)
		{
			return table.FirstOrDefaultAsync(e => e.Id == @record.Id, cancellationToken);
		}

		public static IQueryable<CollatedTable> FindQuery(this ITable<CollatedTable> table, CollatedTable @record)
		{
			return table.Where(e => e.Id == @record.Id);
		}

		public static CollatedTable? FindCollatedTable(this TestDataDB db, int id)
		{
			return db.GetTable<CollatedTable>().FirstOrDefault(e => e.Id == id);
		}

		public static Task<CollatedTable?> FindCollatedTableAsync(this TestDataDB db, int id, CancellationToken cancellationToken = default)
		{
			return db.GetTable<CollatedTable>().FirstOrDefaultAsync(e => e.Id == id, cancellationToken);
		}

		public static IQueryable<CollatedTable> FindCollatedTableQuery(this TestDataDB db, int id)
		{
			return db.GetTable<CollatedTable>().Where(e => e.Id == id);
		}

		public static CollatedTable? Find(this TestDataDB db, CollatedTable @record)
		{
			return db.GetTable<CollatedTable>().FirstOrDefault(e => e.Id == @record.Id);
		}

		public static Task<CollatedTable?> FindAsync(this TestDataDB db, CollatedTable @record, CancellationToken cancellationToken = default)
		{
			return db.GetTable<CollatedTable>().FirstOrDefaultAsync(e => e.Id == @record.Id, cancellationToken);
		}

		public static IQueryable<CollatedTable> FindQuery(this TestDataDB db, CollatedTable @record)
		{
			return db.GetTable<CollatedTable>().Where(e => e.Id == @record.Id);
		}

		public static Doctor? Find(this ITable<Doctor> table, int personId)
		{
			return table.FirstOrDefault(e => e.PersonId == personId);
		}

		public static Task<Doctor?> FindAsync(this ITable<Doctor> table, int personId, CancellationToken cancellationToken = default)
		{
			return table.FirstOrDefaultAsync(e => e.PersonId == personId, cancellationToken);
		}

		public static IQueryable<Doctor> FindQuery(this ITable<Doctor> table, int personId)
		{
			return table.Where(e => e.PersonId == personId);
		}

		public static Doctor? Find(this ITable<Doctor> table, Doctor @record)
		{
			return table.FirstOrDefault(e => e.PersonId == @record.PersonId);
		}

		public static Task<Doctor?> FindAsync(this ITable<Doctor> table, Doctor @record, CancellationToken cancellationToken = default)
		{
			return table.FirstOrDefaultAsync(e => e.PersonId == @record.PersonId, cancellationToken);
		}

		public static IQueryable<Doctor> FindQuery(this ITable<Doctor> table, Doctor @record)
		{
			return table.Where(e => e.PersonId == @record.PersonId);
		}

		public static Doctor? FindDoctor(this TestDataDB db, int personId)
		{
			return db.GetTable<Doctor>().FirstOrDefault(e => e.PersonId == personId);
		}

		public static Task<Doctor?> FindDoctorAsync(this TestDataDB db, int personId, CancellationToken cancellationToken = default)
		{
			return db.GetTable<Doctor>().FirstOrDefaultAsync(e => e.PersonId == personId, cancellationToken);
		}

		public static IQueryable<Doctor> FindDoctorQuery(this TestDataDB db, int personId)
		{
			return db.GetTable<Doctor>().Where(e => e.PersonId == personId);
		}

		public static Doctor? Find(this TestDataDB db, Doctor @record)
		{
			return db.GetTable<Doctor>().FirstOrDefault(e => e.PersonId == @record.PersonId);
		}

		public static Task<Doctor?> FindAsync(this TestDataDB db, Doctor @record, CancellationToken cancellationToken = default)
		{
			return db.GetTable<Doctor>().FirstOrDefaultAsync(e => e.PersonId == @record.PersonId, cancellationToken);
		}

		public static IQueryable<Doctor> FindQuery(this TestDataDB db, Doctor @record)
		{
			return db.GetTable<Doctor>().Where(e => e.PersonId == @record.PersonId);
		}

		public static InheritanceChild? Find(this ITable<InheritanceChild> table, int inheritanceChildId)
		{
			return table.FirstOrDefault(e => e.InheritanceChildId == inheritanceChildId);
		}

		public static Task<InheritanceChild?> FindAsync(this ITable<InheritanceChild> table, int inheritanceChildId, CancellationToken cancellationToken = default)
		{
			return table.FirstOrDefaultAsync(e => e.InheritanceChildId == inheritanceChildId, cancellationToken);
		}

		public static IQueryable<InheritanceChild> FindQuery(this ITable<InheritanceChild> table, int inheritanceChildId)
		{
			return table.Where(e => e.InheritanceChildId == inheritanceChildId);
		}

		public static InheritanceChild? Find(this ITable<InheritanceChild> table, InheritanceChild @record)
		{
			return table.FirstOrDefault(e => e.InheritanceChildId == @record.InheritanceChildId);
		}

		public static Task<InheritanceChild?> FindAsync(this ITable<InheritanceChild> table, InheritanceChild @record, CancellationToken cancellationToken = default)
		{
			return table.FirstOrDefaultAsync(e => e.InheritanceChildId == @record.InheritanceChildId, cancellationToken);
		}

		public static IQueryable<InheritanceChild> FindQuery(this ITable<InheritanceChild> table, InheritanceChild @record)
		{
			return table.Where(e => e.InheritanceChildId == @record.InheritanceChildId);
		}

		public static InheritanceChild? FindInheritanceChild(this TestDataDB db, int inheritanceChildId)
		{
			return db.GetTable<InheritanceChild>().FirstOrDefault(e => e.InheritanceChildId == inheritanceChildId);
		}

		public static Task<InheritanceChild?> FindInheritanceChildAsync(this TestDataDB db, int inheritanceChildId, CancellationToken cancellationToken = default)
		{
			return db.GetTable<InheritanceChild>().FirstOrDefaultAsync(e => e.InheritanceChildId == inheritanceChildId, cancellationToken);
		}

		public static IQueryable<InheritanceChild> FindInheritanceChildQuery(this TestDataDB db, int inheritanceChildId)
		{
			return db.GetTable<InheritanceChild>().Where(e => e.InheritanceChildId == inheritanceChildId);
		}

		public static InheritanceChild? Find(this TestDataDB db, InheritanceChild @record)
		{
			return db.GetTable<InheritanceChild>().FirstOrDefault(e => e.InheritanceChildId == @record.InheritanceChildId);
		}

		public static Task<InheritanceChild?> FindAsync(this TestDataDB db, InheritanceChild @record, CancellationToken cancellationToken = default)
		{
			return db.GetTable<InheritanceChild>().FirstOrDefaultAsync(e => e.InheritanceChildId == @record.InheritanceChildId, cancellationToken);
		}

		public static IQueryable<InheritanceChild> FindQuery(this TestDataDB db, InheritanceChild @record)
		{
			return db.GetTable<InheritanceChild>().Where(e => e.InheritanceChildId == @record.InheritanceChildId);
		}

		public static InheritanceParent? Find(this ITable<InheritanceParent> table, int inheritanceParentId)
		{
			return table.FirstOrDefault(e => e.InheritanceParentId == inheritanceParentId);
		}

		public static Task<InheritanceParent?> FindAsync(this ITable<InheritanceParent> table, int inheritanceParentId, CancellationToken cancellationToken = default)
		{
			return table.FirstOrDefaultAsync(e => e.InheritanceParentId == inheritanceParentId, cancellationToken);
		}

		public static IQueryable<InheritanceParent> FindQuery(this ITable<InheritanceParent> table, int inheritanceParentId)
		{
			return table.Where(e => e.InheritanceParentId == inheritanceParentId);
		}

		public static InheritanceParent? Find(this ITable<InheritanceParent> table, InheritanceParent @record)
		{
			return table.FirstOrDefault(e => e.InheritanceParentId == @record.InheritanceParentId);
		}

		public static Task<InheritanceParent?> FindAsync(this ITable<InheritanceParent> table, InheritanceParent @record, CancellationToken cancellationToken = default)
		{
			return table.FirstOrDefaultAsync(e => e.InheritanceParentId == @record.InheritanceParentId, cancellationToken);
		}

		public static IQueryable<InheritanceParent> FindQuery(this ITable<InheritanceParent> table, InheritanceParent @record)
		{
			return table.Where(e => e.InheritanceParentId == @record.InheritanceParentId);
		}

		public static InheritanceParent? FindInheritanceParent(this TestDataDB db, int inheritanceParentId)
		{
			return db.GetTable<InheritanceParent>().FirstOrDefault(e => e.InheritanceParentId == inheritanceParentId);
		}

		public static Task<InheritanceParent?> FindInheritanceParentAsync(this TestDataDB db, int inheritanceParentId, CancellationToken cancellationToken = default)
		{
			return db.GetTable<InheritanceParent>().FirstOrDefaultAsync(e => e.InheritanceParentId == inheritanceParentId, cancellationToken);
		}

		public static IQueryable<InheritanceParent> FindInheritanceParentQuery(this TestDataDB db, int inheritanceParentId)
		{
			return db.GetTable<InheritanceParent>().Where(e => e.InheritanceParentId == inheritanceParentId);
		}

		public static InheritanceParent? Find(this TestDataDB db, InheritanceParent @record)
		{
			return db.GetTable<InheritanceParent>().FirstOrDefault(e => e.InheritanceParentId == @record.InheritanceParentId);
		}

		public static Task<InheritanceParent?> FindAsync(this TestDataDB db, InheritanceParent @record, CancellationToken cancellationToken = default)
		{
			return db.GetTable<InheritanceParent>().FirstOrDefaultAsync(e => e.InheritanceParentId == @record.InheritanceParentId, cancellationToken);
		}

		public static IQueryable<InheritanceParent> FindQuery(this TestDataDB db, InheritanceParent @record)
		{
			return db.GetTable<InheritanceParent>().Where(e => e.InheritanceParentId == @record.InheritanceParentId);
		}

		public static LinqDataType? Find(this ITable<LinqDataType> table, int id)
		{
			return table.FirstOrDefault(e => e.Id == id);
		}

		public static Task<LinqDataType?> FindAsync(this ITable<LinqDataType> table, int id, CancellationToken cancellationToken = default)
		{
			return table.FirstOrDefaultAsync(e => e.Id == id, cancellationToken);
		}

		public static IQueryable<LinqDataType> FindQuery(this ITable<LinqDataType> table, int id)
		{
			return table.Where(e => e.Id == id);
		}

		public static LinqDataType? Find(this ITable<LinqDataType> table, LinqDataType @record)
		{
			return table.FirstOrDefault(e => e.Id == @record.Id);
		}

		public static Task<LinqDataType?> FindAsync(this ITable<LinqDataType> table, LinqDataType @record, CancellationToken cancellationToken = default)
		{
			return table.FirstOrDefaultAsync(e => e.Id == @record.Id, cancellationToken);
		}

		public static IQueryable<LinqDataType> FindQuery(this ITable<LinqDataType> table, LinqDataType @record)
		{
			return table.Where(e => e.Id == @record.Id);
		}

		public static LinqDataType? FindLinqDataType(this TestDataDB db, int id)
		{
			return db.GetTable<LinqDataType>().FirstOrDefault(e => e.Id == id);
		}

		public static Task<LinqDataType?> FindLinqDataTypeAsync(this TestDataDB db, int id, CancellationToken cancellationToken = default)
		{
			return db.GetTable<LinqDataType>().FirstOrDefaultAsync(e => e.Id == id, cancellationToken);
		}

		public static IQueryable<LinqDataType> FindLinqDataTypeQuery(this TestDataDB db, int id)
		{
			return db.GetTable<LinqDataType>().Where(e => e.Id == id);
		}

		public static LinqDataType? Find(this TestDataDB db, LinqDataType @record)
		{
			return db.GetTable<LinqDataType>().FirstOrDefault(e => e.Id == @record.Id);
		}

		public static Task<LinqDataType?> FindAsync(this TestDataDB db, LinqDataType @record, CancellationToken cancellationToken = default)
		{
			return db.GetTable<LinqDataType>().FirstOrDefaultAsync(e => e.Id == @record.Id, cancellationToken);
		}

		public static IQueryable<LinqDataType> FindQuery(this TestDataDB db, LinqDataType @record)
		{
			return db.GetTable<LinqDataType>().Where(e => e.Id == @record.Id);
		}

		public static Patient? Find(this ITable<Patient> table, int personId)
		{
			return table.FirstOrDefault(e => e.PersonId == personId);
		}

		public static Task<Patient?> FindAsync(this ITable<Patient> table, int personId, CancellationToken cancellationToken = default)
		{
			return table.FirstOrDefaultAsync(e => e.PersonId == personId, cancellationToken);
		}

		public static IQueryable<Patient> FindQuery(this ITable<Patient> table, int personId)
		{
			return table.Where(e => e.PersonId == personId);
		}

		public static Patient? Find(this ITable<Patient> table, Patient @record)
		{
			return table.FirstOrDefault(e => e.PersonId == @record.PersonId);
		}

		public static Task<Patient?> FindAsync(this ITable<Patient> table, Patient @record, CancellationToken cancellationToken = default)
		{
			return table.FirstOrDefaultAsync(e => e.PersonId == @record.PersonId, cancellationToken);
		}

		public static IQueryable<Patient> FindQuery(this ITable<Patient> table, Patient @record)
		{
			return table.Where(e => e.PersonId == @record.PersonId);
		}

		public static Patient? FindPatient(this TestDataDB db, int personId)
		{
			return db.GetTable<Patient>().FirstOrDefault(e => e.PersonId == personId);
		}

		public static Task<Patient?> FindPatientAsync(this TestDataDB db, int personId, CancellationToken cancellationToken = default)
		{
			return db.GetTable<Patient>().FirstOrDefaultAsync(e => e.PersonId == personId, cancellationToken);
		}

		public static IQueryable<Patient> FindPatientQuery(this TestDataDB db, int personId)
		{
			return db.GetTable<Patient>().Where(e => e.PersonId == personId);
		}

		public static Patient? Find(this TestDataDB db, Patient @record)
		{
			return db.GetTable<Patient>().FirstOrDefault(e => e.PersonId == @record.PersonId);
		}

		public static Task<Patient?> FindAsync(this TestDataDB db, Patient @record, CancellationToken cancellationToken = default)
		{
			return db.GetTable<Patient>().FirstOrDefaultAsync(e => e.PersonId == @record.PersonId, cancellationToken);
		}

		public static IQueryable<Patient> FindQuery(this TestDataDB db, Patient @record)
		{
			return db.GetTable<Patient>().Where(e => e.PersonId == @record.PersonId);
		}

		public static Person? Find(this ITable<Person> table, int personId)
		{
			return table.FirstOrDefault(e => e.PersonId == personId);
		}

		public static Task<Person?> FindAsync(this ITable<Person> table, int personId, CancellationToken cancellationToken = default)
		{
			return table.FirstOrDefaultAsync(e => e.PersonId == personId, cancellationToken);
		}

		public static IQueryable<Person> FindQuery(this ITable<Person> table, int personId)
		{
			return table.Where(e => e.PersonId == personId);
		}

		public static Person? Find(this ITable<Person> table, Person @record)
		{
			return table.FirstOrDefault(e => e.PersonId == @record.PersonId);
		}

		public static Task<Person?> FindAsync(this ITable<Person> table, Person @record, CancellationToken cancellationToken = default)
		{
			return table.FirstOrDefaultAsync(e => e.PersonId == @record.PersonId, cancellationToken);
		}

		public static IQueryable<Person> FindQuery(this ITable<Person> table, Person @record)
		{
			return table.Where(e => e.PersonId == @record.PersonId);
		}

		public static Person? FindPerson(this TestDataDB db, int personId)
		{
			return db.GetTable<Person>().FirstOrDefault(e => e.PersonId == personId);
		}

		public static Task<Person?> FindPersonAsync(this TestDataDB db, int personId, CancellationToken cancellationToken = default)
		{
			return db.GetTable<Person>().FirstOrDefaultAsync(e => e.PersonId == personId, cancellationToken);
		}

		public static IQueryable<Person> FindPersonQuery(this TestDataDB db, int personId)
		{
			return db.GetTable<Person>().Where(e => e.PersonId == personId);
		}

		public static Person? Find(this TestDataDB db, Person @record)
		{
			return db.GetTable<Person>().FirstOrDefault(e => e.PersonId == @record.PersonId);
		}

		public static Task<Person?> FindAsync(this TestDataDB db, Person @record, CancellationToken cancellationToken = default)
		{
			return db.GetTable<Person>().FirstOrDefaultAsync(e => e.PersonId == @record.PersonId, cancellationToken);
		}

		public static IQueryable<Person> FindQuery(this TestDataDB db, Person @record)
		{
			return db.GetTable<Person>().Where(e => e.PersonId == @record.PersonId);
		}

		public static ReplacingMergeTreeTable? Find(this ITable<ReplacingMergeTreeTable> table, uint id)
		{
			return table.FirstOrDefault(e => e.Id == id);
		}

		public static Task<ReplacingMergeTreeTable?> FindAsync(this ITable<ReplacingMergeTreeTable> table, uint id, CancellationToken cancellationToken = default)
		{
			return table.FirstOrDefaultAsync(e => e.Id == id, cancellationToken);
		}

		public static IQueryable<ReplacingMergeTreeTable> FindQuery(this ITable<ReplacingMergeTreeTable> table, uint id)
		{
			return table.Where(e => e.Id == id);
		}

		public static ReplacingMergeTreeTable? Find(this ITable<ReplacingMergeTreeTable> table, ReplacingMergeTreeTable @record)
		{
			return table.FirstOrDefault(e => e.Id == @record.Id);
		}

		public static Task<ReplacingMergeTreeTable?> FindAsync(this ITable<ReplacingMergeTreeTable> table, ReplacingMergeTreeTable @record, CancellationToken cancellationToken = default)
		{
			return table.FirstOrDefaultAsync(e => e.Id == @record.Id, cancellationToken);
		}

		public static IQueryable<ReplacingMergeTreeTable> FindQuery(this ITable<ReplacingMergeTreeTable> table, ReplacingMergeTreeTable @record)
		{
			return table.Where(e => e.Id == @record.Id);
		}

		public static ReplacingMergeTreeTable? FindReplacingMergeTreeTable(this TestDataDB db, uint id)
		{
			return db.GetTable<ReplacingMergeTreeTable>().FirstOrDefault(e => e.Id == id);
		}

		public static Task<ReplacingMergeTreeTable?> FindReplacingMergeTreeTableAsync(this TestDataDB db, uint id, CancellationToken cancellationToken = default)
		{
			return db.GetTable<ReplacingMergeTreeTable>().FirstOrDefaultAsync(e => e.Id == id, cancellationToken);
		}

		public static IQueryable<ReplacingMergeTreeTable> FindReplacingMergeTreeTableQuery(this TestDataDB db, uint id)
		{
			return db.GetTable<ReplacingMergeTreeTable>().Where(e => e.Id == id);
		}

		public static ReplacingMergeTreeTable? Find(this TestDataDB db, ReplacingMergeTreeTable @record)
		{
			return db.GetTable<ReplacingMergeTreeTable>().FirstOrDefault(e => e.Id == @record.Id);
		}

		public static Task<ReplacingMergeTreeTable?> FindAsync(this TestDataDB db, ReplacingMergeTreeTable @record, CancellationToken cancellationToken = default)
		{
			return db.GetTable<ReplacingMergeTreeTable>().FirstOrDefaultAsync(e => e.Id == @record.Id, cancellationToken);
		}

		public static IQueryable<ReplacingMergeTreeTable> FindQuery(this TestDataDB db, ReplacingMergeTreeTable @record)
		{
			return db.GetTable<ReplacingMergeTreeTable>().Where(e => e.Id == @record.Id);
		}

		public static TestMerge1? Find(this ITable<TestMerge1> table, int id)
		{
			return table.FirstOrDefault(e => e.Id == id);
		}

		public static Task<TestMerge1?> FindAsync(this ITable<TestMerge1> table, int id, CancellationToken cancellationToken = default)
		{
			return table.FirstOrDefaultAsync(e => e.Id == id, cancellationToken);
		}

		public static IQueryable<TestMerge1> FindQuery(this ITable<TestMerge1> table, int id)
		{
			return table.Where(e => e.Id == id);
		}

		public static TestMerge1? Find(this ITable<TestMerge1> table, TestMerge1 @record)
		{
			return table.FirstOrDefault(e => e.Id == @record.Id);
		}

		public static Task<TestMerge1?> FindAsync(this ITable<TestMerge1> table, TestMerge1 @record, CancellationToken cancellationToken = default)
		{
			return table.FirstOrDefaultAsync(e => e.Id == @record.Id, cancellationToken);
		}

		public static IQueryable<TestMerge1> FindQuery(this ITable<TestMerge1> table, TestMerge1 @record)
		{
			return table.Where(e => e.Id == @record.Id);
		}

		public static TestMerge1? FindTestMerge1(this TestDataDB db, int id)
		{
			return db.GetTable<TestMerge1>().FirstOrDefault(e => e.Id == id);
		}

		public static Task<TestMerge1?> FindTestMerge1Async(this TestDataDB db, int id, CancellationToken cancellationToken = default)
		{
			return db.GetTable<TestMerge1>().FirstOrDefaultAsync(e => e.Id == id, cancellationToken);
		}

		public static IQueryable<TestMerge1> FindTestMerge1Query(this TestDataDB db, int id)
		{
			return db.GetTable<TestMerge1>().Where(e => e.Id == id);
		}

		public static TestMerge1? Find(this TestDataDB db, TestMerge1 @record)
		{
			return db.GetTable<TestMerge1>().FirstOrDefault(e => e.Id == @record.Id);
		}

		public static Task<TestMerge1?> FindAsync(this TestDataDB db, TestMerge1 @record, CancellationToken cancellationToken = default)
		{
			return db.GetTable<TestMerge1>().FirstOrDefaultAsync(e => e.Id == @record.Id, cancellationToken);
		}

		public static IQueryable<TestMerge1> FindQuery(this TestDataDB db, TestMerge1 @record)
		{
			return db.GetTable<TestMerge1>().Where(e => e.Id == @record.Id);
		}

		public static TestMerge2? Find(this ITable<TestMerge2> table, int id)
		{
			return table.FirstOrDefault(e => e.Id == id);
		}

		public static Task<TestMerge2?> FindAsync(this ITable<TestMerge2> table, int id, CancellationToken cancellationToken = default)
		{
			return table.FirstOrDefaultAsync(e => e.Id == id, cancellationToken);
		}

		public static IQueryable<TestMerge2> FindQuery(this ITable<TestMerge2> table, int id)
		{
			return table.Where(e => e.Id == id);
		}

		public static TestMerge2? Find(this ITable<TestMerge2> table, TestMerge2 @record)
		{
			return table.FirstOrDefault(e => e.Id == @record.Id);
		}

		public static Task<TestMerge2?> FindAsync(this ITable<TestMerge2> table, TestMerge2 @record, CancellationToken cancellationToken = default)
		{
			return table.FirstOrDefaultAsync(e => e.Id == @record.Id, cancellationToken);
		}

		public static IQueryable<TestMerge2> FindQuery(this ITable<TestMerge2> table, TestMerge2 @record)
		{
			return table.Where(e => e.Id == @record.Id);
		}

		public static TestMerge2? FindTestMerge2(this TestDataDB db, int id)
		{
			return db.GetTable<TestMerge2>().FirstOrDefault(e => e.Id == id);
		}

		public static Task<TestMerge2?> FindTestMerge2Async(this TestDataDB db, int id, CancellationToken cancellationToken = default)
		{
			return db.GetTable<TestMerge2>().FirstOrDefaultAsync(e => e.Id == id, cancellationToken);
		}

		public static IQueryable<TestMerge2> FindTestMerge2Query(this TestDataDB db, int id)
		{
			return db.GetTable<TestMerge2>().Where(e => e.Id == id);
		}

		public static TestMerge2? Find(this TestDataDB db, TestMerge2 @record)
		{
			return db.GetTable<TestMerge2>().FirstOrDefault(e => e.Id == @record.Id);
		}

		public static Task<TestMerge2?> FindAsync(this TestDataDB db, TestMerge2 @record, CancellationToken cancellationToken = default)
		{
			return db.GetTable<TestMerge2>().FirstOrDefaultAsync(e => e.Id == @record.Id, cancellationToken);
		}

		public static IQueryable<TestMerge2> FindQuery(this TestDataDB db, TestMerge2 @record)
		{
			return db.GetTable<TestMerge2>().Where(e => e.Id == @record.Id);
		}
		#endregion
	}
}
