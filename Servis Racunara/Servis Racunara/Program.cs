using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Servis_Racunara
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            PrijavaForma prijavaForma = new PrijavaForma();
            if (prijavaForma.ShowDialog() == DialogResult.OK)
            {
                GlavnaForma glavna = new GlavnaForma();
                int idKorisnika = (prijavaForma.cbKorisnickoIme.SelectedItem as ComboBoxItem).Vrijednost;
                int idfonta = DbServisRacunara.GetFont(idKorisnika);
                int idteme = DbServisRacunara.GetTema(idKorisnika);
                glavna.podesiFontNaOsnovuSacuvanihVrijednosti(idfonta);
                glavna.podesiTemuNaOsnovuSacuvanihVrijednosti(idteme);
                if (prijavaForma.rbPrevediNaSrpski.Checked)
                {
                    glavna.rbPrevediNaSrpski.Checked = true;


                    if (prijavaForma.cbKorisnickoIme.SelectedItem != null)
                    {
                        glavna.lbKorisnickoIme.Text = (prijavaForma.cbKorisnickoIme.SelectedItem as ComboBoxItem).ToString();
                        Application.Run(glavna);
                    }

                }
                    
                else
                {
                    glavna.rbPrevediNaengleski.Checked = true;
                    if (prijavaForma.cbKorisnickoIme.SelectedItem != null)
                    {
                        glavna.lbKorisnickoIme.Text = (prijavaForma.cbKorisnickoIme.SelectedItem as ComboBoxItem).ToString();
                        Application.Run(glavna);
                    }
                }
                    
            }
            else
            {
                Application.Exit();
            }
        }

    }
}
