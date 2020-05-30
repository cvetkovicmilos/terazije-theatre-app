using SeminarskiRadPozoriste.FormeGlumac;
using SeminarskiRadPozoriste.FormaIzvodjenje;
using SeminarskiRadPozoriste.FormePredstava;
using SeminarskiRadPozoriste.FormeRepertoar;
using SeminarskiRadPozoriste.FormeZanr;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KontrolerKorisnickogInterfejsa;

namespace SeminarskiRadPozoriste
{
    public partial class PocetnaForma : Form
    {
        KontrolerPrijava kontroler = new KontrolerPrijava();

        public PocetnaForma()
        {
            InitializeComponent();
        }

        private void unosNovogGlumcaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new UnosGlumca().ShowDialog();
            this.Show();
        }

        private void izmenaGlumcaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new IzmenaGlumca().ShowDialog();
            this.Show();
        }

        private void brisanjeGlumcaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new BrisanjeGlumca().ShowDialog();
            this.Show();
        }

        private void pretragaGlumacaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new PretragaGlumaca().ShowDialog();
            this.Show();
        }

        private void unosNovePredstaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new UnosPredstave().ShowDialog();
            this.Show();
        }

        private void brisanjePredstaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new BrisanjePredstave().ShowDialog();
            this.Show();
        }

        private void pretragaPredstavaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new PretragaPredstava().ShowDialog();
            this.Show();
        }

        private void pregledSvihŽanrovaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new PregledZanrova().ShowDialog();
            this.Show();
        }

        private void unosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new UnosZanra().ShowDialog();
            this.Show();
        }

        private void izmenaPredstaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new IzmenaPredstave().ShowDialog();
            this.Show();
        }

        private void unosNovogRepertoaraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new UnosRepertoara().ShowDialog();
            this.Show();
        }

        private void pretragaRepertoaraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new PretragaRepertoara().ShowDialog();
            this.Show();
        }

        private void pregledIzvodjenjaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new PregledIzvodjenja().ShowDialog();
            this.Show();
        }

        private void dodajIzvodjenjeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new DodajIzvodjenje().ShowDialog();
            this.Show();
        }

        private void brisanjeRepertoaraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new BrisanjeRepertoara().ShowDialog();
            this.Show();
        }

        private void izmenaRepertoaraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new IzmenaRepertoara().ShowDialog();
            this.Show();
        }

        private void PocetnaForma_FormClosed(object sender, FormClosedEventArgs e)
        {
            kontroler.Kraj();
        }

        private void PocetnaForma_Load(object sender, EventArgs e)
        {
            menuStrip1.ForeColor = Color.White;
        }
    }
}
