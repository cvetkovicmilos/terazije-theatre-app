using Domen;
using Sesija;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije.GlumacSO
{
    public class SacuvajGlumca:OpstaSO
    {
        public override object Izvrsi(OpstiDomenskiObjekat odo)
        {
            Glumac g = odo as Glumac;
            g.SifraGlumca = Broker.DajSesiju().VratiSifru(g);
            return Broker.DajSesiju().Sacuvaj(odo);
        }
    }
}
