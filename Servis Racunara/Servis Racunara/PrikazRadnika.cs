using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servis_Racunara
{
    class PrikazRadnika
    {
        public int IdPartnera { set; get; }

        public string Ime { set; get; }

        public string Ulica { set; get; }

        public string Grad { set; get; }

        public int PostanskiBrojGrada { set; get; }

        public string Telefon { set; get; }

        public int KucniBroj { set; get; }

        public string Email { set; get; }

        public string Uloga { get; set; }

        public decimal Plata { get; set; }

        public string VozackaDozvola { get; set; }

        public string Lozinka { get; set; }

        public int Privilegije { get; set; }


        public override bool Equals(object obj)
        {
            return true;
        }

        public override string ToString()
        {
            return IdPartnera + ", " + Ime + ", " + Ulica + ", " + Grad + ", " + Telefon;
        }
        public string ZaprimioPrikaz()
        {
            return Ime + "-" + IdPartnera;
        }

        public override int GetHashCode()
        {
            return -1255590651 + Ime.GetHashCode();
        }
    }

}
