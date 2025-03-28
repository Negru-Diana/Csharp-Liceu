namespace IstoriaSclaviei
{
    partial class FrmStergeTest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmStergeTest));
            this.lstTeste = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlDetalii = new System.Windows.Forms.Panel();
            this.lstIntrTest = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSalveazaModif = new System.Windows.Forms.Button();
            this.txtLectie = new System.Windows.Forms.TextBox();
            this.txtCapitol = new System.Windows.Forms.TextBox();
            this.txtDenumTest = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pnlDetalii.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstTeste
            // 
            this.lstTeste.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstTeste.FormattingEnabled = true;
            this.lstTeste.ItemHeight = 24;
            this.lstTeste.Location = new System.Drawing.Point(52, 53);
            this.lstTeste.Name = "lstTeste";
            this.lstTeste.Size = new System.Drawing.Size(311, 652);
            this.lstTeste.TabIndex = 68;
            this.lstTeste.SelectedIndexChanged += new System.EventHandler(this.lstTeste_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(47, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 25);
            this.label2.TabIndex = 67;
            this.label2.Text = "Teste:";
            // 
            // pnlDetalii
            // 
            this.pnlDetalii.BackColor = System.Drawing.Color.Transparent;
            this.pnlDetalii.Controls.Add(this.lstIntrTest);
            this.pnlDetalii.Controls.Add(this.label1);
            this.pnlDetalii.Controls.Add(this.btnSalveazaModif);
            this.pnlDetalii.Controls.Add(this.txtLectie);
            this.pnlDetalii.Controls.Add(this.txtCapitol);
            this.pnlDetalii.Controls.Add(this.txtDenumTest);
            this.pnlDetalii.Controls.Add(this.label6);
            this.pnlDetalii.Controls.Add(this.label8);
            this.pnlDetalii.Controls.Add(this.label7);
            this.pnlDetalii.Location = new System.Drawing.Point(378, 12);
            this.pnlDetalii.Name = "pnlDetalii";
            this.pnlDetalii.Size = new System.Drawing.Size(681, 728);
            this.pnlDetalii.TabIndex = 83;
            // 
            // lstIntrTest
            // 
            this.lstIntrTest.Enabled = false;
            this.lstIntrTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstIntrTest.FormattingEnabled = true;
            this.lstIntrTest.ItemHeight = 24;
            this.lstIntrTest.Location = new System.Drawing.Point(339, 41);
            this.lstIntrTest.Name = "lstIntrTest";
            this.lstIntrTest.Size = new System.Drawing.Size(311, 652);
            this.lstIntrTest.TabIndex = 85;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(334, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 25);
            this.label1.TabIndex = 84;
            this.label1.Text = "Intrebari test:";
            // 
            // btnSalveazaModif
            // 
            this.btnSalveazaModif.BackColor = System.Drawing.Color.BurlyWood;
            this.btnSalveazaModif.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalveazaModif.Location = new System.Drawing.Point(20, 400);
            this.btnSalveazaModif.Name = "btnSalveazaModif";
            this.btnSalveazaModif.Size = new System.Drawing.Size(281, 38);
            this.btnSalveazaModif.TabIndex = 80;
            this.btnSalveazaModif.Text = "Sterge test";
            this.btnSalveazaModif.UseVisualStyleBackColor = false;
            this.btnSalveazaModif.Click += new System.EventHandler(this.btnSalveazaModif_Click);
            // 
            // txtLectie
            // 
            this.txtLectie.Enabled = false;
            this.txtLectie.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLectie.Location = new System.Drawing.Point(20, 322);
            this.txtLectie.Name = "txtLectie";
            this.txtLectie.Size = new System.Drawing.Size(281, 31);
            this.txtLectie.TabIndex = 83;
            // 
            // txtCapitol
            // 
            this.txtCapitol.Enabled = false;
            this.txtCapitol.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCapitol.Location = new System.Drawing.Point(20, 242);
            this.txtCapitol.Name = "txtCapitol";
            this.txtCapitol.Size = new System.Drawing.Size(281, 31);
            this.txtCapitol.TabIndex = 82;
            // 
            // txtDenumTest
            // 
            this.txtDenumTest.Enabled = false;
            this.txtDenumTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDenumTest.Location = new System.Drawing.Point(20, 165);
            this.txtDenumTest.Name = "txtDenumTest";
            this.txtDenumTest.Size = new System.Drawing.Size(281, 31);
            this.txtDenumTest.TabIndex = 81;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(16, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 20);
            this.label6.TabIndex = 80;
            this.label6.Text = "Denumire test:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(16, 299);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 20);
            this.label8.TabIndex = 78;
            this.label8.Text = "Lectie test:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(16, 219);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 20);
            this.label7.TabIndex = 76;
            this.label7.Text = "Capitol test:";
            // 
            // FrmStergeTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1071, 767);
            this.Controls.Add(this.pnlDetalii);
            this.Controls.Add(this.lstTeste);
            this.Controls.Add(this.label2);
            this.Name = "FrmStergeTest";
            this.Text = "Sterge Test";
            this.Load += new System.EventHandler(this.FrmStergeTest_Load);
            this.pnlDetalii.ResumeLayout(false);
            this.pnlDetalii.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstTeste;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlDetalii;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSalveazaModif;
        private System.Windows.Forms.TextBox txtLectie;
        private System.Windows.Forms.TextBox txtCapitol;
        private System.Windows.Forms.TextBox txtDenumTest;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox lstIntrTest;
        private System.Windows.Forms.Label label1;
    }
}