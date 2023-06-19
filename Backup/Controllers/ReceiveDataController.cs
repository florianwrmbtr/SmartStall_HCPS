using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;
using Test2.Models;
using Test2.Services;

namespace Test2.Controllers
{
    public class ReceiveDataController : Controller
    {
        [HttpPost]
        public ActionResult ReceiveData(Datenpaket data)
        {
            if (data != null)
            {
                // Datenverarbeitung
                // Zum Beispiel: Daten in einer Datenbank speichern
                // oder weitere Aktionen durchführen

                // Beispiel: Daten in der Konsole ausgeben                
                System.Console.WriteLine($"Received sensor data: {JsonConvert.SerializeObject(data)}");

                DbWriteService writeService = new DbWriteService();
                writeService.InsertData(data);



                // Rückgabe einer erfolgreichen Antwort
                return Content("Data received successfully");
            }

            // Falls keine Daten empfangen wurden, eine Fehlerantwort zurückgeben
            return Content("No data received");
        }
    }
}