using Domen;
using KontrolerAplikacioneLogike;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace KontrolerKorisnickogInterfejsa
{
    public class KontrolerPredstava
    {
        public static Komunikacija kom = KontrolerPrijava.kom;
        public static List<Predstava> predstave;
        public static BindingList<Predstava> listaPredstava;
        public static List<Zanr> zanrovi = new List<Zanr>();
        public static BindingList<Zanr> listaZanrova;
        public static List<Uloga> uloge = new List<Uloga>();
        public static BindingList<Uloga> listaUloga;
        public static Glumac glumac;
        public static Predstava predstava;
        public static List<Zanr> zanroviPom = new List<Zanr>();
        public static BindingList<Zanr> listaZanrovaPom;

        public void VratiSvePredstaveZaCmb(ComboBox cmbPredstava)
        {
            cmbPredstava.DataSource = kom.VratiSvePredstave();
        }

        public void PopuniIzmenaDialog(TextBox txtNazivPredstave, TextBox txtBrojGlumaca, DateTimePicker dtpDatumPostavljanja, TextBox txtReditelj, Predstava p)
        {
            txtNazivPredstave.Text = p.NazivPredstave;
            txtBrojGlumaca.Text = p.BrojGlumaca.ToString();
            txtBrojGlumaca.ReadOnly = true;
            dtpDatumPostavljanja.Value = p.DatumPostavljanja;
            txtReditelj.Text = p.Reditelj;
        }

        public void IzaberiUlogu(DataGridView dgwUloge, TextBox txtNaziv, TextBox txtTip, ComboBox cmbGlumac)
        {
            Uloga uloga = dgwUloge.CurrentRow.DataBoundItem as Uloga;
            txtNaziv.Text = uloga.Naziv;
            txtTip.Text = uloga.Tip;
            cmbGlumac.DataSource = kom.VratiSveGlumce();
        }

        public bool IzmeniUlogu(Predstava predstava, TextBox txtNaziv, TextBox txtTip, ComboBox cmbGlumac, DataGridView dgwUloge)
        {
            Uloga u = dgwUloge.CurrentRow.DataBoundItem as Uloga;
            u.Predstava = predstava;
            u.Naziv = txtNaziv.Text;
            if (u.Naziv == "")
            {
                MessageBox.Show("Molimo unesite naziv uloge!");
                return false;
            }
            u.Tip = txtTip.Text;
            if (u.Tip == "")
            {
                MessageBox.Show("Molimo unesite tip uloge!");
                return false;
            }
            u.Glumac = cmbGlumac.SelectedItem as Domen.Glumac;
            if (u.Glumac == null)
            {
                MessageBox.Show("Molimo odaberite glumca!");
                return false;
            }

            Object rez = kom.IzmeniUlogu(u);

            if (rez == null)
            {
                MessageBox.Show("Sistem nije uspeo da izmeni ulogu!");
                return false;
            }
            else
            {
                MessageBox.Show("Sistem je uspesno izmenio ulogu!");
                return true;
            }
        }

        public void VratiZanroveZaPredstavuDgw(Predstava predstava, DataGridView dgwZanrovi)
        {
            ZanrPredstava zp = new ZanrPredstava();
            zp.Predstava = predstava;
            zanrovi = kom.VratiZanroveZaPredstavu(zp);
            listaZanrova = new BindingList<Zanr>(zanrovi);
            dgwZanrovi.DataSource = listaZanrova;
        }

        public void VratiUlogeZaPredstavuDgw(Predstava predstava, DataGridView dgwUloge)
        {
            Uloga u = new Uloga();
            u.Predstava = predstava;
            uloge = kom.VratiUlogeZaPredstavu(u);
            listaUloga = new BindingList<Uloga>(uloge);
            dgwUloge.DataSource = listaUloga;
        }

        public void PopuniPretragaDialog(Predstava p, TextBox txtNaziv, TextBox txtDatum, TextBox txtReditelj, TextBox txtBrojGlumaca, DataGridView dgwUloge, DataGridView dgwZanrovi)
        {
            txtNaziv.ReadOnly = true;
            txtDatum.ReadOnly = true;
            txtBrojGlumaca.ReadOnly = true;
            txtReditelj.ReadOnly = true;
            dgwUloge.ReadOnly = true;
            dgwZanrovi.ReadOnly = true;

            txtNaziv.Text = p.NazivPredstave;
            txtDatum.Text = p.DatumPostavljanja.ToString();
            txtBrojGlumaca.Text = p.BrojGlumaca.ToString();
            txtReditelj.Text = p.Reditelj;

            ZanrPredstava zp = new ZanrPredstava();
            zp.Predstava = p;
            zanrovi = kom.VratiZanroveZaPredstavu(zp);
            listaZanrova = new BindingList<Zanr>(zanrovi);
            dgwZanrovi.DataSource = listaZanrova;
            Uloga u = new Uloga();
            u.Predstava = p;
            uloge = kom.VratiUlogeZaPredstavu(u);
            listaUloga = new BindingList<Uloga>(uloge);
            dgwUloge.DataSource = listaUloga;
        }

        public bool ObrisiUlogu(DataGridView dgwUloge, Predstava predstava)
        {
            Uloga u = dgwUloge.CurrentRow.DataBoundItem as Uloga;
            uloge.Remove(u);
            listaUloga = new BindingList<Uloga>(uloge);

            predstava.BrojGlumaca = uloge.Count;

            Object rez = kom.ObrisiUlogu(u);
            Object pom = kom.IzmeniPredstavu(predstava);

            if (rez == null || pom == null)
            {
                MessageBox.Show("Sistem nije uspeo da obrise ulogu!");
                return false;
            }
            else
            {
                MessageBox.Show("Sistem je uspesno obrisao ulogu!");
                dgwUloge.DataSource = listaUloga;
                return true;
            }
        }

        public bool IzmeniPredstavu(TextBox txtNazivPredstave, DateTimePicker dtpDatumPostavljanja, TextBox txtReditelj, DataGridView dgwZanrovi, Predstava predstava)
        {
            bool potvrda = false;

            predstava.NazivPredstave = txtNazivPredstave.Text;
            if (predstava.NazivPredstave == "")
            {
                MessageBox.Show("Molimo unesite naziv predstave!");
                return false;
            }
            predstava.DatumPostavljanja = dtpDatumPostavljanja.Value;
            if (predstava.DatumPostavljanja == null || predstava.DatumPostavljanja >= DateTime.Today)
            {
                MessageBox.Show("Molimo unesite datum postavljanja predstave!");
                return false;
            }
            predstava.Reditelj = txtReditelj.Text;
            if (predstava.Reditelj == "")
            {
                MessageBox.Show("Molimo unesite reditelja predstave!");
                return false;
            }

            Object rez = kom.IzmeniPredstavu(predstava);

            if (rez == null)
            {
                potvrda = false;
            }
            else
            {
                potvrda = true;
            }

            listaZanrovaPom = dgwZanrovi.DataSource as BindingList<Zanr>;
            zanroviPom = listaZanrova.ToList<Zanr>();

            if (zanroviPom.Count == 0)
            {
                MessageBox.Show("Molimo unesite zanr predstave!");
                return false;
            }
            else
            {
                foreach (Zanr z in zanrovi)
                {
                    ZanrPredstava zp = new ZanrPredstava();
                    zp.Zanr = z;
                    zp.Predstava = predstava;
                    Object pom = kom.ObrisiZanrZaPredstavu(zp);

                    if (pom == null)
                    {
                        MessageBox.Show("Sistem nije uspeo da sacuva zanrove!");
                        return false;
                    }
                }

                foreach (Zanr za in zanroviPom)
                {
                    ZanrPredstava zp = new ZanrPredstava();
                    zp.Zanr = za;
                    zp.Predstava = predstava;
                    Object pom1 = kom.SacuvajZanrPredstavu(zp);

                    if (pom1 == null)
                    {
                        MessageBox.Show("Sistem nije uspeo da sacuva zanrove!");
                        return false;
                    }
                    else
                    {
                        potvrda = true;
                    }
                }
            }
            if (potvrda == false)
            {
                MessageBox.Show("Sistem nije uspeo da izmeni predstavu!");
            }
            else
            {
                MessageBox.Show("Sistem je uspesno izmenio predstavu!");
            }
            return potvrda;
        }

        public void PopuniDialog(Label lblGlumac, Label lblPredstava, Glumac g, Predstava p)
        {
            lblGlumac.Text = "Glumac: " + g.Ime + " " + g.Prezime + "";
            lblPredstava.Text = "Predstava: " + p.NazivPredstave + "";
            glumac = g;
            predstava = p;
        }

        public Uloga DodajUlogu(TextBox txtNaziv, TextBox txtTip)
        {
            Uloga u = new Uloga();
            u.Naziv = txtNaziv.Text;
            u.Tip = txtTip.Text;
            u.Glumac = glumac;
            u.Predstava = predstava;
            return u;
        }

        public void VratiSvePredstaveZaDgw(DataGridView dgwPredstave)
        {
            dgwPredstave.Rows.Clear();
            dgwPredstave.Refresh();

            predstave = kom.VratiSvePredstave();
            listaPredstava = new BindingList<Predstava>(predstave);

            if (predstave.Count == 0)
            {
                MessageBox.Show("Sistem nije pronasao predstave!");
            }
            else
            {
                MessageBox.Show("Sistem je uspesno pronasao predstave!");
                dgwPredstave.DataSource = listaPredstava;
            }
        }

        public void ObrisiZanrIzmenaPredstave(ComboBox cmbZanr, DataGridView dgwZanrovi)
        {
            Zanr z = dgwZanrovi.CurrentRow.DataBoundItem as Zanr;
            listaZanrova = dgwZanrovi.DataSource as BindingList<Zanr>;
            zanrovi = listaZanrova.ToList<Zanr>();
            zanrovi.Remove(z);
            listaZanrova = new BindingList<Zanr>(zanrovi);
            dgwZanrovi.DataSource = listaZanrova;
        }

        public void DodajZanrIzmenaPredstave(ComboBox cmbZanr, DataGridView dgwZanrovi)
        {
            Zanr z = cmbZanr.SelectedItem as Zanr;
            listaZanrova = dgwZanrovi.DataSource as BindingList<Zanr>;
            zanrovi = listaZanrova.ToList<Zanr>();
            if (zanrovi.Contains(z))
            {
                MessageBox.Show("Zanr vec postoji!");
            }
            else
            {
                zanrovi.Add(z);
            }
            listaZanrova = new BindingList<Zanr>(zanrovi);
            dgwZanrovi.DataSource = listaZanrova;
        }

        public void PopuniDgwUloge(Uloga uloga, DataGridView dgwUloge)
        {
            if (uloga != null)
            {
                uloge.Add(uloga);
                listaUloga = new BindingList<Uloga>(uloge);

                dgwUloge.DataSource = listaUloga;
            }
        }

        public Predstava VratiPredstavuZaUlogu()
        {
            Predstava p = new Predstava();
            p = kom.VratiPoslednjeDodatuPredstavu(p);
            return p;
        }

        public bool SacuvajUlogeZaPredstavu(DataGridView dgwUloge, Predstava p)
        {
            listaUloga = dgwUloge.DataSource as BindingList<Uloga>;
            uloge = listaUloga.ToList<Uloga>();
            bool potvrda = false;

            foreach (Uloga u in uloge)
            {
                Object rez = kom.SacuvajUlogu(u);

                if (rez == null)
                {
                    MessageBox.Show("Sistem nije uspeo da sacuva uloge!");
                    potvrda = false;
                }
                else
                {
                    potvrda = true;
                }
            }

            p.BrojGlumaca = uloge.Count;
            Object pom = kom.IzmeniPredstavu(p);

            if (pom == null)
                potvrda = false;
            else 
                potvrda = true;

            if (potvrda == true)
            {
                MessageBox.Show("Sistem je uspesno sacuvao uloge!");
                uloge.Clear();
                dgwUloge.Rows.Clear();
                dgwUloge.Refresh();
                return potvrda;
            }
            return potvrda;
        }

        public Glumac VratiGlumcaZaUlogu(ComboBox cmbGlumac)
        {
            Glumac g = cmbGlumac.SelectedItem as Glumac;
            return g;
        }

        public void PostaviNazivPredstave(TextBox txtTrenutnaPredstava)
        {
            Predstava p = new Predstava();
            p = kom.VratiPoslednjeDodatuPredstavu(p);
            txtTrenutnaPredstava.Text = p.NazivPredstave;
        }

        public void PromeniStanje(GroupBox gbPredstava, GroupBox gbUloga)
        {
            if (gbPredstava.Enabled == true)
            {
                gbPredstava.Enabled = false;
            }
            else
            {
                gbPredstava.Enabled = true;
            }
            if (gbUloga.Enabled == false)
            {
                gbUloga.Enabled = true; 
            }
            else
            {
                gbUloga.Enabled = false;
            }
        }

        public bool SacuvajPredstavu(TextBox txtNazivPredstave, DateTimePicker dtpDatumPostavljanja, TextBox txtReditelj, DataGridView dgwZanr)
        {
            Predstava p = new Predstava();
            bool potvrda;

            p.NazivPredstave = txtNazivPredstave.Text;
            if (p.NazivPredstave == "")
            {
                MessageBox.Show("Molimo unesite naziv predstave!");
                txtNazivPredstave.Focus();
                return false;
            }

            p.DatumPostavljanja = DateTime.Parse(dtpDatumPostavljanja.Value.ToString("dd.MM.yyyy.", CultureInfo.InvariantCulture));
            if (p.DatumPostavljanja.Date >= DateTime.Today)
            {
                MessageBox.Show("Molimo unesite datum postavljanja!");
                dtpDatumPostavljanja.Focus();
                return false;
            }
            p.Reditelj = txtReditelj.Text;
            if (p.Reditelj == "")
            {
                MessageBox.Show("Molimo unesite naziv predstave!");
                txtNazivPredstave.Focus();
                return false;
            }

            Object rez = kom.SacuvajPredstavu(p);

            if (rez == null)
            {
                potvrda = false;
            }
            else
            {
                potvrda = true;
            }

            Predstava pr = new Predstava(); 
            pr = kom.VratiPoslednjeDodatuPredstavu(pr);

            foreach (Zanr z in zanrovi)
            {
                ZanrPredstava zp = new ZanrPredstava();
                zp.Zanr = z;
                zp.Predstava = pr;
                Object pom = kom.SacuvajZanrPredstavu(zp);

                if (pom == null)
                {
                    potvrda = false;
                }
                else
                {
                    potvrda = true;
                }
            }

            if (potvrda)
            {
                MessageBox.Show("Sistem je uspesno sacuvao predstavu!");
                txtNazivPredstave.Clear();
                txtReditelj.Clear();
                dtpDatumPostavljanja.Value = DateTime.Today;
                zanrovi.Clear();
                dgwZanr.Rows.Clear();
                dgwZanr.Refresh();
            }
            else
            {
                MessageBox.Show("Sistem nije uspeo da sacuva predstavu!");
            }

            return potvrda;
        }

        public void PopuniUnosPredstave(ComboBox cmbGlumac, ComboBox cmbZanr)
        {
            cmbGlumac.DataSource = kom.VratiSveGlumce();
            cmbZanr.DataSource = kom.VratiSveZanrove();
        }

        public void VratiPredstavePoNazivu(DataGridView dgwPredstave, TextBox txtPojam)
        {
            Predstava p = new Predstava();
            p.NazivPredstave = txtPojam.Text;
            //dgwPredstave.Rows.Clear();
            dgwPredstave.Refresh();

            predstave = kom.VratiPredstavePoNazivu(p);
            listaPredstava = new BindingList<Predstava>(predstave);

            dgwPredstave.DataSource = listaPredstava;
        }

        public bool ObrisiPredstavu(DataGridView dgwPredstave)
        {
            Predstava p = dgwPredstave.CurrentRow.DataBoundItem as Predstava;

            Object rez = kom.ObrisiPredstavu(p);

            if (rez == null)
            {
                MessageBox.Show("Sistem ne moze da obrise predstavu!");
                return false;
            }
            else
            {
                MessageBox.Show("Sistem je uspesno obrisao predstavu!");
                predstave.Remove(p);
                listaPredstava = new BindingList<Predstava>(predstave);
                dgwPredstave.DataSource = listaPredstava;
                return true;
            }
        }

        public void DodajZanrZaPredstavu(ComboBox cmbZanr, DataGridView dgwZanr)
        {
            Zanr z = cmbZanr.SelectedItem as Zanr;

            zanrovi.Add(z);
            listaZanrova = new BindingList<Zanr>(zanrovi);

            dgwZanr.DataSource = listaZanrova;
            
        }

        public void VratiZanroveZaCmb(ComboBox cmbZanr)
        {
            cmbZanr.DataSource = kom.VratiSveZanrove();
        }

        //public static bool PoveziSeNaServer()
        //{
        //    kom = new Komunikacija();
        //    return kom.PoveziSeNaServer();
        //}
    }
}
