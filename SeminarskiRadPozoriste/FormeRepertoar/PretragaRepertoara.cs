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

namespace SeminarskiRadPozoriste.FormeRepertoar
{
    public partial class PretragaRepertoara : Form
    {
        KontrolerRepertoar kontroler = new KontrolerRepertoar();

        public PretragaRepertoara()
        {
            InitializeComponent();
        }

        private void PretragaRepertoara_Load(object sender, EventArgs e)
        {
            kontroler.VratiSveRepertoareZaDgw(dgwRepertoari);
        }

        private void txtPojam_TextChanged(object sender, EventArgs e)
        {
            kontroler.VratiRepertoarePoNazivu(dgwRepertoari, txtPojam);
        }

        private void btnIzaberi_Click(object sender, EventArgs e)
        {
            Repertoar r = kontroler.VratiRepertoar(dgwRepertoari);

            this.Hide();
            new PretragaRepertoaraDialog(r).ShowDialog();
            this.Show();
        }
    }
}
