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

namespace SeminarskiRadPozoriste.FormeZanr
{
    public partial class UnosZanra : Form
    {
        KontrolerZanr kontroler = new KontrolerZanr();

        public UnosZanra()
        {
            InitializeComponent();
        }

        private void UnosZanra_Load(object sender, EventArgs e)
        {

        }

        private void btnDodajZanr_Click(object sender, EventArgs e)
        {
            kontroler.SacuvajZanr(txtZanr);
        }
    }
}
