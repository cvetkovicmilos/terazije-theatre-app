using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    [Serializable]
    public class Uloga:OpstiDomenskiObjekat
    {
        int sifraUloge;
        string naziv;
        string tip;
        Predstava predstava;
        Glumac glumac;

        [Browsable(false)]
        public int SifraUloge { get => sifraUloge; set => sifraUloge = value; }

        [DisplayName("Naziv")]
        public string Naziv { get => naziv; set => naziv = value; }

        [DisplayName("Tip")]
        public string Tip { get => tip; set => tip = value; }

        [Browsable(false)]
        public Predstava Predstava { get => predstava; set => predstava = value; }

        [DisplayName("Glumac")]
        public Glumac Glumac { get => glumac; set => glumac = value; }

        // vrednosti za odo

        [Browsable(false)]
        public string tabela => "Uloga";

        [Browsable(false)]
        public string kljuc => "SifraUloge";

        [Browsable(false)]
        public string uslovJedan => "SifraUloge = " + SifraUloge;

        [Browsable(false)]
        public string uslov = "";

        [Browsable(false)]
        public string uslovVise => uslov;

        [Browsable(false)]
        public string azuriranje => "Naziv = '" + Naziv + "', Tip = '" + Tip + "', SifraGlumca = " + Glumac.SifraGlumca;

        [Browsable(false)]
        public string upisivanje => "(" + SifraUloge + ", " + Predstava.SifraPredstave + ", '" + Naziv + "', '" + Tip + "', " + Glumac.SifraGlumca + ")";

        [Browsable(false)]
        public OpstiDomenskiObjekat Napuni(DataRow red)
        {
            Uloga u = new Uloga();
            u.sifraUloge = Convert.ToInt32(red[0]);
            u.Predstava = new Predstava();
            u.predstava.SifraPredstave = Convert.ToInt32(red[1]);
            u.naziv = red[2].ToString();
            u.tip = red[3].ToString();
            u.Glumac = new Glumac();
            u.glumac.SifraGlumca = Convert.ToInt32(red[4]);
            return u;
        }
    }
}
