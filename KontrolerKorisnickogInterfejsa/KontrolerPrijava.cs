using Domen;
using KontrolerAplikacioneLogike;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KontrolerKorisnickogInterfejsa
{
    public class KontrolerPrijava
    {
        public static Komunikacija kom;
        public static bool PoveziSeNaServer()
        {
            kom = new Komunikacija();
            return kom.PoveziSeNaServer();
        }

        public bool RegistrujKorisnika(TextBox txtKorisnickoIme, TextBox txtEmail, TextBox txtLozinka, TextBox txtPotvrdiLozinku)
        {
            Korisnik k = new Korisnik();

            k.KorisnickoIme = txtKorisnickoIme.Text;
            if (txtKorisnickoIme.Text == "")
            {
                MessageBox.Show("Niste uneli korisničko ime!");
                txtKorisnickoIme.Focus();
                return false;
            }

            k.Email = txtEmail.Text;
            if (txtEmail.Text == "")
            {
                MessageBox.Show("Niste uneli lozinku!");
                txtEmail.Focus();
                return false;
            }

            if (txtLozinka.Text == "")
            {
                MessageBox.Show("Niste uneli lozinku!");
                txtLozinka.Focus();
                return false;
            }

            if (txtLozinka.Text.Equals(txtPotvrdiLozinku.Text))
            {
                k.Lozinka = txtLozinka.Text;
            }
            else
            {
                MessageBox.Show("Lozinke ne odgovaraju jedna drugoj!");
                txtPotvrdiLozinku.Focus();
                return false;
            }

            Object rez = kom.RegistrujKorisnika(k);
            if (rez == null)
            {
                MessageBox.Show("Sistem nije uspeo da registruje korisnika!");
                return false;
            }
            else
            {
                MessageBox.Show("Sistem je uspesno registrovao korisnika!");
                return true;
            } 
        }

        public bool PrijaviKorisnika(TextBox txtKorisnickoIme, TextBox txtLozinka)
        {
            Korisnik k = new Korisnik();

            k.KorisnickoIme = txtKorisnickoIme.Text;
            if (txtKorisnickoIme.Text == "")
            {
                MessageBox.Show("Niste uneli korisničko ime!");
                txtKorisnickoIme.Focus();
                return false;
            }

            k.Lozinka = txtLozinka.Text;
            if (txtLozinka.Text == "")
            {
                MessageBox.Show("Niste uneli lozinku!");
                txtLozinka.Focus();
                return false;
            }

            Object rez = kom.PrijaviKorisnika(k);

            if (rez == null)
            {
                MessageBox.Show("Neuspesna prijava na sistem!");
                return false;
            }
            else
            {
                MessageBox.Show("Uspešno ste se prijavili! \nPrijavljeni korisnik: " + k.KorisnickoIme + "");
                return true;
            }
        }

        public void Kraj()
        {
            try
            {
                kom.Kraj();
            }
            catch (Exception)
            {

            }
        }
    }
}
