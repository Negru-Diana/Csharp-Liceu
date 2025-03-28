namespace IstoriaSclaviei
{
    partial class FrmNotificari
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNotificari));
            this.lstNotif = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lstidNotif = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lstNotif
            // 
            this.lstNotif.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstNotif.FormattingEnabled = true;
            this.lstNotif.ItemHeight = 25;
            this.lstNotif.Location = new System.Drawing.Point(108, 59);
            this.lstNotif.Name = "lstNotif";
            this.lstNotif.Size = new System.Drawing.Size(665, 429);
            this.lstNotif.TabIndex = 0;
            this.lstNotif.SelectedIndexChanged += new System.EventHandler(this.lstNotif_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(103, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Notificari:";
            // 
            // lstidNotif
            // 
            this.lstidNotif.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstidNotif.FormattingEnabled = true;
            this.lstidNotif.ItemHeight = 25;
            this.lstidNotif.Location = new System.Drawing.Point(275, 24);
            this.lstidNotif.Name = "lstidNotif";
            this.lstidNotif.Size = new System.Drawing.Size(113, 29);
            this.lstidNotif.TabIndex = 2;
            this.lstidNotif.Visible = false;
            // 
            // FrmNotificari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(866, 528);
            this.Controls.Add(this.lstidNotif);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstNotif);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FrmNotificari";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Notificari";
            this.Load += new System.EventHandler(this.FrmNotificari_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstNotif;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstidNotif;
    }
}