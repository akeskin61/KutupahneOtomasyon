﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Kutuphane_Otomasyonu
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class KutuphaneEntities : DbContext
    {
        public KutuphaneEntities()
            : base("name=KutuphaneEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Uyeler> Uyeler { get; set; }
        public virtual DbSet<Yoneticiler> Yoneticiler { get; set; }
        public virtual DbSet<Kitaplar> Kitaplar { get; set; }
        public virtual DbSet<Oduncler> Oduncler { get; set; }
    }
}
