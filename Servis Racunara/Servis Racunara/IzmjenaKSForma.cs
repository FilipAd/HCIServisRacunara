using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Servis_Racunara
{
    public partial class IzmjenaKSForma : Form
    {
        public IzmjenaKSForma()
        {
            InitializeComponent();
        }

        private void lbKolicinaIzmjenaKS_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btZapamtiIzmjenaKS_Click(object sender, EventArgs e)
        {
            {
                var ks = new KomponentaStavka()
                {
                    BrojNaloga = Int32.Parse(tbBrojNalogaIzmjenaKS.Text),
                    SifraKomponente = Int32.Parse(tbSifraIzmjenaKS.Text),
                    ZahtjevanaKolicina = Int32.Parse(tbKolicinaIzmjenaKS.Text),
                    JedinicnaCijena = Decimal.Parse(tbJedinicnaCijenaIzmjenaKS.Text),
                    Rabat = Decimal.Parse(tbRabatIzmjenaKS.Text),
                    UkupnaCijena = Decimal.Parse(tbUkupnoIzmjenaKS.Text),
                    Razlika = Int32.Parse(tbKolicinaIzmjenaKS.Text) - Int32.Parse(tbStaraKolicinaIzmjenaKS.Text),
                };
                DbServisRacunara.UpdateKomponentaStavka(ks);
                MessageBox.Show("USPJESNO AZURIRANJE", "Uspjesno Azuriranje Stavke Komponente", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btObracunajIzmjenaKS_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbKolicinaIzmjenaKS.Text) || String.IsNullOrEmpty(tbRabatIzmjenaKS.Text))
            {
                MessageBox.Show("MORATE POPUNITI SVA ZAHTJEVANA POLJA", "GRESKA PRAZNO POLJE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    decimal rabat = Decimal.Parse(tbRabatIzmjenaKS.Text);
                    int kolicina = Int32.Parse(tbKolicinaIzmjenaKS.Text);
                    decimal jedinicnaCijena = Decimal.Parse(tbJedinicnaCijenaIzmjenaKS.Text);
                    tbUkupnoIzmjenaKS.Text = Math.Round((((1 - (rabat / 100)) * jedinicnaCijena) * kolicina), 2).ToString();
                    btZapamtiIzmjenaKS.Enabled = true;
                }
                catch (Exception Ex)
                {
                    tbRabatIzmjenaKS.Text = "";
                    tbKolicinaIzmjenaKS.Text = "";
                    MessageBox.Show("Unesene vrijednosti moraju biti brojevi, i komponenta mora biti selektovana", "GRESKA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void tbKolicinaIzmjenaKS_TextChanged(object sender, EventArgs e)
        {
            btZapamtiIzmjenaKS.Enabled = false;  
        }

        private void tbRabatIzmjenaKS_TextChanged(object sender, EventArgs e)
        {
            btZapamtiIzmjenaKS.Enabled = false;
        }

        private void IzmjenaKSForma_Load(object sender, EventArgs e)
        {

        }
        public void prevediNaSrpski()
        {
            lbBrojNalogaIzmjenaKS.Text = "БРОЈ РАДНОГ НАЛОГА :";
            lbSifraKomponenteIzmjenaKS.Text = "ШИФРА :";
            lbNazivIzmjenaKS.Text = "НАЗИВ :";
            lbJedinicnaCijenaIzmjenaKS.Text = "ЈЕДИНИЧНА ЦИЈЕНА :";
            lbKolicinaIzmjenaKS.Text = "КОЛИЧИНА :";
            lbRabatIzmjenaKS.Text = "РАБАТ (%) :";
            lbUkupoIzmjenaKS.Text = "УКУПНО :";
            lbStaraKolicinaIzmjenaKS.Text = "СТАРА КОЛИЧИНА :";
            btObracunajIzmjenaKS.Text = "ОБРАЧУНАЈ";
            btZapamtiIzmjenaKS.Text = "ЗАПАМТИ";


        }
        public void prevediNaEngleski()
        {
            lbBrojNalogaIzmjenaKS.Text = "TICKET NUMBER :";
            lbSifraKomponenteIzmjenaKS.Text = "CODE :";
            lbNazivIzmjenaKS.Text = "TITLE :";
            lbJedinicnaCijenaIzmjenaKS.Text = "UNIT PRICE :";
            lbKolicinaIzmjenaKS.Text = "QUANTITY :";
            lbRabatIzmjenaKS.Text = "DISCOUNT (%) :";
            lbUkupoIzmjenaKS.Text = "SUM :";
            lbStaraKolicinaIzmjenaKS.Text = "OLD QUANTITY :";
            btObracunajIzmjenaKS.Text = "CALCULATE";
            btZapamtiIzmjenaKS.Text = "SAVE";
        }
    }
}
