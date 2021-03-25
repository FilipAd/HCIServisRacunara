using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servis_Racunara
{
    class Usluga
    {
        public int SifraUsluge { get; set; }
        public string Naziv { get; set; }
        public decimal CijenaPoH { get; set; }

        public override string ToString()
        {
            return SifraUsluge + "," + Naziv + "," + CijenaPoH;
        }
      
        public override int GetHashCode()
        {
            return -1255590651 + SifraUsluge.GetHashCode();
        }
    }
}

