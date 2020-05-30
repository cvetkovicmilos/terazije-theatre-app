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
    public partial class IzmenaRepertoara : Form
    {
        KontrolerRepertoar kontroler = new KontrolerRepertoar();

        public IzmenaRepertoara()
        {
            InitializeComponent();
        }

        private void IzmenaRepertoara_Load(object sender, EventArgs e)
        {
            kontroler.VratiSveRepertoareZaDgw(dgwRepertoari);
        }

        private void btnIzaberi_Click(object sender, EventArgs e)
        {
            Repertoar r = kontroler.VratiRepertoar(dgwRepertoari);

            this.Hide();
            new IzmenaRepertoaraDialog(r).ShowDialog();
            this.Show();
        }
    }
}
