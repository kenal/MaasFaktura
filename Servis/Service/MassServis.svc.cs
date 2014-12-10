using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Mass.Data;
using System.Data.Linq;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.Linq.SqlClient;

namespace Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "MassServis" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select MassServis.svc or MassServis.svc.cs at the Solution Explorer and start debugging
    [ServiceContract]
    public class MassServis
    {
    
      [OperationContract]
        public int LoginValidacija(string username, string pass)
        {
            using(DataBaseModelDataContext context = new DataBaseModelDataContext())
            {

                var x = (from a in context.users where (a.username.Equals(username) && a.password.Equals(pass)) select new { a.idUser }).SingleOrDefault();
            if (x != null)
            {
                if (x.idUser != 0)
                    return Convert.ToInt32(x.idUser);
                else return 0;
            }

            else
                { return 0; }
            }   
        }
       [OperationContract]
       public void UnesiDobavljaca(lieferant dobavljac)
       {
           using (DataBaseModelDataContext context = new DataBaseModelDataContext())
           {
               context.lieferants.InsertOnSubmit(dobavljac);
               context.SubmitChanges();
           }
       }
       [OperationContract]
       public ObservableCollection<lieferant> ListaDobavljaca()
       {
           ObservableCollection<lieferant> Lista = new ObservableCollection<lieferant>();
           using (DataBaseModelDataContext context = new DataBaseModelDataContext())
           {
               var x = from a in context.lieferants select a;
               Lista.Clear();
               foreach (var p in x)
               {
                   Lista.Add(new lieferant { 
                   idLief=p.idLief,
                   lieferantNr=p.lieferantNr,
                   vorname=p.vorname,
                   anrede=p.anrede,
                   name=p.name,
                   adresse=p.adresse,
                   tel1=p.tel1,
                   tel2=p.tel2,
                   handy=p.handy,
                   skype=p.skype,
                   fax=p.skype,
                   email=p.email,
                   bank=p.bank,
                   BLZ=p.BLZ,
                   KtoNr=p.KtoNr,
                   BIC=p.BIC,
                   IBAN=p.IBAN,
                   kontoinhaber=p.kontoinhaber,
                   notiz=p.notiz,
                   idUser=p.idUser,
                   umsatz = p.umsatz,
                   zahlweise=p.zahlweise,
                   land=p.land,
                   branche = p.branche,
                   skonto = p.skonto,
                   tage=p.tage,
                   zahlbar = p.zahlbar,
                   rabat=p.rabat,
                   bankeinzug = p.bankeinzug,
                   stauer=p.stauer
                   });
               }
             
           }
           return Lista;
       }

        [OperationContract]
        public void ObrisiDobavljaca(int brDobavljaca)
        {
            using (DataBaseModelDataContext context = new DataBaseModelDataContext())
            {
                var query = from a in context.lieferants where a.lieferantNr == brDobavljaca select a;

                foreach (var p in query)
                {
                    context.lieferants.DeleteOnSubmit(p);
                    context.SubmitChanges();
                }
            }
        }

        [OperationContract]
   public void UpdateDobavljac(lieferant d)
   {
       using(DataBaseModelDataContext context = new DataBaseModelDataContext())
       {
           lieferant dobavljac = (from a in context.lieferants where a.idLief == d.idLief select a).FirstOrDefault();
           dobavljac.lieferantNr = d.lieferantNr;
           dobavljac.anrede = d.anrede;
           dobavljac.vorname = d.vorname;
           dobavljac.name = d.name;
           dobavljac.adresse = d.adresse;
           dobavljac.tel1 = d.tel1;
           dobavljac.tel2 = d.tel2;
           dobavljac.handy = d.handy;
           dobavljac.skype = d.skype;
           dobavljac.fax = d.fax;
           dobavljac.email = d.email;
           dobavljac.bank = d.bank;
           dobavljac.BLZ = d.BLZ;
           dobavljac.KtoNr = d.KtoNr;
           dobavljac.BIC = d.BIC;
           dobavljac.IBAN = d.IBAN;
           dobavljac.kontoinhaber = d.kontoinhaber;
           dobavljac.notiz = d.notiz;
           dobavljac.idUser = d.idUser;
           dobavljac.umsatz = d.umsatz;
           dobavljac.zahlweise = d.zahlweise;
           dobavljac.land = d.land;
           dobavljac.branche = d.branche;
           dobavljac.skonto = d.skonto;
           dobavljac.tage = d.tage;
           dobavljac.zahlbar = d.zahlbar;
           dobavljac.rabat = d.rabat;
           dobavljac.bankeinzug = d.bankeinzug;
           dobavljac.stauer = d.stauer;
           context.SubmitChanges();
       }
   }

        [OperationContract]
        public void UnesiRadnika(int broj,int titula,string ime,string prezime,string adresa,string tel1,string tel2,string mobitel,string fax,string skype,string email,float zarada,float satnica,string odmor, string odmor_na,float broj_plate,
            string bolovanje, string banka, string blz,string bic, string KtoNr, string Iban, string vlasnik, string biljeske, DateTime datum, int id)
        {
            using (DataBaseModelDataContext context = new DataBaseModelDataContext())
            {
                string datum1;
                datum1 = datum.ToString("yyyy-MM-dd");

                mitarbeiter r = new mitarbeiter();
                r.mitarbeiterNr = broj;
                r.tip = titula;
                r.vorname = ime;
                r.name = prezime;
                r.adresse = adresa;
                r.tel1 = tel1;
                r.tel2 = tel2;
                r.handy = mobitel;
                r.fax = fax;
                r.skype=skype;
                r.email = email;
                r.zarada = Convert.ToDecimal(zarada);
                r.satnica = Convert.ToDecimal(satnica);
                r.urlaub_ist = odmor;
                r.urlaub_soll = odmor_na;
                r.broj_plate = Convert.ToDecimal(broj_plate);
                r.krankheit = bolovanje;
                r.bank = banka;
                r.BLZ = blz;
                r.BIC = bic;
                r.KtoNr = KtoNr;
                r.IBAN = Iban;
                r.kontoinhaber = vlasnik;
                r.notiz = biljeske;
                datum = Convert.ToDateTime(datum1);
                r.datum = datum;
                r.idUser = id;
                r.status = 1;
                context.mitarbeiters.InsertOnSubmit(r);
                context.SubmitChanges();
            }
        }
        [OperationContract]
        public ObservableCollection<mitarbeiter> ListaRadnika()
        {
            ObservableCollection<mitarbeiter> Lista = new ObservableCollection<mitarbeiter>();
            using (DataBaseModelDataContext context = new DataBaseModelDataContext())
            {
                var query = from a in context.mitarbeiters select a;
                Lista.Clear();
                foreach (var p in query)
                {
                    Lista.Add(new mitarbeiter
                    {
                       idMit=p.idMit,
                       mitarbeiterNr=p.mitarbeiterNr,
                       tip=p.tip,
                       vorname=p.vorname,
                       name=p.name,
                       adresse=p.adresse,
                       tel1=p.tel1,
                       tel2=p.tel2,
                       handy=p.handy,
                       fax=p.fax,
                       email=p.email,
                       zarada=p.zarada,
                       satnica=p.satnica,
                       urlaub_ist=p.urlaub_ist,
                       urlaub_soll=p.urlaub_soll,
                       broj_plate=p.broj_plate,
                       wochen_std=p.wochen_std,
                       krankheit=p.krankheit,
                       bank=p.bank,
                       BLZ=p.BLZ,
                       BIC=p.BIC,
                       KtoNr=p.KtoNr,
                       IBAN=p.IBAN,
                       skype=p.skype,
                       kontoinhaber=p.kontoinhaber,
                       notiz=p.notiz,
                       datum=p.datum,
                       idUser=p.idUser,
                       folder=p.folder,
                       status=p.status
                    });
                }
                return Lista;
            }
        }

        [OperationContract]
        public void UnesiKupca(kunden kupac)
        {
            using (DataBaseModelDataContext context = new DataBaseModelDataContext())
            {
                context.kundens.InsertOnSubmit(kupac);
                context.SubmitChanges();
            }
        }
        [OperationContract]
        public ObservableCollection<user> ComboKorisnici()
        {
            ObservableCollection<user> Lista = new ObservableCollection<user>();
            using (DataBaseModelDataContext context = new DataBaseModelDataContext())
            {
                var query = from a in context.users select a;

                foreach (var p in query)
                {
                    Lista.Add(new user{
                    idUser= p.idUser,
                    firstName=p.firstName,
                    lastName=p.lastName,
                    mail=p.mail,
                    username=p.username,
                    password=p.password,
                    userType=p.userType,
                    telefon=p.telefon,
                    active=p.active,
                    slika=p.slika,
                    startseit=p.startseit
                    });
                }
                return Lista;
            }
        }

        [OperationContract]
        public ObservableCollection<user> ComboKorisniciPoruke(int id)
        {
            ObservableCollection<user> Lista = new ObservableCollection<user>();
            using (DataBaseModelDataContext context = new DataBaseModelDataContext())
            {
                var query = from a in context.users where a.idUser != id select a;

                foreach (var p in query)
                {
                    Lista.Add(new user
                    {
                        idUser = p.idUser,
                        firstName = p.firstName,
                        lastName = p.lastName,
                        mail = p.mail,
                        username = p.username,
                        password = p.password,
                        userType = p.userType,
                        telefon = p.telefon,
                        active = p.active,
                        slika = p.slika,
                        startseit = p.startseit
                    });
                }
                return Lista;
            }
        }

        [OperationContract]
        public ObservableCollection<kunden> ListaKupaca()
        {
            ObservableCollection<kunden> Lista = new ObservableCollection<kunden>();
            using (DataBaseModelDataContext context = new DataBaseModelDataContext())
            {
                var query = from a in context.kundens select a;
                Lista.Clear();
                foreach (var p in query)
                {
                    Lista.Add(new kunden
                    {
                        idKunde = p.idKunde,
                        suchbegriff = p.suchbegriff,
                        vorname = p.vorname,
                        name = p.name,
                        l_plz_ort = p.l_plz_ort,
                        gruppe = p.gruppe,
                        freifeld1 = p.freifeld1,
                        name2 = p.name2,
                        strasse = p.strasse,
                        tel1 = p.tel1,
                        tel2 = p.tel2,
                        fax = p.fax,
                        mail = p.mail,
                        lk = p.lk,
                        dostava_na = p.dostava_na,
                        dostava_od = p.dostava_od,
                        VKPreisgr = p.VKPreisgr,
                        gotovina = p.gotovina,
                        popust_gotovina = p.popust_gotovina,
                        dnevni_popust = p.dnevni_popust,
                        vertreter = p.vertreter,
                        limit_narudzbe = p.limit_narudzbe,
                        tip = p.tip,
                        lieferadresse = p.lieferadresse,
                        rechnungsadresse = p.rechnungsadresse,
                        email2 = p.email2,
                        internet = p.internet,
                        kundetype = p.kundetype,
                        steuer = p.steuer,
                        broj  = p.broj,
                        broj_detalji = p.broj_detalji,
                        kundenbewertung = p.kundenbewertung,
                        notiz = p.notiz,
                        naziv = p.naziv,
                        land = p.land,
                        placa = p.placa,
                        rabat = p.rabat,
                        adresse2 = p.adresse2,
                        stadt = p.stadt,
                        predmet = p.predmet,
                        anssprechepartner = p.anssprechepartner,
                        notiz_route = p.notiz_route,
                        titel = p.titel,
                        kundeNr = p.kundeNr
                    });
                }
                return Lista;
            }
        }

        [OperationContract]
        public void ObrisiKupca(int brKupca)
        {
            using (DataBaseModelDataContext context = new DataBaseModelDataContext())
            {
                var query = from a in context.kundens where a.kundeNr == brKupca.ToString() select a;

                foreach (var p in query)
                {
                    context.kundens.DeleteOnSubmit(p);
                    context.SubmitChanges();
                }
            }
        }

        [OperationContract]
        public void UpdateKupac(kunden k)
        {
            using (DataBaseModelDataContext context = new DataBaseModelDataContext())
            {
                kunden kupac = (from a in context.kundens where a.idKunde == k.idKunde select a).FirstOrDefault();
                kupac.gotovina = k.gotovina;
                kupac.lieferadresse = k.lieferadresse;
                kupac.rechnungsadresse = k.rechnungsadresse;
                kupac.adresse2 = k.adresse2;
                kupac.notiz = k.notiz;
                kupac.broj = k.broj;
                kupac.broj_detalji = k.broj_detalji;
                kupac.kundeNr = k.kundeNr;
                kupac.notiz_route = k.notiz_route;
                kupac.dnevni_popust = k.dnevni_popust;
                kupac.dostava_na = k.dostava_na;
                kupac.dostava_od = k.dostava_od;
                kupac.fax = k.fax;
                kupac.stadt = k.stadt;
                kupac.gruppe = k.gruppe;
                kupac.vorname = k.vorname;
                kupac.name2 = k.name2;
                kupac.internet = k.internet;
                kupac.anssprechepartner = k.anssprechepartner;
                kupac.limit_narudzbe = k.limit_narudzbe;
                kupac.lk = k.lk;
                kupac.mail = k.mail;
                kupac.email2 = k.email2;
                kupac.l_plz_ort = k.l_plz_ort;
                kupac.naziv = k.naziv;
                kupac.kundenbewertung = k.kundenbewertung;
                kupac.placa = k.placa;
                kupac.suchbegriff = k.suchbegriff;
                kupac.popust_gotovina = k.popust_gotovina;
                kupac.steuer = k.steuer;
                kupac.predmet = k.predmet;
                kupac.vertreter = k.vertreter;
                kupac.name = k.name;
                kupac.rabat = k.rabat;
                kupac.freifeld1 = k.freifeld1;
                kupac.tel1 = k.tel1;
                kupac.tel2 = k.tel2;
                kupac.tip = k.tip;
                kupac.kundetype = k.kundetype;
                kupac.titel = k.titel;
                kupac.strasse = k.strasse;
                kupac.VKPreisgr = k.VKPreisgr;
                kupac.land = k.land;
                context.SubmitChanges();
            }
        }

        [OperationContract]
        public void UnesiUsera(string Name, string LastName, string Email, string Telefon, bool Aktivan, string Slika, string Username, string Password, int UserType, bool Pocetna, string Licence)
        {
            using (DataBaseModelDataContext context = new DataBaseModelDataContext())
            {
                int lastIdOld = (from l in context.users orderby l.idUser descending select Convert.ToInt32(l.idUser)).First();
                try
                {
                    user korisnik = new user();
                    korisnik.firstName = Name;
                    korisnik.lastName = LastName;
                    korisnik.mail = Email;
                    korisnik.username = Username;
                    korisnik.password = Password;
                    korisnik.userType = UserType;
                    korisnik.telefon = Telefon;
                    korisnik.active = Convert.ToInt32(Aktivan);
                    korisnik.slika = Slika;
                    korisnik.startseit = Convert.ToInt32(Pocetna);
                    context.users.InsertOnSubmit(korisnik);
                    context.SubmitChanges();
                    int lastIdNew = (from l in context.users orderby l.idUser descending select Convert.ToInt32(l.idUser)).First();
                    if (lastIdNew > lastIdOld)
                    {
                        user_licence korLicenca = new user_licence();
                        korLicenca.idUser = lastIdNew;
                        korLicenca.datum = Convert.ToDateTime(Licence);
                        korLicenca.active = Convert.ToInt32(Aktivan);
                        context.user_licences.InsertOnSubmit(korLicenca);
                        context.SubmitChanges();
                    }
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
        }

        [OperationContract]
        public ObservableCollection<p_get_User_ViewResult> ListaUserView()
        {
            ObservableCollection<p_get_User_ViewResult> Lista = new ObservableCollection<p_get_User_ViewResult>();
            using (DataBaseModelDataContext context = new DataBaseModelDataContext())
            {
               // var query = from a in context.tbl_kupacs select a;
                var query = from t1 in context.users
                            join t2 in context.user_licences on t1.idUser equals t2.idUser
                            select new {t1.idUser, t1.firstName, t1.lastName, t1.mail, t1.userType, t1.username, t1.password, t1.telefon, t2.datum, t1.startseit, t1.active, t1.slika };
                Lista.Clear();
                foreach (var p in query)
                {
                    Lista.Add(new p_get_User_ViewResult
                    {
                        idUser = p.idUser,
                        firstName = p.firstName,
                        lastName = p.lastName,
                        mail = p.mail,
                        userType = p.userType,
                        username = p.username,
                        password = p.password,
                        telefon = p.telefon,
                        datum = p.datum,
                        startseit = p.startseit,
                        active = p.active,
                        slika = p.slika
                    });
                }
                return Lista;
            }
        }

        //[OperationContract]
        //public ObservableCollection<p_get_User_ViewResult> ListaUserView()
        //{
        //    ObservableCollection<p_get_User_ViewResult> Lista = new ObservableCollection<p_get_User_ViewResult>();
        //    using (DataBaseModelDataContext context = new DataBaseModelDataContext())
        //    {
        //        int a = context.ExecuteCommand("dbo.p_get_User_View");

        //    }
        //    return Lista;
        //}

        [OperationContract]
        public  DataSet getUsersView()
        {
            DataSet ds = new DataSet();
            DataTable dt = new DataTable("tblKorisnik");
            dt.Columns.Add(new DataColumn("id_korisnik", typeof(int)));
            dt.Columns.Add(new DataColumn("ime", typeof(string)));
            dt.Columns.Add(new DataColumn("prezime", typeof(string)));
            dt.Columns.Add(new DataColumn("mail", typeof(string)));
            dt.Columns.Add(new DataColumn("tip", typeof(string)));
            dt.Columns.Add(new DataColumn("username", typeof(string)));
            dt.Columns.Add(new DataColumn("password", typeof(string)));
            dt.Columns.Add(new DataColumn("telefon", typeof(string)));
            dt.Columns.Add(new DataColumn("datum", typeof(DateTime)));
            dt.Columns.Add(new DataColumn("pocetna", typeof(bool)));
            dt.Columns.Add(new DataColumn("aktivan", typeof(bool)));
            dt.Columns.Add(new DataColumn("slika", typeof(string)));
            //DataRow dr = dt.NewRow();
            using (DataBaseModelDataContext context = new DataBaseModelDataContext())
            {
                var query = (from t1 in context.tbl_korisniks
                            join t2 in context.tbl_korisnik_licencas on t1.id_korisnik equals t2.id_korisnik_FK
                            select new { t1.id_korisnik, t1.ime, t1.prezime, t1.mail, t1.tip, t1.username, t1.password, t1.telefon, t2.datum, t1.pocetna, t1.aktivan, t1.slika}).ToList();
                dt.Clear();
                foreach(var g in query)
            {
                    DataRow dr = dt.NewRow();
                dr["id_korisnik"] = g.id_korisnik;
                dr["ime"] = g.ime;
                dr["prezime"] = g.prezime;
                dr["mail"] = g.mail;
                if (g.tip == 0) {dr["tip"] = "Administrator";}
                else if (g.tip == 1) { dr["tip"] = "Mitarbeiter"; }
                else if (g.tip == 2) { dr["tip"] = "Sekretarin"; }
                else if (g.tip == 3) { dr["tip"] = "Techniker"; }
                else if (g.tip == 4) { dr["tip"] = "Werkstattleiter"; }
                dr["username"] = g.username;
                dr["password"] = g.password;
                dr["telefon"] = g.telefon;
                dr["datum"] = g.datum;
                dr["pocetna"] = g.pocetna;
                dr["aktivan"] = g.aktivan;
                dr["slika"] = g.slika;
                //dr["mail"] = g.mail;
                dt.Rows.Add(dr);
                //dt.Rows.Add(g.id_korisnik, g.ime, g.prezime, g.mail, g.tip, g.username, g.password, g.telefon, g.datum, g.pocetna, g.aktivan, g.slika);
            }
            ds.Tables.Add(dt);
            return ds;
            }
        }

        [OperationContract]
        public void DeleteRadnik(int sifraRadnik)
        {
            using (DataBaseModelDataContext context = new DataBaseModelDataContext())
            {
                var query = from a in context.mitarbeiters where a.mitarbeiterNr == sifraRadnik select a;

                foreach (var p in query)
                {
                    context.mitarbeiters.DeleteOnSubmit(p);
                    context.SubmitChanges();
                }
            }
        }

        [OperationContract]
        public void UpdateRadnika(mitarbeiter r, int id)
        {
            using (DataBaseModelDataContext context = new DataBaseModelDataContext())
            {
                mitarbeiter radnik = (from a in context.mitarbeiters where a.idMit == r.idMit select a).FirstOrDefault();
                radnik.mitarbeiterNr = r.mitarbeiterNr;
                radnik.tip = r.tip;
                radnik.vorname = r.vorname;
                radnik.name = r.name;
                radnik.adresse = r.adresse;
                radnik.tel1 = r.tel1;
                radnik.tel2 = r.tel2;
                radnik.handy = r.handy;
                radnik.fax = r.fax;
                radnik.skype = r.skype;
                radnik.email = r.email;
                radnik.zarada = r.zarada;
                radnik.satnica = r.satnica;
                radnik.urlaub_ist = r.urlaub_ist;
                radnik.urlaub_soll = r.urlaub_soll;
                radnik.broj_plate = r.broj_plate;
                radnik.krankheit = r.krankheit;
                radnik.bank = r.bank;
                radnik.BLZ = r.BLZ;
                radnik.BIC = r.BIC;
                radnik.KtoNr = r.KtoNr;
                radnik.IBAN = r.IBAN;
                radnik.kontoinhaber = r.kontoinhaber;
                radnik.notiz = r.notiz;
                radnik.datum = r.datum;
                radnik.idUser = id;
                r.status = 1;
                radnik.folder = r.folder;
                radnik.status = r.status;
               
                context.SubmitChanges();
            }
        }

        [OperationContract]
        public user VratiKorisnika(int id)
        {
            using(DataBaseModelDataContext context = new DataBaseModelDataContext())
            {
                user korisnik = new user();
                var query = (from a in context.users where a.idUser == id select a).Single();
                korisnik.idUser = query.idUser;
                korisnik.firstName = query.firstName;
                korisnik.lastName = query.lastName;
                korisnik.mail = query.mail;
                korisnik.username = query.username;
                korisnik.password = query.password;
                korisnik.userType = query.userType;
                korisnik.telefon = query.telefon;
                korisnik.active = query.active;
                korisnik.slika = query.slika;
                korisnik.startseit = query.startseit;
                return korisnik;
                
            }
        }

        [OperationContract]
        public void EditujUsera(int idUser, string Name, string LastName, string Email, string Telefon, bool Aktivan, string Slika, string Username, string Password, int UserType, bool Pocetna, string Licence)
        {
            using (DataBaseModelDataContext context = new DataBaseModelDataContext())
            {
                try
                {
                    user_licence korLIcenca = context.user_licences.Single(p => p.idUser == idUser);
                    korLIcenca.datum = Convert.ToDateTime(Licence);
                    context.SubmitChanges();

                    user korisnik = context.users.Single(e => e.idUser == idUser);
                    korisnik.firstName = Name;
                    korisnik.lastName = LastName;
                    korisnik.mail = Email;
                    korisnik.username = Username;
                    korisnik.password = Password;
                    korisnik.userType = UserType;
                    korisnik.telefon = Telefon;
                    korisnik.active = Convert.ToInt32(Aktivan);
                    korisnik.slika = Slika;
                    korisnik.startseit = Convert.ToInt32(Pocetna);
                    context.SubmitChanges();                  
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
        }
        [OperationContract]
        public void UpdateKorisnik(user k)
        {
            using (DataBaseModelDataContext context = new DataBaseModelDataContext())
            {
                user korisnik = (from a in context.users where a.idUser == k.idUser select a).FirstOrDefault();
                korisnik.firstName=k.firstName;
                korisnik.lastName=k.lastName;
                korisnik.mail = k.mail;
                korisnik.username = k.username;
                korisnik.password = k.password;
                korisnik.userType = k.userType;
                korisnik.telefon = k.telefon;
                korisnik.active = k.active;
                korisnik.slika = k.slika;
                korisnik.startseit = k.startseit;
                context.SubmitChanges();
            }
        }

        [OperationContract]
        public void DeleteUser(int idUser)
        {
            using (DataBaseModelDataContext context = new DataBaseModelDataContext())
            {
                var queryKor = from a in context.users where a.idUser == idUser select a;
                var queryLic = from a in context.user_licences where a.idUser == idUser select a;

                foreach (var u in queryLic)
                {
                    context.user_licences.DeleteOnSubmit(u);
                    context.SubmitChanges();
                }
                foreach (var p in queryKor)
                {
                    context.users.DeleteOnSubmit(p);
                    context.SubmitChanges();
                }
            }
        }

        [OperationContract]
        public ObservableCollection<mitarbeiter> PretraziRadnika(string ime)
        {
            ObservableCollection<mitarbeiter> ListaTrazenihRadnika = new ObservableCollection<mitarbeiter>();
            using (DataBaseModelDataContext context = new DataBaseModelDataContext())
            {
                var query = from a in context.mitarbeiters where SqlMethods.Like(a.vorname, "%"+ime+"%") select a;
                foreach (var p in query)
                {
                    ListaTrazenihRadnika.Add(new mitarbeiter
                    {
                        idMit=p.idMit,
                        mitarbeiterNr=p.mitarbeiterNr,
                        tip=p.tip,
                        vorname=p.vorname,
                        name=p.name,
                        adresse=p.adresse,
                        tel1=p.tel1,
                        tel2=p.tel2,
                        handy=p.handy,
                        fax=p.fax,
                        email=p.email,
                        zarada=p.zarada,
                        satnica=p.satnica,
                        urlaub_ist=p.urlaub_ist,
                        urlaub_soll=p.urlaub_soll,
                        broj_plate=p.broj_plate,
                        wochen_std=p.wochen_std,
                        krankheit=p.krankheit,
                        bank=p.bank,
                        BLZ=p.BLZ,
                        BIC=p.BIC,
                        KtoNr=p.KtoNr,
                        IBAN=p.IBAN,
                        kontoinhaber=p.kontoinhaber,
                        notiz=p.notiz,
                        datum=p.datum,
                        idUser=p.idUser,
                        folder=p.folder,
                        status=p.status


                    });

                }
                return ListaTrazenihRadnika;
            }
        }
        [OperationContract]
        public ObservableCollection<lieferant> PretraziDobavljaca(string ime)
        {
            ObservableCollection<lieferant> ListaTrazenihDobavljaca = new ObservableCollection<lieferant>();
            using (DataBaseModelDataContext context = new DataBaseModelDataContext())
            {
                var query = from a in context.lieferants where SqlMethods.Like(a.vorname, "%" + ime + "%") select a;

                foreach (var p in query)
                {
                    ListaTrazenihDobavljaca.Add(
                         new lieferant { 
                        idLief=p.idLief,
                        lieferantNr=p.lieferantNr,
                        tip=p.tip,
                        vorname=p.vorname,
                        name=p.name,
                        adresse=p.adresse,
                        tel1=p.tel1,
                        tel2=p.tel2,
                        handy=p.handy,
                        skype=p.skype,
                        fax=p.fax,
                        email=p.email,
                        bank=p.bank,
                        BLZ=p.BLZ,
                        KtoNr=p.KtoNr,
                        BIC=p.BIC,
                        IBAN=p.IBAN,
                        kontoinhaber=p.kontoinhaber,
                        notiz=p.notiz,
                        idUser=p.idUser,
                        promet=p.promet,
                        zahlweise=p.zahlweise,
                        land=p.land,
                        poslovanje=p.poslovanje,
                        rabat=p.rabat,
                        tage=p.tage,
                        zahlbar=p.zahlbar,                        
                        
                        stauer=p.stauer

                    
                        });

                }
                return ListaTrazenihDobavljaca;
            }
        }

        [OperationContract]
        public void changeUserPocetnaOrAktivan(int tip, int idUser, bool value)
        {
            using (DataBaseModelDataContext context = new DataBaseModelDataContext())
            {
                try
                {
                    user korisnik = context.users.Single(e => e.idUser == idUser);

                    if (tip == 1)
                    { korisnik.startseit = value; }
                    else if (tip == 2)
                    { korisnik.active = value; }

                    context.SubmitChanges();
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
        }
        [OperationContract]
        public void ChangeWorkerStatus(int idRadnika,bool status)
        {
            using (DataBaseModelDataContext context = new DataBaseModelDataContext())
            {
                try
                {
                    mitarbeiter radnik = context.mitarbeiters.Single(e => e.idMit == idRadnika);
                    radnik.status = status;
                    context.SubmitChanges();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        [OperationContract]
        public void unesiBug(string bugText, int idUser, bool status, string date)
        {

            using (DataBaseModelDataContext context = new DataBaseModelDataContext())
            { 
            try
            {
                bug greske = new bug();
                greske.user_id = idUser;
                greske.bug1 = bugText;
                greske.status = status;
                greske.datum =date;

                context.tbl_greskes.InsertOnSubmit(greske);
                context.SubmitChanges();
            }
                catch(Exception e)
            {
                throw e;
            }
            }
        }

        [OperationContract]
        public ObservableCollection<bug> ListaBugova()
        {
            ObservableCollection<bug> Lista = new ObservableCollection<bug>();
            using (DataBaseModelDataContext context = new DataBaseModelDataContext())
            {
                var x = from a in context.bugs select a;
                Lista.Clear();
                foreach (var p in x)
                {
                    Lista.Add(new bug
                    {
                        user_id = p.user_id,
                        bug1 = p.bug1,
                        status = p.status,
                        datum = p.datum
                    });
                }

            }
            return Lista;
        }

        [OperationContract]
        public void changeBugStatus(string datum , bool statusValue)
        {
            using (DataBaseModelDataContext context = new DataBaseModelDataContext())
            {
                try
                {
                    bug greske = context.bugs.Single(e => e.datum == datum);                
                    greske.status = statusValue;
                    context.SubmitChanges();
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
        }

        [OperationContract]
        public void DeleteBug(string datum)
        {
            using (DataBaseModelDataContext context = new DataBaseModelDataContext())
            {
                var query = from a in context.bugs where a.datum == datum select a;

                foreach (var p in query)
                {
                    context.bugs.DeleteOnSubmit(p);
                    context.SubmitChanges();
                }
            }
        }

        [OperationContract]
        public int MitarbeiterNr()
        {
            using (DataBaseModelDataContext context = new DataBaseModelDataContext())
            {
                var x = (from a in context.mitarbeiters select new { a.mitarbeiterNr }).ToList().LastOrDefault();
                if (x == null)
                    return 1000;
                else
                    return x.mitarbeiterNr + 1;
            }
        }

        [OperationContract]
        public int LieferantNr()
        {
            using (DataBaseModelDataContext context = new DataBaseModelDataContext())
            {
                var x = (from a in context.lieferants select new { a.lieferantNr }).ToList().LastOrDefault();
                if (x == null)
                    return 1000;
                else
                    return x.lieferantNr + 1;
            }
        }

        [OperationContract]
        public int KundenNr()
        {
            using (DataBaseModelDataContext context = new DataBaseModelDataContext())
            {
                var x = (from a in context.kundens select new { a.kundeNr }).ToList().LastOrDefault();
                if (x == null)
                    return 1000;
                else
                    return x.kundeNr + 1;
            }
        }

        [OperationContract]
        public int AngebotNr()
        {
            using (DataBaseModelDataContext context = new DataBaseModelDataContext())
            {
                var x = (from a in context.angebots select new { a.angebotnr }).ToList().LastOrDefault();
                if (x == null)
                    return 1000;
                else
                    return x.angebotnr + 1;
            }
        }

        [OperationContract]
        public ObservableCollection<tbl_poruka_primljene> ListaPrimljenihPoruka(int id)
        {
            ObservableCollection<tbl_poruka_primljene> Lista = new ObservableCollection<tbl_poruka_primljene>();
            using (DataBaseModelDataContext context = new DataBaseModelDataContext())
            {
                var x = from a in context.tbl_poruka_primljenes where a.primio == id select a;
                Lista.Clear();
                foreach (var p in x)
                {
                    Lista.Add(new tbl_poruka_primljene { 
                        id_poruka_primljene=p.id_poruka_primljene,
                        poslao=p.poslao,
                        primio=p.primio,
                        datum=p.datum,
                        procitano=p.procitano,
                        predmet=p.predmet,
                        naslov=p.naslov
                    });
                }
            }
            return Lista;
        }

        [OperationContract]
        public ObservableCollection<tbl_poruka_poslane> ListaPoslanihPoruka(int id)
        {
            ObservableCollection<tbl_poruka_poslane> Lista = new ObservableCollection<tbl_poruka_poslane>();
            using (DataBaseModelDataContext context = new DataBaseModelDataContext())
            {
                var x = from a in context.tbl_poruka_poslanes where a.poslao == id select a;
                Lista.Clear();
                foreach(var p in x)
                {
                    Lista.Add(new tbl_poruka_poslane
                    {
                        id_poruka_poslane=p.id_poruka_poslane,
                        poslao=p.poslao,
                        primio=p.primio,
                        datum=p.datum,
                        predmet=p.predmet,
                        naslov=p.naslov
                    });
                }
            }
            return Lista;
        }

        [OperationContract]
        public void PosaljiPoruku(int primio, int poslao, string predmet,string naslov)
        {
            using (DataBaseModelDataContext context = new DataBaseModelDataContext())
            {
                tbl_poruka_primljene poruka = new tbl_poruka_primljene();
                poruka.naslov = naslov;
                poruka.poslao = poslao;
                poruka.predmet = predmet;
                poruka.primio = primio;
                poruka.procitano = false;
                poruka.datum = DateTime.Now;
                context.tbl_poruka_primljenes.InsertOnSubmit(poruka);
              

                tbl_poruka_poslane poslana = new tbl_poruka_poslane();
                poslana.naslov = naslov;
                poslana.poslao = poslao;
                poslana.predmet = predmet;
                poslana.datum = DateTime.Now;
                poslana.primio = primio;
                context.tbl_poruka_poslanes.InsertOnSubmit(poslana);
                context.SubmitChanges();
                
            }
        }

        [OperationContract]
        public ObservableCollection<kunden> ListaKupacaSearch(int broj)
        {
            ObservableCollection<kunden> Lista = new ObservableCollection<kunden>();
            using (DataBaseModelDataContext context = new DataBaseModelDataContext())
            {
                var query = from a in context.kundens where a.kundeNr.ToString().Contains("/'"+broj+"'/")  select a;
                Lista.Clear();
                foreach (var p in query)
                {
                    Lista.Add(new kunden
                    {
                        idKunde = p.idKunde,
                        suchbegriff = p.suchbegriff,
                        vorname = p.vorname,
                        name = p.name,
                        l_plz_ort = p.l_plz_ort,
                        gruppe = p.gruppe,
                        freifeld1 = p.freifeld1,
                        name2 = p.name2,
                        strasse = p.strasse,
                        tel1 = p.tel1,
                        tel2 = p.tel2,
                        fax = p.fax,
                        mail = p.mail,
                        lk = p.lk,
                        dostava_na = p.dostava_na,
                        dostava_od = p.dostava_od,
                        VKPreisgr = p.VKPreisgr,
                        gotovina = p.gotovina,
                        popust_gotovina = p.popust_gotovina,
                        dnevni_popust = p.dnevni_popust,
                        vertreter = p.vertreter,
                        limit_narudzbe = p.limit_narudzbe,
                        tip = p.tip,
                        lieferadresse = p.lieferadresse,
                        rechnungsadresse = p.rechnungsadresse,
                        email2 = p.email2,
                        internet = p.internet,
                        kundetype = p.kundetype,
                        steuer = p.steuer,
                        broj = p.broj,
                        broj_detalji = p.broj_detalji,
                        kundenbewertung = p.kundenbewertung,
                        notiz = p.notiz,
                        naziv = p.naziv,
                        land = p.land,
                        placa = p.placa,
                        rabat = p.rabat,
                        adresse2 = p.adresse2,
                        stadt = p.stadt,
                        predmet = p.predmet,
                        anssprechepartner = p.anssprechepartner,
                        notiz_route = p.notiz_route,
                        titel = p.titel,
                        kundeNr = p.kundeNr
                    });
                }
                return Lista;
            }
        }

        [OperationContract]
        public ObservableCollection<materijal> getMaterijal() 
        {
            ObservableCollection<materijal> ListaM = new ObservableCollection<materijal>();
            using (DataBaseModelDataContext context = new DataBaseModelDataContext()) 
            {
                var x = from a in context.materijals select a;
                ListaM.Clear();
                foreach (var p in x) 
                {
                    ListaM.Add(new materijal { id = p.id, naziv = p.naziv});
                }
            }
            return ListaM;
        }
        [OperationContract]
        public ObservableCollection<produkt> getProdukt() 
        {
            ObservableCollection<produkt> ListaP = new ObservableCollection<produkt>();
            using (DataBaseModelDataContext context = new DataBaseModelDataContext()) 
            {
                var x = from a in context.produkts select a;
                ListaP.Clear();
                foreach (var p in x)
                {
                    ListaP.Add(new produkt { idprodukt = p.idprodukt, naziv = p.naziv});
                }
            }
            return ListaP;
        }
        [OperationContract]
        public ObservableCollection<oberflache> getPovrsinaByMaterijal(int matId) 
        {
            ObservableCollection<oberflache> ListP = new ObservableCollection<oberflache>();
            using (DataBaseModelDataContext context = new DataBaseModelDataContext()) 
            {
                var x = from a in context.oberflaches where a.materijal == matId select a;
                ListP.Clear();
                foreach (var p in x)
                {
                    ListP.Add(new oberflache{id = p.id, materijal = p.materijal, pov = p.pov});
                }
            }
            return ListP;
        }
        [OperationContract]
        public ObservableCollection<starke> getDebljinaByProduktId(int prodId)
        {
            ObservableCollection<starke> ListaD = new ObservableCollection<starke>();
            using (DataBaseModelDataContext context = new DataBaseModelDataContext()) 
            {
                var x = from a in context.starkes where a.idprodukt == prodId select a;
                ListaD.Clear();
                foreach (var p in x) 
                {
                    ListaD.Add(new starke {id = p.id, idprodukt = p.idprodukt, starke1 = p.starke1});
                }
            }
            return ListaD;
        }
        [OperationContract]
        public ObservableCollection<materijal> getMatIdByName(string value) 
        {
            ObservableCollection<materijal> ListaM = new ObservableCollection<materijal>();
            using(DataBaseModelDataContext context = new DataBaseModelDataContext())
            {
                var x = from a in context.materijals where a.naziv == value select a;
                ListaM.Clear();
                foreach(var p in x)
                {
                    ListaM.Add(new materijal { id = p.id, naziv = p.naziv});
                }
                return ListaM;
            }
        }
        [OperationContract]
        public ObservableCollection<produkt> getProIdByName(string value)
        {
            ObservableCollection<produkt> ListP = new ObservableCollection<produkt>();
            using (DataBaseModelDataContext context = new DataBaseModelDataContext())
            {
                var x = from a in context.produkts where a.naziv == value select a;
                ListP.Clear();
                foreach (var p in x)
                {
                    ListP.Add(new produkt { idprodukt = p.idprodukt, naziv = p.naziv });
                }
            }
            return ListP;
        }
        [OperationContract]
        public ObservableCollection<starke> getDebljinaIdByName(string value)
        {
            ObservableCollection<starke> ListP = new ObservableCollection<starke>();
            using (DataBaseModelDataContext context = new DataBaseModelDataContext())
            {
                var x = from a in context.starkes where a.starke1 == value select a;
                ListP.Clear();
                foreach (var p in x)
                {
                    ListP.Add(new starke { id = p.id, idprodukt = p.idprodukt, starke1 = p.starke1 });
                }
            }
            return ListP;
        }

        [OperationContract]
        public ObservableCollection<mit_kalendar> ListaEventaMitarbeiter()
        {
            ObservableCollection<mit_kalendar> Lista = new ObservableCollection<mit_kalendar>();
            using (DataBaseModelDataContext context = new DataBaseModelDataContext())
            {
                var x = from a in context.mit_kalendars select a;
                Lista.Clear();
                foreach (var p in x)
                {
                    Lista.Add(new mit_kalendar
                    {
                        id = p.id,
                        idUser = p.idUser,
                        datum = p.datum,
                        datum1 = p.datum1datu1,
                        tip = p.tip,
                        odobreno = p.odobreno,
                        pogledano = p.pogledano,
                        notiz = p.notiz
                    
                    });
                }

            }
            return Lista;
        }

        [OperationContract]
        public void UnesiEventMitarbeiter(mit_kalendar mit_kalendar, int id)
        {
            mit_kalendar mk = new mit_kalendar();
            using (DataBaseModelDataContext context = new DataBaseModelDataContext())
            {
                mk.idUser = id;
                mk.notiz = mit_kalendar.notiz;
                mk.datum1 = mit_kalendar.datum1;
                mk.datum = mit_kalendar.datum;
                mk.tip = mit_kalendar.tip;
                mk.odobreno = false;
                mk.pogledano = false;
                context.mit_kalendars.InsertOnSubmit(mk);
                context.SubmitChanges();
            }
        }
    }
}
   

