using Domen;
using Sesija;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije.ZanrPredstavaSO
{
    public class VratiZanroveZaPredstavu:OpstaSO
    {
        public override object Izvrsi(OpstiDomenskiObjekat odo)
        {
            List<ZanrPredstava> lista = new List<ZanrPredstava>();
            List<Zanr> pom = new List<Zanr>();
            lista = Broker.DajSesiju().VratiSveZaUslovVise(odo).OfType<ZanrPredstava>().ToList<ZanrPredstava>();
            foreach (ZanrPredstava zp in lista)
            {
                zp.Zanr = Broker.DajSesiju().VratiZaUslovJedan(zp.Zanr) as Zanr;
                pom.Add(zp.Zanr);
            }
            return pom;
        }
    }
}
