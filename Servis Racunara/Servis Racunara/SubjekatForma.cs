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

    public partial class SubjekatForma : Form
    {
        public GlavnaForma GlavnaFormaSF;
        public static int IdParneraZaMjenjanje = 0;
        public SubjekatForma()
        {
            InitializeComponent();
            napuniGradComboBox();
            napuniGridKlijenta();
            napuniGridRadnika();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void rbDodajPL_CheckedChanged(object sender, EventArgs e)
        {
            tbBrojLicneKarte.Enabled = false;
            tbBrojLicneKarte.Text = "";
            tbJib.Enabled = true;
            tbUloga.Enabled = false;
            tbUloga.Text = "";
            tbPlata.Enabled = false;
            tbPlata.Text = "";
            tbVozackaDozvola.Enabled = false;
            tbVozackaDozvola.Text = "";
            OmoguciOsnovneInformacije();
        }

        private void rbDodajFL_CheckedChanged(object sender, EventArgs e)
        {
            tbJib.Enabled = false;
            tbJib.Text = "";
            tbBrojLicneKarte.Enabled = true;
            tbUloga.Enabled = false;
            tbUloga.Text = "";
            tbPlata.Enabled = false;
            tbPlata.Text = "";
            tbVozackaDozvola.Enabled = false;
            tbVozackaDozvola.Text = "";
            OmoguciOsnovneInformacije();

        }
        private void rbDodavanjeRadnika_CheckedChanged(object sender, EventArgs e)
        {
            tbJib.Enabled = false;
            tbJib.Text = "";
            tbBrojLicneKarte.Enabled = false;
            tbBrojLicneKarte.Text = "";
            tbUloga.Enabled = true;
            tbPlata.Enabled = true;
            tbVozackaDozvola.Enabled = true;
            OmoguciOsnovneInformacije();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)  //za klijent DGV
        {
            btSacuvajIzmjeneKlijenta.Enabled = true;


            if (dgvSubjekat.Columns[e.ColumnIndex].Name == "ColumnObrisi")
            {
                btDodajPartnera.Enabled = true;
                if (MessageBox.Show("Da li ste sigruni da zelite da obrisete ovog Klijenta?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int Id = (int)dgvSubjekat.Rows[e.RowIndex].Cells[ColumnId.Index].Value;
                    DbServisRacunara.DeletePartnera(Id);
                    GlavnaFormaSF.napuniRadiComboBox();
                    GlavnaFormaSF.napuniZaprimioComboBox();

                }
            }
            else if (dgvSubjekat.Columns[e.ColumnIndex].Name == "ColumnIzmjeni")
            {
                btSacuvajIzmjeneRadnika.Enabled = false;
                btDodajPartnera.Enabled = false;
                int vrsta = Int32.Parse(dgvSubjekat.Rows[e.RowIndex].Cells[ColumnJestePravnoLice.Index].Value.ToString());


                if (vrsta == 0)
                {
                    OmoguciOsnovneInformacije();
                    namjestiTextBoxoveZaFizickaLica();

                }
                else
                {
                    OmoguciOsnovneInformacije();
                    namjestiTextBoxoveZaPravnaLica();
                }

                int pocetniID = (int)dgvSubjekat.Rows[e.RowIndex].Cells[ColumnId.Index].Value;
                tbID.Text = dgvSubjekat.Rows[e.RowIndex].Cells[ColumnId.Index].Value.ToString();
                tbIme.Text = dgvSubjekat.Rows[e.RowIndex].Cells[ColumnIme.Index].Value.ToString();
                tbUlica.Text = dgvSubjekat.Rows[e.RowIndex].Cells[ColumnUlica.Index].Value.ToString();
                tbBrojTelefona.Text = dgvSubjekat.Rows[e.RowIndex].Cells[ColumnTelefon.Index].Value.ToString();
                tbEmail.Text = dgvSubjekat.Rows[e.RowIndex].Cells[ColumnEmail.Index].Value.ToString();
                tbKucniBroj.Text = dgvSubjekat.Rows[e.RowIndex].Cells[ColumnKucniBroj.Index].Value.ToString();
                tbJib.Text = dgvSubjekat.Rows[e.RowIndex].Cells[ColumnJIB.Index].Value.ToString();
                tbBrojLicneKarte.Text = dgvSubjekat.Rows[e.RowIndex].Cells[ColumnBrojLicneKarte.Index].Value.ToString();
                cbGrad.SelectedIndex = cbGrad.FindString(dgvSubjekat.Rows[e.RowIndex].Cells[ColumnGrad.Index].Value.ToString().Trim());


            }
            else if (dgvSubjekat.Columns[e.ColumnIndex].Name == "ColumnDodajNaNalog")
            {
                string identifikator = dgvSubjekat.Rows[e.RowIndex].Cells[ColumnId.Index].Value.ToString();
                int pocetniID = Int32.Parse(identifikator);
                string ime = dgvSubjekat.Rows[e.RowIndex].Cells[ColumnIme.Index].Value.ToString();
                tbIme.Text = ime;
                tbUlica.Text = dgvSubjekat.Rows[e.RowIndex].Cells[ColumnUlica.Index].Value.ToString();
                tbBrojTelefona.Text = dgvSubjekat.Rows[e.RowIndex].Cells[ColumnTelefon.Index].Value.ToString();
                tbEmail.Text = dgvSubjekat.Rows[e.RowIndex].Cells[ColumnEmail.Index].Value.ToString();
                tbKucniBroj.Text = dgvSubjekat.Rows[e.RowIndex].Cells[ColumnKucniBroj.Index].Value.ToString();
                tbJib.Text = dgvSubjekat.Rows[e.RowIndex].Cells[ColumnJIB.Index].Value.ToString();
                tbBrojLicneKarte.Text = dgvSubjekat.Rows[e.RowIndex].Cells[ColumnBrojLicneKarte.Index].Value.ToString();
                cbGrad.SelectedIndex = cbGrad.FindString(dgvSubjekat.Rows[e.RowIndex].Cells[ColumnGrad.Index].Value.ToString().Trim());
                OnemoguciTBSubjektaIDugmad();
                DialogResult rez = MessageBox.Show("Da li zelite da napravite nalog sa ovim klijentom", "Kreiranje radnog naloga sa klijentom", MessageBoxButtons.YesNo);
                if (rez == DialogResult.Yes)
                {

                    GlavnaFormaSF.tbKlijentGF.Text = ime;
                    GlavnaFormaSF.tbIdKlijentaGF.Text = identifikator;
                    GlavnaFormaSF.btSacuvajNalog.Enabled = true;
                    resetujTextBoxove();
                    this.Close();
                }
                else
                {
                    resetujTextBoxove();
                    OmoguciRB();

                }


            }
        }

        private void OnemoguciTBSubjektaIDugmad()
        {
            tbIme.Enabled = false;
            tbBrojLicneKarte.Enabled = false;
            tbBrojTelefona.Enabled = false;
            tbEmail.Enabled = false;
            tbJib.Enabled = false;
            tbKucniBroj.Enabled = false;
            tbPlata.Enabled = false;
            tbUlica.Enabled = false;
            tbUloga.Enabled = false;
            tbVozackaDozvola.Enabled = false;
            cbGrad.Enabled = false;
            btDodajPartnera.Enabled = false;
            btSacuvajIzmjeneKlijenta.Enabled = false;
            btSacuvajIzmjeneRadnika.Enabled = false;

        }
        private void OmoguciOsnovneInformacije()
        {
            tbIme.Enabled = true;
            tbUlica.Enabled = true;
            tbKucniBroj.Enabled = true;
            cbGrad.Enabled = true;
            tbBrojTelefona.Enabled = true;
            tbEmail.Enabled = true;

        }
        private void OmoguciRB()
        {
            rbDodajFL.Enabled = true;
            rbDodajPL.Enabled = true;
            rbDodavanjeRadnika.Enabled = true;

        }

        /* private void OmoguciTBSubjektaIDugmad()
         {
             tbIme.Enabled = true;
             tbBrojLicneKarte.Enabled = true;
             tbBrojTelefona.Enabled = true;
             tbEmail.Enabled = true;
             tbJib.Enabled = true;
             tbKucniBroj.Enabled = true;
             tbPlata.Enabled = true;
             tbUlica.Enabled = true;
             tbUloga.Enabled = false;
             tbVozackaDozvola.Enabled = false;
             cbGrad.Enabled = false;
             btDodajPartnera.Enabled = false;
         }*/

        private void namjestiTextBoxoveZaFizickaLica()
        {
            tbPlata.Enabled = false;
            tbUloga.Enabled = false;
            tbVozackaDozvola.Enabled = false;
            rbDodajFL.Enabled = false;
            rbDodajPL.Enabled = false;
            rbDodavanjeRadnika.Enabled = false;
            tbBrojLicneKarte.Enabled = true;
            tbJib.Enabled = false;
            btSacuvajIzmjeneKlijenta.Enabled = true;
        }
        private void namjestiTextBoxoveZaPravnaLica()
        {

            tbPlata.Enabled = false;
            tbUloga.Enabled = false;
            tbVozackaDozvola.Enabled = false;
            rbDodajFL.Enabled = false;
            rbDodajPL.Enabled = false;
            rbDodavanjeRadnika.Enabled = false;
            tbBrojLicneKarte.Enabled = false;
            tbJib.Enabled = true;
            btSacuvajIzmjeneKlijenta.Enabled = true;
        }

        private void namjestiTextBoxoveZaRadnike()
        {
            tbPlata.Enabled = true;
            tbUloga.Enabled = true;
            tbVozackaDozvola.Enabled = true;
            rbDodajFL.Enabled = false;
            rbDodajPL.Enabled = false;
            rbDodavanjeRadnika.Enabled = false;
            tbBrojLicneKarte.Enabled = false;
            tbJib.Enabled = false;
            btSacuvajIzmjeneRadnika.Enabled = true;
        }

        private void napuniGradComboBox()
        {

            List<Grad> gradovi = DbServisRacunara.GetGrad();
            foreach (Grad grad in gradovi)
            {
                cbGrad.Items.Add(grad.ToString());
            }
        }

        private void napuniGridSubjekata()
        {
            dgvSubjekat.Rows.Clear();
            foreach (var p in DbServisRacunara.GetPartneriFilter(tbFilterPartnera.Text))
            {
                DataGridViewRow row = new DataGridViewRow()
                {
                    Tag = p

                };
                row.CreateCells(dgvSubjekat, p.IdPartnera, p.Ime, p.Ulica, p.Grad, p.Telefon);
                dgvSubjekat.Rows.Add(row);
            }
        }

        private void napuniGridKlijenta() //za klijente
        {

            dgvSubjekat.Rows.Clear();
            foreach (var p in DbServisRacunara.GetKlijentFilter(tbFilterPartnera.Text))
            {
                DataGridViewRow row = new DataGridViewRow()
                {
                    Tag = p

                };

                row.CreateCells(dgvSubjekat, p.IdPartnera, p.Ime, p.Ulica, p.Grad, p.Telefon, p.KucniBroj, p.Email, p.BrojLicneKarte, p.JIB, p.JestePravnoLice);
                dgvSubjekat.Rows.Add(row);

            }

        }

        private void napuniGridRadnika()
        {
            dvgRadnik.Rows.Clear();
            foreach (var p in DbServisRacunara.GetRadnikFilter(tbFilterRadnika.Text))
            {
                DataGridViewRow row = new DataGridViewRow()
                {
                    Tag = p

                };
                row.CreateCells(dvgRadnik, p.IdPartnera, p.Ime, p.Ulica, p.Grad, p.Telefon, p.KucniBroj, p.Email, p.Uloga, p.Plata, p.VozackaDozvola);
                dvgRadnik.Rows.Add(row);
            }
        }

        private void btDodajKlijenta_Click(object sender, EventArgs e) //za partnera
        {

            if (rbDodavanjeRadnika.Checked)
            {
                try
                {
                    if (string.IsNullOrEmpty(tbIme.Text) || string.IsNullOrEmpty(tbKucniBroj.Text)
                        || string.IsNullOrEmpty(tbUloga.Text) || string.IsNullOrEmpty(tbPlata.Text) || string.IsNullOrEmpty(tbVozackaDozvola.Text) || string.IsNullOrEmpty(cbGrad.SelectedItem.ToString()))
                    {
                        MessageBox.Show("Morate popuniti sva zahtjeva polja", "Greska praznog polja", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {

                        string[] el = cbGrad.SelectedItem.ToString().Split('-');
                        int kucniBroj = 0;
                        var ulica = new Ulica()
                        {
                            PostanskiBrojGrada = Int32.Parse(el[1]),
                            NazivUlice = tbUlica.Text,
                        };

                        kucniBroj = Int32.Parse(tbKucniBroj.Text);


              

                var partner = new Partner()
                {
                    Ime = tbIme.Text,
                    Email = tbEmail.Text,
                };

                var radnik = new Radnik()
                {
                    Uloga = tbUloga.Text,
                    Plata = Decimal.Parse(tbPlata.Text),
                    VozackaDozvola = tbVozackaDozvola.Text,
                };

                string brojTelefona = tbBrojTelefona.Text;
                DbServisRacunara.InsertRadnik(radnik, partner, ulica, kucniBroj, brojTelefona);
                GlavnaFormaSF.cbRadi.Items.Clear();
                GlavnaFormaSF.cbZaprimio.Items.Clear();
                GlavnaFormaSF.napuniRadiComboBox();
                GlavnaFormaSF.napuniZaprimioComboBox();
                napuniGridRadnika();
                resetujTextBoxove();
                }
                }
         catch (Exception ex)
            {
                MessageBox.Show("BROJ KUCE i PLATA MORAJU BITI BROJNE VRIJEDNOSTI A VOZACKA MORA BITI MAKSIMALNE DUZINE 2 KARAKTERA", "GRESKA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

                // DbServisRacunara.InsertPartner(partner, ulica, kucniBroj);
            }
            
            else if (rbDodajFL.Checked)
            {
                if (string.IsNullOrEmpty(tbIme.Text) || string.IsNullOrEmpty(tbKucniBroj.Text)
                   || string.IsNullOrEmpty(tbBrojTelefona.Text) || string.IsNullOrEmpty(cbGrad.SelectedItem.ToString()) || string.IsNullOrEmpty(tbBrojLicneKarte.Text))
                {
                    MessageBox.Show("Morate popuniti sva zahtjeva polja", "Greska praznog polja", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (tbBrojLicneKarte.Text.Length != 9)
                {
                    MessageBox.Show("Polje BROJ LICNE KARTE mora sadzrzavati tacno 9 karaktera", "Greska polje licene karte", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    ubacivanjeFizickogLica(0);
                }
            }
            else if (rbDodajPL.Checked)
            {
                if (string.IsNullOrEmpty(tbIme.Text) || string.IsNullOrEmpty(tbKucniBroj.Text)
                  || string.IsNullOrEmpty(tbBrojTelefona.Text) || string.IsNullOrEmpty(cbGrad.SelectedItem.ToString()) || string.IsNullOrEmpty(tbJib.Text))
                {
                    MessageBox.Show("Morate popuniti sva zahtjeva polja", "Greska praznog polja", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (tbJib.Text.Length != 13)
                {
                    MessageBox.Show("Polje JIB mora sadzrzavati tacno 13 karaktera", "Greska polje licene karte", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else 
                {
                    ubacivanjeFizickogLica(1);
                }
            }

        }



        private void tbFilterPartnera_TextChanged(object sender, EventArgs e)
        {
            napuniGridKlijenta();
        }
        private void resetujTextBoxove()
        {
        tbIme.Text = "";
        tbBrojLicneKarte.Text = "";
        tbBrojTelefona.Text = "";
        tbEmail.Text = "";
        tbJib.Text = "";
        tbKucniBroj.Text = "";
        tbPlata.Text = "";
        tbUlica.Text = "";
        tbUloga.Text = "";
        tbVozackaDozvola.Text = "";
        cbGrad.SelectedIndex = -1;
        }

private void ubacivanjeFizickogLica(int JestePL)
        {
            try
            {
                int kucniBroj = 0;
                string[] el = cbGrad.SelectedItem.ToString().Split('-');

                var ulica = new Ulica()
                {
                    PostanskiBrojGrada = Int32.Parse(el[1]),
                    NazivUlice = tbUlica.Text,
                };

                kucniBroj = Int32.Parse(tbKucniBroj.Text);


                var partner = new Partner()
                {
                    Ime = tbIme.Text,
                    Email = tbEmail.Text,
                };
                var klijent = new Klijent()
                {
                    BrojLicneKarte = tbBrojLicneKarte.Text,
                    JIB = tbJib.Text,
                    JestePravnoLice = JestePL,
                };
                string brojTelefona = tbBrojTelefona.Text;
                DbServisRacunara.InsertKlijent(klijent, partner, ulica, kucniBroj, brojTelefona);
                napuniGridKlijenta();
                resetujTextBoxove();
            }
            catch (Exception e)
            {
                MessageBox.Show("BROJ KUCE MORA BITI BROJNA VRIJEDNOST", "GRESKA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void tbFilterRadnika_TextChanged(object sender, EventArgs e)
        {
            napuniGridRadnika();
        }

        private void dvgRadnik_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btSacuvajIzmjeneKlijenta.Enabled = false;


            if (dvgRadnik.Columns[e.ColumnIndex].Name == "ColumnObrisiRadnik")
            {


                if (MessageBox.Show("Da li ste sigruni da zelite da obrisete ovog Klijenta?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int Id = (int)dvgRadnik.Rows[e.RowIndex].Cells[ColumnId.Index].Value;
                    DbServisRacunara.DeletePartnera(Id);


                }
            }
            else if (dvgRadnik.Columns[e.ColumnIndex].Name == "ColumnIzmjeniRadnik")
            {

                btDodajPartnera.Enabled = false;
                namjestiTextBoxoveZaRadnike();

                try
                {

                    IdParneraZaMjenjanje = (int)dvgRadnik.Rows[e.RowIndex].Cells[ColumnIdPartneraRadnik.Index].Value;
                    tbID.Text = dvgRadnik.Rows[e.RowIndex].Cells[ColumnIdPartneraRadnik.Index].Value.ToString();
                    tbIme.Text = dvgRadnik.Rows[e.RowIndex].Cells[ColumnImeRadnik.Index].Value.ToString();
                    tbUlica.Text = dvgRadnik.Rows[e.RowIndex].Cells[ColumnUlicaRadnik.Index].Value.ToString();
                    tbBrojTelefona.Text = dvgRadnik.Rows[e.RowIndex].Cells[ColumnTelefonRadnik.Index].Value.ToString();
                    tbEmail.Text = dvgRadnik.Rows[e.RowIndex].Cells[ColumnEmail.Index].Value.ToString();
                    tbKucniBroj.Text = dvgRadnik.Rows[e.RowIndex].Cells[ColumnBrojKuceRadnik.Index].Value.ToString();

                    cbGrad.SelectedIndex = cbGrad.FindString(dvgRadnik.Rows[e.RowIndex].Cells[ColumnGradRadnik.Index].Value.ToString().Trim());
                    tbUloga.Text = dvgRadnik.Rows[e.RowIndex].Cells[ColumnUloga.Index].Value.ToString();
                    tbPlata.Text = dvgRadnik.Rows[e.RowIndex].Cells[ColumnPlata.Index].Value.ToString();
                    tbVozackaDozvola.Text = dvgRadnik.Rows[e.RowIndex].Cells[ColumnVozackaDozvola.Index].Value.ToString();
                }
                catch (NullReferenceException ex)
                {
                    MessageBox.Show("Stisnuli ste prazno polje", "Greska praznog polja", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
           /* else if (dvgRadnik.Columns[e.ColumnIndex].Name =="ColumnKreirajNalogRadnikKaoKlijent")
            {
                string identifikator = dvgRadnik.Rows[e.RowIndex].Cells[ColumnIdPartneraRadnik.Index].Value.ToString();
                int pocetniID = Int32.Parse(identifikator);
                string ime = dvgRadnik.Rows[e.RowIndex].Cells[ColumnImeRadnik.Index].Value.ToString();
                tbIme.Text = ime;
                tbUlica.Text = dvgRadnik.Rows[e.RowIndex].Cells[ColumnUlicaRadnik.Index].Value.ToString();
                tbBrojTelefona.Text = dvgRadnik.Rows[e.RowIndex].Cells[ColumnTelefonRadnik.Index].Value.ToString();
                tbEmail.Text = dvgRadnik.Rows[e.RowIndex].Cells[ColumnEmailRadnika.Index].Value.ToString();
                tbKucniBroj.Text = dvgRadnik.Rows[e.RowIndex].Cells[ColumnBrojKuceRadnik.Index].Value.ToString();
                tbUloga.Text = dvgRadnik.Rows[e.RowIndex].Cells[ColumnUloga.Index].Value.ToString();
                tbPlata.Text = dvgRadnik.Rows[e.RowIndex].Cells[ColumnPlata.Index].Value.ToString();
                tbVozackaDozvola.Text= dvgRadnik.Rows[e.RowIndex].Cells[ColumnVozackaDozvola.Index].Value.ToString();
                cbGrad.SelectedIndex = cbGrad.FindString(dvgRadnik.Rows[e.RowIndex].Cells[ColumnGradRadnik.Index].Value.ToString().Trim());
                OnemoguciTBSubjektaIDugmad();
                DialogResult rez = MessageBox.Show("Da li zelite da napravite nalog sa ovim klijentom", "Kreiranje radnog naloga sa klijentom", MessageBoxButtons.YesNo);
                if (rez == DialogResult.Yes)
                {

                    GlavnaFormaSF.tbKlijentGF.Text = ime;
                    GlavnaFormaSF.tbIdKlijentaGF.Text = identifikator;
                    GlavnaFormaSF.btSacuvajNalog.Enabled = true;
                    resetujTextBoxove();
                    this.Close();
                }
                else
                {
                    resetujTextBoxove();
                    OmoguciRB();

                }
            }*/
                
           }

        

        private void btSacuvajIzmjeneKlijenta_Click(object sender, EventArgs e)
        {
            try
            {
                string[] el = cbGrad.SelectedItem.ToString().Split('-');

                var klijent = new PrikazPartnera()
                {
                    IdPartnera = Int32.Parse(tbID.Text),
                    Ime = tbIme.Text,
                    Ulica = tbUlica.Text,
                    KucniBroj = Int32.Parse(tbKucniBroj.Text),
                    Grad = cbGrad.SelectedItem.ToString(),
                    Telefon = tbBrojTelefona.Text,
                    Email = tbEmail.Text,
                    JIB = tbJib.Text,
                    BrojLicneKarte = tbBrojLicneKarte.Text,
                    PostanskiBrojGrada = Int32.Parse(el[1]),

                };
                DbServisRacunara.UpdateKlijenta(klijent);
                napuniGridKlijenta();
                //  NapuniGrid();
                btSacuvajIzmjeneKlijenta.Enabled = false;
                resetujTextBoxove();
                omoguciRadioDugmad();
                btDodajPartnera.Enabled = true;
            }
            catch(FormatException fx)
            {
                MessageBox.Show("GRESKA! VRIJEDNOST KUCNOG BROJA MORA BITI BROJNA VRIJEDNOST", "GRESKA BROJNE VRIJEDNOSTI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    

        private void btSacuvajIzmjeneRadnika_Click(object sender, EventArgs e)
        {
            try
            {
                string[] el = cbGrad.SelectedItem.ToString().Split('-');

                var radnik = new PrikazRadnika()
                {
                    IdPartnera = Int32.Parse(tbID.Text),
                    Ime = tbIme.Text,
                    Ulica = tbUlica.Text,
                    KucniBroj = Int32.Parse(tbKucniBroj.Text),
                    Grad = cbGrad.SelectedItem.ToString(),
                    Telefon = tbBrojTelefona.Text,
                    Email = tbEmail.Text,
                    Uloga = tbUloga.Text,
                    Plata = decimal.Parse(tbPlata.Text),
                    VozackaDozvola = tbVozackaDozvola.Text,

                    PostanskiBrojGrada = Int32.Parse(el[1]),

                };
                DbServisRacunara.UpdateRadnika(radnik);
                napuniGridRadnika();
                //  NapuniGrid();
                btSacuvajIzmjeneRadnika.Enabled = false;
                resetujTextBoxove();
                omoguciRadioDugmad();
                btDodajPartnera.Enabled = true;
            }
            catch(FormatException fx)
            {
                MessageBox.Show("GRESKA! VRIJEDNOSTI PLATE I KUCNOG BROJA MORAJU BITI BROJNE VRIJEDNOSTI", "GRESKA BROJNE VRIJEDNOSTI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void omoguciRadioDugmad()
        {
            rbDodajFL.Enabled = true;
            rbDodajPL.Enabled = true;
            rbDodavanjeRadnika.Enabled = true;
        }

        private void gbKlijent_Enter(object sender, EventArgs e)
        {

        }

        private void btOsvjeziKlijenta_Click(object sender, EventArgs e)
        {
            napuniGridKlijenta();
        }

        private void btOsvjeziRadnika_Click(object sender, EventArgs e)
        {
            napuniGridRadnika();
        }
    }
}


