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
    public partial class IzmenaPredstaveDialog : Form
    {
        KontrolerPredstava kontroler = new KontrolerPredstava();
        Predstava predstava;

        public IzmenaPredstaveDialog()
        {
            InitializeComponent();
        }

        public IzmenaPredstaveDialog(Domen.Predstava p)
        {
            InitializeComponent();
            predstava = p;
            kontroler.PopuniIzmenaDialog(txtNazivPredstave, txtBrojGlumaca, dtpDatumPostavljanja, txtReditelj, p);
            kontroler.VratiZanroveZaCmb(cmbZanr);
        }

        private void IzmenaPredstaveDialog_Load(object sender, EventArgs e)
        {
            kontroler.VratiUlogeZaPredstavuDgw(predstava, dgwUloge);
            kontroler.VratiZanroveZaPredstavuDgw(predstava, dgwZanrovi);
        }

        private void btnIzaberi_Click(object sender, EventArgs e)
        {
            kontroler.IzaberiUlogu(dgwUloge, txtNaziv, txtTip, cmbGlumac);
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            kontroler.IzmeniUlogu(predstava, txtNaziv, txtTip, cmbGlumac, dgwUloge);
        }

        private void btnIzmenaPredstave_Click(object sender, EventArgs e)
        {
            kontroler.IzmeniPredstavu(txtNazivPredstave, dtpDatumPostavljanja, txtReditelj, dgwZanrovi, predstava);
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            kontroler.ObrisiUlogu(dgwUloge, predstava);
        }

        private void btnObrisiZanr_Click(object sender, EventArgs e)
        {
            kontroler.ObrisiZanrIzmenaPredstave(cmbZanr, dgwZanrovi);
        }

        private void btnDodajZanr_Click(object sender, EventArgs e)
        {
            kontroler.DodajZanrIzmenaPredstave(cmbZanr, dgwZanrovi);
        }
    }
}
