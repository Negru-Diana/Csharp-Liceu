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
    public partial class FrmStergeLectie : Form
    {
        public FrmStergeLectie()
        {
            InitializeComponent();
        }

        private void FrmStergeLectie_Load(object sender, EventArgs e)
        {
            pnlCapitol.Visible = true;
            pnlLectie.Visible = false;
            pnlContinut.Visible = false;
            rtbLectie.Text = "";

            cbCapitole.Text = "";
            cbLectii.Text = "";

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

                
                int ok = 0;

                Capitole capitol = cbCapitole.SelectedItem as Capitole;

                //Se creeaza conexiunea la baza de date
                MySqlConnection conexiune = new MySqlConnection();
                conexiune.ConnectionString = @"SERVER=localhost; DATABASE=softeducational; UID=root; PASSWORD=; Allow User Variables=True";
                conexiune.Open(); //Se deschide conexiunea

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexiune;
                cmd.CommandText = "SELECT * FROM lectii WHERE idProfesor=@pidProfesor";

                cmd.Parameters.AddWithValue("pidProfesor", this.Tag);

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
                        ok++;
                    }
                }
                r.Close();
                conexiune.Close();

                if(ok!=0)
                {
                    pnlLectie.Visible = true;
                }
                else
                {
                    MessageBox.Show("Nu aveti lectii adaugate in acest capitol.");
                    pnlLectie.Visible = false;
                }
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

                pnlContinut.Visible = true;

                //Se creeaza conexiunea la baza de date
                MySqlConnection conexiune = new MySqlConnection();
                conexiune.ConnectionString = @"SERVER=localhost; DATABASE=softeducational; UID=root; PASSWORD=; Allow User Variables=True";
                conexiune.Open(); //Se deschide conexiunea

                Lectii l = cbLectii.SelectedItem as Lectii;

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexiune;
                cmd.CommandText = "SELECT * FROM continut_lectii WHERE idL=@pidL";

                cmd.Parameters.AddWithValue("pidL", l.idL);

                //Se executa comanda si se depune in r rezultatul 
                MySqlDataReader r = cmd.ExecuteReader();
                while(r.Read())
                {
                    Continut_lectii cl = new Continut_lectii();
                    {
                        cl.id = r["id"].ToString();
                        cl.idL = r["idL"].ToString();
                        cl.continut = r["continut"].ToString();
                    }

                    rtbLectie.Text = cl.ToString();
                    rtbLectie.Tag = cl.idL;
                }

            }
            else
            {
                MessageBox.Show("Selectati lectia pe care doriti sa o stergeti");

            }
        }

        private void btnStergeLectie_Click(object sender, EventArgs e)
        {
            //Se creeaza conexiunea la baza de date
            MySqlConnection conexiune = new MySqlConnection();
            conexiune.ConnectionString = @"SERVER=localhost; DATABASE=softeducational; UID=root; PASSWORD=; Allow User Variables=True";
            conexiune.Open(); //Se deschide conexiunea

            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conexiune;
            cmd.CommandText = "DELETE FROM lectii WHERE idL=@pidL";
            cmd.Parameters.AddWithValue("pidL", rtbLectie.Tag);
            cmd.ExecuteNonQuery();

            cmd.CommandText = "DELETE FROM continut_lectii WHERE idL=@ppidL";
            cmd.Parameters.AddWithValue("ppidL", rtbLectie.Tag);
            cmd.ExecuteNonQuery();

            cmd.CommandText = "DELETE FROM imagini WHERE idL=@idL";
            cmd.Parameters.AddWithValue("idL", rtbLectie.Tag);
            cmd.ExecuteNonQuery();

            conexiune.Close();

            MessageBox.Show("Lectia a fost stearsa cu succes!");
            rtbLectie.Text = "";
            rtbLectie.Tag = null;
            cbLectii.Text = "";
            cbLectii.Items.Clear();
            pnlContinut.Visible = false;

        }
    }
}
