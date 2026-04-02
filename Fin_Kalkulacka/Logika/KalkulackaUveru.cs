using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fin_Kalkulacka.Modely;


namespace Fin_Kalkulacka.Logika
{
    public class KalkulackaUveru
    {
        /// <summary>Vypočítá měsíční splátky a amortizační kalendář.</summary>
        public VysledekUveru Vypocitej(decimal jistina, decimal rocniSazba,
                                       int roky, bool jeAnitni)
        {
            int n = roky * 12;
            decimal r = rocniSazba / 100m / 12m;

            decimal anuitniSplatka = jistina * (r * (decimal)Math.Pow((double)(1 + r), n))
                                   / ((decimal)Math.Pow((double)(1 + r), n) - 1);
            decimal mesicniJistina = jistina / n;

            var kalendar = new List<RadekSplatky>();
            decimal zustatek = jistina;
            decimal celkemZaplaceno = 0;
            decimal celkemUroky = 0;

            for (int m = 1; m <= n; m++)
            {
                decimal urok = zustatek * r;
                decimal splatka = jeAnitni ? anuitniSplatka : mesicniJistina + urok;
                decimal jistinaMesic = splatka - urok;

                zustatek = Math.Max(0, zustatek - jistinaMesic);
                celkemZaplaceno += splatka;
                celkemUroky += urok;

                kalendar.Add(new RadekSplatky(m, splatka, urok, jistinaMesic, zustatek));
            }

            return new VysledekUveru
            {
                MesicniSplatka = kalendar[0].Splatka,
                CelkemZaplaceno = celkemZaplaceno,
                CelkemNaUrocich = celkemUroky,
                Kalendar = kalendar
            };
        }
    }
}
