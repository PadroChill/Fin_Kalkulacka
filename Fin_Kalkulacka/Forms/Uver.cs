using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Fin_Kalkulacka.Logika;
using Fin_Kalkulacka.Modely;

namespace Fin_Kalkulacka.Forms
{
    public partial class Uver : Form
    {
        private List<RadekSplatky> _kalendar = new List<RadekSplatky>();

        public Uver()
        {
            InitializeComponent();
            nudRokyUveru.Minimum = 1;
            nudRokyUveru.Maximum = 30;
        }

        private void btnVypocitatUver_Click(object sender, EventArgs e)
        {
            // Validace
            if (!decimal.TryParse(txtVyseUveru.Text, out decimal vyseUveru) || vyseUveru <= 0)
            {
                MessageBox.Show("Zadejte platnou výši úvěru.", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!decimal.TryParse(txtSazbaUveru.Text, out decimal sazba) || sazba <= 0)
            {
                MessageBox.Show("Zadejte platnou úrokovou sazbu.", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int roky = (int)nudRokyUveru.Value;
            bool jeAnuitni = rbAnuitni.Checked;

            // Výpočet
            var kalkulator = new KalkulackaUveru();
            VysledekUveru vysledek = kalkulator.Vypocitej(vyseUveru, sazba, roky, jeAnuitni);

            // Zobrazení výsledků
            lblMesicniSplatka.Text = $"{vysledek.MesicniSplatka:N0} Kč";
            lblCelkemZaplaceno.Text = $"{vysledek.CelkemZaplaceno:N0} Kč";
            lblCelkemNaUrocich.Text = $"{vysledek.CelkemNaUrocich:N0} Kč";

            // Naplnění tabulky
            _kalendar = vysledek.Kalendar;
            dgvKalendar.Rows.Clear();
            foreach (var radek in _kalendar)
            {
                dgvKalendar.Rows.Add(
                    radek.Mesic,
                    $"{radek.Splatka:N0}",
                    $"{radek.Urok:N0}",
                    $"{radek.Jistina:N0}",
                    $"{radek.Zustatek:N0}"
                );
            }
        }

        private void btnVymazatUver_Click(object sender, EventArgs e)
        {
            txtVyseUveru.Text = "";
            txtSazbaUveru.Text = "";
            nudRokyUveru.Value = 1;
            rbAnuitni.Checked = true;
            lblMesicniSplatka.Text = "—";
            lblCelkemZaplaceno.Text = "—";
            lblCelkemNaUrocich.Text = "—";
            dgvKalendar.Rows.Clear();
            _kalendar.Clear();
        }

        private void btnExportCsv_Click(object sender, EventArgs e)
        {
            if (_kalendar.Count == 0)
            {
                MessageBox.Show("Nejprve proveďte výpočet.", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using var dlg = new SaveFileDialog
            {
                Filter = "CSV soubory (*.csv)|*.csv",
                FileName = "amortizacni_kalendar.csv"
            };

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var sb = new System.Text.StringBuilder();
                    sb.AppendLine("Mesic;Splatka (Kc);Urok (Kc);Jistina (Kc);Zustatek (Kc)");
                    foreach (var r in _kalendar)
                        sb.AppendLine($"{r.Mesic};{r.Splatka:N2};{r.Urok:N2};{r.Jistina:N2};{r.Zustatek:N2}");

                    File.WriteAllText(dlg.FileName, sb.ToString(), System.Text.Encoding.UTF8);
                    MessageBox.Show("Export úspěšný!", "CSV", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Chyba při exportu: " + ex.Message, "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnNaUspory_Click(object sender, EventArgs e)
        {
            var uspory = new Uspory();
            uspory.Show();
            this.Hide();
        }
    }
}
