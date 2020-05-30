using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using Sesija;
using KontrolerKorisnickogInterfejsa;

namespace SeminarskiRadPozoriste.FormePredstava
{
    public partial class IzmenaPredstave : Form
    {
        KontrolerPredstava kontroler = new KontrolerPredstava();

        public IzmenaPredstave()
        {
            InitializeComponent();
        }

        private void IzmenaPredstave_Load(object sender, EventArgs e)
        {
            kontroler.VratiSvePredstaveZaDgw(dgwPredstave);
        }

        private void btnIzaberi_Click(object sender, EventArgs e)
        {
            Domen.Predstava p = dgwPredstave.CurrentRow.DataBoundItem as Domen.Predstava;

            this.Hide();
            new IzmenaPredstaveDialog(p).ShowDialog();
            this.Show();
        }
    }
}
