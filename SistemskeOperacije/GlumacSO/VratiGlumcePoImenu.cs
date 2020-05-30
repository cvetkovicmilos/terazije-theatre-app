using Domen;
using Sesija;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije.GlumacSO
{
    public class VratiGlumcePoImenu:OpstaSO
    {
        public override object Izvrsi(OpstiDomenskiObjekat odo)
        {
            List<Glumac> lista = new List<Glumac>();
            lista = Broker.DajSesiju().VratiSveZaUslovVise(odo).OfType<Glumac>().ToList<Glumac>();
            return lista;
        }
    }
}
