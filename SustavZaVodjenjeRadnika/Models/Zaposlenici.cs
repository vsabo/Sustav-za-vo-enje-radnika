//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.ComponentModel.DataAnnotations;

namespace SustavZaVodjenjeRadnika.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Zaposlenici
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Zaposlenici()
        {
            this.Clanovi_projekta = new HashSet<Clanovi_projekta>();
            this.Place = new HashSet<Place>();
            this.Satnica = new HashSet<Satnica>();
            this.Kontrola_rada = new HashSet<Kontrola_rada>();
            this.Zadaci = new HashSet<Zadaci>();
        }
    
        public int id { get; set; }
        [Display(Name = "Ime")]
        public string ime { get; set; }
        [Display(Name = "Prezime")]
        public string prezime { get; set; }
        [Display(Name = "Adresa prebivalista")]
        public string adresa { get; set; }
        [Display(Name = "Email")]
        public string email { get; set; }
        [Display(Name = "Limit(radnih sati)")]
        public int limit { get; set; }
        [Display(Name = "Broj telefona")]
        public int broj_telefona { get; set; }
        [Display(Name = "Naziv odjela")]
        public int odjel_id { get; set; }
        [Display(Name = "Korisnicko ime")]
        public string korisnicko_ime { get; set; }
        [Display(Name = "Lozinka")]
        public string lozinka { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Clanovi_projekta> Clanovi_projekta { get; set; }
        public virtual Odjeli Odjeli { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Place> Place { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Satnica> Satnica { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Kontrola_rada> Kontrola_rada { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Zadaci> Zadaci { get; set; }
    }
}
