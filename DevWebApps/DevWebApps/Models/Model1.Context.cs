﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DevWebAppsDBEntities : DbContext
    {
        public DevWebAppsDBEntities()
            : base("name=DevWebAppsDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<CATEGORY> CATEGORY { get; set; }
        public virtual DbSet<NEWS_CATEGORY> NEWS_CATEGORY { get; set; }
        public virtual DbSet<CONFIGURATIONS> CONFIGURATIONS { get; set; }
        public virtual DbSet<PAYMENT_METHOD> PAYMENT_METHOD { get; set; }
    }
}
