namespace IstoriaSclaviei
{
    partial class FrmSchhimbaParola
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSchhimbaParola));
            this.cbConfParola = new System.Windows.Forms.CheckBox();
            this.cbParola = new System.Windows.Forms.CheckBox();
            this.txtConfParola = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtParola = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSchimbaParola = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbConfParola
            // 
            this.cbConfParola.AutoSize = true;
            this.cbConfParola.BackColor = System.Drawing.Color.Transparent;
            this.cbConfParola.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbConfParola.Location = new System.Drawing.Point(556, 241);
            this.cbConfParola.Name = "cbConfParola";
            this.cbConfParola.Size = new System.Drawing.Size(94, 20);
            this.cbConfParola.TabIndex = 40;
            this.cbConfParola.Text = "Vezi parola";
            this.cbConfParola.UseVisualStyleBackColor = false;
            this.cbConfParola.CheckedChanged += new System.EventHandler(this.cbConfParola_CheckedChanged);
            // 
            // cbParola
            // 
            this.cbParola.AutoSize = true;
            this.cbParola.BackColor = System.Drawing.Color.Transparent;
            this.cbParola.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbParola.Location = new System.Drawing.Point(556, 132);
            this.cbParola.Name = "cbParola";
            this.cbParola.Size = new System.Drawing.Size(94, 20);
            this.cbParola.TabIndex = 39;
            this.cbParola.Text = "Vezi parola";
            this.cbParola.UseVisualStyleBackColor = false;
            this.cbParola.CheckedChanged += new System.EventHandler(this.cbParola_CheckedChanged);
            // 
            // txtConfParola
            // 
            this.txtConfParola.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtConfParola.Location = new System.Drawing.Point(76, 204);
            this.txtConfParola.Name = "txtConfParola";
            this.txtConfParola.Size = new System.Drawing.Size(574, 31);
            this.txtConfParola.TabIndex = 38;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(71, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 25);
            this.label3.TabIndex = 37;
            this.label3.Text = "Confirmare parola:";
            // 
            // txtParola
            // 
            this.txtParola.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtParola.Location = new System.Drawing.Point(76, 95);
            this.txtParola.Name = "txtParola";
            this.txtParola.Size = new System.Drawing.Size(574, 31);
            this.txtParola.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(71, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 25);
            this.label2.TabIndex = 35;
            this.label2.Text = "Parola:";
            // 
            // btnSchimbaParola
            // 
            this.btnSchimbaParola.BackColor = System.Drawing.Color.BurlyWood;
            this.btnSchimbaParola.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSchimbaParola.Location = new System.Drawing.Point(456, 320);
            this.btnSchimbaParola.Name = "btnSchimbaParola";
            this.btnSchimbaParola.Size = new System.Drawing.Size(194, 33);
            this.btnSchimbaParola.TabIndex = 43;
            this.btnSchimbaParola.Text = "Schimba parola";
            this.btnSchimbaParola.UseVisualStyleBackColor = false;
            this.btnSchimbaParola.Click += new System.EventHandler(this.btnSchimbaParola_Click);
            // 
            // FrmSchhimbaParola
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(731, 439);
            this.Controls.Add(this.btnSchimbaParola);
            this.Controls.Add(this.cbConfParola);
            this.Controls.Add(this.cbParola);
            this.Controls.Add(this.txtConfParola);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtParola);
            this.Controls.Add(this.label2);
            this.Name = "FrmSchhimbaParola";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Schhimba Parola";
            this.Load += new System.EventHandler(this.FrmSchhimbaParola_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox cbConfParola;
        private System.Windows.Forms.CheckBox cbParola;
        private System.Windows.Forms.TextBox txtConfParola;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtParola;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSchimbaParola;
    }
}