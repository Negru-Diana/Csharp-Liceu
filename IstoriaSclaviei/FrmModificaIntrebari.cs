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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace IstoriaSclaviei
{
    public partial class FrmModificaIntrebari : Form
    {
        public FrmModificaIntrebari()
        {
            InitializeComponent();
        }

        private void FrmModificaIntrebari_Load(object sender, EventArgs e)
        {
            //pnl-uri care se fac vizibile doar cand se selecteaza o intrebare din ListBox
            pnlIntrebare.Visible = pnlModifCL.Visible = pnlRaspMultiplu.Visible = pnlRaspUnic.Visible = pnlTextScurt.Visible = false;

            //locatie si marime pnl-uri
            pnlTextScurt.Location = pnlRaspUnic.Location = pnlRaspMultiplu.Location = pnlModifCL.Location = new Point(410, 224);
            pnlIntrebare.Location = new Point(410, 72);

            pnlTextScurt.Size = pnlRaspUnic.Size = pnlRaspMultiplu.Size = pnlModifCL.Size = new Size(615, 476);
            pnlIntrebare.Size = new Size(615, 141);

            //btn
            btnModifCL.Visible = btnModifIntr.Visible = false;

            //incarcare intrebari in ListBox + resetare lista
            lstIntrebari.Items.Clear();

            //Se creeaza conexiunea la baza de date
            MySqlConnection conexiune = new MySqlConnection();
            conexiune.ConnectionString = @"SERVER=localhost; DATABASE=softeducational; UID=root; PASSWORD=; Allow User Variables=True";
            conexiune.Open(); //Se deschide conexiunea

            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conexiune;
            cmd.CommandText = "SELECT * FROM intrebari WHERE idProfesor=@pidProfesor";
            cmd.Parameters.AddWithValue("pidProfesor", this.Tag.ToString());

            
            MySqlDataReader r = cmd.ExecuteReader();
            while(r.Read())
            {
                Intrebari intr = new Intrebari();
                {
                    intr.idIntrebare = r["idIntrebare"].ToString();
                    intr.idProfesor = r["idProfesor"].ToString();
                    intr.intrebare = r["intrebare"].ToString();
                    intr.capitol = r["capitol"].ToString();
                    intr.lectie = r["lectie"].ToString();
                }

                lstIntrebari.Items.Add(intr);
            }
            conexiune.Close();

            //MessageBox.Show(lstIntrebari.Items[1].ToString());

        }

        private void lstIntrebari_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lstIntrebari.SelectedIndex!=-1)
            {
                Intrebari intr = lstIntrebari.SelectedItem as Intrebari;

                btnModifCL.Visible = btnModifIntr.Visible = true;

                pnlIntrebare.Visible = true;
                rtbIntrebare.Tag = intr.idIntrebare.ToString();
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
                while(r.Read())
                {
                    Raspunsuri rasp = new Raspunsuri();
                    {
                        rasp.idRaspuns = r["idRaspuns"].ToString();
                        rasp.idIntrebare = r["idIntrebare"].ToString();
                        rasp.raspuns = r["raspuns"].ToString();
                        rasp.tipRaspuns = r["tipRaspuns"].ToString();
                        rasp.corect = r["corect"].ToString();
                    }

                    if(rasp.tipRaspuns == "text scurt")
                    {
                        pnlTextScurt.Visible = true;
                        pnlRaspUnic.Visible = pnlRaspMultiplu.Visible = pnlModifCL.Visible = false;

                        txtRaspTextScurt.Text = rasp.raspuns.ToString();
                        
                    }
                    else
                    {
                        if(rasp.tipRaspuns == "unic")
                        {
                            pnlRaspUnic.Visible = true;
                            pnlTextScurt.Visible = pnlRaspMultiplu.Visible = pnlModifCL.Visible = false;

                            if(ok==1)
                            {
                                rtbVar1.Text = rasp.raspuns.ToString();
                                rtbVar1.Tag = rasp.idRaspuns.ToString();
                                rbVar1.Text = rtbVar1.Text.ToString();
                                if(rasp.corect=="da")
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
                                if(ok==2)
                                {
                                    rtbVar2.Text = rasp.raspuns.ToString();
                                    rtbVar2.Tag = rasp.idRaspuns.ToString();
                                    rbVar2.Text = rtbVar2.Text.ToString();
                                    if (rasp.corect=="da")
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
                                    if(ok==3)
                                    {
                                        rtbVar3.Text = rasp.raspuns.ToString();
                                        rtbVar3.Tag = rasp.idRaspuns.ToString();
                                        rbVar3.Text = rtbVar3.Text.ToString();
                                        if (rasp.corect=="da")
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
                            pnlTextScurt.Visible = pnlRaspUnic.Visible = pnlModifCL.Visible = false;

                            if(ok==1)
                            {
                                rtbMV1.Text = rasp.raspuns.ToString();
                                rtbMV1.Tag = rasp.idRaspuns.ToString();
                                cbV1.Text = rtbMV1.Text;
                                if(rasp.corect=="da")
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

        private void btnModifIntr_Click(object sender, EventArgs e)
        {
            
            int invalid = 0;
            if(rtbIntrebare.Text!="")
            {
                MySqlConnection conexiune = new MySqlConnection();
                conexiune.ConnectionString = @"SERVER=localhost; DATABASE=softeducational; UID=root; PASSWORD=; Allow User Variables=True";
                conexiune.Open(); //Se deschide conexiunea

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexiune;
                cmd.CommandText = "UPDATE intrebari SET intrebare=@pintr WHERE idIntrebare=@pidIntr";
                cmd.Parameters.AddWithValue("pidIntr", rtbIntrebare.Tag.ToString());
                cmd.Parameters.AddWithValue("pintr", rtbIntrebare.Text);
                cmd.ExecuteNonQuery();
                conexiune.Close();
            }
            else
            {
                MessageBox.Show("Trebuie completate toate campurile inainte de a salva modificarile.");
                invalid = 1;
            }

            if(invalid==0 && pnlTextScurt.Visible==true && txtRaspTextScurt.Text!="")
            {
                MySqlConnection conexiune = new MySqlConnection();
                conexiune.ConnectionString = @"SERVER=localhost; DATABASE=softeducational; UID=root; PASSWORD=; Allow User Variables=True";
                conexiune.Open(); //Se deschide conexiunea

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexiune;
                cmd.CommandText = "UPDATE raspunsuri SET raspuns=@praspuns WHERE idIntrebare=@pidIntr";
                cmd.Parameters.AddWithValue("pidIntr", rtbIntrebare.Tag.ToString());
                cmd.Parameters.AddWithValue("praspuns", txtRaspTextScurt.Text);
                cmd.ExecuteNonQuery();
                conexiune.Close();

                MessageBox.Show("Datele au fost modificate cu succes.");

                //se adauga notificare pentru modificarea intrebarii
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
                    cmdd.Parameters.AddWithValue("ptip", "modifIntrebare");
                    cmdd.Parameters.AddWithValue("idIntr", rtbIntrebare.Tag.ToString());
                    cmdd.ExecuteNonQuery();
                    cmdd.Parameters.Clear();
                }
                read.Close();
                conn.Close();
            }
            else
            {
                if(invalid==0 && pnlRaspUnic.Visible==true && rtbVar1.Text!="" && rtbVar2.Text!="" && rtbVar3.Text!="" && (rbVar1.Checked==true || rbVar2.Checked==true || rbVar3.Checked==true))
                {
                    MySqlConnection con = new MySqlConnection();
                    con.ConnectionString = @"SERVER=localhost; DATABASE=softeducational; UID=root; PASSWORD=; Allow User Variables=True";
                    con.Open(); //Se deschide conexiunea

                    MySqlCommand comm = new MySqlCommand();
                    comm.Connection = con;
                    comm.CommandText = "SELECT * FROM raspunsuri WHERE idIntrebare=@pid";
                    comm.Parameters.AddWithValue("pid", rtbIntrebare.Tag.ToString());

                    //update tabel din baza de date
                    MySqlConnection conexiune = new MySqlConnection();
                    conexiune.ConnectionString = @"SERVER=localhost; DATABASE=softeducational; UID=root; PASSWORD=; Allow User Variables=True";
                    conexiune.Open(); //Se deschide conexiunea

                    MySqlCommand cmd = new MySqlCommand();
                    cmd.Connection = conexiune;


                    MySqlDataReader r = comm.ExecuteReader();
                    while(r.Read())
                    {
                        Raspunsuri rasp = new Raspunsuri();
                        {
                            rasp.idRaspuns = r["idRaspuns"].ToString();
                            rasp.idIntrebare = r["idIntrebare"].ToString();
                            rasp.raspuns = r["raspuns"].ToString();
                            rasp.tipRaspuns = r["tipRaspuns"].ToString();
                            rasp.corect = r["corect"].ToString();
                        }

                        if(rasp.idRaspuns==rtbVar1.Tag.ToString())
                        {
                            cmd.CommandText = "UPDATE raspunsuri SET raspuns=@pr1, corect=@c1 WHERE idIntrebare=@id1 AND idRaspuns=@idr1";
                            cmd.Parameters.AddWithValue("id1", rtbIntrebare.Tag.ToString());
                            cmd.Parameters.AddWithValue("pr1", rtbVar1.Text);
                            cmd.Parameters.AddWithValue("idr1", rtbVar1.Tag.ToString());
                            if (rbVar1.Checked == true)
                            {
                                cmd.Parameters.AddWithValue("c1", "da");
                                //MessageBox.Show("da");
                            }
                            else
                            {
                                cmd.Parameters.AddWithValue("c1", "nu");
                                //MessageBox.Show("nu");
                            }

                            //MessageBox.Show(rasp.idRaspuns.ToString() + " " + rtbVar1.Tag.ToString());
                        }
                        else
                        {
                            if(rasp.idRaspuns==rtbVar2.Tag.ToString())
                            {
                                cmd.CommandText = "UPDATE raspunsuri SET raspuns=@pr2, corect=@c2 WHERE idIntrebare=@id2 AND idRaspuns=@idr2";
                                cmd.Parameters.AddWithValue("id2", rtbIntrebare.Tag.ToString());
                                cmd.Parameters.AddWithValue("pr2", rtbVar2.Text);
                                cmd.Parameters.AddWithValue("idr2", rtbVar2.Tag.ToString());
                                if (rbVar2.Checked == true)
                                {
                                    cmd.Parameters.AddWithValue("c2", "da");

                                    //MessageBox.Show("da");
                                }
                                else
                                {
                                    cmd.Parameters.AddWithValue("c2", "nu");

                                    //MessageBox.Show("nu");
                                }

                                //MessageBox.Show(rasp.idRaspuns.ToString() + " " + rtbVar2.Tag.ToString());
                            }
                            else
                            {
                                if(rasp.idRaspuns==rtbVar3.Tag.ToString())
                                {
                                    cmd.CommandText = "UPDATE raspunsuri SET raspuns=@pr3, corect=@c3 WHERE idIntrebare=@id3 AND idRaspuns=@idr3";
                                    cmd.Parameters.AddWithValue("id3", rtbIntrebare.Tag.ToString());
                                    cmd.Parameters.AddWithValue("pr3", rtbVar3.Text);
                                    cmd.Parameters.AddWithValue("idr3", rtbVar3.Tag.ToString());
                                    if (rbVar3.Checked == true)
                                    {
                                        cmd.Parameters.AddWithValue("c3", "da");
                                        //MessageBox.Show("da");
                                    }
                                    else
                                    {
                                        cmd.Parameters.AddWithValue("c3", "nu");
                                        //MessageBox.Show("nu");
                                    }

                                    //MessageBox.Show(rasp.idRaspuns.ToString() + " " + rtbVar3.Tag.ToString());
                                }
                            }
                        }
                        cmd.ExecuteNonQuery();
                    }
                    conexiune.Close();
                    con.Close();
                    MessageBox.Show("Datele au fost modificate cu succes.");

                    //se adauga notificare pentru modificarea intrebarii
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
                        cmdd.Parameters.AddWithValue("ptip", "modifIntrebare");
                        cmdd.Parameters.AddWithValue("idIntr", rtbIntrebare.Tag.ToString());
                        cmdd.ExecuteNonQuery();
                        cmdd.Parameters.Clear();
                    }
                    read.Close();
                    conn.Close();
                }
                else
                {
                    if(invalid==0 && pnlRaspMultiplu.Visible==true && rtbMV1.Text!="" && rtbMV2.Text!="" && rtbMV3.Text!="" && (cbV1.Checked==true || cbV2.Checked==true || cbV3.Checked==true))
                    {
                        MySqlConnection con = new MySqlConnection();
                        con.ConnectionString = @"SERVER=localhost; DATABASE=softeducational; UID=root; PASSWORD=; Allow User Variables=True";
                        con.Open(); //Se deschide conexiunea

                        MySqlCommand comm = new MySqlCommand();
                        comm.Connection = con;
                        comm.CommandText = "SELECT * FROM raspunsuri WHERE idIntrebare=@pid";
                        comm.Parameters.AddWithValue("pid", rtbIntrebare.Tag.ToString());

                        //update tabel din baza de date
                        MySqlConnection conexiune = new MySqlConnection();
                        conexiune.ConnectionString = @"SERVER=localhost; DATABASE=softeducational; UID=root; PASSWORD=; Allow User Variables=True";
                        conexiune.Open(); //Se deschide conexiunea

                        MySqlCommand cmd = new MySqlCommand();
                        cmd.Connection = conexiune;


                        MySqlDataReader r = comm.ExecuteReader();
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

                            if(rasp.idRaspuns==rtbMV1.Tag.ToString())
                            {
                                cmd.CommandText = "UPDATE raspunsuri SET raspuns=@rm1, corect=@cm1 WHERE idIntrebare=@idm1 AND idRaspuns=@idrm1";
                                cmd.Parameters.AddWithValue("rm1", rtbMV1.Text);
                                if(cbV1.Checked==true)
                                {
                                    cmd.Parameters.AddWithValue("cm1", "da");
                                }
                                else
                                {
                                    cmd.Parameters.AddWithValue("cm1", "nu");
                                }
                                cmd.Parameters.AddWithValue("idm1", rtbIntrebare.Tag.ToString());
                                cmd.Parameters.AddWithValue("idrm1", rtbMV1.Tag.ToString());
                            }
                            else
                            {
                                if (rasp.idRaspuns == rtbMV2.Tag.ToString())
                                {
                                    cmd.CommandText = "UPDATE raspunsuri SET raspuns=@rm2, corect=@cm2 WHERE idIntrebare=@idm2 AND idRaspuns=@idrm2";
                                    cmd.Parameters.AddWithValue("rm2", rtbMV2.Text);
                                    if (cbV2.Checked == true)
                                    {
                                        cmd.Parameters.AddWithValue("cm2", "da");
                                    }
                                    else
                                    {
                                        cmd.Parameters.AddWithValue("cm2", "nu");
                                    }
                                    cmd.Parameters.AddWithValue("idm2", rtbIntrebare.Tag.ToString());
                                    cmd.Parameters.AddWithValue("idrm2", rtbMV2.Tag.ToString());
                                    
                                }
                                else
                                {
                                    if (rasp.idRaspuns == rtbMV3.Tag.ToString())
                                    {
                                        cmd.CommandText = "UPDATE raspunsuri SET raspuns=@rm3, corect=@cm3 WHERE idIntrebare=@idm3 AND idRaspuns=@idrm3";
                                        cmd.Parameters.AddWithValue("rm3", rtbMV3.Text);
                                        if (cbV3.Checked == true)
                                        {
                                            cmd.Parameters.AddWithValue("cm3", "da");
                                        }
                                        else
                                        {
                                            cmd.Parameters.AddWithValue("cm3", "nu");
                                        }
                                        cmd.Parameters.AddWithValue("idm3", rtbIntrebare.Tag.ToString());
                                        cmd.Parameters.AddWithValue("idrm3", rtbMV3.Tag.ToString());
                                        
                                    }
                                }
                            }
                            cmd.ExecuteNonQuery();
                        }
                        conexiune.Close();
                        con.Close();
                        MessageBox.Show("Datele au fost modificate cu succes.");

                        //se adauga notificare pentru modificarea intrebarii
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
                            cmdd.Parameters.AddWithValue("ptip", "modifIntrebare");
                            cmdd.Parameters.AddWithValue("idIntr", rtbIntrebare.Tag.ToString());
                            cmdd.ExecuteNonQuery();
                            cmdd.Parameters.Clear();
                        }
                        read.Close();
                        conn.Close();
                    }
                    else
                    {
                        if(invalid==0)
                        {
                            MessageBox.Show("Trebuie completate toate campurile inainte de a salva modificarile.");
                        }
                    }
                }
                
            }
            
        }

        private void incarcaLectii(string idC)
        {
            if(idC!="0")
            {
                cbLectii.Items.Clear();
                cbCapitole.Items.Add("General");

                MySqlConnection conexiune = new MySqlConnection();
                conexiune.ConnectionString = @"SERVER=localhost; DATABASE=softeducational; UID=root; PASSWORD=; Allow User Variables=True";
                conexiune.Open(); //Se deschide conexiunea

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexiune;
                cmd.CommandText = "SELECT * FROM lectii WHERE idC=@pidC";
                cmd.Parameters.AddWithValue("pidC", idC);

                MySqlDataReader r = cmd.ExecuteReader();
                while (r.Read())
                {
                    Lectii l = new Lectii();
                    {
                        l.idL = r["idL"].ToString();
                        l.idC = r["idC"].ToString();
                        l.titlu = r["titlu"].ToString();
                    }

                    cbLectii.Items.Add(l);
                }
                conexiune.Close();

                Lectii lt = new Lectii();
                {
                    lt.titlu = "General";
                    lt.idL = "0";
                    lt.idProfesor = "0";
                }

                cbLectii.Items.Add(lt);
            }
            else
            {
                cbLectii.Items.Clear();

                Lectii lt = new Lectii();
                {
                    lt.titlu = "General";
                    lt.idL = "0";
                    lt.idProfesor = "0";
                }
                    
                cbLectii.Items.Add(lt);

                cbLectii.Text = "General";
                
            }
            
        }

        string id;
        private void btnModifCL_Click(object sender, EventArgs e)
        {
            pnlModifCL.Visible = true;

            cbLectii.Items.Clear();
            cbCapitole.Items.Clear();

            btnSalveazaModif.Visible = true;

            Intrebari intr = lstIntrebari.SelectedItem as Intrebari;
            if(intr.capitol.ToString()!="General")
            {
                cbCapitole.Text = intr.capitol.ToString();

                //adaug capitolul "General"
                Capitole capitol = new Capitole();
                {
                    capitol.titlu = "General";
                    capitol.idC = "0";
                }
                

                cbCapitole.Items.Add("capitol");
            }
            else
            {
                Capitole cp = new Capitole();
                {
                    cp.titlu = "General";
                    cp.idC = "0";
                    cbCapitole.Items.Add(cp);
                }

                cbCapitole.Text = "General";
                
            }
            
            if(intr.lectie.ToString()!="General")
            {
                cbLectii.Text = intr.lectie.ToString();

                //adaug lectia "General"
                Lectii lectie = new Lectii();
                {
                    lectie.titlu = "General";
                    lectie.idL = "0";
                    lectie.idProfesor = "0";
                }
                

                cbLectii.Items.Add(lectie);
            }
            else
            {
                Lectii lt = new Lectii();
                {
                    lt.titlu = "General";
                    lt.idL = "0";
                    lt.idProfesor = "0";
                }
               

                cbLectii.Items.Add(lt);

                cbLectii.Text = "General";
            }
           

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
                cbCapitole.Items.Add(c);

                if(c.titlu==cbCapitole.Text)
                {
                    id = c.idC;
                }
            }
            conexiune.Close();

            if(cbCapitole.Text!="General")
            {
                incarcaLectii(id);
            }
            else
            {
                cbLectii.Items.Clear();

                Lectii l = new Lectii();
                {
                    l.titlu = "General";
                    l.idL = "0";
                    l.idProfesor = "0";
                }


                cbLectii.Items.Add(l);

                cbLectii.Text = "General";
            }

        }

        private void btnSalveazaModif_Click(object sender, EventArgs e)
        {
            if (cbLectii.Text != "" && cbCapitole.Text != "")
            {
                MySqlConnection conexiune = new MySqlConnection();
                conexiune.ConnectionString = @"SERVER=localhost; DATABASE=softeducational; UID=root; PASSWORD=; Allow User Variables=True";
                conexiune.Open(); //Se deschide conexiunea

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexiune;
                cmd.CommandText = "UPDATE intrebari SET capitol=@pcapitol, lectie=@plectie WHERE idIntrebare=@pidIntrebare ";
                cmd.Parameters.AddWithValue("pcapitol", cbCapitole.Text);
                cmd.Parameters.AddWithValue("plectie", cbLectii.Text);
                cmd.Parameters.AddWithValue("pidIntrebare", rtbIntrebare.Tag.ToString());
                cmd.ExecuteNonQuery();

                MessageBox.Show("Modificarile au fost salvate cu succes.");
                pnlModifCL.Visible = false;
            }
            else
            {
                MessageBox.Show("Completati toate campurile inainte de a salva modificarile.");
            }
            
        }

        private void cbCapitole_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbCapitole.SelectedItem.ToString()!="General")
            {
                Capitole c = cbCapitole.SelectedItem as Capitole;
                incarcaLectii(c.idC);
            }
            else
            {
                cbLectii.Items.Clear();
                
                Lectii lt = new Lectii();
                {
                    lt.titlu = "General";
                    lt.idL = "0";
                    lt.idProfesor = "0";
                }
                
                cbLectii.Items.Add(lt);

                cbLectii.Text = "General";

            }
            
           
        }
    }
}
