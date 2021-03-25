using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servis_Racunara
{
    class PrikazPartnera
    {
        public int IdPartnera { set; get; }

        public string Ime { set; get; }

        public string Ulica { set; get; }

        public int PostanskiBrojGrada { set; get; }

        public string Grad { set; get; }

        public string Telefon { set; get; }

        public int KucniBroj { set; get; }

        public string Email {set; get;}

        public string BrojLicneKarte { get; set; }

        public string JIB { get; set; }

        public int JestePravnoLice { get; set; }


        public override bool Equals(object obj)
        {
            return true;
        }

        public override string ToString()
        {
            return IdPartnera + ", " + Ime + ", " + Ulica + ", " + Grad+", "+Telefon;
        }

        public override int GetHashCode()
        {
            return -1255590651 + Ime.GetHashCode();
        }
    }

}
