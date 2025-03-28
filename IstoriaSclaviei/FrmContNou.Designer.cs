namespace IstoriaSclaviei
{
    partial class FrmContNou
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmContNou));
            this.cbCont = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtConfParola = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCreeazaCont = new System.Windows.Forms.Button();
            this.txtParola = new System.Windows.Forms.TextBox();
            this.txtNume = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbParola = new System.Windows.Forms.CheckBox();
            this.cbConfParola = new System.Windows.Forms.CheckBox();
            this.btnRenunta = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbCont
            // 
            this.cbCont.BackColor = System.Drawing.Color.White;
            this.cbCont.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCont.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbCont.FormattingEnabled = true;
            this.cbCont.Items.AddRange(new object[] {
            "elev",
            "profesor"});
            this.cbCont.Location = new System.Drawing.Point(241, 409);
            this.cbCont.Name = "cbCont";
            this.cbCont.Size = new System.Drawing.Size(196, 33);
            this.cbCont.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(107, 412);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 25);
            this.label4.TabIndex = 27;
            this.label4.Text = "Conturi de:";
            // 
            // txtConfParola
            // 
            this.txtConfParola.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtConfParola.Location = new System.Drawing.Point(111, 326);
            this.txtConfParola.Name = "txtConfParola";
            this.txtConfParola.Size = new System.Drawing.Size(574, 31);
            this.txtConfParola.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(106, 298);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(207, 25);
            this.label3.TabIndex = 25;
            this.label3.Text = "Confirmare parola:";
            // 
            // btnCreeazaCont
            // 
            this.btnCreeazaCont.BackColor = System.Drawing.Color.BurlyWood;
            this.btnCreeazaCont.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnCreeazaCont.Location = new System.Drawing.Point(491, 530);
            this.btnCreeazaCont.Name = "btnCreeazaCont";
            this.btnCreeazaCont.Size = new System.Drawing.Size(194, 33);
            this.btnCreeazaCont.TabIndex = 24;
            this.btnCreeazaCont.Text = "Creeaza cont";
            this.btnCreeazaCont.UseVisualStyleBackColor = false;
            this.btnCreeazaCont.Click += new System.EventHandler(this.btnCreeazaCont_Click);
            // 
            // txtParola
            // 
            this.txtParola.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtParola.Location = new System.Drawing.Point(111, 231);
            this.txtParola.Name = "txtParola";
            this.txtParola.Size = new System.Drawing.Size(574, 31);
            this.txtParola.TabIndex = 22;
            // 
            // txtNume
            // 
            this.txtNume.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtNume.Location = new System.Drawing.Point(111, 74);
            this.txtNume.Name = "txtNume";
            this.txtNume.Size = new System.Drawing.Size(574, 31);
            this.txtNume.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(106, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 25);
            this.label2.TabIndex = 20;
            this.label2.Text = "Parola:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(106, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 25);
            this.label1.TabIndex = 19;
            this.label1.Text = "Nume:";
            // 
            // cbParola
            // 
            this.cbParola.AutoSize = true;
            this.cbParola.BackColor = System.Drawing.Color.Transparent;
            this.cbParola.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbParola.Location = new System.Drawing.Point(591, 268);
            this.cbParola.Name = "cbParola";
            this.cbParola.Size = new System.Drawing.Size(94, 20);
            this.cbParola.TabIndex = 29;
            this.cbParola.Text = "Vezi parola";
            this.cbParola.UseVisualStyleBackColor = false;
            this.cbParola.CheckedChanged += new System.EventHandler(this.cbParola_CheckedChanged);
            // 
            // cbConfParola
            // 
            this.cbConfParola.AutoSize = true;
            this.cbConfParola.BackColor = System.Drawing.Color.Transparent;
            this.cbConfParola.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbConfParola.Location = new System.Drawing.Point(591, 363);
            this.cbConfParola.Name = "cbConfParola";
            this.cbConfParola.Size = new System.Drawing.Size(94, 20);
            this.cbConfParola.TabIndex = 30;
            this.cbConfParola.Text = "Vezi parola";
            this.cbConfParola.UseVisualStyleBackColor = false;
            this.cbConfParola.CheckedChanged += new System.EventHandler(this.cbConfParola_CheckedChanged);
            // 
            // btnRenunta
            // 
            this.btnRenunta.BackColor = System.Drawing.Color.BurlyWood;
            this.btnRenunta.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnRenunta.Location = new System.Drawing.Point(111, 530);
            this.btnRenunta.Name = "btnRenunta";
            this.btnRenunta.Size = new System.Drawing.Size(194, 33);
            this.btnRenunta.TabIndex = 31;
            this.btnRenunta.Text = "Renunta";
            this.btnRenunta.UseVisualStyleBackColor = false;
            this.btnRenunta.Click += new System.EventHandler(this.btnRenunta_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtEmail.Location = new System.Drawing.Point(111, 154);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(574, 31);
            this.txtEmail.TabIndex = 33;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(106, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 25);
            this.label5.TabIndex = 32;
            this.label5.Text = "Email:";
            // 
            // FrmContNou
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(861, 586);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnRenunta);
            this.Controls.Add(this.cbConfParola);
            this.Controls.Add(this.cbParola);
            this.Controls.Add(this.cbCont);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtConfParola);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCreeazaCont);
            this.Controls.Add(this.txtParola);
            this.Controls.Add(this.txtNume);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FrmContNou";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ContNou";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmContNou_FormClosed);
            this.Load += new System.EventHandler(this.FrmContNou_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtConfParola;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCreeazaCont;
        private System.Windows.Forms.TextBox txtParola;
        private System.Windows.Forms.TextBox txtNume;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbParola;
        private System.Windows.Forms.CheckBox cbConfParola;
        private System.Windows.Forms.Button btnRenunta;
        private System.Windows.Forms.ComboBox cbCont;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label5;
    }
}