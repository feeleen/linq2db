// ---------------------------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by LinqToDB scaffolding tool (https://github.com/linq2db/linq2db).
// Changes to this file may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
// ---------------------------------------------------------------------------------------------------

using LinqToDB.Mapping;

#pragma warning disable 1573, 1591
#nullable enable

namespace Cli.Interceptors.SQLite
{
	[Table("Patient")]
	public class Patient
	{
		[Column("PersonID" , IsPrimaryKey = true )] public long   PersonId  { get; internal set; } // integer
		[Column("Diagnosis", CanBeNull    = false)] public string Diagnosis { get; internal set; } = null!; // nvarchar(256)

		#region Associations
		/// <summary>
		/// FK_Patient_0_0
		/// </summary>
		[Association(CanBeNull = false, ThisKey = nameof(PersonId), OtherKey = nameof(Person.PersonId))]
		public Person FkPatient00 { get; set; } = null!;
		#endregion
	}
}
