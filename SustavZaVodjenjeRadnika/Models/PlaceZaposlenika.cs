using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SustavZaVodjenjeRadnika.Models
{
    public class PlaceZaposlenika
    {
        public Place place { get; set; }
        public Zaposlenici zaposlenik { get; set; }
        public Mjesec mjesec { get; set; }
        
    }
}