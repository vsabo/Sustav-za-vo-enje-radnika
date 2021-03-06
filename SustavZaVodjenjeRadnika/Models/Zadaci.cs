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
    
    public partial class Zadaci
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Zadaci()
        {
            this.Vremenska_lista_zadataka = new HashSet<Vremenska_lista_zadataka>();
        }
    
        public int id { get; set; }
        [Display(Name = "Naziv projekta")]
        public int projekt_id { get; set; }
        [Display(Name = "Ime zaposlenika")]
        public int zaposlenik_id { get; set; }
        [Display(Name = "Naziv zadatka")]
        public string naziv { get; set; }
        [Display(Name = "Opis zadatka")]
        public string opis { get; set; }
        [Display(Name = "Vrijeme pocetka")]
        public Nullable<System.DateTime> start_on { get; set; }
        [Display(Name = "Rok")]
        public Nullable<System.DateTime> rok { get; set; }
        [Display(Name = "Status (u izradi/zavrsen)")]
        public bool status { get; set; }
        [Display(Name = "Tip podatka")]
        public int tip_zadatka { get; set; }
    
        public virtual Projekti Projekti { get; set; }
        public virtual Tip_zadataka Tip_zadataka { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Vremenska_lista_zadataka> Vremenska_lista_zadataka { get; set; }
        public virtual Zaposlenici Zaposlenici { get; set; }
    }
}
