﻿using Desktop.ViewModel;
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
        public int rowId = 0;
        public int vertRowPosition = 10;
        public int lastRowId = 0;

        public AngebotWindow()
        {
            InitializeComponent();
            this.DataContext = new AngebotViewModel();
            addRowType01();
        }

        private void Window_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            gridsResolution();
            gridsResolution2();
        }
        #region Resolution
        public void gridsResolution()
        {
            //int brKolona01 = datagrid1.Columns.Count - 1;
            #region resolution full
            if (this.WindowState == WindowState.Maximized)
            {
                var windowWidth = System.Windows.SystemParameters.PrimaryScreenWidth - 145;
                //datagrid 01
                //col1_1.Width = windowWidth / brKolona01;
                //col1_2.Width = windowWidth / brKolona01;
                //col1_3.Width = windowWidth / brKolona01;
                //col1_4.Width = windowWidth / brKolona01;
                //col1_5.Width = windowWidth / brKolona01;
                //col1_6.Width = windowWidth / brKolona01;
                //col1_7.Width = windowWidth / brKolona01;
                //col1_8.Width = windowWidth / brKolona01;
                //col1_9.Width = windowWidth / brKolona01;
                //col1_10.Width = windowWidth / brKolona01;
                //col1_11.Width = windowWidth / brKolona01;
                //col1_12.Width = windowWidth / brKolona01;
                //col1_13.Width = windowWidth / brKolona01;
                //col1_14.Width = windowWidth / brKolona01;
                //col1_15.Width = windowWidth / brKolona01;
                //col1_16.Width = windowWidth / brKolona01;
                //col1_17.Width = windowWidth / brKolona01;
                //col1_18.Width = windowWidth / brKolona01;
                //col1_19.Width = windowWidth / brKolona01;
            }
            #endregion
            #region resolution normal
            else
            {
                var windowWidth = this.Width - 145;
                //datagrid 01
                //col1_1.Width = windowWidth / brKolona01;
                //col1_2.Width = windowWidth / brKolona01;
                //col1_3.Width = windowWidth / brKolona01;
                //col1_4.Width = windowWidth / brKolona01;
                //col1_5.Width = windowWidth / brKolona01;
                //col1_6.Width = windowWidth / brKolona01;
                //col1_7.Width = windowWidth / brKolona01;
                //col1_8.Width = windowWidth / brKolona01;
                //col1_9.Width = windowWidth / brKolona01;
                //col1_10.Width = windowWidth / brKolona01;
                //col1_11.Width = windowWidth / brKolona01;
                //col1_12.Width = windowWidth / brKolona01;
                //col1_13.Width = windowWidth / brKolona01;
                //col1_14.Width = windowWidth / brKolona01;
                //col1_15.Width = windowWidth / brKolona01;
                //col1_16.Width = windowWidth / brKolona01;
                //col1_17.Width = windowWidth / brKolona01;
                //col1_18.Width = windowWidth / brKolona01;
                //col1_19.Width = windowWidth / brKolona01;
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
        #endregion

        #region Tab Control
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
        #endregion


        #region Angebot Dinamic System
        #region Button Add New 01
        private void btnNewRow01_Click(object sender, RoutedEventArgs e)
        {
            addRowType01();
        }
        #endregion

        #region Button Add New 02
        private void btnNewRow02_Click(object sender, RoutedEventArgs e)
        {
            addRowType02();
        }
        #endregion

        #region Add Row Type 01
        private void addRowType01()
        {
            rowId = rowId + 1;
            TextBox myDinamicTxtBox01 = new TextBox();
            TextBox myDinamicTxtBox02 = new TextBox();
            ComboBox matT = new ComboBox();
            ComboBox prod = new ComboBox();
            ComboBox ober = new ComboBox();
            ComboBox stark = new ComboBox();
            ComboBox mat = new ComboBox();
            Button myDinamicButton01 = new Button();
            Label myLabel01 = new Label();
            Button btnDown = new Button();
            Button btnUp = new Button();

            Button btnAddType01 = new Button();
            Button btnAddType02 = new Button();

            myDinamicTxtBox01.Width = 80;
            myDinamicTxtBox01.Height = 25;
            myDinamicTxtBox02.Width = 80;
            myDinamicTxtBox02.Height = 25;
            matT.Width = 80;
            matT.Height = 25;
            prod.Width = 80;
            prod.Height = 25;
            ober.Width = 80;
            ober.Height = 25;
            stark.Width = 80;
            stark.Height = 25;
            mat.Width = 80;
            mat.Height = 25;
            myDinamicButton01.Width = 70;
            myDinamicButton01.Height = 25;
            btnAddType01.Width = 80;
            btnAddType01.Height = 25;
            btnAddType02.Width = 80;
            btnAddType02.Height = 25;
            myLabel01.Width = 30;
            myLabel01.Height = 25;
            btnDown.Width = 30;
            btnDown.Height = 25;
            btnUp.Width = 30;
            btnUp.Height = 25;

            myDinamicTxtBox01.HorizontalAlignment = HorizontalAlignment.Left;
            myDinamicTxtBox01.VerticalAlignment = VerticalAlignment.Top;
            myDinamicTxtBox02.HorizontalAlignment = HorizontalAlignment.Left;
            myDinamicTxtBox02.VerticalAlignment = VerticalAlignment.Top;
            myDinamicButton01.HorizontalAlignment = HorizontalAlignment.Left;
            myDinamicButton01.VerticalAlignment = VerticalAlignment.Top;
            btnAddType01.HorizontalAlignment = HorizontalAlignment.Left;
            btnAddType01.VerticalAlignment = VerticalAlignment.Top;
            btnAddType02.HorizontalAlignment = HorizontalAlignment.Left;
            btnAddType02.VerticalAlignment = VerticalAlignment.Top;
            myLabel01.HorizontalAlignment = HorizontalAlignment.Left;
            myLabel01.VerticalAlignment = VerticalAlignment.Top;
            btnDown.HorizontalAlignment = HorizontalAlignment.Left;
            btnDown.VerticalAlignment = VerticalAlignment.Top;
            btnUp.HorizontalAlignment = HorizontalAlignment.Left;
            btnUp.VerticalAlignment = VerticalAlignment.Top;
            matT.HorizontalAlignment = HorizontalAlignment.Left;
            matT.VerticalAlignment = VerticalAlignment.Top;
            prod.HorizontalAlignment = HorizontalAlignment.Left;
            prod.VerticalAlignment = VerticalAlignment.Top;
            ober.HorizontalAlignment = HorizontalAlignment.Left;
            ober.VerticalAlignment = VerticalAlignment.Top;
            stark.HorizontalAlignment = HorizontalAlignment.Left;
            stark.VerticalAlignment = VerticalAlignment.Top;
            mat.HorizontalAlignment = HorizontalAlignment.Left;
            mat.VerticalAlignment = VerticalAlignment.Top;
            var topW = vertRowPosition + 30;
            myDinamicTxtBox01.Margin = new Thickness(700, vertRowPosition, 0, 0);
            myDinamicTxtBox02.Margin = new Thickness(600, vertRowPosition, 0, 0);
            //Row start
            myLabel01.Margin = new Thickness(5, vertRowPosition, 0, 0);
            matT.Margin = new Thickness(30, vertRowPosition, 0, 0);
            prod.Margin = new Thickness(120, vertRowPosition, 0, 0);
            ober.Margin = new Thickness(210, vertRowPosition, 0, 0);
            stark.Margin = new Thickness(300, vertRowPosition, 0, 0);
            mat.Margin = new Thickness(390, vertRowPosition, 0, 0);

            myDinamicButton01.Margin = new Thickness(820, vertRowPosition, 0, 0);
            btnAddType01.Margin = new Thickness(140, topW, 0, 0);
            btnAddType02.Margin = new Thickness(240, topW, 0, 0);          
            btnDown.Margin = new Thickness(930, vertRowPosition, 0, 0);
            btnUp.Margin = new Thickness(970, vertRowPosition, 0, 0);

            myDinamicTxtBox01.Name = "txtBoxPrva_" + rowId;
            this.RegisterName("txtBoxPrva_" + rowId, myDinamicTxtBox01);
            myDinamicTxtBox02.Name = "txtBoxDruga_" + rowId;
            this.RegisterName("txtBoxDruga_" + rowId, myDinamicTxtBox02);
            myDinamicButton01.Name = "btnPrvi_" + rowId;
            this.RegisterName("btnPrvi_" + rowId, myDinamicButton01);
            myDinamicButton01.Content = "X";
            btnAddType01.Name = "btnAddNew01Row_" + rowId;
            btnAddType01.Content = "Add Row 01";
            this.RegisterName("btnAddNew01Row_" + rowId, btnAddType01);
            btnAddType02.Name = "btnAddNew02Row_" + rowId;
            btnAddType02.Content = "Add Row 02";
            this.RegisterName("btnAddNew02Row_" + rowId, btnAddType02);
            myDinamicButton01.Click += myDinamicButton01_Click;
            myLabel01.Name = "rd_" + rowId;
            this.RegisterName("rd_" + rowId, myLabel01);
            btnDown.Click += btnDown_Click;
            btnDown.Name = "btnDown_" + rowId;
            btnDown.Content = "D";
            this.RegisterName("btnDown_" + rowId, btnDown);
            btnUp.Click += btnUp_Click;
            btnUp.Name = "btnUp_" + rowId;
            btnUp.Content = "U";
            this.RegisterName("btnUp_" + rowId, btnUp);
            matT.Name = "matT_" + rowId;
            this.RegisterName("matT_" + rowId, matT);
            prod.Name = "prod_" + rowId;
            this.RegisterName("prod_" + rowId, prod);
            ober.Name = "ober_" + rowId;
            this.RegisterName("ober_" + rowId, ober);
            stark.Name = "stark_" + rowId;
            this.RegisterName("stark_" + rowId, stark);
            mat.Name = "mat_" + rowId;
            this.RegisterName("mat_" + rowId, mat);

            lastRowId = lastRowId + 1;
            if (lastRowId != 0) { myLabel01.Content = lastRowId; } else { myLabel01.Content = rowId; }
            grid01.Children.Add(myDinamicTxtBox01);
            grid01.Children.Add(myDinamicTxtBox02);
            grid01.Children.Add(myDinamicButton01);
            grid01.Children.Add(matT);
            grid01.Children.Add(prod);
            grid01.Children.Add(myLabel01);           
            grid01.Children.Add(ober);
            grid01.Children.Add(stark);
            grid01.Children.Add(mat);
            grid01.Children.Add(btnDown);
            grid01.Children.Add(btnUp);

            vertRowPosition = vertRowPosition + 30;
            scr01.ScrollToBottom();
        }
        #endregion

        #region Add Row Type 02
        private void addRowType02()
        {
            rowId = rowId + 1;
            TextBox Row2myDinamicTxtBox01 = new TextBox();
            Button Row2myDinamicButton01 = new Button();
            Label myLabel01 = new Label();
            Button btnDown = new Button();
            Button btnUp = new Button();

            Row2myDinamicTxtBox01.Width = 210;
            Row2myDinamicTxtBox01.Height = 25;
            Row2myDinamicButton01.Width = 70;
            Row2myDinamicButton01.Height = 25;
            myLabel01.Width = 30;
            myLabel01.Height = 25;
            btnDown.Width = 30;
            btnDown.Height = 25;
            btnUp.Width = 30;
            btnUp.Height = 25;

            Row2myDinamicTxtBox01.HorizontalAlignment = HorizontalAlignment.Left;
            Row2myDinamicTxtBox01.VerticalAlignment = VerticalAlignment.Top;
            Row2myDinamicButton01.HorizontalAlignment = HorizontalAlignment.Left;
            Row2myDinamicButton01.VerticalAlignment = VerticalAlignment.Top;
            myLabel01.HorizontalAlignment = HorizontalAlignment.Left;
            myLabel01.VerticalAlignment = VerticalAlignment.Top;
            btnDown.HorizontalAlignment = HorizontalAlignment.Left;
            btnDown.VerticalAlignment = VerticalAlignment.Top;
            btnUp.HorizontalAlignment = HorizontalAlignment.Left;
            btnUp.VerticalAlignment = VerticalAlignment.Top;
            Row2myDinamicTxtBox01.Margin = new Thickness(30, vertRowPosition, 0, 0);
            Row2myDinamicButton01.Margin = new Thickness(820, vertRowPosition, 0, 0);
            myLabel01.Margin = new Thickness(5, vertRowPosition, 0, 0);
            btnDown.Margin = new Thickness(930, vertRowPosition, 0, 0);
            btnUp.Margin = new Thickness(970, vertRowPosition, 0, 0);

            Row2myDinamicTxtBox01.Name = "row2txtBox_" + rowId;
            this.RegisterName("row2txtBox_" + rowId, Row2myDinamicTxtBox01);
            Row2myDinamicButton01.Name = "row2Btn_" + rowId;
            Row2myDinamicButton01.DataContext = grid01;
            this.RegisterName("row2Btn_" + rowId, Row2myDinamicButton01);
            Row2myDinamicButton01.Content = "X";
            myLabel01.Name = "rd_" + rowId;
            this.RegisterName("rd_" + rowId, myLabel01);
            btnDown.Click += btnDown_Click;
            btnDown.Name = "btnDown_" + rowId;
            btnDown.Content = "D";
            this.RegisterName("btnDown_" + rowId, btnDown);
            btnUp.Click += btnUp_Click;
            btnUp.Name = "btnUp_" + rowId;
            btnUp.Content = "U";
            this.RegisterName("btnUp_" + rowId, btnUp);

            lastRowId = lastRowId + 1;
            if (lastRowId != 0) { myLabel01.Content = lastRowId; } else { myLabel01.Content = rowId; }


            Row2myDinamicButton01.Click += Row2myDinamicButton01_Click;

            grid01.Children.Add(Row2myDinamicTxtBox01);
            grid01.Children.Add(Row2myDinamicButton01);
            grid01.Children.Add(myLabel01);
            grid01.Children.Add(btnDown);
            grid01.Children.Add(btnUp);

            vertRowPosition = vertRowPosition + 30;
            scr01.ScrollToBottom();
        }
        #endregion

        #region Delete Row Type 01
        private void myDinamicButton01_Click(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;
            int btnIndex = Convert.ToInt32(btn.Name.Split('_').Last());
            TextBox Cell01 = (TextBox)this.FindName("txtBoxPrva_" + btnIndex);
            TextBox Cell02 = (TextBox)this.FindName("txtBoxDruga_" + btnIndex);
            Button Cell03 = (Button)this.FindName("btnPrvi_" + btnIndex);
            Label Cell04 = (Label)this.FindName("rd_" + btnIndex);           
            Button Cell05 = (Button)this.FindName("btnDown_" + btnIndex);
            Button Cell06 = (Button)this.FindName("btnUp_" + btnIndex);
            ComboBox Cell07 = (ComboBox)this.FindName("matT_" + btnIndex);
            ComboBox Cell08 = (ComboBox)this.FindName("prod_" + btnIndex);
            ComboBox Cell09 = (ComboBox)this.FindName("ober_" + btnIndex);
            ComboBox Cell10 = (ComboBox)this.FindName("stark_" + btnIndex);
            ComboBox Cell11 = (ComboBox)this.FindName("mat_" + btnIndex);
            Cell01.UnregisterName(Cell01.Name);
            Cell02.UnregisterName(Cell02.Name);
            Cell03.UnregisterName(Cell03.Name);
            Cell04.UnregisterName(Cell04.Name);
            Cell05.UnregisterName(Cell05.Name);
            Cell06.UnregisterName(Cell06.Name);
            Cell07.UnregisterName(Cell07.Name);
            Cell08.UnregisterName(Cell08.Name);
            Cell09.UnregisterName(Cell09.Name); 
            Cell10.UnregisterName(Cell10.Name); 
            Cell11.UnregisterName(Cell11.Name);

            grid01.Children.Remove(Cell01);
            grid01.Children.Remove(Cell02);
            grid01.Children.Remove(Cell03);
            grid01.Children.Remove(Cell04);
            grid01.Children.Remove(Cell05);
            grid01.Children.Remove(Cell06);
            grid01.Children.Remove(Cell07);
            grid01.Children.Remove(Cell08);
            grid01.Children.Remove(Cell09);
            grid01.Children.Remove(Cell10);
            grid01.Children.Remove(Cell11);


            for (int i = 0; i <= rowId; i++)
            {
                Label Cell000 = (Label)this.FindName("rd_" + i);
                if (Cell000 != null)
                {
                    if (Convert.ToInt32(Cell04.Content) < Convert.ToInt32(Cell000.Content))
                    {
                        int rID = Convert.ToInt32(Cell000.Name.Split('_').Last());

                        TextBox Type01Cell001 = (TextBox)this.FindName("txtBoxPrva_" + rID);
                        TextBox Type01Cell002 = (TextBox)this.FindName("txtBoxDruga_" + rID);
                        Button Type01Cell003 = (Button)this.FindName("btnPrvi_" + rID);
                        Label Type01Cell004 = (Label)this.FindName("rd_" + rID);
                        Button Type01Cell005 = (Button)this.FindName("btnDown_" + rID);
                        Button Type01Cell006 = (Button)this.FindName("btnUp_" + rID);
                        ComboBox Type01Cell007 = (ComboBox)this.FindName("matT_" + rID);
                        ComboBox Type01Cell008 = (ComboBox)this.FindName("prod_" + rID);
                        ComboBox Type01Cell009 = (ComboBox)this.FindName("ober_" + rID);
                        ComboBox Type01Cell0010 = (ComboBox)this.FindName("stark_" + rID);
                        ComboBox Type01Cell0011 = (ComboBox)this.FindName("mat_" + rID);
                        //Row type 02
                        TextBox Type02Cell001 = (TextBox)this.FindName("row2txtBox_" + rID);
                        Button Type02Cell002 = (Button)this.FindName("row2Btn_" + rID);
                        if (Type01Cell001 != null)
                        {
                            //For row type 01
                            var currentTopPosition = Type01Cell001.Margin.Top;
                            var newTopPosition = currentTopPosition - 30;
                            int lblValue = Convert.ToInt32(Type01Cell004.Content);
                            Type01Cell001.Margin = new Thickness(700, newTopPosition, 0, 0);
                            Type01Cell002.Margin = new Thickness(600, newTopPosition, 0, 0);
                            Type01Cell003.Margin = new Thickness(820, newTopPosition, 0, 0);
                            Type01Cell004.Content = lblValue - 1;
                            Type01Cell004.Margin = new Thickness(5, newTopPosition, 0, 0);
                            Type01Cell005.Margin = new Thickness(930, newTopPosition, 0, 0);
                            Type01Cell006.Margin = new Thickness(970, newTopPosition, 0, 0);
                            Type01Cell007.Margin = new Thickness(30, newTopPosition, 0, 0);
                            Type01Cell008.Margin = new Thickness(120, newTopPosition, 0, 0);
                            Type01Cell009.Margin = new Thickness(210, newTopPosition, 0, 0);
                            Type01Cell0010.Margin = new Thickness(300, newTopPosition, 0, 0);
                            Type01Cell0011.Margin = new Thickness(390, newTopPosition, 0, 0);
                        }
                        else if (Type02Cell001 != null)
                        {
                            //For row type 02
                            var currentTopPosition = Type02Cell001.Margin.Top;
                            var newTopPosition = currentTopPosition - 30;
                            int lblValue = Convert.ToInt32(Type01Cell004.Content);

                            Type02Cell001.Margin = new Thickness(30, newTopPosition, 0, 0);
                            Type02Cell002.Margin = new Thickness(820, newTopPosition, 0, 0);
                            Type01Cell004.Content = lblValue - 1;
                            Type01Cell004.Margin = new Thickness(5, newTopPosition, 0, 0);
                            Type01Cell005.Margin = new Thickness(930, newTopPosition, 0, 0);
                            Type01Cell006.Margin = new Thickness(970, newTopPosition, 0, 0);
                        }
                    }
                }
            }
            vertRowPosition = vertRowPosition - 30;
            lastRowId = lastRowId - 1;
        }
        #endregion

        #region Delete Row Type 02
        private void Row2myDinamicButton01_Click(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;
            int btnIndex = Convert.ToInt32(btn.Name.Split('_').Last());
            TextBox Cell01 = (TextBox)this.FindName("row2txtBox_" + btnIndex);
            Button Cell03 = (Button)this.FindName("row2Btn_" + btnIndex);
            Label Cell04 = (Label)this.FindName("rd_" + btnIndex);
            Button Cell05 = (Button)this.FindName("btnDown_" + btnIndex);
            Button Cell06 = (Button)this.FindName("btnUp_" + btnIndex);
            grid01.UnregisterName(Cell01.Name);
            grid01.UnregisterName(Cell03.Name);
            grid01.UnregisterName(Cell04.Name);
            grid01.UnregisterName(Cell05.Name);
            grid01.UnregisterName(Cell06.Name);
            grid01.Children.Remove(Cell01);
            grid01.Children.Remove(Cell03);
            grid01.Children.Remove(Cell04);
            grid01.Children.Remove(Cell05);
            grid01.Children.Remove(Cell06);
            for (int i = 0; i <= rowId; i++)
            {
                Label Cell000 = (Label)this.FindName("rd_" + i);
                if (Cell000 != null)
                {
                    if (Convert.ToInt32(Cell04.Content) < Convert.ToInt32(Cell000.Content))
                    {
                        int rID = Convert.ToInt32(Cell000.Name.Split('_').Last());
                        TextBox Type01Cell001 = (TextBox)this.FindName("txtBoxPrva_" + rID);
                        TextBox Type01Cell002 = (TextBox)this.FindName("txtBoxDruga_" + rID);
                        Button Type01Cell003 = (Button)this.FindName("btnPrvi_" + rID);
                        Label Type01Cell004 = (Label)this.FindName("rd_" + rID);
                        Button Type01Cell005 = (Button)this.FindName("btnDown_" + rID);
                        Button Type01Cell006 = (Button)this.FindName("btnUp_" + rID);
                        ComboBox Type01Cell007 = (ComboBox)this.FindName("matT_" + rID);
                        ComboBox Type01Cell008 = (ComboBox)this.FindName("prod_" + rID);
                        ComboBox Type01Cell009 = (ComboBox)this.FindName("ober_" + rID);
                        ComboBox Type01Cell0010 = (ComboBox)this.FindName("stark_" + rID);
                        ComboBox Type01Cell0011 = (ComboBox)this.FindName("mat_" + rID);
                        //Row type 02
                        TextBox Type02Cell001 = (TextBox)this.FindName("row2txtBox_" + rID);
                        Button Type02Cell002 = (Button)this.FindName("row2Btn_" + rID);
                        if (Type01Cell001 != null)
                        {
                            //For row type 01
                            var currentTopPosition = Type01Cell001.Margin.Top;
                            var newTopPosition = currentTopPosition - 30;
                            int lblValue = Convert.ToInt32(Type01Cell004.Content);
                            Type01Cell001.Margin = new Thickness(700, newTopPosition, 0, 0);
                            Type01Cell002.Margin = new Thickness(600, newTopPosition, 0, 0);
                            Type01Cell003.Margin = new Thickness(820, newTopPosition, 0, 0);
                            Type01Cell004.Content = lblValue - 1;
                            Type01Cell004.Margin = new Thickness(5, newTopPosition, 0, 0);
                            Type01Cell005.Margin = new Thickness(930, newTopPosition, 0, 0);
                            Type01Cell006.Margin = new Thickness(970, newTopPosition, 0, 0);
                            Type01Cell007.Margin = new Thickness(30, newTopPosition, 0, 0);
                            Type01Cell008.Margin = new Thickness(120, newTopPosition, 0, 0);
                            Type01Cell009.Margin = new Thickness(210, newTopPosition, 0, 0);
                            Type01Cell0010.Margin = new Thickness(300, newTopPosition, 0, 0);
                            Type01Cell0011.Margin = new Thickness(390, newTopPosition, 0, 0);
                        }
                        else if (Type02Cell001 != null)
                        {
                            //For row type 02
                            var currentTopPosition = Type02Cell001.Margin.Top;
                            var newTopPosition = currentTopPosition - 30;
                            int lblValue = Convert.ToInt32(Type01Cell004.Content);
                            Type02Cell001.Margin = new Thickness(30, newTopPosition, 0, 0);
                            Type02Cell002.Margin = new Thickness(820, newTopPosition, 0, 0);
                            Type01Cell004.Content = lblValue - 1;
                            Type01Cell004.Margin = new Thickness(5, newTopPosition, 0, 0);
                            Type01Cell005.Margin = new Thickness(930, newTopPosition, 0, 0);
                            Type01Cell006.Margin = new Thickness(970, newTopPosition, 0, 0);
                        }
                    }
                }
            }
            vertRowPosition = vertRowPosition - 30;
            lastRowId = lastRowId - 1;
        }
        #endregion

        #region Save Button
        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i <= rowId; i++)
            {
                //Row type 01
                TextBox Type01Cell001 = (TextBox)this.FindName("txtBoxPrva_" + i);
                TextBox Type01Cell002 = (TextBox)this.FindName("txtBoxDruga_" + i);
                Button Type01Cell003 = (Button)this.FindName("btnPrvi_" + i);

                //Row type 02
                TextBox Type02Cell001 = (TextBox)this.FindName("row2txtBox_" + i);
                Button Type02Cell002 = (Button)this.FindName("row2Btn_" + i);

                if (Type01Cell001 != null)
                {
                    //For row type 01
                    string res01 = Type01Cell001.Text;
                    string res02 = Type01Cell002.Text;

                    MessageBox.Show(String.Format("{0} - {1}", res01, res02));
                }
                else if (Type02Cell001 != null)
                {
                    //For row type 02
                    string res01 = Type02Cell001.Text;
                    MessageBox.Show(String.Format("{0}", res01));
                }
            }
        }
        #endregion

        #region button Down
        private void btnDown_Click(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;
            int btnIndex = Convert.ToInt32(btn.Name.Split('_').Last());
            int btnIndexBelow = 0;
            int tipReda = 0;
            TextBox Type01Cell001 = (TextBox)this.FindName("txtBoxPrva_" + btnIndex);
            TextBox Type01Cell002 = (TextBox)this.FindName("txtBoxDruga_" + btnIndex);
            Button Type01Cell003 = (Button)this.FindName("btnPrvi_" + btnIndex);
            Label Type01Cell004 = (Label)this.FindName("rd_" + btnIndex);
            Button Type01Cell005 = (Button)this.FindName("btnDown_" + btnIndex);
            Button Type01Cell006 = (Button)this.FindName("btnUp_" + btnIndex);
            ComboBox Type01Cell007 = (ComboBox)this.FindName("matT_" + btnIndex);
            ComboBox Type01Cell008 = (ComboBox)this.FindName("prod_" + btnIndex);
            ComboBox Type01Cell009 = (ComboBox)this.FindName("ober_" + btnIndex);
            ComboBox Type01Cell0010 = (ComboBox)this.FindName("stark_" + btnIndex);
            ComboBox Type01Cell0011 = (ComboBox)this.FindName("mat_" + btnIndex);
            TextBox Type02Cell001 = (TextBox)this.FindName("row2txtBox_" + btnIndex);
            Button Type02Cell002 = (Button)this.FindName("row2Btn_" + btnIndex);
            var rowMargin = btn.Margin.Top + 30;
            for (int i = 0; i <= rowId; i++)
            {
                TextBox rowNumType01 = (TextBox)this.FindName("txtBoxPrva_" + i);
                TextBox rowNumType02 = (TextBox)this.FindName("row2txtBox_" + i);
                if (rowNumType01 != null)
                {
                    var curRowMargin01 = rowNumType01.Margin.Top;
                    if (curRowMargin01 == rowMargin)
                    {
                        btnIndexBelow = Convert.ToInt32(rowNumType01.Name.Split('_').Last());
                        tipReda = 1;
                    }
                }
                else if (rowNumType02 != null)
                {
                    var curRowMargin02 = rowNumType02.Margin.Top;
                    if (curRowMargin02 == rowMargin)
                    {
                        btnIndexBelow = Convert.ToInt32(rowNumType02.Name.Split('_').Last());
                        tipReda = 2;
                    }
                }
            }
            TextBox Type01Cell001Below = (TextBox)this.FindName("txtBoxPrva_" + btnIndexBelow);
            TextBox Type01Cell002Below = (TextBox)this.FindName("txtBoxDruga_" + btnIndexBelow);
            Button Type01Cell003Below = (Button)this.FindName("btnPrvi_" + btnIndexBelow);
            Label Type01Cell004Below = (Label)this.FindName("rd_" + btnIndexBelow);
            Button Type01Cell005Below = (Button)this.FindName("btnDown_" + btnIndexBelow);
            Button Type01Cell006Below = (Button)this.FindName("btnUp_" + btnIndexBelow);
            TextBox Type02Cell001btnIndexBelow = (TextBox)this.FindName("row2txtBox_" + btnIndexBelow);
            Button Type02Cell002btnIndexBelow = (Button)this.FindName("row2Btn_" + btnIndexBelow);
            ComboBox Type01Cell007Below = (ComboBox)this.FindName("matT_" + btnIndexBelow);
            ComboBox Type01Cell008Below = (ComboBox)this.FindName("prod_" + btnIndexBelow);
            ComboBox Type01Cell009Below = (ComboBox)this.FindName("ober_" + btnIndexBelow);
            ComboBox Type01Cell0010Below = (ComboBox)this.FindName("stark_" + btnIndexBelow);
            ComboBox Type01Cell0011Below = (ComboBox)this.FindName("mat_" + btnIndexBelow);
            if (Type01Cell001 != null)
            {
                var currentTopPosition = Type01Cell001.Margin.Top;
                var newTopPositionDown = currentTopPosition + 30;
                int lblValue = Convert.ToInt32(Type01Cell004.Content);
                Type01Cell001.Margin = new Thickness(700, newTopPositionDown, 0, 0);
                Type01Cell002.Margin = new Thickness(600, newTopPositionDown, 0, 0);
                Type01Cell003.Margin = new Thickness(820, newTopPositionDown, 0, 0);
                Type01Cell004.Content = lblValue + 1;
                Type01Cell004.Margin = new Thickness(5, newTopPositionDown, 0, 0);
                Type01Cell005.Margin = new Thickness(930, newTopPositionDown, 0, 0);
                Type01Cell006.Margin = new Thickness(970, newTopPositionDown, 0, 0);
                Type01Cell007.Margin = new Thickness(30, newTopPositionDown, 0, 0);
                Type01Cell008.Margin = new Thickness(120, newTopPositionDown, 0, 0);
                Type01Cell009.Margin = new Thickness(210, newTopPositionDown, 0, 0);
                Type01Cell0010.Margin = new Thickness(300, newTopPositionDown, 0, 0);
                Type01Cell0011.Margin = new Thickness(390, newTopPositionDown, 0, 0);
                if (tipReda == 1)
                {
                    var currentTopPositionBelow = Type01Cell001Below.Margin.Top;
                    var newTopPositionUp = currentTopPositionBelow - 30;
                    int lblValueBelow = Convert.ToInt32(Type01Cell004Below.Content);
                    Type01Cell001Below.Margin = new Thickness(700, newTopPositionUp, 0, 0);
                    Type01Cell002Below.Margin = new Thickness(600, newTopPositionUp, 0, 0);
                    Type01Cell003Below.Margin = new Thickness(820, newTopPositionUp, 0, 0);
                    Type01Cell004Below.Content = lblValueBelow - 1;
                    Type01Cell004Below.Margin = new Thickness(5, newTopPositionUp, 0, 0);
                    Type01Cell005Below.Margin = new Thickness(930, newTopPositionUp, 0, 0);
                    Type01Cell006Below.Margin = new Thickness(970, newTopPositionUp, 0, 0);
                    Type01Cell007Below.Margin = new Thickness(30, newTopPositionUp, 0, 0);
                    Type01Cell008Below.Margin = new Thickness(120, newTopPositionUp, 0, 0);
                    Type01Cell009Below.Margin = new Thickness(210, newTopPositionUp, 0, 0);
                    Type01Cell0010Below.Margin = new Thickness(300, newTopPositionUp, 0, 0);
                    Type01Cell0011Below.Margin = new Thickness(390, newTopPositionUp, 0, 0);
                }
                else if (tipReda == 2)
                {
                    var currentTopPositionBelow = Type02Cell001btnIndexBelow.Margin.Top;
                    var newTopPositionUp = currentTopPositionBelow - 30;
                    int lblValueBelow = Convert.ToInt32(Type01Cell004.Content);
                    Type02Cell001btnIndexBelow.Margin = new Thickness(30, newTopPositionUp, 0, 0);
                    Type02Cell002btnIndexBelow.Margin = new Thickness(820, newTopPositionUp, 0, 0);
                    Type01Cell004Below.Content = lblValueBelow - 1;
                    Type01Cell004Below.Margin = new Thickness(5, newTopPositionUp, 0, 0);
                    Type01Cell005Below.Margin = new Thickness(930, newTopPositionUp, 0, 0);
                    Type01Cell006Below.Margin = new Thickness(970, newTopPositionUp, 0, 0);
                }
            }
            else if (Type02Cell001 != null)
            {
                var currentTopPosition = Type02Cell001.Margin.Top;
                var newTopPositionDown = currentTopPosition + 30;
                int lblValue = Convert.ToInt32(Type01Cell004.Content);
                Type02Cell001.Margin = new Thickness(30, newTopPositionDown, 0, 0);
                Type02Cell002.Margin = new Thickness(820, newTopPositionDown, 0, 0);
                Type01Cell004.Content = lblValue + 1;
                Type01Cell004.Margin = new Thickness(5, newTopPositionDown, 0, 0);
                Type01Cell005.Margin = new Thickness(930, newTopPositionDown, 0, 0);
                Type01Cell006.Margin = new Thickness(970, newTopPositionDown, 0, 0);
                if (tipReda == 1)
                {
                    var currentTopPositionBelow = Type01Cell001Below.Margin.Top;
                    var newTopPositionUp = currentTopPositionBelow - 30;
                    int lblValueBelow = Convert.ToInt32(Type01Cell004Below.Content);
                    Type01Cell001Below.Margin = new Thickness(700, newTopPositionUp, 0, 0);
                    Type01Cell002Below.Margin = new Thickness(600, newTopPositionUp, 0, 0);
                    Type01Cell003Below.Margin = new Thickness(820, newTopPositionUp, 0, 0);
                    Type01Cell004Below.Content = lblValueBelow - 1;
                    Type01Cell004Below.Margin = new Thickness(5, newTopPositionUp, 0, 0);
                    Type01Cell005Below.Margin = new Thickness(930, newTopPositionUp, 0, 0);
                    Type01Cell006Below.Margin = new Thickness(970, newTopPositionUp, 0, 0);
                    Type01Cell007Below.Margin = new Thickness(30, newTopPositionUp, 0, 0);
                    Type01Cell008Below.Margin = new Thickness(120, newTopPositionUp, 0, 0);
                    Type01Cell009Below.Margin = new Thickness(210, newTopPositionUp, 0, 0);
                    Type01Cell0010Below.Margin = new Thickness(300, newTopPositionUp, 0, 0);
                    Type01Cell0011Below.Margin = new Thickness(390, newTopPositionUp, 0, 0);
                }
                else if (tipReda == 2)
                {
                    var currentTopPositionBelow = Type02Cell001btnIndexBelow.Margin.Top;
                    var newTopPositionUp = currentTopPositionBelow - 30;
                    int lblValueBelow = Convert.ToInt32(Type01Cell004.Content);
                    Type02Cell001btnIndexBelow.Margin = new Thickness(30, newTopPositionUp, 0, 0);
                    Type02Cell002btnIndexBelow.Margin = new Thickness(820, newTopPositionUp, 0, 0);
                    Type01Cell004Below.Content = lblValueBelow - 1;
                    Type01Cell004Below.Margin = new Thickness(5, newTopPositionUp, 0, 0);
                    Type01Cell005Below.Margin = new Thickness(930, newTopPositionUp, 0, 0);
                    Type01Cell006Below.Margin = new Thickness(970, newTopPositionUp, 0, 0);
                }
            }
        }
        #endregion

        #region button Up
        private void btnUp_Click(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;
            int btnIndex = Convert.ToInt32(btn.Name.Split('_').Last());
            int btnIndexBelow = 0;
            int tipReda = 0;
            TextBox Type01Cell001 = (TextBox)this.FindName("txtBoxPrva_" + btnIndex);
            TextBox Type01Cell002 = (TextBox)this.FindName("txtBoxDruga_" + btnIndex);
            Button Type01Cell003 = (Button)this.FindName("btnPrvi_" + btnIndex);
            Label Type01Cell004 = (Label)this.FindName("rd_" + btnIndex);
            Button Type01Cell005 = (Button)this.FindName("btnDown_" + btnIndex);
            Button Type01Cell006 = (Button)this.FindName("btnUp_" + btnIndex);
            ComboBox Type01Cell007 = (ComboBox)this.FindName("matT_" + btnIndex);
            ComboBox Type01Cell008 = (ComboBox)this.FindName("prod_" + btnIndex);
            ComboBox Type01Cell009 = (ComboBox)this.FindName("ober_" + btnIndex);
            ComboBox Type01Cell0010 = (ComboBox)this.FindName("stark_" + btnIndex);
            ComboBox Type01Cell0011 = (ComboBox)this.FindName("mat_" + btnIndex);
            TextBox Type02Cell001 = (TextBox)this.FindName("row2txtBox_" + btnIndex);
            Button Type02Cell002 = (Button)this.FindName("row2Btn_" + btnIndex);
            var rowMargin = btn.Margin.Top - 30;
            for (int i = 0; i <= rowId; i++)
            {
                TextBox rowNumType01 = (TextBox)this.FindName("txtBoxPrva_" + i);
                TextBox rowNumType02 = (TextBox)this.FindName("row2txtBox_" + i);
                if (rowNumType01 != null)
                {
                    var curRowMargin01 = rowNumType01.Margin.Top;
                    if (curRowMargin01 == rowMargin)
                    {
                        btnIndexBelow = Convert.ToInt32(rowNumType01.Name.Split('_').Last());
                        tipReda = 1;
                    }
                }
                else if (rowNumType02 != null)
                {
                    var curRowMargin02 = rowNumType02.Margin.Top;
                    if (curRowMargin02 == rowMargin)
                    {
                        btnIndexBelow = Convert.ToInt32(rowNumType02.Name.Split('_').Last());
                        tipReda = 2;
                    }
                }
            }
            TextBox Type01Cell001Below = (TextBox)this.FindName("txtBoxPrva_" + btnIndexBelow);
            TextBox Type01Cell002Below = (TextBox)this.FindName("txtBoxDruga_" + btnIndexBelow);
            Button Type01Cell003Below = (Button)this.FindName("btnPrvi_" + btnIndexBelow);
            Label Type01Cell004Below = (Label)this.FindName("rd_" + btnIndexBelow);
            Button Type01Cell005Below = (Button)this.FindName("btnDown_" + btnIndexBelow);
            Button Type01Cell006Below = (Button)this.FindName("btnUp_" + btnIndexBelow);
            ComboBox Type01Cell007Below = (ComboBox)this.FindName("matT_" + btnIndexBelow);
            ComboBox Type01Cell008Below = (ComboBox)this.FindName("prod_" + btnIndexBelow);
            ComboBox Type01Cell009Below = (ComboBox)this.FindName("ober_" + btnIndexBelow);
            ComboBox Type01Cell0010Below = (ComboBox)this.FindName("stark_" + btnIndexBelow);
            ComboBox Type01Cell0011Below = (ComboBox)this.FindName("mat_" + btnIndexBelow);
            TextBox Type02Cell001btnIndexBelow = (TextBox)this.FindName("row2txtBox_" + btnIndexBelow);
            Button Type02Cell002btnIndexBelow = (Button)this.FindName("row2Btn_" + btnIndexBelow);
            if (Type01Cell001 != null)
            {
                var currentTopPosition = Type01Cell001.Margin.Top;
                var newTopPositionDown = currentTopPosition - 30;
                int lblValue = Convert.ToInt32(Type01Cell004.Content);
                Type01Cell001.Margin = new Thickness(700, newTopPositionDown, 0, 0);
                Type01Cell002.Margin = new Thickness(600, newTopPositionDown, 0, 0);
                Type01Cell003.Margin = new Thickness(820, newTopPositionDown, 0, 0);
                Type01Cell004.Content = lblValue - 1;
                Type01Cell004.Margin = new Thickness(5, newTopPositionDown, 0, 0);
                Type01Cell005.Margin = new Thickness(930, newTopPositionDown, 0, 0);
                Type01Cell006.Margin = new Thickness(970, newTopPositionDown, 0, 0);
                Type01Cell007.Margin = new Thickness(30, newTopPositionDown, 0, 0);
                Type01Cell008.Margin = new Thickness(120, newTopPositionDown, 0, 0);
                Type01Cell009.Margin = new Thickness(210, newTopPositionDown, 0, 0);
                Type01Cell0010.Margin = new Thickness(300, newTopPositionDown, 0, 0);
                Type01Cell0011.Margin = new Thickness(390, newTopPositionDown, 0, 0);
                if (tipReda == 1)
                {
                    var currentTopPositionBelow = Type01Cell001Below.Margin.Top;
                    var newTopPositionUp = currentTopPositionBelow + 30;
                    int lblValueBelow = Convert.ToInt32(Type01Cell004Below.Content);
                    Type01Cell001Below.Margin = new Thickness(700, newTopPositionUp, 0, 0);
                    Type01Cell002Below.Margin = new Thickness(600, newTopPositionUp, 0, 0);
                    Type01Cell003Below.Margin = new Thickness(820, newTopPositionUp, 0, 0);
                    Type01Cell004Below.Content = lblValueBelow + 1;
                    Type01Cell004Below.Margin = new Thickness(5, newTopPositionUp, 0, 0);
                    Type01Cell005Below.Margin = new Thickness(930, newTopPositionUp, 0, 0);
                    Type01Cell006Below.Margin = new Thickness(970, newTopPositionUp, 0, 0);
                    Type01Cell007Below.Margin = new Thickness(30, newTopPositionUp, 0, 0);
                    Type01Cell008Below.Margin = new Thickness(120, newTopPositionUp, 0, 0);
                    Type01Cell009Below.Margin = new Thickness(210, newTopPositionUp, 0, 0);
                    Type01Cell0010Below.Margin = new Thickness(300, newTopPositionUp, 0, 0);
                    Type01Cell0011Below.Margin = new Thickness(390, newTopPositionUp, 0, 0);
                }
                else if (tipReda == 2)
                {
                    var currentTopPositionBelow = Type02Cell001btnIndexBelow.Margin.Top;
                    var newTopPositionUp = currentTopPositionBelow + 30;
                    int lblValueBelow = Convert.ToInt32(Type01Cell004.Content);
                    Type02Cell001btnIndexBelow.Margin = new Thickness(30, newTopPositionUp, 0, 0);
                    Type02Cell002btnIndexBelow.Margin = new Thickness(820, newTopPositionUp, 0, 0);
                    Type01Cell004Below.Content = lblValueBelow + 1;
                    Type01Cell004Below.Margin = new Thickness(5, newTopPositionUp, 0, 0);
                    Type01Cell005Below.Margin = new Thickness(930, newTopPositionUp, 0, 0);
                    Type01Cell006Below.Margin = new Thickness(970, newTopPositionUp, 0, 0);
                }
            }
            else if (Type02Cell001 != null)
            {
                var currentTopPosition = Type02Cell001.Margin.Top;
                var newTopPositionDown = currentTopPosition - 30;
                int lblValue = Convert.ToInt32(Type01Cell004.Content);
                Type02Cell001.Margin = new Thickness(30, newTopPositionDown, 0, 0);
                Type02Cell002.Margin = new Thickness(820, newTopPositionDown, 0, 0);
                Type01Cell004.Content = lblValue - 1;
                Type01Cell004.Margin = new Thickness(5, newTopPositionDown, 0, 0);
                Type01Cell005.Margin = new Thickness(930, newTopPositionDown, 0, 0);
                Type01Cell006.Margin = new Thickness(970, newTopPositionDown, 0, 0);
                if (tipReda == 1)
                {
                    var currentTopPositionBelow = Type01Cell001Below.Margin.Top;
                    var newTopPositionUp = currentTopPositionBelow + 30;
                    int lblValueBelow = Convert.ToInt32(Type01Cell004Below.Content);
                    Type01Cell001Below.Margin = new Thickness(700, newTopPositionUp, 0, 0);
                    Type01Cell002Below.Margin = new Thickness(600, newTopPositionUp, 0, 0);
                    Type01Cell003Below.Margin = new Thickness(820, newTopPositionUp, 0, 0);
                    Type01Cell004Below.Content = lblValueBelow + 1;
                    Type01Cell004Below.Margin = new Thickness(5, newTopPositionUp, 0, 0);
                    Type01Cell005Below.Margin = new Thickness(930, newTopPositionUp, 0, 0);
                    Type01Cell006Below.Margin = new Thickness(970, newTopPositionUp, 0, 0);
                    Type01Cell007Below.Margin = new Thickness(30, newTopPositionUp, 0, 0);
                    Type01Cell008Below.Margin = new Thickness(120, newTopPositionUp, 0, 0);
                    Type01Cell009Below.Margin = new Thickness(210, newTopPositionUp, 0, 0);
                    Type01Cell0010Below.Margin = new Thickness(300, newTopPositionUp, 0, 0);
                    Type01Cell0011Below.Margin = new Thickness(390, newTopPositionUp, 0, 0);
                }
                else if (tipReda == 2)
                {
                    var currentTopPositionBelow = Type02Cell001btnIndexBelow.Margin.Top;
                    var newTopPositionUp = currentTopPositionBelow + 30;
                    int lblValueBelow = Convert.ToInt32(Type01Cell004.Content);
                    Type02Cell001btnIndexBelow.Margin = new Thickness(30, newTopPositionUp, 0, 0);
                    Type02Cell002btnIndexBelow.Margin = new Thickness(820, newTopPositionUp, 0, 0);
                    Type01Cell004Below.Content = lblValueBelow + 1;
                    Type01Cell004Below.Margin = new Thickness(5, newTopPositionUp, 0, 0);
                    Type01Cell005Below.Margin = new Thickness(930, newTopPositionUp, 0, 0);
                    Type01Cell006Below.Margin = new Thickness(970, newTopPositionUp, 0, 0);
                }
            }
        }
        #endregion
        #endregion
    }
}
