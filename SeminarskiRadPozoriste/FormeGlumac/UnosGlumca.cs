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
    public partial class UnosGlumca : Form
    {
        KontrolerGlumac kontroler = new KontrolerGlumac();

        public UnosGlumca() 
        {
            InitializeComponent();
        }

        private void UnosGlumca_Load(object sender, EventArgs e)
        {
            kontroler.PopuniCmbPol(cmbPol);
        }

        private void btnUnesiGlumca_Click(object sender, EventArgs e)
        {
            kontroler.UnesiGlumca(txtIme, txtPrezime, cmbPol, dtpDatumRodjenja, txtRadniStaz);
        }
    }
}
