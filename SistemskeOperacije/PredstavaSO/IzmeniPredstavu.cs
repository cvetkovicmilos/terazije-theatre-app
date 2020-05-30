﻿using Domen;
using Sesija;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije.PredstavaSO
{
    public class IzmeniPredstavu:OpstaSO
    {
        public override object Izvrsi(OpstiDomenskiObjekat odo)
        {
            return Broker.DajSesiju().Izmeni(odo);
        }
    }
}
