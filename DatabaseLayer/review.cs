//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DatabaseLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class review
    {
        public int id { get; set; }
        public int book_id { get; set; }
        public string reviewer_name { get; set; }
        public string content { get; set; }
        public Nullable<int> rating { get; set; }
        public Nullable<System.DateTime> published_date { get; set; }
    
        public virtual book book { get; set; }
    }
}
