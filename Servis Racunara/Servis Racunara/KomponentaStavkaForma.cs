﻿using System;
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
                    string srb = "Морате попунити сва захтјевана поља";
                    string eng = "All fields are required";

                    MessageBox.Show((GlavnaFormaKS.rbPrevediNaSrpski.Checked)?srb:eng, "GRESKA PRAZNO POLJE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if ((Int32.Parse(tbDostupnoKS.Text) - Int32.Parse(tbKolicinaKS.Text)) < 0)
                {
                    string srb = "Тражити више компоненти него што их има на стању";
                    string eng = "LOOK FOR MORE COMPONENTS THAN THEY HAVE IN STOCK";
                    MessageBox.Show((GlavnaFormaKS.rbPrevediNaSrpski.Checked)?srb:eng, "GRESKA BROJA KOMPONENTI", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                        string srb = "Унесене вриједности морају бити бројеви, и услуга мора бити селектована";
                        string eng = "The values entered must be numbers, and the service must be selected";
                        MessageBox.Show((GlavnaFormaKS.rbPrevediNaSrpski.Checked)?srb:eng, "GRESKA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch(FormatException fx)
            {
                string srb = "Унесене вриједности морају бити бројеви";
                string eng = "The values entered must be numbers";
                MessageBox.Show((GlavnaFormaKS.rbPrevediNaSrpski.Checked)? srb:eng, "GRESKA VRIJEDNSOTI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
        }


        private void dgvKomponentaStavka_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvKomponentaStavka.Columns[e.ColumnIndex].Name == "ColumnOznaci")
            {
                if (dgvKomponentaStavka.Rows[e.RowIndex].Cells[ColumnSifraKomponenteKS.Index].Value != null)
                {
                    btDodajNaNalog.Enabled = true;

                    tbSifraKomponenteKS.Text = dgvKomponentaStavka.Rows[e.RowIndex].Cells[ColumnSifraKomponenteKS.Index].Value.ToString();
                    tbNazivKS.Text = dgvKomponentaStavka.Rows[e.RowIndex].Cells[ColumnNazivKS.Index].Value.ToString();
                    tbJedinicnaCijenaKS.Text = dgvKomponentaStavka.Rows[e.RowIndex].Cells[ColumnCijenaPoKomaduKS.Index].Value.ToString();
                    tbDostupnoKS.Text = dgvKomponentaStavka.Rows[e.RowIndex].Cells[ColumnDostupnaKolicinaKS.Index].Value.ToString();
                }
                else
                    MessageBox.Show("Stisnuli ste prazno polje", "Greska praznog polja", MessageBoxButtons.OK, MessageBoxIcon.Error);

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
            string srb = "Успјешно сте додали ставку";
            string eng = "You have successfully added an item";
            MessageBox.Show((GlavnaFormaKS.rbPrevediNaSrpski.Checked)?srb:eng, "USPJESNO DODAVANJE KOMPONENTE", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        public void prevediNaSrpski()
        {
            lbFilterKS.Text = "Претражи :";
            gbKomponentaStavka.Text = "КОМПОНЕНТЕ";
            ColumnSifraKomponenteKS.HeaderText = "Шифра";
            ColumnNazivKS.HeaderText = "Назив";
            ColumnCijenaPoKomaduKS.HeaderText = "Цијена по комаду";
            ColumnDostupnaKolicinaKS.HeaderText = "ДоступнаКоличина";
            ColumnOznaci.HeaderText = ColumnOznaci.Text = "Одабери";
            lbBrojRadnogNalogaKS.Text = "БРОЈ НАЛОГА :";
            lbSifraKomponenteKS.Text = "ШИФРА КОМПОНЕНТЕ :";
            lbNazivKS.Text = "НАЗИВ :";
            lbDostupnaKolicinaKS.Text = "ДОСТУПНО :";
            lbJedinicnaCijena.Text = "ЈЕДИНИЧНА ЦИЈЕНА :";
            lbKolicinaKS.Text = "КОЛИЧИНА :";
            lbRabatKS.Text = "РАБАТ (%) :";
            lbUkupnaCijena.Text = "УКУПНА ЦИЈЕНА :";
            btObracunajKS.Text = "ОБРАЧУНАЈ";
            btDodajNaNalog.Text = "ДОДАЈ НА НАЛОГ";

        }

        public void prevediNaEngleski()
        {
            lbFilterKS.Text = "Search :";
            gbKomponentaStavka.Text = "COMPONENTS";
            ColumnSifraKomponenteKS.HeaderText = "Code";
            ColumnNazivKS.HeaderText = "Title";
            ColumnCijenaPoKomaduKS.HeaderText = "Unit price";
            ColumnDostupnaKolicinaKS.HeaderText = "Available";
            ColumnOznaci.HeaderText = ColumnOznaci.Text = "Select";
            lbBrojRadnogNalogaKS.Text = "TICKET NUMBER :";
            lbSifraKomponenteKS.Text = "CODE :";
            lbNazivKS.Text = "TITLE :";
            lbDostupnaKolicinaKS.Text = "AVAILABLE :";
            lbJedinicnaCijena.Text = "UNIT PRICE :";
            lbKolicinaKS.Text = "QUANTITY :";
            lbRabatKS.Text = "DISCOUNT (%) :";
            lbUkupnaCijena.Text = "SUM PRICE :";
            btObracunajKS.Text = "CALCULATE";
            btDodajNaNalog.Text = "ADD TO TICKET";




        }


    }
}
