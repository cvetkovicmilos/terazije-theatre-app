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
    public partial class PretragaPredstavaDialog : Form
    {
        KontrolerPredstava kontroler = new KontrolerPredstava();

        public PretragaPredstavaDialog()
        {
            InitializeComponent();
        }

        Domen.Predstava predstava;

        public PretragaPredstavaDialog(Domen.Predstava p)
        {
            InitializeComponent();
            kontroler.PopuniPretragaDialog(p, txtNaziv, txtDatum, txtReditelj, txtBrojGlumaca, dgwUloge, dgwZanrovi);
        }

        private void PretragaPredstavaDialog_Load(object sender, EventArgs e)
        {

        }
    }
}
