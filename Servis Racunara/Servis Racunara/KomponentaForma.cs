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
    public partial class KomponentaForma : Form
    {
        public static int staraSifra;
        public GlavnaForma GlavnaFormaKOM;
        public KomponentaForma()
        {
            InitializeComponent();
            NapuniGrid();
        }

        void NapuniGrid()
        {
            dgvKomponenta.Rows.Clear();
            foreach (var k in DbServisRacunara.GetKomponenteFilter(tbFilter.Text))
            {
                DataGridViewRow row = new DataGridViewRow()
                {
                    Tag = k

                };
                row.CreateCells(dgvKomponenta,k.SifraKomponente,k.NazivKomponente,k.CijenaKomponente,k.DostupnaKolicina);
                dgvKomponenta.Rows.Add(row);
            }
        }
       

        private void dgvKomponenta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btSacuvajIzmjeneKomponenta.Enabled = true;
            int pocetnaSifra = (int)dgvKomponenta.Rows[e.RowIndex].Cells[ColumnSifra.Index].Value;

            if (dgvKomponenta.Columns[e.ColumnIndex].Name=="ColumnObrisi")
            {
                btDodajKomponentu.Enabled = true;
                if (MessageBox.Show("Da li ste sigruni da zelite da obrisete ovu komponentu?","Message",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
                    {
                    int sifra = (int)dgvKomponenta.Rows[e.RowIndex].Cells[0].Value;
                    DbServisRacunara.DeleteKoomponentaSifra(sifra);
                    dgvKomponenta.Rows.RemoveAt(e.RowIndex);
                    }
            }
            else if(dgvKomponenta.Columns[e.ColumnIndex].Name=="ColumnIzmjeni")
            {
                btSacuvajIzmjeneKomponenta.Enabled = true;
                staraSifra = (int)dgvKomponenta.Rows[e.RowIndex].Cells[ColumnSifra.Index].Value;
                btSacuvajIzmjeneKomponenta.Enabled = true;
                tbSifraKomponente.Text=dgvKomponenta.Rows[e.RowIndex].Cells[ColumnSifra.Index].Value.ToString();
                tbNazivKomponente.Text=dgvKomponenta.Rows[e.RowIndex].Cells[ColumnNaziv.Index].Value.ToString();
                tbCijenaPoKomadu.Text= dgvKomponenta.Rows[e.RowIndex].Cells[ColumnCijena.Index].Value.ToString();
                tbKolicina.Text= dgvKomponenta.Rows[e.RowIndex].Cells[ColumnDostupnaKolicina.Index].Value.ToString();

            }
            else if(dgvKomponenta.Columns[e.ColumnIndex].Name == "ColumnDodaj")
            {
                btDodajKolicinu.Enabled = true;
                btSacuvajIzmjeneKomponenta.Enabled = false;
                btDodajKomponentu.Enabled = false;
                tbSifraKomponente.Text = dgvKomponenta.Rows[e.RowIndex].Cells[ColumnSifra.Index].Value.ToString();
                tbNazivKomponente.Text = dgvKomponenta.Rows[e.RowIndex].Cells[ColumnNaziv.Index].Value.ToString();
                tbCijenaPoKomadu.Text = dgvKomponenta.Rows[e.RowIndex].Cells[ColumnCijena.Index].Value.ToString();
                tbKolicina.Text = dgvKomponenta.Rows[e.RowIndex].Cells[ColumnDostupnaKolicina.Index].Value.ToString();
                tbSifraKomponente.Enabled = false;
                tbNazivKomponente.Enabled = false;
                tbNazivKomponente.Enabled = false;
                tbCijenaPoKomadu.Enabled = false;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btDodajKomponentu_Click(object sender, EventArgs e)
        {
            try
            {
                var komponenta = new Komponenta()
                {
                SifraKomponente = Int32.Parse(tbSifraKomponente.Text),
                NazivKomponente = tbNazivKomponente.Text,
                CijenaKomponente = Decimal.Parse(tbCijenaPoKomadu.Text),
                DostupnaKolicina = Int32.Parse(tbKolicina.Text)
                };
            
                DbServisRacunara.InsertKomponenta(komponenta);
            }
            catch(Exception)
            {
                MessageBox.Show("Neispravni parametri");
            }
                NapuniGrid();
            
        }

        private void btSacuvajIzmjeneKomponenta_Click(object sender, EventArgs e)
        {
            try
            {
                var komponenta = new Komponenta()
                {
                    SifraKomponente = Int32.Parse(tbSifraKomponente.Text),
                    NazivKomponente = tbNazivKomponente.Text,
                    CijenaKomponente = Decimal.Parse(tbCijenaPoKomadu.Text),
                    DostupnaKolicina = Int32.Parse(tbKolicina.Text)
                };
                DbServisRacunara.UpdateKomponenta(staraSifra, komponenta);
            }
            catch(Exception)
            {
                MessageBox.Show("Neuspjesno azuriranje");
            }
            NapuniGrid();
            btSacuvajIzmjeneKomponenta.Enabled = false;
        }

        private void btDodajKolicinu_Click(object sender, EventArgs e)
        {
            int sifra = Int32.Parse(tbSifraKomponente.Text);
            int kolicina = Int32.Parse(tbKolicina.Text);
            if (kolicina < 0)
            {
                MessageBox.Show("GRESKA! NE MOZETE UBACIVATI NEGATIVNE VRIJEDNOSTI", "GRESKA BROJA KOMPONENTI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DbServisRacunara.UpdateKolicina(sifra, kolicina);
                NapuniGrid();
                btDodajKolicinu.Enabled = false;
                btDodajKomponentu.Enabled = true;
                tbSifraKomponente.Text = "";
                tbNazivKomponente.Text = "";
                tbCijenaPoKomadu.Text = "";
                tbKolicina.Text = "";
                tbSifraKomponente.Enabled = true;
                tbNazivKomponente.Enabled = true;
                tbCijenaPoKomadu.Enabled = true;
            }

        }

        private void tbFilter_TextChanged(object sender, EventArgs e)
        {
            NapuniGrid();
        }
        public void prevediNaSrpski()
        {
            lbFilter.Text = "Претрага ( шифра или назив ):";
            ColumnSifra.HeaderText = "Шифра";
            ColumnNaziv.HeaderText = "Назив";
            ColumnCijena.HeaderText = "Цијена по комаду";
            ColumnDostupnaKolicina.HeaderText = "Доступна количина";
            ColumnIzmjeni.HeaderText=ColumnIzmjeni.Text = "Измјени";
            ColumnObrisi.HeaderText = ColumnObrisi.Text = "Обриши";
            ColumnDodaj.HeaderText = ColumnDodaj.Text = "Додај";
            gbDodavanjeKomponente.Text = "ДОДАВАЊЕ КОМПОНЕНТЕ";
            lbSifraKomponente.Text = "Шифра компоненте :";
            lbNazivKomponente.Text = "Назив компоненте :";
            lbCijenaPoKomadu.Text = "Цијена по комаду :";
            lbKolicina.Text = "Количина :";
            btSacuvajIzmjeneKomponenta.Text = "САЧУВАЈ ИЗМЈЕНЕ";
            btDodajKolicinu.Text = "ДОДАЈ НА ПОСТОЈЕЋУ КОЛИЧИНУ";
            btDodajKomponentu.Text = "ДОДАЈ";

        }

        public void prevediNaEngleski()
        {
            lbFilter.Text = "Search ( code or title ):";
            ColumnSifra.HeaderText = "Code";
            ColumnNaziv.HeaderText = "Title";
            ColumnCijena.HeaderText = "Unit price";
            ColumnDostupnaKolicina.HeaderText = "Available";
            ColumnIzmjeni.HeaderText = ColumnIzmjeni.Text = "Edit";
            ColumnObrisi.HeaderText = ColumnObrisi.Text = "Delete";
            ColumnDodaj.HeaderText = ColumnDodaj.Text = "Add";
            gbDodavanjeKomponente.Text = "ADD COMPONENT";
            lbSifraKomponente.Text = "Code :";
            lbNazivKomponente.Text = "Title :";
            lbCijenaPoKomadu.Text = "Unit Price :";
            lbKolicina.Text = "Quantity :";
            btSacuvajIzmjeneKomponenta.Text = "SAVE CHANGES";
            btDodajKolicinu.Text = "ADD ON EXISTING";
            btDodajKomponentu.Text = "ADD";
        }
    }
}
