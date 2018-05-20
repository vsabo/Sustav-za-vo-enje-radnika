using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SustavZaVodjenjeRadnika.Models;

namespace SustavZaVodjenjeRadnika.Controllers
{
    public class ZadaciController : Controller
    {
        SustavZaVodjenjeRadnikaEntities db = new SustavZaVodjenjeRadnikaEntities();
        // GET: Zadaci
        public ActionResult UnesiZadatak()
        {
            ViewBag.projekt_id = new SelectList(db.Projekti, "id", "naziv");
            ViewBag.tip_zadatka = new SelectList(db.Tip_zadataka, "id", "naziv");
            ViewBag.zaposlenik_id = new SelectList(db.Zaposlenici, "id", "prezime");
            if (Session["AdminID"] == null)
            {
                return Redirect("/Login/Login");
            }
            return View();
        }

        [HttpPost]
        public ActionResult UnesiZadatak(Zadaci zadatak)
        {
            if (ModelState.IsValid)
            {
                db.Zadaci.Add(zadatak);
                db.SaveChanges();
                return RedirectToAction("UnesiZadatak");
            }
            ModelState.Clear();
            return View();
        }

        public ActionResult PopisZadataka()
        {
            if (Session["AdminID"] == null)
            {
                return Redirect("/Login/Login");
            }
            var model =
                from p in db.Projekti
                join z in db.Zadaci on p.id equals z.projekt_id
                select new ZadaciProjekata() {  zadatak = z, projekt = p };
            return View(model);

        }
    }
}