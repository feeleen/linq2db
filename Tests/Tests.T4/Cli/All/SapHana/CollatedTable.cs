// ---------------------------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by LinqToDB scaffolding tool (https://github.com/linq2db/linq2db).
// Changes to this file may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
// ---------------------------------------------------------------------------------------------------

using LinqToDB;
using LinqToDB.Mapping;

#pragma warning disable 1573, 1591
#nullable enable

namespace Cli.All.SapHana
{
	[Table("CollatedTable")]
	public class CollatedTable
	{
		[Column("Id"             , DataType  = DataType.Int32, DbType   = "INTEGER"        , Length = 10            , Precision = 10, Scale     = 0            )] public int    Id              { get; set; } // INTEGER
		[Column("CaseSensitive"  , CanBeNull = false         , DataType = DataType.NVarChar, DbType = "NVARCHAR(20)", Length    = 20, Precision = 20, Scale = 0)] public string CaseSensitive   { get; set; } = null!; // NVARCHAR(20)
		[Column("CaseInsensitive", CanBeNull = false         , DataType = DataType.NVarChar, DbType = "NVARCHAR(20)", Length    = 20, Precision = 20, Scale = 0)] public string CaseInsensitive { get; set; } = null!; // NVARCHAR(20)
	}
}
