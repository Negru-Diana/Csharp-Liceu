namespace IstoriaSclaviei
{
    partial class FrmLectii
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLectii));
            this.lblDenumire = new System.Windows.Forms.Label();
            this.rtbLectie = new System.Windows.Forms.RichTextBox();
            this.pbImgLectie = new System.Windows.Forms.PictureBox();
            this.btnStanga = new System.Windows.Forms.Button();
            this.btnDreapta = new System.Windows.Forms.Button();
            this.lstImg = new System.Windows.Forms.ListBox();
            this.lblDescriere = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbImgLectie)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDenumire
            // 
            this.lblDenumire.AutoSize = true;
            this.lblDenumire.BackColor = System.Drawing.Color.Transparent;
            this.lblDenumire.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDenumire.Location = new System.Drawing.Point(49, 9);
            this.lblDenumire.Name = "lblDenumire";
            this.lblDenumire.Size = new System.Drawing.Size(85, 29);
            this.lblDenumire.TabIndex = 0;
            this.lblDenumire.Text = "label1";
            // 
            // rtbLectie
            // 
            this.rtbLectie.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbLectie.Location = new System.Drawing.Point(54, 102);
            this.rtbLectie.Name = "rtbLectie";
            this.rtbLectie.ReadOnly = true;
            this.rtbLectie.Size = new System.Drawing.Size(829, 646);
            this.rtbLectie.TabIndex = 1;
            this.rtbLectie.Text = "";
            // 
            // pbImgLectie
            // 
            this.pbImgLectie.BackColor = System.Drawing.SystemColors.Control;
            this.pbImgLectie.Location = new System.Drawing.Point(931, 102);
            this.pbImgLectie.Name = "pbImgLectie";
            this.pbImgLectie.Size = new System.Drawing.Size(567, 607);
            this.pbImgLectie.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImgLectie.TabIndex = 24;
            this.pbImgLectie.TabStop = false;
            // 
            // btnStanga
            // 
            this.btnStanga.BackColor = System.Drawing.Color.BurlyWood;
            this.btnStanga.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnStanga.BackgroundImage")));
            this.btnStanga.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStanga.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnStanga.Location = new System.Drawing.Point(931, 715);
            this.btnStanga.Name = "btnStanga";
            this.btnStanga.Size = new System.Drawing.Size(106, 33);
            this.btnStanga.TabIndex = 25;
            this.btnStanga.UseVisualStyleBackColor = false;
            this.btnStanga.Click += new System.EventHandler(this.btnStanga_Click);
            // 
            // btnDreapta
            // 
            this.btnDreapta.BackColor = System.Drawing.Color.BurlyWood;
            this.btnDreapta.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDreapta.BackgroundImage")));
            this.btnDreapta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDreapta.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDreapta.Location = new System.Drawing.Point(1392, 715);
            this.btnDreapta.Name = "btnDreapta";
            this.btnDreapta.Size = new System.Drawing.Size(106, 33);
            this.btnDreapta.TabIndex = 26;
            this.btnDreapta.UseVisualStyleBackColor = false;
            this.btnDreapta.Click += new System.EventHandler(this.btnDreapta_Click);
            // 
            // lstImg
            // 
            this.lstImg.FormattingEnabled = true;
            this.lstImg.Location = new System.Drawing.Point(1019, 18);
            this.lstImg.Name = "lstImg";
            this.lstImg.Size = new System.Drawing.Size(120, 17);
            this.lstImg.TabIndex = 27;
            this.lstImg.Visible = false;
            // 
            // lblDescriere
            // 
            this.lblDescriere.BackColor = System.Drawing.Color.Transparent;
            this.lblDescriere.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescriere.Location = new System.Drawing.Point(931, 61);
            this.lblDescriere.Name = "lblDescriere";
            this.lblDescriere.Size = new System.Drawing.Size(567, 38);
            this.lblDescriere.TabIndex = 28;
            this.lblDescriere.Text = "label1";
            this.lblDescriere.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FrmLectii
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1549, 815);
            this.Controls.Add(this.lblDescriere);
            this.Controls.Add(this.lstImg);
            this.Controls.Add(this.btnDreapta);
            this.Controls.Add(this.btnStanga);
            this.Controls.Add(this.pbImgLectie);
            this.Controls.Add(this.rtbLectie);
            this.Controls.Add(this.lblDenumire);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FrmLectii";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmLectii";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmLectii_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbImgLectie)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDenumire;
        private System.Windows.Forms.RichTextBox rtbLectie;
        private System.Windows.Forms.PictureBox pbImgLectie;
        private System.Windows.Forms.Button btnStanga;
        private System.Windows.Forms.Button btnDreapta;
        private System.Windows.Forms.ListBox lstImg;
        private System.Windows.Forms.Label lblDescriere;
    }
}