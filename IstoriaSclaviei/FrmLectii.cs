using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IstoriaSclaviei
{
    public partial class FrmLectii : Form
    {
        public FrmLectii()
        {
            InitializeComponent();
        }

        private void FrmLectii_Load(object sender, EventArgs e)
        {
            lblDenumire.Text = "";
            btnStanga.Visible = false;
            btnDreapta.Visible = false;

            lstImg.Items.Clear();

            //Se creeaza conexiunea la baza de date
            MySqlConnection conexiune = new MySqlConnection();
            conexiune.ConnectionString = @"SERVER=localhost; DATABASE=softeducational; UID=root; PASSWORD=; Allow User Variables=True";
            conexiune.Open(); //Se deschide conexiunea

            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conexiune;
            cmd.CommandText = "SELECT capitole.titlu, lectii.titlu as lTitlu, continut_lectii.continut FROM capitole JOIN lectii ON capitole.idC=lectii.idC JOIN continut_lectii ON lectii.idL=continut_lectii.idL WHERE lectii.idL=@pidL;";

            cmd.Parameters.AddWithValue("pidL", this.Tag);

            //Se executa comanda si se depune in r rezultatul 
            MySqlDataReader r = cmd.ExecuteReader();
            while(r.Read())
            {
                lblDenumire.Text = r["titlu"].ToString() + ". " + r["lTitlu"].ToString();
                rtbLectie.Text = r["continut"].ToString();
   
            }
            r.Close();

            cmd.CommandText = "SELECT * FROM imagini WHERE idL=@ppidL;";
            cmd.Parameters.AddWithValue("ppidL", this.Tag);
            r = cmd.ExecuteReader();
            
            while (r.Read())
            {
                Imagini img = new Imagini();
                {
                    img.idImg = r["idImg"].ToString();
                    img.idL = r["idL"].ToString();
                    img.denumire = r["denumire"].ToString();
                    img.cale = r["cale"].ToString();
                }
                lstImg.Items.Add(img);
            }
            r.Close();
            conexiune.Close();

            if(lstImg.Items.Count>0)
            {
                Imagini img = lstImg.Items[0] as Imagini;
                pbImgLectie.Image = new Bitmap(img.cale.ToString());
                Imagini imag = lstImg.Items[0] as Imagini;
                lblDescriere.Text = imag.denumire;
                lblDescriere.Visible = true;

                if (lstImg.Items.Count > 1)
                {
                    btnDreapta.Visible = true;
                }
            }
            else
            {
                pbImgLectie.Image = new Bitmap(@"Img/nopic.png");
                lblDescriere.Visible = false;
            }
            
           
        }

        int poz = 0;
        private void btnDreapta_Click(object sender, EventArgs e)
        {
            poz++;
            btnStanga.Visible = true;

            pbImgLectie.Image = new Bitmap(lstImg.Items[poz].ToString());
            Imagini imag = lstImg.Items[poz] as Imagini;
            lblDescriere.Text = imag.denumire;

            if(poz==lstImg.Items.Count-1)
            {
                btnDreapta.Visible = false;
            }
        }

        private void btnStanga_Click(object sender, EventArgs e)
        {
            poz--;
            if(poz==0)
            {
                btnStanga.Visible = false;
            }
            btnDreapta.Visible = true;

            pbImgLectie.Image = new Bitmap(lstImg.Items[poz].ToString());
            Imagini imag = lstImg.Items[poz] as Imagini;
            lblDescriere.Text = imag.denumire;

        }
    }
}
