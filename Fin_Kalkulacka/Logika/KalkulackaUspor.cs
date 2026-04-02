using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fin_Kalkulacka.Modely;

namespace Fin_Kalkulacka.Logika
{
    public class KalkulackaUspor
    {
        /// <summary>Vypočítá budoucí hodnotu úspor se složeným úročením.</summary>
        public VysledekUspor Vypocitej(decimal pocatecniVklad, decimal mesicniVklad, decimal rocniSazba, int roky)
        {
            decimal r = rocniSazba / 100m / 12m;
            decimal zustatek = pocatecniVklad;
            var rocniPrehled = new List<(int Rok, decimal Vlozeno, decimal Uroky, decimal Celkem)>();

            for (int rok = 1; rok <= roky; rok++) // projdi každý rok
            {
                decimal vlozenoRok = 0, urokyRok = 0;
                for (int m = 0; m < 12; m++)  // projdi každý měsíc v roce
                {
                    decimal urok = zustatek * r;   // vypočítej úrok za měsíc
                    zustatek += urok + mesicniVklad; // přidej úrok + měsíční vklad
                    vlozenoRok += mesicniVklad;
                    urokyRok += urok;
                }
                rocniPrehled.Add((rok, vlozenoRok, urokyRok, zustatek)); // ulož řádek do tabulky
            }

            decimal celkemVlozeno = pocatecniVklad + mesicniVklad * 12 * roky;

            return new VysledekUspor
            {
                KonecnaCastka = zustatek,
                CelkemVlozeno = celkemVlozeno,
                ZiskZUroku = zustatek - celkemVlozeno,
                RocniPrehled = rocniPrehled
            };
        }
    }
}
