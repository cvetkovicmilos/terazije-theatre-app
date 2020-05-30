using Domen;
using Sesija;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije.UlogaSO
{
    public class SacuvajUlogeZaPredstavu:OpstaSO
    {
        public override object Izvrsi(OpstiDomenskiObjekat odo)
        {
            Uloga u = odo as Uloga;
            u.SifraUloge = Broker.DajSesiju().VratiSifru(u);
            return Broker.DajSesiju().Sacuvaj(odo);
        }
    }
}
