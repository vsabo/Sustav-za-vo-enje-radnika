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
    
    public partial class Kontrola_rada
    {
        public int zaposlenik_id { get; set; }
        public System.DateTime datum { get; set; }
        public Nullable<System.TimeSpan> pocetak_rada { get; set; }
        public Nullable<System.TimeSpan> kraj_rada { get; set; }
    
        public virtual Zaposlenici Zaposlenici { get; set; }
    }
}