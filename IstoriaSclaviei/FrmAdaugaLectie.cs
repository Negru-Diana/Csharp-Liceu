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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace IstoriaSclaviei
{
    public partial class FrmAdaugaLectie : Form
    {
        public FrmAdaugaLectie()
        {
            InitializeComponent();
        }

        int verificare = 0;
        private void FrmAdaugaLectie_Load(object sender, EventArgs e)
        {
            verificare = 0; //cu ajutorul acestei variabile verific daca lectia a fost sau nu salvata

            cbCapitole.Items.Clear();
            cbLectii.Items.Clear();

            pnlCapitol.Visible = true;
            pnlLectie.Visible = false;
            pnlContinutLectie.Visible = false;

            rtbContinutLectie.Text = "";

            btnSalveazaImg.Enabled = false;

            txtDescriereImg.Text = "Descriere imagine";
            txtDescriereImg.Enabled = false;

            btnAddImg.Enabled = btnDelImg.Enabled = false;

            rtbContinutLectie.Enabled = true;
            btnSalveaza.Enabled = true;

            
            lblCaleImg.Text = "Img/nopic.png";
            pbImgLectie.Image = new Bitmap(lblCaleImg.Text);

            //Se incarca capitolele in ComboBox

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

        //Daca s-a selectat un capitol din ComboBox se incarca intr-ul alt ComboBox lectiile care sunt cuprinse in acel capitol
        private void cbCapitole_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCapitole.SelectedIndex != -1)
            {
                if(verificare==1)
                {
                    rtbContinutLectie.Text = "";
                    rtbContinutLectie.Enabled = true;
                    verificare = 0;
                }

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

        //Se adauga un nou capitol
        private void btnAdaugaCapitol_Click(object sender, EventArgs e)
        {
            if (cbCapitole.Text != "")
            {
                cbLectii.Items.Clear();

                if (verificare == 1)
                {
                    rtbContinutLectie.Text = "";
                    rtbContinutLectie.Enabled = true;
                    verificare = 0;
                }

                pnlLectie.Visible = true;

                cbLectii.Text = "";
                cbCapitole.Items.Add(cbCapitole.Text);

            }
            else
            {
                MessageBox.Show("Trebuie sa introduceti titlul noului capitol, iar apoi sa apasati pe butonul + ");
            }
        }

        // NECESAR ?
        private void cbLectii_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbLectii.SelectedIndex != -1)
            {
                if (verificare == 1)
                {
                    rtbContinutLectie.Text = "";
                    rtbContinutLectie.Enabled = true;
                    verificare = 0;
                }

                pnlContinutLectie.Visible = true;

            }
            else
            {
                MessageBox.Show("Selectati o lectie deja existenta, sau adaugati una noua introducand titlul acesteia si apasand pe butonul +");

            }
        }

        //Se adauga o lectie noua
        private void btnAdaugaLectie_Click(object sender, EventArgs e)
        {
            if (cbLectii.Text != "")
            {
                if (verificare == 1)
                {
                    rtbContinutLectie.Text = "";
                    rtbContinutLectie.Enabled = true;
                    verificare = 0;
                }

                pnlContinutLectie.Visible = true;
                cbLectii.Items.Add(cbLectii.Text);
            }
            else
            {
                MessageBox.Show("Trebuie sa introduceti titlul nou de lectie, iar apoi sa apasati pe butonul + ");
            }
        }

        //Se salveaza continutul lectiei
        private void btnSalveaza_Click(object sender, EventArgs e)
        {
            if (rtbContinutLectie.Text != "" && cbCapitole.Text != "" && cbLectii.Text != "")
            {
                btnAddImg.Enabled = true;
                btnDelImg.Enabled = true;

                verificare = 1;

                //Se creeaza conexiunea la baza de date
                MySqlConnection conexiune = new MySqlConnection();
                conexiune.ConnectionString = @"SERVER=localhost; DATABASE=softeducational; UID=root; PASSWORD=; Allow User Variables=True";
                conexiune.Open(); //Se deschide conexiunea

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexiune;
                cmd.CommandText = "SELECT * FROM capitole";  // se cauta capitolul

                int ok = 0; //determina daca exista sau nu capitolul

                MySqlDataReader r = cmd.ExecuteReader();
                while (r.Read())
                {
                    Capitole capitol = new Capitole();
                    {
                        capitol.idC = r["idC"].ToString();
                        capitol.titlu = r["titlu"].ToString();
                    }

                    if (capitol.titlu == cbCapitole.Text)
                    {
                        ok = 1;
                        break;
                    }
                }
                r.Close();

                if (ok == 0) //daca nu exista capitolul, se adauga in baza de date
                {
                    cmd.CommandText = @"INSERT INTO capitole (titlu) VALUES (@ptitlu);";

                    cmd.Parameters.AddWithValue("ptitlu", cbCapitole.Text);
                    cmd.ExecuteNonQuery();
                }

                Capitole c = new Capitole();

                cmd.CommandText = "SELECT * FROM capitole"; //se determina id-ul capitolului in care urmeaza sa fie adaugata lectia
                r = cmd.ExecuteReader();
                while(r.Read())
                {
    
                        c.idC = r.GetString("idC");
                        c.titlu = r.GetString("titlu");

                    if(c.titlu==cbCapitole.Text)
                    {
                        break;
                    }
                }
                r.Close();

                int exista = 0;
                //se verifica daca exista lectia deja
                cmd.CommandText = "SELECT * FROM lectii WHERE idC=@idC";
                //cmd.Parameters.AddWithValue("titlu", cbLectii.Text);
                cmd.Parameters.AddWithValue("idC",c.idC);
                r = cmd.ExecuteReader();
                while(r.Read())
                {
                    if (r["titlu"].ToString()==cbLectii.Text)
                    {
                        MessageBox.Show("Lectia selectata exista deja. Daca doriti sa o modificati, va rugam intrati la modificare lectie sau alegeti alt titlu pentru lectie.");
                        exista++;
                        break;
                    }
                }
                r.Close();

                if(exista==0)
                {
                    //se adauga lectia in baza de date
                    cmd.CommandText = @"INSERT INTO lectii (idC, titlu, idProfesor, data_adaugare) VALUES (@pidC, @pptitlu, @pidProfesor, now());";

                    cmd.Parameters.AddWithValue("pidC", c.idC);
                    cmd.Parameters.AddWithValue("pptitlu", cbLectii.Text);
                    cmd.Parameters.AddWithValue("pidProfesor", this.Tag);
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = "SELECT * FROM lectii"; // se determina id-ul lectiei
                    r = cmd.ExecuteReader();

                    Lectii lectie = new Lectii();
                    while (r.Read())
                    {
                        lectie.idL = r.GetString("idL");
                        lectie.idC = r.GetString("idC");
                        lectie.titlu = r.GetString("titlu");
                        lectie.idProfesor = r.GetString("idProfesor");
                        lectie.data_adaugare = Convert.ToDateTime(r["data_adaugare"]);

                        if (lectie.titlu == cbLectii.Text)
                        {
                            break;
                        }
                    }
                    r.Close();

                    //se adauga continutul lectiei in baza de date
                    cmd.CommandText = @"INSERT INTO continut_lectii (idL, continut) VALUES (@pidL, @pcontinut);";

                    cmd.Parameters.AddWithValue("pidL", lectie.idL);
                    cmd.Parameters.AddWithValue("pcontinut", rtbContinutLectie.Text);
                    cmd.ExecuteNonQuery();

                    //se adauga notificarea pentru adaugarea lectiei
                    cmd.CommandText = @"INSERT INTO notificari (idCont,tipNotificare,idLectie) VALUES (@idCont,@ptip,@idL)";

                    MySqlConnection con = new MySqlConnection();
                    con.ConnectionString = @"SERVER=localhost; DATABASE=softeducational; UID=root; PASSWORD=; Allow User Variables=True";
                    con.Open(); //Se deschide conexiunea

                    MySqlCommand cm = new MySqlCommand();
                    cm.Connection = con;
                    cm.CommandText = "SELECT * FROM conturi";
                    MySqlDataReader read = cm.ExecuteReader();
                    while(read.Read())
                    {
                        cmd.Parameters.AddWithValue("idCont", read["id"].ToString());
                        cmd.Parameters.AddWithValue("ptip", "adaugareLectie");
                        cmd.Parameters.AddWithValue("idL", lectie.idL);
                        cmd.ExecuteNonQuery();
                        cmd.Parameters.Clear();
                    }
                    read.Close();
                    con.Close();


                    conexiune.Close();

                    MessageBox.Show("Lectia a fost salvata cu succes.");

                    btnSalveazaImg.Enabled = true; ;
                    txtDescriereImg.Text = "Descriere imagine";
                    txtDescriereImg.Enabled = true;
                    rtbContinutLectie.Enabled = false;
                    btnSalveaza.Enabled = false;
                }

                
            }
            else
            {
                MessageBox.Show("Campurile cu denumirea capitolului, a lectiei si continutul lectie trebuie completate inainte de a salva lectia.");
            }
            
        }

        //salvarea imaginii
        private void btnSalveazaImg_Click(object sender, EventArgs e)
        {
            if(txtDescriereImg.Text!="Descriere imagine" && lblCaleImg.Text!="Img/nopic.png")
            {
                MySqlConnection conexiune = new MySqlConnection();
                conexiune.ConnectionString = @"SERVER=localhost; DATABASE=softeducational; UID=root; PASSWORD=; Allow User Variables=True";
                conexiune.Open(); //Se deschide conexiunea

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexiune;
                cmd.CommandText = "SELECT * FROM lectii"; // se determina id-ul lectiei

                //Se executa comanda si se depune in r rezultatul 
                MySqlDataReader r = cmd.ExecuteReader();
                Lectii lectie = new Lectii();
                while (r.Read())
                {
                    lectie.idL = r.GetString("idL");
                    lectie.idC = r.GetString("idC");
                    lectie.titlu = r.GetString("titlu");
                    lectie.idProfesor = r.GetString("idProfesor");
                    lectie.data_adaugare = Convert.ToDateTime(r["data_adaugare"]);

                    if(lectie.titlu==cbLectii.Text)
                    {
                        break;
                    }
                }
                r.Close();

                //se adauga imaginea in baza de date
                cmd.CommandText = @"INSERT INTO imagini (idL, denumire, cale) VALUES (@pidL, @pdenumire, @pcale)";
                cmd.Parameters.AddWithValue("pidL",lectie.idL);
                cmd.Parameters.AddWithValue("pdenumire", txtDescriereImg.Text);
                cmd.Parameters.AddWithValue("pcale", lblCaleImg.Text);

                cmd.ExecuteNonQuery();

                conexiune.Close();
                
                lblCaleImg.Text = "Img/nopic.png";
                pbImgLectie.Image = new Bitmap(lblCaleImg.Text);
                txtDescriereImg.Text = "Descriere imagine";

                btnAddImg.Enabled = btnDelImg.Enabled = true;

                MessageBox.Show("Imaginea a fost salvata cu succes!");
            }
            else
            {
                MessageBox.Show("Trebuie sa adaugati o imagine si sa adaugati o descriere acesteia inainte de a o salva");
            }

        }

        //se incarca imaginea din calculator in PictureBox
        private void btnAddImg_Click(object sender, EventArgs e)
        {
            //se deschide OpenFileDialog

            if (ofd.ShowDialog()==DialogResult.OK) 
            {
                lblCaleImg.Text = "Img/" + ofd.SafeFileName;
                if(! File.Exists(lblCaleImg.Text))
                {
                    File.Copy(ofd.FileName, lblCaleImg.Text);

                }
                pbImgLectie.Image = new Bitmap(lblCaleImg.Text);
            }
        }

        //se inlocuieste imaginea din PictureBox cu nopic
        private void btnDelImg_Click(object sender, EventArgs e)
        {
            lblCaleImg.Text = "Img/nopic.png";
            pbImgLectie.Image = new Bitmap(lblCaleImg.Text);
        }
    }
}
