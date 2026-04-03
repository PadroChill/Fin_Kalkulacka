namespace Fin_Kalkulacka
{
    partial class Uspory
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            label1 = new Label();
            VstupniParametry = new Panel();
            btnVymazat = new Button();
            btnCalculateSavings = new Button();
            label6 = new Label();
            nudSavingsYears = new NumericUpDown();
            label5 = new Label();
            txtSavingsRate = new TextBox();
            label4 = new Label();
            txtMonthlyDeposit = new TextBox();
            label3 = new Label();
            txtInitialDeposit = new TextBox();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            Vysledky = new Panel();
            panelZiskZUroku = new Panel();
            lblZiskZUroku = new Label();
            label10 = new Label();
            panelCelkemVlozeno = new Panel();
            lblCelkemVlozeno = new Label();
            label9 = new Label();
            panelKonecnaCastka = new Panel();
            lblCelkovaKonecnaCastka = new Label();
            label7 = new Label();
            label11 = new Label();
            pictureBox2 = new PictureBox();
            dgvUspory = new DataGridView();
            Rok = new DataGridViewTextBoxColumn();
            Vlozeno = new DataGridViewTextBoxColumn();
            Úroky = new DataGridViewTextBoxColumn();
            Celkem = new DataGridViewTextBoxColumn();
            VstupniParametry.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudSavingsYears).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            Vysledky.SuspendLayout();
            panelZiskZUroku.SuspendLayout();
            panelCelkemVlozeno.SuspendLayout();
            panelKonecnaCastka.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvUspory).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.ForeColor = Color.White;
            label1.Location = new Point(211, 87);
            label1.Name = "label1";
            label1.Size = new Size(384, 52);
            label1.TabIndex = 0;
            label1.Text = "Finanční Kalkulačka";
            // 
            // VstupniParametry
            // 
            VstupniParametry.BackColor = Color.FromArgb(22, 22, 31);
            VstupniParametry.Controls.Add(btnVymazat);
            VstupniParametry.Controls.Add(btnCalculateSavings);
            VstupniParametry.Controls.Add(label6);
            VstupniParametry.Controls.Add(nudSavingsYears);
            VstupniParametry.Controls.Add(label5);
            VstupniParametry.Controls.Add(txtSavingsRate);
            VstupniParametry.Controls.Add(label4);
            VstupniParametry.Controls.Add(txtMonthlyDeposit);
            VstupniParametry.Controls.Add(label3);
            VstupniParametry.Controls.Add(txtInitialDeposit);
            VstupniParametry.Controls.Add(label2);
            VstupniParametry.Controls.Add(pictureBox1);
            VstupniParametry.Location = new Point(211, 171);
            VstupniParametry.Name = "VstupniParametry";
            VstupniParametry.Size = new Size(345, 605);
            VstupniParametry.TabIndex = 1;
            // 
            // btnVymazat
            // 
            btnVymazat.BackColor = Color.FromArgb(22, 22, 31);
            btnVymazat.FlatStyle = FlatStyle.Flat;
            btnVymazat.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btnVymazat.ForeColor = Color.White;
            btnVymazat.Location = new Point(178, 522);
            btnVymazat.Name = "btnVymazat";
            btnVymazat.Size = new Size(145, 58);
            btnVymazat.TabIndex = 11;
            btnVymazat.Text = "VYMAZAT";
            btnVymazat.UseVisualStyleBackColor = false;
            // 
            // btnCalculateSavings
            // 
            btnCalculateSavings.BackColor = Color.FromArgb(200, 240, 96);
            btnCalculateSavings.FlatStyle = FlatStyle.Flat;
            btnCalculateSavings.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btnCalculateSavings.ForeColor = SystemColors.ControlText;
            btnCalculateSavings.Location = new Point(23, 522);
            btnCalculateSavings.Name = "btnCalculateSavings";
            btnCalculateSavings.Size = new Size(145, 58);
            btnCalculateSavings.TabIndex = 10;
            btnCalculateSavings.Text = "VYPOČÍTAT";
            btnCalculateSavings.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label6.ForeColor = Color.White;
            label6.Location = new Point(22, 425);
            label6.Name = "label6";
            label6.Size = new Size(109, 19);
            label6.TabIndex = 9;
            label6.Text = "DOBA SPOŘENÍ";
            // 
            // nudSavingsYears
            // 
            nudSavingsYears.BackColor = Color.FromArgb(17, 17, 24);
            nudSavingsYears.BorderStyle = BorderStyle.FixedSingle;
            nudSavingsYears.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            nudSavingsYears.ForeColor = Color.White;
            nudSavingsYears.Location = new Point(23, 453);
            nudSavingsYears.Margin = new Padding(0);
            nudSavingsYears.Name = "nudSavingsYears";
            nudSavingsYears.Size = new Size(300, 30);
            nudSavingsYears.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label5.ForeColor = Color.White;
            label5.Location = new Point(23, 311);
            label5.Name = "label5";
            label5.Size = new Size(200, 19);
            label5.TabIndex = 7;
            label5.Text = "ROČNÍ ÚROKOVÁ SAZBA (KČ)";
            // 
            // txtSavingsRate
            // 
            txtSavingsRate.BackColor = Color.FromArgb(17, 17, 24);
            txtSavingsRate.BorderStyle = BorderStyle.FixedSingle;
            txtSavingsRate.Font = new Font("Segoe UI", 11.25F);
            txtSavingsRate.ForeColor = Color.White;
            txtSavingsRate.Location = new Point(23, 341);
            txtSavingsRate.Multiline = true;
            txtSavingsRate.Name = "txtSavingsRate";
            txtSavingsRate.Size = new Size(300, 58);
            txtSavingsRate.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label4.ForeColor = Color.White;
            label4.Location = new Point(22, 196);
            label4.Name = "label4";
            label4.Size = new Size(144, 19);
            label4.TabIndex = 5;
            label4.Text = "MĚSÍČNÍ VKLAD (KČ)";
            // 
            // txtMonthlyDeposit
            // 
            txtMonthlyDeposit.BackColor = Color.FromArgb(17, 17, 24);
            txtMonthlyDeposit.BorderStyle = BorderStyle.FixedSingle;
            txtMonthlyDeposit.Font = new Font("Segoe UI", 11.25F);
            txtMonthlyDeposit.ForeColor = Color.White;
            txtMonthlyDeposit.Location = new Point(22, 227);
            txtMonthlyDeposit.Multiline = true;
            txtMonthlyDeposit.Name = "txtMonthlyDeposit";
            txtMonthlyDeposit.Size = new Size(300, 58);
            txtMonthlyDeposit.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label3.ForeColor = Color.White;
            label3.Location = new Point(23, 84);
            label3.Name = "label3";
            label3.Size = new Size(181, 19);
            label3.TabIndex = 3;
            label3.Text = "VSTUPNÍ PARAMETRY (KČ)";
            // 
            // txtInitialDeposit
            // 
            txtInitialDeposit.BackColor = Color.FromArgb(17, 17, 24);
            txtInitialDeposit.BorderStyle = BorderStyle.FixedSingle;
            txtInitialDeposit.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            txtInitialDeposit.ForeColor = Color.White;
            txtInitialDeposit.Location = new Point(23, 114);
            txtInitialDeposit.Multiline = true;
            txtInitialDeposit.Name = "txtInitialDeposit";
            txtInitialDeposit.Size = new Size(300, 58);
            txtInitialDeposit.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label2.ForeColor = Color.White;
            label2.Location = new Point(41, 27);
            label2.Name = "label2";
            label2.Size = new Size(150, 19);
            label2.TabIndex = 1;
            label2.Text = "VSTUPNÍ PARAMETRY";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(200, 240, 96);
            pictureBox1.Location = new Point(23, 27);
            pictureBox1.MaximumSize = new Size(50, 57);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(12, 14);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Vysledky
            // 
            Vysledky.BackColor = Color.FromArgb(22, 22, 31);
            Vysledky.Controls.Add(panelZiskZUroku);
            Vysledky.Controls.Add(panelCelkemVlozeno);
            Vysledky.Controls.Add(panelKonecnaCastka);
            Vysledky.Controls.Add(label11);
            Vysledky.Controls.Add(pictureBox2);
            Vysledky.Location = new Point(574, 171);
            Vysledky.Name = "Vysledky";
            Vysledky.Size = new Size(450, 605);
            Vysledky.TabIndex = 12;
            // 
            // panelZiskZUroku
            // 
            panelZiskZUroku.BackColor = Color.FromArgb(17, 17, 24);
            panelZiskZUroku.BorderStyle = BorderStyle.FixedSingle;
            panelZiskZUroku.Controls.Add(lblZiskZUroku);
            panelZiskZUroku.Controls.Add(label10);
            panelZiskZUroku.Location = new Point(231, 212);
            panelZiskZUroku.Name = "panelZiskZUroku";
            panelZiskZUroku.Size = new Size(194, 113);
            panelZiskZUroku.TabIndex = 15;
            // 
            // lblZiskZUroku
            // 
            lblZiskZUroku.AutoSize = true;
            lblZiskZUroku.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            lblZiskZUroku.ForeColor = Color.White;
            lblZiskZUroku.Location = new Point(17, 61);
            lblZiskZUroku.Name = "lblZiskZUroku";
            lblZiskZUroku.RightToLeft = RightToLeft.No;
            lblZiskZUroku.Size = new Size(34, 30);
            lblZiskZUroku.TabIndex = 13;
            lblZiskZUroku.Text = "—";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label10.ForeColor = Color.White;
            label10.Location = new Point(17, 17);
            label10.Name = "label10";
            label10.Size = new Size(103, 19);
            label10.TabIndex = 12;
            label10.Text = "ZISK Z ÚROKŮ";
            // 
            // panelCelkemVlozeno
            // 
            panelCelkemVlozeno.BackColor = Color.FromArgb(17, 17, 24);
            panelCelkemVlozeno.BorderStyle = BorderStyle.FixedSingle;
            panelCelkemVlozeno.Controls.Add(lblCelkemVlozeno);
            panelCelkemVlozeno.Controls.Add(label9);
            panelCelkemVlozeno.Location = new Point(23, 212);
            panelCelkemVlozeno.Name = "panelCelkemVlozeno";
            panelCelkemVlozeno.Size = new Size(194, 113);
            panelCelkemVlozeno.TabIndex = 14;
            panelCelkemVlozeno.Paint += panel1_Paint;
            // 
            // lblCelkemVlozeno
            // 
            lblCelkemVlozeno.AutoSize = true;
            lblCelkemVlozeno.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            lblCelkemVlozeno.ForeColor = Color.White;
            lblCelkemVlozeno.Location = new Point(17, 61);
            lblCelkemVlozeno.Name = "lblCelkemVlozeno";
            lblCelkemVlozeno.RightToLeft = RightToLeft.No;
            lblCelkemVlozeno.Size = new Size(34, 30);
            lblCelkemVlozeno.TabIndex = 13;
            lblCelkemVlozeno.Text = "—";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label9.ForeColor = Color.White;
            label9.Location = new Point(17, 17);
            label9.Name = "label9";
            label9.Size = new Size(129, 19);
            label9.TabIndex = 12;
            label9.Text = "CELKEM VLOŽENO";
            // 
            // panelKonecnaCastka
            // 
            panelKonecnaCastka.BackColor = Color.FromArgb(17, 17, 24);
            panelKonecnaCastka.BorderStyle = BorderStyle.FixedSingle;
            panelKonecnaCastka.Controls.Add(lblCelkovaKonecnaCastka);
            panelKonecnaCastka.Controls.Add(label7);
            panelKonecnaCastka.Location = new Point(23, 84);
            panelKonecnaCastka.Name = "panelKonecnaCastka";
            panelKonecnaCastka.Size = new Size(402, 113);
            panelKonecnaCastka.TabIndex = 2;
            // 
            // lblCelkovaKonecnaCastka
            // 
            lblCelkovaKonecnaCastka.AutoSize = true;
            lblCelkovaKonecnaCastka.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            lblCelkovaKonecnaCastka.ForeColor = Color.FromArgb(200, 240, 96);
            lblCelkovaKonecnaCastka.Location = new Point(17, 61);
            lblCelkovaKonecnaCastka.Name = "lblCelkovaKonecnaCastka";
            lblCelkovaKonecnaCastka.RightToLeft = RightToLeft.No;
            lblCelkovaKonecnaCastka.Size = new Size(38, 32);
            lblCelkovaKonecnaCastka.TabIndex = 13;
            lblCelkovaKonecnaCastka.Text = "—";
            lblCelkovaKonecnaCastka.Click += label8_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label7.ForeColor = Color.White;
            label7.Location = new Point(17, 17);
            label7.Name = "label7";
            label7.Size = new Size(194, 19);
            label7.TabIndex = 12;
            label7.Text = "CELKOVÁ KONEČNÁ ČÁSTKA";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label11.ForeColor = Color.White;
            label11.Location = new Point(41, 27);
            label11.Name = "label11";
            label11.Size = new Size(75, 19);
            label11.TabIndex = 1;
            label11.Text = "VÝSLEDKY";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(200, 240, 96);
            pictureBox2.Location = new Point(23, 27);
            pictureBox2.MaximumSize = new Size(50, 57);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(12, 14);
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // dgvUspory
            // 
            dgvUspory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUspory.BackgroundColor = Color.FromArgb(22, 22, 31);
            dgvUspory.BorderStyle = BorderStyle.None;
            dgvUspory.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvUspory.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(22, 22, 31);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 8.830189F);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.Padding = new Padding(4);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(22, 22, 31);
            dataGridViewCellStyle1.SelectionForeColor = Color.Honeydew;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvUspory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvUspory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUspory.Columns.AddRange(new DataGridViewColumn[] { Rok, Vlozeno, Úroky, Celkem });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(22, 22, 31);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 8.830189F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.Padding = new Padding(4);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(22, 22, 31);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvUspory.DefaultCellStyle = dataGridViewCellStyle2;
            dgvUspory.EnableHeadersVisualStyles = false;
            dgvUspory.GridColor = Color.FromArgb(22, 22, 31);
            dgvUspory.Location = new Point(211, 810);
            dgvUspory.Name = "dgvUspory";
            dgvUspory.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(64, 0, 0);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 8.830189F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvUspory.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvUspory.RowHeadersWidth = 45;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(22, 22, 31);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 8.830189F, FontStyle.Regular, GraphicsUnit.Point, 238);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(22, 22, 31);
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dgvUspory.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvUspory.Size = new Size(813, 166);
            dgvUspory.TabIndex = 13;
            // 
            // Rok
            // 
            Rok.HeaderText = "Rok";
            Rok.MinimumWidth = 6;
            Rok.Name = "Rok";
            // 
            // Vlozeno
            // 
            Vlozeno.HeaderText = "Vloženo (Kč)";
            Vlozeno.MinimumWidth = 6;
            Vlozeno.Name = "Vlozeno";
            // 
            // Úroky
            // 
            Úroky.HeaderText = "Úroky (Kč)";
            Úroky.MinimumWidth = 6;
            Úroky.Name = "Úroky";
            // 
            // Celkem
            // 
            Celkem.HeaderText = "Celkem (Kč)";
            Celkem.MinimumWidth = 6;
            Celkem.Name = "Celkem";
            // 
            // Uspory
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(10, 10, 15);
            ClientSize = new Size(1343, 1100);
            Controls.Add(dgvUspory);
            Controls.Add(Vysledky);
            Controls.Add(VstupniParametry);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Uspory";
            Text = "Form1";
            VstupniParametry.ResumeLayout(false);
            VstupniParametry.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudSavingsYears).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            Vysledky.ResumeLayout(false);
            Vysledky.PerformLayout();
            panelZiskZUroku.ResumeLayout(false);
            panelZiskZUroku.PerformLayout();
            panelCelkemVlozeno.ResumeLayout(false);
            panelCelkemVlozeno.PerformLayout();
            panelKonecnaCastka.ResumeLayout(false);
            panelKonecnaCastka.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvUspory).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel VstupniParametry;
        private Label label2;
        private PictureBox pictureBox1;
        private Label label3;
        private TextBox txtInitialDeposit;
        private Label label5;
        private TextBox txtSavingsRate;
        private Label label4;
        private TextBox txtMonthlyDeposit;
        private NumericUpDown nudSavingsYears;
        private Button btnCalculateSavings;
        private Label label6;
        private Button btnVymazat;
        private Panel Vysledky;
        private Label label11;
        private PictureBox pictureBox2;
        private Panel panelKonecnaCastka;
        private Label label7;
        private Label lblCelkovaKonecnaCastka;
        private Panel panelCelkemVlozeno;
        private Label lblCelkemVlozeno;
        private Label label9;
        private Panel panelZiskZUroku;
        private Label lblZiskZUroku;
        private Label label10;
        private DataGridView dgvUspory;
        private DataGridViewTextBoxColumn Rok;
        private DataGridViewTextBoxColumn Vlozeno;
        private DataGridViewTextBoxColumn Úroky;
        private DataGridViewTextBoxColumn Celkem;
    }
}
