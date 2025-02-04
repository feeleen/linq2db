// ---------------------------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by LinqToDB scaffolding tool (https://github.com/linq2db/linq2db).
// Changes to this file may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
// ---------------------------------------------------------------------------------------------------

using LinqToDB.Mapping;
using System;

#pragma warning disable 1573, 1591
#nullable enable

namespace Cli.Default.MariaDB
{
	[Table("AllTypes")]
	public class AllType
	{
		[Column("ID"                 , IsPrimaryKey = true, IsIdentity = true, SkipOnInsert = true, SkipOnUpdate = true)] public int       Id                  { get; set; } // int(11)
		[Column("bigintDataType"                                                                                       )] public long?     BigintDataType      { get; set; } // bigint(20)
		[Column("smallintDataType"                                                                                     )] public short?    SmallintDataType    { get; set; } // smallint(6)
		[Column("tinyintDataType"                                                                                      )] public sbyte?    TinyintDataType     { get; set; } // tinyint(4)
		[Column("mediumintDataType"                                                                                    )] public int?      MediumintDataType   { get; set; } // mediumint(9)
		[Column("intDataType"                                                                                          )] public int?      IntDataType         { get; set; } // int(11)
		[Column("numericDataType"                                                                                      )] public decimal?  NumericDataType     { get; set; } // decimal(10,0)
		[Column("decimalDataType"                                                                                      )] public decimal?  DecimalDataType     { get; set; } // decimal(10,0)
		[Column("doubleDataType"                                                                                       )] public double?   DoubleDataType      { get; set; } // double
		[Column("floatDataType"                                                                                        )] public float?    FloatDataType       { get; set; } // float
		[Column("dateDataType"                                                                                         )] public DateTime? DateDataType        { get; set; } // date
		[Column("datetimeDataType"                                                                                     )] public DateTime? DatetimeDataType    { get; set; } // datetime
		[Column("timestampDataType"                                                                                    )] public DateTime? TimestampDataType   { get; set; } // timestamp
		[Column("timeDataType"                                                                                         )] public TimeSpan? TimeDataType        { get; set; } // time
		[Column("yearDataType"                                                                                         )] public int?      YearDataType        { get; set; } // year(4)
		[Column("charDataType"                                                                                         )] public char?     CharDataType        { get; set; } // char(1)
		[Column("char20DataType"                                                                                       )] public string?   Char20DataType      { get; set; } // char(20)
		[Column("varcharDataType"                                                                                      )] public string?   VarcharDataType     { get; set; } // varchar(20)
		[Column("textDataType"                                                                                         )] public string?   TextDataType        { get; set; } // text
		[Column("binaryDataType"                                                                                       )] public byte[]?   BinaryDataType      { get; set; } // binary(3)
		[Column("varbinaryDataType"                                                                                    )] public byte[]?   VarbinaryDataType   { get; set; } // varbinary(5)
		[Column("blobDataType"                                                                                         )] public byte[]?   BlobDataType        { get; set; } // blob
		[Column("bitDataType"                                                                                          )] public byte?     BitDataType         { get; set; } // bit(3)
		[Column("enumDataType"                                                                                         )] public string?   EnumDataType        { get; set; } // enum('Green','Red','Blue')
		[Column("setDataType"                                                                                          )] public string?   SetDataType         { get; set; } // set('one','two')
		[Column("intUnsignedDataType"                                                                                  )] public uint?     IntUnsignedDataType { get; set; } // int(10) unsigned
		[Column("boolDataType"                                                                                         )] public bool?     BoolDataType        { get; set; } // tinyint(1)
	}
}
