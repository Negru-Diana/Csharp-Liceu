using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IstoriaSclaviei
{
    internal class Teste
    {
        public string idTest;
        public string denumire;
        public string idProfesor;
        public string data_adaugare;
        public string capitol;
        public string lectie;

        public override string ToString()
        {
            return denumire;
        }
    }
}
