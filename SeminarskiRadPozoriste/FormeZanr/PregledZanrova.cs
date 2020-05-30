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
    public partial class PregledZanrova : Form
    {
        KontrolerZanr kontroler = new KontrolerZanr();

        public PregledZanrova()
        {
            InitializeComponent();
        }

        private void PregledZanrova_Load(object sender, EventArgs e)
        {
            kontroler.VratiSveZanrove(dgwPregledZanrova);
        }
    }
}
