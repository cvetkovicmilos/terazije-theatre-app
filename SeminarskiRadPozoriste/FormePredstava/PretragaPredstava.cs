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
    public partial class PretragaPredstava : Form
    {
        KontrolerPredstava kontroler = new KontrolerPredstava();

        public PretragaPredstava()
        {
            InitializeComponent();
        }

        private void PretragaPredstava_Load(object sender, EventArgs e)
        {
            kontroler.VratiSvePredstaveZaDgw(dgwPredstave);
        }

        private void txtPojam_TextChanged(object sender, EventArgs e)
        {
            kontroler.VratiPredstavePoNazivu(dgwPredstave, txtPojam);
        }

        private void btnIzaberi_Click(object sender, EventArgs e)
        {
            Domen.Predstava p = dgwPredstave.CurrentRow.DataBoundItem as Domen.Predstava;


            this.Hide();
            new PretragaPredstavaDialog(p).ShowDialog();
            this.Show();
        }
    }
}
