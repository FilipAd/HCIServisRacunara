using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace Servis_Racunara
{
    public partial class PrijavaForma : Form
    {
        public GlavnaForma GlavnaFormaLogin;
        public PrijavaForma()
        {
            InitializeComponent();
            tbLozinka.PasswordChar = '*';
            rbPrevediNaSrpski.Checked = true;
            napuniCBIme();
        }

        private void rbPrevediNaSrpski_CheckedChanged(object sender, EventArgs e)
        {
            prevediNaSrpski();



        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void tbKoriscnickoIme_TextChanged(object sender, EventArgs e)
        {

        }

        private void prevediNaSrpski()
        {
            lbKorisnickoIme.Text = "ИМЕ :";
            lbLozinka.Text = "ЛОЗИНКА :";
            btPrijava.Text = "ПРИЈАВА";
        }

        private void prevediNaEngleski()
        {
            lbKorisnickoIme.Text = "NAME :";
            lbLozinka.Text = "PASSWORD :";
            btPrijava.Text = "LOGIN";
        }
        private void napuniCBIme()
        {
            List<PrikazRadnika> radnici = DbServisRacunara.GetRadnici();
            foreach (PrikazRadnika radnik in radnici)
            {
                ComboBoxItem item = new ComboBoxItem(radnik.Ime, radnik.IdPartnera);

                cbKorisnickoIme.Items.Add(item);


            }
        }
        private void rbPrevediNaengleski_CheckedChanged(object sender, EventArgs e)
        {
            prevediNaEngleski();
        }

        private void btPrijava_Click(object sender, EventArgs e)
        {
            string srb = "НЕИСПРАВНА ЛОЗИНКА ИЛИ НАЛОГ";
            string eng = "WRONG PASSWOR OR USERNAME";
            lbGreska.Text = (rbPrevediNaSrpski.Checked) ? srb : eng;
            ComboBoxItem pom = cbKorisnickoIme.SelectedItem as ComboBoxItem;
            if (pom != null)
            {
                NalogLozinka nalog = DbServisRacunara.GetKorisnikLozinka(pom.Vrijednost);
                if (nalog.lozinka.Equals(NalogLozinka.Hash(tbLozinka.Text.Trim())) && nalog.korisnickoIme.Equals(pom.Tekst.Trim()))
                    DialogResult = DialogResult.OK;
                else
                {
                  
                    lbGreska.Text = (rbPrevediNaSrpski.Checked) ? srb : eng;
                    lbGreska.Visible = true;
                    tbLozinka.Text =String.Empty;
                }
            }
            else
           
            lbGreska.Text = (rbPrevediNaSrpski.Checked) ? srb : eng;
            lbGreska.Visible = true;
            tbLozinka.Text =String.Empty;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
      
    }
}
