using Domen;
using Sesija;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije.IzvodjenjeSO
{
    public class VratiSvaIzvodjenjaZaPredstavu:OpstaSO
    {
        public override object Izvrsi(OpstiDomenskiObjekat odo)
        {
            List<Izvodjenje> lista = new List<Izvodjenje>();
            lista = Broker.DajSesiju().VratiSveZaUslovVise(odo).OfType<Izvodjenje>().ToList<Izvodjenje>();
            foreach (Izvodjenje i in lista)
            {
                i.Predstava = Broker.DajSesiju().VratiZaUslovJedan(i.Predstava) as Predstava;
                i.Repertoar = Broker.DajSesiju().VratiZaUslovJedan(i.Repertoar) as Repertoar;
            }
            return lista;
        }
    }
}
