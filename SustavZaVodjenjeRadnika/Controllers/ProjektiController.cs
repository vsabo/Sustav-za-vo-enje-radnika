using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using SustavZaVodjenjeRadnika.Models;

namespace SustavZaVodjenjeRadnika.Controllers
{
    public class ProjektiController : Controller
    {
        SustavZaVodjenjeRadnikaEntities db = new SustavZaVodjenjeRadnikaEntities();
        // GET: Projekti
        public ActionResult UnesiProjekt()
        {
            ViewBag.odjel_id = new SelectList(db.Odjeli, "id", "naziv");
            if (Session["AdminID"] == null)
            {
                return Redirect("/Login/Login");
            }
            return View();
        }

        [HttpPost]
        public ActionResult UnesiProjekt([Bind(Include = "id, naziv, opis, start_on, odjel_id")] Projekti projekt)
        {
            if (ModelState.IsValid)
            {
                db.Projekti.Add(projekt);
                db.SaveChanges();
                return RedirectToAction("UnesiProjekt");
            }
            ModelState.Clear();
            return View();
        }

        public ActionResult PopisProjekata()
        {
            if (Session["AdminID"] == null)
            {
                return Redirect("/Login/Login");
            }
            var model =
                from p in db.Projekti
                join o in db.Odjeli on p.odjel_id equals o.id
                select new OdjeliProjekta() { Odjel = o, Projekt = p };
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
           Projekti projekt = db.Projekti.Find(id);
            if (projekt == null)
            {
                return HttpNotFound();
            }
            return View(projekt);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id, naziv, opis, start_on, odjel_id")]  Projekti projekt)
        {
            if (ModelState.IsValid)
            {
                db.Entry(projekt).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("PopisProjekata");
            }
            return View(projekt);
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
            Projekti projekt = db.Projekti.Find(id);
            if (projekt == null)
            {
                return HttpNotFound();
            }
            return View(projekt);
        }

        // POST: Odjeli/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Projekti projekt = db.Projekti.Find(id);
            db.Projekti.Remove(projekt);
            db.SaveChanges();
            return RedirectToAction("PopisProjekata");
        }

    }
}