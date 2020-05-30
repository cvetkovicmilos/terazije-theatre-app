using Domen;
using Sesija;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije.RepertoarSO
{
    public class VratiSveRepertoare:OpstaSO
    {
        public override object Izvrsi(OpstiDomenskiObjekat odo)
        {
            List<Repertoar> pronadjeni = new List<Repertoar>();
            pronadjeni = Broker.DajSesiju().VratiSve(odo).OfType<Repertoar>().ToList<Repertoar>();
            return pronadjeni;
        }
    }
}
