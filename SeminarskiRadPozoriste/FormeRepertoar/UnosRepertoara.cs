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
    public partial class UnosRepertoara : Form
    {
        KontrolerRepertoar kontroler = new KontrolerRepertoar();

        public UnosRepertoara()
        {
            InitializeComponent();
        }

        private void UnosRepertoara_Load(object sender, EventArgs e)
        {
            kontroler.OnemoguciDugmeZaIzvodjenje(btnDodajRepertoar, btnDodajIzvodjenja);
        }

        private void btnDodajIzvodjenja_Click(object sender, EventArgs e)
        {
            Repertoar repertoar = kontroler.VratiRepertoarZaDalje();

            this.Hide();
            new DodajIzvodjenje(repertoar).ShowDialog();
            this.Show();

        }

        private void btnDodajRepertoar_Click(object sender, EventArgs e)
        {
            if (kontroler.SacuvajRepertoar(txtNaziv, dtpOd, dtpDo))
                kontroler.OnemoguciDugmeZaRepertoar(btnDodajRepertoar, btnDodajIzvodjenja);
        }
    }
}
