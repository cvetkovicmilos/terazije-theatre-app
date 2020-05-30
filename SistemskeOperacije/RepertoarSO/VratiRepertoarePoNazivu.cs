using Domen;
using Sesija;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije.RepertoarSO
{
    public class VratiRepertoarePoNazivu:OpstaSO
    {
        public override object Izvrsi(OpstiDomenskiObjekat odo)
        {
            List<Repertoar> lista = new List<Repertoar>();
            lista = Broker.DajSesiju().VratiSveZaUslovVise(odo).OfType<Repertoar>().ToList<Repertoar>();
            return lista;
        }
    }
}
