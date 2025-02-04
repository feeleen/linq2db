// ---------------------------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by LinqToDB scaffolding tool (https://github.com/linq2db/linq2db).
// Changes to this file may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
// ---------------------------------------------------------------------------------------------------

using LinqToDB;
using LinqToDB.Mapping;
using LinqToDB.Tools.Comparers;
using System;
using System.Collections.Generic;

#pragma warning disable 1573, 1591
#nullable enable

namespace Cli.All.Firebird
{
	[Table("TestMerge2")]
	public class TestMerge2 : IEquatable<TestMerge2>
	{
		[Column("Id"             , DataType = DataType.Int32   , DbType = "integer"         , IsPrimaryKey = true            )] public int       Id              { get; set; } // integer
		[Column("Field1"         , DataType = DataType.Int32   , DbType = "integer"                                          )] public int?      Field1          { get; set; } // integer
		[Column("Field2"         , DataType = DataType.Int32   , DbType = "integer"                                          )] public int?      Field2          { get; set; } // integer
		[Column("Field3"         , DataType = DataType.Int32   , DbType = "integer"                                          )] public int?      Field3          { get; set; } // integer
		[Column("Field4"         , DataType = DataType.Int32   , DbType = "integer"                                          )] public int?      Field4          { get; set; } // integer
		[Column("Field5"         , DataType = DataType.Int32   , DbType = "integer"                                          )] public int?      Field5          { get; set; } // integer
		[Column("FieldInt64"     , DataType = DataType.Int64   , DbType = "bigint"                                           )] public long?     FieldInt64      { get; set; } // bigint
		[Column("FieldBoolean"   , DataType = DataType.Boolean , DbType = "boolean"                                          )] public bool?     FieldBoolean    { get; set; } // boolean
		[Column("FieldString"    , DataType = DataType.NVarChar, DbType = "varchar(20)"     , Length       = 20              )] public string?   FieldString     { get; set; } // varchar(20)
		[Column("FieldNString"   , DataType = DataType.NVarChar, DbType = "varchar(20)"     , Length       = 20              )] public string?   FieldNString    { get; set; } // varchar(20)
		[Column("FieldChar"      , DataType = DataType.NChar   , DbType = "char(1)"         , Length       = 1               )] public char?     FieldChar       { get; set; } // char(1)
		[Column("FieldNChar"     , DataType = DataType.NChar   , DbType = "char(1)"         , Length       = 1               )] public char?     FieldNChar      { get; set; } // char(1)
		[Column("FieldFloat"     , DataType = DataType.Single  , DbType = "float"                                            )] public float?    FieldFloat      { get; set; } // float
		[Column("FieldDouble"    , DataType = DataType.Double  , DbType = "double precision"                                 )] public double?   FieldDouble     { get; set; } // double precision
		[Column("FieldDateTime"  , DataType = DataType.DateTime, DbType = "timestamp"                                        )] public DateTime? FieldDateTime   { get; set; } // timestamp
		[Column("FieldBinary"    , DataType = DataType.Blob    , DbType = "blob"                                             )] public byte[]?   FieldBinary     { get; set; } // blob
		[Column("FieldGuid"      , DataType = DataType.NChar   , DbType = "char(16)"        , Length       = 16              )] public string?   FieldGuid       { get; set; } // char(16)
		[Column("FieldDecimal"   , DataType = DataType.Decimal , DbType = "decimal(18,10)"  , Precision    = 18  , Scale = 10)] public decimal?  FieldDecimal    { get; set; } // decimal(18,10)
		[Column("FieldDate"      , DataType = DataType.Date    , DbType = "date"                                             )] public DateTime? FieldDate       { get; set; } // date
		[Column("FieldTime"      , DataType = DataType.DateTime, DbType = "timestamp"                                        )] public DateTime? FieldTime       { get; set; } // timestamp
		[Column("FieldEnumString", DataType = DataType.NVarChar, DbType = "varchar(20)"     , Length       = 20              )] public string?   FieldEnumString { get; set; } // varchar(20)
		[Column("FieldEnumNumber", DataType = DataType.Int32   , DbType = "integer"                                          )] public int?      FieldEnumNumber { get; set; } // integer

		#region IEquatable<T> support
		private static readonly IEqualityComparer<TestMerge2> _equalityComparer = ComparerBuilder.GetEqualityComparer<TestMerge2>(c => c.Id);

		public bool Equals(TestMerge2? other)
		{
			return _equalityComparer.Equals(this, other!);
		}

		public override int GetHashCode()
		{
			return _equalityComparer.GetHashCode(this);
		}

		public override bool Equals(object? obj)
		{
			return Equals(obj as TestMerge2);
		}
		#endregion
	}
}
