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
    public partial class FrmTeste : Form
    {
        public FrmTeste()
        {
            InitializeComponent();

        }

        int intr = 0;
        private void FrmTeste_Load(object sender, EventArgs e)
        {

            lblIntrGresite.Visible = false;

            lstIntrebariGresite.Visible = false;
            pnlRaspCorecte.Visible = false;
            lblRC1.Text = lblRC2.Text = lblRC3.Text = "";
            lstIntrebariGresite.Items.Clear();
            lstIntrebari.Items.Clear();

            //pnl rasp text scurt
            pnlRaspTextScurt.Visible = false;
            pnlRaspTextScurt.Location = new Point(93, 50);
            pnlRaspTextScurt.Size = new Size(671, 380);

            //pnl rasp unic
            pnlRaspUnic.Visible = false;
            pnlRaspUnic.Location = new Point(93, 50);
            pnlRaspUnic.Size = new Size(668, 450);

            //pnl rasp multiplu
            pnlRaspMultiplu.Visible = false;
            pnlRaspMultiplu.Location = new Point(93, 50);
            pnlRaspMultiplu.Size = new Size(699, 441);

            btnIntrAnt.Visible = btnIntrUrm.Visible = btnVerifica.Visible = false;
            btnVerifica.Location = btnIntrUrm.Location;

            


            Intr();

            incarcaIntr();

            //this.Refresh();
        }

        string[] rasp1 = new string[100];
        string[] rasp2 = new string[100];
        string[] rasp3 = new string[100];
        string[] idIntr = new string[100];
        string[] tipIntr = new string[100];

        void incarcaRaspSalvat()
        {
             
            //incarca rasp
            if (rasp1[intr]!=null && rasp2[intr]!=null && rasp3[intr]!=null && idIntr[intr]!=null)
            {
                if (tipIntr[intr]=="text scurt")
                {
                    txtRaspuns.Text = rasp1[intr].ToString();
                }
                else
                {
                    if (tipIntr[intr]=="unic")
                    {
                        if (rasp1[intr]=="da")
                        {
                            rbVar1.Checked = true;
                        }
                        else
                        {
                            rbVar1.Checked = false;
                        }

                        if (rasp2[intr]=="da")
                        {
                            rbVar2.Checked = true;
                        }
                        else
                        {
                            rbVar2.Checked = false;
                        }

                        if (rasp3[intr]=="da")
                        {
                            rbVar3.Checked = true;
                        }
                        else
                        {
                            rbVar3.Checked = false;
                        }
                    }

                    if (tipIntr[intr]=="multiplu")
                    {
                        if (rasp1[intr] == "da")
                        {
                            cbVar1.Checked = true;
                        }
                        else
                        {
                            cbVar1.Checked = false;
                        }

                        if (rasp2[intr] == "da")
                        {
                            cbVar2.Checked = true;
                        }
                        else
                        {
                            cbVar2.Checked = false;
                        }

                        if (rasp3[intr] == "da")
                        {
                            cbVar3.Checked = true;
                        }
                        else
                        {
                            cbVar3.Checked = false;
                        }
                    }
                }
            }
            else
            {
                reset();
            }
        }

        void salveazaRasp()
        {
            MySqlConnection conexiune = new MySqlConnection();
            conexiune.ConnectionString = @"SERVER=localhost; DATABASE=softeducational; UID=root; PASSWORD=; Allow User Variables=True";
            conexiune.Open(); //Se deschide conexiunea

            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conexiune;
            cmd.CommandText = "SELECT * FROM raspunsuri WHERE idIntrebare=@pidIntr";

            Intrebari intrebare = lstIntrebari.Items[intr] as Intrebari;
            cmd.Parameters.AddWithValue("pidIntr", intrebare.idIntrebare);

            MySqlDataReader r = cmd.ExecuteReader();
            int cate = 0;
            while (r.Read())
            {
                Raspunsuri raspuns = new Raspunsuri();
                {
                    raspuns.raspuns = r["raspuns"].ToString();
                    raspuns.tipRaspuns = r["tipRaspuns"].ToString();
                    
                }

                if (cate == intr)
                {
                    
                    if (raspuns.tipRaspuns == "text scurt")
                    {
                        rasp1[intr] = txtRaspuns.Text;
                        rasp2[intr] = "nu";
                        rasp3[intr] = "nu";

                        idIntr[intr] = r["idIntrebare"].ToString();

                        tipIntr[intr] = "text scurt";

                        MessageBox.Show("Se salveaza");
                    }
                    else
                    {
                        if (raspuns.tipRaspuns == "unic")
                        {
                            if(rbVar1.Checked==true)
                            {
                                rasp1[intr] = "da";
                            }
                            else
                            {
                                rasp1[intr] = "nu";
                            }

                            if (rbVar2.Checked == true)
                            {
                                rasp2[intr] = "da";
                            }
                            else
                            {
                                rasp2[intr] = "nu";
                            }

                            if (rbVar3.Checked == true)
                            {
                                rasp3[intr] = "da";
                            }
                            else
                            {
                                rasp3[intr] = "nu";
                            }

                            idIntr[intr] = r["idIntrebare"].ToString();

                            tipIntr[intr] = "unic";
                        }
                        
                        if(raspuns.tipRaspuns == "multiplu")
                        {
                            if (cbVar1.Checked == true)
                            {
                                rasp1[intr] = "da";
                            }
                            else
                            {
                                rasp1[intr] = "nu";
                            }

                            if (cbVar2.Checked == true)
                            {
                                rasp2[intr] = "da";
                            }
                            else
                            {
                                rasp2[intr] = "nu";
                            }

                            if (cbVar3.Checked == true)
                            {
                                rasp3[intr] = "da";
                            }
                            else
                            {
                                rasp3[intr] = "nu";
                            }

                            idIntr[intr] = r["idIntrebare"].ToString();

                            tipIntr[intr] = "multiplu";
                        }
                    }
                }
                else
                {
                    cate++;
                    if (cate == intr)
                    {

                        if (raspuns.tipRaspuns == "text scurt")
                        {
                            rasp1[intr] = txtRaspuns.Text;
                            rasp2[intr] = "nu";
                            rasp3[intr] = "nu";

                            idIntr[intr] = r["idIntrebare"].ToString();

                            tipIntr[intr] = "text scurt";
                        }
                        else
                        {
                            if (raspuns.tipRaspuns == "unic")
                            {
                                if (rbVar1.Checked == true)
                                {
                                    rasp1[intr] = "da";
                                }
                                else
                                {
                                    rasp1[intr] = "nu";
                                }

                                if (rbVar2.Checked == true)
                                {
                                    rasp2[intr] = "da";
                                }
                                else
                                {
                                    rasp2[intr] = "nu";
                                }

                                if (rbVar3.Checked == true)
                                {
                                    rasp3[intr] = "da";
                                }
                                else
                                {
                                    rasp3[intr] = "nu";
                                }

                                idIntr[intr] = r["idIntrebare"].ToString();

                                tipIntr[intr] = "unic";
                            }

                            if (raspuns.tipRaspuns == "multiplu")
                            {
                                if (cbVar1.Checked == true)
                                {
                                    rasp1[intr] = "da";
                                }
                                else
                                {
                                    rasp1[intr] = "nu";
                                }

                                if (cbVar2.Checked == true)
                                {
                                    rasp2[intr] = "da";
                                }
                                else
                                {
                                    rasp2[intr] = "nu";
                                }

                                if (cbVar3.Checked == true)
                                {
                                    rasp3[intr] = "da";
                                }
                                else
                                {
                                    rasp3[intr] = "nu";
                                }

                                idIntr[intr] = r["idIntrebare"].ToString();

                                tipIntr[intr] = "multiplu";
                            }
                        }
                    }
                    else
                    {
                        cate++;
                    }
                }
                
            }
            r.Close();
            conexiune.Close();

        }

        void incarcaIntr()
        {
            MySqlConnection conexiune = new MySqlConnection();
            conexiune.ConnectionString = @"SERVER=localhost; DATABASE=softeducational; UID=root; PASSWORD=; Allow User Variables=True";
            conexiune.Open(); //Se deschide conexiunea

            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conexiune;
            cmd.CommandText = "SELECT * FROM raspunsuri WHERE idIntrebare=@pidIntr";

            Intrebari intrebare = lstIntrebari.Items[intr] as Intrebari;
            cmd.Parameters.AddWithValue("pidIntr", intrebare.idIntrebare);

            int poz = 1;
            MySqlDataReader r = cmd.ExecuteReader();
            while(r.Read())
            {

                Raspunsuri raspuns = new Raspunsuri();
                {
                    raspuns.raspuns = r["raspuns"].ToString();
                    raspuns.tipRaspuns = r["tipRaspuns"].ToString();
                }

                if (raspuns.tipRaspuns == "text scurt")
                {
                    pnlRaspTextScurt.Visible = true;
                    pnlRaspMultiplu.Visible = pnlRaspUnic.Visible = false;

                    rtbIntrebareTS.Text = intrebare.intrebare;

                    txtRaspuns.Text = "";
                    break;
                }
                else
                {
                    if (raspuns.tipRaspuns == "unic")
                    {

                        pnlRaspUnic.Visible = true;
                        pnlRaspTextScurt.Visible = pnlRaspMultiplu.Visible = false;

                        rbVar1.Checked = false;
                        rbVar2.Checked = false;
                        rbVar3.Checked = false;

                        if (poz == 1)
                        {
                            rtbIntrebareRU.Text = intrebare.intrebare;

                            rbVar1.Text = r["raspuns"].ToString();
                            poz++;
                        }
                        else
                        {
                            if (poz == 2)
                            {
                                rbVar2.Text = r["raspuns"].ToString();
                                poz++;
                            }
                            else
                            {
                                rbVar3.Text = r["raspuns"].ToString();
                                break;
                            }
                        }
                    }
                    else
                    {
                        pnlRaspMultiplu.Visible = true;
                        pnlRaspTextScurt.Visible = pnlRaspUnic.Visible = false;

                        cbVar1.Checked = false;
                        cbVar2.Checked = false;
                        cbVar3.Checked = false;

                        if (poz == 1)
                        {
                            rtbIntrebareRM.Text = intrebare.intrebare;

                            cbVar1.Text = r["raspuns"].ToString();
                            poz++;
                        }
                        else
                        {
                            if (poz == 2)
                            {
                                cbVar2.Text = r["raspuns"].ToString();
                                poz++;
                            }
                            else
                            {
                                cbVar3.Text = r["raspuns"].ToString();
                                break;
                            }
                        }
                    }
                }
            }
            conexiune.Close();

            if(intr<lstIntrebari.Items.Count-1)
            {
                btnIntrUrm.Visible = true;
                btnVerifica.Visible = false;
            }
            else
            {
                btnIntrUrm.Visible = false;
                btnVerifica.Visible = true;
            }

            if(intr>0)
            {
                btnIntrAnt.Visible = true;
            }
            else
            {
                btnIntrAnt.Visible = false;
            }

        }

        void Intr()
        {
            lstIntrebari.Items.Clear();

            MySqlConnection conexiune = new MySqlConnection();
            conexiune.ConnectionString = @"SERVER=localhost; DATABASE=softeducational; UID=root; PASSWORD=; Allow User Variables=True";
            conexiune.Open(); //Se deschide conexiunea

            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conexiune;
            cmd.CommandText = "SELECT * FROM continut_teste JOIN intrebari ON continut_teste.idIntrebare=intrebari.idIntrebare WHERE continut_teste.idTest=@pid";
            cmd.Parameters.AddWithValue("pid", this.Tag.ToString());

            MySqlDataReader r = cmd.ExecuteReader();
            while(r.Read())
            {
                Intrebari intr = new Intrebari();
                {
                    intr.idIntrebare = r["idIntrebare"].ToString();
                    intr.intrebare = r["intrebare"].ToString();
                }

                lstIntrebari.Items.Add(intr);
                lstIntrebariGresite.Items.Add(intr);
            }
            r.Close();
            conexiune.Close();
        }

        void reset()
        {
          
            txtRaspuns.Text = "";

          
            rbVar1.Checked = rbVar2.Checked = rbVar3.Checked = false;

            
            cbVar1.Checked = cbVar2.Checked = cbVar3.Checked = false;
        }

        
        void verificaTest()
        {
            int punctaj = 0;
            for(int i=0;i<lstIntrebari.Items.Count;i++)
            {
                MySqlConnection conexiune = new MySqlConnection();
                conexiune.ConnectionString = @"SERVER=localhost; DATABASE=softeducational; UID=root; PASSWORD=; Allow User Variables=True";
                conexiune.Open(); //Se deschide conexiunea

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexiune;
                cmd.CommandText = "SELECT * FROM raspunsuri WHERE idIntrebare=@pidIntr";
                Intrebari intrebare = lstIntrebari.Items[i] as Intrebari;
                cmd.Parameters.AddWithValue("pidIntr",intrebare.idIntrebare.ToString());
                cmd.Parameters.AddWithValue("pid", this.Tag.ToString());

                MySqlDataReader r = cmd.ExecuteReader();
                while(r.Read())
                {
                    if (rasp1[i]!=null && rasp2[i]!=null && rasp2[3]!=null)
                    {
                        if (tipIntr[i]=="text scurt" && rasp1[i] == r["raspuns"].ToString())
                        {
                            punctaj++;
                        }
                        else
                        {
                            if (tipIntr[i]=="unic" || tipIntr[i]=="multiplu")
                            {
                                if (rasp1[i] == r["corect"].ToString())
                                {
                                    r.Read();
                                    if (rasp2[i] == r["corect"].ToString())
                                    {
                                        r.Read();
                                        if (rasp3[i] == r["corect"].ToString())
                                        {
                                            punctaj++;
                                            lstIntrebariGresite.Items[i] = "DE STERS";
                                            //gresite[i] = "nu";
                                        }
                                        else
                                        {
                                            break;
                                        }
                                    }
                                    else
                                    {
                                        break;
                                    }
                                }
                                else
                                {
                                    
                                    break;
                                }
                            }
                            
                        }
                    }
                }
                r.Close();
                conexiune.Close();
            }
            MessageBox.Show("Punctaj: " + punctaj.ToString() + "/" + lstIntrebari.Items.Count);
        }

        private void btnIntrUrm_Click(object sender, EventArgs e)
        {
            if (txtRaspuns.Text != "" || (cbVar1.Checked == true || cbVar2.Checked == true || cbVar3.Checked == true) || (rbVar1.Checked==true || rbVar2.Checked==true || rbVar3.Checked==true))
            {
                salveazaRasp();
            }
            
            //MessageBox.Show(intr.ToString());
            intr++;
            incarcaIntr();
            incarcaRaspSalvat();

            //MessageBox.Show(intr.ToString());
        }

        private void btnIntrAnt_Click(object sender, EventArgs e)
        {
            if (txtRaspuns.Text != "" || (cbVar1.Checked == true || cbVar2.Checked == true || cbVar3.Checked == true) || (rbVar1.Checked == true || rbVar2.Checked == true || rbVar3.Checked == true))
            {
                salveazaRasp();
            }
            //MessageBox.Show(intr.ToString());
            intr--;
            incarcaIntr();
            incarcaRaspSalvat();

            //MessageBox.Show(intr.ToString());
        }

        private void btnVerifica_Click(object sender, EventArgs e)
        {
            salveazaRasp();
            verificaTest();

            pnlRaspMultiplu.Visible = pnlRaspTextScurt.Visible = pnlRaspUnic.Visible = btnIntrAnt.Visible = btnIntrUrm.Visible = btnVerifica.Visible = false;
            
            for(int i=0;i<lstIntrebariGresite.Items.Count;i++)
            {
                if (lstIntrebariGresite.Items[i].ToString() == "DE STERS")
                {
                    lstIntrebariGresite.Items.Remove(lstIntrebariGresite.Items[i]);
                    i--;
                }
            }

            lstIntrebariGresite.Visible = true;
            lblIntrGresite.Visible = true;

        }

        private void lstIntrebariGresite_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lstIntrebariGresite.SelectedIndex!=-1)
            {
                pnlRaspCorecte.Visible = true;

                Intrebari intrebare = lstIntrebariGresite.SelectedItem as Intrebari;

                MySqlConnection conexiune = new MySqlConnection();
                conexiune.ConnectionString = @"SERVER=localhost; DATABASE=softeducational; UID=root; PASSWORD=; Allow User Variables=True";
                conexiune.Open(); //Se deschide conexiunea

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexiune;
                cmd.CommandText = "SELECT * FROM raspunsuri WHERE idIntrebare=@pidIntr";
                cmd.Parameters.AddWithValue("pidIntr", intrebare.idIntrebare);

                MySqlDataReader r = cmd.ExecuteReader();
                while(r.Read())
                {
                    Raspunsuri rasp = new Raspunsuri();
                    {
                        rasp.raspuns = r["raspuns"].ToString();
                        rasp.tipRaspuns = r["tipRaspuns"].ToString();
                        rasp.corect = r["corect"].ToString();
                    }

                    if(rasp.tipRaspuns=="text scurt")
                    {
                        lblRC1.Text = rasp.raspuns;
                        lblRC1.Visible = true;
                        lblRC2.Visible = lblRC3.Visible = false;

                        break;
                    }
                    else
                    {
                        if(rasp.tipRaspuns=="unic")
                        {
                            lblRC1.Visible = true;
                            lblRC2.Visible = lblRC3.Visible = false;

                            if(rasp.corect=="da")
                            {
                                lblRC1.Text = rasp.raspuns;
                                break;
                            }
                            else
                            {
                                r.Read();
                                rasp.raspuns = r["raspuns"].ToString();
                                rasp.tipRaspuns = r["tipRaspuns"].ToString();
                                rasp.corect = r["corect"].ToString();

                                if(rasp.corect=="da")
                                {
                                    lblRC1.Text = rasp.raspuns;
                                    break;
                                }
                                else
                                {
                                    r.Read();
                                    rasp.raspuns = r["raspuns"].ToString();
                                    rasp.tipRaspuns = r["tipRaspuns"].ToString();
                                    rasp.corect = r["corect"].ToString();

                                    lblRC1.Text = rasp.raspuns;
                                    break;
                                }

                            }
                        }
                        else
                        {
                            if(rasp.corect=="da")
                            {
                                //rasp 1
                                lblRC1.Visible = true;
                                lblRC2.Visible = lblRC3.Visible = false;

                                lblRC1.Text = rasp.raspuns;

                                //rasp 2 (corect?)
                                r.Read();
                                rasp.raspuns = r["raspuns"].ToString();
                                rasp.tipRaspuns = r["tipRaspuns"].ToString();
                                rasp.corect = r["corect"].ToString();
                                
                                if(rasp.corect=="da")
                                {
                                    lblRC2.Visible = true;
                                    lblRC2.Text = rasp.raspuns;

                                    //rasp 3 (corect?)
                                    r.Read();
                                    rasp.raspuns = r["raspuns"].ToString();
                                    rasp.tipRaspuns = r["tipRaspuns"].ToString();
                                    rasp.corect = r["corect"].ToString();

                                    if(rasp.corect=="da")
                                    {
                                        lblRC3.Visible = true;
                                        lblRC3.Text = rasp.raspuns;

                                        break;
                                    }
                                }
                                else
                                {
                                    //rasp 3 (corect?)
                                    r.Read();
                                    rasp.raspuns = r["raspuns"].ToString();
                                    rasp.tipRaspuns = r["tipRaspuns"].ToString();
                                    rasp.corect = r["corect"].ToString();

                                    if (rasp.corect == "da")
                                    {
                                        lblRC2.Visible = true;
                                        lblRC2.Text = rasp.raspuns;

                                        break;
                                    }
                                }

                            }
                            else
                            {
                                //rasp 2 (corect?)
                                r.Read();
                                rasp.raspuns = r["raspuns"].ToString();
                                rasp.tipRaspuns = r["tipRaspuns"].ToString();
                                rasp.corect = r["corect"].ToString();

                                if (rasp.corect == "da")
                                {
                                    lblRC1.Visible = true;
                                    lblRC1.Text = rasp.raspuns;

                                    //rasp 3 (corect?)
                                    r.Read();
                                    rasp.raspuns = r["raspuns"].ToString();
                                    rasp.tipRaspuns = r["tipRaspuns"].ToString();
                                    rasp.corect = r["corect"].ToString();

                                    if (rasp.corect == "da")
                                    {
                                        lblRC2.Visible = true;
                                        lblRC2.Text = rasp.raspuns;

                                        break;
                                    }
                                }
                                else
                                {
                                    //rasp 3 (corect?)
                                    r.Read();
                                    rasp.raspuns = r["raspuns"].ToString();
                                    rasp.tipRaspuns = r["tipRaspuns"].ToString();
                                    rasp.corect = r["corect"].ToString();

                                    if (rasp.corect == "da")
                                    {
                                        lblRC1.Visible = true;
                                        lblRC1.Text = rasp.raspuns;

                                        break;
                                    }
                                }
                            }
                        }
                    }
                }
                r.Close();
                conexiune.Close();
            }
            else
            {
                MessageBox.Show("Selectati intrebarea la care ati raspuns gresit si doriti sa vedeti raspunsul corect.");
            }
        }
    }
}
