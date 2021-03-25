using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servis_Racunara
{
    class Klijent
    {
        public int IdPartnera { get; set; }
        public int JestePravnoLice { get; set; }
        public string BrojLicneKarte { get; set; }

        public string JIB { get; set; }

        public override bool Equals(object obj)
        {
            return obj is Klijent klijent &&
                   IdPartnera == klijent.IdPartnera;
        }

        public override int GetHashCode()
        {
            return -1255590651 + IdPartnera.GetHashCode();
        }

        public override string ToString()
        {
            return IdPartnera.ToString();
        }
    }
}
