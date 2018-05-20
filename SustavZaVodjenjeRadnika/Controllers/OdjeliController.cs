using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using SustavZaVodjenjeRadnika.Models;

namespace SustavZaVodjenjeRadnika.Controllers
{
    public class OdjeliController : Controller
    {
        private SustavZaVodjenjeRadnikaEntities db = new SustavZaVodjenjeRadnikaEntities();

        // GET: Odjeli
        public ActionResult Index()
        {
            return View(db.Odjeli.ToList());
        }

        // GET: Odjeli/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Odjeli odjeli = db.Odjeli.Find(id);
            if (odjeli == null)
            {
                return HttpNotFound();
            }
            return View(odjeli);
        }

        // GET: Odjeli/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Odjeli/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,naziv")] Odjeli odjeli)
        {
            if (ModelState.IsValid)
            {
                db.Odjeli.Add(odjeli);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(odjeli);
        }

        // GET: Odjeli/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Odjeli odjeli = db.Odjeli.Find(id);
            if (odjeli == null)
            {
                return HttpNotFound();
            }
            return View(odjeli);
        }

        // POST: Odjeli/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,naziv")] Odjeli odjeli)
        {
            if (ModelState.IsValid)
            {
                db.Entry(odjeli).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(odjeli);
        }

        // GET: Odjeli/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Odjeli odjeli = db.Odjeli.Find(id);
            if (odjeli == null)
            {
                return HttpNotFound();
            }
            return View(odjeli);
        }

        // POST: Odjeli/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Odjeli odjeli = db.Odjeli.Find(id);
            db.Odjeli.Remove(odjeli);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
