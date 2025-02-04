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

namespace Cli.Default.ClickHouse.Octonica
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

		public static CollatedTable? Find(this ITable<CollatedTable> table, int id)
		{
			return table.FirstOrDefault(e => e.Id == id);
		}

		public static Task<CollatedTable?> FindAsync(this ITable<CollatedTable> table, int id, CancellationToken cancellationToken = default)
		{
			return table.FirstOrDefaultAsync(e => e.Id == id, cancellationToken);
		}

		public static Doctor? Find(this ITable<Doctor> table, int personId)
		{
			return table.FirstOrDefault(e => e.PersonId == personId);
		}

		public static Task<Doctor?> FindAsync(this ITable<Doctor> table, int personId, CancellationToken cancellationToken = default)
		{
			return table.FirstOrDefaultAsync(e => e.PersonId == personId, cancellationToken);
		}

		public static InheritanceChild? Find(this ITable<InheritanceChild> table, int inheritanceChildId)
		{
			return table.FirstOrDefault(e => e.InheritanceChildId == inheritanceChildId);
		}

		public static Task<InheritanceChild?> FindAsync(this ITable<InheritanceChild> table, int inheritanceChildId, CancellationToken cancellationToken = default)
		{
			return table.FirstOrDefaultAsync(e => e.InheritanceChildId == inheritanceChildId, cancellationToken);
		}

		public static InheritanceParent? Find(this ITable<InheritanceParent> table, int inheritanceParentId)
		{
			return table.FirstOrDefault(e => e.InheritanceParentId == inheritanceParentId);
		}

		public static Task<InheritanceParent?> FindAsync(this ITable<InheritanceParent> table, int inheritanceParentId, CancellationToken cancellationToken = default)
		{
			return table.FirstOrDefaultAsync(e => e.InheritanceParentId == inheritanceParentId, cancellationToken);
		}

		public static LinqDataType? Find(this ITable<LinqDataType> table, int id)
		{
			return table.FirstOrDefault(e => e.Id == id);
		}

		public static Task<LinqDataType?> FindAsync(this ITable<LinqDataType> table, int id, CancellationToken cancellationToken = default)
		{
			return table.FirstOrDefaultAsync(e => e.Id == id, cancellationToken);
		}

		public static Patient? Find(this ITable<Patient> table, int personId)
		{
			return table.FirstOrDefault(e => e.PersonId == personId);
		}

		public static Task<Patient?> FindAsync(this ITable<Patient> table, int personId, CancellationToken cancellationToken = default)
		{
			return table.FirstOrDefaultAsync(e => e.PersonId == personId, cancellationToken);
		}

		public static Person? Find(this ITable<Person> table, int personId)
		{
			return table.FirstOrDefault(e => e.PersonId == personId);
		}

		public static Task<Person?> FindAsync(this ITable<Person> table, int personId, CancellationToken cancellationToken = default)
		{
			return table.FirstOrDefaultAsync(e => e.PersonId == personId, cancellationToken);
		}

		public static ReplacingMergeTreeTable? Find(this ITable<ReplacingMergeTreeTable> table, uint id)
		{
			return table.FirstOrDefault(e => e.Id == id);
		}

		public static Task<ReplacingMergeTreeTable?> FindAsync(this ITable<ReplacingMergeTreeTable> table, uint id, CancellationToken cancellationToken = default)
		{
			return table.FirstOrDefaultAsync(e => e.Id == id, cancellationToken);
		}

		public static TestMerge1? Find(this ITable<TestMerge1> table, int id)
		{
			return table.FirstOrDefault(e => e.Id == id);
		}

		public static Task<TestMerge1?> FindAsync(this ITable<TestMerge1> table, int id, CancellationToken cancellationToken = default)
		{
			return table.FirstOrDefaultAsync(e => e.Id == id, cancellationToken);
		}

		public static TestMerge2? Find(this ITable<TestMerge2> table, int id)
		{
			return table.FirstOrDefault(e => e.Id == id);
		}

		public static Task<TestMerge2?> FindAsync(this ITable<TestMerge2> table, int id, CancellationToken cancellationToken = default)
		{
			return table.FirstOrDefaultAsync(e => e.Id == id, cancellationToken);
		}
		#endregion
	}
}
