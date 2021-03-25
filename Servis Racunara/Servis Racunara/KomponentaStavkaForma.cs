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
    public partial class KomponentaStavkaForma : Form
    {
       public GlavnaForma GlavnaFormaKS;
        public KomponentaStavkaForma()
        {
            InitializeComponent();
            napunidgvKomponentaStavka();

        }
        public KomponentaStavkaForma(string BrojNaloga)
        {
            InitializeComponent();
            napunidgvKomponentaStavka();
            tbBrojNalogaKS.Text = BrojNaloga;
            tbRabatKS.Text = "0";

        }

        private void KomponentaStavka_Load(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            btDodajNaNalog.Enabled = false;
        }
        private void napunidgvKomponentaStavka()
        {
            dgvKomponentaStavka.Rows.Clear();
            foreach (var k in DbServisRacunara.GetKomponenteFilter(tbFilterKS.Text))
            {
                DataGridViewRow row = new DataGridViewRow()
                {
                    Tag = k

                };
                row.CreateCells(dgvKomponentaStavka, k.SifraKomponente,k.NazivKomponente,k.CijenaKomponente,k.DostupnaKolicina);
                dgvKomponentaStavka.Rows.Add(row);
            }
        }

        private void tbFilterKS_TextChanged(object sender, EventArgs e)
        {
            napunidgvKomponentaStavka();
        }

        private void btObracunajKS_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(tbKolicinaKS.Text) || String.IsNullOrEmpty(tbRabatKS.Text))
                {
                    MessageBox.Show("MORATE POPUNITI SVA ZAHTJEVANA POLJA", "GRESKA PRAZNO POLJE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if ((Int32.Parse(tbDostupnoKS.Text) - Int32.Parse(tbKolicinaKS.Text)) < 0)
                {
                    MessageBox.Show("GRESKA! TRAZITE VISE KOMPONENTI NEGO STO IH IMA NA STANJU", "GRESKA BROJA KOMPONENTI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tbKolicinaKS.Text = "";
                }
                else
                {
                    try
                    {
                        decimal rabat = Decimal.Parse(tbRabatKS.Text);
                        int kolicina = Int32.Parse(tbKolicinaKS.Text);
                        decimal jedinicnaCijena = Decimal.Parse(tbJedinicnaCijenaKS.Text);
                        tbUkupnaCijenaKS.Text = Math.Round((((1 - (rabat / 100)) * jedinicnaCijena) * kolicina), 2).ToString();
                        btDodajNaNalog.Enabled = true;
                    }
                    catch (Exception Ex)
                    {
                        tbKolicinaKS.Text = "";
                        tbRabatKS.Text = "";
                        MessageBox.Show("Unesene vrijednosti moraju biti brojevi, i usluga mora biti selektovana", "GRESKA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch(FormatException fx)
            {
                MessageBox.Show("GRESKA! VRIJEDNOSTI MORAJU BITI BROJEVNE", "GRESKA VRIJEDNSOTI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
        }


        private void dgvKomponentaStavka_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvKomponentaStavka.Columns[e.ColumnIndex].Name == "ColumnOznaci")
            {
                btDodajNaNalog.Enabled = true;

                tbSifraKomponenteKS.Text = dgvKomponentaStavka.Rows[e.RowIndex].Cells[ColumnSifraKomponenteKS.Index].Value.ToString();
                tbNazivKS.Text = dgvKomponentaStavka.Rows[e.RowIndex].Cells[ColumnNazivKS.Index].Value.ToString();
                tbJedinicnaCijenaKS.Text = dgvKomponentaStavka.Rows[e.RowIndex].Cells[ColumnCijenaPoKomaduKS.Index].Value.ToString();
                tbDostupnoKS.Text= dgvKomponentaStavka.Rows[e.RowIndex].Cells[ColumnDostupnaKolicinaKS.Index].Value.ToString();


            }
        }

        private void tbKolicinaKS_TextChanged(object sender, EventArgs e)
        {
            btDodajNaNalog.Enabled = false;
        }

        private void btDodajNaNalog_Click(object sender, EventArgs e)
        {
            var komponenta = new KomponentaStavka()
            {
                SifraKomponente = Int32.Parse(tbSifraKomponenteKS.Text),
                BrojNaloga = Int32.Parse(tbBrojNalogaKS.Text),
                ZahtjevanaKolicina = Int32.Parse(tbKolicinaKS.Text),
                JedinicnaCijena = Decimal.Parse(tbJedinicnaCijenaKS.Text),
                Rabat = Decimal.Parse(tbRabatKS.Text),
                UkupnaCijena = Decimal.Parse(tbUkupnaCijenaKS.Text),
                DostupnaKolicina = Int32.Parse(tbDostupnoKS.Text),

            };
            DbServisRacunara.InsertKomponentaStavkaNaNalog(komponenta);

            MessageBox.Show("Uspjesno ste dodali stavku", "USPJESNO DODAVANJE KOMPONENTE", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
