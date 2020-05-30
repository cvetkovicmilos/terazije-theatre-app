using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace KontrolerAplikacioneLogike
{
    public class Komunikacija
    {
        TcpClient klijent;
        NetworkStream tok;
        BinaryFormatter formater;

        public bool PoveziSeNaServer()
        {
            try
            {
                klijent = new TcpClient("localhost", 10000);
                tok = klijent.GetStream();
                formater = new BinaryFormatter();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public void Kraj()
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.Kraj;
            formater.Serialize(tok, transfer);
        }

        // GLUMAC 

        public int VratiSifruGlumca()
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.VratiSifruGlumca;
            formater.Serialize(tok, transfer);

            transfer = formater.Deserialize(tok) as TransferKlasa;
            return (int)transfer.Rezultat;
        }

        public Object SacuvajGlumca(Glumac g)
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.SacuvajGlumca;
            transfer.TransferObjekat = g;
            formater.Serialize(tok, transfer);

            transfer = formater.Deserialize(tok) as TransferKlasa;
            return transfer.Rezultat;
        }

        public Object IzmeniGlumca(Glumac g)
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.IzmeniGlumca;
            transfer.TransferObjekat = g;
            formater.Serialize(tok, transfer);

            transfer = formater.Deserialize(tok) as TransferKlasa;
            return transfer.Rezultat;
        }

        public Object ObrisiGlumca(Glumac g)
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.ObrisiGlumca;
            transfer.TransferObjekat = g;
            formater.Serialize(tok, transfer);

            transfer = formater.Deserialize(tok) as TransferKlasa;
            return transfer.Rezultat;
        }

        public List<Glumac> VratiSveGlumce()
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.VratiSveGlumce;
            transfer.TransferObjekat = new Glumac();
            formater.Serialize(tok, transfer);

            transfer = formater.Deserialize(tok) as TransferKlasa;
            return transfer.Rezultat as List<Glumac>;
        }

        public List<Glumac> VratiGlumcePoImenu(string pojam)
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.VratiGlumcePoImenu;
            transfer.TransferObjekat = pojam;
            formater.Serialize(tok, transfer);

            transfer = formater.Deserialize(tok) as TransferKlasa;
            return transfer.Rezultat as List<Glumac>;
        }

        public Object RegistrujKorisnika(Korisnik k)
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.RegistrujKorisnika;
            transfer.TransferObjekat = k;
            formater.Serialize(tok, transfer);

            transfer = formater.Deserialize(tok) as TransferKlasa;
            return transfer.Rezultat;
        }

        public Korisnik PrijaviKorisnika(Korisnik k)
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.PrijaviKorisnika;
            transfer.TransferObjekat = k;
            formater.Serialize(tok, transfer);

            transfer = formater.Deserialize(tok) as TransferKlasa;
            return transfer.Rezultat as Korisnik;
        }

        public Object SacuvajZanr(Zanr z)
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.SacuvajZanr;
            transfer.TransferObjekat = z;
            formater.Serialize(tok, transfer);

            transfer = formater.Deserialize(tok) as TransferKlasa;
            return transfer.Rezultat;
        }

        public List<Zanr> VratiSveZanrove()
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.VratiSveZanrove;
            transfer.TransferObjekat = new Zanr();
            formater.Serialize(tok, transfer);

            transfer = formater.Deserialize(tok) as TransferKlasa;
            return transfer.Rezultat as List<Zanr>;
        }

        public List<Predstava> VratiSvePredstave()
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.VratiSvePredstave;
            transfer.TransferObjekat = new Predstava();
            formater.Serialize(tok, transfer);

            transfer = formater.Deserialize(tok) as TransferKlasa;
            return transfer.Rezultat as List<Predstava>;
        }

        public List<Repertoar> VratiSveRepertoare()
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.VratiSveRepertoare;
            transfer.TransferObjekat = new Repertoar();
            formater.Serialize(tok, transfer);

            transfer = formater.Deserialize(tok) as TransferKlasa;
            return transfer.Rezultat as List<Repertoar>;
        }

        public Object SacuvajRepertoar(Repertoar r)
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.SacuvajRepertoar;
            transfer.TransferObjekat = r;
            formater.Serialize(tok, transfer);

            transfer = formater.Deserialize(tok) as TransferKlasa;
            return transfer.Rezultat;
        }

        public List<Izvodjenje> VratiSvaIzvodjenja()
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.VratiSvaIzvodjenja;
            transfer.TransferObjekat = new Izvodjenje();
            formater.Serialize(tok, transfer);

            transfer = formater.Deserialize(tok) as TransferKlasa;
            return transfer.Rezultat as List<Izvodjenje>;
        }

        public List<Repertoar> VratiSveRepertoarePoNazivu(string pojam)
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.VratiRepertoarePoNazivu;
            transfer.TransferObjekat = pojam;
            formater.Serialize(tok, transfer);

            transfer = formater.Deserialize(tok) as TransferKlasa;
            return transfer.Rezultat as List<Repertoar>;
        }

        public Object ObrisiRepertoar(Repertoar r)
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.ObrisiRepertoar;
            transfer.TransferObjekat = r;
            formater.Serialize(tok, transfer);

            transfer = formater.Deserialize(tok) as TransferKlasa;
            return transfer.Rezultat;
        }

        public List<Izvodjenje> VratiSvaIzvodjenjaZaRepertoar(Izvodjenje i)
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.VratiIzvodjenjaZaRepertoar;
            i.uslov = "SifraRepertoara = " + i.Repertoar.SifraRepertoara + " order by Datum asc";
            transfer.TransferObjekat = i;
            formater.Serialize(tok, transfer);

            transfer = formater.Deserialize(tok) as TransferKlasa;
            return transfer.Rezultat as List<Izvodjenje>;
        }

        public List<Izvodjenje> VratiSvaIzvodjenjaZaPredstavu(Izvodjenje i)
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.VratiIzvodjenjaZaPredstavu;
            i.uslov = "SifraPredstave = " + i.Predstava.SifraPredstave + " order by Datum asc";
            transfer.TransferObjekat = i;
            formater.Serialize(tok, transfer);

            transfer = formater.Deserialize(tok) as TransferKlasa;
            return transfer.Rezultat as List<Izvodjenje>;
        }

        public Object SacuvajIzvodjenje(Izvodjenje i)
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.SacuvajIzvodjenje;
            transfer.TransferObjekat = i;
            formater.Serialize(tok, transfer);

            transfer = formater.Deserialize(tok) as TransferKlasa;
            return transfer.Rezultat;
        }

        public Object IzmeniRepertoar(Repertoar r)
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.IzmeniRepertoar;
            transfer.TransferObjekat = r;
            formater.Serialize(tok, transfer);

            transfer = formater.Deserialize(tok) as TransferKlasa;
            return transfer.Rezultat;
        }

        public Object IzmeniIzvodjenje(Izvodjenje i)
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.IzmeniIzvodjenje;
            transfer.TransferObjekat = i;
            formater.Serialize(tok, transfer);

            transfer = formater.Deserialize(tok) as TransferKlasa;
            return transfer.Rezultat;
        }

        public Object ObrisiIzvodjenje(Izvodjenje i)
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.ObrisiIzvodjenje;
            transfer.TransferObjekat = i;
            formater.Serialize(tok, transfer);

            transfer = formater.Deserialize(tok) as TransferKlasa;
            return transfer.Rezultat;
        }

        public Object ObrisiPredstavu(Predstava p)
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.ObrisiPredstavu;
            transfer.TransferObjekat = p;
            formater.Serialize(tok, transfer);

            transfer = formater.Deserialize(tok) as TransferKlasa;
            return transfer.Rezultat;
        }

        public Repertoar VratiRepertoarPoNazivu(string pojam)
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.VratiRepertoarPoNazivu;
            transfer.TransferObjekat = pojam;
            formater.Serialize(tok, transfer);

            transfer = formater.Deserialize(tok) as TransferKlasa;
            return transfer.Rezultat as Repertoar;
        }

        public List<Predstava> VratiPredstavePoNazivu(Predstava p)
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.VratiPredstavePoNazivu;
            p.uslov = "NazivPredstave like '%" + p.NazivPredstave + "%'";
            transfer.TransferObjekat = p;
            formater.Serialize(tok, transfer);

            transfer = formater.Deserialize(tok) as TransferKlasa;
            return transfer.Rezultat as List<Predstava>;
        }

        public List<Zanr> VratiZanroveZaPredstavu(ZanrPredstava zp)
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.VratiZanroveZaPredstavu;
            zp.uslov = "SifraPredstave = " + zp.Predstava.SifraPredstave;
            transfer.TransferObjekat = zp;
            formater.Serialize(tok, transfer);

            transfer = formater.Deserialize(tok) as TransferKlasa;
            return transfer.Rezultat as List<Zanr>;
        }

        public Object SacuvajPredstavu(Predstava p)
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.SacuvajPredstavu;
            transfer.TransferObjekat = p;
            formater.Serialize(tok, transfer);

            transfer = formater.Deserialize(tok) as TransferKlasa;
            return transfer.Rezultat;
        }

        public Object SacuvajZanrPredstavu(ZanrPredstava zp)
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.SacuvajZanrPredstavu;
            transfer.TransferObjekat = zp;
            formater.Serialize(tok, transfer);

            transfer = formater.Deserialize(tok) as TransferKlasa;
            return transfer.Rezultat;
        }

        public Predstava VratiPoslednjeDodatuPredstavu(Predstava p)
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.VratiPoslednjeDodatuPredstavu;
            p.uslov = "SifraPredstave = (Select max(SifraPredstave) from Predstava)";
            transfer.TransferObjekat = p;
            formater.Serialize(tok, transfer);

            transfer = formater.Deserialize(tok) as TransferKlasa;
            return transfer.Rezultat as Predstava;
        }

        public Object SacuvajUlogu(Uloga u)
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.SacuvajUlogeZaPredstavu;
            transfer.TransferObjekat = u;
            formater.Serialize(tok, transfer);

            transfer = formater.Deserialize(tok) as TransferKlasa;
            return transfer.Rezultat;
        }

        public List<Uloga> VratiUlogeZaPredstavu(Uloga u)
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.VratiUlogeZaPredstavu;
            u.uslov = "SifraPredstave = " + u.Predstava.SifraPredstave;
            transfer.TransferObjekat = u;
            formater.Serialize(tok, transfer);

            transfer = formater.Deserialize(tok) as TransferKlasa;
            return transfer.Rezultat as List<Uloga>;
        }

        public Object IzmeniPredstavu(Predstava p)
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.IzmeniPredstavu;
            transfer.TransferObjekat = p;
            formater.Serialize(tok, transfer);

            transfer = formater.Deserialize(tok) as TransferKlasa;
            return transfer.Rezultat;
        }

        public Object ObrisiZanrZaPredstavu(ZanrPredstava zp)
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.ObrisiZanrZaPredstavu;
            zp.uslov = "SifraPredstave = " + zp.Predstava.SifraPredstave;
            transfer.TransferObjekat = zp;
            formater.Serialize(tok, transfer);

            transfer = formater.Deserialize(tok) as TransferKlasa;
            return transfer.Rezultat;
        }

        public Object ObrisiUlogu(Uloga u)
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.ObrisiUlogu;
            transfer.TransferObjekat = u;
            formater.Serialize(tok, transfer);

            transfer = formater.Deserialize(tok) as TransferKlasa;
            return transfer.Rezultat;
        }

        public Object IzmeniUlogu(Uloga u)
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.IzmeniUlogu;
            transfer.TransferObjekat = u;
            formater.Serialize(tok, transfer);

            transfer = formater.Deserialize(tok) as TransferKlasa;
            return transfer.Rezultat;
        }
    }
}
