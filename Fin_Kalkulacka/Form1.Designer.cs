namespace Fin_Kalkulacka
{
    partial class Form1
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
            label1 = new Label();
            VstupniParametry = new Panel();
            button1 = new Button();
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
            label11 = new Label();
            pictureBox2 = new PictureBox();
            panelKonecnaCastka = new Panel();
            label7 = new Label();
            lblCelkovaKonecnaCastka = new Label();
            panelCelkemVlozeno = new Panel();
            lblCelkemVlozeno = new Label();
            label9 = new Label();
            panelZiskZUroku = new Panel();
            lblZiskZUroku = new Label();
            label10 = new Label();
            VstupniParametry.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudSavingsYears).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            Vysledky.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panelKonecnaCastka.SuspendLayout();
            panelCelkemVlozeno.SuspendLayout();
            panelZiskZUroku.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.ForeColor = Color.White;
            label1.Location = new Point(211, 77);
            label1.Name = "label1";
            label1.Size = new Size(345, 47);
            label1.TabIndex = 0;
            label1.Text = "Finanční Kalkulačka";
            // 
            // VstupniParametry
            // 
            VstupniParametry.BackColor = Color.FromArgb(22, 22, 31);
            VstupniParametry.Controls.Add(button1);
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
            VstupniParametry.Location = new Point(211, 151);
            VstupniParametry.Name = "VstupniParametry";
            VstupniParametry.Size = new Size(345, 534);
            VstupniParametry.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(22, 22, 31);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            button1.ForeColor = Color.White;
            button1.Location = new Point(178, 461);
            button1.Name = "button1";
            button1.Size = new Size(145, 51);
            button1.TabIndex = 11;
            button1.Text = "VYMAZAT";
            button1.UseVisualStyleBackColor = false;
            // 
            // btnCalculateSavings
            // 
            btnCalculateSavings.BackColor = Color.FromArgb(200, 240, 96);
            btnCalculateSavings.FlatStyle = FlatStyle.Flat;
            btnCalculateSavings.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btnCalculateSavings.ForeColor = SystemColors.ControlText;
            btnCalculateSavings.Location = new Point(23, 461);
            btnCalculateSavings.Name = "btnCalculateSavings";
            btnCalculateSavings.Size = new Size(145, 51);
            btnCalculateSavings.TabIndex = 10;
            btnCalculateSavings.Text = "VYPOČÍTAT";
            btnCalculateSavings.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label6.ForeColor = Color.White;
            label6.Location = new Point(22, 375);
            label6.Name = "label6";
            label6.Size = new Size(92, 15);
            label6.TabIndex = 9;
            label6.Text = "DOBA SPOŘENÍ";
            // 
            // nudSavingsYears
            // 
            nudSavingsYears.BackColor = Color.FromArgb(17, 17, 24);
            nudSavingsYears.BorderStyle = BorderStyle.FixedSingle;
            nudSavingsYears.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            nudSavingsYears.ForeColor = Color.White;
            nudSavingsYears.Location = new Point(23, 400);
            nudSavingsYears.Margin = new Padding(0);
            nudSavingsYears.Name = "nudSavingsYears";
            nudSavingsYears.Size = new Size(300, 29);
            nudSavingsYears.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label5.ForeColor = Color.White;
            label5.Location = new Point(23, 274);
            label5.Name = "label5";
            label5.Size = new Size(166, 15);
            label5.TabIndex = 7;
            label5.Text = "ROČNÍ ÚROKOVÁ SAZBA (KČ)";
            // 
            // txtSavingsRate
            // 
            txtSavingsRate.BackColor = Color.FromArgb(17, 17, 24);
            txtSavingsRate.BorderStyle = BorderStyle.FixedSingle;
            txtSavingsRate.Location = new Point(23, 301);
            txtSavingsRate.Multiline = true;
            txtSavingsRate.Name = "txtSavingsRate";
            txtSavingsRate.Size = new Size(300, 51);
            txtSavingsRate.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label4.ForeColor = Color.White;
            label4.Location = new Point(22, 173);
            label4.Name = "label4";
            label4.Size = new Size(121, 15);
            label4.TabIndex = 5;
            label4.Text = "MĚSÍČNÍ VKLAD (KČ)";
            // 
            // txtMonthlyDeposit
            // 
            txtMonthlyDeposit.BackColor = Color.FromArgb(17, 17, 24);
            txtMonthlyDeposit.BorderStyle = BorderStyle.FixedSingle;
            txtMonthlyDeposit.Location = new Point(22, 200);
            txtMonthlyDeposit.Multiline = true;
            txtMonthlyDeposit.Name = "txtMonthlyDeposit";
            txtMonthlyDeposit.Size = new Size(300, 51);
            txtMonthlyDeposit.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label3.ForeColor = Color.White;
            label3.Location = new Point(23, 74);
            label3.Name = "label3";
            label3.Size = new Size(152, 15);
            label3.TabIndex = 3;
            label3.Text = "VSTUPNÍ PARAMETRY (KČ)";
            // 
            // txtInitialDeposit
            // 
            txtInitialDeposit.BackColor = Color.FromArgb(17, 17, 24);
            txtInitialDeposit.BorderStyle = BorderStyle.FixedSingle;
            txtInitialDeposit.Location = new Point(23, 101);
            txtInitialDeposit.Multiline = true;
            txtInitialDeposit.Name = "txtInitialDeposit";
            txtInitialDeposit.Size = new Size(300, 51);
            txtInitialDeposit.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label2.ForeColor = Color.White;
            label2.Location = new Point(41, 24);
            label2.Name = "label2";
            label2.Size = new Size(127, 15);
            label2.TabIndex = 1;
            label2.Text = "VSTUPNÍ PARAMETRY";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(200, 240, 96);
            pictureBox1.Location = new Point(23, 24);
            pictureBox1.MaximumSize = new Size(50, 50);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(12, 12);
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
            Vysledky.Location = new Point(574, 151);
            Vysledky.Name = "Vysledky";
            Vysledky.Size = new Size(450, 534);
            Vysledky.TabIndex = 12;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label11.ForeColor = Color.White;
            label11.Location = new Point(41, 24);
            label11.Name = "label11";
            label11.Size = new Size(64, 15);
            label11.TabIndex = 1;
            label11.Text = "VÝSLEDKY";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(200, 240, 96);
            pictureBox2.Location = new Point(23, 24);
            pictureBox2.MaximumSize = new Size(50, 50);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(12, 12);
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // panelKonecnaCastka
            // 
            panelKonecnaCastka.BackColor = Color.FromArgb(17, 17, 24);
            panelKonecnaCastka.BorderStyle = BorderStyle.FixedSingle;
            panelKonecnaCastka.Controls.Add(lblCelkovaKonecnaCastka);
            panelKonecnaCastka.Controls.Add(label7);
            panelKonecnaCastka.Location = new Point(23, 74);
            panelKonecnaCastka.Name = "panelKonecnaCastka";
            panelKonecnaCastka.Size = new Size(402, 100);
            panelKonecnaCastka.TabIndex = 2;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label7.ForeColor = Color.White;
            label7.Location = new Point(17, 15);
            label7.Name = "label7";
            label7.Size = new Size(162, 15);
            label7.TabIndex = 12;
            label7.Text = "CELKOVÁ KONEČNÁ ČÁSTKA";
            // 
            // lblCelkovaKonecnaCastka
            // 
            lblCelkovaKonecnaCastka.AutoSize = true;
            lblCelkovaKonecnaCastka.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            lblCelkovaKonecnaCastka.ForeColor = Color.FromArgb(200, 240, 96);
            lblCelkovaKonecnaCastka.Location = new Point(17, 54);
            lblCelkovaKonecnaCastka.Name = "lblCelkovaKonecnaCastka";
            lblCelkovaKonecnaCastka.RightToLeft = RightToLeft.No;
            lblCelkovaKonecnaCastka.Size = new Size(34, 30);
            lblCelkovaKonecnaCastka.TabIndex = 13;
            lblCelkovaKonecnaCastka.Text = "—";
            lblCelkovaKonecnaCastka.Click += label8_Click;
            // 
            // panelCelkemVlozeno
            // 
            panelCelkemVlozeno.BackColor = Color.FromArgb(17, 17, 24);
            panelCelkemVlozeno.BorderStyle = BorderStyle.FixedSingle;
            panelCelkemVlozeno.Controls.Add(lblCelkemVlozeno);
            panelCelkemVlozeno.Controls.Add(label9);
            panelCelkemVlozeno.Location = new Point(23, 187);
            panelCelkemVlozeno.Name = "panelCelkemVlozeno";
            panelCelkemVlozeno.Size = new Size(194, 100);
            panelCelkemVlozeno.TabIndex = 14;
            panelCelkemVlozeno.Paint += panel1_Paint;
            // 
            // lblCelkemVlozeno
            // 
            lblCelkemVlozeno.AutoSize = true;
            lblCelkemVlozeno.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            lblCelkemVlozeno.ForeColor = Color.White;
            lblCelkemVlozeno.Location = new Point(17, 54);
            lblCelkemVlozeno.Name = "lblCelkemVlozeno";
            lblCelkemVlozeno.RightToLeft = RightToLeft.No;
            lblCelkemVlozeno.Size = new Size(31, 25);
            lblCelkemVlozeno.TabIndex = 13;
            lblCelkemVlozeno.Text = "—";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label9.ForeColor = Color.White;
            label9.Location = new Point(17, 15);
            label9.Name = "label9";
            label9.Size = new Size(107, 15);
            label9.TabIndex = 12;
            label9.Text = "CELKEM VLOŽENO";
            // 
            // panelZiskZUroku
            // 
            panelZiskZUroku.BackColor = Color.FromArgb(17, 17, 24);
            panelZiskZUroku.BorderStyle = BorderStyle.FixedSingle;
            panelZiskZUroku.Controls.Add(lblZiskZUroku);
            panelZiskZUroku.Controls.Add(label10);
            panelZiskZUroku.Location = new Point(231, 187);
            panelZiskZUroku.Name = "panelZiskZUroku";
            panelZiskZUroku.Size = new Size(194, 100);
            panelZiskZUroku.TabIndex = 15;
            // 
            // lblZiskZUroku
            // 
            lblZiskZUroku.AutoSize = true;
            lblZiskZUroku.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            lblZiskZUroku.ForeColor = Color.White;
            lblZiskZUroku.Location = new Point(17, 54);
            lblZiskZUroku.Name = "lblZiskZUroku";
            lblZiskZUroku.RightToLeft = RightToLeft.No;
            lblZiskZUroku.Size = new Size(31, 25);
            lblZiskZUroku.TabIndex = 13;
            lblZiskZUroku.Text = "—";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label10.ForeColor = Color.White;
            label10.Location = new Point(17, 15);
            label10.Name = "label10";
            label10.Size = new Size(84, 15);
            label10.TabIndex = 12;
            label10.Text = "ZISK Z ÚROKŮ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(10, 10, 15);
            ClientSize = new Size(1287, 999);
            Controls.Add(Vysledky);
            Controls.Add(VstupniParametry);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            VstupniParametry.ResumeLayout(false);
            VstupniParametry.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudSavingsYears).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            Vysledky.ResumeLayout(false);
            Vysledky.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panelKonecnaCastka.ResumeLayout(false);
            panelKonecnaCastka.PerformLayout();
            panelCelkemVlozeno.ResumeLayout(false);
            panelCelkemVlozeno.PerformLayout();
            panelZiskZUroku.ResumeLayout(false);
            panelZiskZUroku.PerformLayout();
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
        private Button button1;
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
    }
}
