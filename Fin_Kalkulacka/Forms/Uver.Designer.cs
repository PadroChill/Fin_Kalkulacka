namespace Fin_Kalkulacka.Forms
{
    partial class Uver
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            label1 = new Label();
            VstupniParametryUver = new Panel();
            label4 = new Label();
            rbLinearni = new RadioButton();
            rbAnuitni = new RadioButton();
            btnVymazatUver = new Button();
            btnVypocitatUver = new Button();
            label6 = new Label();
            nudRokyUveru = new NumericUpDown();
            label5 = new Label();
            txtSazbaUveru = new TextBox();
            label3 = new Label();
            txtVyseUveru = new TextBox();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            VysledkyUver = new Panel();
            btnExportCsv = new Button();
            panelZiskZUroku = new Panel();
            lblCelkemNaUrocich = new Label();
            label10 = new Label();
            panelCelkemVlozeno = new Panel();
            lblCelkemZaplaceno = new Label();
            label9 = new Label();
            panelKonecnaCastka = new Panel();
            lblMesicniSplatka = new Label();
            label7 = new Label();
            label11 = new Label();
            pictureBox2 = new PictureBox();
            dgvKalendar = new DataGridView();
            Mesic = new DataGridViewTextBoxColumn();
            Zustatek = new DataGridViewTextBoxColumn();
            Splatka = new DataGridViewTextBoxColumn();
            Urok = new DataGridViewTextBoxColumn();
            Jistina = new DataGridViewTextBoxColumn();
            btnNaUspory = new Button();
            btnNaUver = new Button();
            VstupniParametryUver.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudRokyUveru).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            VysledkyUver.SuspendLayout();
            panelZiskZUroku.SuspendLayout();
            panelCelkemVlozeno.SuspendLayout();
            panelKonecnaCastka.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvKalendar).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.ForeColor = Color.White;
            label1.Location = new Point(216, 59);
            label1.Name = "label1";
            label1.Size = new Size(384, 52);
            label1.TabIndex = 1;
            label1.Text = "Finanční Kalkulačka";
            // 
            // VstupniParametryUver
            // 
            VstupniParametryUver.BackColor = Color.FromArgb(22, 22, 31);
            VstupniParametryUver.Controls.Add(label4);
            VstupniParametryUver.Controls.Add(rbLinearni);
            VstupniParametryUver.Controls.Add(rbAnuitni);
            VstupniParametryUver.Controls.Add(btnVymazatUver);
            VstupniParametryUver.Controls.Add(btnVypocitatUver);
            VstupniParametryUver.Controls.Add(label6);
            VstupniParametryUver.Controls.Add(nudRokyUveru);
            VstupniParametryUver.Controls.Add(label5);
            VstupniParametryUver.Controls.Add(txtSazbaUveru);
            VstupniParametryUver.Controls.Add(label3);
            VstupniParametryUver.Controls.Add(txtVyseUveru);
            VstupniParametryUver.Controls.Add(label2);
            VstupniParametryUver.Controls.Add(pictureBox1);
            VstupniParametryUver.Location = new Point(216, 217);
            VstupniParametryUver.Name = "VstupniParametryUver";
            VstupniParametryUver.Size = new Size(345, 583);
            VstupniParametryUver.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label4.ForeColor = Color.White;
            label4.Location = new Point(22, 396);
            label4.Name = "label4";
            label4.Size = new Size(100, 19);
            label4.TabIndex = 14;
            label4.Text = "TYP SPLACENÍ";
            // 
            // rbLinearni
            // 
            rbLinearni.AutoSize = true;
            rbLinearni.Font = new Font("Segoe UI", 8.830189F, FontStyle.Regular, GraphicsUnit.Point, 238);
            rbLinearni.ForeColor = Color.White;
            rbLinearni.Location = new Point(140, 427);
            rbLinearni.Name = "rbLinearni";
            rbLinearni.Padding = new Padding(8);
            rbLinearni.Size = new Size(97, 37);
            rbLinearni.TabIndex = 13;
            rbLinearni.Text = "LINEÁRNÍ";
            rbLinearni.UseVisualStyleBackColor = true;
            // 
            // rbAnuitni
            // 
            rbAnuitni.AutoSize = true;
            rbAnuitni.Checked = true;
            rbAnuitni.Font = new Font("Segoe UI", 8.830189F, FontStyle.Regular, GraphicsUnit.Point, 238);
            rbAnuitni.ForeColor = Color.White;
            rbAnuitni.Location = new Point(25, 427);
            rbAnuitni.Name = "rbAnuitni";
            rbAnuitni.Padding = new Padding(8);
            rbAnuitni.Size = new Size(92, 37);
            rbAnuitni.TabIndex = 12;
            rbAnuitni.TabStop = true;
            rbAnuitni.Text = "ANUITNÍ";
            rbAnuitni.UseVisualStyleBackColor = true;
            // 
            // btnVymazatUver
            // 
            btnVymazatUver.BackColor = Color.FromArgb(22, 22, 31);
            btnVymazatUver.FlatStyle = FlatStyle.Flat;
            btnVymazatUver.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btnVymazatUver.ForeColor = Color.White;
            btnVymazatUver.Location = new Point(178, 506);
            btnVymazatUver.Name = "btnVymazatUver";
            btnVymazatUver.Size = new Size(145, 58);
            btnVymazatUver.TabIndex = 11;
            btnVymazatUver.Text = "VYMAZAT";
            btnVymazatUver.UseVisualStyleBackColor = false;
            btnVymazatUver.Click += btnVymazatUver_Click;
            // 
            // btnVypocitatUver
            // 
            btnVypocitatUver.BackColor = Color.FromArgb(200, 240, 96);
            btnVypocitatUver.FlatStyle = FlatStyle.Flat;
            btnVypocitatUver.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btnVypocitatUver.ForeColor = SystemColors.ControlText;
            btnVypocitatUver.Location = new Point(23, 506);
            btnVypocitatUver.Name = "btnVypocitatUver";
            btnVypocitatUver.Size = new Size(145, 58);
            btnVypocitatUver.TabIndex = 10;
            btnVypocitatUver.Text = "VYPOČÍTAT";
            btnVypocitatUver.UseVisualStyleBackColor = false;
            btnVypocitatUver.Click += btnVypocitatUver_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label6.ForeColor = Color.White;
            label6.Location = new Point(22, 306);
            label6.Name = "label6";
            label6.Size = new Size(114, 19);
            label6.TabIndex = 9;
            label6.Text = "DOBA SPLACENÍ";
            // 
            // nudRokyUveru
            // 
            nudRokyUveru.BackColor = Color.FromArgb(17, 17, 24);
            nudRokyUveru.BorderStyle = BorderStyle.FixedSingle;
            nudRokyUveru.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            nudRokyUveru.ForeColor = Color.White;
            nudRokyUveru.Location = new Point(23, 334);
            nudRokyUveru.Margin = new Padding(0);
            nudRokyUveru.Name = "nudRokyUveru";
            nudRokyUveru.Size = new Size(300, 30);
            nudRokyUveru.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label5.ForeColor = Color.White;
            label5.Location = new Point(23, 196);
            label5.Name = "label5";
            label5.Size = new Size(200, 19);
            label5.TabIndex = 7;
            label5.Text = "ROČNÍ ÚROKOVÁ SAZBA (KČ)";
            // 
            // txtSazbaUveru
            // 
            txtSazbaUveru.BackColor = Color.FromArgb(17, 17, 24);
            txtSazbaUveru.BorderStyle = BorderStyle.FixedSingle;
            txtSazbaUveru.Font = new Font("Segoe UI", 11.25F);
            txtSazbaUveru.ForeColor = Color.White;
            txtSazbaUveru.Location = new Point(23, 226);
            txtSazbaUveru.Multiline = true;
            txtSazbaUveru.Name = "txtSazbaUveru";
            txtSazbaUveru.Size = new Size(300, 58);
            txtSazbaUveru.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label3.ForeColor = Color.White;
            label3.Location = new Point(23, 84);
            label3.Name = "label3";
            label3.Size = new Size(121, 19);
            label3.TabIndex = 3;
            label3.Text = "VÝŠE ÚVERU (KČ)";
            // 
            // txtVyseUveru
            // 
            txtVyseUveru.BackColor = Color.FromArgb(17, 17, 24);
            txtVyseUveru.BorderStyle = BorderStyle.FixedSingle;
            txtVyseUveru.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            txtVyseUveru.ForeColor = Color.White;
            txtVyseUveru.Location = new Point(23, 114);
            txtVyseUveru.Multiline = true;
            txtVyseUveru.Name = "txtVyseUveru";
            txtVyseUveru.Size = new Size(300, 58);
            txtVyseUveru.TabIndex = 2;
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
            pictureBox1.Location = new Point(23, 29);
            pictureBox1.MaximumSize = new Size(50, 57);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(12, 14);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // VysledkyUver
            // 
            VysledkyUver.BackColor = Color.FromArgb(22, 22, 31);
            VysledkyUver.Controls.Add(btnExportCsv);
            VysledkyUver.Controls.Add(panelZiskZUroku);
            VysledkyUver.Controls.Add(panelCelkemVlozeno);
            VysledkyUver.Controls.Add(panelKonecnaCastka);
            VysledkyUver.Controls.Add(label11);
            VysledkyUver.Controls.Add(pictureBox2);
            VysledkyUver.Location = new Point(579, 217);
            VysledkyUver.Name = "VysledkyUver";
            VysledkyUver.Size = new Size(467, 583);
            VysledkyUver.TabIndex = 15;
            // 
            // btnExportCsv
            // 
            btnExportCsv.BackColor = Color.FromArgb(22, 22, 31);
            btnExportCsv.FlatStyle = FlatStyle.Flat;
            btnExportCsv.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btnExportCsv.ForeColor = Color.FromArgb(200, 240, 96);
            btnExportCsv.Location = new Point(23, 357);
            btnExportCsv.Name = "btnExportCsv";
            btnExportCsv.Size = new Size(424, 58);
            btnExportCsv.TabIndex = 17;
            btnExportCsv.Text = "EXPORTOVAT DO SOUBORU CSV";
            btnExportCsv.UseVisualStyleBackColor = false;
            btnExportCsv.Click += btnExportCsv_Click;
            // 
            // panelZiskZUroku
            // 
            panelZiskZUroku.BackColor = Color.FromArgb(17, 17, 24);
            panelZiskZUroku.BorderStyle = BorderStyle.FixedSingle;
            panelZiskZUroku.Controls.Add(lblCelkemNaUrocich);
            panelZiskZUroku.Controls.Add(label10);
            panelZiskZUroku.Location = new Point(231, 212);
            panelZiskZUroku.Name = "panelZiskZUroku";
            panelZiskZUroku.Size = new Size(216, 113);
            panelZiskZUroku.TabIndex = 15;
            // 
            // lblCelkemNaUrocich
            // 
            lblCelkemNaUrocich.AutoSize = true;
            lblCelkemNaUrocich.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            lblCelkemNaUrocich.ForeColor = Color.White;
            lblCelkemNaUrocich.Location = new Point(17, 61);
            lblCelkemNaUrocich.Name = "lblCelkemNaUrocich";
            lblCelkemNaUrocich.RightToLeft = RightToLeft.No;
            lblCelkemNaUrocich.Size = new Size(34, 30);
            lblCelkemNaUrocich.TabIndex = 13;
            lblCelkemNaUrocich.Text = "—";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label10.ForeColor = Color.White;
            label10.Location = new Point(17, 17);
            label10.Name = "label10";
            label10.Size = new Size(178, 19);
            label10.TabIndex = 12;
            label10.Text = "ZAPLACENO NA ÚROCÍCH";
            // 
            // panelCelkemVlozeno
            // 
            panelCelkemVlozeno.BackColor = Color.FromArgb(17, 17, 24);
            panelCelkemVlozeno.BorderStyle = BorderStyle.FixedSingle;
            panelCelkemVlozeno.Controls.Add(lblCelkemZaplaceno);
            panelCelkemVlozeno.Controls.Add(label9);
            panelCelkemVlozeno.Location = new Point(23, 212);
            panelCelkemVlozeno.Name = "panelCelkemVlozeno";
            panelCelkemVlozeno.Size = new Size(194, 113);
            panelCelkemVlozeno.TabIndex = 14;
            // 
            // lblCelkemZaplaceno
            // 
            lblCelkemZaplaceno.AutoSize = true;
            lblCelkemZaplaceno.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            lblCelkemZaplaceno.ForeColor = Color.White;
            lblCelkemZaplaceno.Location = new Point(17, 61);
            lblCelkemZaplaceno.Name = "lblCelkemZaplaceno";
            lblCelkemZaplaceno.RightToLeft = RightToLeft.No;
            lblCelkemZaplaceno.Size = new Size(34, 30);
            lblCelkemZaplaceno.TabIndex = 13;
            lblCelkemZaplaceno.Text = "—";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label9.ForeColor = Color.White;
            label9.Location = new Point(17, 17);
            label9.Name = "label9";
            label9.Size = new Size(144, 19);
            label9.TabIndex = 12;
            label9.Text = "CELKEM ZAPLACENO";
            // 
            // panelKonecnaCastka
            // 
            panelKonecnaCastka.BackColor = Color.FromArgb(17, 17, 24);
            panelKonecnaCastka.BorderStyle = BorderStyle.FixedSingle;
            panelKonecnaCastka.Controls.Add(lblMesicniSplatka);
            panelKonecnaCastka.Controls.Add(label7);
            panelKonecnaCastka.Location = new Point(23, 84);
            panelKonecnaCastka.Name = "panelKonecnaCastka";
            panelKonecnaCastka.Size = new Size(424, 113);
            panelKonecnaCastka.TabIndex = 2;
            // 
            // lblMesicniSplatka
            // 
            lblMesicniSplatka.AutoSize = true;
            lblMesicniSplatka.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            lblMesicniSplatka.ForeColor = Color.FromArgb(200, 240, 96);
            lblMesicniSplatka.Location = new Point(17, 61);
            lblMesicniSplatka.Name = "lblMesicniSplatka";
            lblMesicniSplatka.RightToLeft = RightToLeft.No;
            lblMesicniSplatka.Size = new Size(38, 32);
            lblMesicniSplatka.TabIndex = 13;
            lblMesicniSplatka.Text = "—";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label7.ForeColor = Color.White;
            label7.Location = new Point(17, 17);
            label7.Name = "label7";
            label7.Size = new Size(126, 19);
            label7.TabIndex = 12;
            label7.Text = "MĚSIČNÍ SPLÁTKA";
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
            pictureBox2.Location = new Point(23, 29);
            pictureBox2.MaximumSize = new Size(50, 57);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(12, 14);
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // dgvKalendar
            // 
            dgvKalendar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvKalendar.BackgroundColor = Color.FromArgb(22, 22, 31);
            dgvKalendar.BorderStyle = BorderStyle.None;
            dgvKalendar.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvKalendar.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(22, 22, 31);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 8.830189F);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.Padding = new Padding(4);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(22, 22, 31);
            dataGridViewCellStyle1.SelectionForeColor = Color.Honeydew;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvKalendar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvKalendar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKalendar.Columns.AddRange(new DataGridViewColumn[] { Mesic, Zustatek, Splatka, Urok, Jistina });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(22, 22, 31);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 8.830189F);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.Padding = new Padding(4);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(22, 22, 31);
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgvKalendar.DefaultCellStyle = dataGridViewCellStyle4;
            dgvKalendar.EnableHeadersVisualStyles = false;
            dgvKalendar.GridColor = Color.FromArgb(22, 22, 31);
            dgvKalendar.Location = new Point(216, 820);
            dgvKalendar.Name = "dgvKalendar";
            dgvKalendar.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(64, 0, 0);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 8.830189F);
            dataGridViewCellStyle5.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgvKalendar.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvKalendar.RowHeadersVisible = false;
            dgvKalendar.RowHeadersWidth = 45;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(22, 22, 31);
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 8.830189F, FontStyle.Regular, GraphicsUnit.Point, 238);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(22, 22, 31);
            dataGridViewCellStyle6.SelectionForeColor = Color.White;
            dgvKalendar.RowsDefaultCellStyle = dataGridViewCellStyle6;
            dgvKalendar.Size = new Size(830, 166);
            dgvKalendar.TabIndex = 16;
            // 
            // Mesic
            // 
            dataGridViewCellStyle2.BackColor = Color.FromArgb(22, 22, 31);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(22, 22, 31);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            Mesic.DefaultCellStyle = dataGridViewCellStyle2;
            Mesic.HeaderText = "Měsíc";
            Mesic.MinimumWidth = 6;
            Mesic.Name = "Mesic";
            // 
            // Zustatek
            // 
            Zustatek.HeaderText = "Zůstatek (Kč)";
            Zustatek.MinimumWidth = 6;
            Zustatek.Name = "Zustatek";
            // 
            // Splatka
            // 
            Splatka.HeaderText = "Splátka (Kč)";
            Splatka.MinimumWidth = 6;
            Splatka.Name = "Splatka";
            // 
            // Urok
            // 
            dataGridViewCellStyle3.BackColor = Color.FromArgb(22, 22, 31);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(200, 240, 96);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(22, 22, 31);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(200, 240, 96);
            Urok.DefaultCellStyle = dataGridViewCellStyle3;
            Urok.HeaderText = "Úrok (Kč)";
            Urok.MinimumWidth = 6;
            Urok.Name = "Urok";
            // 
            // Jistina
            // 
            Jistina.HeaderText = "Jistina (Kč)";
            Jistina.MinimumWidth = 6;
            Jistina.Name = "Jistina";
            // 
            // btnNaUspory
            // 
            btnNaUspory.BackColor = Color.FromArgb(22, 22, 31);
            btnNaUspory.FlatStyle = FlatStyle.Flat;
            btnNaUspory.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btnNaUspory.ForeColor = Color.White;
            btnNaUspory.Location = new Point(216, 143);
            btnNaUspory.Name = "btnNaUspory";
            btnNaUspory.Size = new Size(145, 58);
            btnNaUspory.TabIndex = 15;
            btnNaUspory.Text = "ÚSPORY";
            btnNaUspory.UseVisualStyleBackColor = false;
            btnNaUspory.Click += btnNaUspory_Click;
            // 
            // btnNaUver
            // 
            btnNaUver.BackColor = Color.FromArgb(22, 22, 31);
            btnNaUver.FlatStyle = FlatStyle.Flat;
            btnNaUver.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btnNaUver.ForeColor = Color.FromArgb(200, 240, 96);
            btnNaUver.Location = new Point(377, 143);
            btnNaUver.Name = "btnNaUver";
            btnNaUver.Size = new Size(145, 58);
            btnNaUver.TabIndex = 15;
            btnNaUver.Text = "ÚVĚR";
            btnNaUver.UseVisualStyleBackColor = false;
            // 
            // Uver
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(10, 10, 15);
            ClientSize = new Size(1386, 1059);
            Controls.Add(btnNaUver);
            Controls.Add(btnNaUspory);
            Controls.Add(dgvKalendar);
            Controls.Add(VysledkyUver);
            Controls.Add(VstupniParametryUver);
            Controls.Add(label1);
            Name = "Uver";
            Text = "Uver";
            VstupniParametryUver.ResumeLayout(false);
            VstupniParametryUver.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudRokyUveru).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            VysledkyUver.ResumeLayout(false);
            VysledkyUver.PerformLayout();
            panelZiskZUroku.ResumeLayout(false);
            panelZiskZUroku.PerformLayout();
            panelCelkemVlozeno.ResumeLayout(false);
            panelCelkemVlozeno.PerformLayout();
            panelKonecnaCastka.ResumeLayout(false);
            panelKonecnaCastka.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvKalendar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel VstupniParametryUver;
        private Button btnVymazatUver;
        private Button btnVypocitatUver;
        private Label label6;
        private NumericUpDown nudRokyUveru;
        private Label label5;
        private TextBox txtSazbaUveru;
        private Label label3;
        private TextBox txtVyseUveru;
        private Label label2;
        private PictureBox pictureBox1;
        private RadioButton rbAnuitni;
        private Label label4;
        private RadioButton rbLinearni;
        private Panel VysledkyUver;
        private Panel panelZiskZUroku;
        private Label lblCelkemNaUrocich;
        private Label label10;
        private Panel panelCelkemVlozeno;
        private Label lblCelkemZaplaceno;
        private Label label9;
        private Panel panelKonecnaCastka;
        private Label lblMesicniSplatka;
        private Label label7;
        private Label label11;
        private PictureBox pictureBox2;
        private DataGridView dgvKalendar;
        private Button btnNaUver;
        private Button btnNaUspory;
        private Button btnExportCsv;
        private DataGridViewTextBoxColumn Mesic;
        private DataGridViewTextBoxColumn Zustatek;
        private DataGridViewTextBoxColumn Splatka;
        private DataGridViewTextBoxColumn Urok;
        private DataGridViewTextBoxColumn Jistina;
    }
}