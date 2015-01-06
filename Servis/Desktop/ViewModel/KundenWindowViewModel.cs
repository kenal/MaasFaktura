using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Desktop.Service;
using Servis.HelperClass;
using System.Windows.Input;
using System.Collections.ObjectModel;
using System.Data;
using System.Windows;
using Mass.Data;
namespace Desktop.ViewModel
{
    public class KundenWindowViewModel: INotifyPropertyChanged, IDataErrorInfo
    {
        #region Fields
        int _idKunde;
        int _kundeNr;
        string _suchbegriff;        
        string _vorname;        
        string _name;
        string _l_plz_ort;        
        string _gruppe;        
        string _freifeld1;        
        string _name2;                
        string _strasse;        
        string _tel1;        
        string _tel2;        
        string _fax;        
        string _mail;       
        string _lk;        
        string _vorlage_am;        
        string _vorlage_anlass;        
        string _VKPreisgr;        
        string _zahlungin;        
        string _skonto;        
        string _skontotage;        
        string _vertreter;        
        string _ufragssperre;        
        int _anreden;        
        string _lieferadresse;        
        string _rechnungsadresse;        
        string _email2;        
        string _internet;        
        int? _kundetype;        
        int? _steuer;        
        int _zahlweise;        
        string _zahl_beding;        
        int _kundenbewertung;       
        string _notiz;
        string _titel;
        string _land;
        string _zahlbar;        
        string _rabat;        
        string _adresse2;        
        string _stadt;        
        string _anredeans;        
        string _anssprechepartner;        
        string _notiz_route;
        MassServisClient client = new MassServisClient();
        private List<string> nacinPlacanja = new List<string>() { "Barverkauf", "Bankeinzug", "Kreditkarte", "Nachnahme", "Rechnung", "Scheck", "Vorkasse" };
        ObservableCollection<kunden> ListaKupaca;       
        kunden selektovaniKupac = new kunden();
        bool radioHer;
        bool radioFrau;
        bool radioFirma;
        bool radioFam;
        bool radioSteuer1;
        bool radioSteuer2;
        bool radioSteuer3;

        int _idKundeEdit;
        int _kundeNrEdit;       
        string _suchbegriffEdit;        
        string _vornameEdit;        
        string _nameEdit;        
        string _titelEdit;        
        string _l_plz_ortEdit;        
        string _gruppeEdit;
        string _freifeld1Edit;        
        string _name2Edit;        
        string _strasseEdit;
        string _tel1Edit;
        string _tel2Edit;
        string _faxEdit;
        string _mailEdit;
        string _lkEdit;
        string _vorlage_amEdit;
        string _vorlage_anlassEdit;
        string _VKPreisgrEdit;
        string _zahlunginEdit;
        string _skontoEdit;
        string _skontotageEdit;
        string _vertreterEdit;
        string _ufragssperreEdit;
        int _anredenEdit;
        string _lieferadresseEdit;
        string _rechnungsadresseEdit;
        string _email2Edit;
        string _internetEdit;
        int? _kundetypeEdit;
        int? _steuerEdit;
        int _zahlweiseEdit;
        string _zahl_bedingEdit;
        int _kundenbewertungEdit;        
        string _notizEdit;        
        string _landEdit;
        string _zahlbarEdit;
        string _rabatEdit;
        string _adresse2Edit;
        string _stadtEdit;
        string _anredeansEdit;
        string _anssprechepartnerEdit;
        string _notiz_routeEdit;
        bool radioHerEdit;
        bool radioFrauEdit;
        bool radioFirmaEdit;
        bool radioFamEdit;
        bool radioSteuer1Edit;
        bool radioSteuer2Edit;
        bool radioSteuer3Edit;
        ObservableCollection<kunden> ListaPage= new ObservableCollection<kunden>();
        int brojStranice =1;

        private int _kolicinaKupaca = 10;

        private List<int> _brojPrikazanihKupaca = new List<int>() { 10, 20, 25 };

        private int _maxStranica;

       

        #endregion

        #region Properties

        public int MaxStranica1
        {
            get { return _maxStranica; }
            set { _maxStranica = value; OnPropertyChanged("MaxStranica1"); }
        }
        public List<int> BrojPrikazanihKupaca
        {
            get { return _brojPrikazanihKupaca; }
            set { _brojPrikazanihKupaca = value; OnPropertyChanged("BrojPrikazanihKupaca"); }
        }

        public int KolicinaKupaca
        {
            get { return _kolicinaKupaca; }
            set { _kolicinaKupaca = value; OnPropertyChanged("KolicinaKupaca"); }
        }
        public Action CloseAction { get; set; }
        public int IdKunde
        {
            get { return _idKunde; }
            set 
            {
                _idKunde = value;
                OnPropertyChanged("IdKunde");
            }
        }

        public int KundeNr
        {
            get { return _kundeNr; }
            set 
            { 
                _kundeNr = value;
                OnPropertyChanged("KundeNr");
            }
        }

        public string Suchbegriff
        {
            get { return _suchbegriff; }
            set 
            { 
                _suchbegriff = value;
                OnPropertyChanged("Suchbegriff"); 
            }
        }        

        public string Vorname
        {
            get { return _vorname; }
            set 
            { 
                _vorname = value;
                OnPropertyChanged("Vorname");
            }
        }

        public string Name
        {
            get { return _name; }
            set 
            { 
                _name = value;
                OnPropertyChanged("Name");
            }
        }

        
        public string Titel
        {
            get { return _titel; }
            set 
            { 
                _titel = value;
                OnPropertyChanged("Titel");
            }
        }

        public string L_plz_ort
        {
            get { return _l_plz_ort; }
            set 
            { 
                _l_plz_ort = value;
                OnPropertyChanged("L_plz_ort");
            }
        }

        public string Gruppe
        {
            get { return _gruppe; }
            set 
            { 
                _gruppe = value;
                OnPropertyChanged("Gruppe");
            }
        }

        public string Freifeld1
        {
            get { return _freifeld1; }
            set 
            { 
                _freifeld1 = value;
                OnPropertyChanged("Freifeld1");
            }
        }

        public string Name2
        {
            get { return _name2; }
            set 
            { 
                _name2 = value;
                OnPropertyChanged("Name2");
            }
        }

        public string Strasse
        {
            get { return _strasse; }
            set 
            { 
                _strasse = value;
                OnPropertyChanged("Strasse");
            }
        }

        public string Tel1
        {
            get { return _tel1; }
            set 
            { 
                _tel1 = value;
                OnPropertyChanged("Tel1");
            }
        }

        public string Tel2
        {
            get { return _tel2; }
            set 
            { 
                _tel2 = value;
                OnPropertyChanged("Tel2");
            }
        }

        public string Fax
        {
            get { return _fax; }
            set 
            { 
                _fax = value;
                OnPropertyChanged("Fax");
            }
        }

        public string Mail
        {
            get { return _mail; }
            set 
            { 
                _mail = value;
                OnPropertyChanged("Mail");
            }
        }

        public string Lk
        {
            get { return _lk; }
            set 
            { 
                _lk = value;
                OnPropertyChanged("Lk");
            }
        }

        public string Vorlage_am
        {
            get { return _vorlage_am; }
            set 
            { 
                _vorlage_am = value;
                OnPropertyChanged("Vorlage_am");
            }
        }

        public string Vorlage_anlass
        {
            get { return _vorlage_anlass; }
            set 
            { 
                _vorlage_anlass = value;
                OnPropertyChanged("Vorlage_anlass");
            }
        }

        public string VKPreisgr
        {
            get { return _VKPreisgr; }
            set 
            { 
                _VKPreisgr = value;
                OnPropertyChanged("VKPreisgr");
            }
        }

        public string Zahlungin
        {
            get { return _zahlungin; }
            set 
            { 
                _zahlungin = value;
                OnPropertyChanged("Zahlungin");
            }
        }

        public string Skonto
        {
            get { return _skonto; }
            set 
            { 
                _skonto = value;
                OnPropertyChanged("Skonto");
            }
        }

        public string Skontotage
        {
            get { return _skontotage; }
            set 
            { 
                _skontotage = value;
                OnPropertyChanged("Skontotage");
            }
        }

        public string Vertreter
        {
            get { return _vertreter; }
            set
            {
                _vertreter = value;
                OnPropertyChanged("Vertreter");
            }
        }

        public string Ufragssperre
        {
            get { return _ufragssperre; }
            set 
            { 
                _ufragssperre = value;
                OnPropertyChanged("Ufragssperre");
            }
        }

        public int Anreden
        {
            get { return _anreden; }
            set 
            { 
                _anreden = value;
                OnPropertyChanged("Anreden");
            }
        }

        public string Lieferadresse
        {
            get { return _lieferadresse; }
            set 
            { 
                _lieferadresse = value;
                OnPropertyChanged("Lieferadresse");
            }
        }

        public string Rechnungsadresse
        {
            get { return _rechnungsadresse; }
            set 
            { 
                _rechnungsadresse = value;
                OnPropertyChanged("Rechnungsadresse");
            }
        }

        public string Email2
        {
            get { return _email2; }
            set 
            { 
                _email2 = value;
                OnPropertyChanged("Email2");
            }
        }

        public string Internet
        {
            get { return _internet; }
            set 
            { 
                _internet = value;
                OnPropertyChanged("Internet");
            }
        }

        public int? Kundetype
        {
            get { return _kundetype; }
            set 
            { 
                _kundetype = value;
                OnPropertyChanged("Kundetype");
            }
        }

        public int? Steuer
        {
            get { return _steuer; }
            set 
            { 
                _steuer = value;
                OnPropertyChanged("Steuer");
            }
        }

        public int Zahlweise
        {
            get { return _zahlweise; }
            set 
            { 
                _zahlweise = value;
                OnPropertyChanged("Zahlweise");
            }
        }

        public string Zahl_beding
        {
            get { return _zahl_beding; }
            set 
            { 
                _zahl_beding = value;
                OnPropertyChanged("Zahl_beding");
            }
        }

        public int Kundenbewertung
        {
            get { return _kundenbewertung; }
            set 
            { 
                _kundenbewertung = value;
                OnPropertyChanged("Kundenbewertung");
            }
        }

        public string Notiz
        {
            get { return _notiz; }
            set 
            { 
                _notiz = value;
                OnPropertyChanged("Notiz");
            }
        }

        

        public string Land
        {
            get { return _land; }
            set 
            {
                _land = value;
                OnPropertyChanged("Land");
            }
        }

        public string Zahlbar
        {
            get { return _zahlbar; }
            set 
            { 
                _zahlbar = value;
                OnPropertyChanged("Zahlbar");
            }
        }

        public string Rabat
        {
            get { return _rabat; }
            set 
            { 
                _rabat = value;
                OnPropertyChanged("Rabat");
            }
        }

        public string Adresse2
        {
            get { return _adresse2; }
            set 
            { 
                _adresse2 = value;
                OnPropertyChanged("Adresse2");
            }
        }

        public string Stadt
        {
            get { return _stadt; }
            set 
            { 
                _stadt = value;
                OnPropertyChanged("Stadt");
            }
        }

        public string Anredeans
        {
            get { return _anredeans; }
            set 
            { 
                _anredeans = value;
                OnPropertyChanged("Anredeans");
            }
        }

        public string Anssprechepartner
        {
            get { return _anssprechepartner; }
            set 
            { 
                _anssprechepartner = value;
                OnPropertyChanged("Anssprechepartner");
            }
        }

        public string Notiz_route
        {
            get { return _notiz_route; }
            set 
            { 
                _notiz_route = value;
                OnPropertyChanged("Notiz_route");
            }
        }

        public List<string> NacinPlacanja
        {
            get { return nacinPlacanja; }
            set 
            { 
                nacinPlacanja = value;
                OnPropertyChanged("NacinPlacanja");
            }
        }

        public ObservableCollection<kunden> ListaKupaca1
        {
            get { return ListaKupaca; }
            set 
            { 
                ListaKupaca = value;
                OnPropertyChanged("ListaKupaca1");
            }
        }

        public ObservableCollection<kunden> ListaPage1
        {
            get { return ListaPage; }
            set 
            { 
                ListaPage = value;
                OnPropertyChanged("ListaPage1");
            }
        }

        public kunden SelektovaniKupac
        {
            get { return selektovaniKupac; }
            set 
            { 
                selektovaniKupac = value;
                OnPropertyChanged("SelektovaniKupac");
            }
        }

        public bool RadioHer
        {
            get { return radioHer; }
            set 
            { 
                radioHer = value;
                OnPropertyChanged("RadioHer");
            }
        }

        public bool RadioFrau
        {
            get { return radioFrau; }
            set 
            { 
                radioFrau = value;
                OnPropertyChanged("RadioFrau");
            }
        }

        public bool RadioFirma
        {
            get { return radioFirma; }
            set 
            { 
                radioFirma = value;
                OnPropertyChanged("RadioFirma");
            }
        }

        public bool RadioFam
        {
            get { return radioFam; }
            set 
            { 
                radioFam = value;
                OnPropertyChanged("RadioFam");
            }
        }

        public bool RadioSteuer1
        {
            get { return radioSteuer1; }
            set 
            { 
                radioSteuer1 = value;
                OnPropertyChanged("RadioSteuer1");
            }
        }

        public bool RadioSteuer2
        {
            get { return radioSteuer2; }
            set 
            { 
                radioSteuer2 = value;
                OnPropertyChanged("RadioSteuer2");
            }
        }

        public bool RadioSteuer3
        {
            get { return radioSteuer3; }
            set 
            { 
                radioSteuer3 = value;
                OnPropertyChanged("RadioSteuer3");
            }
        }

        public int IdKundeEdit
        {
            get { return _idKundeEdit; }
            set 
            { 
                _idKundeEdit = value;
                OnPropertyChanged("IdKundeEdit");
            }
        }

        public int KundeNrEdit
        {
            get { return _kundeNrEdit; }
            set 
            { 
                _kundeNrEdit = value;
                OnPropertyChanged("KundeNrEdit");
            }
        }

        public string SuchbegriffEdit
        {
            get { return _suchbegriffEdit; }
            set 
            { 
                _suchbegriffEdit = value;
                OnPropertyChanged("SuchbegriffEdit");
            }
        }

        public string VornameEdit
        {
            get { return _vornameEdit; }
            set 
            { 
                _vornameEdit = value;
                OnPropertyChanged("VornameEdit");
            }
        }

        public string NameEdit
        {
            get { return _nameEdit; }
            set 
            { 
                _nameEdit = value;
                OnPropertyChanged("NameEdit");
            }
        }

        public string TitelEdit
        {
            get { return _titelEdit; }
            set 
            { 
                _titelEdit = value;
                OnPropertyChanged("TitelEdit");
            }
        }

        public string L_plz_ortEdit
        {
            get { return _l_plz_ortEdit; }
            set 
            { 
                _l_plz_ortEdit = value;
                OnPropertyChanged("L_plz_ortEdit");
            }
        }

        public string GruppeEdit
        {
            get { return _gruppeEdit; }
            set 
            { 
                _gruppeEdit = value;
                OnPropertyChanged("GruppeEdit");
            }
        }

        public string Freifeld1Edit
        {
            get { return _freifeld1Edit; }
            set 
            { 
                _freifeld1Edit = value;
                OnPropertyChanged("Freifeld1Edit");
            }
        }

        public string Name2Edit
        {
            get { return _name2Edit; }
            set 
            { 
                _name2Edit = value;
                OnPropertyChanged("Name2Edit");
            }
        }

        public string StrasseEdit
        {
            get { return _strasseEdit; }
            set 
            { 
                _strasseEdit = value;
                OnPropertyChanged("StrasseEdit");
            }
        }

        public string Tel1Edit
        {
            get { return _tel1Edit; }
            set 
            { 
                _tel1Edit = value;
                OnPropertyChanged("Tel1Edit");
            }
        }

        public string Tel2Edit
        {
            get { return _tel2Edit; }
            set 
            { 
                _tel2Edit = value;
                OnPropertyChanged("Tel2Edit");
            }
        }

        public string FaxEdit
        {
            get { return _faxEdit; }
            set 
            { 
                _faxEdit = value;
                OnPropertyChanged("FaxEdit");
            }
        }

        public string MailEdit
        {
            get { return _mailEdit; }
            set 
            { 
                _mailEdit = value;
                OnPropertyChanged("MailEdit");
            }
        }

        public string LkEdit
        {
            get { return _lkEdit; }
            set 
            { 
                _lkEdit = value;
                OnPropertyChanged("LkEdit");
            }
        }

        public string Vorlage_amEdit
        {
            get { return _vorlage_amEdit; }
            set 
            { 
                _vorlage_amEdit = value;
                OnPropertyChanged("Vorlage_amEdit");
            }
        }

        public string Vorlage_anlassEdit
        {
            get { return _vorlage_anlassEdit; }
            set 
            {
                _vorlage_anlassEdit = value;
                OnPropertyChanged("Vorlage_anlassEdit");
            }
        }

        public string VKPreisgrEdit
        {
            get { return _VKPreisgrEdit; }
            set 
            { 
                _VKPreisgrEdit = value;
                OnPropertyChanged("VKPreisgrEdit");
            }
        }

        public string ZahlunginEdit
        {
            get { return _zahlunginEdit; }
            set 
            { 
                _zahlunginEdit = value;
                OnPropertyChanged("ZahlunginEdit");
            }
        }

        public string SkontoEdit
        {
            get { return _skontoEdit; }
            set 
            { 
                _skontoEdit = value;
                OnPropertyChanged("SkontoEdit");
            }
        }

        public string SkontotageEdit
        {
            get { return _skontotageEdit; }
            set 
            { 
                _skontotageEdit = value;
                OnPropertyChanged("SkontotageEdit");
            }
        }

        public string VertreterEdit
        {
            get { return _vertreterEdit; }
            set 
            { 
                _vertreterEdit = value;
                OnPropertyChanged("VertreterEdit");
            }
        }

        public string UfragssperreEdit
        {
            get { return _ufragssperreEdit; }
            set 
            { 
                _ufragssperreEdit = value;
                OnPropertyChanged("UfragssperreEdit");
            }
        }

        public int AnredenEdit
        {
            get { return _anredenEdit; }
            set 
            { 
                _anredenEdit = value;
                OnPropertyChanged("AnredenEdit");
            }
        }

        public string LieferadresseEdit
        {
            get { return _lieferadresseEdit; }
            set 
            { 
                _lieferadresseEdit = value;
                OnPropertyChanged("LieferadresseEdit");
            }
        }

        public string RechnungsadresseEdit
        {
            get { return _rechnungsadresseEdit; }
            set 
            { 
                _rechnungsadresseEdit = value;
                OnPropertyChanged("RechnungsadresseEdit");
            }
        }

        public string Email2Edit
        {
            get { return _email2Edit; }
            set 
            { 
                _email2Edit = value;
                OnPropertyChanged("Email2Edit");
            }
        }

        public string InternetEdit
        {
            get { return _internetEdit; }
            set 
            { 
                _internetEdit = value;
                OnPropertyChanged("InternetEdit");
            }
        }

        public int? KundetypeEdit
        {
            get { return _kundetypeEdit; }
            set 
            { 
                _kundetypeEdit = value;
                OnPropertyChanged("KundetypeEdit");
            }
        }

        public int? SteuerEdit
        {
            get { return _steuerEdit; }
            set 
            { 
                _steuerEdit = value;
                OnPropertyChanged("SteuerEdit");
            }
        }

        public int ZahlweiseEdit
        {
            get { return _zahlweiseEdit; }
            set 
            { 
                _zahlweiseEdit = value;
                OnPropertyChanged("ZahlweiseEdit");
            }
        }

        public string Zahl_bedingEdit
        {
            get { return _zahl_bedingEdit; }
            set 
            { 
                _zahl_bedingEdit = value;
                OnPropertyChanged("Zahl_bedingEdit");
            }
        }

        public int KundenbewertungEdit
        {
            get { return _kundenbewertungEdit; }
            set 
            { 
                _kundenbewertungEdit = value;
                OnPropertyChanged("KundenbewertungEdit");
            }
        }

        public string NotizEdit
        {
            get { return _notizEdit; }
            set 
            { 
                _notizEdit = value;
                OnPropertyChanged("NotizEdit");
            }
        }

        public string LandEdit
        {
            get { return _landEdit; }
            set 
            { 
                _landEdit = value;
                OnPropertyChanged("LandEdit");
            }
        }

        public string ZahlbarEdit
        {
            get { return _zahlbarEdit; }
            set 
            { 
                _zahlbarEdit = value;
                OnPropertyChanged("ZahlbarEdit");
            }
        }

        public string RabatEdit
        {
            get { return _rabatEdit; }
            set 
            { 
                _rabatEdit = value;
                OnPropertyChanged("RabatEdit");
            }
        }

        public string Adresse2Edit
        {
            get { return _adresse2Edit; }
            set 
            { 
                _adresse2Edit = value;
                OnPropertyChanged("Adresse2Edit");
            }
        }

        public string StadtEdit
        {
            get { return _stadtEdit; }
            set 
            { 
                _stadtEdit = value;
                OnPropertyChanged("StadtEdit");
            }
        }

        public string AnredeansEdit
        {
            get { return _anredeansEdit; }
            set 
            { 
                _anredeansEdit = value;
                OnPropertyChanged("AnredeansEdit");
            }
        }

        public string AnssprechepartnerEdit
        {
            get { return _anssprechepartnerEdit; }
            set 
            { 
                _anssprechepartnerEdit = value;
                OnPropertyChanged("AnssprechepartnerEdit");
            }
        }

        public string Notiz_routeEdit
        {
            get { return _notiz_routeEdit; }
            set 
            { 
                _notiz_routeEdit = value;
                OnPropertyChanged("Notiz_routeEdit");
            }
        }

        public bool RadioHerEdit
        {
            get { return radioHerEdit; }
            set 
            { 
                radioHerEdit = value;
                OnPropertyChanged("RadioHerEdit"); 
            }
        }

        public bool RadioFrauEdit
        {
            get { return radioFrauEdit; }
            set 
            { 
                radioFrauEdit = value;
                OnPropertyChanged("RadioFrauEdit");
            }
        }

        public bool RadioFirmaEdit
        {
            get { return radioFirmaEdit; }
            set 
            { 
                radioFirmaEdit = value;
                OnPropertyChanged("RadioFirmaEdit");
            }
        }

        public bool RadioFamEdit
        {
            get { return radioFamEdit; }
            set 
            { 
                radioFamEdit = value;
                OnPropertyChanged("RadioFamEdit");
            }
        }

        public bool RadioSteuer1Edit
        {
            get { return radioSteuer1Edit; }
            set 
            { 
                radioSteuer1Edit = value;
                OnPropertyChanged("RadioSteuer1Edit");
            }
        }

        public bool RadioSteuer2Edit
        {
            get { return radioSteuer2Edit; }
            set 
            { 
                radioSteuer2Edit = value;
                OnPropertyChanged("RadioSteuer2Edit");
            }
        }

        public bool RadioSteuer3Edit
        {
            get { return radioSteuer3Edit; }
            set 
            { 
                radioSteuer3Edit = value;
                OnPropertyChanged("RadioSteuer3Edit");
            }
        }

        public int BrojStranice
        {
            get { return brojStranice; }
            set { brojStranice = value; OnPropertyChanged("BrojStranice"); }
        }
        #endregion

        #region ICommandMembers
        private ICommand odustaniUnos;
        public ICommand OdustaniUnos
        {
            get { return odustaniUnos = new RelayCommand(param => Odustani(param)); }
            set { odustaniUnos = value; }
        }

        private ICommand _Unesi;
        public ICommand Unesi
        {
            get { return _Unesi = new RelayCommand(param => InsertKupac(param), param => this.CanSave); }
            set { _Unesi = value; }
        }

        private ICommand _PopuniGrid;

        public ICommand PopuniGrid
        {
            get { return _PopuniGrid = new RelayCommand(param => FillGridKupca(param)); }
            set { _PopuniGrid = value; }
        }

        private ICommand _obrisikupca;

        public ICommand ObrisiKupca
        {
            get { return _obrisikupca = new RelayCommand(param => ObrisiKupac(param)); }
            set { _obrisikupca = value; }
        }

        private ICommand _Update;

        public ICommand Update
        {
            get { return _Update = new RelayCommand(param => PopuniUpdate(param)); }
            set { _Update = value; }
        }

        private ICommand updatajkupca;

        public ICommand UpdatajKupca
        {
            get { return updatajkupca = new RelayCommand(param => IzvrsiUpdate(param), param => this.CanSaveEdit); }
            set { updatajkupca = value; }
        }
        private ICommand _UrediKupca;

        public ICommand UrediKupca1
        {
            get { return _UrediKupca = new RelayCommand(param => OtvoriEditKupac(param)); }
            set { _UrediKupca = value; }
        }
        private ICommand zatvoriWindow;

        public ICommand ZatvoriWindow
        {
            get { return zatvoriWindow = new RelayCommand(param => Close()); }
            set { zatvoriWindow = value; }
        }

        private ICommand _paging;

        public ICommand Paging
        {
            get { return _paging = new RelayCommand(param => FillGridKupcaPage(param)); }
            set { _paging = value; }
        }
        private ICommand _paging2;

        public ICommand Paging2
        {
            get { return _paging2 = new RelayCommand(param => FillGridKupcaPage2(param), param => this.CanNext); }
            set { _paging2 = value; }
        }

        private ICommand _pagingRikverc;

        public ICommand PagingRikverc
        {
            get { return _pagingRikverc = new RelayCommand(param => FillGridKupcaBack(param), param => this.CanLast); }
            set { _pagingRikverc = value; }
        }
        private ICommand _prebaciNaPrvi;

        public ICommand PrebaciNaPrvi
        {
            get { return _prebaciNaPrvi = new RelayCommand(param => FillGridKupcaFirst(param), param => this.CanLast); }
            set { _prebaciNaPrvi = value; }
        }

        private ICommand _promjeniBrojPrikaza;

        public ICommand PromjeniBrojPrikaza
        {
            get { return _promjeniBrojPrikaza = new RelayCommand(param => FillGridKupcaFirst(param)); }
            set { _promjeniBrojPrikaza = value; }
        }

        private ICommand _prebaciNaZadnji;

        public ICommand PrebaciNaZadnji
        {
            get { return _prebaciNaZadnji = new RelayCommand(param => FillGridKupcaLast(param), param => this.CanNext); }
            set { _prebaciNaZadnji = value; }
        }
        #endregion

        #region Methods
        public void Paginacija(int stranica)
        {
            int neUzimati=0;
            
            if (ListaKupaca1 != null)
            {
                int brojPrikaza = stranica * KolicinaKupaca;
                if (brojPrikaza > ListaKupaca1.Count())
                    brojPrikaza = ListaKupaca1.Count();
                int ostatak = brojPrikaza % KolicinaKupaca;
                if (ostatak != 0)
                    neUzimati = brojPrikaza - ostatak;
                else
                    neUzimati = brojPrikaza - KolicinaKupaca;
                var x = ListaKupaca1.Skip(neUzimati).Take(KolicinaKupaca);
                ListaPage1.Clear();
                ListaPage1 = new ObservableCollection<kunden>(x);
            }
            KundeNr = client.KundenNr();
            MaxStranica();
        }
        public void Odustani(object parameter)
        {
            Zahlweise = 0;
            
            Kundetype = 0;
            Vorname = null;
            Name = null;
            Titel = null;
            Name2 = null;
            Stadt = null;
            Lieferadresse = null;
            Rechnungsadresse = null;
            Adresse2 = null;
            Tel1 = null;
            Tel2 = null;
            Fax = null;
            Mail = null;
            Internet = null;
            Skonto = null;
            Skontotage = null;
            Zahlbar = null;
            Rabat = null;
            Notiz = null;

        }

        public void InsertKupac(object parameter)
        {
            Suchbegriff = Name;
            if (RadioHer == true)
                Kundetype = 0;
            else if (RadioFrau == true)
                Kundetype = 1;
            else if (RadioFirma == true)
            {
                Kundetype = 2;
                Suchbegriff = Name2;
            }
                
            else if (RadioFam == true)
                Kundetype = 3;

            if (RadioSteuer1 == true)
                Steuer = 0;
            else if (RadioSteuer2 == true)
                Steuer = 1;
            else if (RadioSteuer3 == true)
                Steuer = 2;

            kunden kupac = new kunden();
            kupac.lieferadresse = Lieferadresse;
            kupac.rechnungsadresse = Rechnungsadresse;
            kupac.adresse2 = Adresse2;
            kupac.notiz = Notiz;
            kupac.zahlweise = Zahlweise.ToString();
            kupac.zahl_beding = Zahl_beding;
            kupac.notiz_route = Notiz_route;
            kupac.skontotage = Skontotage;
            kupac.vorlage_am = Vorlage_am;
            kupac.vorlage_anlass = Vorlage_anlass;
            kupac.fax = Fax;
            kupac.zahlungin = Zahlungin;
            kupac.stadt = Stadt;
            kupac.gruppe = Gruppe;
            kupac.vorname = Vorname;
            kupac.name2 = Name2;
            kupac.internet = Internet;
            kupac.anssprechepartner = Anssprechepartner;
            kupac.ufragssperre = Ufragssperre;
            kupac.lk = Lk;
            kupac.mail = Mail;
            kupac.email2 = Email2;
            kupac.l_plz_ort = L_plz_ort;
            
            kupac.kundenbewertung = Kundenbewertung;
            kupac.zahlbar = Zahlbar;
            kupac.suchbegriff = Suchbegriff;
            kupac.skonto = Skonto;
            kupac.steuer = Steuer;
            kupac.anredeans = Anredeans;
            kupac.vertreter = Vertreter;
            kupac.name = Name;
            kupac.rabat = Rabat;
            kupac.freifeld1 = Freifeld1;
            kupac.tel1 = Tel1;
            kupac.tel2 = Tel2;
            kupac.anreden = Anreden;
            kupac.kundetype = Kundetype;
            kupac.VKPreisgr = VKPreisgr;
            kupac.land = Land;
            kupac.kundeNr = KundeNr.ToString();
            
            client.UnesiKupca(kupac);
            FillGridKupca(parameter);
            Paginacija(BrojStranice);

            Zahlweise = 0;
            Kundetype = 0;
            Vorname = null;
            Name = null;
            Titel = null;
            Name2 = null;
            Stadt = null;
            Lieferadresse = null;
            Rechnungsadresse = null;
            Adresse2 = null;
            Tel1 = null;
            Tel2 = null;
            Fax = null;
            Mail = null;
            Internet = null;
            Skonto = null;
            Skontotage = null;
            Zahlbar = null;
            Rabat = null;
            Notiz = null;
        }

        public void FillGridKupca(object parameter)
        {
            ListaKupaca1 = client.ListaKupaca();
        }
        public void FillGridKupcaPage(object parameter)
        {
            Paginacija(BrojStranice);
        }

        public void FillGridKupcaPage2(object parameter)
        {
            BrojStranice++;
            Paginacija(BrojStranice);
           
        }

        public void FillGridKupcaBack(object parameter)
        {
            BrojStranice--;
            Paginacija(BrojStranice);
        }

        public void FillGridKupcaFirst(object parameter)
        {
            BrojStranice = 1;
            Paginacija(BrojStranice);
        }

        public void FillGridKupcaLast(object parameter)
        {
            if (ListaKupaca1!=null)
            {
                int a = ListaKupaca1.Count();
                double pozicija = Convert.ToDouble(a) / KolicinaKupaca;
                if (pozicija % 1 == 0)
                    BrojStranice = Convert.ToInt32(pozicija);
                else                
                    BrojStranice = Convert.ToInt32(pozicija - ((pozicija * 10) % 10) / 10) + 1;
                Paginacija(BrojStranice);                
            }

        }

        public void MaxStranica()
        {
            if (ListaKupaca1 != null)
            {
                int a = ListaKupaca1.Count();
                double pozicija = Convert.ToDouble(a) / KolicinaKupaca;
                if (pozicija % 1 == 0)
                    MaxStranica1 = Convert.ToInt32(pozicija);
                else
                {
                    MaxStranica1 = Convert.ToInt32(pozicija - ((pozicija * 10) % 10) / 10) + 1;
                }

            }
        }
        
        public void ObrisiKupac(object parameter)
        {
            int br = Convert.ToInt32(SelektovaniKupac.kundeNr);
            client.ObrisiKupca(br);
            FillGridKupca(parameter);
            Paginacija(BrojStranice);

        }

        public void OtvoriEditKupac(object parameter)
        {
            KundenWindowEdit kwe = new KundenWindowEdit(this);
            kwe.Show();

        }
        public void Close()
        {
            CloseAction();
        }
        public void PopuniUpdate(object parameter)
        {
            IdKundeEdit = Convert.ToInt32(selektovaniKupac.idKunde);
            KundeNrEdit = Convert.ToInt32(selektovaniKupac.kundeNr);
            LieferadresseEdit = selektovaniKupac.lieferadresse;
            RechnungsadresseEdit = selektovaniKupac.rechnungsadresse;
            Adresse2Edit = selektovaniKupac.adresse2;
            SuchbegriffEdit = selektovaniKupac.suchbegriff;
            VornameEdit = selektovaniKupac.vorname;
            NameEdit = selektovaniKupac.name;
            L_plz_ortEdit = selektovaniKupac.l_plz_ort;
            GruppeEdit = selektovaniKupac.gruppe;
            Freifeld1Edit = selektovaniKupac.freifeld1;
            Name2Edit = selektovaniKupac.name2;
            StrasseEdit = selektovaniKupac.strasse;
            Tel1Edit = selektovaniKupac.tel1;
            Tel2Edit = selektovaniKupac.tel2;
            FaxEdit = selektovaniKupac.fax;
            MailEdit = selektovaniKupac.mail;
            LkEdit = selektovaniKupac.lk;
            Vorlage_amEdit = selektovaniKupac.vorlage_am;
            Vorlage_anlassEdit = selektovaniKupac.vorlage_anlass;
            VKPreisgrEdit = selektovaniKupac.VKPreisgr;
            ZahlunginEdit = selektovaniKupac.zahlungin;
            SkontoEdit = selektovaniKupac.skonto;
            SkontotageEdit = selektovaniKupac.skontotage;
            VertreterEdit = selektovaniKupac.vertreter;
            UfragssperreEdit = selektovaniKupac.ufragssperre;
            AnredenEdit = Convert.ToInt32(selektovaniKupac.anreden);
            Email2Edit = selektovaniKupac.email2;
            InternetEdit = selektovaniKupac.internet;
            KundetypeEdit = Convert.ToInt32(selektovaniKupac.kundetype);
            SteuerEdit = Convert.ToInt32(selektovaniKupac.steuer);
            ZahlweiseEdit = Convert.ToInt32(selektovaniKupac.zahlweise);
            Zahl_bedingEdit = selektovaniKupac.zahl_beding;
            KundenbewertungEdit = Convert.ToInt32(selektovaniKupac.kundenbewertung);
            NotizEdit = selektovaniKupac.notiz;
            
            LandEdit = selektovaniKupac.land;
            ZahlbarEdit = selektovaniKupac.zahlbar;
            RabatEdit = selektovaniKupac.rabat;
            StadtEdit = selektovaniKupac.stadt;
            AnredeansEdit = selektovaniKupac.anredeans;
            AnssprechepartnerEdit = selektovaniKupac.anssprechepartner;
            Notiz_routeEdit = selektovaniKupac.notiz_route;
            TitelEdit = selektovaniKupac.titel;

            if (selektovaniKupac.kundetype == 0)
                RadioHerEdit = true;
            else if (selektovaniKupac.kundetype == 1)
                RadioFrauEdit = true;
            else if (selektovaniKupac.kundetype == 2)
                RadioFirmaEdit = true;
            else if (selektovaniKupac.kundetype == 3)
                RadioFamEdit = true;

            if (selektovaniKupac.steuer == 0)
                RadioSteuer1Edit = true;
            else if (selektovaniKupac.steuer == 1)
                RadioSteuer2Edit = true;
            else if (selektovaniKupac.steuer == 2)
                RadioSteuer3Edit = true;

            
        }
        public void IzvrsiUpdate(object parameter)
        {
            kunden kupac = new kunden();
            kupac.idKunde = selektovaniKupac.idKunde;
            kupac.lieferadresse = LieferadresseEdit;
            kupac.rechnungsadresse = RechnungsadresseEdit;
            kupac.adresse2 = Adresse2Edit;
            kupac.notiz = NotizEdit;
            kupac.zahlweise = ZahlweiseEdit.ToString();
            kupac.zahl_beding = Zahl_bedingEdit;
            kupac.kundeNr = KundeNrEdit.ToString();
            kupac.notiz_route = Notiz_routeEdit;
            kupac.skontotage = SkontotageEdit;
            kupac.vorlage_am = Vorlage_amEdit;
            kupac.vorlage_anlass = Vorlage_anlassEdit;
            kupac.fax = FaxEdit;
            kupac.zahl_beding = ZahlunginEdit;
            kupac.stadt = StadtEdit;
            kupac.gruppe = GruppeEdit;
            kupac.vorname = VornameEdit;
            kupac.internet = InternetEdit;
            kupac.anssprechepartner = AnssprechepartnerEdit;
            kupac.ufragssperre = UfragssperreEdit;
            kupac.lk = LkEdit;
            kupac.mail = MailEdit;
            kupac.email2 = Email2Edit;
            kupac.l_plz_ort = L_plz_ortEdit;
            
            kupac.kundenbewertung = KundenbewertungEdit;
            kupac.zahlbar = ZahlbarEdit;
            kupac.skonto = SkontoEdit;
            kupac.anredeans = AnredeansEdit;
            kupac.vertreter = VertreterEdit;
            kupac.name = NameEdit;
            kupac.rabat = RabatEdit;
            kupac.freifeld1 = Freifeld1Edit;
            kupac.tel1 = Tel1Edit;
            kupac.tel2 = Tel2Edit;
            kupac.anreden = AnredenEdit;
            kupac.titel = TitelEdit;
            kupac.strasse = StrasseEdit;
            kupac.VKPreisgr = VKPreisgrEdit;
            kupac.land = LandEdit;

            SuchbegriffEdit = NameEdit;
            if (RadioHerEdit == true)
                kupac.kundetype = 0;
            else if (RadioFrauEdit == true)
                kupac.kundetype = 1;
            else if (RadioFirmaEdit == true)
            {
                kupac.kundetype = 2;
                SuchbegriffEdit = Name2Edit;
            }
            else if (RadioFamEdit == true)
                kupac.kundetype = 3;

            if (RadioSteuer1Edit == true)
                SteuerEdit = 0;
            else if (RadioSteuer2Edit == true)
                SteuerEdit = 1;
            else if (RadioSteuer3Edit == true)
                SteuerEdit = 2;
            else
                SteuerEdit = null;
            kupac.suchbegriff = SuchbegriffEdit;
            kupac.steuer = SteuerEdit;
            client.UpdateKupac(kupac);
            FillGridKupca(parameter);
            ZatvoriWindow.Execute(this);
            Paginacija(BrojStranice);

        }
        #endregion

        #region INotifyPropertyChanged Members
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        #endregion

        #region IDataErrorInfo
        public string this[string columnName]
        {
            get
            {
                string Result = null;
                if ("Vorname" == columnName)
                {
                    if (String.IsNullOrEmpty(Vorname))
                        Result = "Unesite ime.";
                }
                else if ("Name" == columnName)
                {
                    if (String.IsNullOrEmpty(Name))
                        Result = "Unesite prezime.";
                }
                else if ("Lieferadresse" == columnName)
                {
                    if (String.IsNullOrEmpty(Lieferadresse))
                        Result = "Unesite adresu dostave.";
                }
                else if ("Rechnungsadresse" == columnName)
                {
                    if (String.IsNullOrEmpty(Rechnungsadresse))
                        Result = "Unesite adresu racuna.";
                }
                else if ("Tel1" == columnName)
                {
                    if (String.IsNullOrEmpty(Tel1))
                        Result = "Unesite telefon.";
                }
                else if ("Mail" == columnName)
                {
                    if (String.IsNullOrEmpty(Mail))
                        Result = "Unesite mail.";
                }

                else if ("IsValid" == columnName)
                {
                    Result = true.ToString();
                }

                if ("VornameEdit" == columnName)
                {
                    if (String.IsNullOrEmpty(VornameEdit))
                        Result = "Unesite ime.";
                }
                else if ("NameEdit" == columnName)
                {
                    if (String.IsNullOrEmpty(NameEdit))
                        Result = "Unesite prezime.";
                }
                else if ("LieferadresseEdit" == columnName)
                {
                    if (String.IsNullOrEmpty(LieferadresseEdit))
                        Result = "Unesite adresu dostave.";
                }
                else if ("RechnungsadresseEdit" == columnName)
                {
                    if (String.IsNullOrEmpty(RechnungsadresseEdit))
                        Result = "Unesite adresu racuna.";
                }
                else if ("Tel1Edit" == columnName)
                {
                    if (String.IsNullOrEmpty(Tel1Edit))
                        Result = "Unesite telefon.";
                }
                else if ("MailEdit" == columnName)
                {
                    if (String.IsNullOrEmpty(MailEdit))
                        Result = "Unesite mail.";
                }

                else if ("IsValidEdit" == columnName)
                {
                    Result = true.ToString();
                }

                return Result;
            }
        }

        static readonly string[] ValidatedProperties = 
        {
            "Vorname",
            "Name",
            "Lieferadresse",
            "Rechnungsadresse",
            "Tel1",
            "Mail"
        };

        public bool IsValid
        {
            get
            {
                foreach (string property in ValidatedProperties)
                {
                    if(GetValidationError(property) != null)
                        return false;
                }
                return true;
            }
        }

        private string GetValidationError(string propertyName)
        {
            string error = null;
            switch (propertyName)
            {
                case "Vorname":
                    error = this["Vorname"];
                    break;
                case "Name":
                    error = this["Name"];
                    break;
                case "Lieferadresse":
                    error = this["Lieferadresse"];
                    break;
                case "Rechnungsadresse":
                    error = this["Rechnungsadresse"];
                    break;
                case "Tel1":
                    error = this["Tel1"];
                    break;
                case "Mail":
                    error = this["Mail"];
                    break;
                default:
                    error = null;
                    throw new Exception("Unexpected property being validated on Service");
            }
            return error;
        }

        protected bool CanSave
        {
            get
            {
                return IsValid;
            }
        }

        static readonly string[] ValidatedPropertiesEdit = 
        {
            "VornameEdit",
            "NameEdit",
            "LieferadresseEdit",
            "RechnungsadresseEdit",
            "Tel1Edit",
            "MailEdit"
        };

        public bool IsValidEdit
        {
            get
            {
                foreach (string property in ValidatedPropertiesEdit)
                {
                    if (GetValidationErrorEdit(property) != null)
                        return false;
                }
                return true;
            }
        }

        private string GetValidationErrorEdit(string propertyName)
        {
            string error = null;
            switch (propertyName)
            {
                case "VornameEdit":
                    error = this["VornameEdit"];
                    break;
                case "NameEdit":
                    error = this["NameEdit"];
                    break;
                case "LieferadresseEdit":
                    error = this["LieferadresseEdit"];
                    break;
                case "RechnungsadresseEdit":
                    error = this["RechnungsadresseEdit"];
                    break;
                case "Tel1Edit":
                    error = this["Tel1Edit"];
                    break;
                case "MailEdit":
                    error = this["MailEdit"];
                    break;
                default:
                    error = null;
                    throw new Exception("Unexpected property being validated on Service");
            }
            return error;
        }

        protected bool CanSaveEdit
        {
            get
            {
                return IsValidEdit;
            }
        }

        public bool IsMin
        {
            get
            {
                if (BrojStranice == 1)
                    return false;
                else
                    return true;
            }
        }

        public bool IsMax
        {
            get
            {
                if (BrojStranice == MaxStranica1)
                    return false;
                else 
                    return true;
            }
        }

        protected bool CanNext
        {
            get
            {
                return IsMax;
            }
        }


        protected bool CanLast
        {
            get 
            { 
                return IsMin; 
            }
        }

        public string Error
        {
            get { throw new NotImplementedException(); }
        }
        #endregion
       
    }
}
