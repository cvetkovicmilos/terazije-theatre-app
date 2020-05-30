using Domen;
using KontrolerAplikacioneLogike;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KontrolerKorisnickogInterfejsa
{
    public class KontrolerGlumac
    {
        public static Komunikacija kom = KontrolerPrijava.kom;

        public static List<Glumac> glumci;
        public static BindingList<Glumac> listaGlumaca;
        public Pol pol;

        //public static bool PoveziSeNaServer()
        //{
        //    kom = new Komunikacija();
        //    return kom.PoveziSeNaServer();
        //}

        public void PopuniCmbPol(ComboBox cmbPol)
        {
            cmbPol.Items.AddRange(Enum.GetNames(typeof(Pol)));
            if (cmbPol == null)
            {
                MessageBox.Show("Sistem nije uspeo da ucita polove!");
            }
        }

        public bool UnesiGlumca(TextBox txtIme, TextBox txtPrezime, ComboBox cmbPol, DateTimePicker dtpDatumRodjenja, TextBox txtRadniStaz)
        {
            Glumac g = new Glumac();

            g.Ime = txtIme.Text;
            if (txtIme.Text == "")
            {
                MessageBox.Show("Molimo unesite ime!");
                txtIme.Focus();
                return false;
            }
            g.Prezime = txtPrezime.Text;
            if (txtPrezime.Text == "")
            {
                MessageBox.Show("Molimo unesite prezime!");
                txtPrezime.Focus();
                return false;
            }
            try
            {
                g.Pol = (Pol)Enum.Parse(typeof(Pol), cmbPol.SelectedItem.ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("Molimo unesite pol!");
                cmbPol.Focus();
                return false;
            }

            g.DatumRodjenja = DateTime.Parse(dtpDatumRodjenja.Value.ToString("dd.MM.yyyy.", CultureInfo.InvariantCulture));
            if (dtpDatumRodjenja.Value.Date >= DateTime.Today)
            {
                MessageBox.Show("Molimo unesite datum rodjenja!");
                dtpDatumRodjenja.Focus();
                return false;
            }
            try
            {
                g.RadniStaz = Convert.ToDouble(txtRadniStaz.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Molimo unesite radni staž!");
                txtRadniStaz.Focus();
                return false;
            }

            if (g.RadniStaz < 0)
            {
                MessageBox.Show("Molimo unesite radni staž!");
                txtRadniStaz.Focus();
                return false;
            }

            
            Object rez = kom.SacuvajGlumca(g);

            if (rez == null)
            {
                MessageBox.Show("Sistem nije uspeo da sacuva glumca!");
                return false;
            }
            else
            {
                MessageBox.Show("Sistem je uspesno sacuvao glumca!");
                txtIme.Clear();
                txtPrezime.Clear();
                txtRadniStaz.Clear();
                cmbPol.ResetText();
                dtpDatumRodjenja.Value = DateTime.Today;
                return true;
            }
        }

        public bool IzmeniGlumcaDialog(int sifra, TextBox txtIme, TextBox txtPrezime, DateTimePicker dtpDatumRodjenja, TextBox txtRadniStaz)
        {
            Glumac g = new Glumac();

            g.SifraGlumca = sifra;
            g.Ime = txtIme.Text;
            if (txtIme.Text == "")
            {
                MessageBox.Show("Molimo unesite ime!");
                txtIme.Focus();
                return false;
            }
            g.Prezime = txtPrezime.Text;
            if (txtPrezime.Text == "")
            {
                MessageBox.Show("Molimo unesite prezime!");
                txtPrezime.Focus();
                return false;
            }
            g.Pol = pol;
            g.DatumRodjenja = DateTime.Parse(dtpDatumRodjenja.Value.ToString("dd.MM.yyyy.", CultureInfo.InvariantCulture));
            if (dtpDatumRodjenja.Value.Date == DateTime.Today)
            {
                MessageBox.Show("Molimo unesite datum rodjenja!");
                dtpDatumRodjenja.Focus();
                return false;
            }
            try
            {
                g.RadniStaz = Convert.ToDouble(txtRadniStaz.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Molimo unesite radni staž!");
                txtRadniStaz.Focus();
                return false;
            }

            if (g.RadniStaz < 0)
            {
                MessageBox.Show("Molimo unesite radni staž!");
                txtRadniStaz.Focus();
                return false;
            }

            try
            {
                Object o = kom.IzmeniGlumca(g);

                if (o == null)
                {
                    MessageBox.Show("Sistem nije uspeo da izmeni glumca!");
                    return false;
                }
                else
                {
                    MessageBox.Show("Sistem je uspešno izmenio glumca!");
                    return true;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public int IzmenaGlumcaPopuniFormu(int sifra, TextBox txtIme, TextBox txtPrezime, DateTimePicker dtpDatumRodjenja, TextBox txtRadniStaz, Glumac g)
        {
            sifra = g.SifraGlumca;
            txtIme.Text = g.Ime;
            txtPrezime.Text = g.Prezime;
            dtpDatumRodjenja.Value = g.DatumRodjenja;
            txtRadniStaz.Text = Convert.ToString(g.RadniStaz);
            pol = g.Pol;

            return sifra;
        }

        public Glumac IzmeniGlumca(DataGridView dgwGlumci)
        {
            Glumac g = dgwGlumci.CurrentRow.DataBoundItem as Glumac;
            
            if (g == null)
            {
                MessageBox.Show("Sistem nije uspeo da odabere glumca!");
                return null;
            }

            return g;
        }

        public void VratiSveGlumcePoImenu(DataGridView dgwGlumci, TextBox txtPojam)
        {
            dgwGlumci.Rows.Clear();
            dgwGlumci.Refresh();
            string pojam = txtPojam.Text;

            glumci = kom.VratiGlumcePoImenu(pojam);
            listaGlumaca = new BindingList<Glumac>(glumci);

            if (glumci.Count == 0)
            {
                MessageBox.Show("Sistem nije uspeo da pronadje glumce!");
            }
            else
            {
                dgwGlumci.DataSource = listaGlumaca;
                MessageBox.Show("Sistem je uspesno pronasao glumce!");
            }
        }

        public bool ObrisiGlumca(DataGridView dgwGlumci)
        {
            Glumac g = dgwGlumci.CurrentRow.DataBoundItem as Glumac;

            try
            {
                Object o = kom.ObrisiGlumca(g);

                if (o == null)
                {
                    MessageBox.Show("Sistem ne moze da obrise glumca!");
                    return false;
                }
                else
                {
                    MessageBox.Show("Sistem je uspesno obrisao glumca!");
                    glumci.Remove(g);
                    listaGlumaca = new BindingList<Glumac>(glumci);
                    dgwGlumci.DataSource = listaGlumaca;
                    return true;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void VratiSveGlumce(DataGridView dgwGlumci)
        {
            dgwGlumci.Rows.Clear();
            dgwGlumci.Refresh();

            glumci = kom.VratiSveGlumce();
            listaGlumaca = new BindingList<Glumac>(glumci);

            if (glumci.Count == 0)
            {
                MessageBox.Show("Sistem nije uspeo da pronadje glumce!");
            }
            else
            {
                dgwGlumci.DataSource = listaGlumaca;
                MessageBox.Show("Sistem je uspesno pronasao glumce!");
            }
        }
    }
}
