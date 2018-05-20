using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SustavZaVodjenjeRadnika.Models;

namespace SustavZaVodjenjeRadnika.Controllers
{
    public class LoginController : Controller
    {
        SustavZaVodjenjeRadnikaEntities db = new SustavZaVodjenjeRadnikaEntities();
        // GET: Login
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(Administratori admin)
        {
            if (ModelState.IsValid)
            {
                var obj=db.Administratori.Where(model => model.korisnicko_ime.Equals(admin.korisnicko_ime) && model.lozinka.Equals(admin.lozinka)).FirstOrDefault();
                if (obj != null)
                {
                    Session["AdminID"] = obj.id.ToString();
                    Session["AdminUserName"] = obj.korisnicko_ime.ToString();
                    return Redirect("/Zaposlenik/PopisRadnika");
                }
            }
            return View();
        }

        public ActionResult Logout()
        {
            Session.Remove("AdminID");
            return Redirect("/Login/Login");
        }
        
    }
}