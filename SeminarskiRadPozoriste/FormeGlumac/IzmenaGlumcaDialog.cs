using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domen;
using KontrolerKorisnickogInterfejsa;
using Sesija;

namespace SeminarskiRadPozoriste.FormeGlumac
{
    public partial class IzmenaGlumcaDialog : Form
    {
        int sifra;
        KontrolerGlumac kontroler = new KontrolerGlumac();

        public IzmenaGlumcaDialog()
        {
            InitializeComponent();
        }

        private void IzmenaGlumcaDialog_Load(object sender, EventArgs e)
        {

        }

        public IzmenaGlumcaDialog(Glumac g)
        {
            InitializeComponent();
            sifra = kontroler.IzmenaGlumcaPopuniFormu(sifra, txtIme, txtPrezime, dtpDatumRodjenja, txtRadniStaz, g);
        }

        private void btnIzmeniGlumca_Click(object sender, EventArgs e)
        {
            kontroler.IzmeniGlumcaDialog(sifra, txtIme, txtPrezime, dtpDatumRodjenja, txtRadniStaz);
        }
    }
}
