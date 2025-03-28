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
    public partial class FrmJoc : Form
    {
        public FrmJoc()
        {
            InitializeComponent();
        }
        PictureBox selectat;
        Image[] imagini = new Image[10];

        private void FrmJoc_Load(object sender, EventArgs e)
        {
            reset();

            pnlIntrebari.Location = new Point(554, 76);
            pnlIntrebari.Size = new Size(600, 535);

            pnlRaspTextScurt.Location = new Point(12, 30);
            pnlRaspUnic.Location = pnlRaspMultiplu.Location = new Point(9, 17);

            pnlRaspTextScurt.Size = new Size(658, 406);
            pnlRaspUnic.Size = pnlRaspMultiplu.Size = new Size(658, 406);

            lblGreseli.Text = gresite.ToString() + "/9";

            IncarcaPuzzle();
            IncarcareListaIntrebari();
            incarcaIntrebare();
        }

        void IncarcareListaIntrebari()
        {
            lstIntrebari.Items.Clear();

            MySqlConnection conexiune = new MySqlConnection();
            conexiune.ConnectionString = @"SERVER=localhost; DATABASE=softeducational; UID=root; PASSWORD=; Allow User Variables=True";
            conexiune.Open(); //Se deschide conexiunea

            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conexiune;
            cmd.CommandText = "SELECT * FROM intrebari";

            MySqlDataReader r = cmd.ExecuteReader();
            while(r.Read())
            {
                Intrebari intr = new Intrebari();
                {
                    intr.idIntrebare = r["idIntrebare"].ToString();
                    intr.intrebare = r["intrebare"].ToString();
                }
                lstIntrebari.Items.Add(intr);
            }
            r.Close();
            conexiune.Close();
        }

        void StopJoc()
        {
            if(gresite==9)
            {
                MessageBox.Show("Ai pierdut! Mai invata, apoi hai sa ne jucam!");
                this.Close();
            }
        }

        void incarcaIntrebare()
        {
            pnlIntrebari.Visible = true;

            pb1.Enabled = pb2.Enabled = pb3.Enabled = false;
            pb4.Enabled = pb5.Enabled = pb6.Enabled = false;
            pb7.Enabled = pb8.Enabled = pb9.Enabled = false;

            
            Random r = new Random();
            if(lstIntrebari.Items.Count>0)
            {
                int i = r.Next(0, lstIntrebari.Items.Count - 1);

                MySqlConnection conexiune = new MySqlConnection();
                conexiune.ConnectionString = @"SERVER=localhost; DATABASE=softeducational; UID=root; PASSWORD=; Allow User Variables=True";
                conexiune.Open(); //Se deschide conexiunea

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexiune;
                cmd.CommandText = "SELECT * FROM raspunsuri WHERE idIntrebare=@pidIntr";
                Intrebari intr = lstIntrebari.Items[i] as Intrebari;
                cmd.Parameters.AddWithValue("pidIntr", intr.idIntrebare);

                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    if (reader["tipRaspuns"].ToString() == "text scurt")
                    {
                        pnlRaspTextScurt.Visible = true;
                        pnlRaspUnic.Visible = pnlRaspMultiplu.Visible = false;

                        rtbIntrebareTS.Text = intr.intrebare;

                        txtRaspuns.Tag = reader["raspuns"].ToString();
                        break;
                    }
                    else
                    {
                        if (reader["tipRaspuns"].ToString() == "unic")
                        {
                            pnlRaspUnic.Visible = true;
                            pnlRaspTextScurt.Visible = pnlRaspMultiplu.Visible = false;

                            rtbIntrebareRU.Text = intr.intrebare;

                            rbVar1.Text = reader["raspuns"].ToString();
                            rbVar1.Tag = reader["corect"].ToString();

                            reader.Read();
                            rbVar2.Text = reader["raspuns"].ToString();
                            rbVar2.Tag = reader["corect"].ToString();

                            reader.Read();
                            rbVar3.Text = reader["raspuns"].ToString();
                            rbVar3.Tag = reader["corect"].ToString();

                            break;
                        }
                        else
                        {
                            pnlRaspMultiplu.Visible = true;
                            pnlRaspUnic.Visible = pnlRaspTextScurt.Visible = false;

                            rtbIntrebareRM.Text = intr.intrebare;

                            cbVar1.Text = reader["raspuns"].ToString();
                            cbVar1.Tag = reader["corect"].ToString();

                            reader.Read();
                            cbVar2.Text = reader["raspuns"].ToString();
                            cbVar2.Tag = reader["corect"].ToString();

                            reader.Read();
                            cbVar3.Text = reader["raspuns"].ToString();
                            cbVar3.Tag = reader["corect"].ToString();

                            break;
                        }
                    }
                }

                reader.Close();
                conexiune.Close();

                lstIntrebari.Items.Remove(lstIntrebari.Items[i]);
            }
            else
            {
                MessageBox.Show("Au intervenit niste probleme la incarcarea jocului. Va rugam reveniti mai tarziu.");
                this.Close();
            }
            

            

        }

        int gresite = 0;
        bool verificaIntrebare()
        {
            if(pnlRaspTextScurt.Visible==true)
            {
                if(txtRaspuns.Text!="")
                {
                    if(txtRaspuns.Text==txtRaspuns.Tag.ToString())
                    {
                        pnlIntrebari.Visible = false;
                        reset();
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Raspuns gresit.");
                        gresite++;
                        lblGreseli.Text = gresite.ToString() + "/9";
                        pnlIntrebari.Visible = false;
                        StopJoc();
                        reset();
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show("Trebuie sa raspundeti la intrebare.");
                }
            }
            else
            {
                if(pnlRaspUnic.Visible==true)
                {
                    if(rbVar1.Checked==true || rbVar2.Checked==true || rbVar3.Checked==true)
                    {
                        if (rbVar1.Checked == true && rbVar1.Tag.ToString() == "da")
                        {
                            pnlIntrebari.Visible = false;
                            reset();
                            return true;
                        }
                        else
                        {
                            if (rbVar2.Checked == true && rbVar2.Tag.ToString() == "da")
                            {
                                pnlIntrebari.Visible = false;
                                reset();
                                return true;
                            }
                            else
                            {
                                if (rbVar3.Checked == true && rbVar3.Tag.ToString() == "da")
                                {
                                    pnlIntrebari.Visible = false;
                                    reset();
                                    return true;
                                }
                                else
                                {

                                    MessageBox.Show("Raspuns gresit.");
                                    gresite++;
                                    lblGreseli.Text = gresite.ToString() + "/9";
                                    pnlIntrebari.Visible = false;
                                    StopJoc();
                                    reset();
                                    return false;
                                }
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Trebuie sa raspundeti la intrebare.");
                    }
                }
                else
                {
                    if(cbVar1.Checked==true || cbVar2.Checked==true || cbVar3.Checked==true)
                    {
                        if(cbVar1.Checked==true && cbVar1.Tag.ToString()=="da" && cbVar2.Checked==false && cbVar2.Tag.ToString()=="nu" && cbVar3.Checked==false && cbVar3.Tag.ToString()=="nu")
                        {
                            pnlIntrebari.Visible = false;
                            reset();
                            return true;
                        }
                        else
                        {
                            if (cbVar1.Checked == false && cbVar1.Tag.ToString() == "nu" && cbVar2.Checked == true && cbVar2.Tag.ToString() == "da" && cbVar3.Checked == false && cbVar3.Tag.ToString() == "nu")
                            {
                                pnlIntrebari.Visible = false;
                                reset();
                                return true;
                            }
                            else
                            {
                                if (cbVar1.Checked == false && cbVar1.Tag.ToString() == "nu" && cbVar2.Checked == false && cbVar2.Tag.ToString() == "nu" && cbVar3.Checked == true && cbVar3.Tag.ToString() == "da")
                                {
                                    pnlIntrebari.Visible = false;
                                    reset();
                                    return true;
                                }
                                else
                                {
                                    if (cbVar1.Checked == true && cbVar1.Tag.ToString() == "da" && cbVar2.Checked == true && cbVar2.Tag.ToString() == "da" && cbVar3.Checked == false && cbVar3.Tag.ToString() == "nu")
                                    {
                                        pnlIntrebari.Visible = false;
                                        reset();
                                        return true;
                                    }
                                    else
                                    {
                                        if (cbVar1.Checked == true && cbVar1.Tag.ToString() == "da" && cbVar2.Checked == false && cbVar2.Tag.ToString() == "nu" && cbVar3.Checked == true && cbVar3.Tag.ToString() == "da")
                                        {
                                            pnlIntrebari.Visible = false;
                                            reset();
                                            return true;
                                        }
                                        else
                                        {
                                            if (cbVar1.Checked == false && cbVar1.Tag.ToString() == "nu" && cbVar2.Checked == true && cbVar2.Tag.ToString() == "da" && cbVar3.Checked == true && cbVar3.Tag.ToString() == "da")
                                            {
                                                pnlIntrebari.Visible = false;
                                                reset();
                                                return true;
                                            }
                                            else
                                            {
                                                if (cbVar1.Checked == true && cbVar1.Tag.ToString() == "da" && cbVar2.Checked == true && cbVar2.Tag.ToString() == "da" && cbVar3.Checked == true && cbVar3.Tag.ToString() == "da")
                                                {
                                                    pnlIntrebari.Visible = false;
                                                    reset();
                                                    return true;
                                                }
                                                else
                                                {
                                                    MessageBox.Show("Raspuns gresit.");
                                                    gresite++;
                                                    lblGreseli.Text = gresite.ToString() + "/9";
                                                    pnlIntrebari.Visible = false;
                                                    StopJoc();
                                                    reset();
                                                    return false;
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }

            return false;
        }

        void reset()
        {
            pnlIntrebari.Visible = false;
            pnlRaspMultiplu.Visible = pnlRaspTextScurt.Visible = pnlRaspUnic.Visible = false;

            rtbIntrebareRM.Text = rtbIntrebareRU.Text = rtbIntrebareTS.Text = "";
            rbVar1.Checked = rbVar2.Checked = rbVar3.Checked = false;
            cbVar1.Checked = cbVar2.Checked = cbVar3.Checked = false;

            rbVar1.Checked = rbVar2.Checked = rbVar3.Checked = false;
            cbVar1.Checked = cbVar2.Checked = cbVar3.Checked = false;
            txtRaspuns.Text = "";
        }

        void Afisare()
        {
            for (int i = 1; i <= 9; i++)
            {
                (Controls["pb" + i] as PictureBox).Image = imagini[(int)(Controls["pb" + i] as PictureBox).Tag];
            }
        }

        void IncarcaPuzzle()
        {
            Random r = new Random();
            int folder = r.Next(1, 3);
            for (int i = 1; i <= 9; i++)
            {
                imagini[i] = new Bitmap(@"Puzzle\" + folder.ToString() + @"\" + i + ".jpg");
                (Controls["pb" + i] as PictureBox).Tag = i;
            }
            Afisare();

            for (int i=1;i<=9;i++)
            {
                int nou = r.Next(1, i);
                int aux = (int)(Controls["pb" + nou] as PictureBox).Tag;
                (Controls["pb" + nou] as PictureBox).Tag = (Controls["pb" + i] as PictureBox).Tag;
                (Controls["pb" + i] as PictureBox).Tag = aux;
            }
            Afisare();

        }

        bool Verificare()
        {
            int ok = 0;
            for (int i = 1; i <= 9; i++)
            {
                if ((int)(Controls["pb" + i] as PictureBox).Tag == i)
                {
                    ok++;
                }
            }

            if (ok == 9)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void pb_Click(object sender, EventArgs e)
        {
           
            if (selectat == null)
            {
                selectat = (sender as PictureBox);
            }
            else
            {
                int aux = (int)selectat.Tag;
                selectat.Tag = (int)(sender as PictureBox).Tag;
                (sender as PictureBox).Tag = aux;
                selectat = null;

                Afisare();
                if (Verificare())
                {
                    MessageBox.Show("Felicitari! Puzzle-ul este rezolvat corect!");
                }

                incarcaIntrebare();

                /*
                pb1.Enabled = pb2.Enabled = pb3.Enabled = false;
                pb4.Enabled = pb5.Enabled = pb6.Enabled = false;
                pb7.Enabled = pb8.Enabled = pb9.Enabled = false;
                */

                /*
                if (corect == true && click==1)
                {
                    Afisare();
                    if (Verificare())
                    {
                        MessageBox.Show("Felicitari! Puzzle-ul este rezolvat corect!");
                    }
                    click = 0;
                }
                */
            }
        }

        bool corect;
        //int click = 0;
        private void btnVerifica_Click(object sender, EventArgs e)
        {
            corect = verificaIntrebare();

            if(corect==true)
            {
                MessageBox.Show("Felicitari! Ai raspuns corect.");

                pb1.Enabled = pb2.Enabled = pb3.Enabled = true;
                pb4.Enabled = pb5.Enabled = pb6.Enabled = true;
                pb7.Enabled = pb8.Enabled = pb9.Enabled = true;
            }
            else
            {
                incarcaIntrebare();
            }
            

           
        }
    }
}
