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
    public partial class PretragaRepertoaraDialog : Form
    {
        KontrolerRepertoar kontroler = new KontrolerRepertoar();
        KontrolerIzvodjenje kontrolerIzvodjenje = new KontrolerIzvodjenje();
        Repertoar repertoar;

        public PretragaRepertoaraDialog()
        {
            InitializeComponent();
        }

        public PretragaRepertoaraDialog(Domen.Repertoar r)
        {
            InitializeComponent();
            repertoar = r;
            kontroler.PopuniFormu(txtNaziv, txtDatumOd, txtDatumDo, r, dgwIzvodjenja);
        }

        private void PretragaRepertoaraDialog_Load(object sender, EventArgs e)
        {
            kontrolerIzvodjenje.VratiIzvodjenjaZaRepertoar(dgwIzvodjenja, repertoar);
        }
    }
}
