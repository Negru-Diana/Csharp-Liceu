using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IstoriaSclaviei
{
    internal class Notificari
    {
        public string id;
        public string idCont;
        public string tipNotificare;
        public string idLectie;
        public string idTest;
        public string idIntrebare;
        public string text;

        public override string ToString()
        {
            return text;
        }
    }
}
