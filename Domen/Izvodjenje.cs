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
    public class Izvodjenje:OpstiDomenskiObjekat
    {
        int redniBroj;
        DateTime datum;
        Predstava predstava;
        Repertoar repertoar;



        [Browsable(false)]
        public int RedniBroj { get => redniBroj; set => redniBroj = value; }

        [DisplayName("Datum")]
        public DateTime Datum { get => datum; set => datum = value; }

        [DisplayName("Predstava")]
        public Predstava Predstava { get => predstava; set => predstava = value; }

        [DisplayName("Repertoar")]
        public Repertoar Repertoar { get => repertoar; set => repertoar = value; }


        [Browsable(false)]
        public string tabela => "Izvodjenje";

        [Browsable(false)]
        public string kljuc => "RedniBroj";

        [Browsable(false)]
        public string uslovJedan => "RedniBroj = " + RedniBroj;

        [Browsable(false)]
        public string uslov = "";

        [Browsable(false)]
        public string uslovVise => uslov;

        [Browsable(false)]
        public string azuriranje => "SifraPredstave = " + Predstava.SifraPredstave + ", SifraRepertoara = " + Repertoar.SifraRepertoara + ", RedniBroj = " + RedniBroj + ", Datum = '" + Datum.ToString("yyyy-MM-dd") + "'";

        [Browsable(false)]
        public string upisivanje => "(" + Predstava.SifraPredstave + ", " + Repertoar.SifraRepertoara + ", " + RedniBroj + ", '" + Datum.ToString("yyyy-MM-dd") + "')";

        public OpstiDomenskiObjekat Napuni(DataRow red)
        {
            Izvodjenje i = new Izvodjenje();
            i.Predstava = new Predstava();
            i.Predstava.SifraPredstave = Convert.ToInt32(red[0]);
            //i.Predstava.NazivPredstave = red[1].ToString();
            i.Repertoar = new Repertoar();
            i.Repertoar.SifraRepertoara = Convert.ToInt32(red[1]);
            //i.Repertoar.NazivRepertoara = red[3].ToString();
            i.RedniBroj = Convert.ToInt32(red[2]);
            i.Datum = Convert.ToDateTime(red[3]);
            return i;
        }
    }
}
