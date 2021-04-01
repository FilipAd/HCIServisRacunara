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
    public partial class PromjenaLozinkeForma : Form
    {
        public GlavnaForma GlavnaFormaPromjenaLozinke;
        public PromjenaLozinkeForma()
        {
            InitializeComponent();
            tbStaraLozinka.PasswordChar = '*';
            tbNovaLozinka.PasswordChar = '*';
            tbPotvrtaLozinke.PasswordChar = '*';
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void prevediNaSrpski()
        {
            lbStaraLozinka.Text = "Стара лозинка :";
            lbNovaLozinka.Text = "Нова лозинка :";
            lbPotvrdaLozinke.Text = "Поновите нову лозинку :";
            btPromjeniLozinku.Text = "САЧУВАЈ";
            lbImeKorisnika.Text = "Корисник :";

        }

        public void prevediNaEngleski()
        {
            lbStaraLozinka.Text = "Old password :";
            lbNovaLozinka.Text = "New password :";
            lbPotvrdaLozinke.Text = "Retype new password :";
            btPromjeniLozinku.Text = "SAVE";
            lbImeKorisnika.Text = "User";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btPromjeniLozinku_Click(object sender, EventArgs e)
        {
            string [] el = lbIme.Text.Split('-');
            int id = Int32.Parse(el[1]);
            NalogLozinka pomnalog = DbServisRacunara.GetKorisnikLozinka(id);
            
            if (!(tbNovaLozinka.Text.Trim().Equals(tbPotvrtaLozinke.Text.Trim())))
            {
                string eng = "New password and retype password are not equal";
                string srb = "Нова лозинка и поновљена нова лозинка се не поклапају";
                tbNovaLozinka.Text = String.Empty;
                tbPotvrtaLozinke.Text = String.Empty;
                MessageBox.Show((GlavnaFormaPromjenaLozinke.rbPrevediNaSrpski.Checked) ? srb : eng, "НЕУСПЈЕШНО АЖУРИРАЊЕ", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if(!(pomnalog.lozinka.Equals(NalogLozinka.Hash(tbStaraLozinka.Text.Trim()))))
            {
                string eng = "Old password is invalid";
                string srb = "Стара лозинка није исправна";
                tbStaraLozinka.Text = String.Empty;
                MessageBox.Show((GlavnaFormaPromjenaLozinke.rbPrevediNaSrpski.Checked) ? srb : eng, "ГРЕШКА", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DbServisRacunara.UpdateLozinka(id, tbNovaLozinka.Text.Trim());
                string eng = "Successful password update";
                string srb = "Успјешно сте промјенили лозинку";
                MessageBox.Show((GlavnaFormaPromjenaLozinke.rbPrevediNaSrpski.Checked) ? srb : eng, "USPJESNA PROMEJNA LOZINKE", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void tbPotvrtaLozinke_TextChanged(object sender, EventArgs e)
        {

        }

        private void PromjenaLozinkeForma_Load(object sender, EventArgs e)
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
