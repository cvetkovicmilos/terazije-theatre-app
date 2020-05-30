using Domen;
using Sesija;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije.IzvodjenjeSO
{
    public class SacuvajIzvodjenje:OpstaSO
    {
        public override object Izvrsi(OpstiDomenskiObjekat odo)
        {
            Izvodjenje i = odo as Izvodjenje;
            i.RedniBroj = Broker.DajSesiju().VratiSifru(i);
            return Broker.DajSesiju().Sacuvaj(odo);
        }
    }
}
