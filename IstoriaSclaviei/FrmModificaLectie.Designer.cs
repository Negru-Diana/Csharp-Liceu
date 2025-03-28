namespace IstoriaSclaviei
{
    partial class FrmModificaLectie
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmModificaLectie));
            this.pnlCapitol = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cbCapitole = new System.Windows.Forms.ComboBox();
            this.pnlLectie = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.cbLectii = new System.Windows.Forms.ComboBox();
            this.pnlContinutLectie = new System.Windows.Forms.Panel();
            this.btnSterge = new System.Windows.Forms.Button();
            this.pnlStergeImg = new System.Windows.Forms.Panel();
            this.lstImagini = new System.Windows.Forms.ListBox();
            this.btnStergeImg = new System.Windows.Forms.Button();
            this.txtDescriere = new System.Windows.Forms.TextBox();
            this.btnSt = new System.Windows.Forms.Button();
            this.btnDr = new System.Windows.Forms.Button();
            this.pbStergeImg = new System.Windows.Forms.PictureBox();
            this.pnlAdaugaImg = new System.Windows.Forms.Panel();
            this.btnSalveazaImg = new System.Windows.Forms.Button();
            this.txtDescriereImg = new System.Windows.Forms.TextBox();
            this.btnDelImg = new System.Windows.Forms.Button();
            this.btnAddImg = new System.Windows.Forms.Button();
            this.pbImgLectie = new System.Windows.Forms.PictureBox();
            this.btnAdauga = new System.Windows.Forms.Button();
            this.lblCaleImg = new System.Windows.Forms.Label();
            this.btnSalveaza = new System.Windows.Forms.Button();
            this.rtbContinutLectie = new System.Windows.Forms.RichTextBox();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.pnlCapitol.SuspendLayout();
            this.pnlLectie.SuspendLayout();
            this.pnlContinutLectie.SuspendLayout();
            this.pnlStergeImg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbStergeImg)).BeginInit();
            this.pnlAdaugaImg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImgLectie)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlCapitol
            // 
            this.pnlCapitol.BackColor = System.Drawing.Color.Transparent;
            this.pnlCapitol.Controls.Add(this.label1);
            this.pnlCapitol.Controls.Add(this.cbCapitole);
            this.pnlCapitol.Location = new System.Drawing.Point(59, 12);
            this.pnlCapitol.Name = "pnlCapitol";
            this.pnlCapitol.Size = new System.Drawing.Size(454, 86);
            this.pnlCapitol.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(31, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 25);
            this.label1.TabIndex = 20;
            this.label1.Text = "Capitol:";
            // 
            // cbCapitole
            // 
            this.cbCapitole.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbCapitole.FormattingEnabled = true;
            this.cbCapitole.Location = new System.Drawing.Point(36, 46);
            this.cbCapitole.Name = "cbCapitole";
            this.cbCapitole.Size = new System.Drawing.Size(348, 33);
            this.cbCapitole.TabIndex = 0;
            this.cbCapitole.SelectedIndexChanged += new System.EventHandler(this.cbCapitole_SelectedIndexChanged);
            // 
            // pnlLectie
            // 
            this.pnlLectie.BackColor = System.Drawing.Color.Transparent;
            this.pnlLectie.Controls.Add(this.label2);
            this.pnlLectie.Controls.Add(this.cbLectii);
            this.pnlLectie.Location = new System.Drawing.Point(662, 12);
            this.pnlLectie.Name = "pnlLectie";
            this.pnlLectie.Size = new System.Drawing.Size(486, 86);
            this.pnlLectie.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(17, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 25);
            this.label2.TabIndex = 23;
            this.label2.Text = "Lectie:";
            // 
            // cbLectii
            // 
            this.cbLectii.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbLectii.FormattingEnabled = true;
            this.cbLectii.Location = new System.Drawing.Point(22, 46);
            this.cbLectii.Name = "cbLectii";
            this.cbLectii.Size = new System.Drawing.Size(348, 33);
            this.cbLectii.TabIndex = 22;
            this.cbLectii.SelectedIndexChanged += new System.EventHandler(this.cbLectii_SelectedIndexChanged);
            // 
            // pnlContinutLectie
            // 
            this.pnlContinutLectie.BackColor = System.Drawing.Color.Transparent;
            this.pnlContinutLectie.Controls.Add(this.btnSterge);
            this.pnlContinutLectie.Controls.Add(this.pnlStergeImg);
            this.pnlContinutLectie.Controls.Add(this.pnlAdaugaImg);
            this.pnlContinutLectie.Controls.Add(this.btnAdauga);
            this.pnlContinutLectie.Controls.Add(this.lblCaleImg);
            this.pnlContinutLectie.Controls.Add(this.btnSalveaza);
            this.pnlContinutLectie.Controls.Add(this.rtbContinutLectie);
            this.pnlContinutLectie.Location = new System.Drawing.Point(30, 104);
            this.pnlContinutLectie.Name = "pnlContinutLectie";
            this.pnlContinutLectie.Size = new System.Drawing.Size(1118, 628);
            this.pnlContinutLectie.TabIndex = 28;
            // 
            // btnSterge
            // 
            this.btnSterge.BackColor = System.Drawing.Color.BurlyWood;
            this.btnSterge.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSterge.Location = new System.Drawing.Point(832, 35);
            this.btnSterge.Name = "btnSterge";
            this.btnSterge.Size = new System.Drawing.Size(269, 33);
            this.btnSterge.TabIndex = 33;
            this.btnSterge.Text = "Sterge imagine";
            this.btnSterge.UseVisualStyleBackColor = false;
            this.btnSterge.Click += new System.EventHandler(this.btnSterge_Click);
            // 
            // pnlStergeImg
            // 
            this.pnlStergeImg.Controls.Add(this.lstImagini);
            this.pnlStergeImg.Controls.Add(this.btnStergeImg);
            this.pnlStergeImg.Controls.Add(this.txtDescriere);
            this.pnlStergeImg.Controls.Add(this.btnSt);
            this.pnlStergeImg.Controls.Add(this.btnDr);
            this.pnlStergeImg.Controls.Add(this.pbStergeImg);
            this.pnlStergeImg.Location = new System.Drawing.Point(563, 74);
            this.pnlStergeImg.Name = "pnlStergeImg";
            this.pnlStergeImg.Size = new System.Drawing.Size(488, 543);
            this.pnlStergeImg.TabIndex = 32;
            // 
            // lstImagini
            // 
            this.lstImagini.FormattingEnabled = true;
            this.lstImagini.Location = new System.Drawing.Point(410, 171);
            this.lstImagini.Name = "lstImagini";
            this.lstImagini.Size = new System.Drawing.Size(66, 17);
            this.lstImagini.TabIndex = 29;
            this.lstImagini.Visible = false;
            // 
            // btnStergeImg
            // 
            this.btnStergeImg.BackColor = System.Drawing.Color.BurlyWood;
            this.btnStergeImg.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnStergeImg.Location = new System.Drawing.Point(19, 490);
            this.btnStergeImg.Name = "btnStergeImg";
            this.btnStergeImg.Size = new System.Drawing.Size(370, 33);
            this.btnStergeImg.TabIndex = 28;
            this.btnStergeImg.Text = "Sterge";
            this.btnStergeImg.UseVisualStyleBackColor = false;
            this.btnStergeImg.Click += new System.EventHandler(this.btnStergeImg_Click);
            // 
            // txtDescriere
            // 
            this.txtDescriere.Enabled = false;
            this.txtDescriere.Location = new System.Drawing.Point(19, 464);
            this.txtDescriere.Name = "txtDescriere";
            this.txtDescriere.Size = new System.Drawing.Size(370, 20);
            this.txtDescriere.TabIndex = 27;
            this.txtDescriere.Text = "Descriere imagine";
            // 
            // btnSt
            // 
            this.btnSt.BackColor = System.Drawing.Color.BurlyWood;
            this.btnSt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSt.BackgroundImage")));
            this.btnSt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSt.Location = new System.Drawing.Point(19, 16);
            this.btnSt.Name = "btnSt";
            this.btnSt.Size = new System.Drawing.Size(44, 33);
            this.btnSt.TabIndex = 24;
            this.btnSt.UseVisualStyleBackColor = false;
            this.btnSt.Click += new System.EventHandler(this.btnSt_Click);
            // 
            // btnDr
            // 
            this.btnDr.BackColor = System.Drawing.Color.BurlyWood;
            this.btnDr.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDr.BackgroundImage")));
            this.btnDr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDr.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDr.Location = new System.Drawing.Point(345, 16);
            this.btnDr.Name = "btnDr";
            this.btnDr.Size = new System.Drawing.Size(44, 33);
            this.btnDr.TabIndex = 22;
            this.btnDr.UseVisualStyleBackColor = false;
            this.btnDr.Click += new System.EventHandler(this.btnDr_Click);
            // 
            // pbStergeImg
            // 
            this.pbStergeImg.Location = new System.Drawing.Point(19, 16);
            this.pbStergeImg.Name = "pbStergeImg";
            this.pbStergeImg.Size = new System.Drawing.Size(370, 442);
            this.pbStergeImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbStergeImg.TabIndex = 23;
            this.pbStergeImg.TabStop = false;
            // 
            // pnlAdaugaImg
            // 
            this.pnlAdaugaImg.Controls.Add(this.btnSalveazaImg);
            this.pnlAdaugaImg.Controls.Add(this.txtDescriereImg);
            this.pnlAdaugaImg.Controls.Add(this.btnDelImg);
            this.pnlAdaugaImg.Controls.Add(this.btnAddImg);
            this.pnlAdaugaImg.Controls.Add(this.pbImgLectie);
            this.pnlAdaugaImg.Location = new System.Drawing.Point(534, 58);
            this.pnlAdaugaImg.Name = "pnlAdaugaImg";
            this.pnlAdaugaImg.Size = new System.Drawing.Size(17, 10);
            this.pnlAdaugaImg.TabIndex = 31;
            // 
            // btnSalveazaImg
            // 
            this.btnSalveazaImg.BackColor = System.Drawing.Color.BurlyWood;
            this.btnSalveazaImg.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSalveazaImg.Location = new System.Drawing.Point(19, 510);
            this.btnSalveazaImg.Name = "btnSalveazaImg";
            this.btnSalveazaImg.Size = new System.Drawing.Size(370, 33);
            this.btnSalveazaImg.TabIndex = 28;
            this.btnSalveazaImg.Text = "Salveaza";
            this.btnSalveazaImg.UseVisualStyleBackColor = false;
            this.btnSalveazaImg.Click += new System.EventHandler(this.btnSalveazaImg_Click);
            // 
            // txtDescriereImg
            // 
            this.txtDescriereImg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescriereImg.Location = new System.Drawing.Point(19, 482);
            this.txtDescriereImg.Name = "txtDescriereImg";
            this.txtDescriereImg.Size = new System.Drawing.Size(370, 22);
            this.txtDescriereImg.TabIndex = 27;
            this.txtDescriereImg.Text = "Descriere imagine";
            // 
            // btnDelImg
            // 
            this.btnDelImg.BackColor = System.Drawing.Color.BurlyWood;
            this.btnDelImg.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDelImg.Location = new System.Drawing.Point(19, 16);
            this.btnDelImg.Name = "btnDelImg";
            this.btnDelImg.Size = new System.Drawing.Size(44, 33);
            this.btnDelImg.TabIndex = 24;
            this.btnDelImg.Text = "-";
            this.btnDelImg.UseVisualStyleBackColor = false;
            this.btnDelImg.Click += new System.EventHandler(this.btnDelImg_Click);
            // 
            // btnAddImg
            // 
            this.btnAddImg.BackColor = System.Drawing.Color.BurlyWood;
            this.btnAddImg.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAddImg.Location = new System.Drawing.Point(345, 16);
            this.btnAddImg.Name = "btnAddImg";
            this.btnAddImg.Size = new System.Drawing.Size(44, 33);
            this.btnAddImg.TabIndex = 22;
            this.btnAddImg.Text = "+";
            this.btnAddImg.UseVisualStyleBackColor = false;
            this.btnAddImg.Click += new System.EventHandler(this.btnAddImg_Click);
            // 
            // pbImgLectie
            // 
            this.pbImgLectie.Location = new System.Drawing.Point(19, 16);
            this.pbImgLectie.Name = "pbImgLectie";
            this.pbImgLectie.Size = new System.Drawing.Size(370, 460);
            this.pbImgLectie.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImgLectie.TabIndex = 23;
            this.pbImgLectie.TabStop = false;
            // 
            // btnAdauga
            // 
            this.btnAdauga.BackColor = System.Drawing.Color.BurlyWood;
            this.btnAdauga.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAdauga.Location = new System.Drawing.Point(557, 35);
            this.btnAdauga.Name = "btnAdauga";
            this.btnAdauga.Size = new System.Drawing.Size(269, 33);
            this.btnAdauga.TabIndex = 30;
            this.btnAdauga.Text = "Adauga imagine";
            this.btnAdauga.UseVisualStyleBackColor = false;
            this.btnAdauga.Click += new System.EventHandler(this.btnAdauga_Click);
            // 
            // lblCaleImg
            // 
            this.lblCaleImg.AutoSize = true;
            this.lblCaleImg.Location = new System.Drawing.Point(456, 19);
            this.lblCaleImg.Name = "lblCaleImg";
            this.lblCaleImg.Size = new System.Drawing.Size(45, 13);
            this.lblCaleImg.TabIndex = 25;
            this.lblCaleImg.Text = "CaleImg";
            this.lblCaleImg.Visible = false;
            // 
            // btnSalveaza
            // 
            this.btnSalveaza.BackColor = System.Drawing.Color.BurlyWood;
            this.btnSalveaza.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSalveaza.Location = new System.Drawing.Point(384, 584);
            this.btnSalveaza.Name = "btnSalveaza";
            this.btnSalveaza.Size = new System.Drawing.Size(134, 33);
            this.btnSalveaza.TabIndex = 22;
            this.btnSalveaza.Text = "Salveaza";
            this.btnSalveaza.UseVisualStyleBackColor = false;
            this.btnSalveaza.Click += new System.EventHandler(this.btnSalveaza_Click);
            // 
            // rtbContinutLectie
            // 
            this.rtbContinutLectie.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbContinutLectie.Location = new System.Drawing.Point(46, 35);
            this.rtbContinutLectie.Name = "rtbContinutLectie";
            this.rtbContinutLectie.Size = new System.Drawing.Size(472, 543);
            this.rtbContinutLectie.TabIndex = 0;
            this.rtbContinutLectie.Text = "";
            // 
            // ofd
            // 
            this.ofd.FileName = "openFileDialog1";
            // 
            // FrmModificaLectie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1160, 744);
            this.Controls.Add(this.pnlContinutLectie);
            this.Controls.Add(this.pnlLectie);
            this.Controls.Add(this.pnlCapitol);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FrmModificaLectie";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ModificaLectie";
            this.Load += new System.EventHandler(this.FrmModificaLectie_Load);
            this.pnlCapitol.ResumeLayout(false);
            this.pnlCapitol.PerformLayout();
            this.pnlLectie.ResumeLayout(false);
            this.pnlLectie.PerformLayout();
            this.pnlContinutLectie.ResumeLayout(false);
            this.pnlContinutLectie.PerformLayout();
            this.pnlStergeImg.ResumeLayout(false);
            this.pnlStergeImg.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbStergeImg)).EndInit();
            this.pnlAdaugaImg.ResumeLayout(false);
            this.pnlAdaugaImg.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImgLectie)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCapitol;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbCapitole;
        private System.Windows.Forms.Panel pnlLectie;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbLectii;
        private System.Windows.Forms.Panel pnlContinutLectie;
        private System.Windows.Forms.Button btnSalveazaImg;
        private System.Windows.Forms.TextBox txtDescriereImg;
        private System.Windows.Forms.Label lblCaleImg;
        private System.Windows.Forms.Button btnDelImg;
        private System.Windows.Forms.Button btnAddImg;
        private System.Windows.Forms.PictureBox pbImgLectie;
        private System.Windows.Forms.Button btnSalveaza;
        private System.Windows.Forms.RichTextBox rtbContinutLectie;
        private System.Windows.Forms.OpenFileDialog ofd;
        private System.Windows.Forms.Button btnAdauga;
        private System.Windows.Forms.Panel pnlStergeImg;
        private System.Windows.Forms.Button btnStergeImg;
        private System.Windows.Forms.TextBox txtDescriere;
        private System.Windows.Forms.Button btnSt;
        private System.Windows.Forms.Button btnDr;
        private System.Windows.Forms.PictureBox pbStergeImg;
        private System.Windows.Forms.Panel pnlAdaugaImg;
        private System.Windows.Forms.Button btnSterge;
        private System.Windows.Forms.ListBox lstImagini;
    }
}