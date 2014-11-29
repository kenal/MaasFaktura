using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        #endregion

        #region ICommand
        
        #endregion

        #region Methods
        
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
