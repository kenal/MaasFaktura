using Desktop.Service;
using Servis.HelperClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Desktop.ViewModel
{
    class ProfileWindowViewModel : INotifyPropertyChanged
    {
        #region Fields
        private string _vorname;
        private string _nachname;
        private string _email;
        private string _telefon = "-";
        private string _username;
        private string _password;
        private string _slika;

     
        private tbl_korisnik korisnik;
        private MassServisClient client = new MassServisClient();

       
        #endregion

        #region Properties
        public string Slika
        {
            get { return _slika; }
            set { _slika = value; OnPropertyChanged("Slika"); }
        }
        public tbl_korisnik Korisnik
        {
            get { return korisnik; }
            set { korisnik = value; OnPropertyChanged("Korisnik"); }
        }
        public string Vorname
        {
            get { return _vorname; }
            set { _vorname = value; OnPropertyChanged("Vorname"); }
        }
        public string Nachname
        {
            get { return _nachname; }
            set { _nachname = value; OnPropertyChanged("Nachname"); }
        }
        public string Email
        {
            get { return _email; }
            set { _email = value; OnPropertyChanged("Email"); }
        }
        public string Telefon
        {
            get { return _telefon; }
            set { _telefon = value; OnPropertyChanged("Telefon"); }
        }
        public string Username
        {
            get { return _username; }
            set { _username = value; OnPropertyChanged("Username"); }
        }
        public string Password
        {
            get { return _password; }
            set { _password = value; OnPropertyChanged("Password"); }
        }
        #endregion

        #region ICommand Members
        private ICommand _popuniProfil;

        public ICommand PopuniProfil
        {
            get { return _popuniProfil = new RelayCommand(param => KorisnickiPodaci(param)); }
            set { _popuniProfil = value; }
        }
        private ICommand _Uredi;

        public ICommand Uredi
        {
            get { return _Uredi = new RelayCommand(param => UrediKorisnickePodatke(param)); }
            set { _Uredi = value; }
        }

       
        #endregion

        #region Methods

        public void UrediKorisnickePodatke(object parameter)
        {
            tbl_korisnik k = new tbl_korisnik();
            k.id_korisnik = Sesija.Id_korisnik;
            k.ime = Vorname;
            k.prezime = Nachname;
            k.mail = Email;
            k.username = Username;
            k.password = Password;
            k.telefon = Telefon;
            k.slika = Slika;
            client.UpdateKorisnik(k);
        }
        public void KorisnickiPodaci(object parameter)
        {
            korisnik = client.VratiKorisnika(Sesija.Id_korisnik);
            Vorname = korisnik.ime;
            Nachname = korisnik.prezime;
            Email = korisnik.mail;
            Telefon = korisnik.telefon;
            Username = korisnik.username;
            Password = korisnik.password;
            Slika = korisnik.slika;
        }
        #endregion

        #region INotify Members
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        #endregion
    }
}
