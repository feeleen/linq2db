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

namespace Cli.All.Sybase
{
	[Table("sysquerymetrics", IsView = true)]
	public class Sysquerymetric
	{
		[Column("uid"      , DataType = DataType.Int32  , DbType = "int"         , Length = 4  )] public int     Uid      { get; set; } // int
		[Column("gid"      , DataType = DataType.Int32  , DbType = "int"         , Length = 4  )] public int     Gid      { get; set; } // int
		[Column("hashkey"  , DataType = DataType.Int32  , DbType = "int"         , Length = 4  )] public int     Hashkey  { get; set; } // int
		[Column("id"       , DataType = DataType.Int32  , DbType = "int"         , Length = 4  )] public int     Id       { get; set; } // int
		[Column("sequence" , DataType = DataType.Int16  , DbType = "smallint"    , Length = 2  )] public short   Sequence { get; set; } // smallint
		[Column("exec_min" , DbType   = "ubigint"       , Length = 8                           )] public ulong?  ExecMin  { get; set; } // ubigint
		[Column("exec_max" , DbType   = "ubigint"       , Length = 8                           )] public ulong?  ExecMax  { get; set; } // ubigint
		[Column("exec_avg" , DbType   = "ubigint"       , Length = 8                           )] public ulong?  ExecAvg  { get; set; } // ubigint
		[Column("elap_min" , DbType   = "ubigint"       , Length = 8                           )] public ulong?  ElapMin  { get; set; } // ubigint
		[Column("elap_max" , DbType   = "ubigint"       , Length = 8                           )] public ulong?  ElapMax  { get; set; } // ubigint
		[Column("elap_avg" , DbType   = "ubigint"       , Length = 8                           )] public ulong?  ElapAvg  { get; set; } // ubigint
		[Column("lio_min"  , DbType   = "ubigint"       , Length = 8                           )] public ulong?  LioMin   { get; set; } // ubigint
		[Column("lio_max"  , DbType   = "ubigint"       , Length = 8                           )] public ulong?  LioMax   { get; set; } // ubigint
		[Column("lio_avg"  , DbType   = "ubigint"       , Length = 8                           )] public ulong?  LioAvg   { get; set; } // ubigint
		[Column("pio_min"  , DbType   = "ubigint"       , Length = 8                           )] public ulong?  PioMin   { get; set; } // ubigint
		[Column("pio_max"  , DbType   = "ubigint"       , Length = 8                           )] public ulong?  PioMax   { get; set; } // ubigint
		[Column("pio_avg"  , DbType   = "ubigint"       , Length = 8                           )] public ulong?  PioAvg   { get; set; } // ubigint
		[Column("cnt"      , DbType   = "ubigint"       , Length = 8                           )] public ulong?  Cnt      { get; set; } // ubigint
		[Column("abort_cnt", DbType   = "ubigint"       , Length = 8                           )] public ulong?  AbortCnt { get; set; } // ubigint
		[Column("qtext"    , DataType = DataType.VarChar, DbType = "varchar(510)", Length = 510)] public string? Qtext    { get; set; } // varchar(510)
	}
}
