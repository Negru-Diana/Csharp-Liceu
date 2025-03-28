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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace IstoriaSclaviei
{
    public partial class FrmAdaugaIntrebari : Form
    {
        public FrmAdaugaIntrebari()
        {
            InitializeComponent();
        }

        private void FrmAdaugaIntrebari_Load(object sender, EventArgs e)
        {
            rbTextScurt.Checked = rbRaspUnic.Checked = rbRaspMultiplu.Checked = false;

            cbCapitole.Items.Clear();
            cbLectii.Items.Clear();

            cbCapitole.Text = cbLectii.Text = "";
            rtbIntrebare.Text = "";
            pnlIntrebare.Visible = true;
            pnlTextScurt.Visible = pnlRaspUnic.Visible = pnlRaspMultiplu.Visible = false;

            pnlTextScurt.Location = new Point(12, 230);
            pnlTextScurt.Size = new Size(1015, 293);
            txtRaspTextScurt.Text = "";

            pnlRaspUnic.Location = new Point(12, 207);
            pnlRaspUnic.Size = new Size(1015, 367);
            txtV1.Text = txtV2.Text = txtV3.Text = "";

            pnlRaspMultiplu.Location = new Point(12, 207);
            pnlRaspMultiplu.Size = new Size(1015, 366);
            txtMV1.Text = txtMV2.Text = txtMV3.Text = "";

            //Se incarca capitolele in ComboBox
            cbCapitole.Items.Add("General");

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

            //se adauga lectiile in ComboBox
            cbLectii.Items.Add("General");

            //Se creeaza conexiunea la baza de date
            conexiune.Open(); //Se deschide conexiunea

            cmd.Connection = conexiune;
            cmd.CommandText = "SELECT * FROM lectii";

            //Se executa comanda si se depune in r rezultatul 
            r = cmd.ExecuteReader();
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
                cbLectii.Items.Add(lectie);
                /*
                if (lectie.idC == capitol.idC)
                {
                    cbLectii.Items.Add(lectie);
                }
                */
            }
            r.Close();
            conexiune.Close();
        }

        private void rbTextScurt_CheckedChanged(object sender, EventArgs e)
        {
            pnlRaspMultiplu.Visible = pnlRaspUnic.Visible = false;
            txtV1.Text = txtV2.Text = txtV3.Text = "";
            txtMV1.Text = txtMV2.Text = txtMV3.Text = "";

            pnlTextScurt.Visible = true;
        }

        private void rbRaspUnic_CheckedChanged(object sender, EventArgs e)
        {
            pnlRaspMultiplu.Visible = pnlTextScurt.Visible = false;
            txtMV1.Text = txtMV2.Text = txtMV3.Text = "";
            txtRaspTextScurt.Text = "";

            pnlRaspUnic.Visible = true;
        }

        private void rbRaspMultiplu_CheckedChanged(object sender, EventArgs e)
        {
            pnlTextScurt.Visible = pnlRaspUnic.Visible = false;
            txtRaspTextScurt.Text = "";
            txtV1.Text = txtV2.Text = txtV3.Text = "";

            pnlRaspMultiplu.Visible = true;
        }

        string idIntr;
        private void btnAdIntr_Click(object sender, EventArgs e)
        {
            if(cbCapitole.Text=="")
            {
                cbCapitole.Text = "General";
            }
            if(cbLectii.Text=="")
            {
                cbLectii.Text = "General";
            }

            if(rtbIntrebare.Text!="" && ((txtV1.Text!="" && txtV2.Text!="" && txtV3.Text!="" && (rbVar1.Checked==true || rbVar2.Checked==true || rbVar3.Checked==true)) || (txtMV1.Text!="" && txtMV2.Text!="" && txtMV3.Text!="" && (cbV1.Checked==true || cbV2.Checked==true || cbV3.Checked==true)) || txtRaspTextScurt.Text!=""))
            {
                //Se creeaza conexiunea la baza de date
                MySqlConnection conexiune = new MySqlConnection();
                conexiune.ConnectionString = @"SERVER=localhost; DATABASE=softeducational; UID=root; PASSWORD=; Allow User Variables=True";
                conexiune.Open(); //Se deschide conexiunea

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexiune;
                cmd.CommandText = @"INSERT INTO intrebari (idProfesor,intrebare,capitol,lectie) VALUES (@pidProfesor, @pintrebare, @pcapitol, @plectie)";

                cmd.Parameters.AddWithValue("pidProfesor", this.Tag);
                cmd.Parameters.AddWithValue("pintrebare", rtbIntrebare.Text);
                cmd.Parameters.AddWithValue("pcapitol", cbCapitole.Text);
                cmd.Parameters.AddWithValue("plectie", cbLectii.Text);
                cmd.ExecuteNonQuery();

                cmd.CommandText = "SELECT * FROM intrebari";
                MySqlDataReader r = cmd.ExecuteReader();

                while (r.Read())
                {
                    if (r["idProfesor"].ToString() == this.Tag.ToString() && r["intrebare"].ToString() == rtbIntrebare.Text)
                    {
                        idIntr = r["idIntrebare"].ToString();
                        break;
                    }
                }
                r.Close();

                if (rbTextScurt.Checked == true)
                {
                    cmd.CommandText = @"INSERT INTO raspunsuri (idIntrebare, raspuns, tipRaspuns,corect) VALUES (@ppidIntrebare, @praspuns, @ptipRaspuns, @pcorect)";

                    cmd.Parameters.AddWithValue("ppidIntrebare", idIntr);
                    cmd.Parameters.AddWithValue("praspuns", txtRaspTextScurt.Text);
                    cmd.Parameters.AddWithValue("ptipRaspuns", "text scurt");
                    cmd.Parameters.AddWithValue("pcorect", "da");

                    cmd.ExecuteNonQuery();
                }

                if (rbRaspUnic.Checked == true)
                {
                    //se adauga prima varianta de raspuns
                    cmd.CommandText = @"INSERT INTO raspunsuri (idIntrebare, raspuns, tipRaspuns,corect) VALUES (@pp1idIntrebare, @p1raspuns, @p1tipRaspuns, @p1corect)";

                    cmd.Parameters.AddWithValue("pp1idIntrebare", idIntr);
                    cmd.Parameters.AddWithValue("p1raspuns", txtV1.Text);
                    cmd.Parameters.AddWithValue("p1tipRaspuns", "unic");
                    if (rbVar1.Checked == true)
                    {
                        cmd.Parameters.AddWithValue("p1corect", "da");
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("p1corect", "nu");
                    }

                    cmd.ExecuteNonQuery();

                    //se adauga a doua varianta de raspuns
                    cmd.CommandText = @"INSERT INTO raspunsuri (idIntrebare, raspuns, tipRaspuns,corect) VALUES (@pp2idIntrebare, @p2raspuns, @p2tipRaspuns, @p2corect)";

                    cmd.Parameters.AddWithValue("pp2idIntrebare", idIntr);
                    cmd.Parameters.AddWithValue("p2raspuns", txtV2.Text);
                    cmd.Parameters.AddWithValue("p2tipRaspuns", "unic");
                    if (rbVar2.Checked == true)
                    {
                        cmd.Parameters.AddWithValue("p2corect", "da");
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("p2corect", "nu");
                    }

                    cmd.ExecuteNonQuery();

                    //se adauga a treia varianta de raspuns
                    cmd.CommandText = @"INSERT INTO raspunsuri (idIntrebare, raspuns, tipRaspuns,corect) VALUES (@pp3idIntrebare, @p3raspuns, @p3tipRaspuns, @p3corect)";

                    cmd.Parameters.AddWithValue("pp3idIntrebare", idIntr);
                    cmd.Parameters.AddWithValue("p3raspuns", txtV3.Text);
                    cmd.Parameters.AddWithValue("p3tipRaspuns", "unic");
                    if (rbVar3.Checked == true)
                    {
                        cmd.Parameters.AddWithValue("p3corect", "da");
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("p3corect", "nu");
                    }

                    cmd.ExecuteNonQuery();
                }

                if (rbRaspMultiplu.Checked == true)
                {
                    //se adauga prima varianta de raspuns
                    cmd.CommandText = @"INSERT INTO raspunsuri (idIntrebare, raspuns, tipRaspuns,corect) VALUES (@ppidIntrebare, @praspuns, @ptipRaspuns, @pcorect)";

                    cmd.Parameters.AddWithValue("ppidIntrebare", idIntr);
                    cmd.Parameters.AddWithValue("praspuns", txtMV1.Text);
                    cmd.Parameters.AddWithValue("ptipRaspuns", "multiplu");
                    if (cbV1.Checked == true)
                    {
                        cmd.Parameters.AddWithValue("pcorect", "da");
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("pcorect", "nu");
                    }

                    cmd.ExecuteNonQuery();

                    //se adauga a doua varianta de raspuns
                    cmd.CommandText = @"INSERT INTO raspunsuri (idIntrebare, raspuns, tipRaspuns,corect) VALUES (@pp2idIntrebare, @p2raspuns, @p2tipRaspuns, @p2corect)";

                    cmd.Parameters.AddWithValue("pp2idIntrebare", idIntr);
                    cmd.Parameters.AddWithValue("p2raspuns", txtMV2.Text);
                    cmd.Parameters.AddWithValue("p2tipRaspuns", "multiplu");
                    if (cbV2.Checked == true)
                    {
                        cmd.Parameters.AddWithValue("p2corect", "da");
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("p2corect", "nu");
                    }

                    cmd.ExecuteNonQuery();

                    //se adauga a treia varianta de raspuns
                    cmd.CommandText = @"INSERT INTO raspunsuri (idIntrebare, raspuns, tipRaspuns,corect) VALUES (@pp3idIntrebare, @p3raspuns, @p3tipRaspuns, @p3corect)";

                    cmd.Parameters.AddWithValue("pp3idIntrebare", idIntr);
                    cmd.Parameters.AddWithValue("p3raspuns", txtMV3.Text);
                    cmd.Parameters.AddWithValue("p3tipRaspuns", "multiplu");
                    if (cbV3.Checked == true)
                    {
                        cmd.Parameters.AddWithValue("p3corect", "da");
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("p3corect", "nu");
                    }

                    cmd.ExecuteNonQuery();
                }
                conexiune.Close();
                MessageBox.Show("Intrebarea a fost adaugata cu succes!");

                //se adauga notificare pentru adaugare intrebare
                MySqlConnection c = new MySqlConnection();
                c.ConnectionString = @"SERVER=localhost; DATABASE=softeducational; UID=root; PASSWORD=; Allow User Variables=True";
                c.Open(); //Se deschide conexiunea

                MySqlCommand cmdd = new MySqlCommand();
                cmdd.Connection = c;
                cmdd.CommandText = @"INSERT INTO notificari (idCont,tipNotificare,idIntrebare) VALUES (@idCont,@ptip,@idIntr)";

                MySqlConnection conn = new MySqlConnection();
                conn.ConnectionString = @"SERVER=localhost; DATABASE=softeducational; UID=root; PASSWORD=; Allow User Variables=True";
                conn.Open(); //Se deschide conexiunea

                MySqlCommand cmm = new MySqlCommand();
                cmm.Connection = conn;
                cmm.CommandText = "SELECT * FROM conturi";
                MySqlDataReader read = cmm.ExecuteReader();
                while (read.Read())
                {
                    cmdd.Parameters.AddWithValue("idCont", read["id"].ToString());
                    cmdd.Parameters.AddWithValue("ptip", "adaugaIntrebare");
                    cmdd.Parameters.AddWithValue("idIntr", idIntr);
                    cmdd.ExecuteNonQuery();
                    cmdd.Parameters.Clear();
                }
                read.Close();
                conn.Close();

                FrmAdaugaIntrebari_Load(sender,e);
            }
            else
            {
                MessageBox.Show("Pentru a salva intrebarea, toate campurile trebuie completate OBLIGATORIU.");
            }
            
        }

        private void cbCapitole_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbCapitole.SelectedIndex!=-1 && cbCapitole.Text!="General")
            {
                cbLectii.Items.Clear();
                cbLectii.Items.Add("General");

                MySqlConnection conexiune = new MySqlConnection();
                conexiune.ConnectionString = @"SERVER=localhost; DATABASE=softeducational; UID=root; PASSWORD=; Allow User Variables=True";
                conexiune.Open(); //Se deschide conexiunea

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexiune;
                cmd.CommandText = "SELECT * FROM lectii";

                Capitole c = cbCapitole.SelectedItem as Capitole;

                MySqlDataReader r = cmd.ExecuteReader();
                while(r.Read())
                {
                    Lectii l = new Lectii();
                    {
                        l.idL = r["idL"].ToString();
                        l.idC = r["idC"].ToString();
                        l.titlu = r["titlu"].ToString();
                    }

                    if(c.idC==l.idC)
                    {
                        cbLectii.Items.Add(l);
                    }
                    
                }
                r.Close();
                conexiune.Close();
            }
        }
    }
}
