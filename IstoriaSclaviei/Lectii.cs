using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IstoriaSclaviei
{
    internal class Lectii
    {
        public string idL;
        public string idC;
        public string titlu;
        public string idProfesor;
        public DateTime data_adaugare;

        public override string ToString()
        {
            return titlu;
        }
    }
}
