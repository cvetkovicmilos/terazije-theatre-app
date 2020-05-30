using Domen;
using KontrolerKorisnickogInterfejsa;
using Sesija;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeminarskiRadPozoriste
{
    public partial class Registracija : Form
    {
        KontrolerPrijava kontroler = new KontrolerPrijava();

        public Registracija()
        {
            InitializeComponent();
            KontrolerPrijava.PoveziSeNaServer();
        }

        private void btnRegistracija_Click(object sender, EventArgs e)
        {
            if (kontroler.RegistrujKorisnika(txtKorisnickoIme, txtEmail, txtLozinka, txtPotvrdiLozinku))
                this.Hide();
            new Prijava().ShowDialog();
        }

        private void Registracija_FormClosed(object sender, FormClosedEventArgs e)
        {
            kontroler.Kraj();
        }
    }
}
