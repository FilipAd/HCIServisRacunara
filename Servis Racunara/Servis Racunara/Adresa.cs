using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servis_Racunara
{
    class Adresa
    {
        public int KucniBroj { get; set;}

        public int IdUlice { get; set;}

        public int PostanskiBrojGrada { get; set; }

        public override bool Equals(object obj)
        {
            return obj is Adresa adresa &&
                   (KucniBroj == adresa.KucniBroj) && (IdUlice==adresa.IdUlice) && (PostanskiBrojGrada==adresa.PostanskiBrojGrada);
        }

        public override int GetHashCode()
        {
            return -1255590651 + KucniBroj.GetHashCode();
        }

        public override string ToString()
        {
            return PostanskiBrojGrada + ", " + IdUlice+ ", "+KucniBroj;
        }

    }
}
