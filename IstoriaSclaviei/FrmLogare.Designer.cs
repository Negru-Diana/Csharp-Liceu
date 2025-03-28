namespace IstoriaSclaviei
{
    partial class FrmLogare
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogare));
            this.label1 = new System.Windows.Forms.Label();
            this.txtNume = new System.Windows.Forms.TextBox();
            this.cbParola = new System.Windows.Forms.CheckBox();
            this.txtParola = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCreeazaCont = new System.Windows.Forms.Button();
            this.btnLogare = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(116, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nume/Email:";
            // 
            // txtNume
            // 
            this.txtNume.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtNume.Location = new System.Drawing.Point(121, 116);
            this.txtNume.Name = "txtNume";
            this.txtNume.Size = new System.Drawing.Size(505, 31);
            this.txtNume.TabIndex = 3;
            // 
            // cbParola
            // 
            this.cbParola.AutoSize = true;
            this.cbParola.BackColor = System.Drawing.Color.Transparent;
            this.cbParola.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbParola.Location = new System.Drawing.Point(121, 267);
            this.cbParola.Name = "cbParola";
            this.cbParola.Size = new System.Drawing.Size(94, 20);
            this.cbParola.TabIndex = 10;
            this.cbParola.Text = "Vezi parola";
            this.cbParola.UseVisualStyleBackColor = false;
            this.cbParola.CheckedChanged += new System.EventHandler(this.cbParola_CheckedChanged);
            // 
            // txtParola
            // 
            this.txtParola.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtParola.Location = new System.Drawing.Point(121, 230);
            this.txtParola.Name = "txtParola";
            this.txtParola.Size = new System.Drawing.Size(505, 31);
            this.txtParola.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(116, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Parola:";
            // 
            // btnCreeazaCont
            // 
            this.btnCreeazaCont.BackColor = System.Drawing.Color.BurlyWood;
            this.btnCreeazaCont.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnCreeazaCont.Location = new System.Drawing.Point(121, 396);
            this.btnCreeazaCont.Name = "btnCreeazaCont";
            this.btnCreeazaCont.Size = new System.Drawing.Size(194, 33);
            this.btnCreeazaCont.TabIndex = 12;
            this.btnCreeazaCont.Text = "Creeaza cont";
            this.btnCreeazaCont.UseVisualStyleBackColor = false;
            this.btnCreeazaCont.Click += new System.EventHandler(this.btnCreeazaCont_Click);
            // 
            // btnLogare
            // 
            this.btnLogare.BackColor = System.Drawing.Color.BurlyWood;
            this.btnLogare.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnLogare.Location = new System.Drawing.Point(432, 396);
            this.btnLogare.Name = "btnLogare";
            this.btnLogare.Size = new System.Drawing.Size(194, 33);
            this.btnLogare.TabIndex = 11;
            this.btnLogare.Text = "Intra in cont";
            this.btnLogare.UseVisualStyleBackColor = false;
            this.btnLogare.Click += new System.EventHandler(this.btnLogare_Click);
            // 
            // FrmLogare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(777, 494);
            this.Controls.Add(this.btnCreeazaCont);
            this.Controls.Add(this.btnLogare);
            this.Controls.Add(this.cbParola);
            this.Controls.Add(this.txtParola);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNume);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FrmLogare";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Logare";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmLogare_FormClosed);
            this.Load += new System.EventHandler(this.FrmLogare_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNume;
        private System.Windows.Forms.CheckBox cbParola;
        private System.Windows.Forms.TextBox txtParola;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCreeazaCont;
        private System.Windows.Forms.Button btnLogare;
    }
}

