using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desktop.ViewModel
{
   public class PorukeWindowViewModel : INotifyPropertyChanged
    {
        #region Fields
        private List<int> _comboPoruke = new List<int>() { 10, 25, 50, 100 };
        private int _brojPrikazanihPoruka=10;

       
        #endregion

        #region Properties
        public List<int> ComboPoruke
        {
            get { return _comboPoruke; }
            set { _comboPoruke = value; OnPropertyChanged("ComboPoruke"); }
        }
        public int BrojPrikazanihPoruka
        {
            get { return _brojPrikazanihPoruka; }
            set { _brojPrikazanihPoruka = value; OnPropertyChanged("BrojPrikazanihPoruka"); }
        }
        #endregion

        #region ICommand Memebers
        
        #endregion

        #region Methods
        
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
        #endregion
   }

}
