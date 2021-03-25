using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servis_Racunara
{
    class Radnik
    {
        public int IdPartnera { get; set; }
        public string Uloga { get; set; }
        public decimal Plata { get; set; }
        public string VozackaDozvola { get; set; }
        public override bool Equals(object obj)
        {
            return obj is Radnik radnik &&
                   IdPartnera == radnik.IdPartnera;
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
