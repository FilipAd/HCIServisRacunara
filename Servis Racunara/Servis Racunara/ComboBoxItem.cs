using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servis_Racunara
{
    class ComboBoxItem
    {

     
        public string Tekst { get; set; }
        public int Vrijednost { get; set; }
        public ComboBoxItem(String Tekst, int Vrijednost)
        {
            this.Tekst = Tekst;
            this.Vrijednost = Vrijednost;
        }
        public override string ToString()
        {
            return Tekst+"-"+Vrijednost;
        }
    }
}

