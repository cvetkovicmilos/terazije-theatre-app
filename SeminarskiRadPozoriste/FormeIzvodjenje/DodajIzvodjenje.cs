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

namespace SeminarskiRadPozoriste.FormaIzvodjenje
{
    public partial class DodajIzvodjenje : Form
    {
        List<Izvodjenje> lista = new List<Izvodjenje>();
        Repertoar repertoar;

        KontrolerIzvodjenje kontrolerIzvodjenje = new KontrolerIzvodjenje();
        KontrolerPredstava kontrolerPredstava = new KontrolerPredstava();
        KontrolerRepertoar kontrolerRepertoar = new KontrolerRepertoar();

        public DodajIzvodjenje()
        {
            InitializeComponent();
        }

        public DodajIzvodjenje(Repertoar r)
        {
            InitializeComponent();

            kontrolerIzvodjenje.InicijalizujCmbDan(r, cmbDan);
            kontrolerPredstava.VratiSvePredstaveZaCmb(cmbPredstava);
            repertoar = r;
        }

        private void btnDodajIzvodjenje_Click(object sender, EventArgs e)
        {
            kontrolerIzvodjenje.DodajIzvodjenje(cmbPredstava, cmbDan, lista, repertoar, dgwIzvodjenja); 
        }

        private void DodajIzvodjenje_Load(object sender, EventArgs e)
        {
            kontrolerIzvodjenje.VratiIzvodjenjaZaRepertoar(dgwIzvodjenja, repertoar);
        }

        private void btnSacuvajIzvodjenja_Click(object sender, EventArgs e)
        {
            kontrolerIzvodjenje.SacuvajIzvodjenja(lista, dgwIzvodjenja);
        }
    }
}
