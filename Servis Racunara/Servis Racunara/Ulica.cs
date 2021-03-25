using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servis_Racunara
{
    class Ulica
    {
        public int PostanskiBrojGrada { get; set; }

        public int IdUlice { get; set; }

        public string NazivUlice { get; set; }

        public override bool Equals(object obj)
        {
            return obj is Ulica ulica &&
                   (IdUlice == ulica.IdUlice) && PostanskiBrojGrada==ulica.PostanskiBrojGrada;
        }

        public override int GetHashCode()
        {
            return -1255590651 + IdUlice.GetHashCode();
        }

        public override string ToString()
        {
            return IdUlice + ", " + NazivUlice;
        }
    }
}
