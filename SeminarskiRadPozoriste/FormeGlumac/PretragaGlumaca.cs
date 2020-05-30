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

namespace SeminarskiRadPozoriste.FormeGlumac
{
    public partial class PretragaGlumaca : Form
    {
        KontrolerGlumac kontroler = new KontrolerGlumac();

        public PretragaGlumaca()
        {
            InitializeComponent();
        }

        private void PretragaGlumaca_Load(object sender, EventArgs e)
        {
            kontroler.VratiSveGlumce(dgwGlumci);
        }

        private void txtPojam_TextChanged(object sender, EventArgs e)
        {
            kontroler.VratiSveGlumcePoImenu(dgwGlumci, txtPojam);
        }
    }
}
