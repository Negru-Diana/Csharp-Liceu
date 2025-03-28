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
using static System.Net.Mime.MediaTypeNames;

namespace IstoriaSclaviei
{
    public partial class FrmStergeTest : Form
    {
        public FrmStergeTest()
        {
            InitializeComponent();
        }

        private void FrmStergeTest_Load(object sender, EventArgs e)
        {
            pnlDetalii.Visible = false;
            lstIntrTest.Items.Clear();
            lstTeste.Items.Clear();
            txtDenumTest.Text = "";
            txtCapitol.Text = "";
            txtLectie.Text = "";

            //se adauga testele in ListBox
            MySqlConnection conexiune = new MySqlConnection();
            conexiune.ConnectionString = @"SERVER=localhost; DATABASE=softeducational; UID=root; PASSWORD=; Allow User Variables=True";
            conexiune.Open(); //Se deschide conexiunea

            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conexiune;
            cmd.CommandText = "SELECT * FROM teste WHERE idProfesor=@idProf";
            cmd.Parameters.AddWithValue("idProf", this.Tag.ToString());

            MySqlDataReader r = cmd.ExecuteReader();
            while (r.Read())
            {
                Teste test = new Teste();
                {
                    test.idTest = r["idTest"].ToString();
                    test.denumire = r["denumire"].ToString();
                    test.idProfesor = r["idProfesor"].ToString();
                    test.capitol = r["capitol"].ToString();
                    test.lectie = r["lectie"].ToString();
                }
                lstTeste.Items.Add(test);
            }
            r.Close();
            conexiune.Close();
        }

        private void lstTeste_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lstTeste.SelectedIndex!=-1)
            {
                pnlDetalii.Visible = true;

                Teste test = lstTeste.SelectedItem as Teste;
                txtDenumTest.Text = test.denumire;
                txtCapitol.Text = test.capitol;
                txtLectie.Text = test.lectie;

                //se adauga intrebarile in ListBox
                MySqlConnection conexiune = new MySqlConnection();
                conexiune.ConnectionString = @"SERVER=localhost; DATABASE=softeducational; UID=root; PASSWORD=; Allow User Variables=True";
                conexiune.Open(); //Se deschide conexiunea

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexiune;
                cmd.CommandText = "SELECT * FROM continut_teste JOIN intrebari ON continut_teste.idIntrebare=intrebari.idIntrebare WHERE idTest=@pidTest";
                cmd.Parameters.AddWithValue("pidTest", test.idTest);
                MySqlDataReader r = cmd.ExecuteReader();
                while(r.Read())
                {
                    lstIntrTest.Items.Add(r["intrebare"].ToString());
                }
                r.Close();
                conexiune.Close();

            }
            else
            {
                MessageBox.Show("Selectati testul pe care doriti sa il stergeti.");
            }
        }

        private void btnSalveazaModif_Click(object sender, EventArgs e)
        {
            Teste test = lstTeste.SelectedItem as Teste;

            //se sterge testul din baza de date
            MySqlConnection conexiune = new MySqlConnection();
            conexiune.ConnectionString = @"SERVER=localhost; DATABASE=softeducational; UID=root; PASSWORD=; Allow User Variables=True";
            conexiune.Open(); //Se deschide conexiunea

            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conexiune;
            cmd.CommandText = "DELETE FROM teste WHERE idTest=@pidTest";
            cmd.Parameters.AddWithValue("pidTest", test.idTest);
            cmd.ExecuteNonQuery();

            cmd.CommandText = "DELETE FROM continut_teste WHERE idTest=@pidT";
            cmd.Parameters.AddWithValue("pidT", test.idTest);
            cmd.ExecuteNonQuery();

            conexiune.Close();
            MessageBox.Show("Testul a fost sters cu succes.");

            FrmStergeTest_Load(sender, e);

        }
    }
}
