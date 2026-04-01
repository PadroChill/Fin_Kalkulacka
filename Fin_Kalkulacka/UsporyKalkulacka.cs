using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fin_Kalkulacka
{
    public class UsporyKalkulacka
    {
        public UsporyKalkulacka Calculate (double mesicniUspory, double pocetMesicu)
        {
            double celkoveUspory = mesicniUspory * pocetMesicu;
            return new UsporyVysledek(celkoveUspory);
        }
    }
}
