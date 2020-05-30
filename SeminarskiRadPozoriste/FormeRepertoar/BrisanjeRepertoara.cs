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
    public partial class BrisanjeRepertoara : Form
    {
        KontrolerRepertoar kontroler = new KontrolerRepertoar();

        List<Domen.Repertoar> lista;
        public BrisanjeRepertoara()
        {
            InitializeComponent();
        }

        private void BrisanjeRepertoara_Load(object sender, EventArgs e)
        {
            kontroler.VratiSveRepertoareZaDgw(dgwRepertoar);
        }

        private void btnIzaberi_Click(object sender, EventArgs e)
        {
            kontroler.ObrisiRepertoar(dgwRepertoar);
        }
    }
}
