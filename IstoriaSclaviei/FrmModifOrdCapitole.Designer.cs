namespace IstoriaSclaviei
{
    partial class FrmModifOrdCapitole
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmModifOrdCapitole));
            this.lstCapitole = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSalveazaModif = new System.Windows.Forms.Button();
            this.btnJos = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSus = new System.Windows.Forms.Button();
            this.lstIdc = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lstCapitole
            // 
            this.lstCapitole.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstCapitole.FormattingEnabled = true;
            this.lstCapitole.ItemHeight = 24;
            this.lstCapitole.Location = new System.Drawing.Point(59, 69);
            this.lstCapitole.Name = "lstCapitole";
            this.lstCapitole.Size = new System.Drawing.Size(258, 436);
            this.lstCapitole.TabIndex = 67;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(54, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 25);
            this.label2.TabIndex = 68;
            this.label2.Text = "Capitole:";
            // 
            // btnSalveazaModif
            // 
            this.btnSalveazaModif.BackColor = System.Drawing.Color.BurlyWood;
            this.btnSalveazaModif.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalveazaModif.Location = new System.Drawing.Point(397, 467);
            this.btnSalveazaModif.Name = "btnSalveazaModif";
            this.btnSalveazaModif.Size = new System.Drawing.Size(281, 38);
            this.btnSalveazaModif.TabIndex = 84;
            this.btnSalveazaModif.Text = "Salveaza modificari";
            this.btnSalveazaModif.UseVisualStyleBackColor = false;
            this.btnSalveazaModif.Click += new System.EventHandler(this.btnSalveazaModif_Click);
            // 
            // btnJos
            // 
            this.btnJos.BackColor = System.Drawing.Color.BurlyWood;
            this.btnJos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJos.Location = new System.Drawing.Point(397, 165);
            this.btnJos.Name = "btnJos";
            this.btnJos.Size = new System.Drawing.Size(281, 38);
            this.btnJos.TabIndex = 83;
            this.btnJos.Text = "jos";
            this.btnJos.UseVisualStyleBackColor = false;
            this.btnJos.Click += new System.EventHandler(this.btnJos_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(393, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(179, 20);
            this.label5.TabIndex = 82;
            this.label5.Text = "Modifica ordine capitole:";
            // 
            // btnSus
            // 
            this.btnSus.BackColor = System.Drawing.Color.BurlyWood;
            this.btnSus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSus.Location = new System.Drawing.Point(397, 105);
            this.btnSus.Name = "btnSus";
            this.btnSus.Size = new System.Drawing.Size(281, 38);
            this.btnSus.TabIndex = 81;
            this.btnSus.Text = "sus";
            this.btnSus.UseVisualStyleBackColor = false;
            this.btnSus.Click += new System.EventHandler(this.btnSus_Click);
            // 
            // lstIdc
            // 
            this.lstIdc.FormattingEnabled = true;
            this.lstIdc.Location = new System.Drawing.Point(434, 275);
            this.lstIdc.Name = "lstIdc";
            this.lstIdc.Size = new System.Drawing.Size(120, 17);
            this.lstIdc.TabIndex = 85;
            this.lstIdc.Visible = false;
            // 
            // FrmModifOrdCapitole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(728, 550);
            this.Controls.Add(this.lstIdc);
            this.Controls.Add(this.btnSalveazaModif);
            this.Controls.Add(this.btnJos);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnSus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstCapitole);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FrmModifOrdCapitole";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modifica Ordine Capitole";
            this.Load += new System.EventHandler(this.FrmModifOrdCapitole_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstCapitole;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSalveazaModif;
        private System.Windows.Forms.Button btnJos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSus;
        private System.Windows.Forms.ListBox lstIdc;
    }
}