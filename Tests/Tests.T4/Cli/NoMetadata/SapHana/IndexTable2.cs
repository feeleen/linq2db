// ---------------------------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by LinqToDB scaffolding tool (https://github.com/linq2db/linq2db).
// Changes to this file may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
// ---------------------------------------------------------------------------------------------------


#pragma warning disable 1573, 1591
#nullable enable

namespace Cli.NoMetadata.SapHana
{
	public class IndexTable2
	{
		public int PkField1 { get; set; } // INTEGER
		public int PkField2 { get; set; } // INTEGER

		#region Associations
		/// <summary>
		/// FK_Patient2_IndexTable
		/// </summary>
		public IndexTable Patient2IndexTable { get; set; } = null!;
		#endregion
	}
}
