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

namespace SeminarskiRadPozoriste.FormaIzvodjenje
{
    public partial class PregledIzvodjenja : Form
    {
        KontrolerIzvodjenje kontroler = new KontrolerIzvodjenje();
        KontrolerPredstava kontrolerPredstava = new KontrolerPredstava();
        KontrolerRepertoar kontrolerRepertoar = new KontrolerRepertoar();

        List<Domen.Izvodjenje> lista;
        Domen.Predstava p;
        Domen.Repertoar r;

        public PregledIzvodjenja()
        {
            InitializeComponent();
        }

        private void PregledIzvodjenja_Load(object sender, EventArgs e)
        {
            kontroler.VratiIzvodjenja(dgwIzvodjenja);
            kontrolerPredstava.VratiSvePredstaveZaCmb(cmbPredstava);
            kontrolerRepertoar.VratiSveRepertoareZaCmb(cmbRepertoar);
        }

        private void cmbPredstava_SelectedIndexChanged(object sender, EventArgs e)
        {
            kontroler.VratiIzvodjenjaZaPredstavu(cmbPredstava, dgwIzvodjenja);
        }

        private void cmbRepertoar_SelectedIndexChanged(object sender, EventArgs e)
        {
            kontroler.VratiIzvodjenjaZaRepertoar(cmbRepertoar, dgwIzvodjenja);
        }
    }
}
