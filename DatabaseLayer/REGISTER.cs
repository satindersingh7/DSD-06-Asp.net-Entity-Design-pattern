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
    
    public partial class REGISTER
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public REGISTER()
        {
            this.checkouts = new HashSet<checkout>();
        }
    
        public int ID { get; set; }
        public string FNAME { get; set; }
        public string LNAME { get; set; }
        public string EMAILID { get; set; }
        public string PASSWORD { get; set; }
    
        public virtual address address { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<checkout> checkouts { get; set; }
    }
}
