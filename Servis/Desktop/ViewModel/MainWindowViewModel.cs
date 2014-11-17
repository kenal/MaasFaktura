﻿using Desktop.Service;
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
    public class MainWindowViewModel:INotifyPropertyChanged
    {
        #region Fields
        private string _imeKorisnika;
        private tbl_korisnik _logovaniKor;
        MassServisClient client = new MassServisClient();

       
        #endregion

        #region Properties
        public tbl_korisnik LogovaniKor
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
        public void PopuniButtonKorisnikom(object parameter)
        {
        //    int id = Sesija.id_korisnik;
        //    LogovaniKor = client.VratiKorisnika(id);
        //    ImeKorisnika = LogovaniKor.ime + " " + LogovaniKor.prezime;
        }
        #endregion

        #region ICommand Members
        private ICommand loading;

        public ICommand Loading
        {
            get { return loading = new RelayCommand(param=> PopuniButtonKorisnikom(param)); }
            set { loading = value; }
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

    }
}
