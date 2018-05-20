using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SustavZaVodjenjeRadnika.Models
{
    public class ZadaciProjekata
    {
        public Zadaci zadatak { get; set; }
        public Projekti projekt { get; set; }
        public Tip_zadataka tip { get; set; }

    }
}