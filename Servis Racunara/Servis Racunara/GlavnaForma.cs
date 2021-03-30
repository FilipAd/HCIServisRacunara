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
        public PrijavaForma PrijavaForma;
        public PromjenaLozinkeForma PromjenaLozinkeFormaGF;
        public GlavnaForma()
        {
            InitializeComponent();
            napuniZaprimioComboBox();
            napuniRadiComboBox();
            napuniDgvNeproknjizeni();
            napuniDgvProknjizeni();
            rbPrevediNaSrpski.Checked = true;
            
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
            string []el = lbKorisnickoIme.Text.Split('-');
            int id = Int32.Parse(el[1]);
            SubjekatFormaGF = new SubjekatForma();
            SubjekatFormaGF.GlavnaFormaSF = this;
            if (DbServisRacunara.GetPrivilegije(id) != 1)
                SubjekatFormaGF.ukiniPrivilegije();
            if(rbPrevediNaSrpski.Checked)
            SubjekatFormaGF.prevediNaSrpski();
            else if(rbPrevediNaengleski.Checked)
            {
                SubjekatFormaGF.prevediNaEngleski();
            }
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
            if (rbPrevediNaSrpski.Checked)
            {
                KomponentaFormaGF.prevediNaSrpski();
            }
            else if(rbPrevediNaengleski.Checked)
            {
                KomponentaFormaGF.prevediNaEngleski();
            }
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
            string[] el = lbKorisnickoIme.Text.Split('-');
            int id = Int32.Parse(el[1]);
            if (DbServisRacunara.GetPrivilegije(id) != 1)
                SubjekatFormaGF.ukiniPrivilegije();
            if (rbPrevediNaSrpski.Checked)
                SubjekatFormaGF.prevediNaSrpski();
            else if (rbPrevediNaengleski.Checked)
            {
                SubjekatFormaGF.prevediNaEngleski();
            }

            SubjekatFormaGF.ShowDialog();
            btSacuvajNalog.Enabled = true;
            
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(cbStatus.Text) || String.IsNullOrEmpty(cbRadi.Text) || String.IsNullOrEmpty(cbZaprimio.Text) || String.IsNullOrEmpty(tbBrojRadnogNaloga.Text))
            {
                string eng = "FIELDS: ASSIGNED,CREATED BY and STATUS are required";
                string srb = "МОРАТЕ ОЗНАЧИТИ КО РАДИ, КО ЈЕ КРЕИРАО НАЛОГ, СТАТУС ТАКОЂЕ МОРА ПОСТОЈАТИ БРОЈ РАДНОГ НАЛОГА";

                MessageBox.Show((rbPrevediNaSrpski.Checked) ? srb : eng, "NEUSPJESNO AZURIRANJE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
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

        if(String.IsNullOrEmpty(cbZaprimio.Text) || String.IsNullOrEmpty(cbStatus.Text))
            {
              
                string srb = "МОРАТЕ НАВЕСТИ КО ЈЕ ЗАПРИМИО КАО И СТАТУС НАЛОГА";
                string eng = "FIELDS: CREATED BY and STATUS are required";
                
                MessageBox.Show((rbPrevediNaSrpski.Checked) ? srb : eng, "GRESKA NEMA RADNIKA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
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
                    Status = cbStatus.SelectedItem.ToString(),
                    DatumKreiranja = dtpDatumKreiranja.Value,
                    IdKlijenta = Int32.Parse(tbIdKlijentaGF.Text),
                    DatumZavrsetka = dtpDatumZavrsetka.Value

                };
                if (cbRadi.SelectedItem as ComboBoxItem is null)
                {

                }
                else
                    nalog.IdServiseraRadi = (cbRadi.SelectedItem as ComboBoxItem).Vrijednost;

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
                
                string srb = "МОРАТЕ СЕЛЕКТОВАТИ РАДНИ НАЛОГ";
                string eng = "YOU HAVE TO SELECT TICKET";

                MessageBox.Show((rbPrevediNaSrpski.Checked) ? srb : eng, "GRESKA NIJE ODABRAN NALOG", MessageBoxButtons.OK, MessageBoxIcon.Error);
           
              
            }
            else
            {
                UslugaFormaGF = new UslugaStavkaForma(tbBrojRadnogNaloga.Text);
                UslugaFormaGF.GlavnaFormaUSLUGA = this;
                if (rbPrevediNaSrpski.Checked)
                    UslugaFormaGF.prevediNasrpski();
                else if(rbPrevediNaengleski.Checked)
                    UslugaFormaGF.prevediNaEngleski();
                UslugaFormaGF.ShowDialog();
            }
        }

        private void button2_Click(object sender, EventArgs e) //dodaj komponentu
        {
            if (String.IsNullOrEmpty(tbBrojRadnogNaloga.Text))
            {
                string eng = "TICKET IS NOT SELECTED";
                string srb = "МОРАТЕ СЕЛЕКТОВАТИ РАДНИ НАЛОГ";
                MessageBox.Show((rbPrevediNaSrpski.Checked)? srb:eng, "GRESKA NIJE ODABRAN NALOG", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                KomponentaStavkaFormaGF = new KomponentaStavkaForma(tbBrojRadnogNaloga.Text);
                KomponentaStavkaFormaGF.GlavnaFormaKS = this;
                if (rbPrevediNaSrpski.Checked)
                    KomponentaStavkaFormaGF.prevediNaSrpski();
                else if (rbPrevediNaengleski.Checked)
                    KomponentaStavkaFormaGF.prevediNaEngleski();
                KomponentaStavkaFormaGF.ShowDialog();
            }
        }

        private void btOsvjeziUsluguKomponente_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbBrojRadnogNaloga.Text))
            {
             string   eng = "TICKET IS NOT SELECTED";
                string srb = "МОРАТЕ СЕЛЕКТОВАТИ РАДНИ НАЛОГ";
                if (rbPrevediNaSrpski.Checked)
                MessageBox.Show(srb, "GRESKA NIJE ODABRAN NALOG", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else if(rbPrevediNaengleski.Checked)
                    MessageBox.Show(eng,"TICKET IS NOT SELECTED ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

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
                if (dgvUslugaStavka.Rows[e.RowIndex].Cells[ColumnSifraUsluge.Index].Value !=null)
                {
                    IzmjenaUSFormaGF = new IzmjenaUSForma();
                    IzmjenaUSFormaGF.GlavnaFormaIUS = this;
                    if (rbPrevediNaSrpski.Checked)
                        IzmjenaUSFormaGF.prevediNaSrpski();
                    else if (rbPrevediNaengleski.Checked)
                        IzmjenaUSFormaGF.prevediNaEngleski();
                    IzmjenaUSFormaGF.tbBrojNalogaIzmjenaUS.Text = tbBrojRadnogNaloga.Text;
                    IzmjenaUSFormaGF.tbSifraIzmejnaUS.Text = dgvUslugaStavka.Rows[e.RowIndex].Cells[ColumnSifraUsluge.Index].Value.ToString();
                    IzmjenaUSFormaGF.tbNazivIzmjenaUS.Text = dgvUslugaStavka.Rows[e.RowIndex].Cells[ColumnNazivUsluge.Index].Value.ToString();
                    IzmjenaUSFormaGF.tbCijenaPoHIzmjenaUS.Text = dgvUslugaStavka.Rows[e.RowIndex].Cells[ColumnCijena.Index].Value.ToString();
                    IzmjenaUSFormaGF.tbKolicinaIzmjenaUS.Text = dgvUslugaStavka.Rows[e.RowIndex].Cells[ColumnKolicinaUsluge.Index].Value.ToString();
                    IzmjenaUSFormaGF.tbRabatIzmejnaUS.Text = dgvUslugaStavka.Rows[e.RowIndex].Cells[ColumnRabat.Index].Value.ToString();
                    IzmjenaUSFormaGF.tbUkupnoIzmjenaUS.Text = dgvUslugaStavka.Rows[e.RowIndex].Cells[ColumnUkupnaCijena.Index].Value.ToString();
                    IzmjenaUSFormaGF.tbIzmjenaUSStaraKolicina.Text = dgvUslugaStavka.Rows[e.RowIndex].Cells[ColumnKolicinaUsluge.Index].Value.ToString();
                    IzmjenaUSFormaGF.ShowDialog();
                }
                else
                    MessageBox.Show("Stisnuli ste prazno polje", "Greska praznog polja", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(dgvUslugaStavka.Columns[e.ColumnIndex].Name == "ColumnObrisiStavkuUsluge")
            {
                if (dgvUslugaStavka.Rows[e.RowIndex].Cells[ColumnSifraUsluge.Index].Value != null)
                {
                    string eng = "Are you sure you want to delete this item";
                    string srb = "Да ли сте сигурно да желите да обришете ову ставку?";
                    if (MessageBox.Show((rbPrevediNaSrpski.Checked) ? srb : eng, "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        var us = new UslugaStavka()
                        {
                            BrojRadnogNaloga = Int32.Parse(tbBrojRadnogNaloga.Text),
                            SifraUsluge = Int32.Parse(dgvUslugaStavka.Rows[e.RowIndex].Cells[ColumnSifraUsluge.Index].Value.ToString())

                        };
                        DbServisRacunara.DeleteUslugaStavka(us);
                        string eng1 = "Successfully deleted item";
                        string srb1 = "Успјешно обрисана ставка";
                        MessageBox.Show((rbPrevediNaSrpski.Checked) ? srb1 : eng1, "Uspjesno Brisanje Usluge", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
                else
                    MessageBox.Show("Stisnuli ste prazno polje", "Greska praznog polja", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void dgvKomponentaStavka_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgvKomponentaStavka.Columns[e.ColumnIndex].Name == "ColumnIzmjeniKS")
            {
                if (dgvKomponentaStavka.Rows[e.RowIndex].Cells[ColumnSifraKomponente.Index].Value != null)
                {
                    if (DbServisRacunara.ProvjeriDaLiJeKomponentaObrisana(Int32.Parse(tbBrojRadnogNaloga.Text)) == 1)
                    {
                        string srb = "КОМПОНЕНТА ЈЕ ОБРИСАНА ИЗ РЕГИСТРА И НИЈЕ МОГУЋЕ МЈЕЊАТИ ЈЕ";
                        string eng = "THE COMPONENT HAS BEEN DELETED FROM THE REGISTER AND CANNOT BE CHANGED";
                        MessageBox.Show((rbPrevediNaSrpski.Checked) ? srb : eng, "KOMPONENTA OBRISANA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        IzmjenaKSFormaGF = new IzmjenaKSForma();
                        IzmjenaKSFormaGF.GlavnaFormaIKS = this;
                        if (rbPrevediNaSrpski.Checked)
                            IzmjenaKSFormaGF.prevediNaSrpski();
                        else if (rbPrevediNaengleski.Checked)
                            IzmjenaKSFormaGF.prevediNaEngleski();
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
                else
                    MessageBox.Show("Stisnuli ste prazno polje", "Greska praznog polja", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (dgvKomponentaStavka.Columns[e.ColumnIndex].Name == "ColumnObrisiKS")
            {
                if (dgvKomponentaStavka.Rows[e.RowIndex].Cells[ColumnSifraKomponente.Index].Value != null)
                {
                    string eng = "Are you sure you want to delete this item";
                    string srb = "Да ли сте сигурни да желите обрисати ову ставку?";
                    if (MessageBox.Show((rbPrevediNaSrpski.Checked) ? srb : eng, "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        var ks = new KomponentaStavka()
                        {
                            BrojNaloga = Int32.Parse(tbBrojRadnogNaloga.Text),
                            SifraKomponente = Int32.Parse(dgvKomponentaStavka.Rows[e.RowIndex].Cells[ColumnSifraKomponente.Index].Value.ToString()),
                            Razlika = Int32.Parse(dgvKomponentaStavka.Rows[e.RowIndex].Cells[ColumnKolicinaKomponente.Index].Value.ToString()),

                        };
                        DbServisRacunara.DeleteKomponentaStavka(ks);
                        string eng1 = "Successfully deleted item";
                        string srb1 = "Успјешно обрисана ставка ";
                        MessageBox.Show((rbPrevediNaSrpski.Checked) ? srb1 : eng1, "Uspjesno Brisanje Usluge", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
                else
                    MessageBox.Show("Stisnuli ste prazno polje", "Greska praznog polja", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbBrojRadnogNaloga.Text))
            {
                string eng = "TICKET IS NOT SELECTED";
                string srb = "МОРАТЕ СЕЛЕКТОВАТИ РАДНИ НАЛОГ ";
                MessageBox.Show((rbPrevediNaSrpski.Checked)?eng:srb, "NEUSPJESNO BRISANJE NALOGA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string eng = "Are you sure you want to delete this ticket";
                string srb = "Да ли сте сигурни да желите обрисати овај налог?";
                if (MessageBox.Show((rbPrevediNaSrpski.Checked)?eng:srb, "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int brojNaloga = Int32.Parse(tbBrojRadnogNaloga.Text);
                    DbServisRacunara.ObrisSveStavkeUslugeSaRadnogNaloga(brojNaloga);

                    if (DbServisRacunara.VratiBrojStavkiKomponentiSaNaloga(Int32.Parse(tbBrojRadnogNaloga.Text)) > 0)
                    {

                        string eng1 = "You MUST DELETE ALL COMPONENTS FROM THE TICKET IN ORDER TO DELETE THE TICKET";
                        string srb1 = "МОРАТЕ ОБРИСАТИ СВЕ КОМПОНЕНТЕ СА НАЛОГА ДА БИ СТЕ МОГЛИ ОБРИСАТИ НАЛОГ";
                        MessageBox.Show((rbPrevediNaSrpski.Checked)?srb1:eng1, "NEUSPJESNO BRISANJE NALOGA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        DbServisRacunara.DeleteRadniNalog(Int32.Parse(tbBrojRadnogNaloga.Text));
                        string eng1 = "Successfully deleted ticket";
                        string srb1 = "Успјешно обрисан налог";
                        MessageBox.Show((rbPrevediNaSrpski.Checked) ? srb1 : eng1, "USPJESNO BRISANJE NALOGA", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                string eng = "TICKET IS NOT SELECTED";
                string srb = "МОРАТЕ СЕЛЕКТОВАТИ РАДНИ НАЛОГ ";
                MessageBox.Show((rbPrevediNaSrpski.Checked) ? srb : eng, "GRESKA PROKNJIZAVANJA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string eng = "Are you sure you want to process this ticket";
                string srb = "Да ли сте сигурни да желите да прокњижите овај налог?";
                if (MessageBox.Show((rbPrevediNaSrpski.Checked) ? srb : eng, "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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

        private void btPrevodNaEngleski_Click(object sender, EventArgs e)
        {
            prevediNaEngleski();
        }

        private void prevediNaSrpski()
        {
            btNoviRadniNalog.Text = "НАПРАВИ НОВИ РАДНИ НАЛОГ";
            btSacuvajNalog.Text = "САЧУВАЈ НАЛОГ";
            btIzmjenaNaloga.Text = "ИЗМЈЕНА НАЛОГА";
            btSacuvajIzmjene.Text = "САЧУВАЈ ИЗМЈЕНЕ";
            btObrisiNalog.Text = "ОБРИШИ НАЛОГ";
            btDodajUslugu.Text = "ДОДАЈ УСЛУГУ";
            btDodajKomponentu.Text = "ДОДАЈ КОМПОНЕНТУ";
            gbPlacanje.Text = "ИЗНОС ЗА ПЛАЋАЊЕ:";
            lbZaprimio.Text = "ЗАПРИМИО :";
            lbServiserRadi.Text = "РАДИ :";
            lbNapomena.Text = "НАПОМЕНА :";
            lbUkupnoUsluge.Text = "Услуге за уплату :";
            lbUkupnoKomponenti.Text = "Компоненти за уплату :";
            lbUkupanIznosZaUplatu.Text = "УКУПАН ИЗНОС ЗА УПЛАТУ :";
            lbKlijent.Text = "КЛИЈЕНТ :";
            lbIdKlijenta.Text = "ИД Клијента :";
            lbStatus.Text = "СТАТУС :";
            lbZahtjev.Text = "ЗАХТЈЕВ :";
            lbDatumKreiranja.Text = "Датум креирања :";
            lbDatumZavrsetka.Text = "Датум завршетка :";
            tabPageUsluga.Text = "УСЛУГА";
            tabPageKomponenta.Text = "КОМПОНЕНТА";
            lbBrRadnogNaloga.Text = "БР.Налога :";
            ColumnSifraUsluge.HeaderText = "Шифра";
            ColumnNazivUsluge.HeaderText = "Назив";
            ColumnKolicinaUsluge.HeaderText = "Кол.";
            ColumnCijena.HeaderText = "Јед.Цијена";
            ColumnRabat.HeaderText = "Рабат";
            ColumnUkupnaCijena.HeaderText = "Укупно";
            ColumnIzmjeniStavkuUsluge.HeaderText = "Измјени";
            ColumnObrisiStavkuUsluge.HeaderText = "Обриши";
            ColumnIzmjeniStavkuUsluge.Text = "Измјени";
            ColumnObrisiStavkuUsluge.Text = "Обриши";

            ColumnSifraKomponente.HeaderText = "Шифра";
            ColumnNazivKomponente.HeaderText = "Назив";
            ColumnKolicinaKomponente.HeaderText = "Кол.";
            ColumnCijenaKomponente.HeaderText = "Јед.Цијена";
            ColumnRabatKomponente.HeaderText = "Рабат";
            ColumnUkupnaCijenaKomponente.HeaderText = "Укупно";
            ColumnIzmjeniKS.HeaderText = "Измјени";
            ColumnObrisiKS.HeaderText = "Обриши";
            ColumnIzmjeniKS.Text = "Измјени";
            ColumnObrisiKS.Text = "Обриши";

            lbPretraziNalog.Text = "Претражи :";
            lbLogovaniSteKao.Text = "Корисник :";
            btProknjizi.Text = "ПРОКЊИЖИ НАЛОГ";
            rbNeproknjizeni.Text = "НЕПРОКЊИЖЕНИ НАЛОЗИ";
            rbProknjizeni.Text = "ПРОКЊИЖЕНИ НАЛОЗИ";
            tabPageProknjizeni.Text = "Прокњижени";
            tabPageNeproknjizeni.Text = "Непрокњижени";
            ColumnBrojNaloga.HeaderText = "Бр.Налога";
            ColumnDatumKreiranjaN.HeaderText = "ДатумКреирања";
            ColumnImeKlijentaN.HeaderText = "Име";
            ColumnStatusN.HeaderText = "Статус";
            ColumnIdPartnera.HeaderText = "ИдПартнера";

            ColumnBrojNalogaP.HeaderText = "Бр.Налога";
            ColumnDatumKreiranjaP.HeaderText = "ДатумКреирања";
            ColumnImeP.HeaderText = "Име";
            ColumnStatusP.HeaderText = "Статус";
            ColumnIdPartneraProknjizeni.HeaderText = "ИдПартнера";
            btPromjenaLozinke.Text = "Промјена лозинке";




        }

        private void prevediNaEngleski()
        {
            btNoviRadniNalog.Text = "NEW TICKET";
            btSacuvajNalog.Text = "SAVE TICKET";
            btIzmjenaNaloga.Text = "EDIT TICKET";
            btSacuvajIzmjene.Text = "SAVE CHANGES";
            btObrisiNalog.Text = "DELETE TICKET";
            btDodajUslugu.Text = "ADD SERVICE";
            btDodajKomponentu.Text = "ADD COMPONENT";
            gbPlacanje.Text = "AMOUNT FOR PAYMENT:";
            lbZaprimio.Text = "CREATED BY :";
            lbServiserRadi.Text = "ASIGNEE :";
            lbNapomena.Text = "NOTE :";
            lbUkupnoUsluge.Text = "Services :";
            lbUkupnoKomponenti.Text = "Components :";
            lbUkupanIznosZaUplatu.Text = "CHECKOUT :";
            lbKlijent.Text = "CLIENT :";
            lbIdKlijenta.Text = "Client ID :";
            lbStatus.Text = "STATUS :";
            lbZahtjev.Text = "REQUEST :";
            lbDatumKreiranja.Text = "Creation date :";
            lbDatumZavrsetka.Text = "Completion date :";
            tabPageUsluga.Text = "SERVICE";
            tabPageKomponenta.Text = "COMPONENT";
            lbBrRadnogNaloga.Text = "No.Ticket :";
            ColumnSifraUsluge.HeaderText = "Code";
            ColumnNazivUsluge.HeaderText = "Title";
            ColumnKolicinaUsluge.HeaderText = "quantity";
            ColumnCijena.HeaderText = "UnitPrice";
            ColumnRabat.HeaderText = "Discount";
            ColumnUkupnaCijena.HeaderText = "Sum";
            ColumnIzmjeniStavkuUsluge.HeaderText = "Edit";
            ColumnObrisiStavkuUsluge.HeaderText = "Delete";
            ColumnIzmjeniStavkuUsluge.Text = "Edit";
            ColumnObrisiStavkuUsluge.Text = "Delete";

            ColumnSifraKomponente.HeaderText = "Code";
            ColumnNazivKomponente.HeaderText = "Title";
            ColumnKolicinaKomponente.HeaderText = "quantity";
            ColumnCijenaKomponente.HeaderText = "UnitPrice";
            ColumnRabatKomponente.HeaderText = "Discount";
            ColumnUkupnaCijenaKomponente.HeaderText = "Sum";
            ColumnIzmjeniKS.HeaderText = "Edit";
            ColumnObrisiKS.HeaderText = "Delete";
            ColumnIzmjeniKS.Text = "Edit";
            ColumnObrisiKS.Text = "Delete";

            lbPretraziNalog.Text = "Search :";
            lbLogovaniSteKao.Text = "User :";
            btProknjizi.Text = "PROCESS TICKET";
            rbNeproknjizeni.Text = "UNPROCESSED TICKETS";
            rbProknjizeni.Text = "UNPROCESSED TICKETS";
            tabPageProknjizeni.Text = "Processed";
            tabPageNeproknjizeni.Text = "Unprocessed";
            ColumnBrojNaloga.HeaderText = "No.Ticket";
            ColumnDatumKreiranjaN.HeaderText = "Creation date";
            ColumnImeKlijentaN.HeaderText = "Name";
            ColumnStatusN.HeaderText = "Status";
            ColumnIdPartnera.HeaderText = "ClientId";

            ColumnBrojNalogaP.HeaderText = "No.Ticket";
            ColumnDatumKreiranjaP.HeaderText = "Creation date";
            ColumnImeP.HeaderText = "Name";
            ColumnStatusP.HeaderText = "Status";
            ColumnIdPartneraProknjizeni.HeaderText = "ClientId";
            btPromjenaLozinke.Text = "Change password";
        }


        private void btPrevodNaSrpski_Click(object sender, EventArgs e)
        {
            this.prevediNaSrpski();
        }

        private void rbPrevediNaSrpski_CheckedChanged(object sender, EventArgs e)
        {
            prevediNaSrpski();
        }

        private void rbPrevediNaengleski_CheckedChanged(object sender, EventArgs e)
        {
            prevediNaEngleski();
        }

        private void tbIdKlijentaGF_TextChanged(object sender, EventArgs e)
        {

        }

        private void btPromjenaLozinke_Click(object sender, EventArgs e)
        {
            PromjenaLozinkeFormaGF = new PromjenaLozinkeForma();
            PromjenaLozinkeFormaGF.GlavnaFormaPromjenaLozinke = this;
            PromjenaLozinkeFormaGF.lbIme.Text=lbKorisnickoIme.Text;
            if (rbPrevediNaSrpski.Checked)
                PromjenaLozinkeFormaGF.prevediNaSrpski();
            else
                PromjenaLozinkeFormaGF.prevediNaEngleski();
            PromjenaLozinkeFormaGF.ShowDialog();
        }
    }
}
