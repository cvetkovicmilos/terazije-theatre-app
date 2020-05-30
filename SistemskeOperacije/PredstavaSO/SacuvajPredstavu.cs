using Domen;
using Sesija;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije.PredstavaSO
{
    public class SacuvajPredstavu:OpstaSO
    {
        public override object Izvrsi(OpstiDomenskiObjekat odo)
        {
            Predstava p = odo as Predstava;
            p.SifraPredstave = Broker.DajSesiju().VratiSifru(p);
            return Broker.DajSesiju().Sacuvaj(odo);
        }
    }
}
