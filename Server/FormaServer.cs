using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server
{
    public partial class FormaServer : Form
    {
        Server s;

        public FormaServer()
        {
            InitializeComponent();
        }

        private void FormaServer_Load(object sender, EventArgs e)
        {
            btnZaustavi.Enabled = false;   
        }

        private void btnPokreni_Click(object sender, EventArgs e)
        {
            s = new Server();
            if (s.PokreniServer())
            {
                this.Text = "Pozoriste - Server pokrenut";
                btnPokreni.Enabled = false;
                btnZaustavi.Enabled = true;
                label1.Text = "Server je pokrenut!";
            }
        }

        private void btnZaustavi_Click(object sender, EventArgs e)
        {
            if (s.ZaustaviServer())
            {
                try
                {
                    this.Text = "Pozoriste - Server zaustavljen";
                    btnPokreni.Enabled = true;
                    btnZaustavi.Enabled = false;
                    label1.Text = "Server je zaustavljen!";
                }
                catch (Exception)
                {
                    MessageBox.Show("Ima jos prijavljenih korisnika!");
                }
            }
        }
    }
}
