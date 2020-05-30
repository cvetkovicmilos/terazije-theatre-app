using Domen;
using KontrolerKorisnickogInterfejsa;
using SeminarskiRadPozoriste.FormaIzvodjenje;
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
    public partial class IzmenaRepertoaraDialog : Form
    {
        KontrolerRepertoar kontroler = new KontrolerRepertoar();
        KontrolerIzvodjenje kontrolerIzvodjenje = new KontrolerIzvodjenje();
        Repertoar repertoar;
        Izvodjenje izvodjenje;

        public IzmenaRepertoaraDialog(Domen.Repertoar r)
        {
            InitializeComponent();
            repertoar = r;
        }

        private void btnIzmenaRepertoara_Click(object sender, EventArgs e)
        {
            kontroler.IzmeniRepertoar(txtNazivRepertoara, dtpOd, dtpDo, repertoar);
        }

        private void IzmenaRepertoaraDialog_Load(object sender, EventArgs e)
        {
            kontroler.PopuniFormuIzmenaRepertoara(txtNazivRepertoara, dtpOd, dtpDo, repertoar, txtNazivPredstave, dtpDatum);
            kontrolerIzvodjenje.VratiIzvodjenjaZaRepertoar(dgwIzvodjenja, repertoar);
        }

        private void btnIzaberi_Click(object sender, EventArgs e)
        {
            izvodjenje = kontrolerIzvodjenje.IzaberiIzvodjenje(txtNazivPredstave, dtpDatum, dgwIzvodjenja, repertoar);
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            if (kontrolerIzvodjenje.IzmeniIzvodjenje(izvodjenje, dtpDatum))
                kontrolerIzvodjenje.VratiIzvodjenjaZaRepertoar(dgwIzvodjenja, repertoar);
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            this.Hide();
            new DodajIzvodjenje(repertoar).ShowDialog();
            this.Show();
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if (kontrolerIzvodjenje.ObrisiIzvodjenje(dgwIzvodjenja))
                kontrolerIzvodjenje.VratiIzvodjenjaZaRepertoar(dgwIzvodjenja, repertoar);
        }
    }
}
