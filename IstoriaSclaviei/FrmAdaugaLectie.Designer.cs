namespace IstoriaSclaviei
{
    partial class FrmAdaugaLectie
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdaugaLectie));
            this.cbCapitole = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdaugaCapitol = new System.Windows.Forms.Button();
            this.btnAdaugaLectie = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cbLectii = new System.Windows.Forms.ComboBox();
            this.pnlCapitol = new System.Windows.Forms.Panel();
            this.pnlLectie = new System.Windows.Forms.Panel();
            this.pnlContinutLectie = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSalveazaImg = new System.Windows.Forms.Button();
            this.txtDescriereImg = new System.Windows.Forms.TextBox();
            this.lblCaleImg = new System.Windows.Forms.Label();
            this.btnDelImg = new System.Windows.Forms.Button();
            this.btnAddImg = new System.Windows.Forms.Button();
            this.pbImgLectie = new System.Windows.Forms.PictureBox();
            this.btnSalveaza = new System.Windows.Forms.Button();
            this.rtbContinutLectie = new System.Windows.Forms.RichTextBox();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.pnlCapitol.SuspendLayout();
            this.pnlLectie.SuspendLayout();
            this.pnlContinutLectie.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImgLectie)).BeginInit();
            this.SuspendLayout();
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
            // btnAdaugaCapitol
            // 
            this.btnAdaugaCapitol.BackColor = System.Drawing.Color.BurlyWood;
            this.btnAdaugaCapitol.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAdaugaCapitol.Location = new System.Drawing.Point(390, 46);
            this.btnAdaugaCapitol.Name = "btnAdaugaCapitol";
            this.btnAdaugaCapitol.Size = new System.Drawing.Size(44, 33);
            this.btnAdaugaCapitol.TabIndex = 21;
            this.btnAdaugaCapitol.Text = "+";
            this.btnAdaugaCapitol.UseVisualStyleBackColor = false;
            this.btnAdaugaCapitol.Click += new System.EventHandler(this.btnAdaugaCapitol_Click);
            // 
            // btnAdaugaLectie
            // 
            this.btnAdaugaLectie.BackColor = System.Drawing.Color.BurlyWood;
            this.btnAdaugaLectie.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAdaugaLectie.Location = new System.Drawing.Point(376, 53);
            this.btnAdaugaLectie.Name = "btnAdaugaLectie";
            this.btnAdaugaLectie.Size = new System.Drawing.Size(44, 33);
            this.btnAdaugaLectie.TabIndex = 24;
            this.btnAdaugaLectie.Text = "+";
            this.btnAdaugaLectie.UseVisualStyleBackColor = false;
            this.btnAdaugaLectie.Click += new System.EventHandler(this.btnAdaugaLectie_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(17, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 25);
            this.label2.TabIndex = 23;
            this.label2.Text = "Lectie:";
            // 
            // cbLectii
            // 
            this.cbLectii.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbLectii.FormattingEnabled = true;
            this.cbLectii.Location = new System.Drawing.Point(22, 53);
            this.cbLectii.Name = "cbLectii";
            this.cbLectii.Size = new System.Drawing.Size(348, 33);
            this.cbLectii.TabIndex = 22;
            this.cbLectii.SelectedIndexChanged += new System.EventHandler(this.cbLectii_SelectedIndexChanged);
            // 
            // pnlCapitol
            // 
            this.pnlCapitol.BackColor = System.Drawing.Color.Transparent;
            this.pnlCapitol.Controls.Add(this.btnAdaugaCapitol);
            this.pnlCapitol.Controls.Add(this.label1);
            this.pnlCapitol.Controls.Add(this.cbCapitole);
            this.pnlCapitol.Location = new System.Drawing.Point(59, 12);
            this.pnlCapitol.Name = "pnlCapitol";
            this.pnlCapitol.Size = new System.Drawing.Size(454, 119);
            this.pnlCapitol.TabIndex = 25;
            // 
            // pnlLectie
            // 
            this.pnlLectie.BackColor = System.Drawing.Color.Transparent;
            this.pnlLectie.Controls.Add(this.btnAdaugaLectie);
            this.pnlLectie.Controls.Add(this.label2);
            this.pnlLectie.Controls.Add(this.cbLectii);
            this.pnlLectie.Location = new System.Drawing.Point(662, 12);
            this.pnlLectie.Name = "pnlLectie";
            this.pnlLectie.Size = new System.Drawing.Size(486, 119);
            this.pnlLectie.TabIndex = 26;
            // 
            // pnlContinutLectie
            // 
            this.pnlContinutLectie.BackColor = System.Drawing.Color.Transparent;
            this.pnlContinutLectie.Controls.Add(this.label4);
            this.pnlContinutLectie.Controls.Add(this.btnSalveazaImg);
            this.pnlContinutLectie.Controls.Add(this.txtDescriereImg);
            this.pnlContinutLectie.Controls.Add(this.lblCaleImg);
            this.pnlContinutLectie.Controls.Add(this.btnDelImg);
            this.pnlContinutLectie.Controls.Add(this.btnAddImg);
            this.pnlContinutLectie.Controls.Add(this.pbImgLectie);
            this.pnlContinutLectie.Controls.Add(this.btnSalveaza);
            this.pnlContinutLectie.Controls.Add(this.rtbContinutLectie);
            this.pnlContinutLectie.Location = new System.Drawing.Point(30, 137);
            this.pnlContinutLectie.Name = "pnlContinutLectie";
            this.pnlContinutLectie.Size = new System.Drawing.Size(1118, 595);
            this.pnlContinutLectie.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(629, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(373, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Imaginile se vor putea adauga dupa salvarea lectiei, cu o descriere sugestiva.";
            // 
            // btnSalveazaImg
            // 
            this.btnSalveazaImg.BackColor = System.Drawing.Color.BurlyWood;
            this.btnSalveazaImg.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSalveazaImg.Location = new System.Drawing.Point(632, 509);
            this.btnSalveazaImg.Name = "btnSalveazaImg";
            this.btnSalveazaImg.Size = new System.Drawing.Size(370, 33);
            this.btnSalveazaImg.TabIndex = 28;
            this.btnSalveazaImg.Text = "Salveaza imagine";
            this.btnSalveazaImg.UseVisualStyleBackColor = false;
            this.btnSalveazaImg.Click += new System.EventHandler(this.btnSalveazaImg_Click);
            // 
            // txtDescriereImg
            // 
            this.txtDescriereImg.Location = new System.Drawing.Point(632, 483);
            this.txtDescriereImg.Name = "txtDescriereImg";
            this.txtDescriereImg.Size = new System.Drawing.Size(370, 20);
            this.txtDescriereImg.TabIndex = 27;
            this.txtDescriereImg.Text = "Descriere imagine";
            // 
            // lblCaleImg
            // 
            this.lblCaleImg.AutoSize = true;
            this.lblCaleImg.Location = new System.Drawing.Point(1035, 48);
            this.lblCaleImg.Name = "lblCaleImg";
            this.lblCaleImg.Size = new System.Drawing.Size(45, 13);
            this.lblCaleImg.TabIndex = 25;
            this.lblCaleImg.Text = "CaleImg";
            this.lblCaleImg.Visible = false;
            // 
            // btnDelImg
            // 
            this.btnDelImg.BackColor = System.Drawing.Color.BurlyWood;
            this.btnDelImg.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDelImg.Location = new System.Drawing.Point(632, 35);
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
            this.btnAddImg.Location = new System.Drawing.Point(958, 35);
            this.btnAddImg.Name = "btnAddImg";
            this.btnAddImg.Size = new System.Drawing.Size(44, 33);
            this.btnAddImg.TabIndex = 22;
            this.btnAddImg.Text = "+";
            this.btnAddImg.UseVisualStyleBackColor = false;
            this.btnAddImg.Click += new System.EventHandler(this.btnAddImg_Click);
            // 
            // pbImgLectie
            // 
            this.pbImgLectie.Location = new System.Drawing.Point(632, 35);
            this.pbImgLectie.Name = "pbImgLectie";
            this.pbImgLectie.Size = new System.Drawing.Size(370, 442);
            this.pbImgLectie.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImgLectie.TabIndex = 23;
            this.pbImgLectie.TabStop = false;
            // 
            // btnSalveaza
            // 
            this.btnSalveaza.BackColor = System.Drawing.Color.BurlyWood;
            this.btnSalveaza.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSalveaza.Location = new System.Drawing.Point(367, 559);
            this.btnSalveaza.Name = "btnSalveaza";
            this.btnSalveaza.Size = new System.Drawing.Size(134, 33);
            this.btnSalveaza.TabIndex = 22;
            this.btnSalveaza.Text = "Salveaza";
            this.btnSalveaza.UseVisualStyleBackColor = false;
            this.btnSalveaza.Click += new System.EventHandler(this.btnSalveaza_Click);
            // 
            // rtbContinutLectie
            // 
            this.rtbContinutLectie.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbContinutLectie.Location = new System.Drawing.Point(29, 35);
            this.rtbContinutLectie.Name = "rtbContinutLectie";
            this.rtbContinutLectie.Size = new System.Drawing.Size(472, 518);
            this.rtbContinutLectie.TabIndex = 0;
            this.rtbContinutLectie.Text = "";
            // 
            // ofd
            // 
            this.ofd.FileName = "openFileDialog1";
            // 
            // FrmAdaugaLectie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1160, 744);
            this.Controls.Add(this.pnlContinutLectie);
            this.Controls.Add(this.pnlLectie);
            this.Controls.Add(this.pnlCapitol);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FrmAdaugaLectie";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdaugaLectie";
            this.Load += new System.EventHandler(this.FrmAdaugaLectie_Load);
            this.pnlCapitol.ResumeLayout(false);
            this.pnlCapitol.PerformLayout();
            this.pnlLectie.ResumeLayout(false);
            this.pnlLectie.PerformLayout();
            this.pnlContinutLectie.ResumeLayout(false);
            this.pnlContinutLectie.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImgLectie)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbCapitole;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdaugaCapitol;
        private System.Windows.Forms.Button btnAdaugaLectie;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbLectii;
        private System.Windows.Forms.Panel pnlCapitol;
        private System.Windows.Forms.Panel pnlLectie;
        private System.Windows.Forms.Panel pnlContinutLectie;
        private System.Windows.Forms.Button btnDelImg;
        private System.Windows.Forms.Button btnAddImg;
        private System.Windows.Forms.PictureBox pbImgLectie;
        private System.Windows.Forms.Button btnSalveaza;
        private System.Windows.Forms.RichTextBox rtbContinutLectie;
        private System.Windows.Forms.Label lblCaleImg;
        private System.Windows.Forms.TextBox txtDescriereImg;
        private System.Windows.Forms.OpenFileDialog ofd;
        private System.Windows.Forms.Button btnSalveazaImg;
        private System.Windows.Forms.Label label4;
    }
}