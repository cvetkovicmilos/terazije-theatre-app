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
    public class Repertoar:OpstiDomenskiObjekat
    {
        int sifraRepertoara;
        string nazivRepertoara;
        DateTime datumVazenjaOd;
        DateTime datumVazenjaDo;

        public override string ToString()
        {
            return nazivRepertoara;
        }

        public OpstiDomenskiObjekat Napuni(DataRow red)
        {
            Repertoar r = new Repertoar();
            r.SifraRepertoara = Convert.ToInt32(red[0]);
            r.NazivRepertoara = red[1].ToString();
            r.DatumVazenjaOd = Convert.ToDateTime(red[2]);
            r.DatumVazenjaDo = Convert.ToDateTime(red[3]);
            return r;
        }

        [Browsable(false)]
        public int SifraRepertoara { get => sifraRepertoara; set => sifraRepertoara = value; }

        [DisplayName("Naziv repertoara")]
        public string NazivRepertoara { get => nazivRepertoara; set => nazivRepertoara = value; }

        [DisplayName("Vazi od")]
        public DateTime DatumVazenjaOd { get => datumVazenjaOd; set => datumVazenjaOd = value; }

        [DisplayName("Vazi do")]
        public DateTime DatumVazenjaDo { get => datumVazenjaDo; set => datumVazenjaDo = value; }


        [Browsable(false)]
        public string tabela => "Repertoar";

        [Browsable(false)]
        public string kljuc => "SifraRepertoara";

        [Browsable(false)]
        public string uslovJedan => "SifraRepertoara = " + SifraRepertoara;

        [Browsable(false)]
        public string uslovVise => "NazivRepertoara like '%" + NazivRepertoara + "%'";

        [Browsable(false)]
        public string azuriranje => "SifraRepertoara = " + SifraRepertoara + ", NazivRepertoara = '" + NazivRepertoara + "', DatumVazenjaOd = '" + DatumVazenjaOd.ToString("yyyy-MM-dd") + "', DatumVazenjaDo = '" + DatumVazenjaDo.ToString("yyyy-MM-dd") + "'";

        [Browsable(false)]
        public string upisivanje => "(" + SifraRepertoara + ", '" + NazivRepertoara + "', '" + DatumVazenjaOd.ToString("yyyy-MM-dd") + "', '" + DatumVazenjaDo.ToString("yyyy-MM-dd") + "')";
    }
}
