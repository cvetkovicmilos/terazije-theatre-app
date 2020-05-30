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
    public partial class BrisanjeGlumca : Form
    {
        KontrolerGlumac kontroler = new KontrolerGlumac();

        public BrisanjeGlumca()
        {
            InitializeComponent();
        }

        private void BrisanjeGlumca_Load(object sender, EventArgs e)
        {
            kontroler.VratiSveGlumce(dgwGlumci);
        }

        private void btnIzaberi_Click(object sender, EventArgs e)
        {
            kontroler.ObrisiGlumca(dgwGlumci);
        }
    }
}
