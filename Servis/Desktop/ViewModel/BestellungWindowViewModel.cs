using Desktop.Service;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Desktop.ViewModel
{
    public class BestellungWindowViewModel : ICommand
    {
        #region ICommand
        MassServisClient client = new MassServisClient();
        ObservableCollection<tbl_dobavljac> ListaDobavljaca;
        #endregion
    }
}
