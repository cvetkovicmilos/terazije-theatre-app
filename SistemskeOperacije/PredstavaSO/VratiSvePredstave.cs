using Domen;
using Sesija;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije.PredstavaSO
{
    public class VratiSvePredstave:OpstaSO
    {
        public override object Izvrsi(OpstiDomenskiObjekat odo)
        {
            List<Predstava> pronadjene = new List<Predstava>();
            pronadjene = Broker.DajSesiju().VratiSve(odo).OfType<Predstava>().ToList<Predstava>();
            return pronadjene;
        }
    }
}
