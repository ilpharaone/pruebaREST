using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PruebaREST.CSD
{
    public class Localizacion
    {
        public Calle street { get; set; }

        public string city { get; set; }

        public string state { get; set; }

        public string country { get; set; }

        public string postcode { get; set; }

        public Coordenadas coordinates { get; set; }

        public ZonaHoraria timezone { get; set; }

    }
}