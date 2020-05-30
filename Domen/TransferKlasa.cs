using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    public enum Operacije { Kraj = 1,
        VratiSifruGlumca = 2,
        SacuvajGlumca = 3,
        IzmeniGlumca = 4,
        ObrisiGlumca = 5,
        VratiSveGlumce = 6,
        VratiGlumcePoImenu = 7,
        RegistrujKorisnika = 8,
        PrijaviKorisnika = 9,
        SacuvajZanr = 10,
        VratiSveZanrove = 11,
        VratiSvePredstave = 12,
        VratiSveRepertoare = 13,
        SacuvajRepertoar = 14,
        VratiSvaIzvodjenja = 15,
        VratiRepertoarePoNazivu = 16,
        ObrisiRepertoar = 17,
        VratiIzvodjenjaZaRepertoar = 18,
        VratiIzvodjenjaZaPredstavu = 19,
        SacuvajIzvodjenje = 20,
        IzmeniRepertoar = 21,
        IzmeniIzvodjenje = 22,
        ObrisiIzvodjenje = 23,
        ObrisiPredstavu = 24,
        VratiRepertoarPoNazivu = 25,
        VratiPredstavePoNazivu = 26,
        VratiZanroveZaPredstavu = 27,
        SacuvajPredstavu = 28,
        SacuvajZanrPredstavu = 29,
        VratiPoslednjeDodatuPredstavu = 30,
        SacuvajUlogeZaPredstavu = 31,
        VratiUlogeZaPredstavu = 32,
        IzmeniPredstavu = 33,
        ObrisiZanrZaPredstavu = 34,
        ObrisiUlogu = 35,
        IzmeniUlogu = 36
    }
    [Serializable]
    public class TransferKlasa
    {
        public Operacije Operacija;
        public Object TransferObjekat;
        public Object Rezultat;
    }
}
