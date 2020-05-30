using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    public enum Pol { Muski, Zenski}

    [Serializable]
    public class Glumac:OpstiDomenskiObjekat
    {
        int sifraGlumca;
        string ime;
        string prezime;
        Pol pol;
        DateTime datumRodjenja;
        double radniStaz;

        public override string ToString()
        {
            return ime + " " + prezime;
        }

        public OpstiDomenskiObjekat Napuni(DataRow red)
        {
            Glumac g = new Glumac();
            g.SifraGlumca = Convert.ToInt32(red[0]);
            g.Ime = red[1].ToString();
            g.Prezime = red[2].ToString();
            g.Pol = (Pol)Enum.Parse(typeof(Pol), red[3].ToString());
            g.DatumRodjenja = Convert.ToDateTime(red[4]);
            g.RadniStaz = Convert.ToInt32(red[5]);
            return g;
        }

        [Browsable(false)]
        public int SifraGlumca { get => sifraGlumca; set => sifraGlumca = value; }
        [DisplayName("Ime")]
        public string Ime { get => ime; set => ime = value; }
        [DisplayName("Prezime")]
        public string Prezime { get => prezime; set => prezime = value; }
        [DisplayName("Pol")]
        public Pol Pol { get => pol; set => pol = value; }
        [DisplayName("Datum rodjenja")]
        public DateTime DatumRodjenja { get => datumRodjenja; set => datumRodjenja = value; }
        [DisplayName("Radni staz")]
        public double RadniStaz { get => radniStaz; set => radniStaz = value; }

        [Browsable(false)]
        public string tabela => "Glumac";

        [Browsable(false)]
        public string kljuc => "SifraGlumca";

        [Browsable(false)]
        public string uslovJedan => "SifraGlumca = " + SifraGlumca;

        [Browsable(false)]
        public string uslovVise => "Ime like '%" + Ime + "%'";

        [Browsable(false)]
        public string azuriranje => "Ime = '" + Ime + "', Prezime = '" + Prezime + "', Pol = '" + Pol.ToString() + "', DatumRodjenja = '" + DatumRodjenja.ToString("yyyy-MM-dd") + "', RadniStaz = '" + RadniStaz + "'";

        [Browsable(false)]
        public string upisivanje => "(" + SifraGlumca + ", '" + Ime + "', '" + Prezime + "', '" + Pol.ToString() + "', '" + DatumRodjenja.ToString("yyyy-MM-dd") + "', " + RadniStaz + ")";
    }
}
