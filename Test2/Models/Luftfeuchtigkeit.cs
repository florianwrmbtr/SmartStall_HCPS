using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Test2.Models
{
    public class Luftfeuchtigkeit
    {
        public string LuftfeuchtigkeitAktuellListeTag { get; set; }
        public string LuftfeuchtigkeitDurschnittListeTag { get; set; }
        public string LuftfeuchtigkeitAktuellWoche { get; set; }
        public string LuftfeuchtigkeitDurchschnittWoche { get; set; }

        public Luftfeuchtigkeit()
        {
            LuftfeuchtigkeitAktuellListeTag = "[10, 8, 10, 9, 15, 10, 8, 10, 9, 10, 9, 15]";
            LuftfeuchtigkeitDurschnittListeTag = "[10, 8, 10, 9, 8, 10, 10, 8, 10, 9, 15, 16]";
            LuftfeuchtigkeitAktuellWoche = "[10, 8, 10, 9, 15, 16, 10]";
            LuftfeuchtigkeitDurchschnittWoche = "[10, 8, 10, 9, 15, 16, 9]";
        }
    }
}