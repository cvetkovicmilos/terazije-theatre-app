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
    public class Predstava:OpstiDomenskiObjekat
    {
        int sifraPredstave;
        string nazivPredstave;
        DateTime datumPostavljanja;
        int brojGlumaca;
        string reditelj;
        List<Uloga> listaUloga;

        public override string ToString()
        {
            return nazivPredstave;
        }

        public OpstiDomenskiObjekat Napuni(DataRow red)
        {
            Predstava p = new Predstava();
            p.SifraPredstave = Convert.ToInt32(red[0]);
            p.NazivPredstave = red[1].ToString();
            p.DatumPostavljanja = Convert.ToDateTime(red[2]);
            p.BrojGlumaca = Convert.ToInt32(red[3]);
            p.Reditelj = red[4].ToString();
            return p;
        }

        [Browsable(false)]
        public int SifraPredstave { get => sifraPredstave; set => sifraPredstave = value; }

        [DisplayName("Naziv predstave")]
        public string NazivPredstave { get => nazivPredstave; set => nazivPredstave = value; }

        [DisplayName("Datum postavljanja")]
        public DateTime DatumPostavljanja { get => datumPostavljanja; set => datumPostavljanja = value; }

        [DisplayName("Broj glumaca")]
        public int BrojGlumaca { get => brojGlumaca; set => brojGlumaca = value; }

        [DisplayName("Reditelj")]
        public string Reditelj { get => reditelj; set => reditelj = value; }

        [DisplayName("Uloge")]
        public List<Uloga> Uloga { get => listaUloga; set => listaUloga = value; }

        [Browsable(false)]
        public List<Zanr> Zanrovi { get; set; }

        //[DisplayName("Zanrovi")]
        //public string ZanroviPrikaz
        //{
        //    get
        //    {
        //        string rez = "";
        //        Zanrovi?.ForEach(z => rez.Concat($", {z.Naziv}"));
        //        return rez;
        //    }
        //}

        [Browsable(false)]
        public string tabela => "Predstava";

        [Browsable(false)]
        public string kljuc => "SifraPredstave";

        [Browsable(false)]
        public string uslovJedan => "SifraPredstave = " + SifraPredstave;

        [Browsable(false)]
        public string uslov = "";

        [Browsable(false)]
        public string uslovVise => uslov;

        [Browsable(false)]
        public string azuriranje => "SifraPredstave = " + SifraPredstave + ", NazivPredstave = '" + NazivPredstave + "', DatumPostavljanja = '" + DatumPostavljanja.ToString("yyyy-MM-dd") + "', BrojGlumaca = " + BrojGlumaca + ", Reditelj = '" + Reditelj + "'";

        [Browsable(false)]
        public string upisivanje => "(" + SifraPredstave + ", '" + NazivPredstave + "', '" + DatumPostavljanja.ToString("yyyy-MM-dd") + "', " + BrojGlumaca + ", '" + Reditelj + "')";
    }
}
