using Domen;
using Sesija;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije.KorisnikSO
{
    public class PrijaviKorisnika:OpstaSO
    {
        public override object Izvrsi(OpstiDomenskiObjekat odo)
        {
            return Broker.DajSesiju().VratiZaUslovVise(odo);
        }
    }
}
