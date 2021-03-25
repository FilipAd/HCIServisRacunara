using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servis_Racunara
{
    static class DbServisRacunara
    {
        public static string connectionString = "SERVER=localhost;DATABASE=servisracunara;UID=root;PASSWORD=specnaz9;";
        public static List<Komponenta> GetKomponentas()
        {
            List<Komponenta> rezultat = new List<Komponenta>();
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText =
                @"SELECT k.SifraKomponente,k.NazivKomponente,k.CijenaKomponente,k.DostupnaKolicina
                  FROM komponenta k
                  ORDER BY k.SifraKomponente";
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                rezultat.Add(new Komponenta()
                {
                    SifraKomponente = reader.GetInt32(0),
                    NazivKomponente = reader.GetString(1),
                    CijenaKomponente = reader.GetDecimal(2),
                    DostupnaKolicina = reader.GetInt32(3),
                  
                });
            }
            reader.Close();
            conn.Close();
            return rezultat;
        }

        public static List<Grad> GetGrad()
        {
            List<Grad> rezultat = new List<Grad>();
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = @"SELECT G.PostanskiBrojGrada,G.NazivGrada
            FROM GRAD G ORDER BY NazivGrada";
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                rezultat.Add(new Grad()
                {
                    PostanskiBrojGrada = reader.GetInt32(0),
                    NazivGrada=reader.GetString(1)
                    
                });
            }
            reader.Close();
            conn.Close();
            return rezultat;
        }
        public static decimal GetUslugeZaPlatiti(int BrojNaloga)
        {
           
                decimal suma = 0;
                MySqlConnection conn = new MySqlConnection(connectionString);
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = @"SELECT SUM(Ukupno) FROM USLUGA_STAVKA WHERE (BrojRadnogNaloga =@BrojNaloga) and Obrisana=0";
                cmd.Parameters.AddWithValue("@BrojNaloga", BrojNaloga);
                MySqlDataReader reader = cmd.ExecuteReader();
            try
            {
                while (reader.Read())
                {
                    suma = reader.GetDecimal(0);
                }
                reader.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
                reader.Close();
                conn.Close();
            }
            return suma;
            
           
        }
        
        public static decimal GetKomponentiZaPlatiti(int BrojNaloga)
        {
            decimal suma = 0;
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = @"SELECT SUM(Ukupno) FROM KOMPONENTA_STAVKA WHERE BrojRadnogNaloga =@BrojNaloga";
            cmd.Parameters.AddWithValue("@BrojNaloga", BrojNaloga);
            MySqlDataReader reader = cmd.ExecuteReader();
            try
            {
                while (reader.Read())
                {
                    suma = reader.GetDecimal(0);
                }
                reader.Close();
                conn.Close();
            }
            catch(Exception ex)
            {
                reader.Close();
                conn.Close();
            }
            return suma;
        }
        public static List<PrikazRadnika> GetRadnici()
        {
            List<PrikazRadnika> rezultat = new List<PrikazRadnika>();
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = @"SELECT R.IdPartnera,P.Ime
                FROM Radnik R inner join Partner P using (IdPartnera) WHERE P.Obrisan=0 ORDER BY Ime";
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                rezultat.Add(new PrikazRadnika()
                {
                    IdPartnera = reader.GetInt32(0),
                    Ime = reader.GetString(1)

                });
            }
            reader.Close();
            conn.Close();
            return rezultat;
        }
        public static int ProvjeriDaLiJeKomponentaObrisana(int BrojRadnogNaloga)
        {

            int rezultat = 0;
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = @"SELECT K.Obrisana
                FROM Komponenta K inner join Komponenta_Stavka KS on K.SifraKomponente=KS.SifraKomponente WHERE
                KS.BrojRadnogNaloga=@BrojRadnogNaloga";
            cmd.Parameters.AddWithValue("@BrojRadnogNaloga", BrojRadnogNaloga);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                rezultat = reader.GetInt32(0);
            }
            reader.Close();
            conn.Close();
            return rezultat;
        }
        public static List<KomponentaStavka> GetKomponentaStavke(int BrojRadnogNaloga)
        {
            List<KomponentaStavka> rezultat = new List<KomponentaStavka>();
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = @"SELECT KS.SifraKomponente,Nazivkomponente,Kolicina,Cijena,Rabat,Ukupno
                FROM Komponenta K inner join Komponenta_Stavka KS on K.SifraKomponente=KS.SifraKomponente WHERE
                KS.BrojRadnogNaloga=@BrojRadnogNaloga";
            cmd.Parameters.AddWithValue("@BrojRadnogNaloga",BrojRadnogNaloga);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                rezultat.Add(new KomponentaStavka()
                {
                    SifraKomponente=reader.GetInt32(0),
                    NazivKomponente=reader.GetString(1),
                    ZahtjevanaKolicina=reader.GetInt32(2),
                    JedinicnaCijena=reader.GetDecimal(3),
                    Rabat=reader.GetDecimal(4),
                    UkupnaCijena=reader.GetDecimal(5),
                    
                });
            }
            reader.Close();
            conn.Close();
            return rezultat;
        }
        public static List<UslugaStavka> GetUslugaStavke(int BrojRadnogNaloga)
        {
            List<UslugaStavka> rezultat = new List<UslugaStavka>();
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = @"SELECT US.SifraUsluge,Naziv,Kolicina,US.CijenaPoH,Rabat,Ukupno
                FROM Usluga U  inner join USLUGA_Stavka US on U.SifraUSLUGE=US.SifraUsluge WHERE
                (US.BrojRadnogNaloga=@BrojRadnogNaloga) and US.Obrisana=0 ";
            cmd.Parameters.AddWithValue("@BrojRadnogNaloga", BrojRadnogNaloga);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                rezultat.Add(new UslugaStavka()
                {
                    SifraUsluge = reader.GetInt32(0),
                    NazivUsluge = reader.GetString(1),
                    Kolicina = reader.GetInt32(2),
                    CijenaPoH = reader.GetDecimal(3),
                    Rabat = reader.GetDecimal(4),
                    UkupnaCijena = reader.GetDecimal(5),
                   
                });
            }
            reader.Close();
            conn.Close();
            return rezultat;
        }

        public static void UpdateRandiNalog(RadniNalog nalog)
        {
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "CALL UPDATE_RADNI_NALOG(@BrojNaloga,@Zahtjev,@Napomena,@DatumKreiranja,@DatumZavrsetka,@Status,@IdServiseraZaprimio,@IdServiseraRadi)";
            cmd.Parameters.AddWithValue("@BrojNaloga", nalog.BrojRadnogNaloga);
            cmd.Parameters.AddWithValue("@Zahtjev", nalog.OpisZahtjeva);
            cmd.Parameters.AddWithValue("@Napomena", nalog.Napomena);
            cmd.Parameters.AddWithValue("@DatumKreiranja", nalog.DatumKreiranja);
            cmd.Parameters.AddWithValue("@DatumZavrsetka", nalog.DatumZavrsetka);
            cmd.Parameters.AddWithValue("@Status", nalog.Status);
            cmd.Parameters.AddWithValue("@IdServiseraZaprimio", nalog.IdRadnikaZaprimio);
            cmd.Parameters.AddWithValue("@IdServiseraRadi", nalog.IdServiseraRadi);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public static void UpdateUslugaStavka(UslugaStavka us)
        {
            
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "CALL UPDATE_USLUGA_STAVKA(@SifraUsluge,@BrojNaloga,@Kolicina,@CijenaPoH,@Rabat,@Ukupno)";
            cmd.Parameters.AddWithValue("@SifraUsluge", us.SifraUsluge);
            cmd.Parameters.AddWithValue("@BrojNaloga", us.BrojRadnogNaloga);
            cmd.Parameters.AddWithValue("@Kolicina", us.Kolicina);
            cmd.Parameters.AddWithValue("@CijenaPoH", us.CijenaPoH);
            cmd.Parameters.AddWithValue("@Rabat", us.Rabat);
            cmd.Parameters.AddWithValue("@Ukupno", us.UkupnaCijena);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public static void DeleteUslugaStavka(UslugaStavka us)
        {
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "DELETE from USLUGA_STAVKA where (BrojRadnognaloga=@BrojNaloga) and (SifraUsluge=@SifraUsluge)";
            cmd.Parameters.AddWithValue("@SifraUsluge", us.SifraUsluge);
            cmd.Parameters.AddWithValue("@BrojNaloga", us.BrojRadnogNaloga);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
       

        public static void InsertKomponenta(Komponenta komponenta)
        {
            
            
                MySqlConnection conn = new MySqlConnection(connectionString);
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText =
                    @"INSERT INTO komponenta(SifraKomponente,NazivKomponente,CijenaKomponente,DostupnaKolicina)
                  VALUES (@SifraKomponente, @NazivKomponente, @CijenaKomponente, @DostupnaKolicina)";
                cmd.Parameters.AddWithValue("@SifraKomponente", komponenta.SifraKomponente);
                cmd.Parameters.AddWithValue("@NazivKomponente", komponenta.NazivKomponente);
                cmd.Parameters.AddWithValue("@CijenaKomponente", komponenta.CijenaKomponente);
                cmd.Parameters.AddWithValue("@DostupnaKolicina", komponenta.DostupnaKolicina);
                cmd.ExecuteNonQuery();
                conn.Close();
            
            
        }

        public static void InsertPartner(Partner partner,string brojTelefona)
        {
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = @"INSERT INTO partner(Ime,PostanskiBrojGrada,NazivUlice,Email,KucniBroj) 
                VALUES (@Ime,@PostanskiBrojGrada,@NazivUlice,@Email,@KucniBroj)";
            cmd.Parameters.AddWithValue("@Ime", partner.Ime);
            cmd.Parameters.AddWithValue("@PostanskiBrojGrada",partner.PostanskiBrojGrada);
            cmd.Parameters.AddWithValue("@NazivUlice", partner.NazivUlice);
            cmd.Parameters.AddWithValue("@Email", partner.Email);
            cmd.Parameters.AddWithValue("@KucniBroj",partner.KucniBroj);
            cmd.ExecuteNonQuery();
            partner.IdPartnera = (int)cmd.LastInsertedId;
            conn.Close();
            InsertTelefon(partner, brojTelefona);
            
           
        }

        public static void InsertTelefon(Partner partner,string BrojTelefona)
        {
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = @"INSERT INTO telefon(IdPartnera,BrojTelefona) 
                VALUES (@IdPartnera,@BrojTelefona)";
            cmd.Parameters.AddWithValue("@IdPartnera",partner.IdPartnera);
            cmd.Parameters.AddWithValue("@BrojTelefona",BrojTelefona);
            cmd.ExecuteNonQuery();
            conn.Close();

        }

        
        public static void InsertRadnik(Radnik radnik,Partner partner, string brojTelefona)
        {
            DbServisRacunara.InsertPartner(partner,brojTelefona);
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = @"INSERT INTO Radnik(IdPartnera,Uloga,Plata,VozackaDozvola)
            VALUES (@IdPartnera,@Uloga,@Plata,@VozackaDozvola)";
            cmd.Parameters.AddWithValue("@IdPartnera", partner.IdPartnera);
            cmd.Parameters.AddWithValue("@Uloga", radnik.Uloga);
            cmd.Parameters.AddWithValue("@Plata", radnik.Plata);
            cmd.Parameters.AddWithValue("@VozackaDozvola", radnik.VozackaDozvola);
            cmd.ExecuteNonQuery();
            conn.Close();


        }

        public static void InsertKlijent(Klijent klijent,Partner partner,string brojTelefona)
        {
            DbServisRacunara.InsertPartner(partner,brojTelefona);
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = @"INSERT INTO Klijent(IdPartnera,JestePravnoLice,BrojLicneKarte,JIB)
            VALUES (@IdPartnera,@JestePravnoLice,@BrojLicneKarte,@JIB)";
            cmd.Parameters.AddWithValue("@IdPartnera", partner.IdPartnera);
            cmd.Parameters.AddWithValue("@JestePravnoLice", klijent.JestePravnoLice);
            cmd.Parameters.AddWithValue("@BrojLicneKarte", klijent.BrojLicneKarte);
            cmd.Parameters.AddWithValue("@JIB", klijent.JIB);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public static void UpdateRadnika(PrikazRadnika radnik)
        {
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = @"update (Partner P inner join Radnik R on R.Idpartnera=P.IdPartnera) inner join Telefon T on T.IdPartnera=P.IdPartnera
            SET P.NazivUlice =@NazivUlice ,P.PostanskiBrojGrada =@PostanskiBrojGrada,
            P.KucniBroj =@KucniBroj,P.Ime =@Ime,T.BrojTelefona =@BrojTelefona,P.Email=@Email,R.Uloga=@Uloga,R.Plata=@Plata,R.VozackaDozvola=@VozackaDozvola
            where P.IdPartnera=@Id";
            cmd.Parameters.AddWithValue("@Id", radnik.IdPartnera);
            cmd.Parameters.AddWithValue("@NazivUlice",radnik.Ulica);
            cmd.Parameters.AddWithValue("@PostanskiBrojGrada",radnik.PostanskiBrojGrada);
            cmd.Parameters.AddWithValue("@KucniBroj", radnik.KucniBroj);
            cmd.Parameters.AddWithValue("@Ime", radnik.Ime);
            cmd.Parameters.AddWithValue("@BrojTelefona", radnik.Telefon);
            cmd.Parameters.AddWithValue("@Email", radnik.Email);
            cmd.Parameters.AddWithValue("@Uloga", radnik.Uloga);
            cmd.Parameters.AddWithValue("@Plata", radnik.Plata);
            cmd.Parameters.AddWithValue("@VozackaDozvola", radnik.VozackaDozvola);
            cmd.ExecuteNonQuery();
            conn.Close();
            
        }

        public static void DeletePartnera(int IdPartnera)
        {
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "CALL OBRISI_PARTNERA(@IdPartnera)";
            cmd.Parameters.AddWithValue("@IdPartnera", IdPartnera);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public static void UpdateKlijenta(PrikazPartnera klijent)
        {
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = @"update (Partner P inner join Klijent K on K.Idpartnera=P.IdPartnera) inner join Telefon T on T.IdPartnera=P.IdPartnera
            SET P.NazivUlice =@NazivUlice,P.PostanskiBrojGrada =@PostanskiBrojGrada,
            P.KucniBroj =@KucniBroj ,P.Ime =@Ime,T.BrojTelefona =@BrojTelefona,P.Email=@Email,K.JIB=@JIB,K.BrojLicneKarte=@BrojLicneKarte
            where P.IdPartnera=@Id";
            cmd.Parameters.AddWithValue("@Id", klijent.IdPartnera);
            cmd.Parameters.AddWithValue("@NazivUlice", klijent.Ulica);
            cmd.Parameters.AddWithValue("@PostanskiBrojGrada", klijent.PostanskiBrojGrada);
            cmd.Parameters.AddWithValue("@KucniBroj", klijent.KucniBroj);
            cmd.Parameters.AddWithValue("@Ime", klijent.Ime);
            cmd.Parameters.AddWithValue("@BrojTelefona", klijent.Telefon);
            cmd.Parameters.AddWithValue("@Email", klijent.Email);
            cmd.Parameters.AddWithValue("@BrojLicneKarte", klijent.BrojLicneKarte);
            cmd.Parameters.AddWithValue("@JIB", klijent.JIB);
            cmd.ExecuteNonQuery();
            conn.Close();

        }
         public static void InsertKlijentURadniNalog(int IdPartnera)
         {
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = @"INSERT INTO RADNI_NALOG(IdKlijenta) VALUES (@IdKlijenta)";
            cmd.Parameters.AddWithValue("@IdKlijenta",IdPartnera);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public static void InsertUslugaStavkaNaNalog(UslugaStavka uslugaStavka)
        {
           
                MySqlConnection conn = new MySqlConnection(connectionString);
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
            try
            {
                cmd.CommandText = @"INSERT INTO USLUGA_STAVKA(SifraUsluge,BrojRadnogNaloga,Kolicina,CijenaPoH,Rabat,Ukupno) 
            VALUES (@SifraUsluge,@BrojRadnogNaloga,@Kolicina,@CijenaPoH,@Rabat,@Ukupno)";
                cmd.Parameters.AddWithValue("@SifraUsluge", uslugaStavka.SifraUsluge);
                cmd.Parameters.AddWithValue("@BrojRadnogNaloga", uslugaStavka.BrojRadnogNaloga);
                cmd.Parameters.AddWithValue("@Kolicina", uslugaStavka.Kolicina);
                cmd.Parameters.AddWithValue("@CijenaPoH", uslugaStavka.CijenaPoH);
                cmd.Parameters.AddWithValue("@Rabat", uslugaStavka.Rabat);
                cmd.Parameters.AddWithValue("@Ukupno", uslugaStavka.UkupnaCijena);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (MySqlException mysqlEx)
            {

                conn.Close();
            }


        }
        public static void UmanjiDostupneKompnente(KomponentaStavka ks)
        {
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "CALL UMANJI_DOSTUPNE_KOMPONENTE(@SifraKomponente,@ZaKolicinu)";
            cmd.Parameters.AddWithValue("@SifraKomponente", ks.SifraKomponente);
            cmd.Parameters.AddWithValue("@ZaKolicinu", ks.ZahtjevanaKolicina);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public static void ObrisiSveStavkeKomponenteSaRadnogNaloga(int BrojNaloga)
        {
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "CALL  OBRISI_SVE_STAVKE_KOMPONENTE_SA_NALOGA(@BrojRadnogNaloga)";
            cmd.Parameters.AddWithValue("@BrojRadnogNaloga",BrojNaloga);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public static void ObrisSveStavkeUslugeSaRadnogNaloga(int BrojNaloga)
        {
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "CALL OBRISI_SVE_STAVKE_USLUGE_SA_NALOGA(@BrojRadnogNaloga)";
            cmd.Parameters.AddWithValue("@BrojRadnogNaloga", BrojNaloga);
            cmd.ExecuteNonQuery();
            conn.Close();

        }
        public static void InsertKomponentaStavkaNaNalog(KomponentaStavka komponentaStavka)
        {
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            try
            {
                cmd.CommandText = @"INSERT INTO KOMPONENTA_STAVKA(SifraKomponente,BrojRadnogNaloga,Kolicina,Cijena,Rabat,Ukupno) 
                VALUES (@SifraUsluge,@BrojRadnogNaloga,@Kolicina,@Cijena,@Rabat,@Ukupno)";
                cmd.Parameters.AddWithValue("@SifraUsluge", komponentaStavka.SifraKomponente);
                cmd.Parameters.AddWithValue("@BrojRadnogNaloga", komponentaStavka.BrojNaloga);
                cmd.Parameters.AddWithValue("@Kolicina", komponentaStavka.ZahtjevanaKolicina);
                cmd.Parameters.AddWithValue("@Cijena", komponentaStavka.JedinicnaCijena);
                cmd.Parameters.AddWithValue("@Rabat", komponentaStavka.Rabat);
                cmd.Parameters.AddWithValue("@Ukupno", komponentaStavka.UkupnaCijena);
                cmd.ExecuteNonQuery();
                conn.Close();
                UmanjiDostupneKompnente(komponentaStavka);
            }

            catch (MySqlException mysqlEx)
            {
                conn.Close();
            }
            
        }
        public static void UpdateKomponentaStavka(KomponentaStavka ks)
        {
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "CALL UPDATE_KOMPONENTA_STAVKA(@BrojNaloga,@SifraKomponente,@Razlika,@Cijena,@Rabat,@Ukupno,@Kolicina)";
            cmd.Parameters.AddWithValue("@SifraKomponente", ks.SifraKomponente);
            cmd.Parameters.AddWithValue("@BrojNaloga", ks.BrojNaloga);
            cmd.Parameters.AddWithValue("@Kolicina", ks.ZahtjevanaKolicina);
            cmd.Parameters.AddWithValue("@Cijena", ks.JedinicnaCijena);
            cmd.Parameters.AddWithValue("@Rabat", ks.Rabat);
            cmd.Parameters.AddWithValue("@Ukupno", ks.UkupnaCijena);
            cmd.Parameters.AddWithValue("@Razlika", ks.Razlika);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public static void DeleteKomponentaStavka(KomponentaStavka ks)
        {
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "CALL DELETE_KOMPONENTA_STAVKA(@BrojRadnogNaloga,@SifraKomponente,@Razlika)";
            cmd.Parameters.AddWithValue("@BrojRadnogNaloga", ks.BrojNaloga);
            cmd.Parameters.AddWithValue("@SifraKomponente", ks.SifraKomponente);
            cmd.Parameters.AddWithValue("@Razlika", ks.Razlika);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public static void InsertRadniNalog(RadniNalog nalog)
        {
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = @"INSERT INTO RADNI_NALOG(OpisZahtjeva,Napomena,StatusNaloga,DatumKreiranja,IdServiseraZ,IdKlijenta,IdServiseraR,DatumZavrsetka)
            VALUES (@OpisZahtjeva,@Napomena,@StatusNaloga,@DatumKreiranja,@IdServiseraZ,@IdKlijenta,@IdServiseraR,@DatumZavrsetka)";
            cmd.Parameters.AddWithValue("@OpisZahtjeva",nalog.OpisZahtjeva);
            cmd.Parameters.AddWithValue("@Napomena", nalog.Napomena);
            cmd.Parameters.AddWithValue("@StatusNaloga", nalog.Status);
            cmd.Parameters.AddWithValue("@DatumKreiranja", nalog.DatumKreiranja);
            cmd.Parameters.AddWithValue("@IdServiseraZ", nalog.IdRadnikaZaprimio);
            cmd.Parameters.AddWithValue("@IdKlijenta", nalog.IdKlijenta);
            cmd.Parameters.AddWithValue("@IdServiseraR", nalog.IdServiseraRadi);
            cmd.Parameters.AddWithValue("@DatumZavrsetka", nalog.DatumZavrsetka);
            cmd.ExecuteNonQuery();
            nalog.BrojRadnogNaloga = (int)cmd.LastInsertedId;
            conn.Close();
        }

        public static void UpdateKomponenta(int staraS,Komponenta k)
        {
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = @"UPDATE komponenta
            SET SifraKomponente=@novaSifra,NazivKomponente=@NazivKomponente,CijenaKomponente=@CijenaKomponente,DostupnaKolicina=@DostupnaKolicina 
            WHERE SifraKomponente=@staraSifra";
            cmd.Parameters.AddWithValue("@staraSifra", staraS);
            cmd.Parameters.AddWithValue("@novaSifra", k.SifraKomponente);
            cmd.Parameters.AddWithValue("@NazivKomponente", k.NazivKomponente);
            cmd.Parameters.AddWithValue("@CijenaKomponente", k.CijenaKomponente);
            cmd.Parameters.AddWithValue("@DostupnaKolicina", k.DostupnaKolicina);
            cmd.ExecuteNonQuery();
            conn.Close();
           

        }

        public static void UpdateKolicina(int sifra,int kolicina)
        {
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = @"UPDATE komponenta
                SET DostupnaKolicina=DostupnaKolicina+@kolicina
                WHERE SifraKomponente=@sifra";
            cmd.Parameters.AddWithValue("@sifra", sifra);
            cmd.Parameters.AddWithValue("@kolicina",kolicina);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public static void DeleteKoomponentaSifra(int sifraKomponente)
        {
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "UPDATE komponenta SET Obrisana=1 WHERE SifraKomponente=@SifraKomponente";
            cmd.Parameters.AddWithValue("@SifraKomponente",sifraKomponente);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public static void DeleteRadniNalog(int BrojNaloga)
        {
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "CALL OBRISI_RADNI_NALOG(@BrojNaloga)";
            cmd.Parameters.AddWithValue("@BrojNaloga",BrojNaloga);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public static List<Komponenta> GetKomponenteFilter(string filter)
        {
            List<Komponenta> rezultat = new List<Komponenta>();
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText =
                @"SELECT k.SifraKomponente,k.NazivKomponente, k.CijenaKomponente,k.DostupnaKolicina
                  FROM komponenta k
                  WHERE (k.SifraKomponente LIKE @str OR k.NazivKomponente LIKE @str) and Obrisana=0
                  ORDER BY k.SifraKomponente,k.NazivKomponente";
            cmd.Parameters.AddWithValue("@str", filter + "%");
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                rezultat.Add(new Komponenta()
                {
                    SifraKomponente = reader.GetInt32(0),
                    NazivKomponente = reader.GetString(1),
                    CijenaKomponente = reader.GetDecimal(2),
                    DostupnaKolicina = reader.GetInt32(3),

                });
            }
            reader.Close();
            conn.Close();
            return rezultat;
        }
        public static List<PrikazPartnera> GetPartneriFilter(string filter)
        {
            List<PrikazPartnera> rezultat = new List<PrikazPartnera>();
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText =
                @"SELECT P.IdPartnera,Ime,NazivUlice,NazivGrada,BrojTelefona
                  FROM ((partner P inner join ulica U on P.IdUlice=U.IdUlice) inner join Grad G on G.PostanskiBrojGrada=U.PostanskiBrojGrada) inner join Telefon T on P.IdPartnera=T.IdPartnera
                  WHERE Ime LIKE @str OR  NazivUlice LIKE @str OR NazivGrada LIKE @str
                  ORDER BY Ime";
            cmd.Parameters.AddWithValue("@str", filter + "%");
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                rezultat.Add(new PrikazPartnera()
                {
                    IdPartnera = reader.GetInt32(0),
                    Ime = reader.GetString(1),
                    Ulica = reader.GetString(2),
                    Grad = reader.GetString(3),
                    Telefon = reader.GetString(4)

                }) ;
            }
            reader.Close();
            conn.Close();
            return rezultat;
        }
        public static List<PrikazPartnera> GetKlijentFilter(string filter)
        {
            List<PrikazPartnera> rezultat = new List<PrikazPartnera>();
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText =
                @"SELECT P.IdPartnera,Ime,NazivUlice,NazivGrada,BrojTelefona,KucniBroj,Email,BrojLicneKarte,JIB,JestePravnoLice
                  FROM ((partner P inner join Grad G on G.PostanskiBrojGrada=P.PostanskiBrojGrada) inner join Telefon T on P.IdPartnera=T.IdPartnera) inner join Klijent K on K.IdPartnera=P.IdPartnera
                  WHERE (Ime LIKE @str OR  NazivUlice LIKE @str OR NazivGrada LIKE @str) and P.Obrisan=0
                  ORDER BY IdPartnera,Ime";
            cmd.Parameters.AddWithValue("@str", filter + "%");
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                rezultat.Add(new PrikazPartnera()
                {
                    IdPartnera = reader.GetInt32(0),
                    Ime = reader.GetString(1),
                    Ulica = reader.GetString(2),
                    Grad = reader.GetString(3),
                    Telefon = reader.GetString(4),
                    KucniBroj = reader.GetInt32(5),
                    Email=reader.GetString(6),
                    BrojLicneKarte=reader.GetString(7),
                    JIB=reader.GetString(8),
                    JestePravnoLice=reader.GetInt32(9)
                }); 
            }
            reader.Close();
            conn.Close();
            return rezultat;
        }
        public static List<RadniNalogPrikaz> GetRadniNaloziNeproknjizeni(string filter)
        {
            List<RadniNalogPrikaz> rezultat = new List<RadniNalogPrikaz>();
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = @"SELECT BrojRadnogNaloga,OpisZahtjeva,Napomena,StatusNaloga,DatumKreiranja,DatumZavrsetka,IdServiseraZ,IdServiseraR,IdKlijenta,Proknjizeni,BrojRacuna,P.Ime
            FROM RADNI_NALOG RN inner join PARTNER P on P.IdPartnera=RN.IdKlijenta
            WHERE (Proknjizeni=0 and P.Ime LIKE @str) and RN.Obrisan=0";
            cmd.Parameters.AddWithValue("@str", filter + "%");
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                rezultat.Add(new RadniNalogPrikaz()
                {
                   BrojRadnogNaloga=reader.GetInt32(0),
                   OpisZahtjeva=reader.GetString(1),
                   Napomena=reader.GetString(2),
                   Status=reader.GetString(3),
                   DatumKreiranja=reader.GetDateTime(4),
                   DatumZavrsetka = reader.GetDateTime(5),
                   IdRadnikaZaprimio=reader.GetInt32(6),
                   IdServiseraRadi=reader.GetInt32(7),
                   IdKlijenta=reader.GetInt32(8),
                   Proknjizen=reader.GetInt32(9),
              //     BrojRacuna=reader.GetInt32(10),
                   ImeKlijenta=reader.GetString(11),
                });
            }
            reader.Close();
            conn.Close();
            return rezultat;



        }
        public static List<RadniNalogPrikaz> GetRadniNaloziProknjizeni(string filter)
        {
            List<RadniNalogPrikaz> rezultat = new List<RadniNalogPrikaz>();
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = @"SELECT BrojRadnogNaloga,OpisZahtjeva,Napomena,StatusNaloga,DatumKreiranja,DatumZavrsetka,IdServiseraZ,IdServiseraR,IdKlijenta,Proknjizeni,BrojRacuna,P.Ime
            FROM RADNI_NALOG RN inner join PARTNER P on P.IdPartnera=RN.IdKlijenta
            WHERE (Proknjizeni=1 and P.Ime LIKE @str) and RN.Obrisan=0";
            cmd.Parameters.AddWithValue("@str", filter + "%");
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                rezultat.Add(new RadniNalogPrikaz()
                {
                    BrojRadnogNaloga = reader.GetInt32(0),
                    OpisZahtjeva = reader.GetString(1),
                    Napomena = reader.GetString(2),
                    Status = reader.GetString(3),
                    DatumKreiranja = reader.GetDateTime(4),
                    DatumZavrsetka = reader.GetDateTime(5),
                    IdRadnikaZaprimio = reader.GetInt32(6),
                    IdServiseraRadi = reader.GetInt32(7),
                    IdKlijenta = reader.GetInt32(8),
                    Proknjizen = reader.GetInt32(9),
                    //     BrojRacuna=reader.GetInt32(10),
                    ImeKlijenta = reader.GetString(11),
                });
            }
            reader.Close();
            conn.Close();
            return rezultat;



        }
        public static RadniNalogPrikaz GetRadniNalogNeproknjizenielementi(int BrojNaloga)
        {
            List<PrikazRadnika> rezultat = new List<PrikazRadnika>();
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = @"SELECT OpisZahtjeva,Napomena,DatumKreiranja,DatumZavrsetka,IdServiseraR,Z.Ime as Zaprimio,R.Ime as Radi,IdServiseraZ
            FROM RADNI_NALOG RN,Partner R,Partner Z  WHERE RN.IdServiseraZ=Z.IdPartnera and RN.IdServiseraR=R.IdPartnera and BrojRadnogNaloga=@BrojNaloga";
            cmd.Parameters.AddWithValue("@BrojNaloga", BrojNaloga);
            MySqlDataReader reader = cmd.ExecuteReader();
            RadniNalogPrikaz nalog = null;
            while (reader.Read())
            {
                nalog = new RadniNalogPrikaz()
                {
                    OpisZahtjeva = reader.GetString(0),
                    Napomena = reader.GetString(1),
                    DatumKreiranja = reader.GetDateTime(2),
                    DatumZavrsetka = reader.GetDateTime(3),
                    

                };
                if (!reader.IsDBNull(4))
                    nalog.IdServiseraRadi = reader.GetInt32(4);
                if (!reader.IsDBNull(5))
                    nalog.ImeRadnikaKojiJeZaprimio = reader.GetString(5);
               
                if (!reader.IsDBNull(6))
                    nalog.ImeServiseraKojiRadi = reader.GetString(6);
                if (!reader.IsDBNull(7))
                    nalog.IdRadnikaZaprimio = reader.GetInt32(7);
                
            }
            reader.Close();
            conn.Close();
            return nalog;


        }

        public static List<Usluga> GetUsluga(string filter)
        {
            List<Usluga> rezultat = new List<Usluga>();
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = @"SELECT SifraUsluge,Naziv,CijenaPoH
            FROM USLUGA WHERE (SifraUsluge LIKE @str OR Naziv LIKE @str) and Obrisana=0";
            cmd.Parameters.AddWithValue("@str", filter + "%");
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                rezultat.Add(new Usluga()
                { 
                    SifraUsluge=reader.GetInt32(0),
                    Naziv=reader.GetString(1),
                    CijenaPoH=reader.GetDecimal(2),
                });
            }
            reader.Close();
            conn.Close();
            return rezultat;

        }
        public static List<PrikazRadnika> GetRadnikFilter(string filter)
        {
            List<PrikazRadnika> rezultat = new List<PrikazRadnika>();
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText =
                @"SELECT P.IdPartnera,Ime,NazivUlice,NazivGrada,BrojTelefona,KucniBroj,Email,Uloga,Plata,VozackaDozvola
                FROM ((partner P inner join Grad G on G.PostanskiBrojGrada=P.PostanskiBrojGrada) inner join Telefon T on P.IdPartnera=T.IdPartnera) inner join Radnik R on R.IdPartnera=P.IdPartnera
                  WHERE (Ime LIKE @str OR  NazivUlice LIKE @str OR NazivGrada LIKE @str) and P.Obrisan=0
                  ORDER BY IdPartnera,Ime";
            cmd.Parameters.AddWithValue("@str", filter + "%");
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                rezultat.Add(new PrikazRadnika()
                {
                    IdPartnera = reader.GetInt32(0),
                    Ime = reader.GetString(1),
                    Ulica = reader.GetString(2),
                    Grad = reader.GetString(3),
                    Telefon = reader.GetString(4),
                    KucniBroj = reader.GetInt32(5),
                    Email = reader.GetString(6),
                    Uloga = reader.GetString(7),
                    Plata = reader.GetDecimal(8),
                    VozackaDozvola = reader.GetString(9)


                }) ;
            }
            reader.Close();
            conn.Close();
            return rezultat;
        }
        public static int VratiBrojStavkiKomponentiSaNaloga(int BrojNaloga)
        {
            int rezultat = 0;
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = @"SELECT COUNT(*) FROM KOMPONENTA_STAVKA WHERE BrojRadnogNaloga=@BrojNaloga";
            cmd.Parameters.AddWithValue("@BrojNaloga",BrojNaloga);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                rezultat = reader.GetInt32(0);
            }
            reader.Close();
            conn.Close();
            return rezultat;
        }
        public static void ProknjiziNalog(int BrojNaloga)
        {
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = @"UPDATE Radni_nalog SET Proknjizeni=1 WHERE BrojRadnogNaloga=@BrojNaloga";
            cmd.Parameters.AddWithValue("@BrojNaloga", BrojNaloga);
            cmd.ExecuteNonQuery();
            conn.Close();
        }


    }
}
