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

namespace SeminarskiRadPozoriste.FormePredstava
{
    public partial class BrisanjePredstave : Form
    {
        KontrolerPredstava kontroler = new KontrolerPredstava();

        public BrisanjePredstave()
        {
            InitializeComponent();
        }

        private void BrisanjePredstave_Load(object sender, EventArgs e)
        {
            kontroler.VratiSvePredstaveZaDgw(dgwPredstave);
        }

        private void btnIzaberi_Click(object sender, EventArgs e)
        {
            kontroler.ObrisiPredstavu(dgwPredstave);
        }
    }
}
