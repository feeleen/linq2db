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

namespace Cli.All.SapHana
{
	[Table("AllTypes")]
	public class AllType : IEquatable<AllType>
	{
		[Column("ID"                  , DataType = DataType.Int32        , DbType = "INTEGER"            , Length = 10        , Precision = 10        , Scale = 0, IsPrimaryKey = true, IsIdentity = true, SkipOnInsert = true, SkipOnUpdate = true)] public int       Id                   { get; set; } // INTEGER
		[Column("bigintDataType"      , DataType = DataType.Int64        , DbType = "BIGINT"             , Length = 19        , Precision = 19        , Scale = 0                                                                                  )] public long?     BigintDataType       { get; set; } // BIGINT
		[Column("smallintDataType"    , DataType = DataType.Int16        , DbType = "SMALLINT"           , Length = 5         , Precision = 5         , Scale = 0                                                                                  )] public short?    SmallintDataType     { get; set; } // SMALLINT
		[Column("decimalDataType"     , DataType = DataType.Decimal      , DbType = "DECIMAL(34, 0)"     , Length = 34        , Precision = 34        , Scale = 0                                                                                  )] public decimal?  DecimalDataType      { get; set; } // DECIMAL(34, 0)
		[Column("smalldecimalDataType", DataType = DataType.Decimal      , DbType = "SMALLDECIMAL(16, 0)", Length = 16        , Precision = 16        , Scale = 0                                                                                  )] public decimal?  SmalldecimalDataType { get; set; } // SMALLDECIMAL(16, 0)
		[Column("intDataType"         , DataType = DataType.Int32        , DbType = "INTEGER"            , Length = 10        , Precision = 10        , Scale = 0                                                                                  )] public int?      IntDataType          { get; set; } // INTEGER
		[Column("tinyintDataType"     , DataType = DataType.Byte         , DbType = "TINYINT"            , Length = 3         , Precision = 3         , Scale = 0                                                                                  )] public byte?     TinyintDataType      { get; set; } // TINYINT
		[Column("floatDataType"       , DataType = DataType.Double       , DbType = "DOUBLE"             , Length = 15        , Precision = 15        , Scale = 0                                                                                  )] public double?   FloatDataType        { get; set; } // DOUBLE
		[Column("realDataType"        , DataType = DataType.Single       , DbType = "REAL"               , Length = 7         , Precision = 7         , Scale = 0                                                                                  )] public float?    RealDataType         { get; set; } // REAL
		[Column("dateDataType"        , DataType = DataType.Date         , DbType = "DATE"               , Length = 10        , Precision = 10        , Scale = 0                                                                                  )] public DateTime? DateDataType         { get; set; } // DATE
		[Column("timeDataType"        , DataType = DataType.Time         , DbType = "TIME"               , Length = 8         , Precision = 8         , Scale = 0                                                                                  )] public TimeSpan? TimeDataType         { get; set; } // TIME
		[Column("seconddateDataType"  , DataType = DataType.SmallDateTime, DbType = "SECONDDATE"         , Length = 19        , Precision = 19        , Scale = 0                                                                                  )] public DateTime? SeconddateDataType   { get; set; } // SECONDDATE
		[Column("timestampDataType"   , DataType = DataType.Timestamp    , DbType = "TIMESTAMP"          , Length = 27        , Precision = 27        , Scale = 7                                                                                  )] public DateTime? TimestampDataType    { get; set; } // TIMESTAMP
		[Column("charDataType"        , DataType = DataType.Char         , DbType = "CHAR(1)"            , Length = 1         , Precision = 1         , Scale = 0                                                                                  )] public char?     CharDataType         { get; set; } // CHAR(1)
		[Column("char20DataType"      , DataType = DataType.Char         , DbType = "CHAR(20)"           , Length = 20        , Precision = 20        , Scale = 0                                                                                  )] public string?   Char20DataType       { get; set; } // CHAR(20)
		[Column("varcharDataType"     , DataType = DataType.VarChar      , DbType = "VARCHAR(20)"        , Length = 20        , Precision = 20        , Scale = 0                                                                                  )] public string?   VarcharDataType      { get; set; } // VARCHAR(20)
		[Column("textDataType"        , DataType = DataType.Text         , DbType = "TEXT"               , Length = 2147483647, Precision = 2147483647, Scale = 0                                                                                  )] public string?   TextDataType         { get; set; } // TEXT
		[Column("shorttextDataType"   , DataType = DataType.NVarChar     , DbType = "SHORTTEXT"          , Length = 20        , Precision = 20        , Scale = 0                                                                                  )] public string?   ShorttextDataType    { get; set; } // SHORTTEXT
		[Column("ncharDataType"       , DataType = DataType.NChar        , DbType = "NCHAR(1)"           , Length = 1         , Precision = 1         , Scale = 0                                                                                  )] public char?     NcharDataType        { get; set; } // NCHAR(1)
		[Column("nchar20DataType"     , DataType = DataType.NChar        , DbType = "NCHAR(20)"          , Length = 20        , Precision = 20        , Scale = 0                                                                                  )] public string?   Nchar20DataType      { get; set; } // NCHAR(20)
		[Column("nvarcharDataType"    , DataType = DataType.NVarChar     , DbType = "NVARCHAR(20)"       , Length = 20        , Precision = 20        , Scale = 0                                                                                  )] public string?   NvarcharDataType     { get; set; } // NVARCHAR(20)
		[Column("alphanumDataType"    , DataType = DataType.NVarChar     , DbType = "ALPHANUM"           , Length = 20        , Precision = 20        , Scale = 0                                                                                  )] public string?   AlphanumDataType     { get; set; } // ALPHANUM
		[Column("binaryDataType"      , DataType = DataType.Binary       , DbType = "BINARY(10)"         , Length = 10        , Precision = 10        , Scale = 0                                                                                  )] public byte[]?   BinaryDataType       { get; set; } // BINARY(10)
		[Column("varbinaryDataType"   , DataType = DataType.VarBinary    , DbType = "VARBINARY(10)"      , Length = 10        , Precision = 10        , Scale = 0                                                                                  )] public byte[]?   VarbinaryDataType    { get; set; } // VARBINARY(10)
		[Column("blobDataType"        , DataType = DataType.Blob         , DbType = "BLOB"               , Length = 2147483647, Precision = 2147483647, Scale = 0                                                                                  )] public byte[]?   BlobDataType         { get; set; } // BLOB
		[Column("clobDataType"        , DataType = DataType.Text         , DbType = "CLOB"               , Length = 2147483647, Precision = 2147483647, Scale = 0                                                                                  )] public string?   ClobDataType         { get; set; } // CLOB
		[Column("nclobDataType"       , DataType = DataType.NText        , DbType = "NCLOB"              , Length = 2147483647, Precision = 2147483647, Scale = 0                                                                                  )] public string?   NclobDataType        { get; set; } // NCLOB

		#region IEquatable<T> support
		private static readonly IEqualityComparer<AllType> _equalityComparer = ComparerBuilder.GetEqualityComparer<AllType>(c => c.Id);

		public bool Equals(AllType? other)
		{
			return _equalityComparer.Equals(this, other!);
		}

		public override int GetHashCode()
		{
			return _equalityComparer.GetHashCode(this);
		}

		public override bool Equals(object? obj)
		{
			return Equals(obj as AllType);
		}
		#endregion
	}
}
