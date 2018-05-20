using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SustavZaVodjenjeRadnika.Models;

namespace SustavZaVodjenjeRadnika.Controllers
{
    public class PlaceController : Controller
    {
        SustavZaVodjenjeRadnikaEntities db = new SustavZaVodjenjeRadnikaEntities();
        // GET: Place
        public ActionResult IspisPlace()
        {
            if (Session["AdminID"] == null)
            {
                return Redirect("/Login/Login");
            }

            var model = db.Place.Where(p => p.zaposlenik_id == 2);
            return View(model);
            
        }

      
    }
}