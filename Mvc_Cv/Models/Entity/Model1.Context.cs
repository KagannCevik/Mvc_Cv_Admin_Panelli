﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Mvc_Cv.Models.Entity
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Mvc5_Sıfırdan_Admin_CvEntities : DbContext
    {
        public Mvc5_Sıfırdan_Admin_CvEntities()
            : base("name=Mvc5_Sıfırdan_Admin_CvEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<TBLADMIN> TBLADMIN { get; set; }
        public virtual DbSet<TBLDENEYIMLERIM> TBLDENEYIMLERIM { get; set; }
        public virtual DbSet<TBLEGITIM> TBLEGITIM { get; set; }
        public virtual DbSet<TBLHAKKIMDA> TBLHAKKIMDA { get; set; }
        public virtual DbSet<TBLHOBILERIM> TBLHOBILERIM { get; set; }
        public virtual DbSet<TBLILETISIM> TBLILETISIM { get; set; }
        public virtual DbSet<TBLSERTIFIKALARIM> TBLSERTIFIKALARIM { get; set; }
        public virtual DbSet<TBLYETENEKLERIM> TBLYETENEKLERIM { get; set; }
        public virtual DbSet<TBLSOSYALMEDYA> TBLSOSYALMEDYA { get; set; }
    }
}
