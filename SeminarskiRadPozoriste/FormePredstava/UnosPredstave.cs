using Domen;
using KontrolerKorisnickogInterfejsa;
using SeminarskiRadPozoriste.FormeZanr;
using Sesija;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeminarskiRadPozoriste.FormePredstava
{
    public partial class UnosPredstave : Form
    {
        KontrolerPredstava kontroler = new KontrolerPredstava();

        public UnosPredstave()
        {
            InitializeComponent();
        }

        private void UnosPredstave_Load(object sender, EventArgs e)
        {
            kontroler.PopuniUnosPredstave(cmbGlumac, cmbZanr);
            gbPredstava.Enabled = true;
            gbUloga.Enabled = false;

        }

        private void btnUnosPredstave_Click(object sender, EventArgs e)
        {
            if (kontroler.SacuvajPredstavu(txtNazivPredstave, dtpDatumPostavljanja, txtReditelj, dgwZanr))
            {
                kontroler.PromeniStanje(gbPredstava, gbUloga);
                kontroler.PostaviNazivPredstave(txtTrenutnaPredstava);
            }
        }

        private void btnDodajGlumca_Click(object sender, EventArgs e)
        {
            UnosPredstaveUlogaDialog dialog = new UnosPredstaveUlogaDialog(kontroler.VratiGlumcaZaUlogu(cmbGlumac), kontroler.VratiPredstavuZaUlogu());
            dialog.ShowDialog();            
            kontroler.PopuniDgwUloge(dialog.Uloga, dgwUloge);
        }

        private void btnDodajUloge_Click(object sender, EventArgs e)
        {
            kontroler.SacuvajUlogeZaPredstavu(dgwUloge, kontroler.VratiPredstavuZaUlogu());
        }

        private void btnDodajZanr_Click(object sender, EventArgs e)
        {
            new UnosZanra().ShowDialog();
        }

        private void cmbZanr_DropDown(object sender, EventArgs e)
        {
            kontroler.VratiZanroveZaCmb(cmbZanr);
        }

        private void btnZanr_Click(object sender, EventArgs e)
        {
            kontroler.DodajZanrZaPredstavu(cmbZanr, dgwZanr);
        }

        private void cmbZanr_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
