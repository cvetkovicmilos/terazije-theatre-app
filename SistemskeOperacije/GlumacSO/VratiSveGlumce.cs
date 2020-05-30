using Domen;
using Sesija;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije.GlumacSO
{
    public class VratiSveGlumce:OpstaSO
    {
        public override object Izvrsi(OpstiDomenskiObjekat odo)
        {
            List<Glumac> pronadjeni = new List<Glumac>();
            pronadjeni = Broker.DajSesiju().VratiSve(odo).OfType<Glumac>().ToList<Glumac>();
            return pronadjeni;
        }
    }
}
