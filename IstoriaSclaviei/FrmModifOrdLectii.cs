using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IstoriaSclaviei
{
    public partial class FrmModifOrdLectii : Form
    {
        public FrmModifOrdLectii()
        {
            InitializeComponent();
        }

        private void FrmModifOrdLectii_Load(object sender, EventArgs e)
        {
            lstLectii.Items.Clear();
            lstIdL.Items.Clear();
            cbCapitole.Items.Clear();

            MySqlConnection conexiune = new MySqlConnection();
            conexiune.ConnectionString = @"SERVER=localhost; DATABASE=softeducational; UID=root; PASSWORD=; Allow User Variables=True";
            conexiune.Open(); //Se deschide conexiunea

            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conexiune;
            cmd.CommandText = "SELECT * FROM capitole";

            MySqlDataReader r = cmd.ExecuteReader();
            while (r.Read())
            {
                Capitole c = new Capitole();
                {
                    c.idC = r["idC"].ToString();
                    c.titlu = r["titlu"].ToString();
                }
                cbCapitole.Items.Add(c);
            }
            r.Close();
            conexiune.Close();


        }

        private void btnSus_Click(object sender, EventArgs e)
        {
            if (lstLectii.SelectedIndex > 0)
            {
                int index = lstLectii.SelectedIndex;
                Lectii lectie = lstLectii.SelectedItem as Lectii;

                lstLectii.Items[index] = lstLectii.Items[index - 1];
                lstLectii.Items[index - 1] = lectie;

                lstLectii.SelectedIndex = index - 1;
                lstLectii.Update();
                lstLectii.Focus();
            }
            else
            {
                if (lstLectii.SelectedIndex == -1)
                {
                    MessageBox.Show("Selectati lectia pe care doriti sa o mutati cu o pozitie mai sus.");
                }
                else
                {
                    MessageBox.Show("Nu puteti efectua aceasta modificare.");
                }
            }
        }

        private void btnJos_Click(object sender, EventArgs e)
        {
            if (lstLectii.SelectedIndex < lstLectii.Items.Count - 1 && lstLectii.SelectedIndex != -1)
            {
                int index = lstLectii.SelectedIndex;
                Lectii lectie = lstLectii.SelectedItem as Lectii;


                lstLectii.Items[index] = lstLectii.Items[index + 1];
                lstLectii.Items[index + 1] = lectie;

                lstLectii.SelectedIndex = index + 1;
                lstLectii.Update();
                lstLectii.Focus();
            }
            else
            {
                if (lstLectii.SelectedIndex == -1)
                {
                    MessageBox.Show("Selectati lectia pe care doriti sa o mutati cu o pozitie mai jos.");
                }
                else
                {
                    MessageBox.Show("Nu puteti efectua aceasta modificare.");
                }
            }
        }

        private void btnSalveazaModif_Click(object sender, EventArgs e)
        {
            MySqlConnection conexiune = new MySqlConnection();
            conexiune.ConnectionString = @"SERVER=localhost; DATABASE=softeducational; UID=root; PASSWORD=; Allow User Variables=True";
            conexiune.Open(); //Se deschide conexiunea

            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conexiune;
            cmd.CommandText = "SELECT * FROM lectii WHERE idC=@pidC";
            cmd.Parameters.AddWithValue("pidC", this.Tag);

            int index = 0;

            MySqlDataReader read = cmd.ExecuteReader();
            while (read.Read())
            {
                Lectii l = lstLectii.Items[index] as Lectii;
                Lectii ll = lstIdL.Items[index] as Lectii;
                //lstIdL.Items.Add(l);

                MySqlConnection con = new MySqlConnection();
                con.ConnectionString = @"SERVER=localhost; DATABASE=softeducational; UID=root; PASSWORD=; Allow User Variables=True";
                con.Open(); //Se deschide conexiunea

                MySqlCommand cmm = new MySqlCommand();
                cmm.Connection = con;
                cmm.CommandText = "UPDATE lectii SET titlu=@ptitlu, idProfesor=@idProf, data_adaugare=@pdata WHERE idL=@pid";
                //cmm.Parameters.AddWithValue("pidC", l.idC);
                cmm.Parameters.AddWithValue("ptitlu", l.titlu);
                cmm.Parameters.AddWithValue("idProf", l.idProfesor);
                cmm.Parameters.AddWithValue("pdata", l.data_adaugare);
                cmm.Parameters.AddWithValue("pid", ll.idL);
                //cmm.Parameters.AddWithValue("pid", l.id);
                cmm.ExecuteNonQuery();
                con.Close();
                index++;
            }
            read.Close();
            

            
            cmd.CommandText = "SELECT * FROM lectii WHERE idC=@pid";
            cmd.Parameters.AddWithValue("pid", this.Tag);
            MySqlDataReader r = cmd.ExecuteReader();
            index = 0;
            while (r.Read())
            {
                MySqlConnection con = new MySqlConnection();
                con.ConnectionString = @"SERVER=localhost; DATABASE=softeducational; UID=root; PASSWORD=; Allow User Variables=True";
                con.Open(); //Se deschide conexiunea

                MySqlCommand cmm = new MySqlCommand();
                cmm.Connection = con;
                cmm.CommandText = "UPDATE lectii SET idL=@pidL WHERE titlu=@titlu";
                Lectii lectie = lstLectii.Items[index] as Lectii;
                cmm.Parameters.AddWithValue("pidL", lectie.idL);
                cmm.Parameters.AddWithValue("titlu", lectie.titlu);
                cmm.ExecuteNonQuery();
                con.Close();
                index++;
            }
            r.Close();
            conexiune.Close();
            



            MessageBox.Show("Modificarile au fost salvate cu succes.");
            this.Close();
        }

        private void cbCapitole_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbCapitole.SelectedIndex!=-1)
            {
                lstLectii.Items.Clear();
                lstIdL.Items.Clear();

                MySqlConnection conexiune = new MySqlConnection();
                conexiune.ConnectionString = @"SERVER=localhost; DATABASE=softeducational; UID=root; PASSWORD=; Allow User Variables=True";
                conexiune.Open(); //Se deschide conexiunea

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexiune;
                cmd.CommandText = "SELECT * FROM lectii WHERE idC=@pidC";
                Capitole capitol = cbCapitole.SelectedItem as Capitole;
                cmd.Parameters.AddWithValue("pidC", capitol.idC);

                this.Tag = capitol.idC;

                MySqlDataReader r = cmd.ExecuteReader();
                while (r.Read())
                {
                    Lectii l = new Lectii();
                    {
                       // l.id = r["id"].ToString();
                        l.idL = r["idL"].ToString();
                        l.idC = r["idC"].ToString();
                        l.titlu = r["titlu"].ToString();
                        l.idProfesor = r["idProfesor"].ToString();
                        l.data_adaugare = Convert.ToDateTime( r["data_adaugare"]);
                    }
                    lstLectii.Items.Add(l);
                    lstIdL.Items.Add(l);
                }
                r.Close();
                conexiune.Close();
            }
        }
    }
}
