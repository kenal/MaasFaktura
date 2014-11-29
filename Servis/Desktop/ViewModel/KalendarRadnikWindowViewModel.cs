using Desktop.Service;
using Servis.HelperClass;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Desktop.ViewModel
{
    public class KalendarRadnikWindowViewModel: INotifyPropertyChanged
    {
        #region Fields
        int _idKorisnik;        
        DateTime _datum;        
        DateTime _datum1;        
        int _tip;        
        bool _odobreno;        
        bool _pogledano;        
        string _text;
        private MassServisClient client = new MassServisClient();
        private ObservableCollection<tbl_korisnik> _listaKorisnika;
        private tbl_korisnik _selektovaniKorisnik;
        #endregion

        #region Properties
        public int IdKorisnik
        {
            get { return _idKorisnik; }
            set 
            { 
                _idKorisnik = value;
                OnPropertyChanged("IdKorisnik");
            }
        }

        public DateTime Datum
        {
            get { return _datum; }
            set 
            { 
                _datum = value;
                OnPropertyChanged("Datum");
            }
        }

        public DateTime Datum1
        {
            get { return _datum1; }
            set 
            { 
                _datum1 = value;
                OnPropertyChanged("Datum1");
            }
        }    

        public int Tip
        {
            get { return _tip; }
            set 
            { 
                _tip = value;
                OnPropertyChanged("Tip");
            }
        }

        public bool Odobreno
        {
            get { return _odobreno; }
            set 
            { 
                _odobreno = value;
                OnPropertyChanged("Odobreno");
            }
        }

        public bool Pogledano
        {
            get { return _pogledano; }
            set 
            { 
                _pogledano = value;
                OnPropertyChanged("Pogledano");
            }
        }

        public string Text
        {
            get { return _text; }
            set 
            { 
                _text = value;
                OnPropertyChanged("Text");
            }
        }

        public ObservableCollection<tbl_korisnik> ListaKorisnika
        {
            get { return _listaKorisnika; }
            set { _listaKorisnika = value; OnPropertyChanged("ListaKorisnika"); }
        }

        public tbl_korisnik SelektovaniKorisnik
        {
            get { return _selektovaniKorisnik; }
            set { _selektovaniKorisnik = value; OnPropertyChanged("SelektovaniKorisnik"); }
        }
        #endregion

        #region ICommand
        private ICommand _otvoriDodaj;

        public ICommand OtvoriDodaj
        {
            get { return _otvoriDodaj = new RelayCommand(param => OtvoriDodajKalendar(param)); }
            set { _otvoriDodaj = value; }
        }

        private ICommand PopuniComboKorisnika;

        public ICommand PopuniComboKorisnika1
        {
            get { return PopuniComboKorisnika = new RelayCommand(param => popuniCombo(param)); }
            set { PopuniComboKorisnika = value; }
        }
        #endregion

        #region Methods
        public void OtvoriDodajKalendar(object parameter)
        {
            KalendarRadnikDodajWindow kd = new KalendarRadnikDodajWindow(this);
            kd.Show();
        }

        public void popuniCombo(object parameter)
        {
            ListaKorisnika = client.ComboKorisnici();
            
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
    }
}
