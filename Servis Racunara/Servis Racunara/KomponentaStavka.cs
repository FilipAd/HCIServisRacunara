using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servis_Racunara
{
    class KomponentaStavka
    {
        public int BrojNaloga { get; set; }
        public int SifraKomponente { get; set; }
        public string NazivKomponente { get; set; }
        public decimal JedinicnaCijena { get; set; }
        public int DostupnaKolicina { get; set; }
        public int ZahtjevanaKolicina { get; set; }
        public decimal Rabat { get; set; }
        public decimal UkupnaCijena { get; set; }
        public decimal KomponentiZaPlatiti { get; set; }
        public int Razlika { get; set; }

        public override bool Equals(object obj)
        {
            return obj is KomponentaStavka ks &&
                   SifraKomponente == ks.SifraKomponente;
        }

        public override int GetHashCode()
        {
            return -1255590651 + SifraKomponente.GetHashCode();
        }

        public override string ToString()
        {
            return SifraKomponente + ", " +BrojNaloga;
        }

    }
}
