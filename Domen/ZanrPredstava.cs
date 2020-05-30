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
    public class ZanrPredstava:OpstiDomenskiObjekat
    {
        Zanr zanr;
        Predstava predstava;

        [Browsable(false)]
        public Zanr Zanr { get => zanr; set => zanr = value; }
        
        [Browsable(false)]
        public Predstava Predstava { get => predstava; set => predstava = value; }


        [Browsable(false)]
        public string tabela => "ZanrPredstava";

        [Browsable(false)]
        public string kljuc => "";

        [Browsable(false)]
        public string uslovJedan => "SifraZanra = " + Zanr.SifraZanra;

        [Browsable(false)]
        public string uslov = "";

        [Browsable(false)]
        public string uslovVise => uslov;

        [Browsable(false)]
        public string azuriranje => "SifraZanra = " + Zanr.SifraZanra + ", SifraPredstave = " + Predstava.SifraPredstave + "";

        [Browsable(false)]
        public string upisivanje => "(" + Zanr.SifraZanra + ", " + Predstava.SifraPredstave + ")";

        public OpstiDomenskiObjekat Napuni(DataRow red)
        {
            ZanrPredstava zp = new ZanrPredstava();
            zp.Zanr = new Zanr();
            zp.Zanr.SifraZanra = Convert.ToInt32(red[0]);
            zp.Predstava = new Predstava();
            zp.Predstava.SifraPredstave = Convert.ToInt32(red[1]);
            return zp;
        }
    }
}
