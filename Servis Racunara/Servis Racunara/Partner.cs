using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servis_Racunara
{
   public class Partner
    {
        public int IdPartnera { get; set; }
        public string Ime { get; set; }
        public int PostanskiBrojGrada { get; set; }
        public string Email { get; set; }
        public string NazivUlice { get; set; }

        public int KucniBroj { get; set; }

        public override bool Equals(object obj)
        {
            return obj is Partner partner &&
                   IdPartnera == partner.IdPartnera;
        }

        public override int GetHashCode()
        {
            return -1255590651 + IdPartnera.GetHashCode();
        }

        public override string ToString()
        {
            return IdPartnera + ", " + Ime;
        }

    }
}
