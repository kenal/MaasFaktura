using Desktop.Service;
using Microsoft.Win32;
using Servis.HelperClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media.Imaging;

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

        private ICommand _izborSlike;

        public ICommand IzborSlike
        {
            get { return _izborSlike = new RelayCommand(param => DodajSliku(param)); }
            set { _izborSlike = value; }
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

        public void DodajSliku(object parameter)
        {
             OpenFileDialog op = new OpenFileDialog();
                string folderpath = System.IO.Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + "\\images\\";
                op.Title = "Select a picture";
                op.Filter = "All supported graphics|*.jpg;*.jpeg;*.png|" +
                            "JPEG (*.jpg;*.jpeg)|*.jpg;*.jpeg|" +
                            "Portable Network Graphic (*.png)|*.png";

                bool? myResult;
                myResult = op.ShowDialog();
                if (myResult != null && myResult == true)
                {
                    //Image.Source = new BitmapImage(new Uri(op.FileName));
                    //if (!Directory.Exists(folderpath))
                    //{
                    //    Directory.CreateDirectory(folderpath);
                    //}
                    //string fileName = System.IO.Path.GetTempPath() + Guid.NewGuid().ToString() + ".jpg";
                    //string filePath = folderpath + System.IO.Path.GetFileName(fileName);
                    //System.IO.File.Copy(op.FileName, filePath, true);
                    //insertPict(filePath, k.IdKorisnika);

                   
                    //k.ImageToByte = File.ReadAllBytes(filePath);

                    //SpremiSliku(k.IdKorisnika, k.ImageToByte);
                    //imgUser.Visibility = Visibility.Collapsed;
                }
                MessageBox.Show("Uspjesno ste dodali korisnicku sliku!!!","Slika",MessageBoxButton.OK,MessageBoxImage.Information);
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
