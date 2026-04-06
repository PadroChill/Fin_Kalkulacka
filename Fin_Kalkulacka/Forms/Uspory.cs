using Fin_Kalkulacka.Forms;
using Fin_Kalkulacka.Logika;
using Fin_Kalkulacka.Modely;

namespace Fin_Kalkulacka

{
    public partial class Uspory : Form
    {
        public Uspory()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCalculateSavings_Click(object sender, EventArgs e)
        {
            // Validace
            if (!decimal.TryParse(txtPocatecniVklad.Text, out decimal pocVklad) || pocVklad < 0)
            {
                MessageBox.Show("Zadejte platný poèáteèní vklad.", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!decimal.TryParse(txtMesicniVklad.Text, out decimal mesVklad) || mesVklad < 0)
            {
                MessageBox.Show("Zadejte platný mìsíèní vklad.", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!decimal.TryParse(txtRocniSazba.Text, out decimal sazba) || sazba <= 0)
            {
                MessageBox.Show("Zadejte platnou úrokovou sazbu.", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int roky = (int)nudDobaSporeni.Value;

            // Výpoèet
            var kalkulator = new KalkulackaUspor();
            VysledekUspor vysledek = kalkulator.Vypocitej(pocVklad, mesVklad, sazba, roky);

            // Zobrazení výsledkù
            lblKonecnaCastka.Text = $"{vysledek.KonecnaCastka:N0} Kè";
            lblCelkemVlozeno.Text = $"{vysledek.CelkemVlozeno:N0} Kè";
            lblZiskZUroku.Text = $"{vysledek.ZiskZUroku:N0} Kè";

            // Naplnìní tabulky
            dgvUspory.Rows.Clear();
            decimal cumVlozeno = pocVklad, cumUroky = 0;
            foreach (var radek in vysledek.RocniPrehled)
            {
                cumVlozeno += radek.Vlozeno;
                cumUroky += radek.Uroky;
                dgvUspory.Rows.Add(radek.Rok, $"{cumVlozeno:N0}", $"{cumUroky:N0}", $"{radek.Celkem:N0}");
            }
        }

        private void btnVymazatUspory_Click(object sender, EventArgs e)
        {
            txtPocatecniVklad.Text = "";
            txtMesicniVklad.Text = "";
            txtRocniSazba.Text = "";
            nudDobaSporeni.Value = 1;
            lblKonecnaCastka.Text = "—";
            lblCelkemVlozeno.Text = "—";
            lblZiskZUroku.Text = "—";
            dgvUspory.Rows.Clear();
        }

        private void btnNaUver_Click(object sender, EventArgs e)
        {
            var uver = new Uver();
            uver.Show();
            this.Hide();
        }
    }
}
