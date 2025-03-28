using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IstoriaSclaviei
{
    internal class Intrebari
    {
        public string idIntrebare;
        public string idProfesor;
        public string intrebare;
        public string capitol;
        public string lectie;

        public override string ToString()
        {
            return intrebare;
        }
    }
}
