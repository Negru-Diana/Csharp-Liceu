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
    public partial class FrmSchhimbaParola : Form
    {
        public FrmSchhimbaParola()
        {
            InitializeComponent();
        }

        private void cbParola_CheckedChanged(object sender, EventArgs e)
        {
            if (cbParola.Checked == true)
            {
                txtParola.PasswordChar = '\0';

            }
            else
            {
                txtParola.PasswordChar = '*';

            }
        }

        private void cbConfParola_CheckedChanged(object sender, EventArgs e)
        {
            if (cbConfParola.Checked == true)
            {
                txtConfParola.PasswordChar = '\0';

            }
            else
            {
                txtConfParola.PasswordChar = '*';

            }
        }

        private void FrmSchhimbaParola_Load(object sender, EventArgs e)
        {
            txtConfParola.Text = "";
            txtParola.Text = "";
            cbConfParola.Checked = cbParola.Checked = false;

            txtParola.PasswordChar = '*';
            txtConfParola.PasswordChar = '*';
        }

        private void btnSchimbaParola_Click(object sender, EventArgs e)
        {
            if(txtParola.Text==txtConfParola.Text && txtParola.TextLength >= 8)
            {
                MySqlConnection conexiune = new MySqlConnection();
                conexiune.ConnectionString = @"SERVER=localhost; DATABASE=softeducational; UID=root; PASSWORD=; Allow User Variables=True";
                conexiune.Open(); //Se deschide conexiunea

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexiune;
                cmd.CommandText = "UPDATE conturi SET parola=@pparola WHERE id=@pid";
                cmd.Parameters.AddWithValue("pparola", txtParola.Text);
                cmd.Parameters.AddWithValue("pid", this.Tag.ToString());
                cmd.ExecuteNonQuery();
                conexiune.Close();
                MessageBox.Show("Parola a fost modificata cu succes.");
                this.Close();
            }
            else
            {
                if(txtParola.Text != txtConfParola.Text)
                {
                    MessageBox.Show("Parolele nu corespund.");
                }
                else
                {
                    
                    MessageBox.Show("Parola trebuie sa contina minim 8 caractere.");
                }
            }
        }
    }
}
