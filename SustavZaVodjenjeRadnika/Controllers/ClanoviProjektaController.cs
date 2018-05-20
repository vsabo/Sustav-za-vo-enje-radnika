using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SustavZaVodjenjeRadnika.Models;

namespace SustavZaVodjenjeRadnika.Controllers
{
    public class ClanoviProjektaController : Controller
    {
        // GET: ClanoviProjekta
        public ActionResult ClanoviProjekta()
        {
            SustavZaVodjenjeRadnikaEntities db = new SustavZaVodjenjeRadnikaEntities();
            return View();
        }

        public ActionResult ClanoviProjekta(Clanovi_projekta clanovi)
        {
            return View();
        }
    }
}