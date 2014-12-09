using Desktop.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Desktop
{
    /// <summary>
    /// Interaction logic for AdminEditWindow.xaml
    /// </summary>
    public partial class AdminEditWindow : Window
    {
            AdminWindowViewModel m = new AdminWindowViewModel();

         public AdminEditWindow(AdminWindowViewModel m)
        {
            InitializeComponent();
            this.m = m;
            this.DataContext = m;
            m.CloseAction = null;
            if (m.CloseAction == null)
            {
                m.CloseAction = new Action(() => this.Close());
            }
        }

         #region Color field Validations
         private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
         {
             if (idName.Text.Length == 0) { idName.Background = Brushes.LightPink; }
             else { idName.Background = Brushes.White; }
         }

         private void idLastName_TextChanged(object sender, TextChangedEventArgs e)
         {
             if (idLastName.Text.Length == 0) { idLastName.Background = Brushes.LightPink; }
             else { idLastName.Background = Brushes.White; }
         }

         private void idEmail_TextChanged(object sender, TextChangedEventArgs e)
         {
             if (idEmail.Text.Length == 0) { idEmail.Background = Brushes.LightPink; }
             else { idEmail.Background = Brushes.White; }
         }

         private void idTelefon_TextChanged(object sender, TextChangedEventArgs e)
         {
             if (idTelefon.Text.Length == 0) { idTelefon.Background = Brushes.LightPink; }
             else { idTelefon.Background = Brushes.White; }
         }

         private void idUsername_TextChanged(object sender, TextChangedEventArgs e)
         {
             if (idUsername.Text.Length == 0) { idUsername.Background = Brushes.LightPink; }
             else { idUsername.Background = Brushes.White; }
         }

         private void idPassword_TextChanged(object sender, TextChangedEventArgs e)
         {
             if (idPassword.Text.Length == 0) { idPassword.Background = Brushes.LightPink; }
             else { idPassword.Background = Brushes.White; }
         }
         #endregion
    }
}
