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
    public partial class UslugaStavkaForma : Form
    {
        public GlavnaForma GlavnaFormaUSLUGA;
        public UslugaStavkaForma()
        {
            InitializeComponent();
            napuniDgvUsluga();
            tbRabatUS.Text = "0";
        }
        public UslugaStavkaForma(string BrojNaloga)
        {
            InitializeComponent();
            napuniDgvUsluga();
            tbBrojNalogaUS.Text = BrojNaloga;
            tbRabatUS.Text = "0";
        }

        private void UslugaStavka_Load(object sender, EventArgs e)
        {

        }
        private void napuniDgvUsluga()
        {
            dgvUsluga.Rows.Clear();
            foreach (var u in DbServisRacunara.GetUsluga(tbFilterUsluga.Text))
            {
                DataGridViewRow row = new DataGridViewRow()
                {
                    Tag = u

                };
                row.CreateCells(dgvUsluga,u.SifraUsluge, u.Naziv,u.CijenaPoH);
                dgvUsluga.Rows.Add(row);
            }
        }

        private void tbFilterUsluga_TextChanged(object sender, EventArgs e)
        {
            napuniDgvUsluga();
        }

        private void dgvUsluga_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvUsluga.Columns[e.ColumnIndex].Name == "ColumnOznaci")
            {
                if (dgvUsluga.Rows[e.RowIndex].Cells[ColumnSifraUsluge.Index].Value != null)
                {
                    

                    tbSifraUS.Text = dgvUsluga.Rows[e.RowIndex].Cells[ColumnSifraUsluge.Index].Value.ToString();
                    tbNazivUS.Text = dgvUsluga.Rows[e.RowIndex].Cells[ColumnNazivUsluge.Index].Value.ToString();
                    tbCijenaPoSatuUS.Text = dgvUsluga.Rows[e.RowIndex].Cells[ColumnCijenaPoH.Index].Value.ToString();
                }
                else
                    MessageBox.Show("Стиснули сте празно поље",String.Empty, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void tbBrojNalogaUS_TextChanged(object sender, EventArgs e)
        {

        }

        private void btIzracunajCijenuUS_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(tbKolicinaUS.Text) || String.IsNullOrEmpty(tbRabatUS.Text))
                {
                string srb = "МОРАТЕ ПОПУНИТИ СВА ЗАХТЈЕВАНА ПОЉА";
                string eng = "All fields are required";
                MessageBox.Show((GlavnaFormaUSLUGA.rbPrevediNaSrpski.Checked)? srb:eng, "GRESKA PRAZNO POLJE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if(Int32.Parse(tbKolicinaUS.Text)<1)
                   {
                    string srb = "Негативне вриједности нису дозвољене, као ни 0";
                    string eng = "Negative values are not allowed";
                    MessageBox.Show((GlavnaFormaUSLUGA.rbPrevediNaSrpski.Checked) ? srb : eng,String.Empty, MessageBoxButtons.OK, MessageBoxIcon.Error);

                   }
                else
                {
                    
                       decimal rabat = Decimal.Parse(tbRabatUS.Text);
                        int kolicina = Int32.Parse(tbKolicinaUS.Text);
                        decimal jedinicnaCijena = Decimal.Parse(tbCijenaPoSatuUS.Text);
                        tbCijenaUS.Text = Math.Round((((1 - (rabat / 100)) * jedinicnaCijena) * kolicina), 2).ToString();
                        btDodajUsluguNaNalog.Enabled = true;
                    }
                    
                }
            catch (Exception Ex)
            {
                tbKolicinaUS.Text = "";
                tbKolicinaUS.Text = "";
                string eng1 = "The values entered must be numbers, and the service must be selected";
                string srb1 = "Унесене вриједности морају бити бројеви, и услуга мора бити селектована";
                MessageBox.Show((GlavnaFormaUSLUGA.rbPrevediNaSrpski.Checked) ? srb1 : eng1, "GRESKA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void tbKolicinaUS_TextChanged(object sender, EventArgs e)
        {
            btDodajUsluguNaNalog.Enabled = false;
        }

        private void btDodajUsluguNaNalog_Click(object sender, EventArgs e)
        {
            var usluga = new UslugaStavka()
            {
                SifraUsluge = Int32.Parse(tbSifraUS.Text),
                BrojRadnogNaloga = Int32.Parse(tbBrojNalogaUS.Text),
                Kolicina = Int32.Parse(tbKolicinaUS.Text),
                CijenaPoH = Decimal.Parse(tbCijenaPoSatuUS.Text),
                Rabat = Decimal.Parse(tbRabatUS.Text),
                UkupnaCijena=Decimal.Parse(tbCijenaUS.Text),
                
            };
            btDodajUsluguNaNalog.Enabled = true;
            DbServisRacunara.InsertUslugaStavkaNaNalog(usluga);
            string srb = "Успјешно сте додали ставку";
            string eng = "You have successfully added an item";
            MessageBox.Show((GlavnaFormaUSLUGA.rbPrevediNaSrpski.Checked) ? srb : eng,String.Empty, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void tbRabatUS_TextChanged(object sender, EventArgs e)
        {
            btDodajUsluguNaNalog.Enabled = false;
        }

        public void prevediNasrpski()
        {
            lbFilterUsluga.Text = "Претражи :";
            gbUslugaStavka.Text = "УСЛУГЕ :";
            ColumnSifraUsluge.HeaderText = "Шифра";
            ColumnNazivUsluge.HeaderText = "Назив";
            ColumnCijenaPoH.HeaderText = "Цијена по h";
            ColumnOznaci.HeaderText = ColumnOznaci.Text = "Означи";
            lbBrojNalogaUslugaStavka.Text = "БРОЈ НАЛОГА :";
            lbSifraUsluge.Text = "ШИФРА :";
            lbNazivUsluge.Text = "НАЗИВ :";
            lbCijenaUslugePoH.Text = "ЦИЈЕНА ПО h :";
            lbKolicinaUsluge.Text = "КОЛИЧНА :";
            lbRabatUsluga.Text = "РАБАТ (%) :";
            lbCijenaUslugeZavrsna.Text = "ЦИЈЕНА :";
            btDodajUsluguNaNalog.Text = "ДОДАЈ НА НАЛОГ";
            btIzracunajCijenuUS.Text = "ОБРАЧУНАЈ";

        }

        public void prevediNaEngleski()
        {
            lbFilterUsluga.Text = "Search :";
            gbUslugaStavka.Text = "SERVICES :";
            ColumnSifraUsluge.HeaderText = "Code";
            ColumnNazivUsluge.HeaderText = "Title";
            ColumnCijenaPoH.HeaderText = "Cost per h";
            ColumnOznaci.HeaderText = ColumnOznaci.Text = "Select";
            lbBrojNalogaUslugaStavka.Text = "TICKET NUMBER :";
            lbSifraUsluge.Text = "CODE :";
            lbNazivUsluge.Text = "TITLE :";
            lbCijenaUslugePoH.Text = "COST PER h :";
            lbKolicinaUsluge.Text = "QUANTITY :";
            lbRabatUsluga.Text = "DISCOUNT (%) :";
            lbCijenaUslugeZavrsna.Text = "PRICE :";
            btDodajUsluguNaNalog.Text = "ADD TO TICKET";
            btIzracunajCijenuUS.Text = "CALCULATE";
        }

        private void gbUslugaStavka_Enter(object sender, EventArgs e)
        {

        }
        public void prebaciNaTemu1()
        {
            this.BackColor = System.Drawing.Color.SkyBlue;

        }

        public void prebaciNaTemu2()
        {
            this.BackColor = System.Drawing.Color.MistyRose;

        }

        public void prebaciNaTemu3()
        {
            this.BackColor = System.Drawing.Color.LightYellow;

        }

        public void prebaciNaBezteme()
        {
            this.BackColor = SystemColors.Control;

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
    }
}
