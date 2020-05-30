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
    public class KontrolerRepertoar
    {
        public static Komunikacija kom = KontrolerPrijava.kom;
        public static Repertoar repertoar;

        public static List<Repertoar> repertoari;
        public static BindingList<Repertoar> listaRepertoara;

        public void VratiSveRepertoareZaCmb(ComboBox cmbRepertoar)
        {
            cmbRepertoar.DataSource = kom.VratiSveRepertoare();
        }

        public bool SacuvajRepertoar(TextBox txtNaziv, DateTimePicker dtpOd, DateTimePicker dtpDo)
        {
            Repertoar r = new Repertoar();
            r.NazivRepertoara = txtNaziv.Text;
            if (r.NazivRepertoara == "")
            {
                MessageBox.Show("Unesite naziv repertoara!");
                return false;
            }
            r.DatumVazenjaOd = dtpOd.Value;
            if (r.DatumVazenjaOd == null)
            {
                MessageBox.Show("Unesite validan datum!");
                return false;
            }
            r.DatumVazenjaDo = dtpDo.Value;
            if (r.DatumVazenjaDo == null)
            {
                MessageBox.Show("Unesite validan datum!");
                return false;
            }
            if (r.DatumVazenjaDo < r.DatumVazenjaOd)
            {
                MessageBox.Show("Datum od kad vazi repertoar ne moze biti manji od datuma do kad vazi!");
                return false;
            }

            Object rez = kom.SacuvajRepertoar(r);

            if (rez == null)
            {
                MessageBox.Show("Sistem nije uspeo da sacuva repertoar!");
                return false;
            }
            else
            {
                MessageBox.Show("Sistem je uspesno sacuvao repertoar!");
                repertoar = r;
                return true;
            }

        }

        public Repertoar VratiRepertoarZaDalje()
        {
            return kom.VratiRepertoarPoNazivu(repertoar.NazivRepertoara);
        }

        public void PopuniFormuIzmenaRepertoara(TextBox txtNazivRepertoara, DateTimePicker dtpOd, DateTimePicker dtpDo, Repertoar repertoar, TextBox txtNazivPredstave, DateTimePicker dtpDatum)
        {
            txtNazivRepertoara.Text = repertoar.NazivRepertoara;
            dtpOd.Value = repertoar.DatumVazenjaOd;
            dtpDo.Value = repertoar.DatumVazenjaDo;
            txtNazivPredstave.Enabled = false;
            dtpDatum.MinDate = dtpOd.Value;
            dtpDatum.MaxDate = dtpDo.Value;
        }

        public bool IzmeniRepertoar(TextBox txtNazivRepertoara, DateTimePicker dtpOd, DateTimePicker dtpDo, Repertoar repertoar)
        {
            repertoar.NazivRepertoara = txtNazivRepertoara.Text;
            if (repertoar.NazivRepertoara == "")
            {
                MessageBox.Show("Unesite naziv repertoara!");
                return false;
            }
            repertoar.DatumVazenjaOd = dtpOd.Value;
            if (repertoar.DatumVazenjaOd == null)
            {
                MessageBox.Show("Unesite validan datum!");
                return false;
            }
            repertoar.DatumVazenjaDo = dtpDo.Value;
            if (repertoar.DatumVazenjaDo == null)
            {
                MessageBox.Show("Unesite validan datum!");
                return false;
            }
            if (repertoar.DatumVazenjaDo < repertoar.DatumVazenjaOd)
            {
                MessageBox.Show("Datum od kad vazi repertoar ne moze biti manji od datuma do kad vazi!");
                return false;
            }

            Object rez = kom.IzmeniRepertoar(repertoar);

            if (rez == null)
            {
                MessageBox.Show("Sistem nije uspeo da izmeni repertoar!");
                return false;
            }
            else
            {
                MessageBox.Show("Sistem je uspesno izmenio repertoar!");
                return true;
            }
        }

        public void PopuniFormu(TextBox txtNaziv, TextBox txtDatumOd, TextBox txtDatumDo, Repertoar r, DataGridView dgwIzvodjenja)
        {
            repertoar = r;

            txtNaziv.ReadOnly = true;
            txtDatumOd.ReadOnly = true;
            txtDatumDo.ReadOnly = true;
            dgwIzvodjenja.ReadOnly = true;

            txtNaziv.Text = repertoar.NazivRepertoara;
            txtDatumOd.Text = repertoar.DatumVazenjaOd.ToString();
            txtDatumDo.Text = repertoar.DatumVazenjaDo.ToString();

            
        }

        public bool ObrisiRepertoar(DataGridView dgwRepertoar)
        {
            Repertoar r = dgwRepertoar.CurrentRow.DataBoundItem as Repertoar;

            Object rez = kom.ObrisiRepertoar(r);

            if (rez == null)
            {
                MessageBox.Show("Sistem ne moze da obrise repertoar!");
                return false;
            }
            else
            {
                MessageBox.Show("Sistem je uspesno obrisao repertoar!");
                repertoari.Remove(r);
                listaRepertoara = new BindingList<Repertoar>(repertoari);
                dgwRepertoar.DataSource = listaRepertoara;
                return true;
            }
        }

        public void VratiRepertoarePoNazivu(DataGridView dgwRepertoari, TextBox txtPojam)
        {
            string pojam = txtPojam.Text;
            dgwRepertoari.Rows.Clear();
            dgwRepertoari.Refresh();

            repertoari = kom.VratiSveRepertoarePoNazivu(pojam);
            listaRepertoara = new BindingList<Repertoar>(repertoari);

            dgwRepertoari.DataSource = listaRepertoara;
        }

        public void VratiSveRepertoareZaDgw(DataGridView dgwRepertoari)
        {
            dgwRepertoari.Rows.Clear();
            dgwRepertoari.Refresh();

            repertoari = kom.VratiSveRepertoare();
            listaRepertoara = new BindingList<Repertoar>(repertoari);

            if (repertoari.Count == 0)
            {
                MessageBox.Show("Sistem nije pronasao repertoare!");
            }
            else
            {
                MessageBox.Show("Sistem je uspesno pronasao repertoare!");
                dgwRepertoari.DataSource = listaRepertoara;
            }

        }

        public Repertoar VratiRepertoar(DataGridView dgwRepertoari)
        {
            Repertoar r = dgwRepertoari.CurrentRow.DataBoundItem as Repertoar;
            return r;
        }

        public void OnemoguciDugmeZaRepertoar(Button btnDodajRepertoar, Button btnDodajIzvodjenja)
        {
            btnDodajRepertoar.Enabled = false;
            btnDodajIzvodjenja.Enabled = true;
        }

        public void OnemoguciDugmeZaIzvodjenje(Button btnDodajRepertoar, Button btnDodajIzvodjenja)
        {
            btnDodajRepertoar.Enabled = true;
            btnDodajIzvodjenja.Enabled = false;
        }

        public void VratiDatumeRepertoara(ComboBox cmbRepertoar, ComboBox cmbDan)
        {
            Repertoar r = cmbRepertoar.SelectedItem as Repertoar;
            List<DateTime> datum = new List<DateTime>();
            for (DateTime dani = r.DatumVazenjaOd; dani <= r.DatumVazenjaDo; dani = dani.AddDays(1))
            {
                datum.Add(dani);
            }
            cmbDan.DataSource = datum;
        }

        //public static bool PoveziSeNaServer()
        //{
        //    kom = new Komunikacija();
        //    return kom.PoveziSeNaServer();
        //}
    }
}
