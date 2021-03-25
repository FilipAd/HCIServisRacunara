using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servis_Racunara
{
    class RadniNalog
    {
        public int BrojRadnogNaloga { get; set; }
        public string OpisZahtjeva { get; set; }
        public string Napomena { get; set; }
        public string Status { get; set; }
        public DateTime DatumKreiranja { get; set;}
        public int IdKlijenta { get; set; }
        public int IdRadnikaZaprimio { get; set; }
        public int Proknjizen { get; set; }
        public int BrojRacuna { get; set; }
        
        public int IdServiseraRadi { get; set; }
        public DateTime DatumZavrsetka { get; set; }






    }
}
