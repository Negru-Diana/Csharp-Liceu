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
    public partial class FrmNotificari : Form
    {
        public FrmNotificari()
        {
            InitializeComponent();
        }

        private void FrmNotificari_Load(object sender, EventArgs e)
        {
            lstNotif.Items.Clear();
            lstidNotif.Items.Clear();

            //Se creeaza conexiunea la baza de date
            MySqlConnection conexiune = new MySqlConnection();
            conexiune.ConnectionString = @"SERVER=localhost; DATABASE=softeducational; UID=root; PASSWORD=; Allow User Variables=True";
            conexiune.Open(); //Se deschide conexiunea

            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conexiune;
            cmd.CommandText = "SELECT * FROM notificari WHERE idCont=@pid";
            cmd.Parameters.AddWithValue("pid", this.Tag.ToString());

            MySqlDataReader r = cmd.ExecuteReader();
            while(r.Read())
            {
                Notificari notif = new Notificari();
                {
                    notif.id = r["id"].ToString();
                    notif.idCont = r["idCont"].ToString();
                    notif.tipNotificare = r["tipNotificare"].ToString();
                    notif.idLectie = r["idLectie"].ToString();
                    notif.idTest = r["idTest"].ToString();
                    notif.idIntrebare = r["idIntrebare"].ToString();

                    if (notif.tipNotificare == "adaugareLectie" || notif.tipNotificare=="modifLectie")
                    {
                        if(notif.tipNotificare == "adaugareLectie")
                        {
                            notif.text = "A fost adaugata lectia ";
                        }
                        else
                        {
                            notif.text = "A fost modificata lectia ";
                        }

                        MySqlConnection con = new MySqlConnection();
                        con.ConnectionString = @"SERVER=localhost; DATABASE=softeducational; UID=root; PASSWORD=; Allow User Variables=True";
                        con.Open(); //Se deschide conexiunea

                        MySqlCommand cm = new MySqlCommand();
                        cm.Connection = con;
                        cm.CommandText = "SELECT * FROM lectii WHERE idL=@pid";
                        cm.Parameters.AddWithValue("pid", notif.idLectie);
                        MySqlDataReader read = cm.ExecuteReader();
                        while(read.Read())
                        {
                            notif.text += read["titlu"].ToString();
                            break;
                        }
                        read.Close();
                        cm.Parameters.Clear();
                        con.Close();
                    }
                    else
                    {
                        if(notif.tipNotificare=="adaugareTest" || notif.tipNotificare=="modifTest")
                        {
                            if(notif.tipNotificare== "adaugareTest")
                            {
                                notif.text = "A fost adaugat testul ";
                            }
                            else
                            {
                                notif.text = "A fost modificat testul ";
                            }

                            MySqlConnection con = new MySqlConnection();
                            con.ConnectionString = @"SERVER=localhost; DATABASE=softeducational; UID=root; PASSWORD=; Allow User Variables=True";
                            con.Open(); //Se deschide conexiunea

                            MySqlCommand cm = new MySqlCommand();
                            cm.Connection = con;
                            cm.CommandText = "SELECT * FROM teste WHERE idTest=@pid";
                            cm.Parameters.AddWithValue("pid", notif.idTest);
                            MySqlDataReader read = cm.ExecuteReader();
                            while (read.Read())
                            {
                                notif.text += read["denumire"].ToString();
                                break;
                            }
                            read.Close();
                            cm.Parameters.Clear();
                            con.Close();
                        }
                        else
                        {
                            //verific daca contul este de profesor
                            MySqlConnection conn = new MySqlConnection();
                            conn.ConnectionString = @"SERVER=localhost; DATABASE=softeducational; UID=root; PASSWORD=; Allow User Variables=True";
                            conn.Open(); //Se deschide conexiunea

                            MySqlCommand cmdd = new MySqlCommand();
                            cmdd.Connection = conn;
                            cmdd.CommandText = "SELECT * FROM conturi WHERE id=@idCont";
                            cmdd.Parameters.AddWithValue("idCont", this.Tag.ToString());
                            MySqlDataReader rr = cmdd.ExecuteReader();
                            rr.Read();
                            int drept = 0;
                            if (rr["drepturi"].ToString()=="profesor")
                            {
                                drept = 1;
                            }
                            rr.Close();
                            conn.Close();

                            if (drept==1)
                            {
                                if(notif.tipNotificare=="adaugaIntrebare")
                                {
                                    notif.text = "A fost adaugata intrebarea ";
                                }
                                else
                                {
                                    notif.text = "A fost modificata intrebarea ";
                                }

                                MySqlConnection con = new MySqlConnection();
                                con.ConnectionString = @"SERVER=localhost; DATABASE=softeducational; UID=root; PASSWORD=; Allow User Variables=True";
                                con.Open(); //Se deschide conexiunea

                                MySqlCommand cm = new MySqlCommand();
                                cm.Connection = con;
                                cm.CommandText = "SELECT * FROM intrebari WHERE idIntrebare=@pid";
                                cm.Parameters.AddWithValue("pid", notif.idIntrebare);
                                MySqlDataReader read = cm.ExecuteReader();
                                while (read.Read())
                                {
                                    notif.text += read["intrebare"].ToString();
                                    break;
                                }
                                read.Close();
                                cm.Parameters.Clear();
                                con.Close();

                            }
                        }

                        
                    }

                    
                }

                if(notif.ToString()!=null)
                {
                    lstNotif.Items.Add(notif.ToString());
                    lstidNotif.Items.Add(notif.id);
                }
                
            }

            if(lstNotif.Items.Count==0)
            {
                MessageBox.Show("Nu aveti notificari noi.");
                this.Close();
            }
        }

        private void lstNotif_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lstNotif.SelectedIndex!=-1)
            {
                MySqlConnection conexiune = new MySqlConnection();
                conexiune.ConnectionString = @"SERVER=localhost; DATABASE=softeducational; UID=root; PASSWORD=; Allow User Variables=True";
                conexiune.Open(); //Se deschide conexiunea

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexiune;
                cmd.CommandText = "SELECT * FROM notificari WHERE idCont=@pid AND id=@pidNotif";
                cmd.Parameters.AddWithValue("pid", this.Tag.ToString());
                cmd.Parameters.AddWithValue("pidNotif", lstidNotif.Items[lstNotif.SelectedIndex]);
                MySqlDataReader r = cmd.ExecuteReader();
                r.Read();
                if (r["tipNotificare"].ToString()=="adaugareLectie" || r["tipNotificare"].ToString()=="modifLectie")
                {
                    FrmLectii fl = new FrmLectii();
                    fl.MdiParent = this.MdiParent;
                    fl.Tag = r["idLectie"].ToString();
                    fl.Show();
                    this.Close();
                }
                else
                {
                    if (r["tipNotificare"].ToString() == "adaugareTest" || r["tipNotificare"].ToString() == "modifTest")
                    {
                        FrmTeste ft = new FrmTeste();
                        ft.MdiParent = this.MdiParent;
                        ft.Tag = r["idTest"].ToString();
                        ft.Show();
                        this.Close();
                    }
                }

                MySqlConnection con = new MySqlConnection();
                con.ConnectionString = @"SERVER=localhost; DATABASE=softeducational; UID=root; PASSWORD=; Allow User Variables=True";
                con.Open(); //Se deschide conexiunea

                MySqlCommand cmm = new MySqlCommand();
                cmm.Connection = con;
                cmm.CommandText ="DELETE FROM notificari WHERE id=@pidNotif";
                cmm.Parameters.AddWithValue("pidNotif", lstidNotif.Items[lstNotif.SelectedIndex]);
                cmm.ExecuteNonQuery();
                con.Close();

                r.Close();
                conexiune.Close();

                FrmNotificari_Load(sender, e);
            }
        }
    }
}
