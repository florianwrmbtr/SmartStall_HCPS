using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;
using Test2.Models;

namespace Test2.Controllers
{
    public class HomeController : Controller
    {
        Ammoniak am = new Ammoniak();
        public ActionResult Index()
        {
            ViewBag.ammoniakWerteTagAktuell = am.AmmoniakAktuellListeTag;
            ViewBag.ammoniakWerteTagDurchschnitt = am.AmmoniakDurschnittListeTag;
            return View();
        }

        public ActionResult GetAmmoniak()
        {
            Dictionary<string, string> ammoniakWerte = new Dictionary<string, string>();
            ammoniakWerte.Add("ammoniakWerteTagAktuell", am.AmmoniakAktuellListeTag);
            ammoniakWerte.Add("ammoniakWerteTagDurchschnitt", am.AmmoniakDurschnittListeTag);

            ammoniakWerte.Add("ammoiakWerteWocheAktuell", am.AmmoniakAktuellWoche);
            ammoniakWerte.Add("ammoniakWerteWocheDurchschnitt", am.AmmoniakDurchschnittWoche);
            return Json(ammoniakWerte, JsonRequestBehavior.AllowGet);
        }
    }
}