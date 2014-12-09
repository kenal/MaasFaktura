﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using Desktop.Service;
using Desktop;
using System.Windows;
using Servis.HelperClass;
using System.Windows.Input;
using System.Windows.Controls;

namespace Servis.ViewModel
{
    public class LoginWindowViewModel : INotifyPropertyChanged
    {
        #region Fields
        private string _korisnickoIme;
        private string _lozinka;
        private MassServisClient client = new MassServisClient();
        private string Validacija = "Bitte loggen Sie sich mit Ihrem Benutzemamen und Passwort.";
        private string pozadina = "#4B4D4B";
        private string vidljivost = "Visible";

        
        #endregion

        #region Properties


        public string Vidljivost
        {
            get { return vidljivost; }
            set { vidljivost = value;
            OnPropertyChanged("Vidljivost");
            }
        }
        public string Pozadina
        {
            get { return pozadina; }
            set { pozadina = value;
            OnPropertyChanged("Pozadina");
            }
        }

        public string Validacija1
        {
            get { return Validacija; }
            set { Validacija = value;
            OnPropertyChanged("Validacija1");
            }
        }
        public string Lozinka
        {
            get { return _lozinka; }
            set { 
                _lozinka = value;
                OnPropertyChanged("Lozinka");
                 }
        }

        public string KorisnickoIme
        {
            get { return _korisnickoIme; }
            set { 
                _korisnickoIme = value;
                OnPropertyChanged("KorisnickoIme");
                }
        } 
        #endregion

        #region ICommand Members

        private ICommand _LoginClick;

        public ICommand LoginClick
        {
            get { 
                    _LoginClick = new RelayCommand(param =>ProvjeraLogin(param));
                return _LoginClick;
                }
            set { _LoginClick = value; }
        }

        private ICommand _Closed;

        public ICommand Closed
        {
            get 
            {
                _Closed = new RelayCommand(param => Zatvori(param));
                return _Closed; 
            }
            set { _Closed = value; }
        }

        #endregion

        #region Methods

        public void Zatvori(object param)
        {
            Application.Current.Shutdown();
        }
        public void ProvjeraLogin(object parameter)
        {
            var passwordBox = parameter as PasswordBox;
            var password = passwordBox.Password;
            if (KorisnickoIme != null && password != null)
            {
                int id = client.LoginValidacija(KorisnickoIme, password);
                if (id != 0)
                {
                    Validacija1 = "Erfolgreiche Anwendungen";
                    Pozadina = "LimeGreen";
                    MainWindow mw = new MainWindow();
                    mw.Show();
                    Vidljivost = "Collapsed";
                    Sesija.id_korisnik = id;

                }
                else
                    Validacija1 = "False angeben!";
                Pozadina = "#CC9999";
            }
            else
                Validacija1 = "Bitte geben Sie die Daten";
            Pozadina = "#CC9999";
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