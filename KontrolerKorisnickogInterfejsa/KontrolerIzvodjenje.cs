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
    public class KontrolerIzvodjenje
    {
        public static Komunikacija kom = KontrolerPrijava.kom;
        public static List<Izvodjenje> izvodjenja;
        public static BindingList<Izvodjenje> listaIzvodjenja;
        public static Repertoar repertoar;

        public void DodajIzvodjenje(ComboBox cmbPredstava, ComboBox cmbDan, List<Izvodjenje> lista, Repertoar r, DataGridView dgwIzvodjenja)
        {
            Izvodjenje i = new Izvodjenje();
            i.Predstava = cmbPredstava.SelectedItem as Predstava;
            i.Repertoar = r;
            i.Datum = (DateTime)cmbDan.SelectedItem;
            lista.Add(i);

            izvodjenja = lista;
            listaIzvodjenja = new BindingList<Izvodjenje>(izvodjenja);

            dgwIzvodjenja.DataSource = listaIzvodjenja;
        }

        public void VratiIzvodjenjaZaPredstavu(ComboBox cmbPredstava, DataGridView dgwIzvodjenja)
        {
            Predstava p = cmbPredstava.SelectedItem as Predstava;
            Izvodjenje i = new Izvodjenje();
            i.Predstava = p;

            izvodjenja = kom.VratiSvaIzvodjenjaZaPredstavu(i);
            listaIzvodjenja = new BindingList<Izvodjenje>(izvodjenja);

            dgwIzvodjenja.Rows.Clear();
            dgwIzvodjenja.Refresh();
            dgwIzvodjenja.DataSource = listaIzvodjenja;
        }

        public bool IzmeniIzvodjenje(Izvodjenje izvodjenje, DateTimePicker dtpDatum)
        {
            Izvodjenje pom = izvodjenje;
            pom.Datum = dtpDatum.Value;

            Object rez = kom.IzmeniIzvodjenje(pom);

            if (rez == null)
            {
                MessageBox.Show("Sistem nije uspeo da izmeni izvodjenje!");
                return false;
            }
            else
            {
                MessageBox.Show("Sistem je uspesno izmenio izvodjenje!");
                return true;
            }
        }

        public bool ObrisiIzvodjenje(DataGridView dgwIzvodjenja)
        {
            Izvodjenje pom = dgwIzvodjenja.CurrentRow.DataBoundItem as Izvodjenje;

            Object rez = kom.ObrisiIzvodjenje(pom);

            if (rez == null)
            {
                MessageBox.Show("Sistem nije uspeo da obrise izvodjenje!");
                return false;
            }
            else
            {
                MessageBox.Show("Sistem je uspesno obrisao izvodjenje!");
                return true;
            }
        }

        public Izvodjenje IzaberiIzvodjenje(TextBox txtNazivPredstave, DateTimePicker dtpDatum, DataGridView dgwIzvodjenja, Repertoar repertoar)
        {
            Izvodjenje i = dgwIzvodjenja.CurrentRow.DataBoundItem as Izvodjenje;
            txtNazivPredstave.Text = i.Predstava.NazivPredstave;
            dtpDatum.MinDate = repertoar.DatumVazenjaOd;
            dtpDatum.MaxDate = repertoar.DatumVazenjaDo;
            return i;
        }

        public void VratiIzvodjenjaZaRepertoar(DataGridView dgwIzvodjenja, Repertoar r)
        {
            Izvodjenje i = new Izvodjenje();
            i.Repertoar = r;

            izvodjenja = kom.VratiSvaIzvodjenjaZaRepertoar(i);
            listaIzvodjenja = new BindingList<Izvodjenje>(izvodjenja);

            dgwIzvodjenja.Rows.Clear();
            dgwIzvodjenja.Refresh();
            dgwIzvodjenja.DataSource = listaIzvodjenja;
        }

        public void VratiIzvodjenjaZaRepertoar(ComboBox cmbRepertoar, DataGridView dgwIzvodjenja)
        {
            Repertoar r = cmbRepertoar.SelectedItem as Repertoar;
            Izvodjenje i = new Izvodjenje();
            i.Repertoar = r;

            izvodjenja = kom.VratiSvaIzvodjenjaZaRepertoar(i);
            listaIzvodjenja = new BindingList<Izvodjenje>(izvodjenja);

            dgwIzvodjenja.Rows.Clear();
            dgwIzvodjenja.Refresh();
            dgwIzvodjenja.DataSource = listaIzvodjenja;
        }

        public bool SacuvajIzvodjenja(List<Izvodjenje> lista, DataGridView dgwIzvodjenja)
        {
            if (lista.Count == 0)
            {
                MessageBox.Show("Molimo unesite izvodjenja!");
                return false;
            }
            else
            {
                int brojac = 0;
                foreach (Izvodjenje i in lista)
                {
                    Object rez = kom.SacuvajIzvodjenje(i);

                    if (rez == null)
                    {
                        MessageBox.Show("Sistem nije uspeo da sacuva izvodjenja!");
                        return false;
                    }
                    else
                    {
                        brojac++;
                    }
                }
                if (brojac == lista.Count)
                {
                    MessageBox.Show("Sistem je uspesno sacuvao izvodjenja!");
                    dgwIzvodjenja.Rows.Clear();
                    dgwIzvodjenja.Refresh();
                    return true;
                }
                else
                    return false;
            }
        }

        public void VratiIzvodjenja(DataGridView dgwIzvodjenja)
        {
            dgwIzvodjenja.Rows.Clear();
            dgwIzvodjenja.Refresh();

            izvodjenja = kom.VratiSvaIzvodjenja();
            listaIzvodjenja = new BindingList<Izvodjenje>(izvodjenja);

            if (izvodjenja.Count == 0)
            {
                MessageBox.Show("Sistem nije uspeo da pronadje izvodjenja!");
            }
            else
            {
                MessageBox.Show("Sistem je uspesno pronasao izvodjenja!");
                dgwIzvodjenja.DataSource = listaIzvodjenja;
            }
        }

        public void InicijalizujCmbDan(Repertoar r, ComboBox cmbDan)
        {
            List<DateTime> datum = new List<DateTime>();
            for (DateTime dan = r.DatumVazenjaOd; dan <= r.DatumVazenjaDo; dan = dan.AddDays(1))
            {
                datum.Add(dan.Date);
            }

            cmbDan.DataSource = datum;
            repertoar = r;
        }
    }
}
