using Domen;
using KontrolerKorisnickogInterfejsa;
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
    public partial class UnosPredstaveUlogaDialog : Form
    {
        KontrolerPredstava kontroler = new KontrolerPredstava();
        public Uloga Uloga { get; set; }

        public UnosPredstaveUlogaDialog()
        {
            InitializeComponent();
        }

        public UnosPredstaveUlogaDialog(Glumac g, Predstava p)
        {
            InitializeComponent();

            kontroler.PopuniDialog(lblGlumac, lblPredstava, g, p);
        }

        private void UnosPredstaveUlogaDialog_Load(object sender, EventArgs e)
        {

        }

        private void btnDodajUlogu_Click(object sender, EventArgs e)
        {
            Uloga = kontroler.DodajUlogu(txtNaziv, txtTip);
            Close();
        }
    }
}
