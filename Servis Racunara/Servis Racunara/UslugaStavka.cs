using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servis_Racunara
{
    class UslugaStavka
    {
        public int SifraUsluge { get; set; }
        public int BrojRadnogNaloga { get; set; }
        public string NazivUsluge { get; set; }
        public int Kolicina { get; set; }
        public decimal Rabat { get; set; }
        public decimal UkupnaCijena { get; set; }
        public decimal CijenaPoH { get; set; }
        public decimal UslugeZaPlatiti { get; set; }



    }
}
