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
            chbPrivilegije.Enabled = false;
            tbVozackaDozvola.Text = "";
            OmoguciOsnovneInformacije();
        }

        private void rbDodajFL_CheckedChanged(object sender, EventArgs e)
        {
            tbJib.Enabled = false;
            chbPrivilegije.Enabled = false;
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
            chbPrivilegije.Enabled = true;
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
                if (dgvSubjekat.Rows[e.RowIndex].Cells[ColumnId.Index].Value != null)
                {
                    btDodajPartnera.Enabled = true;
                    string eng = "Are you sure you want to delete this Client";
                    string srb = "Да ли сте сигурни да желите да обришете овог Клијента?";
                    if (MessageBox.Show((GlavnaFormaSF.rbPrevediNaSrpski.Checked) ? srb : eng, String.Empty, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        int Id = (int)dgvSubjekat.Rows[e.RowIndex].Cells[ColumnId.Index].Value;
                        DbServisRacunara.DeletePartnera(Id);
                        GlavnaFormaSF.napuniRadiComboBox();
                        GlavnaFormaSF.napuniZaprimioComboBox();

                    }
                }
                else
                   MessageBox.Show("Стиснули сте празно поље", String.Empty, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (dgvSubjekat.Columns[e.ColumnIndex].Name == "ColumnIzmjeni")
            {
                if (dgvSubjekat.Rows[e.RowIndex].Cells[ColumnId.Index].Value != null)
                {
                    btSacuvajIzmjeneRadnika.Enabled = false;
                    btDodajPartnera.Enabled = false;
                    int vrsta = Int32.Parse(dgvSubjekat.Rows[e.RowIndex].Cells[ColumnJestePravnoLice.Index].Value.ToString());


                    if (vrsta == 0)
                    {
                        OmoguciOsnovneInformacije();
                        namjestiTextBoxoveZaFizickaLica();
                        rbDodajFL.Checked = true;

                    }
                    else
                    {
                        OmoguciOsnovneInformacije();
                        namjestiTextBoxoveZaPravnaLica();
                        rbDodajPL.Checked = true;
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
                else
                    MessageBox.Show("Стиснули сте празно поље", String.Empty, MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
            else if (dgvSubjekat.Columns[e.ColumnIndex].Name == "ColumnDodajNaNalog")
            {
                if (dgvSubjekat.Rows[e.RowIndex].Cells[ColumnId.Index].Value != null)
                {
                    string identifikator = dgvSubjekat.Rows[e.RowIndex].Cells[ColumnId.Index].Value.ToString();
                    int pocetniID = Int32.Parse(identifikator);
                    string ime = dgvSubjekat.Rows[e.RowIndex].Cells[ColumnIme.Index].Value.ToString();
                    GlavnaFormaSF.tbZahtjev.Text = String.Empty;
                    GlavnaFormaSF.tbNapomena.Text = String.Empty;
                    GlavnaFormaSF.dgvKomponentaStavka.Rows.Clear();
                    GlavnaFormaSF.dgvUslugaStavka.Rows.Clear();
                    GlavnaFormaSF.cbRadi.SelectedItem = null;
                    GlavnaFormaSF.cbZaprimio.SelectedItem = null;
                    GlavnaFormaSF.cbStatus.SelectedItem = null;
                    GlavnaFormaSF.tbBrojRadnogNaloga.Text = String.Empty;
                    GlavnaFormaSF.lbStatus.BackColor = SystemColors.Control;
                    GlavnaFormaSF.dtpDatumKreiranja.Value = DateTime.Now;
                    GlavnaFormaSF.dtpDatumZavrsetka.Value = DateTime.Now;
                    tbIme.Text = ime;
                    tbUlica.Text = dgvSubjekat.Rows[e.RowIndex].Cells[ColumnUlica.Index].Value.ToString();
                    tbBrojTelefona.Text = dgvSubjekat.Rows[e.RowIndex].Cells[ColumnTelefon.Index].Value.ToString();
                    tbEmail.Text = dgvSubjekat.Rows[e.RowIndex].Cells[ColumnEmail.Index].Value.ToString();
                    tbKucniBroj.Text = dgvSubjekat.Rows[e.RowIndex].Cells[ColumnKucniBroj.Index].Value.ToString();
                    tbJib.Text = dgvSubjekat.Rows[e.RowIndex].Cells[ColumnJIB.Index].Value.ToString();
                    tbBrojLicneKarte.Text = dgvSubjekat.Rows[e.RowIndex].Cells[ColumnBrojLicneKarte.Index].Value.ToString();
                    cbGrad.SelectedIndex = cbGrad.FindString(dgvSubjekat.Rows[e.RowIndex].Cells[ColumnGrad.Index].Value.ToString().Trim());
                    OnemoguciTBSubjektaIDugmad();
                    string eng = "Do you want to create a ticket with this Client?";
                    string srb = "Да ли желите да направите налог са овим Клијентом";
                    DialogResult rez = MessageBox.Show((GlavnaFormaSF.rbPrevediNaSrpski.Checked) ? srb : eng, String.Empty, MessageBoxButtons.YesNo);
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
                else
                   MessageBox.Show("Стиснули сте празно поље", String.Empty, MessageBoxButtons.OK, MessageBoxIcon.Error);


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
            chbPrivilegije.Enabled = true;
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
                row.CreateCells(dvgRadnik, p.IdPartnera, p.Ime, p.Ulica, p.Grad, p.Telefon, p.KucniBroj, p.Email, p.Uloga, p.Plata, p.VozackaDozvola,p.Privilegije);
                dvgRadnik.Rows.Add(row);
            }
        }

        private void btDodajKlijenta_Click(object sender, EventArgs e) //za partnera
        {

            if (rbDodavanjeRadnika.Checked)
            {
                try
                {
                    if (cbGrad.SelectedItem == null)
                    {
                        string srb = "Морате селектовати град";
                        string eng = "Field Citiy is required";
                        MessageBox.Show((GlavnaFormaSF.rbPrevediNaSrpski.Checked) ? srb : eng, String.Empty, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                   else if (string.IsNullOrEmpty(tbIme.Text) || string.IsNullOrEmpty(tbKucniBroj.Text)
                        || string.IsNullOrEmpty(tbUloga.Text) || string.IsNullOrEmpty(tbPlata.Text) || string.IsNullOrEmpty(tbVozackaDozvola.Text) || string.IsNullOrEmpty(cbGrad.SelectedItem.ToString()))
                    {
                        string srb = "Морате попунити сва захтјевана поља";
                        string eng = "All fields are required";

                        MessageBox.Show((GlavnaFormaSF.rbPrevediNaSrpski.Checked)?srb:eng, String.Empty, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {

                        string[] el = cbGrad.SelectedItem.ToString().Split('-');
                        int kucniBroj = 0;
                       

                       


              

                var partner = new Partner()
                {
                    Ime = tbIme.Text,
                    Email = tbEmail.Text,
                    PostanskiBrojGrada = Int32.Parse(el[1]),
                    NazivUlice = tbUlica.Text,
                    KucniBroj = Int32.Parse(tbKucniBroj.Text)
                };

                var radnik = new Radnik()
                {
                    Uloga = tbUloga.Text,
                    Plata = Decimal.Parse(tbPlata.Text),
                    VozackaDozvola = tbVozackaDozvola.Text,
                };
                        if (chbPrivilegije.Checked)
                            radnik.Privilegije = 1;
                string brojTelefona = tbBrojTelefona.Text;
                DbServisRacunara.InsertRadnik(radnik, partner,brojTelefona);
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
                    
                    string srb = "БРОЈ КУЋЕ И ПЛАТА МОРАЈУ БИТИ БРОЈНЕ ВРИЈЕДНОСТИ А ВОЗАЧКА ДОЗВОЛА МОРА БИТИ МАКСИМАЛНЕ ДУЖИНЕ 2 КАРАКТЕРА";
                        string eng = "THE NUMBER OF THE HOUSE AND THE SALARY MUST BE NUMERICAL VALUES AND THE DRIVER MUST BE A MAXIMUM LENGTH OF 2 CHARACTERS ";
                        MessageBox.Show((GlavnaFormaSF.rbPrevediNaSrpski.Checked)?srb:eng, String.Empty, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                // DbServisRacunara.InsertPartner(partner, ulica, kucniBroj);
            }
            
            else if (rbDodajFL.Checked)
            {
                try
                {
                    if (cbGrad.SelectedItem == null)
                    {
                        string srb = "Морате селектовати град";
                        string eng = "Field Citiy is required";
                        MessageBox.Show((GlavnaFormaSF.rbPrevediNaSrpski.Checked) ? srb : eng, String.Empty, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (string.IsNullOrEmpty(tbIme.Text) || string.IsNullOrEmpty(tbKucniBroj.Text)
                       || string.IsNullOrEmpty(tbBrojTelefona.Text) || string.IsNullOrEmpty(cbGrad.SelectedItem.ToString()) || string.IsNullOrEmpty(tbBrojLicneKarte.Text))
                    {
                        string srb = "Морате попунити сва захтјевана поља";
                        string eng = "All fields are required";
                        MessageBox.Show((GlavnaFormaSF.rbPrevediNaSrpski.Checked) ? srb : eng, String.Empty, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (tbBrojLicneKarte.Text.Length != 9)
                    {
                      
                        string srb = "Поље БРОЈ ЛИЧНЕ КАРТЕ мора садржавати тачно 9 карактера";
                        string eng = "Field UID must contain exactly 9 character";
                        MessageBox.Show((GlavnaFormaSF.rbPrevediNaSrpski.Checked) ? srb : eng, String.Empty, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        ubacivanjeFizickogLica(0);
                    }
                }
                catch(Exception ex)
                {
                    
                    string srb = "БРОЈ КУЋЕ МОРА БИТИ НУМЕРИЧКА ВРИЈЕДНОСТ И ГРАД МОРА БИТИ ЈЕДАН ОД ДОЗВОЉЕНИХ";
                    string eng = "THE NUMBER OF THE HOUSE MUST BE NUMERICAL VALUES AND CITY MUST BE ONE OF THE OFFERS ";
                    MessageBox.Show((GlavnaFormaSF.rbPrevediNaSrpski.Checked) ? srb : eng, String.Empty, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (rbDodajPL.Checked)
            {
                try
                {
                    if(cbGrad.SelectedItem==null)
                    {
                        string srb = "Морате селектовати град";
                        string eng = "Field Citiy is required";
                        MessageBox.Show((GlavnaFormaSF.rbPrevediNaSrpski.Checked) ? srb : eng, String.Empty, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (string.IsNullOrEmpty(tbIme.Text) || string.IsNullOrEmpty(tbKucniBroj.Text)
                      || string.IsNullOrEmpty(tbBrojTelefona.Text) || string.IsNullOrEmpty(cbGrad.SelectedItem.ToString()) || string.IsNullOrEmpty(tbJib.Text))
                    {
                        string srb = "Морате попунити сва захтјевана поља";
                        string eng = "All fields are required";
                        MessageBox.Show((GlavnaFormaSF.rbPrevediNaSrpski.Checked) ? srb : eng, String.Empty, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (tbJib.Text.Length != 13)
                    {
                        
                        string srb = "Поље ЈИБ мора садржавати тачно 13 карактера";
                        string eng = "UIN field must contain exactly 13 characters";

                        MessageBox.Show((GlavnaFormaSF.rbPrevediNaSrpski.Checked) ? srb : eng, String.Empty, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        ubacivanjeFizickogLica(1);
                    }
                }
                catch(Exception ex)
                {
                   
                    string srb = "БРОЈ КУЋЕ МОРА БИТИ НУМЕРИЧКА ВРИЈЕДНОСТ, И ГРАД МОРА БИТИ ЈЕДАН ОД ДОЗВОЛЈЕНИХ";
                    string eng = "THE NUMBER OF THE HOUSE MUST BE NUMERICAL VALUES AND CITY MUST BE ONE OF THE OFFERS ";
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
            tbID.Text = "";
        }

private void ubacivanjeFizickogLica(int JestePL)
        {
            try
            {
                int kucniBroj = 0;
                string[] el = cbGrad.SelectedItem.ToString().Split('-');

                kucniBroj = Int32.Parse(tbKucniBroj.Text);


                var partner = new Partner()
                {
                    Ime = tbIme.Text,
                    Email = tbEmail.Text,
                    PostanskiBrojGrada = Int32.Parse(el[1]),
                    NazivUlice = tbUlica.Text,
                    KucniBroj = kucniBroj
                };
                var klijent = new Klijent()
                {
                    BrojLicneKarte = tbBrojLicneKarte.Text,
                    JIB = tbJib.Text,
                    JestePravnoLice = JestePL,
                };
                string brojTelefona = tbBrojTelefona.Text;
                DbServisRacunara.InsertKlijent(klijent, partner,brojTelefona);
                napuniGridKlijenta();
                resetujTextBoxove();
            }
            catch (Exception e)
            {
                string srb = "БРОЈ КУЋЕ МОРА БИТИ НУМЕРИЧКА ВРИЈЕДНОСТ";
                string eng = "HOUSE NUMBER MUST BE NUMERICAL VALUE";
                MessageBox.Show((GlavnaFormaSF.rbPrevediNaSrpski.Checked) ? srb : eng, String.Empty, MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                if (dvgRadnik.Rows[e.RowIndex].Cells[ColumnId.Index].Value != null)
                {
                    string eng = "Are you sure you want to delete this Client";
                    string srb = "Да ли сте сигурни да желите да обришете овог Клијента?";
                    if (MessageBox.Show((GlavnaFormaSF.rbPrevediNaSrpski.Checked) ? srb : eng, String.Empty, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        int Id = (int)dvgRadnik.Rows[e.RowIndex].Cells[ColumnId.Index].Value;
                        DbServisRacunara.DeletePartnera(Id);


                    }
                }
                else
                    MessageBox.Show("Стиснули сте празно поље", String.Empty, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (dvgRadnik.Columns[e.ColumnIndex].Name == "ColumnIzmjeniRadnik")
            {

                btDodajPartnera.Enabled = false;
                namjestiTextBoxoveZaRadnike();

                
                    if (dvgRadnik.Rows[e.RowIndex].Cells[ColumnIdPartneraRadnik.Index].Value != null)
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
                    if (dvgRadnik.Rows[e.RowIndex].Cells[ColumnPrivilegije.Index].Value.ToString() == "1")
                        chbPrivilegije.Checked = true;
                    else
                        chbPrivilegije.Checked = false;



                }
                
                else
                    MessageBox.Show("Стснули сте празно поље",String.Empty, MessageBoxButtons.OK, MessageBoxIcon.Error);
                
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
                if(rbDodajFL.Checked)
                {
                    if (cbGrad.SelectedItem == null)
                    {
                        string srb = "Морате селектовати град";
                        string eng = "Field Citiy is required";
                        MessageBox.Show((GlavnaFormaSF.rbPrevediNaSrpski.Checked) ? srb : eng, String.Empty, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (string.IsNullOrEmpty(tbIme.Text) || string.IsNullOrEmpty(tbKucniBroj.Text)
                       || string.IsNullOrEmpty(tbBrojTelefona.Text) || string.IsNullOrEmpty(cbGrad.SelectedItem.ToString()) || string.IsNullOrEmpty(tbBrojLicneKarte.Text))
                    {
                        string srb = "Морате попунити сва захтјевана поља";
                        string eng = "All fields are required";
                        MessageBox.Show((GlavnaFormaSF.rbPrevediNaSrpski.Checked) ? srb : eng, String.Empty, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (tbBrojLicneKarte.Text.Length != 9)
                    {
                        
                        string srb = "Поље БРОЈ ЛИЧНЕ КАРТЕ мора садржавати тачно 9 карактера";
                        string eng = "Field ID must contain exactly 9 character";
                        MessageBox.Show((GlavnaFormaSF.rbPrevediNaSrpski.Checked) ? srb : eng, String.Empty, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
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
                }
                else if(rbDodajPL.Checked)
                {
                    if (cbGrad.SelectedItem == null)
                    {
                        string srb = "Морате селектовати град";
                        string eng = "Field Citiy is required";
                        MessageBox.Show((GlavnaFormaSF.rbPrevediNaSrpski.Checked) ? srb : eng, String.Empty, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (string.IsNullOrEmpty(tbIme.Text) || string.IsNullOrEmpty(tbKucniBroj.Text)
                      || string.IsNullOrEmpty(tbBrojTelefona.Text) || string.IsNullOrEmpty(cbGrad.SelectedItem.ToString()) || string.IsNullOrEmpty(tbJib.Text))
                    {
                        string srb = "Морате попунити сва захтјевана поља";
                        string eng = "All fields are required";
                        MessageBox.Show((GlavnaFormaSF.rbPrevediNaSrpski.Checked) ? srb : eng, String.Empty, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (tbJib.Text.Length != 13)
                    {
                        string srb = "Поље ЈИБ мора садржавати тачно 13 карактера";
                        string eng = "UIN field must contain exactly 13 characters";

                        MessageBox.Show((GlavnaFormaSF.rbPrevediNaSrpski.Checked) ? srb : eng, String.Empty, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
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
                }
                
            }
            catch(FormatException fx)
            {
                string eng = "THE NUMBER OF THE HOUSE  MUST BE NUMERICAL VALUE";
                string srb = "КУЋНИ БРОЈ МОРА БИТИ НУМЕРИЧКА ВРИЈЕДНОСТ";
                MessageBox.Show((GlavnaFormaSF.rbPrevediNaSrpski.Checked) ? srb : eng, String.Empty, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch(Exception eex)
            {
                string eng = "Filed City is invalid or ID length is longer than 2 characters";
                string srb = "Град мора бити један од дозвољених, и возачка дозвола мора бити максимално 2 карактера";
                MessageBox.Show((GlavnaFormaSF.rbPrevediNaSrpski.Checked) ? srb : eng, String.Empty, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    

        private void btSacuvajIzmjeneRadnika_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbGrad.SelectedItem == null)
                {
                    string srb = "Морате селектовати град";
                    string eng = "Field Citiy is required";
                    MessageBox.Show((GlavnaFormaSF.rbPrevediNaSrpski.Checked) ? srb : eng, String.Empty, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (string.IsNullOrEmpty(tbIme.Text) || string.IsNullOrEmpty(tbKucniBroj.Text)
                     || string.IsNullOrEmpty(tbUloga.Text) || string.IsNullOrEmpty(tbPlata.Text) || string.IsNullOrEmpty(tbVozackaDozvola.Text) || string.IsNullOrEmpty(cbGrad.SelectedItem.ToString()))
                {
                    string srb = "Морате попунити сва захтјевана поља";
                    string eng = "All fields are required";

                    MessageBox.Show((GlavnaFormaSF.rbPrevediNaSrpski.Checked) ? srb : eng, String.Empty, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else
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
                    if (chbPrivilegije.Checked)
                        radnik.Privilegije = 1;
                    DbServisRacunara.UpdateRadnika(radnik);
                    napuniGridRadnika();
                    //  NapuniGrid();
                    btSacuvajIzmjeneRadnika.Enabled = false;
                    resetujTextBoxove();
                    omoguciRadioDugmad();
                    btDodajPartnera.Enabled = true;
                }
            }
            catch(FormatException fx)
            {
                string srb = "БРОЈ КУЋЕ И ПЛАТА МОРАЈУ БИТИ НУМЕРИЧКЕ ВРИЈЕДНОСТИ";
                string eng = "THE NUMBER OF THE HOUSE AND THE SALARY MUST BE NUMERICAL VALUES";
                MessageBox.Show((GlavnaFormaSF.rbPrevediNaSrpski.Checked) ? srb : eng, String.Empty, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception eex)
            {
                string eng = "Filed City is invalid or ID length is longer than 2 characters";
                string srb = "Град мора бити један од дозвољених, и возачка дозвола мора бити максимално 2 карактера";
                MessageBox.Show((GlavnaFormaSF.rbPrevediNaSrpski.Checked) ? srb : eng, String.Empty, MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

       public void prevediNaSrpski()
        {
            gbOsnovneInformacije.Text = "ОСНОВНЕ ИНФОРМАЦИЈЕ";
            lbIme.Text = "Име :";
            lbUlica.Text = "Улица :";
            lbGrad.Text = "Град :";
            lbId.Text = "ID :";
            lbKucniBroj.Text = "Број :";
            lbTelefon.Text = "Телефон :";
            gbTipPartnera.Text = "ТИП ПАРТНЕРА";
            rbDodajPL.Text = "ДОДАЈ ПРАВНО ЛИЦЕ";
            rbDodajFL.Text = "ДОДАЈ ФИЗИЧКО ЛИЦЕ";
            rbDodavanjeRadnika.Text = "ДОДАЈ РАДНИКА";
            gbDodatneInformacije.Text = "ДОДАТНЕ ИНФОРМАЦИЈЕ";
            lbUloga.Text = "Улога :";
            lbPlata.Text = "Плата :";
            lbVozackaDozvola.Text = "Возачка дозвола кат. :";
            lbBrojLicneKarte.Text = "Број Личне Карте :";
            lbJib.Text = "ЈИБ :";
            btDodajPartnera.Text = "ДОДАЈ ПАРТНЕРА";
            gbKlijent.Text = "КЛИЈЕНТИ";
            ColumnId.HeaderText=ColumnIdPartneraRadnik.HeaderText = "";
            ColumnIme.HeaderText=ColumnImeRadnik.HeaderText = "Име";
            ColumnUlica.HeaderText=ColumnUlicaRadnik.HeaderText = "Улица";
            ColumnGrad.HeaderText=ColumnGradRadnik.HeaderText = "Град";
            ColumnTelefon.HeaderText=ColumnTelefonRadnik.HeaderText = "Телефон";
            ColumnKucniBroj.HeaderText=ColumnBrojKuceRadnik.HeaderText = "Кућ.Бр.";
            ColumnBrojLicneKarte.HeaderText = "Бр.Лич.Карте";
            ColumnJIB.HeaderText = "ЈИБ";
            ColumnJestePravnoLice.HeaderText = "ЈестеПравноЛице?";
            ColumnIzmjeni.HeaderText=ColumnIzmjeniRadnik.HeaderText = "Измјени";
            ColumnObrisi.HeaderText=ColumnObrisiRadnik.HeaderText = "Обриши";
            ColumnObrisi.Text=ColumnObrisiRadnik.Text = "Обриши";
            ColumnIzmjeni.Text=ColumnIzmjeniRadnik.Text= "Измјени";
            ColumnDodajNaNalog.HeaderText = "Налог";
            lbFilterPartnera.Text=lbPreatraziRadnika.Text = "Претражи :";
            btSacuvajIzmjeneKlijenta.Text = "САЧУВАЈ ИЗМЈЕНЕ КЛИЈЕНТА";
            btSacuvajIzmjeneRadnika.Text = "САЧУВАЈ ИЗМЈЕНЕ РАДНИКА";
            gbRadnik.Text = "РАДНИЦИ";
            ColumnUloga.HeaderText = "Улога";
            ColumnPlata.HeaderText = "Плата";
            ColumnVozackaDozvola.HeaderText = "Воз.Доз.";
            chbPrivilegije.Text = "Привилегије";

        }

        public void prevediNaEngleski()
        {
            gbOsnovneInformacije.Text = "BASIC INFORMATION";
            lbIme.Text =  "Name :";
            lbUlica.Text = "Street :";
            lbGrad.Text = "City :";
            lbId.Text = "ID :";
            lbKucniBroj.Text = "Number :";
            lbTelefon.Text = "Phone :";
            gbTipPartnera.Text = "PARTNER TYPE";
            rbDodajPL.Text = "ADD CORPORATE PERSON";
            rbDodajFL.Text = "ADD NATURAL PERSON";
            rbDodavanjeRadnika.Text = "ADD WORKER ";
            gbDodatneInformacije.Text = "EXTRA INFORMATION";
            lbUloga.Text = "Role :";
            lbPlata.Text = "Salary :";
            lbVozackaDozvola.Text = "Driving licence cat. :";
            lbBrojLicneKarte.Text = "ID Number :";
            lbJib.Text = "UIN :";
            btDodajPartnera.Text = "ADD PARTNER";
            gbKlijent.Text = "CLIENTS";
            ColumnUlica.HeaderText = ColumnUlicaRadnik.HeaderText = "Street";
            ColumnIme.HeaderText = ColumnImeRadnik.HeaderText = "Name";
            ColumnGrad.HeaderText = ColumnGradRadnik.HeaderText = "City";
            ColumnTelefon.HeaderText = ColumnTelefonRadnik.HeaderText = "Phone";
            ColumnKucniBroj.HeaderText = ColumnBrojKuceRadnik.HeaderText = "House No.";
            ColumnBrojLicneKarte.HeaderText = "ID Number";
            ColumnJIB.HeaderText = "UIN";
            ColumnJestePravnoLice.HeaderText = "IsCorporatePerson?";
            ColumnIzmjeni.HeaderText = ColumnIzmjeniRadnik.HeaderText = "Edit";
            ColumnObrisi.HeaderText = ColumnObrisiRadnik.HeaderText = "Delete";
            ColumnObrisi.Text = ColumnObrisiRadnik.Text = "Delete";
            ColumnIzmjeni.Text = ColumnIzmjeniRadnik.Text = "Edit";
            ColumnDodajNaNalog.HeaderText = "Ticket";
            ColumnDodajNaNalog.Text = "Ticket";
            lbFilterPartnera.Text = lbPreatraziRadnika.Text = "Search :";
            btSacuvajIzmjeneKlijenta.Text = "SAVE CHANGES CLIENT";
            btSacuvajIzmjeneRadnika.Text = "SAVE CHANGES WORKER";
            gbRadnik.Text = "WORKERS";
            ColumnUloga.HeaderText = "Role";
            ColumnPlata.HeaderText = "Salary";
            ColumnVozackaDozvola.HeaderText = "Driv.Lic.";
            chbPrivilegije.Text = "Privileges";
        }

        public void ukiniPrivilegije()
        {
            gbRadnik.Visible = false;
            rbDodavanjeRadnika.Visible = false;
        }

        public void prebaciNaTemu1()
        {
            this.BackColor = System.Drawing.Color.SkyBlue;
            ((ToolStripMenuItem)GlavnaFormaSF.tsmiTema1.OwnerItem).DropDownItems
           .OfType<ToolStripMenuItem>().ToList()
           .ForEach(item =>
           {
               item.Checked = false;
           });
            GlavnaFormaSF.tsmiTema1.Checked = true;
        }

        public void prebaciNaTemu2()
        {
            this.BackColor = System.Drawing.Color.MistyRose;
            ((ToolStripMenuItem)GlavnaFormaSF.tsmiTema2.OwnerItem).DropDownItems
           .OfType<ToolStripMenuItem>().ToList()
           .ForEach(item =>
           {
               item.Checked = false;
           });
            GlavnaFormaSF.tsmiTema2.Checked = true;
        }

        public void prebaciNaTemu3()
        {
            this.BackColor = System.Drawing.Color.LightYellow;
            ((ToolStripMenuItem)GlavnaFormaSF.tsmiTema3.OwnerItem).DropDownItems
           .OfType<ToolStripMenuItem>().ToList()
           .ForEach(item =>
           {
               item.Checked = false;
           });
            GlavnaFormaSF.tsmiTema3.Checked = true;
        }

        public void prebaciNaBezteme()
        {
            this.BackColor = SystemColors.Control;
            ((ToolStripMenuItem)GlavnaFormaSF.tsmiTemaBezTeme.OwnerItem).DropDownItems
           .OfType<ToolStripMenuItem>().ToList()
           .ForEach(item =>
           {
               item.Checked = false;
           });
            GlavnaFormaSF.tsmiTemaBezTeme.Checked = true;
        }
        public void promjeniFont(string imeFonta)
        {


            List<Control> allControls = GetAllControls(this);
            allControls.ForEach(k => k.Font = new System.Drawing.Font(imeFonta, k.Font.Size, k.Font.Style));


        }
        private List<Control> GetAllControls(Control container, List<Control> list)
        {
            foreach (Control c in container.Controls)
            {

                if (c.Controls.Count > 0)
                    list = GetAllControls(c, list);
                else
                    list.Add(c);
            }

            return list;
        }
        private List<Control> GetAllControls(Control container)
        {
            return GetAllControls(container, new List<Control>());
        }
        private void SubjekatForma_Load(object sender, EventArgs e)
        {

        }
    }
}


