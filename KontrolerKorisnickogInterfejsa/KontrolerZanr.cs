using Domen;
using KontrolerAplikacioneLogike;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KontrolerKorisnickogInterfejsa
{
    public class KontrolerZanr
    {
        public static Komunikacija kom = KontrolerPrijava.kom;
        public static List<Zanr> zanrovi;
        public static BindingList<Zanr> listaZanrova;

        public bool SacuvajZanr(TextBox txtZanr)
        {
            Zanr z = new Zanr();
            
            z.Naziv = txtZanr.Text;
            if (z.Naziv == "")
            {
                MessageBox.Show("Niste uneli naziv zanra!");
                return false;
            }

            Object rez = kom.SacuvajZanr(z);

            if (rez == null)
            {
                MessageBox.Show("Sistem nije uspeo da sacuva zanr!");
                return false;
            }
            else
            {
                MessageBox.Show("Sistem je uspesno da sacuvao zanr!");
                txtZanr.Clear();
                return true;
            }
        }

        public void VratiSveZanrove(DataGridView dgwPregledZanrova)
        {
            dgwPregledZanrova.Rows.Clear();
            dgwPregledZanrova.Refresh();

            zanrovi = kom.VratiSveZanrove();
            listaZanrova = new BindingList<Zanr>(zanrovi);

            if (zanrovi.Count == 0)
            {
                MessageBox.Show("Sistem nije uspeo da pronadje zanrove!");
            }
            else
            {
                dgwPregledZanrova.DataSource = listaZanrova;
                MessageBox.Show("Sistem je uspesno pronasao zanrove!");
            }
        }


        //public static bool PoveziSeNaServer()
        //{
        //    kom = new Komunikacija();
        //    return kom.PoveziSeNaServer();
        //}
    }
}
