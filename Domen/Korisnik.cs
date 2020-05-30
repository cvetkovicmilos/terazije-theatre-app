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
    public class Korisnik:OpstiDomenskiObjekat
    {
        #region Atributi


        string korisnickoIme;
        string email;
        string lozinka;

        [DisplayName("Korisnicko ime")]
        public string KorisnickoIme { get => korisnickoIme; set => korisnickoIme = value; }
        [DisplayName("E-mail")]
        public string Email { get => email; set => email = value; }
        [DisplayName("Lozinka")]
        public string Lozinka { get => lozinka; set => lozinka = value; }

        #endregion
        #region ODO

        [Browsable(false)]
        public string tabela => "Korisnik";

        [Browsable(false)]
        public string kljuc => "KorisnickoIme";

        [Browsable(false)]
        public string uslovJedan => "KorisnickoIme = '" + KorisnickoIme + "'";

        [Browsable(false)]
        public string uslovVise => "KorisnickoIme = '" + KorisnickoIme + "' and Lozinka = '" + Lozinka + "'";

        [Browsable(false)]
        public string azuriranje => "KorisnickoIme = '" + KorisnickoIme + "', Email = '" + Email + "', Lozinka = '" + Lozinka + "'";

        [Browsable(false)]
        public string upisivanje => "('" + KorisnickoIme + "', '" + Email + "', '" + Lozinka + "')";

        public OpstiDomenskiObjekat Napuni(DataRow red)
        {
            Korisnik k = new Korisnik();
            k.KorisnickoIme = red[0].ToString();
            k.Email = red[1].ToString();
            k.Lozinka = red[2].ToString();
            return k;
        }

        #endregion
    }
}
