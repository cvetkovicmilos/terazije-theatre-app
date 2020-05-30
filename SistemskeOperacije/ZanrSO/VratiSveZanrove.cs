using Domen;
using Sesija;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije.ZanrSO
{
    public class VratiSveZanrove:OpstaSO
    {
        public override object Izvrsi(OpstiDomenskiObjekat odo)
        {
            List<Zanr> pronadjeni = new List<Zanr>();
            pronadjeni = Broker.DajSesiju().VratiSve(odo).OfType<Zanr>().ToList<Zanr>();
            return pronadjeni;
        }
    }
}
