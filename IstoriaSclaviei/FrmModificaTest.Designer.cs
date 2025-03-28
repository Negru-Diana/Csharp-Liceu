namespace IstoriaSclaviei
{
    partial class FrmModificaTest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmModificaTest));
            this.cbLectii = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbCapitole = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnJos = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSus = new System.Windows.Forms.Button();
            this.btnStergeIntrebare = new System.Windows.Forms.Button();
            this.btnAdaugaIntrebare = new System.Windows.Forms.Button();
            this.lstIntrTest = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lstIntrebari = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSalveazaModif = new System.Windows.Forms.Button();
            this.cbTeste = new System.Windows.Forms.ComboBox();
            this.pnlControl = new System.Windows.Forms.Panel();
            this.lstID = new System.Windows.Forms.ListBox();
            this.pnlControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbLectii
            // 
            this.cbLectii.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLectii.FormattingEnabled = true;
            this.cbLectii.Location = new System.Drawing.Point(22, 118);
            this.cbLectii.Name = "cbLectii";
            this.cbLectii.Size = new System.Drawing.Size(281, 33);
            this.cbLectii.TabIndex = 79;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(18, 95);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 20);
            this.label8.TabIndex = 78;
            this.label8.Text = "Lectie test:";
            // 
            // cbCapitole
            // 
            this.cbCapitole.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCapitole.FormattingEnabled = true;
            this.cbCapitole.Location = new System.Drawing.Point(22, 38);
            this.cbCapitole.Name = "cbCapitole";
            this.cbCapitole.Size = new System.Drawing.Size(281, 33);
            this.cbCapitole.TabIndex = 77;
            this.cbCapitole.SelectedIndexChanged += new System.EventHandler(this.cbCapitole_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(18, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 20);
            this.label7.TabIndex = 76;
            this.label7.Text = "Capitol test:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(50, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 20);
            this.label6.TabIndex = 74;
            this.label6.Text = "Denumire test:";
            // 
            // btnJos
            // 
            this.btnJos.BackColor = System.Drawing.Color.BurlyWood;
            this.btnJos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJos.Location = new System.Drawing.Point(22, 454);
            this.btnJos.Name = "btnJos";
            this.btnJos.Size = new System.Drawing.Size(281, 38);
            this.btnJos.TabIndex = 73;
            this.btnJos.Text = "jos";
            this.btnJos.UseVisualStyleBackColor = false;
            this.btnJos.Click += new System.EventHandler(this.btnJos_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(18, 375);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(181, 20);
            this.label5.TabIndex = 72;
            this.label5.Text = "Modifica ordine intrebari:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(18, 265);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 20);
            this.label4.TabIndex = 71;
            this.label4.Text = "Sterge intrebari test:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(18, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 20);
            this.label3.TabIndex = 70;
            this.label3.Text = "Adauga intrebari test:";
            // 
            // btnSus
            // 
            this.btnSus.BackColor = System.Drawing.Color.BurlyWood;
            this.btnSus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSus.Location = new System.Drawing.Point(22, 398);
            this.btnSus.Name = "btnSus";
            this.btnSus.Size = new System.Drawing.Size(281, 38);
            this.btnSus.TabIndex = 69;
            this.btnSus.Text = "sus";
            this.btnSus.UseVisualStyleBackColor = false;
            this.btnSus.Click += new System.EventHandler(this.btnSus_Click);
            // 
            // btnStergeIntrebare
            // 
            this.btnStergeIntrebare.BackColor = System.Drawing.Color.BurlyWood;
            this.btnStergeIntrebare.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStergeIntrebare.Location = new System.Drawing.Point(22, 288);
            this.btnStergeIntrebare.Name = "btnStergeIntrebare";
            this.btnStergeIntrebare.Size = new System.Drawing.Size(281, 38);
            this.btnStergeIntrebare.TabIndex = 68;
            this.btnStergeIntrebare.Text = "-";
            this.btnStergeIntrebare.UseVisualStyleBackColor = false;
            this.btnStergeIntrebare.Click += new System.EventHandler(this.btnStergeIntrebare_Click);
            // 
            // btnAdaugaIntrebare
            // 
            this.btnAdaugaIntrebare.BackColor = System.Drawing.Color.BurlyWood;
            this.btnAdaugaIntrebare.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdaugaIntrebare.Location = new System.Drawing.Point(22, 206);
            this.btnAdaugaIntrebare.Name = "btnAdaugaIntrebare";
            this.btnAdaugaIntrebare.Size = new System.Drawing.Size(281, 38);
            this.btnAdaugaIntrebare.TabIndex = 67;
            this.btnAdaugaIntrebare.Text = "+";
            this.btnAdaugaIntrebare.UseVisualStyleBackColor = false;
            this.btnAdaugaIntrebare.Click += new System.EventHandler(this.btnAdaugaIntrebare_Click);
            // 
            // lstIntrTest
            // 
            this.lstIntrTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstIntrTest.FormattingEnabled = true;
            this.lstIntrTest.ItemHeight = 24;
            this.lstIntrTest.Location = new System.Drawing.Point(378, 65);
            this.lstIntrTest.Name = "lstIntrTest";
            this.lstIntrTest.Size = new System.Drawing.Size(311, 652);
            this.lstIntrTest.TabIndex = 66;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(373, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 25);
            this.label2.TabIndex = 65;
            this.label2.Text = "Intrebari test:";
            // 
            // lstIntrebari
            // 
            this.lstIntrebari.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstIntrebari.FormattingEnabled = true;
            this.lstIntrebari.ItemHeight = 24;
            this.lstIntrebari.Location = new System.Drawing.Point(719, 65);
            this.lstIntrebari.Name = "lstIntrebari";
            this.lstIntrebari.Size = new System.Drawing.Size(311, 652);
            this.lstIntrebari.TabIndex = 64;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(714, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 25);
            this.label1.TabIndex = 63;
            this.label1.Text = "Intrebari:";
            // 
            // btnSalveazaModif
            // 
            this.btnSalveazaModif.BackColor = System.Drawing.Color.BurlyWood;
            this.btnSalveazaModif.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalveazaModif.Location = new System.Drawing.Point(22, 556);
            this.btnSalveazaModif.Name = "btnSalveazaModif";
            this.btnSalveazaModif.Size = new System.Drawing.Size(281, 38);
            this.btnSalveazaModif.TabIndex = 80;
            this.btnSalveazaModif.Text = "Salveaza modificari";
            this.btnSalveazaModif.UseVisualStyleBackColor = false;
            this.btnSalveazaModif.Click += new System.EventHandler(this.btnSalveazaModif_Click);
            // 
            // cbTeste
            // 
            this.cbTeste.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTeste.FormattingEnabled = true;
            this.cbTeste.Location = new System.Drawing.Point(54, 65);
            this.cbTeste.Name = "cbTeste";
            this.cbTeste.Size = new System.Drawing.Size(281, 33);
            this.cbTeste.TabIndex = 81;
            this.cbTeste.SelectedIndexChanged += new System.EventHandler(this.cbTeste_SelectedIndexChanged);
            // 
            // pnlControl
            // 
            this.pnlControl.BackColor = System.Drawing.Color.Transparent;
            this.pnlControl.Controls.Add(this.btnSalveazaModif);
            this.pnlControl.Controls.Add(this.cbLectii);
            this.pnlControl.Controls.Add(this.label8);
            this.pnlControl.Controls.Add(this.cbCapitole);
            this.pnlControl.Controls.Add(this.label7);
            this.pnlControl.Controls.Add(this.btnJos);
            this.pnlControl.Controls.Add(this.label5);
            this.pnlControl.Controls.Add(this.label4);
            this.pnlControl.Controls.Add(this.label3);
            this.pnlControl.Controls.Add(this.btnSus);
            this.pnlControl.Controls.Add(this.btnStergeIntrebare);
            this.pnlControl.Controls.Add(this.btnAdaugaIntrebare);
            this.pnlControl.Location = new System.Drawing.Point(32, 123);
            this.pnlControl.Name = "pnlControl";
            this.pnlControl.Size = new System.Drawing.Size(323, 621);
            this.pnlControl.TabIndex = 82;
            // 
            // lstID
            // 
            this.lstID.FormattingEnabled = true;
            this.lstID.Location = new System.Drawing.Point(557, 26);
            this.lstID.Name = "lstID";
            this.lstID.Size = new System.Drawing.Size(120, 17);
            this.lstID.TabIndex = 83;
            this.lstID.Visible = false;
            // 
            // FrmModificaTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1071, 767);
            this.Controls.Add(this.lstID);
            this.Controls.Add(this.pnlControl);
            this.Controls.Add(this.cbTeste);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lstIntrTest);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstIntrebari);
            this.Controls.Add(this.label1);
            this.Name = "FrmModificaTest";
            this.Text = "Modifica Test";
            this.Load += new System.EventHandler(this.FrmModificaTest_Load);
            this.pnlControl.ResumeLayout(false);
            this.pnlControl.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbLectii;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbCapitole;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnJos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSus;
        private System.Windows.Forms.Button btnStergeIntrebare;
        private System.Windows.Forms.Button btnAdaugaIntrebare;
        private System.Windows.Forms.ListBox lstIntrTest;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstIntrebari;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSalveazaModif;
        private System.Windows.Forms.ComboBox cbTeste;
        private System.Windows.Forms.Panel pnlControl;
        private System.Windows.Forms.ListBox lstID;
    }
}