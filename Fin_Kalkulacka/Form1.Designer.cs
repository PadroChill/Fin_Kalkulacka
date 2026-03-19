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
            panel1 = new Panel();
            label5 = new Label();
            txtSavingsRate = new TextBox();
            label4 = new Label();
            txtMonthlyDeposit = new TextBox();
            label3 = new Label();
            txtInitialDeposit = new TextBox();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            numericUpDown1 = new NumericUpDown();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
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
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(22, 22, 31);
            panel1.Controls.Add(numericUpDown1);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txtSavingsRate);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtMonthlyDeposit);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtInitialDeposit);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(211, 151);
            panel1.Name = "panel1";
            panel1.Size = new Size(345, 451);
            panel1.TabIndex = 1;
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
            // numericUpDown1
            // 
            numericUpDown1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            numericUpDown1.Location = new Point(22, 382);
            numericUpDown1.Margin = new Padding(0);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(300, 29);
            numericUpDown1.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(10, 10, 15);
            ClientSize = new Size(1287, 705);
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Label label2;
        private PictureBox pictureBox1;
        private Label label3;
        private TextBox txtInitialDeposit;
        private Label label5;
        private TextBox txtSavingsRate;
        private Label label4;
        private TextBox txtMonthlyDeposit;
        private NumericUpDown numericUpDown1;
    }
}
