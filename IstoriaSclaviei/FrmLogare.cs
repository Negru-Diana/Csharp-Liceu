using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace IstoriaSclaviei
{
    public partial class FrmLogare : Form
    {
        public FrmLogare()
        {
            InitializeComponent();
        }

        private void FrmLogare_Load(object sender, EventArgs e)
        {
            txtNume.Text = "Pop Anca";
            txtParola.Text = "popANCA00";
            txtParola.PasswordChar = '*';
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

        private void btnCreeazaCont_Click(object sender, EventArgs e)
        {
            FrmContNou cn = new FrmContNou();
            cn.Location = this.Location;
            cn.Tag = this;
            cn.Show();
            this.Hide();
        }

        private void btnLogare_Click(object sender, EventArgs e)
        {
            if(txtNume.Text!="" && txtParola.Text!="")
            {
                //Se creeaza conexiunea la baza de date
                MySqlConnection conexiune = new MySqlConnection();
                conexiune.ConnectionString = @"SERVER=localhost; DATABASE=softeducational; UID=root; PASSWORD=; Allow User Variables=True";
                conexiune.Open(); //Se deschide conexiunea

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexiune;
                cmd.CommandText = "SELECT * FROM conturi";


                int ok = 0;
                //Se executa comanda si se depune in r rezultatul 
                MySqlDataReader r = cmd.ExecuteReader();
                while (r.Read())
                {
                    Conturi x = new Conturi();
                    {
                        x.id = r.GetString("id");
                        x.utilizator = r.GetString("utilizator");
                        x.email = r.GetString("email");
                        x.parola = r.GetString("parola");
                        x.drepturi = r.GetString("drepturi");

                       
                    };

                    if ((x.utilizator == txtNume.Text || x.email==txtNume.Text) && x.parola == txtParola.Text)
                    {
                        MySqlConnection con = new MySqlConnection();
                        con.ConnectionString = @"SERVER=localhost; DATABASE=softeducational; UID=root; PASSWORD=; Allow User Variables=True";
                        con.Open(); //Se deschide conexiunea

                        
                        //se modifica data la care s-a facut ultima logare
                        MySqlCommand cmm = new MySqlCommand();
                        cmm.Connection = con;
                        cmm.CommandText = "UPDATE conturi SET ultimaLOGARE=now() WHERE (utilizator=@pUtilizator OR email=@pEmail) AND parola=@pparola";
                        cmm.Parameters.AddWithValue("pUtilizator", txtNume.Text);
                        cmm.Parameters.AddWithValue("pEmail", txtNume.Text);
                        cmm.Parameters.AddWithValue("pparola", txtParola.Text);
                        cmm.ExecuteNonQuery();
                        con.Close();
                        //MessageBox.Show("Data a fost modificata");
                        

                        FrmMain main = new FrmMain();
                        main.Tag = this;
                        main.Text = x.id;
                        main.Show();
                        this.Hide();
                        ok = 1;
                    }
                    else
                    {
                        if ((x.utilizator == txtNume.Text || x.email==txtNume.Text) && x.parola != txtParola.Text)
                        {
                            MessageBox.Show("Parola introdusa este incorecta.");
                            ok = 1;
                        }
                    }
                }

                if(ok==0)
                {
                    MessageBox.Show("Numele de utilizator este gresit sau contul nu exista.");
                }

                r.Close();
                conexiune.Close();
            }
            else
            {
                MessageBox.Show("Toate campurile trebuie completate inainte de a continua.");
            }
        }

        private void FrmLogare_FormClosed(object sender, FormClosedEventArgs e)
        {
            if((this.Tag as FrmContNou)!=null)
            {
                (this.Tag as FrmContNou).Close();
            }

            if ((this.Tag as FrmMain) != null)
            {
                (this.Tag as FrmMain).Close();
            }
        }
    }
}
