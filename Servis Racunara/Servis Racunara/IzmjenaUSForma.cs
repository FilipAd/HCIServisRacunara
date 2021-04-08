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
    public partial class IzmjenaUSForma : Form
    {
        public GlavnaForma GlavnaFormaIUS;
        public IzmjenaUSForma()
        {
            InitializeComponent();
        }

        private void btObracunajIzmjenaUS_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(tbKolicinaIzmjenaUS.Text) || String.IsNullOrEmpty(tbRabatIzmejnaUS.Text))
            {
                string srb = "Морате попунити сва захтјевана поља";
                string eng = "All fields are required";
                MessageBox.Show((GlavnaFormaIUS.rbPrevediNaSrpski.Checked)?srb:eng, String.Empty, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (Int32.Parse(tbKolicinaIzmjenaUS.Text) < 1)
            {
                string srb = "Негативне вриједности нису дозвољене, коа ни 0";
                string eng = "Negative values are not allowed";
                MessageBox.Show((GlavnaFormaIUS.rbPrevediNaSrpski.Checked) ? srb : eng, String.Empty, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                
                    decimal rabat = Decimal.Parse(tbRabatIzmejnaUS.Text);
                    int kolicina = Int32.Parse(tbKolicinaIzmjenaUS.Text);
                    decimal jedinicnaCijena = Decimal.Parse(tbCijenaPoHIzmjenaUS.Text);
                    tbUkupnoIzmjenaUS.Text = Math.Round((((1 - (rabat / 100)) * jedinicnaCijena) * kolicina), 2).ToString();
                    btZapamtiIzmjenaUS.Enabled = true;
                }
               
            }
            catch (Exception Ex)
            {
                tbRabatIzmejnaUS.Text = "";
                tbKolicinaIzmjenaUS.Text = "";
                string srb = "Унесене вриједности морају бити бројеви, и услуга мора бити селектована";
                string eng = "The values entered must be numbers, and the service must be selected";
                MessageBox.Show((GlavnaFormaIUS.rbPrevediNaSrpski.Checked) ? srb : eng, String.Empty, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btZapamtiIzmjenaUS_Click(object sender, EventArgs e)
        {
            var us = new UslugaStavka()
            {
                BrojRadnogNaloga = Int32.Parse(tbBrojNalogaIzmjenaUS.Text),
                SifraUsluge = Int32.Parse(tbSifraIzmejnaUS.Text),
                Kolicina=Int32.Parse(tbKolicinaIzmjenaUS.Text),
                CijenaPoH=Decimal.Parse(tbCijenaPoHIzmjenaUS.Text),
                Rabat=Decimal.Parse(tbRabatIzmejnaUS.Text),
                UkupnaCijena=Decimal.Parse(tbUkupnoIzmjenaUS.Text),
            };
            DbServisRacunara.UpdateUslugaStavka(us);
            string srb = "Успјешно ажурирање";
            string eng = "Successful update";
            MessageBox.Show((GlavnaFormaIUS.rbPrevediNaSrpski.Checked)?srb:eng, String.Empty, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void IzmjenaUSForma_Load(object sender, EventArgs e)
        {

        }

        public void prevediNaSrpski()
        {
            lbBrojNalogaIzmjenaUS.Text = "БРОЈ РАДНОГ НАЛОГА :";
            lbSifraIzmjenaUS.Text = "ШИФРА :";
            lbNazivIzmjenaUS.Text = "НАЗИВ :";
            lbIzmjenaCijenaPoHUS.Text = "ЦИЈЕНА ПО h :";
            lbIzmjeniKolicinaUS.Text = "КОЛИЧИНА :";
            lbStaraKolicinaIzmjenaUS.Text = "СТАРА КОЛИЧИНА :";
            lbRabatIzmjeniUS.Text = "РАБАТ (%) :";
            lbUkupnoIzmjenaUS.Text = "УКУПНО :";
            btObracunajIzmjenaUS.Text = "ОБРАЧУНАЈ";
            btZapamtiIzmjenaUS.Text = "ЗАПАМТИ";


        }

        public void prevediNaEngleski()
        {
            lbBrojNalogaIzmjenaUS.Text = "TICKET NUMBER :";
            lbSifraIzmjenaUS.Text = "CODE :";
            lbNazivIzmjenaUS.Text = "TITLE :";
            lbIzmjenaCijenaPoHUS.Text = "COST PER h :";
            lbIzmjeniKolicinaUS.Text = "QUANTITY :";
            lbStaraKolicinaIzmjenaUS.Text = "OLD QUANTITY :";
            lbRabatIzmjeniUS.Text = "DISCOUNT (%) :";
            lbUkupnoIzmjenaUS.Text = "SUM :";
            btObracunajIzmjenaUS.Text = "CALCULATE";
            btZapamtiIzmjenaUS.Text = "SAVE";


        }

        private void tbBrojNalogaIzmjenaUS_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbSifraIzmejnaUS_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbIzmjenaUSStaraKolicina_TextChanged(object sender, EventArgs e)
        {

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
    }
}
