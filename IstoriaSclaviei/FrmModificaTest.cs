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
    public partial class FrmModificaTest : Form
    {
        public FrmModificaTest()
        {
            InitializeComponent();
        }

        private void FrmModificaTest_Load(object sender, EventArgs e)
        {
            lstIntrebari.Items.Clear();
            lstIntrTest.Items.Clear();
            lstIntrTest.Text = "Selecteaza testul";
            cbCapitole.Items.Clear();
            cbCapitole.Text = "";
            cbLectii.Items.Clear();
            cbLectii.Text = "";
            cbTeste.Items.Clear();
            cbTeste.Text = "";

            //se adauga intrebarile in ListBox
            MySqlConnection conexiune = new MySqlConnection();
            conexiune.ConnectionString = @"SERVER=localhost; DATABASE=softeducational; UID=root; PASSWORD=; Allow User Variables=True";
            conexiune.Open(); //Se deschide conexiunea

            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conexiune;
            cmd.CommandText = "SELECT * FROM intrebari";

            MySqlDataReader r = cmd.ExecuteReader();
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
                lstIntrebari.Items.Add(intr);
            }
            r.Close();

            cmd.CommandText = "SELECT * FROM teste";
            int ok = 0;

            r = cmd.ExecuteReader();
            while(r.Read())
            {
                Teste t = new Teste();
                {
                    t.idTest = r["idTest"].ToString();
                    t.denumire = r["denumire"].ToString();
                    t.idProfesor = r["idProfesor"].ToString();
                    //t.data_adaugare = r["data_adaugare"].ToString();
                    t.capitol = r["capitol"].ToString();
                    t.lectie = r["lectie"].ToString();
                }

                if(t.idProfesor==this.Tag.ToString())
                {
                    ok++;
                    cbTeste.Items.Add(t);
                }
            }

            if(ok==0)
            {
                MessageBox.Show("Nu aveti teste pe care sa le puteti modifica.");
                this.Close();
            }

            conexiune.Close();

            pnlControl.Visible = false;

        }

        private void incarcaLectii(string idC)
        {
            if (idC != "0")
            {
                cbLectii.Items.Clear();
                //cbCapitole.Items.Add("General");

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

        string idCapitol,denumCap,idTest;

        private void btnAdaugaIntrebare_Click(object sender, EventArgs e)
        {
            if (lstIntrebari.SelectedIndex != -1)
            {
                Intrebari intr = lstIntrebari.SelectedItem as Intrebari;

                int ok = 0;
                for (int i = 0; i < lstIntrTest.Items.Count; i++)
                {
                    Intrebari intrebare = lstIntrTest.Items[i] as Intrebari;

                    if (intrebare.intrebare == intr.intrebare)
                    {
                        ok = 1;
                        break;
                    }
                    
                }
                if (ok == 0)
                {
                    lstIntrTest.Items.Add(intr);
                }
                else
                {
                    MessageBox.Show("Intrebarea selectata a fost deja adaugata la test");
                }


            }
            else
            {

                MessageBox.Show("Selectati intrebare pe care doriti sa o adaugati la test.");

            }
        }

        private void btnStergeIntrebare_Click(object sender, EventArgs e)
        {
            if (lstIntrTest.SelectedIndex != -1)
            {
                lstIntrTest.Items.Remove(lstIntrTest.SelectedItem);
            }
            else
            {
                MessageBox.Show("Selectati intrebare pe care doriti sa o stergeti.");
            }
        }

        int poz = 0, stop=0;
        string idInreg;

        private void btnSus_Click(object sender, EventArgs e)
        {
            if (lstIntrTest.SelectedIndex > 0)
            {
                int index = lstIntrTest.SelectedIndex;
                Intrebari intr = lstIntrTest.SelectedItem as Intrebari;

                lstIntrTest.Items[index] = lstIntrTest.Items[index - 1];
                lstIntrTest.Items[index - 1] = intr;

                lstIntrTest.SelectedIndex = index - 1;
                lstIntrTest.Update();
                lstIntrTest.Focus();
            }
            else
            {
                if (lstIntrTest.SelectedIndex == -1)
                {
                    MessageBox.Show("Selectati intrebare pe care doriti sa o mutati cu o pozitie mai jos.");
                }
                else
                {
                    MessageBox.Show("Nu puteti efectua aceasta modificare.");
                }
            }
        }

        private void btnJos_Click(object sender, EventArgs e)
        {
            if (lstIntrTest.SelectedIndex < lstIntrTest.Items.Count - 1 && lstIntrTest.SelectedIndex != -1)
            {
                int index = lstIntrTest.SelectedIndex;
                Intrebari intr = lstIntrTest.SelectedItem as Intrebari;


                lstIntrTest.Items[index] = lstIntrTest.Items[index + 1];
                lstIntrTest.Items[index + 1] = intr;

                lstIntrTest.SelectedIndex = index + 1;
                lstIntrTest.Update();
                lstIntrTest.Focus();
            }
            else
            {
                if (lstIntrTest.SelectedIndex == -1)
                {
                    MessageBox.Show("Selectati intrebare pe care doriti sa o mutati cu o pozitie mai jos.");
                }
                else
                {
                    MessageBox.Show("Nu puteti efectua aceasta modificare.");
                }
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnSalveazaModif_Click(object sender, EventArgs e)
        {
            if(cbTeste.Text!="" && cbLectii.Text!="" && cbCapitole.Text!="" && lstIntrTest.Items.Count!=0)
            {
                MySqlConnection conexiune = new MySqlConnection();
                conexiune.ConnectionString = @"SERVER=localhost; DATABASE=softeducational; UID=root; PASSWORD=; Allow User Variables=True";
                conexiune.Open(); //Se deschide conexiunea

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexiune;
                cmd.CommandText = "UPDATE teste SET denumire=@pden, capitol=@pcapitol, lectie=@plectie WHERE idTest=@pid";
                cmd.Parameters.AddWithValue("pden", cbTeste.Text);
                cmd.Parameters.AddWithValue("pcapitol", cbCapitole.Text);
                cmd.Parameters.AddWithValue("plectie", cbLectii.Text);
                cmd.Parameters.AddWithValue("pid", idTest);
                cmd.ExecuteNonQuery();

                cmd.CommandText = "SELECT * FROM continut_teste WHERE idTest=@pidTest";
                cmd.Parameters.AddWithValue("pidTest", idTest);

                MySqlDataReader r = cmd.ExecuteReader();
                int i = 0;
                
                while(r.Read())
                {
                    MySqlConnection con = new MySqlConnection();
                    con.ConnectionString = @"SERVER=localhost; DATABASE=softeducational; UID=root; PASSWORD=; Allow User Variables=True";
                    con.Open(); //Se deschide conexiunea

                    MySqlCommand cm = new MySqlCommand();
                    cm.Connection = con;

                    if(i<lstIntrTest.Items.Count && i < lstID.Items.Count)
                    {
                        cm.CommandText = "UPDATE continut_teste SET idIntrebare=@pidIntr WHERE idTest=@pidTest AND id=@pidd";
                        Intrebari intr = lstIntrTest.Items[i] as Intrebari;
                        //MessageBox.Show(intr.idIntrebare.ToString() + " " + i.ToString());
                        cm.Parameters.AddWithValue("pidIntr", intr.idIntrebare);
                        cm.Parameters.AddWithValue("pidTest", idTest);
                        cm.Parameters.AddWithValue("pidd", lstID.Items[i]);
                        poz = i;
                        idInreg = r["id"].ToString();
                        cm.ExecuteNonQuery();
                    }
                    else
                    {
                        //Intrebari intrebare = lstIntrTest.Items[i] as Intrebari;
                        cm.CommandText = "DELETE FROM continut_teste WHERE id>@id AND idTest=@idT";
                        cm.Parameters.AddWithValue("id", idInreg.ToString());
                        cm.Parameters.AddWithValue("idT", idTest);
                        cm.ExecuteNonQuery();
                    }
                    
                    
                    con.Close();
                    i++;
                }
                r.Close();
                conexiune.Close();
                

                //verific daca au ramas elem 
                
                if (poz<lstIntrTest.Items.Count)
                {
                    for (int k = poz + 1; k < lstIntrTest.Items.Count; k++)
                    {
                        MySqlConnection conex = new MySqlConnection();
                        conex.ConnectionString = @"SERVER=localhost; DATABASE=softeducational; UID=root; PASSWORD=; Allow User Variables=True";
                        conex.Open(); //Se deschide conexiunea

                        MySqlCommand cmm = new MySqlCommand();
                        cmm.Connection = conex;
                        cmm.CommandText = "INSERT INTO continut_teste (idTest,idIntrebare) VALUES (@pidTest, @pidIntr)";
                        cmm.Parameters.AddWithValue("pidTest", idTest);
                        Intrebari intr = lstIntrTest.Items[k] as Intrebari;
                        //MessageBox.Show(intr.ToString() + " " + k.ToString());
                        cmm.Parameters.AddWithValue("pidIntr", intr.idIntrebare.ToString());
                        cmm.ExecuteNonQuery();
                        conex.Close();
                    }
                }

                

                if(stop==0)
                {
                    stop = 1;
                    btnSalveazaModif_Click(sender, e);
                    
                }
                else
                {
                    MessageBox.Show("Modificarile au fost salvate.");
                    //se adauga notificare pentru modificarea testului
                    MySqlConnection c = new MySqlConnection();
                    c.ConnectionString = @"SERVER=localhost; DATABASE=softeducational; UID=root; PASSWORD=; Allow User Variables=True";
                    c.Open(); //Se deschide conexiunea

                    MySqlCommand cmdd = new MySqlCommand();
                    cmdd.Connection = c;
                    cmdd.CommandText = @"INSERT INTO notificari (idCont,tipNotificare,idTest) VALUES (@idCont,@ptip,@idT)";

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
                        cmdd.Parameters.AddWithValue("ptip", "modifTest");
                        cmdd.Parameters.AddWithValue("idT", idTest);
                        cmdd.ExecuteNonQuery();
                        cmdd.Parameters.Clear();
                    }
                    read.Close();
                    conn.Close();
                    stop = 0;
                    FrmModificaTest_Load(sender, e);
                }
                
            }
            else
            {
                MessageBox.Show("Toate campurile trebuie completate inainte de a salva modificarile.");
                this.Close();
            }
        }

        private void cbTeste_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbTeste.SelectedIndex!=-1)
            {
                pnlControl.Visible = true;

                lstIntrTest.Items.Clear();

                Teste t = cbTeste.SelectedItem as Teste;

                //se incarca testul ales
                MySqlConnection conexiune = new MySqlConnection();
                conexiune.ConnectionString = @"SERVER=localhost; DATABASE=softeducational; UID=root; PASSWORD=; Allow User Variables=True";
                conexiune.Open(); //Se deschide conexiunea

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexiune;
                cmd.CommandText = "SELECT * FROM teste WHERE idTest=@pidTest";
                cmd.Parameters.AddWithValue("pidTest", t.idTest.ToString());

                MySqlDataReader r = cmd.ExecuteReader();
                while(r.Read())
                {
                    Teste test = new Teste();
                    {
                        test.idTest = r["idTest"].ToString();
                        test.denumire = r["denumire"].ToString();
                        test.idProfesor = r["idProfesor"].ToString();
                        //test.data_adaugare = r["data_adaugare"].ToString();
                        test.capitol = r["capitol"].ToString();
                        test.lectie = r["lectie"].ToString();
                    }
                    denumCap = test.capitol;
                    idTest = test.idTest;

                    cbCapitole.Text = test.capitol;
                    cbLectii.Text = test.lectie;

                }
                r.Close();

                //se adauga capitolele in ComboBox
                cbCapitole.Items.Clear();

                cmd.CommandText = "SELECT * FROM capitole";

                
                r = cmd.ExecuteReader();
                while (r.Read())
                {
                    Capitole c = new Capitole();
                    {
                        c.idC = r["idC"].ToString();
                        c.titlu = r["titlu"].ToString();
                    }
                    cbCapitole.Items.Add(c);

                    if(c.titlu==denumCap)
                    {
                        idCapitol = c.idC;
                    }
                }
                r.Close();

                //se incarca intrebarile
                cmd.CommandText = "SELECT intrebari.*, continut_teste.id FROM intrebari JOIN continut_teste ON intrebari.idIntrebare=continut_teste.idIntrebare WHERE idTest=@pidT";
                cmd.Parameters.AddWithValue("pidT",idTest);

                r = cmd.ExecuteReader();
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

                    lstIntrTest.Items.Add(intr);
                    lstID.Items.Add(r["id"].ToString());
                }

                conexiune.Close();

                //adaug capitolul "General"
                Capitole capitol = new Capitole();
                {
                    capitol.titlu = "General";
                    capitol.idC = "0";
                }
                cbCapitole.Items.Add(capitol);

               //se adauga lectiile
                //Capitole cp = cbCapitole. as Capitole;
                incarcaLectii(idCapitol);

            }
            else
            {
                MessageBox.Show("Selectati testul pe care doriti sa-l modificati");
            }
        }

        private void cbCapitole_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cbCapitole.SelectedIndex != -1)
            {
                Capitole c = cbCapitole.SelectedItem as Capitole;
                incarcaLectii(c.idC);

                cbLectii.Text = "";
            }
            
        }
    }


}
