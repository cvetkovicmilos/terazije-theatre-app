using Domen;
using Sesija;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije.ZanrSO
{
    public class SacuvajZanr:OpstaSO
    {
        public override object Izvrsi(OpstiDomenskiObjekat odo)
        {
            Zanr z = odo as Zanr;
            z.SifraZanra = Broker.DajSesiju().VratiSifru(z);
            return Broker.DajSesiju().Sacuvaj(odo);
        }
    }
}
