﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataHandler
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class SuppliesBranchEntities : DbContext
    {
        public SuppliesBranchEntities()
            : base("name=SuppliesBranchEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<CategoryTbl> CategoryTbls { get; set; }
        public virtual DbSet<CompanyRegistraion> CompanyRegistraions { get; set; }
        public virtual DbSet<PaperAdd> PaperAdds { get; set; }
        public virtual DbSet<PaperAddItem> PaperAddItems { get; set; }
        public virtual DbSet<ProcumentdTbl> ProcumentdTbls { get; set; }
        public virtual DbSet<ProcumentPlan> ProcumentPlans { get; set; }
        public virtual DbSet<QuatationLetter> QuatationLetters { get; set; }
        public virtual DbSet<ReqCategory> ReqCategories { get; set; }
        public virtual DbSet<ReqestPaperAdditem> ReqestPaperAdditems { get; set; }
        public virtual DbSet<Request> Requests { get; set; }
        public virtual DbSet<RequestItem> RequestItems { get; set; }
        public virtual DbSet<RequestPaperAdd> RequestPaperAdds { get; set; }
        public virtual DbSet<RequestPerson> RequestPersons { get; set; }
        public virtual DbSet<Section> Sections { get; set; }
    }
}
