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
    public partial class FrmModifOrdCapitole : Form
    {
        public FrmModifOrdCapitole()
        {
            InitializeComponent();
        }

        private void FrmModifOrdCapitole_Load(object sender, EventArgs e)
        {
            lstCapitole.Items.Clear();
            lstIdc.Items.Clear();

            MySqlConnection conexiune = new MySqlConnection();
            conexiune.ConnectionString = @"SERVER=localhost; DATABASE=softeducational; UID=root; PASSWORD=; Allow User Variables=True";
            conexiune.Open(); //Se deschide conexiunea

            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conexiune;
            cmd.CommandText = "SELECT * FROM capitole";

            MySqlDataReader r = cmd.ExecuteReader();
            while(r.Read())
            {
                Capitole c = new Capitole();
                {
                    c.idC = r["idC"].ToString();
                    c.titlu = r["titlu"].ToString();
                }
                lstCapitole.Items.Add(c);
            }
            r.Close();
            conexiune.Close();
        }

        private void btnSus_Click(object sender, EventArgs e)
        {
            if (lstCapitole.SelectedIndex > 0)
            {
                int index = lstCapitole.SelectedIndex;
                Capitole capitol = lstCapitole.SelectedItem as Capitole;

                lstCapitole.Items[index] = lstCapitole.Items[index - 1];
                lstCapitole.Items[index - 1] = capitol;

                lstCapitole.SelectedIndex = index - 1;
                lstCapitole.Update();
                lstCapitole.Focus();
            }
            else
            {
                if (lstCapitole.SelectedIndex == -1)
                {
                    MessageBox.Show("Selectati capitolul pe care doriti sa il mutati cu o pozitie mai sus.");
                }
                else
                {
                    MessageBox.Show("Nu puteti efectua aceasta modificare.");
                }
            }
        }

        private void btnJos_Click(object sender, EventArgs e)
        {
            if (lstCapitole.SelectedIndex < lstCapitole.Items.Count - 1 && lstCapitole.SelectedIndex != -1)
            {
                int index = lstCapitole.SelectedIndex;
                Capitole capitol = lstCapitole.SelectedItem as Capitole;


                lstCapitole.Items[index] = lstCapitole.Items[index + 1];
                lstCapitole.Items[index + 1] = capitol;

                lstCapitole.SelectedIndex = index + 1;
                lstCapitole.Update();
                lstCapitole.Focus();
            }
            else
            {
                if (lstCapitole.SelectedIndex == -1)
                {
                    MessageBox.Show("Selectati capitolul pe care doriti sa il mutati cu o pozitie mai jos.");
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
            cmd.CommandText = "SELECT * FROM capitole";

            int index = 0;

            MySqlDataReader read = cmd.ExecuteReader();
            while(read.Read())
            {
                Capitole c = lstCapitole.Items[index] as Capitole;
                lstIdc.Items.Add(c);

                MySqlConnection con = new MySqlConnection();
                con.ConnectionString = @"SERVER=localhost; DATABASE=softeducational; UID=root; PASSWORD=; Allow User Variables=True";
                con.Open(); //Se deschide conexiunea

                MySqlCommand cmm = new MySqlCommand();
                cmm.Connection = con;
                cmm.CommandText = "UPDATE capitole SET  titlu=@ptitlu WHERE idC=@pid"; 
                cmm.Parameters.AddWithValue("ptitlu", c.titlu);
                cmm.Parameters.AddWithValue("pid", read["idC"].ToString());
                cmm.ExecuteNonQuery();
                con.Close();
                index++;
            }
            read.Close();


            
            cmd.CommandText = "SELECT * FROM capitole";
            MySqlDataReader r = cmd.ExecuteReader();
            index = 0;
            while(r.Read())
            {
                MySqlConnection con = new MySqlConnection();
                con.ConnectionString = @"SERVER=localhost; DATABASE=softeducational; UID=root; PASSWORD=; Allow User Variables=True";
                con.Open(); //Se deschide conexiunea

                MySqlCommand cmm = new MySqlCommand();
                cmm.Connection = con;
                cmm.CommandText = "UPDATE capitole SET idC=@pidC WHERE titlu=@titlu";
                Capitole capitol = lstIdc.Items[index] as Capitole;
                cmm.Parameters.AddWithValue("pidC",capitol.idC);
                cmm.Parameters.AddWithValue("titlu", capitol.titlu);
                cmm.ExecuteNonQuery();
                con.Close();
                index++;
            }
            r.Close();
            conexiune.Close();
            


            MessageBox.Show("Modificarile au fost salvate cu succes.");
            this.Close();
        }
    }
}
