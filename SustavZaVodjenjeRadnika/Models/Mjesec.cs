//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class Mjesec
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Mjesec()
        {
            this.Place = new HashSet<Place>();
            this.Satnica = new HashSet<Satnica>();
        }
    
        public int id { get; set; }
        public string naziv { get; set; }
        public int broj_dana { get; set; }
        public int godina { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Place> Place { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Satnica> Satnica { get; set; }
    }
}