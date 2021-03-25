using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servis_Racunara
{
    class Telefon
    {
        public string IdPartnera { set; get; }

        public string BrojTelefona { set; get; }

        public int PostanskiBrojGrada { get; set; }

        public string NazivGrada { get; set; }

        public override bool Equals(object obj)
        {
            return obj is Telefon telefon &&
                  IdPartnera == telefon.IdPartnera && BrojTelefona==telefon.BrojTelefona;
        }

        public override int GetHashCode()
        {
            return -1255590651 + PostanskiBrojGrada.GetHashCode();
        }

        public override string ToString()
        {
            return IdPartnera + "," + BrojTelefona;
        }
       
    }
}
