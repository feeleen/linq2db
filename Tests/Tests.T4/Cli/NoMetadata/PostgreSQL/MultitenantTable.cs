// ---------------------------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by LinqToDB scaffolding tool (https://github.com/linq2db/linq2db).
// Changes to this file may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
// ---------------------------------------------------------------------------------------------------

using System;

#pragma warning disable 1573, 1591
#nullable enable

namespace Cli.NoMetadata.PostgreSQL
{
	public class MultitenantTable
	{
		public Guid     Tenantid    { get; set; } // uuid
		public Guid     Id          { get; set; } // uuid
		public string?  Name        { get; set; } // character varying(100)
		public string?  Description { get; set; } // text
		public DateTime Createdat   { get; set; } // timestamp (6) without time zone
	}
}
