using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IstoriaSclaviei
{
    internal class Raspunsuri
    {
        public string idRaspuns;
        public string idIntrebare;
        public string raspuns;
        public string tipRaspuns;
        public string corect;

        public override string ToString()
        {
            return raspuns;
        }
    }
}
