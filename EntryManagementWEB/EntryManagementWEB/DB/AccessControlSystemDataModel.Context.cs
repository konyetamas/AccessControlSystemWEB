﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EntryManagementWEB.DB
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class AccessControlSystemEntities : DbContext
    {
        public AccessControlSystemEntities()
            : base("name=AccessControlSystemEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Company> Companies { get; set; }
        public virtual DbSet<Entry> Entries { get; set; }
        public virtual DbSet<Member> Members { get; set; }
        public virtual DbSet<MessageFromBuilding> MessageFromBuildings { get; set; }
        public virtual DbSet<MessageFromCompany> MessageFromCompanies { get; set; }
        public virtual DbSet<MessagesOfCompany> MessagesOfCompanies { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<User> Users { get; set; }
    }
}
