using Domen;
using SistemskeOperacije.GlumacSO;
using SistemskeOperacije.IzvodjenjeSO;
using SistemskeOperacije.KorisnikSO;
using SistemskeOperacije.PredstavaSO;
using SistemskeOperacije.RepertoarSO;
using SistemskeOperacije.UlogaSO;
using SistemskeOperacije.ZanrPredstavaSO;
using SistemskeOperacije.ZanrSO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Server
{
    public class NitKlijenta
    {
        private NetworkStream tok;
        BinaryFormatter formater;

        public NitKlijenta(NetworkStream tok)
        {
            this.tok = tok;
            formater = new BinaryFormatter();

            ThreadStart ts = Obradi;
            new Thread(ts).Start();
        }

        private void Obradi()
        {
            try
            {
                int operacija = 0;
                while (operacija != (int)Operacije.Kraj)
                {
                    TransferKlasa transfer = formater.Deserialize(tok) as TransferKlasa;
                    switch (transfer.Operacija)
                    {
                        // KORISNIK

                        case Operacije.RegistrujKorisnika:
                            RegistrujKorisnika registrujKorisnika = new RegistrujKorisnika();
                            transfer.Rezultat = registrujKorisnika.IzvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;
                        case Operacije.PrijaviKorisnika:
                            PrijaviKorisnika prijaviKorisnika = new PrijaviKorisnika();
                            transfer.Rezultat = prijaviKorisnika.IzvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;

                        // ZANR

                        case Operacije.SacuvajZanr:
                            SacuvajZanr sacuvajZanr = new SacuvajZanr();
                            transfer.Rezultat = sacuvajZanr.IzvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;
                        case Operacije.VratiSveZanrove:
                            VratiSveZanrove vratiSveZanrove = new VratiSveZanrove();
                            transfer.Rezultat = vratiSveZanrove.IzvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;

                        // GLUMAC

                        case Operacije.VratiSifruGlumca:
                            VratiSifruGlumca sifraGlumca = new VratiSifruGlumca();
                            transfer.Rezultat = sifraGlumca.IzvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;
                        case Operacije.SacuvajGlumca:
                            SacuvajGlumca sacuvajGlumca = new SacuvajGlumca();
                            transfer.Rezultat = sacuvajGlumca.IzvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;
                        case Operacije.IzmeniGlumca:
                            IzmeniGlumca izmeniGlumca = new IzmeniGlumca();
                            transfer.Rezultat = izmeniGlumca.IzvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;
                        case Operacije.ObrisiGlumca:
                            ObrisiGlumca obrisiGlumca = new ObrisiGlumca();
                            transfer.Rezultat = obrisiGlumca.IzvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;
                        case Operacije.VratiSveGlumce:
                            VratiSveGlumce vratiSveGlumce = new VratiSveGlumce();
                            transfer.Rezultat = vratiSveGlumce.IzvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;
                        case Operacije.VratiGlumcePoImenu:
                            VratiGlumcePoImenu vratiGlumcePoImenu = new VratiGlumcePoImenu();
                            OpstiDomenskiObjekat odoGlumac = new Glumac { Ime = transfer.TransferObjekat.ToString() };
                            transfer.Rezultat = vratiGlumcePoImenu.IzvrsiSO(odoGlumac);
                            formater.Serialize(tok, transfer);
                            break;

                        // PREDSTAVA

                        case Operacije.VratiSvePredstave:
                            VratiSvePredstave vratiSvePredstave = new VratiSvePredstave();
                            transfer.Rezultat = vratiSvePredstave.IzvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;
                        case Operacije.ObrisiPredstavu:
                            ObrisiPredstavu obrisiPredstavu = new ObrisiPredstavu();
                            transfer.Rezultat = obrisiPredstavu.IzvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;
                        case Operacije.VratiPredstavePoNazivu:
                            VratiPredstavePoNazivu vratiPredstavePoNazivu = new VratiPredstavePoNazivu();
                            //OpstiDomenskiObjekat odoPredstava = new Predstava { NazivPredstave = transfer.TransferObjekat.ToString() };
                            transfer.Rezultat = vratiPredstavePoNazivu.IzvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;
                        case Operacije.SacuvajPredstavu:
                            SacuvajPredstavu sacuvajPredstavu = new SacuvajPredstavu();
                            transfer.Rezultat = sacuvajPredstavu.IzvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;
                        case Operacije.VratiPoslednjeDodatuPredstavu:
                            VratiPoslednjeDodatuPredstavu vratiPoslednjeDodatuPredstavu = new VratiPoslednjeDodatuPredstavu();
                            transfer.Rezultat = vratiPoslednjeDodatuPredstavu.IzvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;
                        case Operacije.IzmeniPredstavu:
                            IzmeniPredstavu izmeniPredstavu = new IzmeniPredstavu();
                            transfer.Rezultat = izmeniPredstavu.IzvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;

                        // REPERTOAR

                        case Operacije.VratiSveRepertoare:
                            VratiSveRepertoare vratiSveRepertoare = new VratiSveRepertoare();
                            transfer.Rezultat = vratiSveRepertoare.IzvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;
                        case Operacije.SacuvajRepertoar:
                            SacuvajRepertoar sacuvajRepertoar = new SacuvajRepertoar();
                            transfer.Rezultat = sacuvajRepertoar.IzvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;
                        case Operacije.VratiRepertoarePoNazivu: 
                            VratiRepertoarePoNazivu vratiRepertoarePoNazivu = new VratiRepertoarePoNazivu();
                            OpstiDomenskiObjekat odoRepertoar = new Repertoar { NazivRepertoara = transfer.TransferObjekat.ToString() };
                            transfer.Rezultat = vratiRepertoarePoNazivu.IzvrsiSO(odoRepertoar);
                            formater.Serialize(tok, transfer);
                            break;
                        case Operacije.ObrisiRepertoar:
                            ObrisiRepertoar obrisiRepertoar = new ObrisiRepertoar();
                            transfer.Rezultat = obrisiRepertoar.IzvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;
                        case Operacije.IzmeniRepertoar:
                            IzmeniRepertoar izmeniRepertoar = new IzmeniRepertoar();
                            transfer.Rezultat = izmeniRepertoar.IzvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;
                        case Operacije.VratiRepertoarPoNazivu:
                            VratiRepertoarPoNazivu vratiRepertoarPoNazivu = new VratiRepertoarPoNazivu();
                            OpstiDomenskiObjekat odoRepertoar2 = new Repertoar { NazivRepertoara = transfer.TransferObjekat.ToString() };
                            transfer.Rezultat = vratiRepertoarPoNazivu.IzvrsiSO(odoRepertoar2);
                            formater.Serialize(tok, transfer);
                            break;

                        // IZVODJENJE

                        case Operacije.VratiSvaIzvodjenja:
                            VratiSvaIzvodjenja vratiSvaIzvodjenja = new VratiSvaIzvodjenja();
                            transfer.Rezultat = vratiSvaIzvodjenja.IzvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;
                        case Operacije.VratiIzvodjenjaZaRepertoar:
                            VratiSvaIzvodjenjaZaRepertoar vratiSvaIzvodjenjaZaRepertoar = new VratiSvaIzvodjenjaZaRepertoar();
                            transfer.Rezultat = vratiSvaIzvodjenjaZaRepertoar.IzvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;
                        case Operacije.VratiIzvodjenjaZaPredstavu:
                            VratiSvaIzvodjenjaZaPredstavu vratiSvaIzvodjenjaZaPredstavu = new VratiSvaIzvodjenjaZaPredstavu();
                            transfer.Rezultat = vratiSvaIzvodjenjaZaPredstavu.IzvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;
                        case Operacije.SacuvajIzvodjenje:
                            SacuvajIzvodjenje sacuvajIzvodjenje = new SacuvajIzvodjenje();
                            transfer.Rezultat = sacuvajIzvodjenje.IzvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;
                        case Operacije.IzmeniIzvodjenje:
                            IzmeniIzvodjenje izmeniIzvodjenje = new IzmeniIzvodjenje();
                            transfer.Rezultat = izmeniIzvodjenje.IzvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;
                        case Operacije.ObrisiIzvodjenje:
                            ObrisiIzvodjenje obrisiIzvodjenje = new ObrisiIzvodjenje();
                            transfer.Rezultat = obrisiIzvodjenje.IzvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;

                        // ZANR PREDSTAVA

                        case Operacije.VratiZanroveZaPredstavu:
                            VratiZanroveZaPredstavu vratiZanroveZaPredstavu = new VratiZanroveZaPredstavu();
                            transfer.Rezultat = vratiZanroveZaPredstavu.IzvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;
                        case Operacije.SacuvajZanrPredstavu:
                            SacuvajZanrPredstavu sacuvajZanrPredstavu = new SacuvajZanrPredstavu();
                            transfer.Rezultat = sacuvajZanrPredstavu.IzvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;
                        case Operacije.ObrisiZanrZaPredstavu:
                            ObrisiZanrZaPredstavu obrisiZanrZaPredstavu = new ObrisiZanrZaPredstavu();
                            transfer.Rezultat = obrisiZanrZaPredstavu.IzvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;

                        // ULOGA

                        case Operacije.SacuvajUlogeZaPredstavu:
                            SacuvajUlogeZaPredstavu sacuvajUlogeZaPredstavu = new SacuvajUlogeZaPredstavu();
                            transfer.Rezultat = sacuvajUlogeZaPredstavu.IzvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;
                        case Operacije.VratiUlogeZaPredstavu:
                            VratiUlogeZaPredstavu vratiUlogeZaPredstavu = new VratiUlogeZaPredstavu();
                            transfer.Rezultat = vratiUlogeZaPredstavu.IzvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;
                        case Operacije.ObrisiUlogu:
                            ObrisiUlogu obrisiUlogu = new ObrisiUlogu();
                            transfer.Rezultat = obrisiUlogu.IzvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;
                        case Operacije.IzmeniUlogu:
                            IzmeniUlogu izmeniUlogu = new IzmeniUlogu();
                            transfer.Rezultat = izmeniUlogu.IzvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;

                        // KRAJ

                        default:
                            break;
                        case Operacije.Kraj:
                            Server.listaTokova.Remove(tok);
                            operacija = 1;
                            break;
                    }
                }
            }

            catch (Exception)
            {
                try
                {
                    Server.listaTokova.Remove(tok);
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }
    }
}
