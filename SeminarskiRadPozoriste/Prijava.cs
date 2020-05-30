using Sesija;
using Domen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KontrolerKorisnickogInterfejsa;

namespace SeminarskiRadPozoriste
{
    public partial class Prijava : Form
    {
        KontrolerPrijava kontroler = new KontrolerPrijava();

        public Prijava()
        {
            InitializeComponent();
        }

        private void btnPrijava_Click(object sender, EventArgs e)
        {
            if (KontrolerPrijava.PoveziSeNaServer())
            {
                if (kontroler.PrijaviKorisnika(txtKorisnickoIme, txtLozinka))
                {
                    this.Hide();
                    new PocetnaForma().ShowDialog();
                    this.Show();
                }
            }
        }

        private void btnRegistracija_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Registracija().ShowDialog();
            this.Close();
        }

        private void Prijava_FormClosed(object sender, FormClosedEventArgs e)
        {
            kontroler.Kraj();
        }
    }
}
