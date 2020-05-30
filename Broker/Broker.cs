using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Domen;

namespace Sesija
{
    public class Broker
    {
        SqlConnection konekcija;
        SqlCommand komanda;
        SqlTransaction transakcija;

        void KonektujSe()
        {
            konekcija = new SqlConnection(@"Data Source=desktop-md7b0pl;Initial Catalog=SeminarskiRadPozoriste;Integrated Security=True");
            komanda = konekcija.CreateCommand();
        }

        private Broker()
        {
            KonektujSe();
        }

        static Broker instanca;
        public static Broker DajSesiju()
        {
            if (instanca == null)
                instanca = new Broker();
            return instanca;
        }

        public void OtvoriKonekciju()
        {
            try
            {
                konekcija.Open();
            }
            catch (Exception)
            {
                MessageBox.Show("Nije moguce otvoriti konekciju!");
            }
        }

        public void ZatvoriKonekciju()
        {
            try
            {
                konekcija.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Nije moguce zatvoriti konekciju!");
            }
        }

        public void ZapocniTransakciju()
        {
            try
            {
                transakcija = konekcija.BeginTransaction();
            }
            catch (Exception)
            {
                MessageBox.Show("Nije moguce zapoceti transakciju!");
            }
        }

        public void PonistiTransakciju()
        {
            try
            {
                transakcija.Rollback();
            }
            catch (Exception)
            {
                MessageBox.Show("Nije moguce ponistiti transakciju!");
            }
        }

        public void PotvrdiTransakciju()
        {
            try
            {
                transakcija.Commit();
            }
            catch (Exception)
            {
                MessageBox.Show("Nije moguce potvrditi transakciju!");
            }
        }

        // PRIJAVA KORISNIKA

        public Korisnik Prijava(Korisnik k)
        {
            try
            {
                OtvoriKonekciju();
                komanda.CommandText = "Select * from Korisnik where [KorisnickoIme] = '" + k.KorisnickoIme + "' and [Lozinka] = '" + k.Lozinka + "'";
                SqlDataReader citac = komanda.ExecuteReader();

                if (citac.Read())
                {
                    k.KorisnickoIme = citac.GetString(0);
                    k.Email = citac.GetString(1);
                    k.Lozinka = citac.GetString(2);

                    return k;
                }

                citac.Close();
                return null;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if (konekcija != null)
                    ZatvoriKonekciju();
            }
        }

        // REGISTRACIJA KORISNIKA

        public int Registracija(Korisnik k)
        {
            try
            {
                OtvoriKonekciju();
                komanda.CommandText = "Insert into Korisnik values('" + k.KorisnickoIme + "', '" + k.Email + "', '" + k.Lozinka + "')";
                return komanda.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if (konekcija != null)
                    ZatvoriKonekciju();
            }
        }

        // uradjeno DOBIJANJE SIFRE GLUMCA 

        public int VratiSifruGlumca()
        {
            try
            {
                komanda.CommandText = "Select max(SifraGlumca) from Glumac";
                try
                {
                    int sifra = Convert.ToInt32(komanda.ExecuteScalar());
                    return sifra + 1;
                }
                catch (Exception)
                {
                    return 1;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        // uradjeno CUVANJE GLUMCA

        public int SacuvajGlumca(Glumac g)
        {
            try
            {
                OtvoriKonekciju();
                //komanda = konekcija.CreateCommand();
                //int sifra = VratiSifruGlumca();
                //g.SifraGlumca = sifra;
                komanda.Parameters.Clear();
                g.SifraGlumca = VratiSifruGlumca();
                komanda.CommandText = "Insert into Glumac values(@SifraGlumca, @Ime, @Prezime, @Pol, @DatumRodjenja, @RadniStaz)";
                //komanda.CommandText = "Insert into Glumac values(" + g.SifraGlumca + ", '" + g.Ime + "', '" + g.Prezime + "', '" + g.Pol.ToString() + "', '" + DateTime.ParseExact(g.DatumRodjenja.ToString(), "yyyy-MM-dd", null) + "', " + g.RadniStaz + ")";
                komanda.Parameters.AddWithValue("@SifraGlumca", g.SifraGlumca);
                komanda.Parameters.AddWithValue("@Ime", g.Ime);
                komanda.Parameters.AddWithValue("@Prezime", g.Prezime);
                komanda.Parameters.AddWithValue("@Pol", g.Pol.ToString());
                komanda.Parameters.AddWithValue("@DatumRodjenja", g.DatumRodjenja);
                komanda.Parameters.AddWithValue("@RadniStaz", g.RadniStaz);
                return komanda.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if (konekcija != null)
                    ZatvoriKonekciju();
            }
        }

        // uradjeno DOBIJANJE SVIH GLUMACA

        public List<Glumac> VratiSveGlumce()
        {
            List<Glumac> glumci = new List<Glumac>();

            try
            {
                OtvoriKonekciju();
                komanda.CommandText = "Select * from Glumac";
                SqlDataReader citac = komanda.ExecuteReader();

                while(citac.Read())
                {
                    Glumac g = new Glumac();
                    g.SifraGlumca = citac.GetInt32(0);
                    g.Ime = citac.GetString(1);
                    g.Prezime = citac.GetString(2);
                    g.Pol = (Pol)Enum.Parse(typeof(Pol), citac.GetString(3));
                    g.DatumRodjenja = citac.GetDateTime(4);
                    g.RadniStaz = citac.GetDouble(5);
                    glumci.Add(g);
                }
                citac.Close();
                return glumci;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if (konekcija != null)
                    ZatvoriKonekciju();
            }
        }

        // uradjeno IZMENA GLUMCA

        public int IzmeniGlumca(Glumac g)
        {
            try
            {
                OtvoriKonekciju();
                komanda.Parameters.Clear();
                komanda.CommandText = "Update Glumac Set Ime = @Ime, Prezime = @Prezime, Pol = @Pol, DatumRodjenja = @DatumRodjenja, RadniStaz = @RadniStaz " +
                    "Where [SifraGlumca] = " + g.SifraGlumca + "";
                komanda.Parameters.AddWithValue("@Ime", g.Ime);
                komanda.Parameters.AddWithValue("@Prezime", g.Prezime);
                komanda.Parameters.AddWithValue("@Pol", g.Pol.ToString());
                komanda.Parameters.AddWithValue("@DatumRodjenja", g.DatumRodjenja);
                komanda.Parameters.AddWithValue("@RadniStaz", g.RadniStaz);
                return komanda.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if (konekcija != null)
                    ZatvoriKonekciju();
            }
        }

        // uradjeno BRISANJE GLUMCA

        public int ObrisiGlumca(Glumac g)
        {
            try
            {
                OtvoriKonekciju();
                komanda.Parameters.Clear();
                komanda.CommandText = "Delete From Glumac Where SifraGlumca = @SifraGlumca";
                komanda.Parameters.AddWithValue("@SifraGlumca", g.SifraGlumca);
                return komanda.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if (konekcija != null)
                    ZatvoriKonekciju();
            }
        }

        // PRETRAGA GLUMACA PO IMENU

        public List<Glumac> PretragaGlumacaPoImenu(string pojam)
        {
            List<Glumac> glumci = new List<Glumac>();

            try
            {
                OtvoriKonekciju();
                komanda.CommandText = "Select * from Glumac where Ime like '"+pojam+"%'";
                SqlDataReader citac = komanda.ExecuteReader();

                while (citac.Read())
                {
                    Glumac g = new Glumac();
                    g.SifraGlumca = citac.GetInt32(0);
                    g.Ime = citac.GetString(1);
                    g.Prezime = citac.GetString(2);
                    g.Pol = (Pol)Enum.Parse(typeof(Pol), citac.GetString(3));
                    g.DatumRodjenja = citac.GetDateTime(4);
                    g.RadniStaz = citac.GetDouble(5);
                    glumci.Add(g);
                }
                citac.Close();
                return glumci;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if (konekcija != null)
                    ZatvoriKonekciju();
            }
        }

        // DOBIJANJE SIFRE PREDSTAVE

        public int VratiSifruPredstave()
        {
            try
            {
                komanda.CommandText = "Select max(SifraPredstave) from Predstava";
                try
                {
                    int sifra = Convert.ToInt32(komanda.ExecuteScalar());
                    return sifra + 1;
                }
                catch (Exception)
                {
                    return 1;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        // CUVANJE PREDSTAVE

        public bool SacuvajPredstavu(Predstava p, List<Zanr> lista)
        {
            try
            {
                OtvoriKonekciju();
                //komanda.Parameters.Clear();
                p.SifraPredstave = VratiSifruPredstave();
                //komanda.CommandText = "Insert into Predstava values(@SifraPredstave, @NazivPredstave, @DatumPostavljanja, @BrojGlumaca, @Reditelj);" +
                //                      "Insert into ZanrPredstava values(@SifraZanra, @SifraPredstave)";
                //komanda.Parameters.AddWithValue("@SifraPredstave", p.SifraPredstave);
                //komanda.Parameters.AddWithValue("@NazivPredstave", p.NazivPredstave);
                //komanda.Parameters.AddWithValue("@DatumPostavljanja", p.DatumPostavljanja);
                //komanda.Parameters.AddWithValue("@BrojGlumaca", p.BrojGlumaca);
                //komanda.Parameters.AddWithValue("@Reditelj", p.Reditelj);
                //komanda.Parameters.AddWithValue("@SifraZanra", z.SifraZanra);
                komanda.CommandText = "Insert into Predstava values(" + p.SifraPredstave + ", '" + p.NazivPredstave + "', '" + p.DatumPostavljanja.ToString("yyyy-MM-dd") + "', " + p.BrojGlumaca + ", '" + p.Reditelj + "')";
                komanda.ExecuteNonQuery();
                foreach (Zanr z in lista)
                {
                    komanda.CommandText = "Insert into ZanrPredstava values(" + z.SifraZanra + ", " + p.SifraPredstave + ")";
                    komanda.ExecuteNonQuery();
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                if (konekcija != null)
                    ZatvoriKonekciju();
            }
        }

        // IZMENA PREDSTAVE

        public bool IzmeniPredstavu(Predstava p, List<Zanr> lista)
        {
            try
            {
                OtvoriKonekciju();
                komanda.Parameters.Clear();
                //p.SifraPredstave = VratiSifruPredstave();
                //komanda.CommandText = "Update Predstava set NazivPredstave = @NazivPredstave, " +
                //                      "DatumPostavljanja = @DatumPostavljanja, BrojGlumaca = @BrojGlumaca, Reditelj = @Reditelj" +
                //                      "where SifraPredstave = " + p.NazivPredstave + ";" +
                //                      "Insert into ZanrPredstava values(@SifraZanra, @SifraPredstave)";
                komanda.CommandText = "Update Predstava set NazivPredstave = '" + p.NazivPredstave + "', DatumPostavljanja = '" + p.DatumPostavljanja.ToString("yyyy-MM-dd") + "', BrojGlumaca = " + p.BrojGlumaca + ", Reditelj = '" + p.Reditelj + "' where SifraPredstave = " + p.SifraPredstave + "; Delete from ZanrPredstava where SifraPredstave = " + p.SifraPredstave;
                komanda.ExecuteNonQuery();
                foreach (Zanr z in lista)
                {
                    komanda.CommandText = "Insert into ZanrPredstava values(" + z.SifraZanra + ", " + p.SifraPredstave + ")";
                }
                //komanda.Parameters.AddWithValue("@NazivPredstave", p.NazivPredstave);
                //komanda.Parameters.AddWithValue("@DatumPostavljanja", p.DatumPostavljanja);
                //komanda.Parameters.AddWithValue("@BrojGlumaca", p.BrojGlumaca);
                //komanda.Parameters.AddWithValue("@Reditelj", p.Reditelj);
                //komanda.Parameters.AddWithValue("@SifraZanra", z.SifraZanra);
                komanda.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                if (konekcija != null)
                    ZatvoriKonekciju();
            }
        }

        // IZMENA ULOGA

        public int IzmenaUlogeUPredstavi(Uloga u)
        {
            try
            {
                OtvoriKonekciju();
                komanda.CommandText = "Update Uloga set Naziv = '" + u.Naziv + "', Tip = '" + u.Tip + "', SifraGlumca = " + u.Glumac.SifraGlumca + " where SifraUloge = " + u.SifraUloge;
                return komanda.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if (konekcija != null)
                    ZatvoriKonekciju();
            }
        }

        // DOBIJANJE SVIH PREDSTAVA

        public List<Predstava> VratiSvePredstave()
        {
            List<Predstava> listaPredstava = new List<Predstava>();

            try
            {
                OtvoriKonekciju();
                komanda.CommandText = "Select * from Predstava";
                SqlDataReader citac = komanda.ExecuteReader();

                while (citac.Read())
                {
                    Predstava p = new Predstava();
                    p.SifraPredstave = citac.GetInt32(0);
                    p.NazivPredstave = citac.GetString(1);
                    p.DatumPostavljanja = citac.GetDateTime(2);
                    p.BrojGlumaca = citac.GetInt32(3);
                    p.Reditelj = citac.GetString(4);
                    listaPredstava.Add(p);
                }

                citac.Close();
                return listaPredstava;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if (konekcija != null)
                    ZatvoriKonekciju();
            }
        }

        // DOBIJANJE SIFRE ULOGE

        public int VratiSifruUloge()
        {
            try
            {
                komanda.CommandText = "Select max(SifraUloge) from Uloga";
                try
                {
                    int sifra = Convert.ToInt32(komanda.ExecuteScalar());
                    return sifra + 1;
                }
                catch (Exception)
                {
                    return 1;
                }
            }
            catch (Exception)
            {

                throw;
            }
            
        }
        
        // CUVANJE ULOGE

        public int SacuvajUloge(List<Uloga> listaUloga, int brojGlumaca)
        {
            try
            {
                OtvoriKonekciju();
                ZapocniTransakciju();
                komanda = new SqlCommand("", konekcija, transakcija);

                foreach (Uloga u in listaUloga)
                {
                    komanda.Parameters.Clear();
                    u.SifraUloge = VratiSifruUloge();
                    komanda.CommandText = "Insert into Uloga values(@SifraUloge, @SifraPredstave, @Naziv, @Tip, @SifraGlumca);" +
                                          "Update Predstava Set BrojGlumaca = @BrojGlumaca where [SifraPredstave] = " + u.Predstava.SifraPredstave;
                    komanda.Parameters.AddWithValue("@SifraUloge", u.SifraUloge);
                    komanda.Parameters.AddWithValue("@SifraPredstave", u.Predstava.SifraPredstave);
                    komanda.Parameters.AddWithValue("@Naziv", u.Naziv);
                    komanda.Parameters.AddWithValue("@Tip", u.Tip);
                    komanda.Parameters.AddWithValue("@SifraGlumca", u.Glumac.SifraGlumca);
                    komanda.Parameters.AddWithValue("@BrojGlumaca", brojGlumaca);
                    komanda.ExecuteNonQuery();
                }

                PotvrdiTransakciju();
                return 1;
            }
            catch (Exception)
            {
                PonistiTransakciju();
                throw;
            }
            finally
            {
                if (konekcija != null)
                    ZatvoriKonekciju();
            }
        }

        // BRISANJE ULOGE

        public int ObrisiUlogu(Uloga u, Predstava p)
        {
            try
            {
                OtvoriKonekciju();
                komanda.Parameters.Clear();
                komanda.CommandText = "Delete From Uloga Where SifraUloge = " + u.SifraUloge + "; Update Predstava Set BrojGlumaca = " + p.BrojGlumaca + "-1 where SifraPredstave = " + p.SifraPredstave;
                return komanda.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if (konekcija != null)
                    ZatvoriKonekciju();
            }
        }

        // DOBIJANJE POSLEDNJE DODATE PREDSTAVE

        public Predstava VratiPoslednjeDodatuPredstavu()
        {
            Predstava p = new Predstava();

            try
            {
                OtvoriKonekciju();
                komanda.CommandText = "Select * from Predstava where SifraPredstave = (Select max(SifraPredstave) from Predstava)";
                SqlDataReader citac = komanda.ExecuteReader();

                while (citac.Read())
                {
                    p.SifraPredstave = citac.GetInt32(0);
                    p.NazivPredstave = citac.GetString(1);
                    p.DatumPostavljanja = citac.GetDateTime(2);
                    p.BrojGlumaca = citac.GetInt32(3);
                    p.Reditelj = citac.GetString(4);
                }
                citac.Close();
                return p;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if (konekcija != null)
                    ZatvoriKonekciju();
            }
        }

        // BRISANJE PREDSTAVE

        public int ObrisiPredstavu(Predstava p)
        {
            try
            {
                OtvoriKonekciju();
                komanda.Parameters.Clear();
                komanda.CommandText = "Delete From Predstava Where SifraPredstave = @SifraPredstave";
                komanda.Parameters.AddWithValue("@SifraPredstave", p.SifraPredstave);
                return komanda.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if (konekcija != null)
                    ZatvoriKonekciju();
            }
        }

        // PRETRAGA PREDSTAVA PO NAZIVU

        public List<Predstava> PretragaPredstavaPoNazivu(string pojam)
        {
            List<Predstava> predstave = new List<Predstava>();

            try
            {
                OtvoriKonekciju();
                komanda.CommandText = "Select * from Predstava where NazivPredstave like '%" + pojam + "%'";
                SqlDataReader citac = komanda.ExecuteReader();

                while (citac.Read())
                {
                    Predstava p = new Predstava();
                    p.SifraPredstave = citac.GetInt32(0);
                    p.NazivPredstave = citac.GetString(1);
                    p.DatumPostavljanja = citac.GetDateTime(2);
                    p.BrojGlumaca = citac.GetInt32(3);
                    p.Reditelj = citac.GetString(4);
                    predstave.Add(p);
                }
                citac.Close();
                return predstave;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if (konekcija != null)
                    ZatvoriKonekciju();
            }
        }

        // DOBIJANJE SVIH ULOGA ZA IZABRANU PREDSTAVU

        public List<Uloga> VratiSveUlogeZaPredstavu(Predstava predstava)
        {
            List<Uloga> uloge = new List<Uloga>();

            try
            {
                OtvoriKonekciju();
                komanda.CommandText = "Select u.SifraUloge, u.Naziv, u.Tip, g.Ime, g.Prezime from Uloga u join Glumac g on (g.SifraGlumca = u.SifraGlumca) where SifraPredstave = " + predstava.SifraPredstave + "";
                SqlDataReader citac = komanda.ExecuteReader();

                int sifraGlumca;

                while (citac.Read())
                {
                    Uloga u = new Uloga();
                    u.SifraUloge = citac.GetInt32(0);
                    u.Predstava = predstava;
                    u.Naziv = citac.GetString(1);
                    u.Tip = citac.GetString(2);
                    u.Glumac = new Glumac
                    {
                        Ime = citac.GetString(3),
                        Prezime = citac.GetString(4)
                    };
                    uloge.Add(u);
                }
                citac.Close();
                return uloge;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if (konekcija != null)
                    ZatvoriKonekciju();
            }
        }

        // DOBIJANJE SIFRE ZANRA

        public int VratiSifruZanra()
        {
            try
            {
                komanda.CommandText = "Select max(SifraZanra) from Zanr";
                try
                {
                    int sifra = Convert.ToInt32(komanda.ExecuteScalar());
                    return sifra + 1;
                }
                catch (Exception)
                {
                    return 1;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        // CUVANJE ZANRA

        public int SacuvajZanr(Zanr z)
        {
            try
            {
                OtvoriKonekciju();
                komanda.Parameters.Clear();
                z.SifraZanra = VratiSifruZanra();
                komanda.CommandText = "Insert into Zanr values(@SifraZanra, @Naziv)";
                komanda.Parameters.AddWithValue("@SifraZanra", z.SifraZanra);
                komanda.Parameters.AddWithValue("@Naziv", z.Naziv);
                return komanda.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if (konekcija != null)
                    ZatvoriKonekciju();
            }
        }

        // DOBIJANJE SVIH ZANROVA

        public List<Zanr> VratiSveZanrove()
        {
            List<Zanr> listaZanrova = new List<Zanr>();

            try
            {
                OtvoriKonekciju();
                komanda.CommandText = "Select * from Zanr";
                SqlDataReader citac = komanda.ExecuteReader();

                while (citac.Read())
                {
                    Zanr z = new Zanr();
                    z.SifraZanra = citac.GetInt32(0);
                    z.Naziv = citac.GetString(1);
                    listaZanrova.Add(z);
                }

                citac.Close();
                return listaZanrova;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if (konekcija != null)
                    ZatvoriKonekciju();
            }
        }

        // DOBIJANJE ZANRA ZA PREDSTAVU

        public List<Zanr> VratiZanrZaOdredjenuPredstavu(Predstava p)
        {
            List<Zanr> listaZanrova = new List<Zanr>();

            try
            {
                OtvoriKonekciju();
                komanda.CommandText = "Select z.* from Zanr z join ZanrPredstava zp on (z.SifraZanra = zp.SifraZanra) " +
                                      "join Predstava p on (p.SifraPredstave = zp.SifraPredstave) where p.SifraPredstave = " + p.SifraPredstave;
                SqlDataReader citac = komanda.ExecuteReader();

                while (citac.Read())
                {
                    Zanr z = new Zanr();
                    z.SifraZanra = citac.GetInt32(0);
                    z.Naziv = citac.GetString(1);
                    listaZanrova.Add(z);
                }
                return listaZanrova;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if (konekcija != null)
                    ZatvoriKonekciju();
            }
        }

        // KREIRANJE REPERTOARA

        public int SacuvajRepertoar(Repertoar r)
        {
            try
            {
                OtvoriKonekciju();
                komanda.Parameters.Clear();
                r.SifraRepertoara = VratiSifruRepertoara();
                komanda.CommandText = "Insert into Repertoar values(@SifraRepertoara, @NazivRepertoara, @DatumVazenjaOd, @DatumVazenjaDo)";
                komanda.Parameters.AddWithValue("@SifraRepertoara", r.SifraRepertoara);
                komanda.Parameters.AddWithValue("@NazivRepertoara", r.NazivRepertoara);
                komanda.Parameters.AddWithValue("@DatumVazenjaOd", r.DatumVazenjaOd);
                komanda.Parameters.AddWithValue("@DatumVazenjaDo", r.DatumVazenjaDo);
                return komanda.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if (konekcija != null)
                    ZatvoriKonekciju();
            }
        }

        // DOBIJANJE SIFRE REPERTOARA

        private int VratiSifruRepertoara()
        {
            try
            {
                komanda.CommandText = "Select max(SifraRepertoara) from Repertoar";
                try
                {
                    int sifra = Convert.ToInt32(komanda.ExecuteScalar());
                    return sifra + 1;
                }
                catch (Exception)
                {
                    return 1;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        // DOBIJANJE REDNOG BROJA IZVODJENJA

        private int VratiRedniBrojStavkeRepertoara()
        {
            try
            {
                komanda.CommandText = "Select max(RedniBroj) from StavkaRepertoara";
                try
                {
                    int sifra = Convert.ToInt32(komanda.ExecuteScalar());
                    return sifra + 1;
                }
                catch (Exception)
                {
                    return 1;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private int VratiRedniBrojIzvodjenja()
        {
            try
            {
                komanda.CommandText = "Select max(RedniBroj) from Izvodjenje";
                try
                {
                    int sifra = Convert.ToInt32(komanda.ExecuteScalar());
                    return sifra + 1;
                }
                catch (Exception)
                {
                    return 1;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        // CUVANJE SVIH IZVODJENJA

        public int SacuvajSvaIzvodjenja(List<Izvodjenje> listaIzvodjenja)
        {
            try
            {
                OtvoriKonekciju();
                ZapocniTransakciju();
                komanda = new SqlCommand("", konekcija, transakcija);

                foreach(Izvodjenje i in listaIzvodjenja)
                {
                    komanda.Parameters.Clear();
                    i.RedniBroj = VratiRedniBrojIzvodjenja();
                    komanda.CommandText = "Insert into Izvodjenje values(@SifraPredstave, @SifraRepertoara, @RedniBroj, @Datum)";

                    komanda.Parameters.AddWithValue("@SifraPredstave", i.Predstava.SifraPredstave);
                    komanda.Parameters.AddWithValue("@SifraRepertoara", i.Repertoar.SifraRepertoara);
                    komanda.Parameters.AddWithValue("@RedniBroj", i.RedniBroj);
                    komanda.Parameters.AddWithValue("@Datum", i.Datum);                     
                    komanda.ExecuteNonQuery();
                }

                PotvrdiTransakciju();
                return 1;
            }
            catch (Exception)
            {
                PonistiTransakciju();
                throw;
            } 
            finally
            {
                if (konekcija != null)
                {
                    ZatvoriKonekciju();
                }
            }
        }

        // VRATI SVE REPERTOARE

        public List<Repertoar> VratiSveRepertoare()
        {
            List<Repertoar> listaRepertoara = new List<Repertoar>();

            try
            {
                OtvoriKonekciju();
                komanda.CommandText = "Select * from Repertoar";
                SqlDataReader citac = komanda.ExecuteReader();

                while (citac.Read())
                {
                    Repertoar r = new Repertoar();
                    r.SifraRepertoara = citac.GetInt32(0);
                    r.NazivRepertoara = citac.GetString(1);
                    r.DatumVazenjaOd = citac.GetDateTime(2);
                    r.DatumVazenjaDo = citac.GetDateTime(3);
                    listaRepertoara.Add(r);
                }

                citac.Close();
                return listaRepertoara;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if (konekcija != null)
                    ZatvoriKonekciju();
            }
        }

        // IZMENA REPERTOARA

        public bool IzmenaRepertoara(Repertoar r)
        {
            try
            {
                konekcija.Open();
                komanda.CommandText = "Update Repertoar set NazivRepertoara = '" + r.NazivRepertoara + "', DatumVazenjaOd = '" + r.DatumVazenjaOd.ToString("yyyy-MM-dd") + "', DatumVazenjaDo = '" + r.DatumVazenjaDo.ToString("yyyy-MM-dd") + "' where SifraRepertoara = " + r.SifraRepertoara;
                komanda.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                if (konekcija != null)
                    ZatvoriKonekciju();
            }
        }

        // PRETRAGA REPERTOARA PO NAZIVU

        public List<Repertoar> PretragaRepertoaraPoNazivu(string pojam)
        {
            List<Repertoar> listaRepertoara = new List<Repertoar>();

            try
            {
                OtvoriKonekciju();
                komanda.CommandText = "Select * from Repertoar where NazivRepertoara like '%" + pojam + "%'";
                SqlDataReader citac = komanda.ExecuteReader();

                while (citac.Read())
                {
                    Repertoar r = new Repertoar();
                    r.SifraRepertoara = citac.GetInt32(0);
                    r.NazivRepertoara = citac.GetString(1);
                    r.DatumVazenjaOd = citac.GetDateTime(2);
                    r.DatumVazenjaDo = citac.GetDateTime(3);
                    listaRepertoara.Add(r);
                }

                citac.Close();
                return listaRepertoara;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if (konekcija != null)
                    ZatvoriKonekciju();
            }
        }

        // VRATI SVA IZVODJENJA

        public List<Izvodjenje> VratiSvaIzvodjenja()
        {
            List<Izvodjenje> izvodjenja = new List<Izvodjenje>();

            try
            {
                OtvoriKonekciju();
                komanda.CommandText = "Select i.SifraPredstave, p.NazivPredstave, i.SifraRepertoara, r.NazivRepertoara, i.RedniBroj, i.Datum from Izvodjenje i join Repertoar r on r.SifraRepertoara = i.SifraRepertoara join Predstava p on p.SifraPredstave = i.SifraPredstave";

                SqlDataReader citac = komanda.ExecuteReader();

                while (citac.Read())
                {
                    Izvodjenje i = new Izvodjenje();
                    i.Predstava = new Predstava();
                    i.Predstava.SifraPredstave = citac.GetInt32(0);
                    i.Predstava.NazivPredstave = citac.GetString(1);
                    i.Repertoar = new Repertoar();
                    i.Repertoar.SifraRepertoara = citac.GetInt32(2);
                    i.Repertoar.NazivRepertoara = citac.GetString(3);
                    i.RedniBroj = citac.GetInt32(4);
                    try
                    {
                        i.Datum = citac.GetDateTime(5);
                    }
                    catch (Exception)
                    {

                        throw;
                    }
                    izvodjenja.Add(i);
                }
                citac.Close();
                return izvodjenja;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if (konekcija != null)
                    ZatvoriKonekciju();
            }
        }

        List<Izvodjenje> VratiIzvodjenjaPoUslovu(Predstava p, Repertoar r)
        {
            List<Izvodjenje> lista = new List<Izvodjenje>();
            string uslov = "";

            try
            {
                OtvoriKonekciju();
                if (p != null)
                {
                    uslov += " join Predstava p on p.SifraPredstave = i.SifraPredstave where p.SifraPredstave = " + p.SifraPredstave;
                }
                if (r != null)
                {
                    uslov += " join Repertoar r on r.SifraRepertoara = i.SifraRepertoara where r.SifraRepertoara = " + r.SifraRepertoara;
                }
                komanda.CommandText = "Select i.SifraPredstave, i.SifraRepertoara, i.RedniBroj, i.Datum from Izvodjenje i" + uslov;
                SqlDataReader citac = komanda.ExecuteReader();

                while (citac.Read())
                {
                    Izvodjenje i = new Izvodjenje();
                    i.Predstava = new Predstava();
                    i.Predstava.SifraPredstave = citac.GetInt32(0);
                    i.Repertoar = new Repertoar();
                    i.Repertoar.SifraRepertoara = citac.GetInt32(1);
                    i.RedniBroj = citac.GetInt32(2);
                    try
                    {
                        i.Datum = citac.GetDateTime(3);
                    }
                    catch (Exception)
                    {

                        throw;
                    }
                    lista.Add(i);
                }

                citac.Close();
                return lista;
                
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if (konekcija != null)
                    ZatvoriKonekciju();
            }
        }

        // VRATI IZVODJENJA ZA REPERTOAR

        public List<Izvodjenje> VratiIzvodjenjaZaRepertoar(Repertoar r)
        {
            List<Izvodjenje> lista = new List<Izvodjenje>();

            try
            {
                OtvoriKonekciju();
                komanda.CommandText = "Select i.SifraPredstave, p.NazivPredstave, i.SifraRepertoara, r.NazivRepertoara, i.RedniBroj, i.Datum from Izvodjenje i join Repertoar r on r.SifraRepertoara = i.SifraRepertoara join Predstava p on p.SifraPredstave = i.SifraPredstave " +
                    "where r.SifraRepertoara = " + r.SifraRepertoara;
                SqlDataReader citac = komanda.ExecuteReader();
                while (citac.Read())
                {
                    Izvodjenje i = new Izvodjenje();
                    i.Predstava = new Predstava();
                    i.Predstava.SifraPredstave = citac.GetInt32(0);
                    i.Predstava.NazivPredstave = citac.GetString(1);
                    i.Repertoar = new Repertoar();
                    i.Repertoar.SifraRepertoara = citac.GetInt32(2);
                    i.Repertoar.NazivRepertoara = citac.GetString(3);
                    i.RedniBroj = citac.GetInt32(4);
                    try
                    {
                        i.Datum = citac.GetDateTime(5);
                    }
                    catch (Exception)
                    {

                        throw;
                    }
                    lista.Add(i);
                }
                citac.Close();
                return lista;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if (konekcija != null)
                    ZatvoriKonekciju();
            }
        }

        // BRISANJE REPERTOARA

        public int ObrisiRepertoar(Repertoar r)
        {
            try
            {
                OtvoriKonekciju();
                komanda.Parameters.Clear();
                komanda.CommandText = "Delete From Repertoar Where SifraRepertoara = @SifraRepertoara";
                komanda.Parameters.AddWithValue("@SifraRepertoara", r.SifraRepertoara);
                return komanda.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if (konekcija != null)
                    ZatvoriKonekciju();
            }
        }

        // VRATI IZVODJENJA ZA REPERTOAR

        // VRATI IZVODJENJA ZA PREDSTAVU

        public List<Izvodjenje> VratiIzvodjenjaZaPredstavu(Predstava p)
        {
            List<Izvodjenje> lista = new List<Izvodjenje>();

            try
            {
                OtvoriKonekciju();
                komanda.CommandText = "Select i.SifraPredstave, p.NazivPredstave, i.SifraRepertoara, r.NazivRepertoara, i.RedniBroj, i.Datum from Izvodjenje i join Repertoar r on r.SifraRepertoara = i.SifraRepertoara join Predstava p on p.SifraPredstave = i.SifraPredstave " +
                    "where p.SifraPredstave = " + p.SifraPredstave;
                SqlDataReader citac = komanda.ExecuteReader();
                while (citac.Read())
                {
                    Izvodjenje i = new Izvodjenje();
                    i.Predstava = new Predstava();
                    i.Predstava.SifraPredstave = citac.GetInt32(0);
                    i.Predstava.NazivPredstave = citac.GetString(1);
                    i.Repertoar = new Repertoar();
                    i.Repertoar.SifraRepertoara = citac.GetInt32(2);
                    i.Repertoar.NazivRepertoara = citac.GetString(3);
                    i.RedniBroj = citac.GetInt32(4);
                    try
                    {
                        i.Datum = citac.GetDateTime(5);
                    }
                    catch (Exception)
                    {

                        throw;
                    }
                    lista.Add(i);
                }
                citac.Close();
                return lista;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if (konekcija != null)
                    ZatvoriKonekciju();
            }
        }

        // VRATI IZVODJENJA ZA REPERTOAR I PREDSTAVU

        public List<Izvodjenje> VratiIzvodjenjaZaPredstavuIRepertoar(Predstava p, Repertoar r)
        {
            List<Izvodjenje> lista = new List<Izvodjenje>();

            try
            {
                OtvoriKonekciju();
                komanda.CommandText = "Select i.SifraPredstave, p.NazivPredstave, i.SifraRepertoara, r.NazivRepertoara, i.RedniBroj, i.Datum from Izvodjenje i join Repertoar r on r.SifraRepertoara = i.SifraRepertoara join Predstava p on p.SifraPredstave = i.SifraPredstave " +
                    "where p.SifraPredstave = " + p.SifraPredstave + " and r.SifraRepertoara = " + r.SifraRepertoara;
                SqlDataReader citac = komanda.ExecuteReader();
                while (citac.Read())
                {
                    Izvodjenje i = new Izvodjenje();
                    i.Predstava = new Predstava();
                    i.Predstava.SifraPredstave = citac.GetInt32(0);
                    i.Predstava.NazivPredstave = citac.GetString(1);
                    i.Repertoar = new Repertoar();
                    i.Repertoar.SifraRepertoara = citac.GetInt32(2);
                    i.Repertoar.NazivRepertoara = citac.GetString(3);
                    i.RedniBroj = citac.GetInt32(4);
                    try
                    {
                        i.Datum = citac.GetDateTime(5);
                    }
                    catch (Exception)
                    {

                        throw;
                    }
                    lista.Add(i);
                }
                citac.Close();
                return lista;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if (konekcija != null)
                    ZatvoriKonekciju();
            }
        }

        // IZMENA IZVODJENJA

        public bool IzmeniIzvodjenje(Izvodjenje i)
        {
            try
            {
                konekcija.Open();
                komanda.CommandText = "Update Izvodjenje set Datum = '" + i.Datum.ToString("yyyy-MM-dd") + "' where RedniBroj = " + i.RedniBroj;
                komanda.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                if (konekcija != null)
                    ZatvoriKonekciju();
            }
        }

        // BRISANJE IZVODJENJA

        public bool ObrisiIzvodjenje(Izvodjenje i)
        {
            try
            {
                konekcija.Open();
                komanda.CommandText = "Delete from Izvodjenje where RedniBroj = " + i.RedniBroj;
                komanda.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                if (konekcija != null)
                    ZatvoriKonekciju();
            }
        }

        // vrati se na dodavanje zanrova, zavrsi izmenu i brisanje repertoara, kao i na izmenu predstave i to je to
        // sredi dgw kako se prikazuju nazivi redova, sredi i stavku repertoara
    
    
        // GENERICKI BROKER

        public List<OpstiDomenskiObjekat> VratiSve(OpstiDomenskiObjekat odo)
        {
            string upit = "Select * from " + odo.tabela;
            SqlDataReader citac = null;
            SqlCommand komanda = new SqlCommand(upit, konekcija, transakcija);

            try
            {
                citac = komanda.ExecuteReader();
                DataTable tabela = new DataTable();
                tabela.Load(citac);
                List<OpstiDomenskiObjekat> lista = new List<OpstiDomenskiObjekat>();
                
                foreach (DataRow red in tabela.Rows)
                {
                    OpstiDomenskiObjekat pom = odo.Napuni(red);
                    lista.Add(pom);
                }

                return lista;
            }
            catch (Exception)
            {
                throw new Exception("Greska u radu sa bazom!");
            }
            finally
            {
                if (citac != null)
                {
                    citac.Close();
                }
            }
        }
    
        public OpstiDomenskiObjekat VratiZaUslovJedan(OpstiDomenskiObjekat odo)
        {
            string upit = "Select * from " + odo.tabela + " where " + odo.uslovJedan;
            SqlDataReader citac = null;
            SqlCommand komanda = new SqlCommand(upit, konekcija, transakcija);

            try
            {
                citac = komanda.ExecuteReader();
                DataTable tabela = new DataTable();
                tabela.Load(citac);
                DataRow red;
                if (tabela.Rows.Count == 0)
                {
                    return null;
                }
                else
                {
                    red = tabela.Rows[0];
                }

                return odo.Napuni(red);
            }
            catch (Exception)
            {
                throw new Exception("Greska u radu sa bazom!");
            }
            finally
            {
                if (citac != null)
                {
                    citac.Close();
                }
            }
        }

        public OpstiDomenskiObjekat VratiZaUslovVise(OpstiDomenskiObjekat odo)
        {
            string upit = "Select * from " + odo.tabela + " where " + odo.uslovVise;
            SqlDataReader citac = null;
            SqlCommand komanda = new SqlCommand(upit, konekcija, transakcija);

            try
            {
                citac = komanda.ExecuteReader();
                DataTable tabela = new DataTable();
                tabela.Load(citac);
                DataRow red;
                if (tabela.Rows.Count == 0)
                {
                    return null;
                }
                else
                {
                    red = tabela.Rows[0];
                }

                return odo.Napuni(red);
            }
            catch (Exception)
            {
                throw new Exception("Greska u radu sa bazom!");
            }
            finally
            {
                if (citac != null)
                {
                    citac.Close();
                }
            }
        }

        public List<OpstiDomenskiObjekat> VratiSveZaUslovVise(OpstiDomenskiObjekat odo)
        {
            string upit = "Select * from " + odo.tabela + " where " + odo.uslovVise;
            SqlDataReader citac = null;
            SqlCommand komanda = new SqlCommand(upit, konekcija, transakcija);

            try
            {
                citac = komanda.ExecuteReader();
                DataTable tabela = new DataTable();
                tabela.Load(citac);
                List<OpstiDomenskiObjekat> lista = new List<OpstiDomenskiObjekat>();
                
                foreach (DataRow red in tabela.Rows)
                {
                    OpstiDomenskiObjekat pom = odo.Napuni(red);
                    lista.Add(pom);
                }

                return lista;
            }
            catch (Exception)
            {
                throw new Exception("Greska u radu sa bazom!");
            }
            finally
            {
                if (citac != null)
                {
                    citac.Close();
                }
            }
        }

        public List<OpstiDomenskiObjekat> VratiSveZaUslovJedan(OpstiDomenskiObjekat odo)
        {
            string upit = "Select * from " + odo.tabela + " where " + odo.uslovJedan;
            SqlDataReader citac = null;
            SqlCommand komanda = new SqlCommand(upit, konekcija, transakcija);

            try
            {
                citac = komanda.ExecuteReader();
                DataTable tabela = new DataTable();
                tabela.Load(citac);
                List<OpstiDomenskiObjekat> lista = new List<OpstiDomenskiObjekat>();

                foreach (DataRow red in tabela.Rows)
                {
                    OpstiDomenskiObjekat pom = odo.Napuni(red);
                    lista.Add(pom);
                }

                return lista;
            }
            catch (Exception)
            {
                throw new Exception("Greska u radu sa bazom!");
            }
            finally
            {
                if (citac != null)
                {
                    citac.Close();
                }
            }
        }

        public int Sacuvaj(OpstiDomenskiObjekat odo)
        {
            string upit = "Insert into " + odo.tabela + " values " + odo.upisivanje;
            SqlCommand komanda = new SqlCommand(upit, konekcija, transakcija);

            try
            {
                return komanda.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw new Exception("Greska u radu sa bazom!");
            }
        }

        public int Izmeni(OpstiDomenskiObjekat odo)
        {
            string upit = "Update " + odo.tabela + " set " + odo.azuriranje + " where " + odo.uslovJedan;
            SqlCommand komanda = new SqlCommand(upit, konekcija, transakcija);

            try
            {
                return komanda.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw new Exception("Greska u radu sa bazom!");
            }
        }

        public int Obrisi(OpstiDomenskiObjekat odo)
        {
            string upit = "Delete from " + odo.tabela + " where " + odo.uslovJedan;
            SqlCommand komanda = new SqlCommand(upit, konekcija, transakcija);

            try
            {
                return komanda.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw new Exception("Greska u radu sa bazom!");
            }
        }

        public int ObrisiZaUslovVise(OpstiDomenskiObjekat odo)
        {
            string upit = "Delete from " + odo.tabela + " where " + odo.uslovVise;
            SqlCommand komanda = new SqlCommand(upit, konekcija, transakcija);

            try
            {
                return komanda.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw new Exception("Greska u radu sa bazom!");
            }
        }

        public int VratiSifru(OpstiDomenskiObjekat odo)
        {
            string upit = "Select max(" + odo.kljuc + ") from " + odo.tabela;
            SqlCommand komanda = new SqlCommand(upit, konekcija, transakcija);

            try
            {
                int sifra = Convert.ToInt32(komanda.ExecuteScalar());
                return sifra + 1;
            }
            catch (Exception)
            {
                return 1;
            }
        }
    }
}
