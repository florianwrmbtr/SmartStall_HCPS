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
        Ammoniak amonniak = new Ammoniak();
        Luftfeuchtigkeit luftfeuchtigkeit = new Luftfeuchtigkeit();

        public ActionResult Index()
        {
            ViewBag.ammoniakWerteTagAktuell = amonniak.AmmoniakAktuellListeTag;
            ViewBag.ammoniakWerteTagDurchschnitt = amonniak.AmmoniakDurschnittListeTag;

            ViewBag.luftfeuchtigkeitWerteTagAktuell = luftfeuchtigkeit.LuftfeuchtigkeitAktuellListeTag;
            ViewBag.luftfeuchtigkeitWerteTagDurchschnitt = luftfeuchtigkeit.LuftfeuchtigkeitDurschnittListeTag;

            return View();
        }

        public ActionResult GetAmmoniak()
        {
            Dictionary<string, string> ammoniakWerte = new Dictionary<string, string>();
            ammoniakWerte.Add("ammoniakWerteTagAktuell", amonniak.AmmoniakAktuellListeTag);
            ammoniakWerte.Add("ammoniakWerteTagDurchschnitt", amonniak.AmmoniakDurschnittListeTag);

            ammoniakWerte.Add("ammoiakWerteWocheAktuell", amonniak.AmmoniakAktuellWoche);
            ammoniakWerte.Add("ammoniakWerteWocheDurchschnitt", amonniak.AmmoniakDurchschnittWoche);
            return Json(ammoniakWerte, JsonRequestBehavior.AllowGet);
        }

        public ActionResult GetLuftfeuchtigkeit()
        {
            Dictionary<string, string> luftfeuchtigkeitWerte = new Dictionary<string, string>();
            luftfeuchtigkeitWerte.Add("luftfeuchtigkeitWerteTagAktuell", luftfeuchtigkeit.LuftfeuchtigkeitAktuellListeTag);
            luftfeuchtigkeitWerte.Add("luftfeuchtigkeitWerteTagDurchschnitt", luftfeuchtigkeit.LuftfeuchtigkeitDurschnittListeTag);

            luftfeuchtigkeitWerte.Add("luftfeuchtigkeitWerteWocheAktuell", luftfeuchtigkeit.LuftfeuchtigkeitAktuellWoche);
            luftfeuchtigkeitWerte.Add("luftfeuchtigkeitWerteWocheDurchschnitt", luftfeuchtigkeit.LuftfeuchtigkeitDurchschnittWoche);
            return Json(luftfeuchtigkeitWerte, JsonRequestBehavior.AllowGet);
        }
    }
}