//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DevWebApps.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class NEWS_CATEGORY
    {
        public long ID { get; set; }
        public string NAME { get; set; }
        public string NOTES { get; set; }
        public string ICON { get; set; }
        public Nullable<long> IDPARENT { get; set; }
        public string SLUG { get; set; }
        public string META_TITLE { get; set; }
        public string META_KEYWORD { get; set; }
        public string META_DESCRIPTION { get; set; }
        public Nullable<System.DateTime> CREATED_DATE { get; set; }
        public Nullable<System.DateTime> UPDATED_DATE { get; set; }
        public Nullable<long> CREATED_BY { get; set; }
        public Nullable<long> UPDATED_BY { get; set; }
        public Nullable<byte> ISDELETE { get; set; }
        public Nullable<byte> ISACTIVE { get; set; }
    }
}
