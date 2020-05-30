using Domen;
using Sesija;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije.PredstavaSO
{
    public class VratiPredstavePoNazivu:OpstaSO
    {
        public override object Izvrsi(OpstiDomenskiObjekat odo)
        {
            List<Predstava> lista = new List<Predstava>();
            lista = Broker.DajSesiju().VratiSveZaUslovVise(odo).OfType<Predstava>().ToList<Predstava>();
            return lista;
        }
    }
}
