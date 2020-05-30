using Domen;
using Sesija;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije.GlumacSO
{
    public class VratiSifruGlumca:OpstaSO
    {
        public override object Izvrsi(OpstiDomenskiObjekat odo)
        {
            Glumac g = new Glumac();
            g.SifraGlumca = Broker.DajSesiju().VratiSifru(odo);
            return g;
        }
    }
}
