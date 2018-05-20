using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using System.Web.Mvc;
using SustavZaVodjenjeRadnika.Models;

namespace SustavZaVodjenjeRadnika.Controllers
{
    public class TipZadatkaController : Controller
    {
        SustavZaVodjenjeRadnikaEntities db = new SustavZaVodjenjeRadnikaEntities();
        // GET: TipZadatka
        public ActionResult UnesiTipZadatka()
        {
            if (Session["AdminID"] == null)
            {
                return Redirect("/Login/Login");
            }
            return View();
        }

        [HttpPost]
        public ActionResult UnesiTipZadatka([Bind(Include = "Naziv, Opis")] Tip_zadataka tip)
        {
            if (ModelState.IsValid)
            {
                db.Tip_zadataka.Add(tip);
                db.SaveChanges();
                return RedirectToAction("UnesiTipZadatka");
            }
            ModelState.Clear();
            return View();
        }

    }
}