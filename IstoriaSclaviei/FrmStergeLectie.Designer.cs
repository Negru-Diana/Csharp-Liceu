namespace IstoriaSclaviei
{
    partial class FrmStergeLectie
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmStergeLectie));
            this.pnlCapitol = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cbCapitole = new System.Windows.Forms.ComboBox();
            this.pnlLectie = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.cbLectii = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlContinut = new System.Windows.Forms.Panel();
            this.btnStergeLectie = new System.Windows.Forms.Button();
            this.lstImg = new System.Windows.Forms.ListBox();
            this.rtbLectie = new System.Windows.Forms.RichTextBox();
            this.pnlCapitol.SuspendLayout();
            this.pnlLectie.SuspendLayout();
            this.pnlContinut.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCapitol
            // 
            this.pnlCapitol.BackColor = System.Drawing.Color.Transparent;
            this.pnlCapitol.Controls.Add(this.label1);
            this.pnlCapitol.Controls.Add(this.cbCapitole);
            this.pnlCapitol.Location = new System.Drawing.Point(45, 47);
            this.pnlCapitol.Name = "pnlCapitol";
            this.pnlCapitol.Size = new System.Drawing.Size(454, 119);
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
            this.pnlLectie.Location = new System.Drawing.Point(611, 47);
            this.pnlLectie.Name = "pnlLectie";
            this.pnlLectie.Size = new System.Drawing.Size(425, 119);
            this.pnlLectie.TabIndex = 27;
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(77, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(445, 24);
            this.label3.TabIndex = 28;
            this.label3.Text = "Alege capitolul din care doresti sa stergi lectia:";
            // 
            // pnlContinut
            // 
            this.pnlContinut.BackColor = System.Drawing.Color.Transparent;
            this.pnlContinut.Controls.Add(this.btnStergeLectie);
            this.pnlContinut.Controls.Add(this.lstImg);
            this.pnlContinut.Controls.Add(this.rtbLectie);
            this.pnlContinut.Location = new System.Drawing.Point(47, 177);
            this.pnlContinut.Name = "pnlContinut";
            this.pnlContinut.Size = new System.Drawing.Size(989, 615);
            this.pnlContinut.TabIndex = 29;
            // 
            // btnStergeLectie
            // 
            this.btnStergeLectie.BackColor = System.Drawing.Color.BurlyWood;
            this.btnStergeLectie.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnStergeLectie.Location = new System.Drawing.Point(763, 21);
            this.btnStergeLectie.Name = "btnStergeLectie";
            this.btnStergeLectie.Size = new System.Drawing.Size(171, 46);
            this.btnStergeLectie.TabIndex = 33;
            this.btnStergeLectie.Text = "Sterge lectie";
            this.btnStergeLectie.UseVisualStyleBackColor = false;
            this.btnStergeLectie.Click += new System.EventHandler(this.btnStergeLectie_Click);
            // 
            // lstImg
            // 
            this.lstImg.FormattingEnabled = true;
            this.lstImg.Location = new System.Drawing.Point(1352, 577);
            this.lstImg.Name = "lstImg";
            this.lstImg.Size = new System.Drawing.Size(120, 17);
            this.lstImg.TabIndex = 31;
            this.lstImg.Visible = false;
            // 
            // rtbLectie
            // 
            this.rtbLectie.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbLectie.Location = new System.Drawing.Point(34, 21);
            this.rtbLectie.Name = "rtbLectie";
            this.rtbLectie.Size = new System.Drawing.Size(706, 534);
            this.rtbLectie.TabIndex = 27;
            this.rtbLectie.Text = "";
            // 
            // FrmStergeLectie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1075, 784);
            this.Controls.Add(this.pnlContinut);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pnlLectie);
            this.Controls.Add(this.pnlCapitol);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FrmStergeLectie";
            this.Text = "Sterge Lectie";
            this.Load += new System.EventHandler(this.FrmStergeLectie_Load);
            this.pnlCapitol.ResumeLayout(false);
            this.pnlCapitol.PerformLayout();
            this.pnlLectie.ResumeLayout(false);
            this.pnlLectie.PerformLayout();
            this.pnlContinut.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlCapitol;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbCapitole;
        private System.Windows.Forms.Panel pnlLectie;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbLectii;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnlContinut;
        private System.Windows.Forms.RichTextBox rtbLectie;
        private System.Windows.Forms.Button btnStergeLectie;
        private System.Windows.Forms.ListBox lstImg;
    }
}