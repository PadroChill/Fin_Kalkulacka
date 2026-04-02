using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fin_Kalkulacka.Modely
{
    public class RadekSplatky
    {
        public int Mesic { get; set; }
        public decimal Splatka { get; set; }
        public decimal Urok { get; set; }
        public decimal Jistina { get; set; }
        public decimal Zustatek { get; set; }

        public RadekSplatky(int mesic, decimal splatka, decimal urok, decimal jistina, decimal zustatek)
        {
            Mesic = mesic;
            Splatka = splatka;
            Urok = urok;
            Jistina = jistina;
            Zustatek = zustatek;
        }
    }

    public class VysledekUveru
    {
        public decimal MesicniSplatka { get; set; }
        public decimal CelkemZaplaceno { get; set; }
        public decimal CelkemNaUrocich { get; set; }
        public List<RadekSplatky> Kalendar { get; set; }
    }
}

