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
    
    public partial class Tip_zadataka
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tip_zadataka()
        {
            this.Zadaci = new HashSet<Zadaci>();
        }
        [Display(Name = "Tip zadatka ")]
        public int id { get; set; }
        [Display(Name = "Tip zadatka ")]
        public string naziv { get; set; }
        [Display(Name = "Opis")]
        public string opis { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Zadaci> Zadaci { get; set; }
    }
}