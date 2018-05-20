using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SustavZaVodjenjeRadnika.Models;

namespace SustavZaVodjenjeRadnika.Controllers
{
    public class AdminController : Controller
    {
        SustavZaVodjenjeRadnikaEntities db = new SustavZaVodjenjeRadnikaEntities();
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }
    }
}