﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace awaami
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class db_awaamiEntities : DbContext
    {
        public db_awaamiEntities()
            : base("name=db_awaamiEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public virtual DbSet<AspNetRole> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaim> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogin> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUser> AspNetUsers { get; set; }
        public virtual DbSet<Authority> Authorities { get; set; }
        public virtual DbSet<Issue> Issues { get; set; }
        public virtual DbSet<Issue_category> Issue_category { get; set; }
        public virtual DbSet<Location> Locations { get; set; }
        public virtual DbSet<Location_type> Location_type { get; set; }
        public virtual DbSet<Person> People { get; set; }
        public virtual DbSet<Sub_location> Sub_location { get; set; }
        public virtual DbSet<UnionCouncil> UnionCouncils { get; set; }
        public virtual DbSet<database_firewall_rules> database_firewall_rules { get; set; }
    }
}
