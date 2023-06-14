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
    public class ReceiveDataController : Controller
    {
        [HttpPost]
        public ActionResult ReceiveData(SensorData data)
        {
            if (data != null)
            {
                // Datenverarbeitung
                // Zum Beispiel: Daten in einer Datenbank speichern
                // oder weitere Aktionen durchführen

                // Beispiel: Daten in der Konsole ausgeben
                string json = JsonConvert.SerializeObject(data);
                System.Console.WriteLine($"Received sensor data: {json}");

                // Rückgabe einer erfolgreichen Antwort
                return Content("Data received successfully");
            }

            // Falls keine Daten empfangen wurden, eine Fehlerantwort zurückgeben
            return Content("No data received");
        }
    }

    public class SensorData
    {
        public float Temperature { get; set; }
        public float Pressure { get; set; }
        public float Humidity { get; set; }
        public float GasResistance { get; set; }
    }
}