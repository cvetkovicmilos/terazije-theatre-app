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
    public class Zanr:OpstiDomenskiObjekat
    {
        int sifraZanra;
        string naziv;

        public override string ToString()
        {
            return naziv;
        }

        //public Zanr Objekat
        //{
        //    get
        //    {
        //        return this;
        //    }
        //}


        public OpstiDomenskiObjekat Napuni(DataRow red)
        {
            Zanr z = new Zanr();
            z.SifraZanra = Convert.ToInt32(red[0]);
            z.Naziv = red[1].ToString();
            return z;
        }

        [Browsable(false)]
        public int SifraZanra { get => sifraZanra; set => sifraZanra = value; }

        [DisplayName("Naziv")]
        public string Naziv { get => naziv; set => naziv = value; }


        [Browsable(false)]
        public string tabela => "Zanr";

        [Browsable(false)]
        public string kljuc => "SifraZanra";

        [Browsable(false)]
        public string uslovJedan => "SifraZanra = " + SifraZanra;

        [Browsable(false)]
        public string uslovVise => null;

        [Browsable(false)]
        public string azuriranje => "SifraZanra = " + SifraZanra + ", Naziv = '" + Naziv + "'";

        [Browsable(false)]
        public string upisivanje => "(" + SifraZanra + ", '" + Naziv + "')";
    }
}
