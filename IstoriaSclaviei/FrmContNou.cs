using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace IstoriaSclaviei
{
    public partial class FrmContNou : Form
    {
        public FrmContNou()
        {
            InitializeComponent();
        }

        private void FrmContNou_Load(object sender, EventArgs e)
        {
            txtNume.Text = "";
            txtEmail.Text = "";
            txtParola.Text = "";
            txtParola.PasswordChar = '*';
            txtConfParola.Text = "";
            txtConfParola.PasswordChar = '*';
            cbCont.Text = "Alege";
        }

        private void btnRenunta_Click(object sender, EventArgs e)
        {
            FrmLogare log = new FrmLogare();
            log.Show();
            log.Tag = this;
            this.Hide();
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

        private void btnCreeazaCont_Click(object sender, EventArgs e)
        {
            if(txtNume.Text!="" && txtParola.Text==txtConfParola.Text && txtParola.Text!="" && cbCont.SelectedIndex!= -1 && txtParola.TextLength>=8 && txtEmail.Text!="")
            {
                //Se creeaza conexiunea la baza de date
                MySqlConnection conexiune = new MySqlConnection();
                conexiune.ConnectionString = @"SERVER=localhost; DATABASE=softeducational; UID=root; PASSWORD=; Allow User Variables=True";
                conexiune.Open(); //Se deschide conexiunea

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexiune;
                cmd.CommandText = @"INSERT INTO conturi(utilizator,email, parola, drepturi) VALUES(@putilizator,@pemail, @pparola, @pdrepturi);";
                //Se stabilesc parametrii comenzii in ordine
                cmd.Parameters.AddWithValue("putilizator", txtNume.Text);
                cmd.Parameters.AddWithValue("pemail", txtEmail.Text);
                cmd.Parameters.AddWithValue("pparola", txtParola.Text);
                cmd.Parameters.AddWithValue("pdrepturi", cbCont.Text);

                //Se executa comanda si se verifica daca rezultatul este nenul
                if (cmd.ExecuteNonQuery() != 0)
                {
                    MessageBox.Show("Contul a fost creat cu succes!");
                    FrmLogare log = new FrmLogare();
                    log.Show();
                    log.Tag = this;
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Din cauza unor probleme, contul nu a putut fi creat. Va rugam, sa incercati din nou.");
                }
                conexiune.Close();
            }
            else
            {
                if (txtNume.Text == "" || txtConfParola.Text=="" || txtParola.Text == "" || cbCont.SelectedIndex == -1 || txtEmail.Text=="")
                {
                    MessageBox.Show("Trebuie completate toate casutele inainte de a va putea crea un cont!");
                }
                else
                {
                    if(txtParola.TextLength<8)
                    {
                        MessageBox.Show("Parola trebuie sa aiba minim 8 caractere.");
                    }
                    else
                    {
                        if (txtParola.Text != txtConfParola.Text)
                        {
                            MessageBox.Show("Parolele nu coincid.");
                        }
                    }
                   
                   
                }
            }
        }

        private void FrmContNou_FormClosed(object sender, FormClosedEventArgs e)
        {
            if((this.Tag as FrmLogare)!=null)
            {
                (this.Tag as FrmLogare).Close();
            }
        }
    }
}
