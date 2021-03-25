using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servis_Racunara
{
   public class Komponenta
    {
        public int SifraKomponente { get; set; }

        public string NazivKomponente { get; set; }

        public decimal CijenaKomponente { get; set; }

        public int DostupnaKolicina { get; set; }

        public override bool Equals(object obj)
        {
            return obj is Komponenta komponenta &&
                   SifraKomponente == komponenta.SifraKomponente;
        }
        public override int GetHashCode()
        {
            return -1255590651 + SifraKomponente.GetHashCode();
        }

        public override string ToString()
        {
            return SifraKomponente + ", " + NazivKomponente+", " +CijenaKomponente+", "+DostupnaKolicina;
        }
    }
}
