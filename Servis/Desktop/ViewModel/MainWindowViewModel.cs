using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desktop.ViewModel
{
    public class MainWindowViewModel:INotifyPropertyChanged, IDataErrorInfo
    {
        #region Fields
        private string _imeKorisnika; 
        #endregion

        #region Properties
        public string ImeKorisnika
        {
            get { return _imeKorisnika; }
            set { _imeKorisnika = value; OnPropertyChanged("ImeKorisnika") }
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
