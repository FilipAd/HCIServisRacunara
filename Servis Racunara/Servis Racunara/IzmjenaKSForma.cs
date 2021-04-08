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
        public GlavnaForma GlavnaFormaIKS;
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
                string srb = "Успјешно ажурирање";
                string eng = "Successful update";

                MessageBox.Show((GlavnaFormaIKS.rbPrevediNaSrpski.Checked)? srb:eng, String.Empty, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btObracunajIzmjenaKS_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(tbKolicinaIzmjenaKS.Text) || String.IsNullOrEmpty(tbRabatIzmjenaKS.Text))
            {
                string srb = "Морате попунити сва захтјевана поља";
                string eng = "All fields are required";
                MessageBox.Show((GlavnaFormaIKS.rbPrevediNaSrpski.Checked)?srb:eng, String.Empty, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(Int32.Parse(tbKolicinaIzmjenaKS.Text)<1)
            {
                string srb = "Негативне вриједности нису дозвољене, као ни 0";
                string eng = "Negative values are not allowed";
                MessageBox.Show((GlavnaFormaIKS.rbPrevediNaSrpski.Checked) ? srb : eng, String.Empty, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                
                    decimal rabat = Decimal.Parse(tbRabatIzmjenaKS.Text);
                    int kolicina = Int32.Parse(tbKolicinaIzmjenaKS.Text);
                    decimal jedinicnaCijena = Decimal.Parse(tbJedinicnaCijenaIzmjenaKS.Text);
                    tbUkupnoIzmjenaKS.Text = Math.Round((((1 - (rabat / 100)) * jedinicnaCijena) * kolicina), 2).ToString();
                    btZapamtiIzmjenaKS.Enabled = true;
                }
               
            }
            catch (Exception Ex)
            {
                tbRabatIzmjenaKS.Text = "";
                tbKolicinaIzmjenaKS.Text = "";
                string srb = "Унесене вриједности морају бити бројеви, и компонента мора бити селектована";
                string eng = "The values entered must be numbers, and the component must be selected";
                MessageBox.Show((GlavnaFormaIKS.rbPrevediNaSrpski.Checked) ? srb : eng, String.Empty, MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void tbNazivIzmjenaKS_TextChanged(object sender, EventArgs e)
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
        private void SubjekatForma_Load(object sender, EventArgs e)
        {

        }
    }
}
