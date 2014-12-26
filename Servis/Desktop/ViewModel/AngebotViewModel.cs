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
using System.Windows.Threading;

namespace Desktop.ViewModel
{
    public class AngebotViewModel : INotifyPropertyChanged
    {

        #region Fields
        MassServisClient client = new MassServisClient();
        private ObservableCollection<kunden> _comboKunden;
        private int _selectedKunden;
        #endregion

        #region Properties
        public ObservableCollection<kunden> ComboKunden
        {
            get { return _comboKunden; }
            set { _comboKunden = value; OnPropertyChanged("ComboKunden"); }
        }
        public int SelectedKunden
        {
            get { return _selectedKunden; }
            set
            {
                if (_selectedKunden != value)
                {
                    _selectedKunden = value;
                    RaisePropertyChanged("SelectedKunden");
                    // New item has been selected. Do something here
                }
            }
        }
        #endregion

        #region Methods
        public void popuniCombo(object parameter)
        {
            ComboKunden = client.ListaKupaca();
        }
        #endregion

        #region ICommand Memebers
        private ICommand PopuniComboKundena;

        public ICommand PopuniComboKundena1
        {
            get { return PopuniComboKundena = new RelayCommand(param => popuniCombo(param)); }
            set { PopuniComboKundena = value; }
        }
        #endregion

        #region INofifyPropertyChanged Members
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged2;
        private void RaisePropertyChanged(string PropertyName)
        {
            if (PropertyChanged2 != null)
                PropertyChanged2(this, new PropertyChangedEventArgs(PropertyName));
        }
        #endregion
    }
}


        //public event PropertyChangedEventHandler PropertyChanged;

        //private DateTime _now;

        //public AngebotViewModel()
        //{

        //    /* _now = DateTime.Now;

        //     DispatcherTimer timer = new DispatcherTimer();

        //     timer.Interval = TimeSpan.FromMilliseconds(100);

        //     timer.Tick += new EventHandler(timer_Tick);

        //     timer.Start();

        //     AngebotNr = client.AngebotNr();*/


        //}

        //public DateTime Now
        //{

        //    get { return _now; }

        //    private set
        //    {

        //        _now = value;

        //        if (PropertyChanged != null)

        //            PropertyChanged(this, new PropertyChangedEventArgs("Now"));

        //    }

        //}

        //void timer_Tick(object sender, EventArgs e)
        //{

        //    Now = DateTime.Now;

        //}
