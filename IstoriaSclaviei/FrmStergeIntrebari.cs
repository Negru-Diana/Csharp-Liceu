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
    public partial class FrmStergeIntrebari : Form
    {
        public FrmStergeIntrebari()
        {
            InitializeComponent();
        }

        private void FrmStergeIntrebari_Load(object sender, EventArgs e)
        {
            lstIntrebari.Items.Clear();

            pnlIntrebare.Visible = false;
            pnlIntrebare.Location = new Point(410, 72);
            pnlIntrebare.Size = new Size(615, 141);

            btnStergIntr.Visible = false;
            btnStergIntr.Location = new Point(812, 662);

            pnlRaspMultiplu.Visible = pnlRaspUnic.Visible = pnlTextScurt.Visible = false;
            pnlRaspMultiplu.Location = pnlRaspUnic.Location = pnlTextScurt.Location = new Point(410, 224);
            pnlRaspMultiplu.Size = pnlRaspUnic.Size = pnlTextScurt.Size = new Size(615, 476);

            //Se creeaza conexiunea la baza de date
            MySqlConnection conexiune = new MySqlConnection();
            conexiune.ConnectionString = @"SERVER=localhost; DATABASE=softeducational; UID=root; PASSWORD=; Allow User Variables=True";
            conexiune.Open(); //Se deschide conexiunea

            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conexiune;
            cmd.CommandText = "SELECT * FROM intrebari";

            MySqlDataReader r = cmd.ExecuteReader();

            int ok = 0;

            
            while (r.Read())
            {
                Intrebari intr = new Intrebari();
                {
                    intr.idIntrebare = r["idIntrebare"].ToString();
                    intr.idProfesor = r["idProfesor"].ToString();
                    intr.intrebare = r["intrebare"].ToString();
                    intr.capitol = r["capitol"].ToString();
                    intr.lectie = r["lectie"].ToString();
                }
                

                if (intr.idProfesor == this.Tag.ToString())
                {
                    lstIntrebari.Items.Add(intr);
                    ok++;
                }
            }
            r.Close();

            if (ok == 0)
            {
                MessageBox.Show("Nu aveti incarcate intrebari pe care sa le puteti sterge.");
                this.Close();
            }
            conexiune.Close();
        }

        private void btnStergIntr_Click(object sender, EventArgs e)
        {
            if (rtbIntrebare.Text != "" && lstIntrebari.SelectedIndex != -1)
            {
                //MessageBox.Show(rtbIntrebare.Tag.ToString());
                
                MySqlConnection conexiune = new MySqlConnection();
                conexiune.ConnectionString = @"SERVER=localhost; DATABASE=softeducational; UID=root; PASSWORD=; Allow User Variables=True";
                conexiune.Open(); //Se deschide conexiunea

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexiune;
                cmd.CommandText = "DELETE FROM intrebari WHERE idIntrebare=@pidIntr";

                cmd.Parameters.AddWithValue("pidIntr", rtbIntrebare.Tag.ToString());
                cmd.ExecuteNonQuery();

                cmd.CommandText = "DELETE FROM raspunsuri WHERE idIntrebare=@ppidIntr";

                cmd.Parameters.AddWithValue("ppidIntr", rtbIntrebare.Tag.ToString());
                cmd.ExecuteNonQuery();

                cmd.CommandText = "DELETE FROM teste WHERE idIntrebare=@idIntr";

                cmd.Parameters.AddWithValue("idIntr", rtbIntrebare.Tag.ToString());
                cmd.ExecuteNonQuery();

                MessageBox.Show("Intrebarea a fost stearsa cu succes!");
                pnlIntrebare.Visible = pnlRaspMultiplu.Visible = pnlRaspUnic.Visible = pnlTextScurt.Visible = false;
                btnStergIntr.Visible = false;
                

                FrmStergeIntrebari_Load(sender, e);
            }

        }

        private void lstIntrebari_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstIntrebari.SelectedIndex != -1)
            {
                btnStergIntr.Visible = true;

                Intrebari intr = lstIntrebari.SelectedItem as Intrebari;

                pnlIntrebare.Visible = true;
                rtbIntrebare.Tag = intr.idIntrebare.ToString();
                //MessageBox.Show(rtbIntrebare.Tag.ToString());
                rtbIntrebare.Text = intr.intrebare.ToString();

                //se incarca raspunsurile
                MySqlConnection conexiune = new MySqlConnection();
                conexiune.ConnectionString = @"SERVER=localhost; DATABASE=softeducational; UID=root; PASSWORD=; Allow User Variables=True";
                conexiune.Open(); //Se deschide conexiunea

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexiune;
                cmd.CommandText = "SELECT * FROM raspunsuri WHERE idIntrebare=@pidIntrebare";
                cmd.Parameters.AddWithValue("pidIntrebare", rtbIntrebare.Tag.ToString());

                int ok = 1;

                MySqlDataReader r = cmd.ExecuteReader();
                while (r.Read())
                {
                    Raspunsuri rasp = new Raspunsuri();
                    {
                        rasp.idRaspuns = r["idRaspuns"].ToString();
                        rasp.idIntrebare = r["idIntrebare"].ToString();
                        rasp.raspuns = r["raspuns"].ToString();
                        rasp.tipRaspuns = r["tipRaspuns"].ToString();
                        rasp.corect = r["corect"].ToString();
                    }

                    if (rasp.tipRaspuns == "text scurt")
                    {
                        pnlTextScurt.Visible = true;
                        pnlRaspUnic.Visible = pnlRaspMultiplu.Visible = false;

                        txtRaspTextScurt.Text = rasp.raspuns.ToString();

                    }
                    else
                    {
                        if (rasp.tipRaspuns == "unic")
                        {
                            pnlRaspUnic.Visible = true;
                            pnlTextScurt.Visible = pnlRaspMultiplu.Visible =  false;

                            if (ok == 1)
                            {
                                rtbVar1.Text = rasp.raspuns.ToString();
                                rtbVar1.Tag = rasp.idRaspuns.ToString();
                                rbVar1.Text = rtbVar1.Text.ToString();
                                if (rasp.corect == "da")
                                {
                                    rbVar1.Checked = true;
                                }
                                else
                                {
                                    rbVar1.Checked = false;
                                }
                            }
                            else
                            {
                                if (ok == 2)
                                {
                                    rtbVar2.Text = rasp.raspuns.ToString();
                                    rtbVar2.Tag = rasp.idRaspuns.ToString();
                                    rbVar2.Text = rtbVar2.Text.ToString();
                                    if (rasp.corect == "da")
                                    {
                                        rbVar2.Checked = true;
                                    }
                                    else
                                    {
                                        rbVar2.Checked = false;
                                    }
                                }
                                else
                                {
                                    if (ok == 3)
                                    {
                                        rtbVar3.Text = rasp.raspuns.ToString();
                                        rtbVar3.Tag = rasp.idRaspuns.ToString();
                                        rbVar3.Text = rtbVar3.Text.ToString();
                                        if (rasp.corect == "da")
                                        {
                                            rbVar3.Checked = true;
                                        }
                                        else
                                        {
                                            rbVar3.Checked = false;
                                        }
                                    }
                                }
                            }
                            ok++;
                        }
                        else
                        {
                            pnlRaspMultiplu.Visible = true;
                            pnlTextScurt.Visible = pnlRaspUnic.Visible =  false;

                            if (ok == 1)
                            {
                                rtbMV1.Text = rasp.raspuns.ToString();
                                rtbMV1.Tag = rasp.idRaspuns.ToString();
                                cbV1.Text = rtbMV1.Text;
                                if (rasp.corect == "da")
                                {
                                    cbV1.Checked = true;
                                }
                                else
                                {
                                    cbV1.Checked = false;
                                }
                            }
                            else
                            {
                                if (ok == 2)
                                {
                                    rtbMV2.Text = rasp.raspuns.ToString();
                                    rtbMV2.Tag = rasp.idRaspuns.ToString();
                                    cbV2.Text = rtbMV2.Text;
                                    if (rasp.corect == "da")
                                    {
                                        cbV2.Checked = true;
                                    }
                                    else
                                    {
                                        cbV2.Checked = false;
                                    }
                                }
                                else
                                {
                                    if (ok == 3)
                                    {
                                        rtbMV3.Text = rasp.raspuns.ToString();
                                        rtbMV3.Tag = rasp.idRaspuns.ToString();
                                        cbV3.Text = rtbMV3.Text;
                                        if (rasp.corect == "da")
                                        {
                                            cbV3.Checked = true;
                                        }
                                        else
                                        {
                                            cbV3.Checked = false;
                                        }
                                    }
                                }
                            }

                            ok++;
                        }
                    }
                }
                conexiune.Close();

                
            }
        }
    }
}
