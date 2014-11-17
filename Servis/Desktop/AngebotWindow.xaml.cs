using Desktop.ViewModel;
using System;
using System.Collections.Generic;
using System.Data;
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
    /// Interaction logic for AngebotWindow.xaml
    /// </summary>
    public partial class AngebotWindow : Window
    {
        DataTable myDataTable;
        

        public AngebotWindow()
        {
            InitializeComponent();
            this.DataContext = new AngebotViewModel();
            myDataTable = new DataTable();

            // Add columns to DataTable.
            myDataTable.Columns.Add("val1");
            myDataTable.Columns.Add("val2");
            myDataTable.Columns.Add("val3");
            myDataTable.Columns.Add("val4");
            myDataTable.Columns.Add("val5");
            myDataTable.Columns.Add("val6");
            myDataTable.Columns.Add("val7");
            myDataTable.Columns.Add("val8");
            myDataTable.Columns.Add("val9");
            myDataTable.Columns.Add("val10");
            myDataTable.Columns.Add("val11");
            myDataTable.Columns.Add("val12");
            myDataTable.Columns.Add("val13");
            myDataTable.Columns.Add("val14");
            myDataTable.Columns.Add("val15");
            myDataTable.Columns.Add("val16");
            myDataTable.Columns.Add("val17");
            myDataTable.Columns.Add("val18");

            myDataTable.Rows.Add("1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1");
            //myDataTable.Rows.Add("2", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1");

            datagrid1.ItemsSource = myDataTable.DefaultView;
        }

        private void Window_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            gridsResolution();
            gridsResolution2();
        }
        public void gridsResolution()
        {
            int brKolona01 = datagrid1.Columns.Count - 1;
            #region resolution full
            if (this.WindowState == WindowState.Maximized)
            {
                var windowWidth = System.Windows.SystemParameters.PrimaryScreenWidth - 145;
                //datagrid 01
                col1_1.Width = windowWidth / brKolona01;
                col1_2.Width = windowWidth / brKolona01;
                col1_3.Width = windowWidth / brKolona01;
                col1_4.Width = windowWidth / brKolona01;
                col1_5.Width = windowWidth / brKolona01;
                col1_6.Width = windowWidth / brKolona01;
                col1_7.Width = windowWidth / brKolona01;
                col1_8.Width = windowWidth / brKolona01;
                col1_9.Width = windowWidth / brKolona01;
                col1_10.Width = windowWidth / brKolona01;
                col1_11.Width = windowWidth / brKolona01;
                col1_12.Width = windowWidth / brKolona01;
                col1_13.Width = windowWidth / brKolona01;
                col1_14.Width = windowWidth / brKolona01;
                col1_15.Width = windowWidth / brKolona01;
                col1_16.Width = windowWidth / brKolona01;
                col1_17.Width = windowWidth / brKolona01;
                col1_18.Width = windowWidth / brKolona01;
                col1_19.Width = windowWidth / brKolona01;
            }
            #endregion
            #region resolution normal
            else
            {
                var windowWidth = this.Width - 145;
                //datagrid 01
                col1_1.Width = windowWidth / brKolona01;
                col1_2.Width = windowWidth / brKolona01;
                col1_3.Width = windowWidth / brKolona01;
                col1_4.Width = windowWidth / brKolona01;
                col1_5.Width = windowWidth / brKolona01;
                col1_6.Width = windowWidth / brKolona01;
                col1_7.Width = windowWidth / brKolona01;
                col1_8.Width = windowWidth / brKolona01;
                col1_9.Width = windowWidth / brKolona01;
                col1_10.Width = windowWidth / brKolona01;
                col1_11.Width = windowWidth / brKolona01;
                col1_12.Width = windowWidth / brKolona01;
                col1_13.Width = windowWidth / brKolona01;
                col1_14.Width = windowWidth / brKolona01;
                col1_15.Width = windowWidth / brKolona01;
                col1_16.Width = windowWidth / brKolona01;
                col1_17.Width = windowWidth / brKolona01;
                col1_18.Width = windowWidth / brKolona01;
                col1_19.Width = windowWidth / brKolona01;
            }
            #endregion
        }

        public void gridsResolution2()
        {
            int brKolona02 = datagrid2.Columns.Count;
            #region resolution full
            if (this.WindowState == WindowState.Maximized)
            {
                var windowWidth = System.Windows.SystemParameters.PrimaryScreenWidth - 20;

                //datagrid 02
                col2_1.Width = windowWidth / brKolona02;
                col2_2.Width = windowWidth / brKolona02;
                col2_3.Width = windowWidth / brKolona02;
                col2_4.Width = windowWidth / brKolona02;
                col2_5.Width = windowWidth / brKolona02;
                col2_6.Width = windowWidth / brKolona02;
                col2_7.Width = windowWidth / brKolona02;
                col2_8.Width = windowWidth / brKolona02;
                col2_9.Width = windowWidth / brKolona02;
                col2_10.Width = windowWidth / brKolona02;
                col2_11.Width = windowWidth / brKolona02;
                col2_12.Width = windowWidth / brKolona02;
                col2_13.Width = windowWidth / brKolona02;
                col2_14.Width = windowWidth / brKolona02;
            }
            #endregion
            #region resolution normal
            else
            {
                var windowWidth = this.Width - 20;
                //datagrid 02
                col2_1.Width = windowWidth / brKolona02;
                col2_2.Width = windowWidth / brKolona02;
                col2_3.Width = windowWidth / brKolona02;
                col2_4.Width = windowWidth / brKolona02;
                col2_5.Width = windowWidth / brKolona02;
                col2_6.Width = windowWidth / brKolona02;
                col2_7.Width = windowWidth / brKolona02;
                col2_8.Width = windowWidth / brKolona02;
                col2_9.Width = windowWidth / brKolona02;
                col2_10.Width = windowWidth / brKolona02;
                col2_11.Width = windowWidth / brKolona02;
                col2_12.Width = windowWidth / brKolona02;
                col2_13.Width = windowWidth / brKolona02;
                col2_14.Width = windowWidth / brKolona02;
            }
            #endregion
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnNew_Click(object sender, RoutedEventArgs e)
        {
            grdNeue.Visibility = Visibility.Visible;
            grdAngeboteliste.Visibility = Visibility.Collapsed;
            grdAngNachverfogung.Visibility = Visibility.Collapsed;
        }

        private void btnAngebotListe_Click(object sender, RoutedEventArgs e)
        {
            grdAngeboteliste.Visibility = Visibility.Visible;
            grdNeue.Visibility = Visibility.Collapsed;
            grdAngNachverfogung.Visibility = Visibility.Collapsed;
        }

        private void btnAngebotNach_Click(object sender, RoutedEventArgs e)
        {
            grdAngNachverfogung.Visibility = Visibility.Visible;
            grdNeue.Visibility = Visibility.Collapsed;
            grdAngeboteliste.Visibility = Visibility.Collapsed;
        }
    }
}
