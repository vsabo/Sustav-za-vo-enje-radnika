﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SustavZaVodjenjeRadnika.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class SustavZaVodjenjeRadnikaEntities : DbContext
    {
        public SustavZaVodjenjeRadnikaEntities()
            : base("name=SustavZaVodjenjeRadnikaEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Administratori> Administratori { get; set; }
        public virtual DbSet<Bonus> Bonus { get; set; }
        public virtual DbSet<Clanovi_projekta> Clanovi_projekta { get; set; }
        public virtual DbSet<Kontrola_rada> Kontrola_rada { get; set; }
        public virtual DbSet<Mjesec> Mjesec { get; set; }
        public virtual DbSet<Odbitak> Odbitak { get; set; }
        public virtual DbSet<Odjeli> Odjeli { get; set; }
        public virtual DbSet<Place> Place { get; set; }
        public virtual DbSet<Projekti> Projekti { get; set; }
        public virtual DbSet<Satnica> Satnica { get; set; }
        public virtual DbSet<Tip_zadataka> Tip_zadataka { get; set; }
        public virtual DbSet<Vremenska_lista_zadataka> Vremenska_lista_zadataka { get; set; }
        public virtual DbSet<Zadaci> Zadaci { get; set; }
        public virtual DbSet<Zaposlenici> Zaposlenici { get; set; }
    }
}
