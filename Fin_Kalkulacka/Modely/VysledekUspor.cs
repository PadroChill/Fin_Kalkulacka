using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fin_Kalkulacka.Modely
{
    public class VysledekUspor
    {
        public decimal KonecnaCastka { get; set; }  // celková částka na konci
        public decimal CelkemVlozeno { get; set; }  // kolik jsem dal ze svého
        public decimal ZiskZUroku { get; set; }  // kolik vydělaly úroky
        public List<(int Rok, decimal Vlozeno, decimal Uroky, decimal Celkem)> RocniPrehled { get; set; }
    }
}
