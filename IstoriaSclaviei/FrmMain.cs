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
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        string id;

        private void FrmMain_Load(object sender, EventArgs e)
        {
            Conturi x = new Conturi();
            x.id = this.Text;
            id = x.id.ToString();

            //se determina drepturile contului in care s-a facut logarea

            //Se creeaza conexiunea la baza de date
            MySqlConnection conexiune = new MySqlConnection();
            conexiune.ConnectionString = @"SERVER=localhost; DATABASE=softeducational; UID=root; PASSWORD=; Allow User Variables=True";
            conexiune.Open(); //Se deschide conexiunea

            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conexiune;
            cmd.CommandText = "SELECT * FROM conturi";


            //Se executa comanda si se depune in r rezultatul 
            MySqlDataReader r = cmd.ExecuteReader();
            while (r.Read())
            {
                if (r["id"].ToString() == x.id)
                {
                    x.utilizator = r.GetString("utilizator");
                    x.parola = r.GetString("parola");
                    x.drepturi = r.GetString("drepturi");

                    break;
                }

            }

            r.Close();
            conexiune.Close();

            if (x.drepturi == "elev")
            {
                this.Text = "Cont de elev";

                //visible=true --> Contul meu
                contulMeuToolStripMenuItem.Visible = true;
                notificariToolStripMenuItem.Visible = true;
                schimbaParolaToolStripMenuItem.Visible = true;
                ajutorToolStripMenuItem.Visible = true;
                iesiDinContToolStripMenuItem.Visible = true;

                lectiiToolStripMenuItem.Visible = true;
                testeToolStripMenuItem.Visible = true;
                jocuriToolStripMenuItem.Visible = true;

                //visible=false --> Administrare lectii/teste
                administrareLectiiToolStripMenuItem.Visible = false;
                administrareTesteToolStripMenuItem.Visible = false;

            }
            else
            {
                this.Text = "Cont de profesor";

                //visible=true --> Contul meu
                contulMeuToolStripMenuItem.Visible = true;
                notificariToolStripMenuItem.Visible = true;
                schimbaParolaToolStripMenuItem.Visible = true;
                ajutorToolStripMenuItem.Visible = true;
                iesiDinContToolStripMenuItem.Visible = true;

                lectiiToolStripMenuItem.Visible = true;
                testeToolStripMenuItem.Visible = true;
                jocuriToolStripMenuItem.Visible = true;

                //visible=true --> Administrare lectii/teste
                administrareLectiiToolStripMenuItem.Visible = true;
                administrareTesteToolStripMenuItem.Visible = true;

            }

            
            notificariToolStripMenuItem.Visible = true;
            ajutorToolStripMenuItem.Visible = false;
            jocuriToolStripMenuItem.Visible = true;
        }

        void menu()
        {
            lectiiToolStripMenuItem.DropDownItems.Clear(); 

            //Se creeaza conexiunea la baza de date
            MySqlConnection conexiune = new MySqlConnection();
            conexiune.ConnectionString = @"SERVER=localhost; DATABASE=softeducational; UID=root; PASSWORD=; Allow User Variables=True";
            conexiune.Open(); //Se deschide conexiunea

            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = @"SERVER=localhost; DATABASE=softeducational; UID=root; PASSWORD=; Allow User Variables=True";
            con.Open(); //Se deschide conexiunea

            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM capitole";
            

            MySqlCommand command = new MySqlCommand();
            command.Connection = conexiune;
            command.CommandText = "SELECT lectii.* FROM capitole JOIN lectii ON capitole.idC=lectii.idC ORDER BY capitole.idC";

            //Se executa comanda si se depune in r rezultatul 
            MySqlDataReader r = cmd.ExecuteReader();
            while (r.Read())
            {
                Capitole c = new Capitole();
                {
                    c.idC = r["idC"].ToString();
                    c.titlu = r["titlu"].ToString();
                }

                lectiiToolStripMenuItem.DropDownItems.Add(c.ToString()); // se adauga capitolul in meniu

                //se creeaza o legatura intre denumirea capitolului si submeniu
                ToolStripMenuItem it = lectiiToolStripMenuItem.DropDownItems[lectiiToolStripMenuItem.DropDownItems.Count - 1] as ToolStripMenuItem;
                
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Lectii l = new Lectii();
                    {
                        l.idL = reader["idL"].ToString();
                        l.idC = reader["idC"].ToString();
                        l.titlu = reader["titlu"].ToString();
                        l.idProfesor = reader["idProfesor"].ToString();
                        l.data_adaugare = Convert.ToDateTime(reader["data_adaugare"]);
                    }
                    if(c.idC==l.idC)
                    {
                        it.DropDownItems.Add(l.ToString());

                        ToolStripMenuItem subit = it.DropDownItems[it.DropDownItems.Count - 1] as ToolStripMenuItem;
                       
                        subit.Click += new System.EventHandler(this.subit_Click); //eventul Click
                        subit.Tag = l.idL; // se transmite prin Tag lectia care a fost aleasa la eventul Click

                    } 
                }
                reader.Close();
            }
            r.Close();
            conexiune.Close();
            con.Close();
        }

        
        void meniuTeste()
        {
            testeToolStripMenuItem.DropDownItems.Clear();

            //Se creeaza conexiunea la baza de date
            MySqlConnection conexiune = new MySqlConnection();
            conexiune.ConnectionString = @"SERVER=localhost; DATABASE=softeducational; UID=root; PASSWORD=; Allow User Variables=True";
            conexiune.Open(); //Se deschide conexiunea

            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conexiune;
            cmd.CommandText = "SELECT DISTINCT capitol FROM teste"; //adaug capitolele pentru care exista teste
            

            MySqlDataReader r = cmd.ExecuteReader();
            while(r.Read())
            {
                testeToolStripMenuItem.DropDownItems.Add(r["capitol"].ToString());


                MySqlConnection con = new MySqlConnection();
                con.ConnectionString = @"SERVER=localhost; DATABASE=softeducational; UID=root; PASSWORD=; Allow User Variables=True";
                con.Open(); //Se deschide conexiunea

                MySqlCommand cm = new MySqlCommand();
                cm.Connection = con;
                cm.CommandText = "SELECT DISTINCT lectie FROM teste WHERE capitol=@pcapitol"; //adaug lectiile pentru care exista teste
                cm.Parameters.AddWithValue("pcapitol", r["capitol"].ToString());

                ToolStripMenuItem it = testeToolStripMenuItem.DropDownItems[testeToolStripMenuItem.DropDownItems.Count - 1] as ToolStripMenuItem;

                MySqlDataReader reader = cm.ExecuteReader();
                while(reader.Read())
                {
                    it.DropDownItems.Add(reader["lectie"].ToString());

                    

                    MySqlConnection conex = new MySqlConnection();
                    conex.ConnectionString = @"SERVER=localhost; DATABASE=softeducational; UID=root; PASSWORD=; Allow User Variables=True";
                    conex.Open(); //Se deschide conexiunea

                    MySqlCommand cmm = new MySqlCommand();
                    cmm.Connection = conex;
                    cmm.CommandText = "SELECT * FROM teste WHERE capitol=@pC AND lectie=@pLectie"; //adaug lectiile pentru care exista teste
                    cmm.Parameters.AddWithValue("pC", r["capitol"].ToString());
                    cmm.Parameters.AddWithValue("pLectie", reader["lectie"].ToString());

                    ToolStripMenuItem t = it.DropDownItems[it.DropDownItems.Count - 1] as ToolStripMenuItem;

                    MySqlDataReader rr = cmm.ExecuteReader();
                    while(rr.Read())
                    {
                        Teste test = new Teste();
                        {
                            test.idTest = rr["idTest"].ToString();
                            test.denumire = rr["denumire"].ToString();
                        }

                        t.DropDownItems.Add(test.ToString());

                        ToolStripMenuItem subt = t.DropDownItems[t.DropDownItems.Count - 1] as ToolStripMenuItem;

                        subt.Click += new System.EventHandler(this.subt_Click); //eventul Click
                        subt.Tag = test.idTest;

                    }
                    rr.Close();
                    conex.Close();
                }
                reader.Close();
                con.Close();
                

            }
        }

        private void subit_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32((sender as ToolStripDropDownItem).Tag.ToString()); //id-ul testului care urmeaza sa fie incarcat
            FrmLectii frml = new FrmLectii();
            frml.MdiParent = this;
            frml.Tag = id;
            frml.Show();
            frml.Location = new Point(200, 0);
            frml.Text = sender.ToString();
        }

        private void subt_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32 ((sender as ToolStripDropDownItem).Tag.ToString()); //id-ul testului care urmeaza sa fie incarcat
            FrmTeste frmt = new FrmTeste();
            frmt.MdiParent = this;
            frmt.Tag = id;
            frmt.Show();
            frmt.Location = new Point(300, 100);
            frmt.Text = sender.ToString();
            //frmt.Size = new Size(921, 595);
        }

        //inchiderea unei ferestre dupa ce am terminat cu ea, fara a se opri programul
        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            if((this.Tag as FrmLogare)!=null)
            {
                (this.Tag as FrmLogare).Close();
            }
        }

        private void iesiDinContToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLogare log = new FrmLogare();
            log.Show();
            log.Tag = this;
            this.Hide();
        }

        private void adaugaLectieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAdaugaLectie adlectie = new FrmAdaugaLectie();
            adlectie.MdiParent = this;
            adlectie.Tag = id.ToString();
            adlectie.Show();
            adlectie.Location = new Point(150, 15);
        }

        private void modificaLectieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmModificaLectie modifl = new FrmModificaLectie();
            modifl.MdiParent = this;
            modifl.Show();
            modifl.Location = new Point(200, 15);
        }

        private void adaugaTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAdaugaTest adtest = new FrmAdaugaTest();
            adtest.MdiParent = this;
            adtest.Tag = id.ToString();
            adtest.Show();
            adtest.Location = new Point(250, 0);
        }

        private void stergeLectieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmStergeLectie fsl = new FrmStergeLectie();
            fsl.MdiParent = this;
            fsl.Tag = id.ToString();
            fsl.Show();
            fsl.Location = new Point(200, 0);
        }

        private void adaugaIntrebariToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAdaugaIntrebari fai = new FrmAdaugaIntrebari();
            fai.MdiParent = this;
            fai.Tag = id.ToString();
            fai.Show();
            fai.Location = new Point(200, 0);
        }

        private void modificaIntrebariToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmModificaIntrebari fmi = new FrmModificaIntrebari();
            fmi.MdiParent = this;
            fmi.Tag = id.ToString();
            fmi.Show();
            fmi.Location = new Point(250, 0);
        }

        private void stergeIntrebariToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmStergeIntrebari fsi = new FrmStergeIntrebari();
            fsi.MdiParent = this;
            fsi.Tag = id.ToString();
            fsi.Show();
            fsi.Location = new Point(250, 0);
        }

        private void modificaTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmModificaTest fmt = new FrmModificaTest();
            fmt.MdiParent = this;
            fmt.Tag = id.ToString();
            fmt.Show();
            fmt.Location = new Point(250, 0);
        }

        private void stergeTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmStergeTest fst = new FrmStergeTest();
            fst.MdiParent = this;
            fst.Tag = id.ToString();
            fst.Show();
            fst.Location = new Point(250, 0);
        }

        private void lectiiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menu(); //se apeleaza functia de generare a meniului din cod
            
        }

        private void testeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            meniuTeste(); //se apeleaza functia de generare a testelor din cod
        }

        private void schimbaParolaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSchhimbaParola fsp = new FrmSchhimbaParola();
            fsp.MdiParent = this;
            fsp.Tag = id.ToString();
            fsp.Show();
            //fsp.Location = new Point(400, 150);
        }

        private void lectiiToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmModifOrdCapitole fmoc = new FrmModifOrdCapitole();
            fmoc.MdiParent = this;
            fmoc.Show();
            fmoc.Location = new Point(400, 100);
        }

        private void lectiiToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FrmModifOrdLectii fmol = new FrmModifOrdLectii();
            fmol.MdiParent = this;
            fmol.Show();
            fmol.Location = new Point(400, 100);
        }

        private void notificariToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmNotificari fn = new FrmNotificari();
            fn.MdiParent = this;
            fn.Tag = id.ToString();
            fn.Show();
        }

        private void jocuriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmJoc fj = new FrmJoc();
            fj.MdiParent = this;
            fj.Show();
        }
    }
}
