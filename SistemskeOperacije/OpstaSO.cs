using Domen;
using Sesija;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije
{
    public abstract class OpstaSO
    {
        public Object IzvrsiSO(OpstiDomenskiObjekat odo)
        {
            Object rezultat = null;
            Broker.DajSesiju().OtvoriKonekciju();
            Broker.DajSesiju().ZapocniTransakciju();
            
            try
            {
                rezultat = Izvrsi(odo);
                Broker.DajSesiju().PotvrdiTransakciju();
            }
            catch (Exception)
            {
                Broker.DajSesiju().PonistiTransakciju();
            }
            finally
            {
                Broker.DajSesiju().ZatvoriKonekciju();
            }

            return rezultat;
        }

        public virtual object Izvrsi(OpstiDomenskiObjekat odo)
        {
            return null;
        }
    }
}
