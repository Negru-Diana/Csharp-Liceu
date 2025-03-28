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
    public partial class FrmAdaugaTest : Form
    {
        public FrmAdaugaTest()
        {
            InitializeComponent();
        }

        private void FrmAdaugaTest_Load(object sender, EventArgs e)
        {
            txtNumeTest.Text = "";
            cbCapitole.Text = "";
            cbLectii.Text = "";

            lstIntrebari.Items.Clear();
            lstIntrTest.Items.Clear();

            //se adauga intrebarile in ListBox
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
                    intr.idProfesor = r["idProfesor"].ToString();
                    intr.intrebare = r["intrebare"].ToString();
                    intr.capitol = r["capitol"].ToString();
                    intr.lectie = r["lectie"].ToString();
                }
                lstIntrebari.Items.Add(intr);
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
            }
            conexiune.Close();

            //adaug capitolul "General"
            Capitole capitol = new Capitole();
            {
                capitol.titlu = "General";
                capitol.idC = "0";
            }
            cbCapitole.Items.Add(capitol);

            cbLectii.Items.Clear();

            Lectii lectie = new Lectii();
            {
                lectie.titlu = "General";
                lectie.idL = "0";
                lectie.idProfesor = "0";
            }
            cbLectii.Items.Add(lectie);

        }

        private void btnAdaugaIntrebare_Click(object sender, EventArgs e)
        {
            if(lstIntrebari.SelectedIndex!=-1)
            {
                Intrebari intr = lstIntrebari.SelectedItem as Intrebari;

                int ok = 0;
                for(int i=0;i<lstIntrTest.Items.Count;i++)
                {
                    if (lstIntrTest.Items[i] == intr)
                    {
                        ok = 1;
                        break;
                    }
                }
                if(ok==0)
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
            if(lstIntrTest.SelectedIndex!=-1)
            {
                lstIntrTest.Items.Remove(lstIntrTest.SelectedItem);
            }
            else
            {
                MessageBox.Show("Selectati intrebare pe care doriti sa o stergeti.");
            }
        }

        private void btnSus_Click(object sender, EventArgs e)
        {
            if(lstIntrTest.SelectedIndex > 0)
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
            if (lstIntrTest.SelectedIndex < lstIntrTest.Items.Count -1 && lstIntrTest.SelectedIndex!=-1)
            {
                int index = lstIntrTest.SelectedIndex;
                Intrebari intr = lstIntrTest.SelectedItem as Intrebari;


                lstIntrTest.Items[index] = lstIntrTest.Items[index+1];
                lstIntrTest.Items[index + 1] = intr;

                lstIntrTest.SelectedIndex = index + 1;
                lstIntrTest.Update();
                lstIntrTest.Focus();
            }
            else
            {
                if(lstIntrTest.SelectedIndex==-1)
                {
                    MessageBox.Show("Selectati intrebare pe care doriti sa o mutati cu o pozitie mai jos.");
                }
                else
                {
                    MessageBox.Show("Nu puteti efectua aceasta modificare.");
                }
            }
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

        private void cbCapitole_SelectedIndexChanged(object sender, EventArgs e)
        {
           if(cbCapitole.SelectedIndex!=-1)
           {
                Capitole c = cbCapitole.SelectedItem as Capitole;
                incarcaLectii(c.idC);
           }
           
        }

        string idTest;
        private void btnSalveaza_Click(object sender, EventArgs e)
        {
            if(lstIntrTest.Items.Count!=0 && txtNumeTest.Text!="")
            {
                int ok = 0;
                MySqlConnection conexiune = new MySqlConnection();
                conexiune.ConnectionString = @"SERVER=localhost; DATABASE=softeducational; UID=root; PASSWORD=; Allow User Variables=True";
                conexiune.Open(); //Se deschide conexiunea

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexiune;
                cmd.CommandText = "SELECT denumire FROM teste";
                MySqlDataReader r = cmd.ExecuteReader();
                while(r.Read())
                {
                    if (r["denumire"].ToString()==txtNumeTest.Text)
                    {
                        ok = 1;
                        break;
                    }
                }
                r.Close();

                if(ok==0)
                {
                    cmd.CommandText = "INSERT INTO teste (denumire, idProfesor, data_adaugare, capitol, lectie) VALUES (@pdenum, @pidProf, @pdataAd, @pCapitol, @plectie)";

                    cmd.Parameters.AddWithValue("pdenum", txtNumeTest.Text);
                    cmd.Parameters.AddWithValue("pidProf", this.Tag.ToString());
                    cmd.Parameters.AddWithValue("pdataAd", "now()");
                    if (cbCapitole.Text != "")
                    {
                        cmd.Parameters.AddWithValue("pCapitol", cbCapitole.Text);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("pCapitol", "General");
                    }

                    if (cbLectii.Text != "")
                    {
                        cmd.Parameters.AddWithValue("plectie", cbLectii.Text);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("plectie", "General");
                    }
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = "SELECT * FROM teste WHERE denumire=@pdenumire";
                    cmd.Parameters.AddWithValue("pdenumire", txtNumeTest.Text);
                    r = cmd.ExecuteReader();

                    while (r.Read())
                    {
                        idTest = r["idTest"].ToString();
                    }
                    r.Close();

                }
                conexiune.Close();

                if (ok==0)
                {

                    for (int i=0;i<lstIntrTest.Items.Count;i++)
                    {
                        MySqlConnection con = new MySqlConnection();
                        con.ConnectionString = @"SERVER=localhost; DATABASE=softeducational; UID=root; PASSWORD=; Allow User Variables=True";
                        con.Open(); //Se deschide conexiunea

                        MySqlCommand cm = new MySqlCommand();
                        cm.Connection = con;

                        cm.CommandText = "INSERT INTO continut_teste (idTest, idIntrebare) VALUES (@pidTest, @pidIntrebare)";
                        cm.Parameters.AddWithValue("pidTest", idTest.ToString());
                        Intrebari intr = lstIntrTest.Items[i] as Intrebari;
                        cm.Parameters.AddWithValue("pidIntrebare", intr.idIntrebare.ToString());
                        cm.ExecuteNonQuery();
                        con.Close();
                    }

                    MessageBox.Show("Testul a fost salvat cu succes.");

                    //se adauga notificare pentru adaugarea testutului
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
                        cmdd.Parameters.AddWithValue("ptip", "adaugareTest");
                        cmdd.Parameters.AddWithValue("idT", idTest.ToString());
                        cmdd.ExecuteNonQuery();
                        cmdd.Parameters.Clear();
                    }
                    read.Close();
                    conn.Close();
                    c.Close();

                    FrmAdaugaTest_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Exista deja un test cu acest nume. Va rugam sa alegeti alt nume.");
                }
                conexiune.Close();

                
            }
            else
            {
                MessageBox.Show("Campul cu denumirea testului si lista intrebarilor pentru test sunt obligatorii. Va rugam sa le completati inainte de a salva testul.");
            }
        }
    }
}
