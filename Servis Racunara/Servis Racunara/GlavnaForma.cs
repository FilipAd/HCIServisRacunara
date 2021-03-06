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
    public partial class GlavnaForma : Form
    {
        public SubjekatForma SubjekatFormaGF;
        public KomponentaForma KomponentaFormaGF;
        public UslugaStavkaForma UslugaFormaGF;
        public KomponentaStavkaForma KomponentaStavkaFormaGF;
        public IzmjenaKSForma IzmjenaKSFormaGF;
        public IzmjenaUSForma IzmjenaUSFormaGF;
        public GlavnaForma()
        {
            InitializeComponent();
            napuniZaprimioComboBox();
            napuniRadiComboBox();
            napuniDgvNeproknjizeni();
            napuniDgvProknjizeni();
            
        }

        private void napuniDgvNeproknjizeni()
        {
            {
                dgvNeproknjizeni.Rows.Clear();
                foreach (var n in DbServisRacunara.GetRadniNaloziNeproknjizeni(tbFilterNalog.Text))
                {
                    DataGridViewRow row = new DataGridViewRow()
                    {
                        Tag = n

                    };
                    row.CreateCells(dgvNeproknjizeni, n.BrojRadnogNaloga, n.DatumKreiranja,n.ImeKlijenta,n.Status,n.IdKlijenta);
                    dgvNeproknjizeni.Rows.Add(row);
                }
            }
        }
        private void napuniDgvProknjizeni()
        {
            {
                dgvProknjizeni.Rows.Clear();
                foreach (var n in DbServisRacunara.GetRadniNaloziProknjizeni(tbFilterNalog.Text))
                {
                    DataGridViewRow row = new DataGridViewRow()
                    {
                        Tag = n

                    };
                    row.CreateCells(dgvProknjizeni, n.BrojRadnogNaloga, n.DatumKreiranja, n.ImeKlijenta, n.Status, n.IdKlijenta);
                    dgvProknjizeni.Rows.Add(row);
                }
            }
        }

        private void napuniDgvKomponentaStavka()
        {
           dgvKomponentaStavka.Rows.Clear();
            int BrojNlaoga = Int32.Parse(tbBrojRadnogNaloga.Text);
      
            foreach (var ks in DbServisRacunara.GetKomponentaStavke(BrojNlaoga))
            {
                DataGridViewRow row = new DataGridViewRow()
                {
                    Tag = ks

                };
               
                row.CreateCells(dgvKomponentaStavka,ks.SifraKomponente, ks.NazivKomponente,ks.ZahtjevanaKolicina,ks.JedinicnaCijena,ks.Rabat,ks.UkupnaCijena);
                dgvKomponentaStavka.Rows.Add(row);
            }
            prikaziKolikoTrebaDaSePlati();
        }
        private void napuniDgvUslugaStavka()
        {
            dgvUslugaStavka.Rows.Clear();
            int BrojNaloga = Int32.Parse(tbBrojRadnogNaloga.Text);
           
            foreach (var us in DbServisRacunara.GetUslugaStavke(BrojNaloga))
            {
                DataGridViewRow row = new DataGridViewRow()
                {
                    Tag = us

                };
               
                row.CreateCells(dgvUslugaStavka, us.SifraUsluge,us.NazivUsluge, us.Kolicina,us.CijenaPoH, us.Rabat, us.UkupnaCijena);
                dgvUslugaStavka.Rows.Add(row);
            }
            prikaziKolikoTrebaDaSePlati();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtpDatumZavrsetka_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbStatus.Text=="ZAHTJEV ZA SERVISOM")
            {
                lbStatus.BackColor = Color.Red;
            }
            else if (cbStatus.Text == "RADI SE")
            {
                lbStatus.BackColor = Color.LightGreen;
            }
            else if (cbStatus.Text == "ZAVRSEN")
            {
                lbStatus.BackColor = Color.Pink;
            }
        }

        private void lbStatus_Click(object sender, EventArgs e)
        {

        }

        private void rbNeproknjizeni_CheckedChanged(object sender, EventArgs e)
        {
            tcNalozi.SelectTab("tabPageNeproknjizeni");
        }

        private void rbProknjizeni_CheckedChanged(object sender, EventArgs e)
        {
            tcNalozi.SelectTab("tabPageProknjizeni");
        }

        private void tcNalozi_Selected(object sender, TabControlEventArgs e)
        {
          
        }

        private void tpProknjizeni_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SubjekatFormaGF = new SubjekatForma();
            SubjekatFormaGF.GlavnaFormaSF = this;
            SubjekatFormaGF.ShowDialog();
        }

        private void Form1_MouseHover(object sender, EventArgs e)
        {
           
        }

        private void btSubjekat_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Registar Subjekata", btnSubjekat);
        }

        private void btnKomponenta_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Registar Komponenti", btnKomponenta);
        }

        private void GlavnaForma_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void lvProknjizeni_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lvKomponenta_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       private void btnKlijentIzBaze_MouseHover(object sender, EventArgs e)
        {
       //     toolTip1.Show("Izaberi postojeceg klijenta", btnKlijentIzBaze);
        }

        private void lbBroj_Click(object sender, EventArgs e)
        {

        }

        private void btnKomponenta_Click(object sender, EventArgs e)
        {
            KomponentaFormaGF= new KomponentaForma();
            KomponentaFormaGF.GlavnaFormaKOM = this;
            KomponentaFormaGF.ShowDialog();
           
        }

        private void btnKlijentIzBaze_Click(object sender, EventArgs e)
        {

         //   new OdabirKlijentaIzBaze().ShowDialog();

        }
        public void napuniZaprimioComboBox()
        {

            List<PrikazRadnika> radnici = DbServisRacunara.GetRadnici();
            foreach (PrikazRadnika radnik in radnici)
            {
                {
                    ComboBoxItem item = new ComboBoxItem(radnik.Ime, radnik.IdPartnera);
                    cbZaprimio.Items.Add(item);
                }
            }
        }
        public void napuniRadiComboBox()
        {

            List<PrikazRadnika> radnici = DbServisRacunara.GetRadnici();
            foreach (PrikazRadnika radnik in radnici)
            {
                ComboBoxItem item = new ComboBoxItem(radnik.Ime, radnik.IdPartnera);

                cbRadi.Items.Add(item);


            }
        }



        public void SetTbKlijent(string tekst)
        {
            tbKlijentGF.Text = tekst;
        }
        private void btNoviRadniNalog_Click(object sender, EventArgs e)
        {
            SubjekatFormaGF = new SubjekatForma();
            SubjekatFormaGF.GlavnaFormaSF = this;
            SubjekatFormaGF.ShowDialog();
            btSacuvajNalog.Enabled = true;
            
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(cbStatus.Text) || String.IsNullOrEmpty(cbRadi.Text) || String.IsNullOrEmpty(cbZaprimio.Text) || String.IsNullOrEmpty(tbBrojRadnogNaloga.Text))
            {
                MessageBox.Show("MORATE OZNACITI KO RADI, KO JE KREIRAO NALOG,STATUS,TAKODJE MORA POSTOJATI BROJ RADNOG NALOGA", "NEUSPJESNO AZURIRANJE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btSacuvajIzmjene.Enabled = false;
            }
            else
            {
                var nalog = new RadniNalog()
                {
                    BrojRadnogNaloga = Int32.Parse(tbBrojRadnogNaloga.Text),
                    OpisZahtjeva = tbZahtjev.Text,
                    Napomena = tbNapomena.Text,
                    DatumKreiranja = dtpDatumKreiranja.Value,
                    DatumZavrsetka = dtpDatumZavrsetka.Value,
                    Status = cbStatus.SelectedItem.ToString(),
                    IdRadnikaZaprimio = (cbZaprimio.SelectedItem as ComboBoxItem).Vrijednost,
                    IdServiseraRadi=(cbRadi.SelectedItem as ComboBoxItem).Vrijednost,
               
                };
                DbServisRacunara.UpdateRandiNalog(nalog);
                btSacuvajIzmjene.Enabled = false;

            }
        }

        private void btSacuvajNalog_Click(object sender, EventArgs e)
        {

        if(String.IsNullOrEmpty(cbRadi.Text) || String.IsNullOrEmpty(cbZaprimio.Text) || String.IsNullOrEmpty(cbStatus.Text))
            {
                MessageBox.Show("MORATE NAVESTI KO RADI NALOG I KO GA JE ZAPRIMIO KAO I STATUS NALOGA", "GRESKA NEMA RADNIKA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
          else
            {
                string IdServiserRadi = null;
                string IdServiserZaprimio = null;


                var nalog = new RadniNalog()
                {
                    OpisZahtjeva = tbZahtjev.Text,
                    Napomena = tbNapomena.Text,
                    IdRadnikaZaprimio = (cbZaprimio.SelectedItem as ComboBoxItem).Vrijednost,
                    IdServiseraRadi = (cbRadi.SelectedItem as ComboBoxItem).Vrijednost,
                    Status = cbStatus.SelectedItem.ToString(),
                    DatumKreiranja = dtpDatumKreiranja.Value,
                    IdKlijenta = Int32.Parse(tbIdKlijentaGF.Text),
                    DatumZavrsetka = dtpDatumZavrsetka.Value

                };

                DbServisRacunara.InsertRadniNalog(nalog);
                MessageBox.Show(tbIdKlijentaGF.Text);
                tbBrojRadnogNaloga.Text = nalog.BrojRadnogNaloga.ToString();
                napuniDgvNeproknjizeni();
                btSacuvajNalog.Enabled = false;
            }
        }

        private void tbFilterNalog_TextChanged(object sender, EventArgs e)
        {
            napuniDgvNeproknjizeni();
        }

        private void dgvNeproknjizeni_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tbBrojRadnogNaloga.Text = dgvNeproknjizeni.Rows[e.RowIndex].Cells[ColumnBrojNaloga.Index].Value.ToString();
            tbKlijentGF.Text= dgvNeproknjizeni.Rows[e.RowIndex].Cells[ColumnImeKlijentaN.Index].Value.ToString();
            cbStatus.SelectedIndex = cbStatus.FindStringExact(dgvNeproknjizeni.Rows[e.RowIndex].Cells[ColumnStatusN.Index].Value.ToString());
            tbIdKlijentaGF.Text = dgvNeproknjizeni.Rows[e.RowIndex].Cells[ColumnIdPartnera.Index].Value.ToString();
            RadniNalogPrikaz np = DbServisRacunara.GetRadniNalogNeproknjizenielementi((int)dgvNeproknjizeni.Rows[e.RowIndex].Cells[ColumnBrojNaloga.Index].Value);
            tbNapomena.Text = np.Napomena;
            tbZahtjev.Text = np.OpisZahtjeva;
            dtpDatumKreiranja.Value = np.DatumKreiranja;
            dtpDatumZavrsetka.Value = np.DatumZavrsetka;
            cbRadi.SelectedIndex = cbRadi.FindStringExact(np.ImeServiseraKojiRadi + "-" + np.IdServiseraRadi);
            cbZaprimio.SelectedIndex = cbZaprimio.FindStringExact(np.ImeRadnikaKojiJeZaprimio + "-" + np.IdRadnikaZaprimio);
            napuniDgvKomponentaStavka();
            napuniDgvUslugaStavka();
          


        }

        private void button1_Click_1(object sender, EventArgs e) //dodaj uslugu
        {
            if (String.IsNullOrEmpty(tbBrojRadnogNaloga.Text))
            {
                MessageBox.Show("MORATE SELEKTOVATI RADNI NALOG ", "GRESKA NIJE ODABRAN NALOG", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                UslugaFormaGF = new UslugaStavkaForma(tbBrojRadnogNaloga.Text);
                UslugaFormaGF.GlavnaFormaUSLUGA = this;
                UslugaFormaGF.ShowDialog();
            }
        }

        private void button2_Click(object sender, EventArgs e) //dodaj komponentu
        {
            if (String.IsNullOrEmpty(tbBrojRadnogNaloga.Text))
            {
                MessageBox.Show("MORATE SELEKTOVATI RADNI NALOG ", "GRESKA NIJE ODABRAN NALOG", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                KomponentaStavkaFormaGF = new KomponentaStavkaForma(tbBrojRadnogNaloga.Text);
                KomponentaStavkaFormaGF.GlavnaFormaKS = this;
                KomponentaStavkaFormaGF.ShowDialog();
            }
        }

        private void btOsvjeziUsluguKomponente_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbBrojRadnogNaloga.Text))
            {
                MessageBox.Show("MORATE SELEKTOVATI RADNI NALOG ", "GRESKA NIJE ODABRAN NALOG", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                napuniDgvKomponentaStavka();
                napuniDgvUslugaStavka();
                napuniDgvNeproknjizeni();
                
            }
        }

        private void tcUslugaKomponenta_Click(object sender, EventArgs e)
        {
            
        }

        private void lbVrUsluge_Click(object sender, EventArgs e)
        {

        }
        private void prikaziKolikoTrebaDaSePlati()
        {
            int brNaloga = Int32.Parse(tbBrojRadnogNaloga.Text);
            lbVrUsluge.Text = DbServisRacunara.GetUslugeZaPlatiti(brNaloga).ToString();
            lbVrKomponente.Text = DbServisRacunara.GetKomponentiZaPlatiti(brNaloga).ToString();
            lbVrUkupno.Text = (Decimal.Parse(lbVrKomponente.Text) + Decimal.Parse(lbVrUsluge.Text)).ToString();
        }

        private void dgvUslugaStavka_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvUslugaStavka.Columns[e.ColumnIndex].Name == "ColumnIzmjeniStavkuUsluge")
            {
                IzmjenaUSFormaGF = new IzmjenaUSForma();
                IzmjenaUSFormaGF.tbBrojNalogaIzmjenaUS.Text = tbBrojRadnogNaloga.Text;
                IzmjenaUSFormaGF.tbSifraIzmejnaUS.Text = dgvUslugaStavka.Rows[e.RowIndex].Cells[ColumnSifraUsluge.Index].Value.ToString();
                IzmjenaUSFormaGF.tbNazivIzmjenaUS.Text = dgvUslugaStavka.Rows[e.RowIndex].Cells[ColumnNazivUsluge.Index].Value.ToString();
                IzmjenaUSFormaGF.tbCijenaPoHIzmjenaUS.Text = dgvUslugaStavka.Rows[e.RowIndex].Cells[ColumnCijena.Index].Value.ToString();
                IzmjenaUSFormaGF.tbKolicinaIzmjenaUS.Text = dgvUslugaStavka.Rows[e.RowIndex].Cells[ColumnKolicinaUsluge.Index].Value.ToString();
                IzmjenaUSFormaGF.tbRabatIzmejnaUS.Text = dgvUslugaStavka.Rows[e.RowIndex].Cells[ColumnRabat.Index].Value.ToString();
                IzmjenaUSFormaGF.tbUkupnoIzmjenaUS.Text = dgvUslugaStavka.Rows[e.RowIndex].Cells[ColumnUkupnaCijena.Index].Value.ToString();
                IzmjenaUSFormaGF.tbIzmjenaUSStaraKolicina.Text= dgvUslugaStavka.Rows[e.RowIndex].Cells[ColumnKolicinaUsluge.Index].Value.ToString();
                IzmjenaUSFormaGF.ShowDialog();

            }
            else if(dgvUslugaStavka.Columns[e.ColumnIndex].Name == "ColumnObrisiStavkuUsluge")
            {
                if (MessageBox.Show("Da li ste sigruni da zelite da obrisete ovu stavku?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    var us = new UslugaStavka()
                    {
                        BrojRadnogNaloga = Int32.Parse(tbBrojRadnogNaloga.Text),
                        SifraUsluge=Int32.Parse(dgvUslugaStavka.Rows[e.RowIndex].Cells[ColumnSifraUsluge.Index].Value.ToString())

                    };
                    DbServisRacunara.DeleteUslugaStavka(us);
                    MessageBox.Show("Uspjesno obrisana stavka ", "Uspjesno Brisanje Usluge", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }

        }

        private void dgvKomponentaStavka_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgvKomponentaStavka.Columns[e.ColumnIndex].Name == "ColumnIzmjeniKS")
            {
                if (DbServisRacunara.ProvjeriDaLiJeKomponentaObrisana(Int32.Parse(tbBrojRadnogNaloga.Text)) == 1)
                {
                    MessageBox.Show("KOMPONENTA JE OBRISANA IZ REGISTRA I NIJE JE MOGUCE MJENJATI", "KOMPONENTA OBRISANA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    IzmjenaKSFormaGF = new IzmjenaKSForma();
                    IzmjenaKSFormaGF.tbBrojNalogaIzmjenaKS.Text = tbBrojRadnogNaloga.Text;
                    IzmjenaKSFormaGF.tbSifraIzmjenaKS.Text = dgvKomponentaStavka.Rows[e.RowIndex].Cells[ColumnSifraKomponente.Index].Value.ToString();
                    IzmjenaKSFormaGF.tbNazivIzmjenaKS.Text = dgvKomponentaStavka.Rows[e.RowIndex].Cells[ColumnNazivKomponente.Index].Value.ToString();
                    IzmjenaKSFormaGF.tbJedinicnaCijenaIzmjenaKS.Text = dgvKomponentaStavka.Rows[e.RowIndex].Cells[ColumnCijenaKomponente.Index].Value.ToString();
                    IzmjenaKSFormaGF.tbKolicinaIzmjenaKS.Text = dgvKomponentaStavka.Rows[e.RowIndex].Cells[ColumnKolicinaKomponente.Index].Value.ToString();
                    IzmjenaKSFormaGF.tbRabatIzmjenaKS.Text = dgvKomponentaStavka.Rows[e.RowIndex].Cells[ColumnRabatKomponente.Index].Value.ToString();
                    IzmjenaKSFormaGF.tbUkupnoIzmjenaKS.Text = dgvKomponentaStavka.Rows[e.RowIndex].Cells[ColumnUkupnaCijenaKomponente.Index].Value.ToString();
                    IzmjenaKSFormaGF.tbStaraKolicinaIzmjenaKS.Text = dgvKomponentaStavka.Rows[e.RowIndex].Cells[ColumnKolicinaKomponente.Index].Value.ToString();
                    IzmjenaKSFormaGF.ShowDialog();
                }
                
            }
            else if (dgvKomponentaStavka.Columns[e.ColumnIndex].Name == "ColumnObrisiKS")
            {
                if (MessageBox.Show("Da li ste sigruni da zelite da obrisete ovu stavku?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    var ks = new KomponentaStavka()
                    {
                        BrojNaloga = Int32.Parse(tbBrojRadnogNaloga.Text),
                        SifraKomponente = Int32.Parse(dgvKomponentaStavka.Rows[e.RowIndex].Cells[ColumnSifraKomponente.Index].Value.ToString()),
                        Razlika=Int32.Parse(dgvKomponentaStavka.Rows[e.RowIndex].Cells[ColumnKolicinaKomponente.Index].Value.ToString()),
                       
                    };
                    DbServisRacunara.DeleteKomponentaStavka(ks);
                    MessageBox.Show("Uspjesno obrisana stavka ", "Uspjesno Brisanje Usluge", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbBrojRadnogNaloga.Text))
            {
                MessageBox.Show("MORATE OZNACITI RADNI NALOG", "NEUSPJESNO BRISANJE NALOGA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Da li ste sigruni da zelite da obrisete ovaj nalog?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int brojNaloga = Int32.Parse(tbBrojRadnogNaloga.Text);
                    DbServisRacunara.ObrisSveStavkeUslugeSaRadnogNaloga(brojNaloga);

                    if (DbServisRacunara.VratiBrojStavkiKomponentiSaNaloga(Int32.Parse(tbBrojRadnogNaloga.Text)) > 0)
                    {
                        MessageBox.Show("MORATE OBRISATI SVE KOMPONENTE SA NALOGA DA BI STE MOGLI OBRISATI NALOG", "NEUSPJESNO BRISANJE NALOGA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        DbServisRacunara.DeleteRadniNalog(Int32.Parse(tbBrojRadnogNaloga.Text));
                        MessageBox.Show("USPJESNO STE OBRISALI RADNI NALOG", "USPJESNO BRISANJE NALOGA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                   
                }
            }
            
        }

        private void btIzmjenaNaloga_Click(object sender, EventArgs e)
        {
            btSacuvajIzmjene.Enabled = true;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btProknjizi_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(tbBrojRadnogNaloga.Text))
            {
                MessageBox.Show("NISTE ODABRALI NALOG", "GRESKA PROKNJIZAVANJA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Da li ste sigruni da zelite da proknjizite ovaj nalog?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    DbServisRacunara.ProknjiziNalog(Int32.Parse(tbBrojRadnogNaloga.Text));
                    napuniDgvProknjizeni();
                    napuniDgvNeproknjizeni();
                }
            }
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tbBrojRadnogNaloga.Text = dgvProknjizeni.Rows[e.RowIndex].Cells[ColumnBrojNalogaP.Index].Value.ToString();
            tbKlijentGF.Text = dgvProknjizeni.Rows[e.RowIndex].Cells[ColumnImeP.Index].Value.ToString();
            cbStatus.SelectedIndex = cbStatus.FindStringExact(dgvProknjizeni.Rows[e.RowIndex].Cells[ColumnStatusP.Index].Value.ToString());
            tbIdKlijentaGF.Text = dgvProknjizeni.Rows[e.RowIndex].Cells[ColumnIdPartneraProknjizeni.Index].Value.ToString();
            RadniNalogPrikaz np = DbServisRacunara.GetRadniNalogNeproknjizenielementi((int)dgvProknjizeni.Rows[e.RowIndex].Cells[ColumnBrojNalogaP.Index].Value);
            tbNapomena.Text = np.Napomena;
            tbZahtjev.Text = np.OpisZahtjeva;
            dtpDatumKreiranja.Value = np.DatumKreiranja;
            dtpDatumZavrsetka.Value = np.DatumZavrsetka;
            cbRadi.SelectedIndex = cbRadi.FindStringExact(np.ImeServiseraKojiRadi + "-" + np.IdServiseraRadi);
            cbZaprimio.SelectedIndex = cbZaprimio.FindStringExact(np.ImeRadnikaKojiJeZaprimio + "-" + np.IdRadnikaZaprimio);
            napuniDgvKomponentaStavka();
            napuniDgvUslugaStavka();

        }

        private void button1_Click_3(object sender, EventArgs e)
        {
            napuniDgvNeproknjizeni();
            napuniDgvProknjizeni();
        }
    }
}
