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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            label1 = new Label();
            VstupniParametry = new Panel();
            btnVymazatUspory = new Button();
            btnCalculateSavings = new Button();
            label6 = new Label();
            nudDobaSporeni = new NumericUpDown();
            label5 = new Label();
            txtRocniSazba = new TextBox();
            label4 = new Label();
            txtMesicniVklad = new TextBox();
            label3 = new Label();
            txtPocatecniVklad = new TextBox();
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
            lblKonecnaCastka = new Label();
            label7 = new Label();
            label11 = new Label();
            pictureBox2 = new PictureBox();
            dgvUspory = new DataGridView();
            Rok = new DataGridViewTextBoxColumn();
            Vlozeno = new DataGridViewTextBoxColumn();
            Úroky = new DataGridViewTextBoxColumn();
            Celkem = new DataGridViewTextBoxColumn();
            btnNaUver = new Button();
            btnNaUspory = new Button();
            VstupniParametry.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudDobaSporeni).BeginInit();
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
            VstupniParametry.Controls.Add(btnVymazatUspory);
            VstupniParametry.Controls.Add(btnCalculateSavings);
            VstupniParametry.Controls.Add(label6);
            VstupniParametry.Controls.Add(nudDobaSporeni);
            VstupniParametry.Controls.Add(label5);
            VstupniParametry.Controls.Add(txtRocniSazba);
            VstupniParametry.Controls.Add(label4);
            VstupniParametry.Controls.Add(txtMesicniVklad);
            VstupniParametry.Controls.Add(label3);
            VstupniParametry.Controls.Add(txtPocatecniVklad);
            VstupniParametry.Controls.Add(label2);
            VstupniParametry.Controls.Add(pictureBox1);
            VstupniParametry.Location = new Point(211, 245);
            VstupniParametry.Name = "VstupniParametry";
            VstupniParametry.Size = new Size(345, 605);
            VstupniParametry.TabIndex = 1;
            // 
            // btnVymazatUspory
            // 
            btnVymazatUspory.BackColor = Color.FromArgb(22, 22, 31);
            btnVymazatUspory.FlatStyle = FlatStyle.Flat;
            btnVymazatUspory.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btnVymazatUspory.ForeColor = Color.White;
            btnVymazatUspory.Location = new Point(178, 522);
            btnVymazatUspory.Name = "btnVymazatUspory";
            btnVymazatUspory.Size = new Size(145, 58);
            btnVymazatUspory.TabIndex = 11;
            btnVymazatUspory.Text = "VYMAZAT";
            btnVymazatUspory.UseVisualStyleBackColor = false;
            btnVymazatUspory.Click += btnVymazatUspory_Click;
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
            btnCalculateSavings.Click += btnCalculateSavings_Click;
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
            // nudDobaSporeni
            // 
            nudDobaSporeni.BackColor = Color.FromArgb(17, 17, 24);
            nudDobaSporeni.BorderStyle = BorderStyle.FixedSingle;
            nudDobaSporeni.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            nudDobaSporeni.ForeColor = Color.White;
            nudDobaSporeni.Location = new Point(23, 453);
            nudDobaSporeni.Margin = new Padding(0);
            nudDobaSporeni.Name = "nudDobaSporeni";
            nudDobaSporeni.Size = new Size(300, 30);
            nudDobaSporeni.TabIndex = 8;
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
            // txtRocniSazba
            // 
            txtRocniSazba.BackColor = Color.FromArgb(17, 17, 24);
            txtRocniSazba.BorderStyle = BorderStyle.FixedSingle;
            txtRocniSazba.Font = new Font("Segoe UI", 11.25F);
            txtRocniSazba.ForeColor = Color.White;
            txtRocniSazba.Location = new Point(23, 341);
            txtRocniSazba.Multiline = true;
            txtRocniSazba.Name = "txtRocniSazba";
            txtRocniSazba.Size = new Size(300, 58);
            txtRocniSazba.TabIndex = 6;
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
            // txtMesicniVklad
            // 
            txtMesicniVklad.BackColor = Color.FromArgb(17, 17, 24);
            txtMesicniVklad.BorderStyle = BorderStyle.FixedSingle;
            txtMesicniVklad.Font = new Font("Segoe UI", 11.25F);
            txtMesicniVklad.ForeColor = Color.White;
            txtMesicniVklad.Location = new Point(22, 227);
            txtMesicniVklad.Multiline = true;
            txtMesicniVklad.Name = "txtMesicniVklad";
            txtMesicniVklad.Size = new Size(300, 58);
            txtMesicniVklad.TabIndex = 4;
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
            // txtPocatecniVklad
            // 
            txtPocatecniVklad.BackColor = Color.FromArgb(17, 17, 24);
            txtPocatecniVklad.BorderStyle = BorderStyle.FixedSingle;
            txtPocatecniVklad.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            txtPocatecniVklad.ForeColor = Color.White;
            txtPocatecniVklad.Location = new Point(23, 114);
            txtPocatecniVklad.Multiline = true;
            txtPocatecniVklad.Name = "txtPocatecniVklad";
            txtPocatecniVklad.Size = new Size(300, 58);
            txtPocatecniVklad.TabIndex = 2;
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
            Vysledky.Location = new Point(574, 245);
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
            panelKonecnaCastka.Controls.Add(lblKonecnaCastka);
            panelKonecnaCastka.Controls.Add(label7);
            panelKonecnaCastka.Location = new Point(23, 84);
            panelKonecnaCastka.Name = "panelKonecnaCastka";
            panelKonecnaCastka.Size = new Size(402, 113);
            panelKonecnaCastka.TabIndex = 2;
            // 
            // lblKonecnaCastka
            // 
            lblKonecnaCastka.AutoSize = true;
            lblKonecnaCastka.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            lblKonecnaCastka.ForeColor = Color.FromArgb(200, 240, 96);
            lblKonecnaCastka.Location = new Point(17, 61);
            lblKonecnaCastka.Name = "lblKonecnaCastka";
            lblKonecnaCastka.RightToLeft = RightToLeft.No;
            lblKonecnaCastka.Size = new Size(38, 32);
            lblKonecnaCastka.TabIndex = 13;
            lblKonecnaCastka.Text = "—";
            lblKonecnaCastka.Click += label8_Click;
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
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(22, 22, 31);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 8.830189F);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.Padding = new Padding(4);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(22, 22, 31);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvUspory.DefaultCellStyle = dataGridViewCellStyle3;
            dgvUspory.EnableHeadersVisualStyles = false;
            dgvUspory.GridColor = Color.FromArgb(22, 22, 31);
            dgvUspory.Location = new Point(211, 884);
            dgvUspory.Name = "dgvUspory";
            dgvUspory.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(64, 0, 0);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 8.830189F);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvUspory.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvUspory.RowHeadersVisible = false;
            dgvUspory.RowHeadersWidth = 45;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(22, 22, 31);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 8.830189F, FontStyle.Regular, GraphicsUnit.Point, 238);
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(22, 22, 31);
            dataGridViewCellStyle5.SelectionForeColor = Color.White;
            dgvUspory.RowsDefaultCellStyle = dataGridViewCellStyle5;
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
            dataGridViewCellStyle2.BackColor = Color.FromArgb(200, 240, 96);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(200, 240, 96);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(22, 22, 31);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(200, 240, 96);
            Úroky.DefaultCellStyle = dataGridViewCellStyle2;
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
            // btnNaUver
            // 
            btnNaUver.BackColor = Color.FromArgb(22, 22, 31);
            btnNaUver.FlatStyle = FlatStyle.Flat;
            btnNaUver.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btnNaUver.ForeColor = Color.White;
            btnNaUver.Location = new Point(372, 172);
            btnNaUver.Name = "btnNaUver";
            btnNaUver.Size = new Size(145, 58);
            btnNaUver.TabIndex = 16;
            btnNaUver.Text = "ÚVĚR";
            btnNaUver.UseVisualStyleBackColor = false;
            btnNaUver.Click += btnNaUver_Click;
            // 
            // btnNaUspory
            // 
            btnNaUspory.BackColor = Color.FromArgb(22, 22, 31);
            btnNaUspory.FlatStyle = FlatStyle.Flat;
            btnNaUspory.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btnNaUspory.ForeColor = Color.FromArgb(200, 240, 96);
            btnNaUspory.Location = new Point(211, 172);
            btnNaUspory.Name = "btnNaUspory";
            btnNaUspory.Size = new Size(145, 58);
            btnNaUspory.TabIndex = 17;
            btnNaUspory.Text = "ÚSPORY";
            btnNaUspory.UseVisualStyleBackColor = false;
            // 
            // Uspory
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(10, 10, 15);
            ClientSize = new Size(1343, 1100);
            Controls.Add(btnNaUver);
            Controls.Add(btnNaUspory);
            Controls.Add(dgvUspory);
            Controls.Add(Vysledky);
            Controls.Add(VstupniParametry);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Uspory";
            Text = "Form1";
            VstupniParametry.ResumeLayout(false);
            VstupniParametry.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudDobaSporeni).EndInit();
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
        private TextBox txtPocatecniVklad;
        private Label label5;
        private TextBox txtRocniSazba;
        private Label label4;
        private TextBox txtMesicniVklad;
        private NumericUpDown nudDobaSporeni;
        private Button btnCalculateSavings;
        private Label label6;
        private Button btnVymazatUspory;
        private Panel Vysledky;
        private Label label11;
        private PictureBox pictureBox2;
        private Panel panelKonecnaCastka;
        private Label label7;
        private Label lblKonecnaCastka;
        private Panel panelCelkemVlozeno;
        private Label lblCelkemVlozeno;
        private Label label9;
        private Panel panelZiskZUroku;
        private Label lblZiskZUroku;
        private Label label10;
        private DataGridView dgvUspory;
        private Button btnNaUver;
        private Button btnNaUspory;
        private DataGridViewTextBoxColumn Rok;
        private DataGridViewTextBoxColumn Vlozeno;
        private DataGridViewTextBoxColumn Úroky;
        private DataGridViewTextBoxColumn Celkem;
    }
}
