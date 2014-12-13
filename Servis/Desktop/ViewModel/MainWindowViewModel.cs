using Desktop.Service;
using Mass.Data;
using Servis.HelperClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Windows.Threading;

namespace Desktop.ViewModel
{
    public class MainWindowViewModel:INotifyPropertyChanged
    {
        #region Fields
        private string _imeKorisnika;
        private user _logovaniKor;
       
      
        MassServisClient client = new MassServisClient();

       
        #endregion

        #region Properties
       
        public user LogovaniKor
        {
            get { return _logovaniKor; }
            set { _logovaniKor = value; OnPropertyChanged("LogovaniKor"); }
        }
        public string ImeKorisnika
        {
            get { return _imeKorisnika; }
            set { _imeKorisnika = value; OnPropertyChanged("ImeKorisnika"); }
        } 
        #endregion

        #region Methods
        public void OpenProfile(object parameter)
        {
            ProfileWindow PW = new ProfileWindow();
            PW.Show();
        }
       
        public void PopuniButtonKorisnikom(object parameter)
        {
            int id = Sesija.Id_korisnik;
            LogovaniKor = client.VratiKorisnika(id);
            ImeKorisnika = LogovaniKor.firstName + " " + LogovaniKor.lastName;
        }

        public void OtvoriPoruke(object parameter)
        {
            PorukeWindow por = new PorukeWindow();
            por.Show();
        }
        #endregion

        #region ICommand Members
        private ICommand _openMsg;

        public ICommand OpenMsg
        {
            get { return _openMsg = new RelayCommand(param => OtvoriPoruke(param)); }
            set { _openMsg = value; }
        }

        private ICommand loading;

        public ICommand Loading
        {
            get { return loading = new RelayCommand(param=> PopuniButtonKorisnikom(param)); }
            set { loading = value; }
        }

        private ICommand _otvoriProfil;

        public ICommand OtvoriProfil
        {
            get { return _otvoriProfil = new RelayCommand(param => OpenProfile(param)); }
            set { _otvoriProfil = value; }
        }
        #endregion

        #region INoftiyPropertyChanged Members
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        } 
        #endregion

        #region Dispatcher Timer Poruke
        private void dispatcherTimer_Tick(object sender, EventArgs e)
        {
            int brojNeprocitanihPoruka = client.ProvjeriPoruke(Sesija.Id_korisnik);
            if (brojNeprocitanihPoruka > 0)
            {
                Background = "#FA5833";
                Upozorenje = brojNeprocitanihPoruka.ToString();
                Vidljivost = Visibility.Visible;
            }
            else
            {
                Background = "#5A5A5A";
                Upozorenje = "";
                Vidljivost = Visibility.Collapsed;
            }
        }

        private ICommand _provjera;

        public ICommand Provjera
        {
            get { return _provjera = new RelayCommand(param => ProvjeraPoruka(param)); }
            set { _provjera = value; }
        }

        public void ProvjeraPoruka(object parameter)
        {
            DispatcherTimer dispatcherTimer = new DispatcherTimer();
            dispatcherTimer.Tick += new EventHandler(dispatcherTimer_Tick);
            dispatcherTimer.Interval = new TimeSpan(0, 0, 5);
            dispatcherTimer.Start();
        }

        private string _background = "#5A5A5A";

        public string Background
        {
            get { return _background; }
            set 
            { 
                _background = value;
                OnPropertyChanged("Background");
            }
        }

        private string _upozorenje = "";

        public string Upozorenje
        {
            get { return _upozorenje; }
            set 
            { 
                _upozorenje = value;
                OnPropertyChanged("Upozorenje");
            }
        }

        Visibility _vidljivost = Visibility.Collapsed;

        public Visibility Vidljivost
        {
            get { return _vidljivost; }
            set 
            { 
                _vidljivost = value;
                OnPropertyChanged("Vidljivost");
            }
        }
 

        #endregion

    }
}
