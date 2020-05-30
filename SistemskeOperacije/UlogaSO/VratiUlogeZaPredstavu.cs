using Domen;
using Sesija;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije.UlogaSO
{
    public class VratiUlogeZaPredstavu:OpstaSO
    {
        public override object Izvrsi(OpstiDomenskiObjekat odo)
        {
            List<Uloga> lista = new List<Uloga>();
            lista = Broker.DajSesiju().VratiSveZaUslovVise(odo).OfType<Uloga>().ToList<Uloga>();
            foreach (Uloga u in lista)
            {
                u.Predstava = Broker.DajSesiju().VratiZaUslovJedan(u.Predstava) as Predstava;
                u.Glumac = Broker.DajSesiju().VratiZaUslovJedan(u.Glumac) as Glumac;
            }
            return lista;
        }
    }
}
