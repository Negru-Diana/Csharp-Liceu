using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IstoriaSclaviei
{
    public partial class FrmModificaLectie : Form
    {
        public FrmModificaLectie()
        {
            InitializeComponent();
        }

        private void FrmModificaLectie_Load(object sender, EventArgs e)
        {
            pnlAdaugaImg.Visible = false;
            pnlStergeImg.Visible = false;
            pnlStergeImg.Location = pnlAdaugaImg.Location = new Point(614, 77);
            pnlStergeImg.Size = pnlAdaugaImg.Size = new Size(429, 551);



            cbCapitole.Items.Clear();
            cbLectii.Items.Clear();

            pnlCapitol.Visible = true;
            pnlLectie.Visible = false;
            pnlContinutLectie.Visible = false;

            rtbContinutLectie.Text = "";

            txtDescriereImg.Text = "Descriere imagine";

            rtbContinutLectie.Enabled = true;
            btnSalveaza.Enabled = true;


            lblCaleImg.Text = "Img/nopic.png";
            pbImgLectie.Image = new Bitmap(lblCaleImg.Text);


            //Se creeaza conexiunea la baza de date
            MySqlConnection conexiune = new MySqlConnection();
            conexiune.ConnectionString = @"SERVER=localhost; DATABASE=softeducational; UID=root; PASSWORD=; Allow User Variables=True";
            conexiune.Open(); //Se deschide conexiunea

            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conexiune;
            cmd.CommandText = "SELECT * FROM capitole";

            //Se executa comanda si se depune in r rezultatul 
            MySqlDataReader r = cmd.ExecuteReader();
            while (r.Read())
            {
                Capitole capitol = new Capitole();
                {
                    capitol.idC = r.GetString("idC");
                    capitol.titlu = r.GetString("titlu");
                }

                cbCapitole.Items.Add(capitol);


            }
            r.Close();
            conexiune.Close();
        }

        private void cbCapitole_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cbCapitole.SelectedIndex != -1)
            {

                cbLectii.Text = "";
                cbLectii.Items.Clear();

                pnlLectie.Visible = true;

                Capitole capitol = cbCapitole.SelectedItem as Capitole;

                //Se creeaza conexiunea la baza de date
                MySqlConnection conexiune = new MySqlConnection();
                conexiune.ConnectionString = @"SERVER=localhost; DATABASE=softeducational; UID=root; PASSWORD=; Allow User Variables=True";
                conexiune.Open(); //Se deschide conexiunea

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexiune;
                cmd.CommandText = "SELECT * FROM lectii";

                //Se executa comanda si se depune in r rezultatul 
                MySqlDataReader r = cmd.ExecuteReader();
                while (r.Read())
                {
                    Lectii lectie = new Lectii();
                    {
                        lectie.idL = r.GetString("idL");
                        lectie.idC = r.GetString("idC");
                        lectie.titlu = r.GetString("titlu");
                        lectie.idProfesor = r.GetString("idProfesor");
                        lectie.data_adaugare = Convert.ToDateTime(r["data_adaugare"]);
                    }

                    if (lectie.idC == capitol.idC)
                    {
                        cbLectii.Items.Add(lectie);
                    }
                }
                r.Close();
                conexiune.Close();
            }
            else
            {
                MessageBox.Show("Selectati un capitol deja existent, sau adaugati unul nou introducand titlul acestuia si apasand pe butonul +");
            }
        }

        private void cbLectii_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbLectii.SelectedIndex != -1)
            {
                pnlContinutLectie.Visible = true;

                //Se creeaza conexiunea la baza de date
                MySqlConnection conexiune = new MySqlConnection();
                conexiune.ConnectionString = @"SERVER=localhost; DATABASE=softeducational; UID=root; PASSWORD=; Allow User Variables=True";
                conexiune.Open(); //Se deschide conexiunea

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexiune;
                cmd.CommandText = "SELECT * FROM lectii";

                //Se executa comanda si se depune in r rezultatul 
                MySqlDataReader r = cmd.ExecuteReader();

                Lectii lectie = new Lectii();

                while(r.Read())
                {
                    lectie.idL = r["idL"].ToString();
                    lectie.idC = r["idC"].ToString();
                    lectie.titlu = r["titlu"].ToString();
                    lectie.idProfesor = r["idProfesor"].ToString();
                    lectie.data_adaugare = Convert.ToDateTime(r["data_adaugare"]);

                    if(lectie.titlu==cbLectii.Text)
                    {
                        this.Tag = lectie.idL;
                        break;
                    }
                }
                r.Close();

                cmd.CommandText = "SELECT * FROM continut_lectii ";
                r = cmd.ExecuteReader();
                while(r.Read())
                {
                    if (lectie.idL == r["idL"].ToString())
                    {
                        rtbContinutLectie.Text = r["continut"].ToString();
                        break;
                    }
                }
                r.Close();
                conexiune.Close();

            }
            else
            {
                MessageBox.Show("Selectati o lectie deja existenta, sau adaugati una noua introducand titlul acesteia si apasand pe butonul +");

            }
        }

        private void btnSalveaza_Click(object sender, EventArgs e)
        {

            //Se creeaza conexiunea la baza de date
            MySqlConnection conexiune = new MySqlConnection();
            conexiune.ConnectionString = @"SERVER=localhost; DATABASE=softeducational; UID=root; PASSWORD=; Allow User Variables=True";
            conexiune.Open(); //Se deschide conexiunea

            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conexiune;
            cmd.CommandText = "UPDATE continut_lectii SET continut=@pcontinut WHERE idL=@pidL";

            cmd.Parameters.AddWithValue("pcontinut", rtbContinutLectie.Text);
            cmd.Parameters.AddWithValue("pidL", this.Tag.ToString());
            cmd.ExecuteNonQuery();
            

            cmd.CommandText = "UPDATE lectii SET Titlu=@ptitlu WHERE idL=@idL";
            cmd.Parameters.AddWithValue("ptitlu", cbLectii.Text);
            cmd.Parameters.AddWithValue("idL", this.Tag.ToString());
            cmd.ExecuteNonQuery();

            cmd.Parameters.Clear();
            cmd.CommandText = "SELECT * FROM capitole WHERE titlu=@titlu";
            cmd.Parameters.AddWithValue("titlu", cbCapitole.Text);
            string idCapitol;
            MySqlDataReader r = cmd.ExecuteReader();
            r.Read();
            idCapitol = r["idC"].ToString();
            /*
            while(r.Read())
            {
                idCapitol = r["idC"].ToString();
                break;
            }
            */
            r.Close();
           

            cmd.Parameters.Clear();
            cmd.CommandText = "UPDATE lectii SET idC=@pidC WHERE idL=@pidL";
            cmd.Parameters.AddWithValue("pidC", idCapitol.ToString());
            cmd.Parameters.AddWithValue("pidL", this.Tag.ToString());
            cmd.ExecuteNonQuery();

            conexiune.Close();

            MessageBox.Show("Lectia a fost modificata cu secces.");

            //se adauga notificare pentru modificarea lectiei
            MySqlConnection c = new MySqlConnection();
            c.ConnectionString = @"SERVER=localhost; DATABASE=softeducational; UID=root; PASSWORD=; Allow User Variables=True";
            c.Open(); //Se deschide conexiunea

            MySqlCommand cmdd = new MySqlCommand();
            cmdd.Connection = c;
            cmdd.CommandText = @"INSERT INTO notificari (idCont,tipNotificare,idLectie) VALUES (@idCont,@ptip,@idL)";

            MySqlConnection conn = new MySqlConnection();
            conn.ConnectionString = @"SERVER=localhost; DATABASE=softeducational; UID=root; PASSWORD=; Allow User Variables=True";
            conn.Open(); //Se deschide conexiunea

            MySqlCommand cmm = new MySqlCommand();
            cmm.Connection = conn;
            cmm.CommandText = "SELECT * FROM conturi";
            MySqlDataReader read = cmm.ExecuteReader();
            while (read.Read())
            {
                cmdd.Parameters.AddWithValue("idCont", read["id"].ToString());
                cmdd.Parameters.AddWithValue("ptip", "modifLectie");
                cmdd.Parameters.AddWithValue("idL", this.Tag.ToString());
                cmdd.ExecuteNonQuery();
                cmdd.Parameters.Clear();
            }
            read.Close();
            conn.Close();
        }

        private void btnAddImg_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                lblCaleImg.Text = "Img/" + ofd.SafeFileName;
                if (! File.Exists(lblCaleImg.Text))
                {
                    File.Copy(ofd.FileName, lblCaleImg.Text);

                }
                pbImgLectie.Image = new Bitmap(lblCaleImg.Text);
            }
        }

        private void btnDelImg_Click(object sender, EventArgs e)
        {
            lblCaleImg.Text = "Img/nopic.png";
            pbImgLectie.Image = new Bitmap(lblCaleImg.Text);
        }

        private void btnSalveazaImg_Click(object sender, EventArgs e)
        {
            if (txtDescriereImg.Text != "Descriere imagine" && lblCaleImg.Text != "Img/nopic.png")
            {
                MySqlConnection conexiune = new MySqlConnection();
                conexiune.ConnectionString = @"SERVER=localhost; DATABASE=softeducational; UID=root; PASSWORD=; Allow User Variables=True";
                conexiune.Open(); //Se deschide conexiunea

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexiune;

                cmd.CommandText = @"INSERT INTO imagini (idL, denumire, cale) VALUES (@pidL, @pdenumire, @pcale)";
                cmd.Parameters.AddWithValue("pidL", this.Tag.ToString());
                cmd.Parameters.AddWithValue("pdenumire", txtDescriereImg.Text);
                cmd.Parameters.AddWithValue("pcale", lblCaleImg.Text);

                cmd.ExecuteNonQuery();

                conexiune.Close();

                lblCaleImg.Text = "Img/nopic.png";
                pbImgLectie.Image = new Bitmap(lblCaleImg.Text);
                txtDescriereImg.Text = "Descriere imagine";

                MessageBox.Show("Imaginea a fost salvata cu succes!");
            }
            else
            {
                MessageBox.Show("Trebuie sa adaugati o imagine si sa adaugati o descriere acesteia inainte de a o salva");
            }
        }

        private void btnAdauga_Click(object sender, EventArgs e)
        {
            pnlAdaugaImg.Visible = true;
            pnlStergeImg.Visible = false;
        }

        private void btnSterge_Click(object sender, EventArgs e)
        {
            pnlStergeImg.Visible = true;
            pnlAdaugaImg.Visible = false;

            lstImagini.Items.Clear();

            MySqlConnection conexiune = new MySqlConnection();
            conexiune.ConnectionString = @"SERVER=localhost; DATABASE=softeducational; UID=root; PASSWORD=; Allow User Variables=True";
            conexiune.Open(); //Se deschide conexiunea

            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conexiune;

            cmd.CommandText = "SELECT * FROM imagini WHERE idL=@pidL";
            cmd.Parameters.AddWithValue("pidL", this.Tag);
            //MessageBox.Show(this.Tag.ToString());

            MySqlDataReader r = cmd.ExecuteReader();
            int exista = 0;
            while(r.Read())
            {
                Imagini img = new Imagini();
                {
                    img.idImg = r["idImg"].ToString();
                    img.denumire = r["denumire"].ToString();
                    img.cale = r["cale"].ToString();
                }

                lstImagini.Items.Add(img);
                exista++;
                //MessageBox.Show(img.idImg.ToString());
            }
            r.Close();
            conexiune.Close();

            if(exista==0)
            {
                MessageBox.Show("Nu exista imagini.");
                pnlStergeImg.Visible = false;
            }
            else
            {
                btnDr.Visible = true;
                btnSt.Visible = true;

                Imagini img = lstImagini.Items[0] as Imagini;
                txtDescriere.Text = img.denumire;
                pbStergeImg.Image = new Bitmap(img.cale);
            }
        }

        int imgcurenta = 0;
        private void btnDr_Click(object sender, EventArgs e)
        {
            imgcurenta++;
            if(imgcurenta<=lstImagini.Items.Count-1)
            {
                IncarcaImg();
            }
            else
            {
                imgcurenta = 0;
                IncarcaImg();
            }
        }

        private void IncarcaImg()
        {
            Imagini img = lstImagini.Items[imgcurenta] as Imagini;
            txtDescriere.Text = img.denumire;
            pbStergeImg.Image = new Bitmap(img.cale);
        }

        private void btnSt_Click(object sender, EventArgs e)
        {
            imgcurenta--;
            if (imgcurenta>=0)
            {
                IncarcaImg();
            }
            else
            {
                imgcurenta = lstImagini.Items.Count-1;
                IncarcaImg();
            }
        }

        private void btnStergeImg_Click(object sender, EventArgs e)
        {
            if(imgcurenta>-1)
            {
                MySqlConnection conexiune = new MySqlConnection();
                conexiune.ConnectionString = @"SERVER=localhost; DATABASE=softeducational; UID=root; PASSWORD=; Allow User Variables=True";
                conexiune.Open(); //Se deschide conexiunea

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexiune;

                cmd.CommandText = "DELETE FROM imagini WHERE idL=@pidL";
                cmd.Parameters.AddWithValue("pidL", this.Tag);
                cmd.ExecuteNonQuery();
                conexiune.Close();

                lstImagini.Items.Remove(lstImagini.Items[imgcurenta]);
                MessageBox.Show("Imaginea a fost stearsa cu succes.");

                if(imgcurenta+1<=lstImagini.Items.Count-1)
                {
                    imgcurenta++;
                    IncarcaImg();
                }
                else
                {
                    if(imgcurenta-1>=0)
                    {
                        imgcurenta--;
                        IncarcaImg();
                    }
                    else
                    {
                        pnlStergeImg.Visible = false;
                        MessageBox.Show("Nu mai exista imagini pe care sa le puteti sterge.");
                    }
                }


            }
        }

    }
}