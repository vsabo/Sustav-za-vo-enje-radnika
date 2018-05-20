using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using SustavZaVodjenjeRadnika.Models;

namespace SustavZaVodjenjeRadnika.Controllers
{
    public class ZaposlenikController : Controller
    {
        SustavZaVodjenjeRadnikaEntities db = new SustavZaVodjenjeRadnikaEntities();
        // GET: Zaposlenik
        public ActionResult DodajRadnika()
        {

            ViewBag.odjel_id = new SelectList(db.Odjeli, "id", "naziv");
            if (Session["AdminID"] == null)
            {
                return Redirect("/Login/Login");
            }
            return View();
        }

        [HttpPost]
        public ActionResult DodajRadnika([Bind (Include = "id, ime, prezime, adresa, email, limit, broj_telefona, odjel_id, korisnicko_ime, lozinka")] Zaposlenici zaposlenik)
        {
            if (ModelState.IsValid)
            {
                db.Zaposlenici.Add(zaposlenik);
                db.SaveChanges();
                return RedirectToAction("DodajRadnika");

            }
            ModelState.Clear();
            return View();
        }

        public ActionResult PopisRadnika()
        {
            if (Session["AdminID"] == null)
            {
                return Redirect("/Login/Login");
            }

            var model =
                from z in db.Zaposlenici
                join o in db.Odjeli on z.odjel_id equals o.id
                select new OdjeliZaposlenika {Odjel = o, Zaposlenik = z};
            return View(model);
        }

        // GET: Odjeli/Edit/5
        public ActionResult Edit(int? id)
        {
            if (Session["AdminID"] == null)
            {
                return Redirect("/Login/Login");
            }

            ViewBag.odjel_id = new SelectList(db.Odjeli, "id", "naziv");
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
           Zaposlenici zaposlenik = db.Zaposlenici.Find(id);
            if (zaposlenik == null)
            {
                return HttpNotFound();
            }
            return View(zaposlenik);
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id, ime, prezime, adresa, email, limit, broj_telefona, odjel_id, korisnicko_ime, lozinka")] Zaposlenici zaposlenik)
        {
            if (ModelState.IsValid)
            {
                db.Entry(zaposlenik).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("PopisRadnika");
            }
            return View(zaposlenik);
        }

        // GET: Odjeli/Delete/5
        public ActionResult Delete(int? id)
        {
            if (Session["AdminID"] == null)
            {
                return Redirect("/Login/Login");
            }

            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
          Zaposlenici zaposlenik = db.Zaposlenici.Find(id);
            if (zaposlenik == null)
            {
                return HttpNotFound();
            }
            return View(zaposlenik);
        }

        // POST: Odjeli/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Zaposlenici zaposlenik = db.Zaposlenici.Find(id);
            db.Zaposlenici.Remove(zaposlenik);
            db.SaveChanges();
            return RedirectToAction("PopisRadnika");
        }
    }
}