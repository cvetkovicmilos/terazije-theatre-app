using Domen;
using Sesija;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije.RepertoarSO
{
    public class SacuvajRepertoar:OpstaSO
    {
        public override object Izvrsi(OpstiDomenskiObjekat odo)
        {
            Repertoar r = odo as Repertoar;
            r.SifraRepertoara = Broker.DajSesiju().VratiSifru(r);
            return Broker.DajSesiju().Sacuvaj(odo);
        }
    }
}
