using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sube1.EmlakciApp
{
    class Ev
    {
        public int odasayisi;//field
        public int katno;
        public string semt;
        public double alan;

        public string EvBilgileri()
        {
            return $"Oda Sayısı:{odasayisi}\nKat no:{katno}\nAlan:{alan}\nSemt:{semt}\n";
        }
    }
}
