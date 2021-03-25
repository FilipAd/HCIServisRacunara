using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servis_Racunara
{
    class Grad
    {
        public int PostanskiBrojGrada { get; set; }

        public string NazivGrada { get; set; }

        public override bool Equals(object obj)
        {
            return obj is Grad grad &&
                   PostanskiBrojGrada == grad.PostanskiBrojGrada;
        }

        public override int GetHashCode()
        {
            return -1255590651 + PostanskiBrojGrada.GetHashCode();
        }

        public override string ToString()
        {
            return NazivGrada + "-" + PostanskiBrojGrada;
        }
        public string IspisiNazivGrada()
        {
            return NazivGrada;
        }
        public string IpisiPostanskiBroj()
        {
            return PostanskiBrojGrada.ToString();
        }
    }
}
