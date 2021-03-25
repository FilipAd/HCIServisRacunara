using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servis_Racunara
{
    class RadniNalogPrikaz
    {
        public int BrojRadnogNaloga { get; set;}
        public int IdKlijenta { get; set; }
        public string ImeKlijenta { get; set; }
        public DateTime DatumKreiranja { get; set; }
        public string Status { get; set; }
        public string OpisZahtjeva { get; set; }
        public string Napomena { get; set; }
        public DateTime DatumZavrsetka { get; set; }

        public int IdRadnikaZaprimio { get; set; }
        public int IdServiseraRadi { get; set; }

        public string ImeRadnikaKojiJeZaprimio { get; set; }
        public string ImeServiseraKojiRadi { get; set; }
        public int Proknjizen { get; set; }
        public int BrojRacuna { get; set; }
    }
}
