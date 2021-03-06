﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class EntityEntities : DbContext
    {
        public EntityEntities()
            : base("name=EntityEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<address> addresses { get; set; }
        public virtual DbSet<book> books { get; set; }
        public virtual DbSet<checkout> checkouts { get; set; }
        public virtual DbSet<REGISTER> REGISTERs { get; set; }
        public virtual DbSet<review> reviews { get; set; }
    
        public virtual int sp_REGISTER(Nullable<int> task, string fNAME, string lNAME, string eMAILID, string pASSWORD)
        {
            var taskParameter = task.HasValue ?
                new ObjectParameter("Task", task) :
                new ObjectParameter("Task", typeof(int));
    
            var fNAMEParameter = fNAME != null ?
                new ObjectParameter("FNAME", fNAME) :
                new ObjectParameter("FNAME", typeof(string));
    
            var lNAMEParameter = lNAME != null ?
                new ObjectParameter("LNAME", lNAME) :
                new ObjectParameter("LNAME", typeof(string));
    
            var eMAILIDParameter = eMAILID != null ?
                new ObjectParameter("EMAILID", eMAILID) :
                new ObjectParameter("EMAILID", typeof(string));
    
            var pASSWORDParameter = pASSWORD != null ?
                new ObjectParameter("PASSWORD", pASSWORD) :
                new ObjectParameter("PASSWORD", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_REGISTER", taskParameter, fNAMEParameter, lNAMEParameter, eMAILIDParameter, pASSWORDParameter);
        }
    }
}
