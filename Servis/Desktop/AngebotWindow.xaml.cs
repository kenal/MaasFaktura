﻿using Desktop.Service;
using Desktop.ViewModel;
using Mass.Data;
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
using System.Windows.Navigation;
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
        List<string> nameList;
        Service.MassServisClient client = new MassServisClient();

        public AngebotWindow()
        {
            InitializeComponent();
            this.DataContext = new AngebotViewModel();
            addRowType01();
            bindMethod();
        }

        private void Window_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            gridsResolution();
            gridsResolution2();
        }
        #region Resolution
        public void gridsResolution()
        {
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

        #region Button Add New 03
        private void btnNewRow03_Click(object sender, RoutedEventArgs e)
        {
            addRowType03();
        }
        #endregion

        #region Add Row Type 01
        private void addRowType01()
        {
            Service.MassServisClient client = new MassServisClient();
            var materijalList = client.getMaterijal();
            var produktList = client.getProdukt();
            var oberflacheList = client.getPovrsinaByMaterijal(1);
            var starkeList = client.getDebljinaByProduktId(1);
            var einheitList = client.getEinheit();

            rowId = rowId + 1;
            TextBox brei = new TextBox();
            TextBox lng = new TextBox();
            ComboBox matT = new ComboBox();
            ComboBox prod = new ComboBox();
            ComboBox ober = new ComboBox();
            ComboBox stark = new ComboBox();
            ComboBox mat = new ComboBox();
            ComboBox gehr = new ComboBox();
            ComboBox einh = new ComboBox();
            TextBox men = new TextBox();
            TextBox einz = new TextBox();
            TextBox stk = new TextBox();
            TextBox gpreis = new TextBox();
            TextBox rab = new TextBox();
            CheckBox akonto = new CheckBox();
            Button myDinamicButton01 = new Button();
            Label myLabel01 = new Label();
            Button btnDown = new Button();
            Button btnUp = new Button();
            Button btnAddType01 = new Button();
            Button btnAddType02 = new Button();
            //Button with image arrow down
            Image imgDown = new Image();
            BitmapImage biDown = new BitmapImage();
            biDown.BeginInit();
            biDown.UriSource = new Uri("images/icons/arrDown.png", UriKind.Relative);
            biDown.EndInit();
            imgDown.Source = biDown;
            imgDown.Width = 13;
            imgDown.Height = 13;
            imgDown.Stretch = Stretch.Fill;
            btnDown.Content = imgDown;
            //Button with image arrow up
            Image imgUp = new Image();
            BitmapImage biUp = new BitmapImage();
            biUp.BeginInit();
            biUp.UriSource = new Uri("images/icons/arrUp.png", UriKind.Relative);
            biUp.EndInit();
            imgUp.Source = biUp;
            imgUp.Width = 13;
            imgUp.Height = 13;
            imgUp.Stretch = Stretch.Fill;
            btnUp.Content = imgUp;
            //Button with image close
            Image imgClose = new Image();
            BitmapImage biClose = new BitmapImage();
            biClose.BeginInit();
            biClose.UriSource = new Uri("images/icons/btnClose.png", UriKind.Relative);
            biClose.EndInit();
            imgClose.Source = biClose;
            imgClose.Width = 13;
            imgClose.Height = 13;
            imgClose.Stretch = Stretch.Fill;
            myDinamicButton01.Content = imgClose;
            brei.Width = 40;
            brei.Height = 25;
            lng.Width = 40;
            lng.Height = 25;
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
            gehr.Width = 80;
            gehr.Height = 25;
            einh.Width = 80;
            einh.Height = 25;
            men.Width = 40;
            men.Height = 25;
            einz.Width = 60;
            einz.Height = 25;
            stk.Width = 40;
            stk.Height = 25;
            gpreis.Width = 60;
            gpreis.Height = 25;
            rab.Width = 40;
            rab.Height = 25;
            myDinamicButton01.Width = 70;
            myDinamicButton01.Height = 25;
            btnAddType01.Width = 80;
            btnAddType01.Height = 25;
            btnAddType02.Width = 80;
            btnAddType02.Height = 25;
            myLabel01.Width = 25;
            myLabel01.Height = 30;
            btnDown.Width = 30;
            btnDown.Height = 25;
            btnUp.Width = 30;
            btnUp.Height = 25;

            brei.HorizontalAlignment = HorizontalAlignment.Left;
            brei.VerticalAlignment = VerticalAlignment.Top;
            lng.HorizontalAlignment = HorizontalAlignment.Left;
            lng.VerticalAlignment = VerticalAlignment.Top;
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
            gehr.HorizontalAlignment = HorizontalAlignment.Left;
            gehr.VerticalAlignment = VerticalAlignment.Top;
            einh.HorizontalAlignment = HorizontalAlignment.Left;
            einh.VerticalAlignment = VerticalAlignment.Top;
            men.HorizontalAlignment = HorizontalAlignment.Left;
            men.VerticalAlignment = VerticalAlignment.Top;
            einz.HorizontalAlignment = HorizontalAlignment.Left;
            einz.VerticalAlignment = VerticalAlignment.Top;
            stk.HorizontalAlignment = HorizontalAlignment.Left;
            stk.VerticalAlignment = VerticalAlignment.Top;
            gpreis.HorizontalAlignment = HorizontalAlignment.Left;
            gpreis.VerticalAlignment = VerticalAlignment.Top;
            rab.HorizontalAlignment = HorizontalAlignment.Left;
            rab.VerticalAlignment = VerticalAlignment.Top;
            akonto.HorizontalAlignment = HorizontalAlignment.Left;
            akonto.VerticalAlignment = VerticalAlignment.Top;

            var topW = vertRowPosition + 30;
            brei.Margin = new Thickness(730, vertRowPosition, 0, 0);
            lng.Margin = new Thickness(680, vertRowPosition, 0, 0);
            //Row start
            myLabel01.Margin = new Thickness(5, vertRowPosition, 0, 0);
            matT.Margin = new Thickness(30, vertRowPosition, 0, 0);
            prod.Margin = new Thickness(120, vertRowPosition, 0, 0);
            ober.Margin = new Thickness(210, vertRowPosition, 0, 0);
            stark.Margin = new Thickness(300, vertRowPosition, 0, 0);
            mat.Margin = new Thickness(390, vertRowPosition, 0, 0);
            gehr.Margin = new Thickness(500, vertRowPosition, 0, 0);
            einh.Margin = new Thickness(590, vertRowPosition, 0, 0);
            men.Margin = new Thickness(780, vertRowPosition, 0, 0);
            einz.Margin = new Thickness(830, vertRowPosition, 0, 0);
            stk.Margin = new Thickness(900, vertRowPosition, 0, 0);
            gpreis.Margin = new Thickness(950, vertRowPosition, 0, 0);
            rab.Margin = new Thickness(1020, vertRowPosition, 0, 0);
            akonto.Margin = new Thickness(1075, vertRowPosition + 5, 0, 0);
            myDinamicButton01.Margin = new Thickness(1110, vertRowPosition, 0, 0);
            btnAddType01.Margin = new Thickness(140, topW, 0, 0);
            btnAddType02.Margin = new Thickness(240, topW, 0, 0);
            btnDown.Margin = new Thickness(1190, vertRowPosition, 0, 0);
            btnUp.Margin = new Thickness(1230, vertRowPosition, 0, 0);

            brei.Name = "txtBoxPrva_" + rowId;
            this.RegisterName("txtBoxPrva_" + rowId, brei);
            brei.VerticalContentAlignment = VerticalAlignment.Center;
            brei.TextChanged += menPreracunavanje_TextChanged;
            lng.Name = "txtBoxDruga_" + rowId;
            this.RegisterName("txtBoxDruga_" + rowId, lng);
            lng.VerticalContentAlignment = VerticalAlignment.Center;
            lng.TextChanged += menPreracunavanje_TextChanged;
            myDinamicButton01.Name = "btnPrvi_" + rowId;
            this.RegisterName("btnPrvi_" + rowId, myDinamicButton01);
            btnAddType01.Name = "btnAddNew01Row_" + rowId;
            btnAddType01.Content = "Add Row 01";
            this.RegisterName("btnAddNew01Row_" + rowId, btnAddType01);
            btnAddType02.Name = "btnAddNew02Row_" + rowId;
            btnAddType02.Content = "Add Row 02";
            this.RegisterName("btnAddNew02Row_" + rowId, btnAddType02);
            myDinamicButton01.Click += myDinamicButton01_Click;
            myLabel01.Name = "rd_" + rowId;
            myLabel01.Foreground = Brushes.Green;
            myLabel01.FontWeight = FontWeights.Bold;
            this.RegisterName("rd_" + rowId, myLabel01);
            btnDown.Click += btnDown_Click;
            btnDown.Name = "btnDown_" + rowId;
            this.RegisterName("btnDown_" + rowId, btnDown);
            btnUp.Click += btnUp_Click;
            btnUp.Name = "btnUp_" + rowId;
            this.RegisterName("btnUp_" + rowId, btnUp);
            matT.Name = "matT_" + rowId;
            this.RegisterName("matT_" + rowId, matT);
            foreach (var p in materijalList) { matT.Items.Add(p.naziv); }
            matT.SelectedIndex = 0;
            matT.SelectionChanged += matT_SelectionChanged;
            prod.Name = "prod_" + rowId;
            this.RegisterName("prod_" + rowId, prod);
            foreach (var p in produktList) { prod.Items.Add(p.naziv); }
            prod.SelectedIndex = 0;
            prod.SelectionChanged += prod_SelectionChanged;
            ober.Name = "ober_" + rowId;
            this.RegisterName("ober_" + rowId, ober);
            foreach (var p in oberflacheList) { ober.Items.Add(p.pov); }
            ober.SelectedIndex = 0;
            stark.Name = "stark_" + rowId;
            this.RegisterName("stark_" + rowId, stark);
            foreach (var p in starkeList) { stark.Items.Add(p.starke1); }
            stark.SelectedIndex = 0;
            mat.Name = "mat_" + rowId;
            this.RegisterName("mat_" + rowId, mat);
            var mType = client.getMatIdByName(matT.SelectedValue.ToString());
            var mArt = client.getMaterijalByID(mType[0].id);
            mat.Items.Clear();
            mat.SelectionChanged += mat_SelectionChanged;
            foreach (var p in mArt) { mat.Items.Add(p.naziv); }
            mat.SelectedIndex = 0;
            gehr.Name = "gehr_" + rowId;
            this.RegisterName("gehr_" + rowId, gehr);
            gehr.Items.Add("Nein");
            gehr.Items.Add("Ja");
            gehr.Items.Add("Sonstige");
            gehr.SelectedIndex = 0;
            einh.Name = "einh_" + rowId;
            this.RegisterName("einh_" + rowId, einh);
            foreach (var p in einheitList) { einh.Items.Add(p.jedinica.Replace("\"","").Trim()); }
            einh.SelectedIndex = 0;
            einh.SelectionChanged += einh_SelectionChanged;
            men.Name = "men_" + rowId;
            this.RegisterName("men_" + rowId, men);
            men.TextChanged += men1_TextChanged;
            men.VerticalContentAlignment = VerticalAlignment.Center;
            einz.Name = "einz_" + rowId;
            this.RegisterName("einz_" + rowId, einz);
            einz.TextChanged += men1_TextChanged;
            einz.VerticalContentAlignment = VerticalAlignment.Center;
            stk.Name = "stk_" + rowId;
            this.RegisterName("stk_" + rowId, stk);
            stk.TextChanged += men1_TextChanged;
            stk.VerticalContentAlignment = VerticalAlignment.Center;
            gpreis.Name = "gpreis_" + rowId;
            this.RegisterName("gpreis_" + rowId, gpreis);
            gpreis.VerticalContentAlignment = VerticalAlignment.Center;
            gpreis.KeyDown += gPreis_KeyDown;
            rab.Name = "rab_" + rowId;
            this.RegisterName("rab_" + rowId, rab);
            rab.VerticalContentAlignment = VerticalAlignment.Center;
            akonto.Name = "akonto_" + rowId;
            this.RegisterName("akonto_" + rowId, akonto);
            akonto.Click += akonto_Click;

            lastRowId = lastRowId + 1;
            if (lastRowId != 0) { myLabel01.Content = lastRowId; } else { myLabel01.Content = rowId; }
            grid01.Children.Add(brei);
            grid01.Children.Add(lng);
            grid01.Children.Add(myDinamicButton01);
            grid01.Children.Add(matT);
            grid01.Children.Add(prod);
            grid01.Children.Add(myLabel01);
            grid01.Children.Add(ober);
            grid01.Children.Add(stark);
            grid01.Children.Add(mat);
            grid01.Children.Add(gehr);
            grid01.Children.Add(einh);
            grid01.Children.Add(men);
            grid01.Children.Add(einz);
            grid01.Children.Add(stk);
            grid01.Children.Add(gpreis);
            grid01.Children.Add(btnDown);
            grid01.Children.Add(btnUp);
            grid01.Children.Add(rab);
            grid01.Children.Add(akonto);

            vertRowPosition = vertRowPosition + 30;
            scr01.ScrollToBottom();
            if (lastRowId > 6)
            {
                if(grdHeaders.Margin.Left == 0)
                grdHeaders.Margin = new Thickness(-14, grdHeaders.Margin.Top, 0, 0);
            }
            
            //get_price(lastRowId, 1, mType[0].id, "0,8 cm", "poliert");
        }
        #endregion

        #region Add Row Type 02
        private void addRowType02()
        {
            Service.MassServisClient client = new MassServisClient();
            var PozicijaList = client.getPozicija();
            var PodPozicija = client.getPodpozicijaFromPozicija(1);

            rowId = rowId + 1;
            TextBox Row2myDinamicTxtBox01 = new TextBox();
            Button Row2myDinamicButton01 = new Button();
            Label myLabel01 = new Label();
            Button btnDown = new Button();
            Button btnUp = new Button();
            //Row 2 Column content
            ComboBox r2First = new ComboBox();
            ComboBox r2Second = new ComboBox();
            TextBox r2brei = new TextBox();
            TextBox r2lng = new TextBox();
            TextBox r2einh = new TextBox();
            TextBox r2men = new TextBox();
            TextBox r2einz = new TextBox();
            TextBox r2stk = new TextBox();
            TextBox r2gpreis = new TextBox();
            TextBox r2rab = new TextBox();
            CheckBox r2akonto = new CheckBox();
            //Button with image arrow down
            Image imgDown = new Image();
            BitmapImage biDown = new BitmapImage();
            biDown.BeginInit();
            biDown.UriSource = new Uri("images/icons/arrDown.png", UriKind.Relative);
            biDown.EndInit();
            imgDown.Source = biDown;
            imgDown.Width = 13;
            imgDown.Height = 13;
            imgDown.Stretch = Stretch.Fill;
            btnDown.Content = imgDown;
            //Button with image arrow up
            Image imgUp = new Image();
            BitmapImage biUp = new BitmapImage();
            biUp.BeginInit();
            biUp.UriSource = new Uri("images/icons/arrUp.png", UriKind.Relative);
            biUp.EndInit();
            imgUp.Source = biUp;
            imgUp.Width = 13;
            imgUp.Height = 13;
            imgUp.Stretch = Stretch.Fill;
            btnUp.Content = imgUp;
            //Button with image close
            Image imgClose = new Image();
            BitmapImage biClose = new BitmapImage();
            biClose.BeginInit();
            biClose.UriSource = new Uri("images/icons/btnClose.png", UriKind.Relative);
            biClose.EndInit();
            imgClose.Source = biClose;
            imgClose.Width = 13;
            imgClose.Height = 13;
            imgClose.Stretch = Stretch.Fill;
            Row2myDinamicButton01.Content = imgClose;            
            Row2myDinamicTxtBox01.Visibility = Visibility.Hidden;
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
            r2First.Width = 80;
            r2First.Height = 25;
            r2Second.Width = 350;
            r2Second.Height = 25;
            r2brei.Width = 40;
            r2brei.Height = 25;
            r2lng.Width = 40;
            r2lng.Height = 25;
            r2einh.Width = 80;
            r2einh.Height = 25;
            r2men.Width = 40;
            r2men.Height = 25;
            r2einz.Width = 60;
            r2einz.Height = 25;
            r2stk.Width = 40;
            r2stk.Height = 25;
            r2gpreis.Width = 60;
            r2gpreis.Height = 25;
            r2rab.Width = 40;
            r2rab.Height = 25;

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
            r2First.HorizontalAlignment = HorizontalAlignment.Left;
            r2First.VerticalAlignment = VerticalAlignment.Top;
            r2Second.HorizontalAlignment = HorizontalAlignment.Left;
            r2Second.VerticalAlignment = VerticalAlignment.Top;
            r2brei.HorizontalAlignment = HorizontalAlignment.Left;
            r2brei.VerticalAlignment = VerticalAlignment.Top;
            r2lng.HorizontalAlignment = HorizontalAlignment.Left;
            r2lng.VerticalAlignment = VerticalAlignment.Top;
            r2einh.HorizontalAlignment = HorizontalAlignment.Left;
            r2einh.VerticalAlignment = VerticalAlignment.Top;
            r2men.HorizontalAlignment = HorizontalAlignment.Left;
            r2men.VerticalAlignment = VerticalAlignment.Top;
            r2einz.HorizontalAlignment = HorizontalAlignment.Left;
            r2einz.VerticalAlignment = VerticalAlignment.Top;
            r2stk.HorizontalAlignment = HorizontalAlignment.Left;
            r2stk.VerticalAlignment = VerticalAlignment.Top;
            r2gpreis.HorizontalAlignment = HorizontalAlignment.Left;
            r2gpreis.VerticalAlignment = VerticalAlignment.Top;
            r2rab.HorizontalAlignment = HorizontalAlignment.Left;
            r2rab.VerticalAlignment = VerticalAlignment.Top;
            r2akonto.HorizontalAlignment = HorizontalAlignment.Left;
            r2akonto.VerticalAlignment = VerticalAlignment.Top;

            Row2myDinamicTxtBox01.Margin = new Thickness(30, vertRowPosition, 0, 0);
            r2First.Margin = new Thickness(30, vertRowPosition, 0, 0);
            r2Second.Margin = new Thickness(120, vertRowPosition, 0, 0);
            r2brei.Margin = new Thickness(730, vertRowPosition, 0, 0);
            r2lng.Margin = new Thickness(680, vertRowPosition, 0, 0);
            r2einh.Margin = new Thickness(590, vertRowPosition, 0, 0);
            r2men.Margin = new Thickness(780, vertRowPosition, 0, 0);
            r2einz.Margin = new Thickness(830, vertRowPosition, 0, 0);
            r2stk.Margin = new Thickness(900, vertRowPosition, 0, 0);
            r2gpreis.Margin = new Thickness(950, vertRowPosition, 0, 0);
            Row2myDinamicButton01.Margin = new Thickness(1110, vertRowPosition, 0, 0);
            myLabel01.Margin = new Thickness(5, vertRowPosition, 0, 0);
            btnDown.Margin = new Thickness(1190, vertRowPosition, 0, 0);
            btnUp.Margin = new Thickness(1230, vertRowPosition, 0, 0);
            r2rab.Margin = new Thickness(1020, vertRowPosition, 0, 0);
            r2akonto.Margin = new Thickness(1075, vertRowPosition + 5, 0, 0);

            Row2myDinamicTxtBox01.Name = "row2txtBox_" + rowId;
            this.RegisterName("row2txtBox_" + rowId, Row2myDinamicTxtBox01);
            Row2myDinamicButton01.Name = "row2Btn_" + rowId;
            Row2myDinamicButton01.DataContext = grid01;
            this.RegisterName("row2Btn_" + rowId, Row2myDinamicButton01);
            myLabel01.Name = "rd_" + rowId;
            this.RegisterName("rd_" + rowId, myLabel01);
            myLabel01.Foreground = Brushes.Green;
            myLabel01.FontWeight = FontWeights.Bold;
            btnDown.Click += btnDown_Click;
            btnDown.Name = "btnDown_" + rowId;
            this.RegisterName("btnDown_" + rowId, btnDown);
            btnUp.Click += btnUp_Click;
            btnUp.Name = "btnUp_" + rowId;
            this.RegisterName("btnUp_" + rowId, btnUp);
            r2First.Name = "r2First_" + rowId;
            foreach (var p in PozicijaList) { r2First.Items.Add(p.naziv); }
            r2First.SelectedIndex = 0;
            r2First.SelectionChanged += r2First_SelectionChanged;
            this.RegisterName("r2First_" + rowId, r2First);
            r2Second.Name = "r2Second_" + rowId;
            this.RegisterName("r2Second_" + rowId, r2Second);
            r2Second.SelectionChanged += r2Second_SelectionChanged;
            foreach (var p in PodPozicija) { r2Second.Items.Add(p.naziv); }
            r2Second.SelectedIndex = 0;
            r2brei.Name = "r2brei_" + rowId;
            this.RegisterName("r2brei_" + rowId, r2brei);
            r2brei.IsReadOnly = true;
            r2brei.Background = Brushes.LightGray;
            r2lng.Name = "r2lng_" + rowId;
            this.RegisterName("r2lng_" + rowId, r2lng);
            r2lng.IsReadOnly = true;
            r2lng.Background = Brushes.LightGray;
            r2einh.Name = "r2einh_" + rowId;
            this.RegisterName("r2einh_" + rowId, r2einh);
            r2einh.IsReadOnly = true;
            r2einh.Background = Brushes.LightGray;
            r2men.Name = "r2men_" + rowId;
            this.RegisterName("r2men_" + rowId, r2men);
            r2men.VerticalContentAlignment = VerticalAlignment.Center;
            r2men.TextChanged += men2_TextChanged;
            r2einz.Name = "r2einz_" + rowId;
            this.RegisterName("r2einz_" + rowId, r2einz);
            r2einz.VerticalContentAlignment = VerticalAlignment.Center;
            r2einz.TextChanged += men2_TextChanged;
            r2stk.Name = "r2stk_" + rowId;
            this.RegisterName("r2stk_" + rowId, r2stk);
            r2stk.VerticalContentAlignment = VerticalAlignment.Center;
            r2stk.TextChanged += men2_TextChanged;
            r2gpreis.Name = "r2gpreis_" + rowId;
            this.RegisterName("r2gpreis_" + rowId, r2gpreis);
            r2gpreis.VerticalContentAlignment = VerticalAlignment.Center;
            r2gpreis.TextChanged += men2_TextChanged;
            r2gpreis.KeyUp += gPreis_KeyDown;
            r2rab.Name = "r2rab_" + rowId;
            this.RegisterName("r2rab_" + rowId, r2rab);
            r2rab.VerticalContentAlignment = VerticalAlignment.Center;
            r2akonto.Name = "r2akonto_" + rowId;
            this.RegisterName("r2akonto_" + rowId, r2akonto);
            r2akonto.Click += akonto_Click;

            myLabel01.Foreground = Brushes.Green;
            myLabel01.FontWeight = FontWeights.Bold;
            lastRowId = lastRowId + 1;
            if (lastRowId != 0) { myLabel01.Content = lastRowId; } else { myLabel01.Content = rowId; }


            Row2myDinamicButton01.Click += Row2myDinamicButton01_Click;

            grid01.Children.Add(Row2myDinamicTxtBox01);
            grid01.Children.Add(Row2myDinamicButton01);
            grid01.Children.Add(myLabel01);
            grid01.Children.Add(btnDown);
            grid01.Children.Add(btnUp);
            grid01.Children.Add(r2First);
            grid01.Children.Add(r2Second);
            grid01.Children.Add(r2brei);
            grid01.Children.Add(r2lng);
            grid01.Children.Add(r2einh);
            grid01.Children.Add(r2men);
            grid01.Children.Add(r2einz);
            grid01.Children.Add(r2stk);
            grid01.Children.Add(r2gpreis);
            grid01.Children.Add(r2rab);
            grid01.Children.Add(r2akonto);

            vertRowPosition = vertRowPosition + 30;
            scr01.ScrollToBottom();
            if (lastRowId > 6)
            {
                if (grdHeaders.Margin.Left == 0)
                    grdHeaders.Margin = new Thickness(-14, grdHeaders.Margin.Top, 0, 0);
            }
        }
        #endregion

        #region Add Row Type 03
        private void addRowType03()
        {
            rowId = rowId + 1;
            Label myLabel01 = new Label();
            TextBox r3First = new TextBox();

            Button Row3myDinamicButton01 = new Button();
            Button btnDown = new Button();
            Button btnUp = new Button();
            //Button with image arrow down
            Image imgDown = new Image();
            BitmapImage biDown = new BitmapImage();
            biDown.BeginInit();
            biDown.UriSource = new Uri("images/icons/arrDown.png", UriKind.Relative);
            biDown.EndInit();
            imgDown.Source = biDown;
            imgDown.Width = 13;
            imgDown.Height = 13;
            imgDown.Stretch = Stretch.Fill;
            btnDown.Content = imgDown;
            //Button with image arrow up
            Image imgUp = new Image();
            BitmapImage biUp = new BitmapImage();
            biUp.BeginInit();
            biUp.UriSource = new Uri("images/icons/arrUp.png", UriKind.Relative);
            biUp.EndInit();
            imgUp.Source = biUp;
            imgUp.Width = 13;
            imgUp.Height = 13;
            imgUp.Stretch = Stretch.Fill;
            btnUp.Content = imgUp;
            //Button with image close
            Image imgClose = new Image();
            BitmapImage biClose = new BitmapImage();
            biClose.BeginInit();
            biClose.UriSource = new Uri("images/icons/btnClose.png", UriKind.Relative);
            biClose.EndInit();
            imgClose.Source = biClose;
            imgClose.Width = 13;
            imgClose.Height = 13;
            imgClose.Stretch = Stretch.Fill;
            Row3myDinamicButton01.Content = imgClose;

            myLabel01.Width = 30;
            myLabel01.Height = 25;
            r3First.Width = 980;
            r3First.Height = 28;
            Row3myDinamicButton01.Width = 70;
            Row3myDinamicButton01.Height = 25;
            btnDown.Width = 30;
            btnDown.Height = 25;
            btnUp.Width = 30;
            btnUp.Height = 25;
            r3First.HorizontalContentAlignment = HorizontalAlignment.Center;
            r3First.VerticalContentAlignment = VerticalAlignment.Center;

            myLabel01.HorizontalAlignment = HorizontalAlignment.Left;
            myLabel01.VerticalAlignment = VerticalAlignment.Top;
            r3First.HorizontalAlignment = HorizontalAlignment.Left;
            r3First.VerticalAlignment = VerticalAlignment.Top;
            Row3myDinamicButton01.HorizontalAlignment = HorizontalAlignment.Left;
            Row3myDinamicButton01.VerticalAlignment = VerticalAlignment.Top;
            btnDown.HorizontalAlignment = HorizontalAlignment.Left;
            btnDown.VerticalAlignment = VerticalAlignment.Top;
            btnUp.HorizontalAlignment = HorizontalAlignment.Left;
            btnUp.VerticalAlignment = VerticalAlignment.Top;

            myLabel01.Margin = new Thickness(5, vertRowPosition, 0, 0);
            r3First.Margin = new Thickness(30, vertRowPosition, 0, 0);
            Row3myDinamicButton01.Margin = new Thickness(1110, vertRowPosition, 0, 0);
            btnDown.Margin = new Thickness(1190, vertRowPosition, 0, 0);
            btnUp.Margin = new Thickness(1230, vertRowPosition, 0, 0);

            myLabel01.Name = "rd_" + rowId;
            this.RegisterName("rd_" + rowId, myLabel01);
            myLabel01.Foreground = Brushes.Blue;
            myLabel01.FontWeight = FontWeights.Bold;
            r3First.Name = "r3First_" + rowId;
            this.RegisterName("r3First_" + rowId, r3First);
            Row3myDinamicButton01.Name = "row3Btn_" + rowId;
            this.RegisterName("row3Btn_" + rowId, Row3myDinamicButton01);
            btnDown.Click += btnDown_Click;
            btnDown.Name = "btnDown_" + rowId;
            this.RegisterName("btnDown_" + rowId, btnDown);
            btnUp.Click += btnUp_Click;
            btnUp.Name = "btnUp_" + rowId;
            this.RegisterName("btnUp_" + rowId, btnUp);

            lastRowId = lastRowId + 1;
            if (lastRowId != 0) { myLabel01.Content = lastRowId; } else { myLabel01.Content = rowId; }

            Row3myDinamicButton01.Click += Row3myDinamicButton01_Click;

            grid01.Children.Add(myLabel01);
            grid01.Children.Add(r3First);
            grid01.Children.Add(Row3myDinamicButton01);
            grid01.Children.Add(btnDown);
            grid01.Children.Add(btnUp);

            vertRowPosition = vertRowPosition + 30;
            scr01.ScrollToBottom();
            if (lastRowId > 6)
            {
                if (grdHeaders.Margin.Left == 0)
                    grdHeaders.Margin = new Thickness(-14, grdHeaders.Margin.Top, 0, 0);
            }
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
            ComboBox Cell12 = (ComboBox)this.FindName("gehr_" + btnIndex);
            ComboBox Cell13 = (ComboBox)this.FindName("einh_" + btnIndex);
            TextBox Cell14 = (TextBox)this.FindName("men_" + btnIndex);
            TextBox Cell15 = (TextBox)this.FindName("einz_" + btnIndex);
            TextBox Cell16 = (TextBox)this.FindName("stk_" + btnIndex);
            TextBox Cell17 = (TextBox)this.FindName("gpreis_" + btnIndex);
            TextBox Cell18 = (TextBox)this.FindName("rab_" + btnIndex);
            CheckBox Cell19 = (CheckBox)this.FindName("akonto_" + btnIndex);

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
            Cell12.UnregisterName(Cell12.Name);
            Cell13.UnregisterName(Cell13.Name);
            Cell14.UnregisterName(Cell14.Name);
            Cell15.UnregisterName(Cell15.Name);
            Cell16.UnregisterName(Cell16.Name);
            Cell17.UnregisterName(Cell17.Name);
            Cell18.UnregisterName(Cell18.Name);
            Cell19.UnregisterName(Cell19.Name);
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
            grid01.Children.Remove(Cell12);
            grid01.Children.Remove(Cell13);
            grid01.Children.Remove(Cell14);
            grid01.Children.Remove(Cell15);
            grid01.Children.Remove(Cell16);
            grid01.Children.Remove(Cell17);
            grid01.Children.Remove(Cell18);
            grid01.Children.Remove(Cell19);


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
                        ComboBox Type01Cell0012 = (ComboBox)this.FindName("gehr_" + rID);
                        ComboBox Type01Cell0013 = (ComboBox)this.FindName("einh_" + rID);
                        TextBox Type01Cell0014 = (TextBox)this.FindName("men_" + rID);
                        TextBox Type01Cell0015 = (TextBox)this.FindName("einz_" + rID);
                        TextBox Type01Cell0016 = (TextBox)this.FindName("stk_" + rID);
                        TextBox Type01Cell0017 = (TextBox)this.FindName("gpreis_" + rID);
                        TextBox Type01Cell0018 = (TextBox)this.FindName("rab_" + rID);
                        CheckBox Type01Cell0019 = (CheckBox)this.FindName("akonto_" + rID);

                        //Row type 02
                        TextBox Type02Cell001 = (TextBox)this.FindName("row2txtBox_" + rID);
                        Button Type02Cell002 = (Button)this.FindName("row2Btn_" + rID);
                        ComboBox Type02Cell003 = (ComboBox)this.FindName("r2First_" + rID);
                        ComboBox Type02Cell004 = (ComboBox)this.FindName("r2Second_" + rID);
                        TextBox Type02Cell005 = (TextBox)this.FindName("r2brei_" + rID);
                        TextBox Type02Cell006 = (TextBox)this.FindName("r2lng_" + rID);
                        TextBox Type02Cell007 = (TextBox)this.FindName("r2einh_" + rID);
                        TextBox Type02Cell008 = (TextBox)this.FindName("r2men_" + rID);
                        TextBox Type02Cell009 = (TextBox)this.FindName("r2einz_" + rID);
                        TextBox Type02Cell010 = (TextBox)this.FindName("r2stk_" + rID);
                        TextBox Type02Cell011 = (TextBox)this.FindName("r2gpreis_" + rID);
                        TextBox Type02Cell012 = (TextBox)this.FindName("r2rab_" + rID);
                        CheckBox Type02Cell013 = (CheckBox)this.FindName("r2akonto_" + rID);
                        //Row type 03
                        TextBox Type03Cell01 = (TextBox)this.FindName("r3First_" + rID);
                        Button Type03Cell02 = (Button)this.FindName("row3Btn_" + rID);
                        if (Type01Cell001 != null)
                        {
                            //For row type 01
                            var currentTopPosition = Type01Cell001.Margin.Top;
                            var newTopPosition = currentTopPosition - 30;
                            int lblValue = Convert.ToInt32(Type01Cell004.Content);
                            Type01Cell001.Margin = new Thickness(730, newTopPosition, 0, 0);
                            Type01Cell002.Margin = new Thickness(680, newTopPosition, 0, 0);
                            Type01Cell003.Margin = new Thickness(1110, newTopPosition, 0, 0);
                            Type01Cell004.Content = lblValue - 1;
                            Type01Cell004.Margin = new Thickness(5, newTopPosition, 0, 0);
                            Type01Cell005.Margin = new Thickness(1190, newTopPosition, 0, 0);
                            Type01Cell006.Margin = new Thickness(1230, newTopPosition, 0, 0);
                            Type01Cell007.Margin = new Thickness(30, newTopPosition, 0, 0);
                            Type01Cell008.Margin = new Thickness(120, newTopPosition, 0, 0);
                            Type01Cell009.Margin = new Thickness(210, newTopPosition, 0, 0);
                            Type01Cell0010.Margin = new Thickness(300, newTopPosition, 0, 0);
                            Type01Cell0011.Margin = new Thickness(390, newTopPosition, 0, 0);
                            Type01Cell0012.Margin = new Thickness(500, newTopPosition, 0, 0);
                            Type01Cell0013.Margin = new Thickness(590, newTopPosition, 0, 0);
                            Type01Cell0014.Margin = new Thickness(780, newTopPosition, 0, 0);
                            Type01Cell0015.Margin = new Thickness(830, newTopPosition, 0, 0);
                            Type01Cell0016.Margin = new Thickness(900, newTopPosition, 0, 0);
                            Type01Cell0017.Margin = new Thickness(950, newTopPosition, 0, 0);
                            Type01Cell0018.Margin = new Thickness(1020, newTopPosition, 0, 0);
                            Type01Cell0019.Margin = new Thickness(1075, newTopPosition + 5, 0, 0);
                        }
                        else if (Type02Cell001 != null)
                        {
                            //For row type 02
                            var currentTopPosition = Type02Cell001.Margin.Top;
                            var newTopPosition = currentTopPosition - 30;
                            int lblValue = Convert.ToInt32(Type01Cell004.Content);

                            Type02Cell001.Margin = new Thickness(30, newTopPosition, 0, 0);
                            Type02Cell002.Margin = new Thickness(1110, newTopPosition, 0, 0);
                            Type01Cell004.Content = lblValue - 1;
                            Type01Cell004.Margin = new Thickness(5, newTopPosition, 0, 0);
                            Type01Cell005.Margin = new Thickness(1190, newTopPosition, 0, 0);
                            Type01Cell006.Margin = new Thickness(1230, newTopPosition, 0, 0);
                            Type02Cell003.Margin = new Thickness(30, newTopPosition, 0, 0);
                            Type02Cell004.Margin = new Thickness(120, newTopPosition, 0, 0);
                            Type02Cell005.Margin = new Thickness(730, newTopPosition, 0, 0);
                            Type02Cell006.Margin = new Thickness(680, newTopPosition, 0, 0);
                            Type02Cell007.Margin = new Thickness(590, newTopPosition, 0, 0);
                            Type02Cell008.Margin = new Thickness(780, newTopPosition, 0, 0);
                            Type02Cell009.Margin = new Thickness(830, newTopPosition, 0, 0);
                            Type02Cell010.Margin = new Thickness(900, newTopPosition, 0, 0);
                            Type02Cell011.Margin = new Thickness(950, newTopPosition, 0, 0);
                            Type02Cell012.Margin = new Thickness(1020, newTopPosition, 0, 0);
                            Type02Cell013.Margin = new Thickness(1075, newTopPosition + 5, 0, 0);
                        }
                        //For row type 03
                        else if (Type03Cell01 != null)
                        {
                            var currentTopPosition = Type03Cell01.Margin.Top;
                            var newTopPosition = currentTopPosition - 30;
                            int lblValue = Convert.ToInt32(Type01Cell004.Content);
                            Type01Cell004.Content = lblValue - 1;
                            Type01Cell004.Margin = new Thickness(5, newTopPosition, 0, 0);
                            Type03Cell01.Margin = new Thickness(30, newTopPosition, 0, 0);
                            Type03Cell02.Margin = new Thickness(1110, newTopPosition, 0, 0);
                            Type01Cell005.Margin = new Thickness(1190, newTopPosition, 0, 0);
                            Type01Cell006.Margin = new Thickness(1230, newTopPosition, 0, 0);
                        }
                    }
                }
            }
            vertRowPosition = vertRowPosition - 30;
            lastRowId = lastRowId - 1;

            if (lastRowId < 7)
            {
                if (grdHeaders.Margin.Left == -14)
                    grdHeaders.Margin = new Thickness(0, grdHeaders.Margin.Top, 0, 0);
            }
            preracunavanje();
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
            ComboBox Cell07 = (ComboBox)this.FindName("r2First_" + btnIndex);
            ComboBox Cell08 = (ComboBox)this.FindName("r2Second_" + btnIndex);
            TextBox Cell09 = (TextBox)this.FindName("r2brei_" + btnIndex);
            TextBox Cell10 = (TextBox)this.FindName("r2lng_" + btnIndex);
            TextBox Cell11 = (TextBox)this.FindName("r2einh_" + btnIndex);
            TextBox Cell12 = (TextBox)this.FindName("r2men_" + btnIndex);
            TextBox Cell13 = (TextBox)this.FindName("r2einz_" + btnIndex);
            TextBox Cell14 = (TextBox)this.FindName("r2stk_" + btnIndex);
            TextBox Cell15 = (TextBox)this.FindName("r2gpreis_" + btnIndex);
            TextBox Cell16 = (TextBox)this.FindName("r2rab_" + btnIndex);
            CheckBox Cell17 = (CheckBox)this.FindName("r2akonto_" + btnIndex);

            grid01.UnregisterName(Cell01.Name);
            grid01.UnregisterName(Cell03.Name);
            grid01.UnregisterName(Cell04.Name);
            grid01.UnregisterName(Cell05.Name);
            grid01.UnregisterName(Cell06.Name);
            grid01.UnregisterName(Cell07.Name);
            grid01.UnregisterName(Cell08.Name);
            grid01.UnregisterName(Cell09.Name);
            grid01.UnregisterName(Cell10.Name);
            grid01.UnregisterName(Cell11.Name);
            grid01.UnregisterName(Cell12.Name);
            grid01.UnregisterName(Cell13.Name);
            grid01.UnregisterName(Cell14.Name);
            grid01.UnregisterName(Cell15.Name);
            grid01.UnregisterName(Cell16.Name);
            grid01.UnregisterName(Cell17.Name);

            grid01.Children.Remove(Cell01);
            grid01.Children.Remove(Cell03);
            grid01.Children.Remove(Cell04);
            grid01.Children.Remove(Cell05);
            grid01.Children.Remove(Cell06);
            grid01.Children.Remove(Cell07);
            grid01.Children.Remove(Cell08);
            grid01.Children.Remove(Cell09);
            grid01.Children.Remove(Cell10);
            grid01.Children.Remove(Cell11);
            grid01.Children.Remove(Cell12);
            grid01.Children.Remove(Cell13);
            grid01.Children.Remove(Cell14);
            grid01.Children.Remove(Cell15);
            grid01.Children.Remove(Cell16);
            grid01.Children.Remove(Cell17);

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
                        ComboBox Type01Cell0012 = (ComboBox)this.FindName("gehr_" + rID);
                        ComboBox Type01Cell0013 = (ComboBox)this.FindName("einh_" + rID);
                        TextBox Type01Cell0014 = (TextBox)this.FindName("men_" + rID);
                        TextBox Type01Cell0015 = (TextBox)this.FindName("einz_" + rID);
                        TextBox Type01Cell0016 = (TextBox)this.FindName("stk_" + rID);
                        TextBox Type01Cell0017 = (TextBox)this.FindName("gpreis_" + rID);
                        TextBox Type01Cell0018 = (TextBox)this.FindName("rab_" + rID);
                        CheckBox Type01Cell0019 = (CheckBox)this.FindName("akonto_" + rID);
                        //Row type 02
                        TextBox Type02Cell001 = (TextBox)this.FindName("row2txtBox_" + rID);
                        Button Type02Cell002 = (Button)this.FindName("row2Btn_" + rID);
                        ComboBox Type02Cell003 = (ComboBox)this.FindName("r2First_" + rID);
                        ComboBox Type02Cell004 = (ComboBox)this.FindName("r2Second_" + rID);
                        TextBox Type02Cell005 = (TextBox)this.FindName("r2brei_" + rID);
                        TextBox Type02Cell006 = (TextBox)this.FindName("r2lng_" + rID);
                        TextBox Type02Cell007 = (TextBox)this.FindName("r2einh_" + rID);
                        TextBox Type02Cell008 = (TextBox)this.FindName("r2men_" + rID);
                        TextBox Type02Cell009 = (TextBox)this.FindName("r2einz_" + rID);
                        TextBox Type02Cell010 = (TextBox)this.FindName("r2stk_" + rID);
                        TextBox Type02Cell011 = (TextBox)this.FindName("r2gpreis_" + rID);
                        TextBox Type02Cell012 = (TextBox)this.FindName("r2rab_" + rID);
                        CheckBox Type02Cell013 = (CheckBox)this.FindName("r2akonto_" + rID);
                        //Row type 03
                        TextBox Type03Cell01 = (TextBox)this.FindName("r3First_" + rID);
                        Button Type03Cell02 = (Button)this.FindName("row3Btn_" + rID);
                        if (Type01Cell001 != null)
                        {
                            //For row type 01
                            var currentTopPosition = Type01Cell001.Margin.Top;
                            var newTopPosition = currentTopPosition - 30;
                            int lblValue = Convert.ToInt32(Type01Cell004.Content);
                            Type01Cell001.Margin = new Thickness(730, newTopPosition, 0, 0);
                            Type01Cell002.Margin = new Thickness(680, newTopPosition, 0, 0);
                            Type01Cell003.Margin = new Thickness(1110, newTopPosition, 0, 0);
                            Type01Cell004.Content = lblValue - 1;
                            Type01Cell004.Margin = new Thickness(5, newTopPosition, 0, 0);
                            Type01Cell005.Margin = new Thickness(1190, newTopPosition, 0, 0);
                            Type01Cell006.Margin = new Thickness(1230, newTopPosition, 0, 0);
                            Type01Cell007.Margin = new Thickness(30, newTopPosition, 0, 0);
                            Type01Cell008.Margin = new Thickness(120, newTopPosition, 0, 0);
                            Type01Cell009.Margin = new Thickness(210, newTopPosition, 0, 0);
                            Type01Cell0010.Margin = new Thickness(300, newTopPosition, 0, 0);
                            Type01Cell0011.Margin = new Thickness(390, newTopPosition, 0, 0);
                            Type01Cell0012.Margin = new Thickness(500, newTopPosition, 0, 0);
                            Type01Cell0013.Margin = new Thickness(590, newTopPosition, 0, 0);
                            Type01Cell0014.Margin = new Thickness(780, newTopPosition, 0, 0);
                            Type01Cell0015.Margin = new Thickness(830, newTopPosition, 0, 0);
                            Type01Cell0016.Margin = new Thickness(900, newTopPosition, 0, 0);
                            Type01Cell0017.Margin = new Thickness(950, newTopPosition, 0, 0);
                            Type01Cell0018.Margin = new Thickness(1020, newTopPosition, 0, 0);
                            Type01Cell0019.Margin = new Thickness(1075, newTopPosition + 5, 0, 0);
                        }
                        else if (Type02Cell001 != null)
                        {
                            //For row type 02
                            var currentTopPosition = Type02Cell001.Margin.Top;
                            var newTopPosition = currentTopPosition - 30;
                            int lblValue = Convert.ToInt32(Type01Cell004.Content);
                            Type02Cell001.Margin = new Thickness(30, newTopPosition, 0, 0);
                            Type02Cell002.Margin = new Thickness(1110, newTopPosition, 0, 0);
                            Type01Cell004.Content = lblValue - 1;
                            Type01Cell004.Margin = new Thickness(5, newTopPosition, 0, 0);
                            Type01Cell005.Margin = new Thickness(1190, newTopPosition, 0, 0);
                            Type01Cell006.Margin = new Thickness(1230, newTopPosition, 0, 0);
                            Type02Cell003.Margin = new Thickness(30, newTopPosition, 0, 0);
                            Type02Cell004.Margin = new Thickness(120, newTopPosition, 0, 0);
                            Type02Cell005.Margin = new Thickness(730, newTopPosition, 0, 0);
                            Type02Cell006.Margin = new Thickness(680, newTopPosition, 0, 0);
                            Type02Cell007.Margin = new Thickness(590, newTopPosition, 0, 0);
                            Type02Cell008.Margin = new Thickness(780, newTopPosition, 0, 0);
                            Type02Cell009.Margin = new Thickness(830, newTopPosition, 0, 0);
                            Type02Cell010.Margin = new Thickness(900, newTopPosition, 0, 0);
                            Type02Cell011.Margin = new Thickness(950, newTopPosition, 0, 0);
                            Type02Cell012.Margin = new Thickness(1020, newTopPosition, 0, 0);
                            Type02Cell013.Margin = new Thickness(1075, newTopPosition + 5, 0, 0);
                        }
                        //For row type 03
                        else if (Type03Cell01 != null)
                        {
                            var currentTopPosition = Type03Cell01.Margin.Top;
                            var newTopPosition = currentTopPosition - 30;
                            int lblValue = Convert.ToInt32(Type01Cell004.Content);
                            Type01Cell004.Content = lblValue - 1;
                            Type01Cell004.Margin = new Thickness(5, newTopPosition, 0, 0);
                            Type03Cell01.Margin = new Thickness(30, newTopPosition, 0, 0);
                            Type03Cell02.Margin = new Thickness(1110, newTopPosition, 0, 0);
                            Type01Cell005.Margin = new Thickness(1190, newTopPosition, 0, 0);
                            Type01Cell006.Margin = new Thickness(1230, newTopPosition, 0, 0);
                        }
                    }
                }
            }
            vertRowPosition = vertRowPosition - 30;
            lastRowId = lastRowId - 1;
            if (lastRowId < 7)
            {
                if (grdHeaders.Margin.Left == -14)
                    grdHeaders.Margin = new Thickness(0, grdHeaders.Margin.Top, 0, 0);
            }
            preracunavanje();
        }
        #endregion

        #region Delete Row Type 03
        private void Row3myDinamicButton01_Click(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;
            int btnIndex = Convert.ToInt32(btn.Name.Split('_').Last());
            TextBox Cell01 = (TextBox)this.FindName("r3First_" + btnIndex);
            Button Cell02 = (Button)this.FindName("row3Btn_" + btnIndex);
            Label Cell03 = (Label)this.FindName("rd_" + btnIndex);
            Button Cell04 = (Button)this.FindName("btnDown_" + btnIndex);
            Button Cell05 = (Button)this.FindName("btnUp_" + btnIndex);

            grid01.UnregisterName(Cell01.Name);
            grid01.UnregisterName(Cell02.Name);
            grid01.UnregisterName(Cell03.Name);
            grid01.UnregisterName(Cell04.Name);
            grid01.UnregisterName(Cell05.Name);

            grid01.Children.Remove(Cell01);
            grid01.Children.Remove(Cell02);
            grid01.Children.Remove(Cell03);
            grid01.Children.Remove(Cell04);
            grid01.Children.Remove(Cell05);

            for (int i = 0; i <= rowId; i++)
            {
                Label Cell000 = (Label)this.FindName("rd_" + i);
                if (Cell000 != null)
                {
                    if (Convert.ToInt32(Cell03.Content) < Convert.ToInt32(Cell000.Content))
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
                        ComboBox Type01Cell0012 = (ComboBox)this.FindName("gehr_" + rID);
                        ComboBox Type01Cell0013 = (ComboBox)this.FindName("einh_" + rID);
                        TextBox Type01Cell0014 = (TextBox)this.FindName("men_" + rID);
                        TextBox Type01Cell0015 = (TextBox)this.FindName("einz_" + rID);
                        TextBox Type01Cell0016 = (TextBox)this.FindName("stk_" + rID);
                        TextBox Type01Cell0017 = (TextBox)this.FindName("gpreis_" + rID);
                        TextBox Type01Cell0018 = (TextBox)this.FindName("rab_" + rID);
                        CheckBox Type01Cell0019 = (CheckBox)this.FindName("akonto_" + rID);
                        //Row type 02
                        TextBox Type02Cell001 = (TextBox)this.FindName("row2txtBox_" + rID);
                        Button Type02Cell002 = (Button)this.FindName("row2Btn_" + rID);
                        ComboBox Type02Cell003 = (ComboBox)this.FindName("r2First_" + rID);
                        ComboBox Type02Cell004 = (ComboBox)this.FindName("r2Second_" + rID);
                        TextBox Type02Cell005 = (TextBox)this.FindName("r2brei_" + rID);
                        TextBox Type02Cell006 = (TextBox)this.FindName("r2lng_" + rID);
                        TextBox Type02Cell007 = (TextBox)this.FindName("r2einh_" + rID);
                        TextBox Type02Cell008 = (TextBox)this.FindName("r2men_" + rID);
                        TextBox Type02Cell009 = (TextBox)this.FindName("r2einz_" + rID);
                        TextBox Type02Cell010 = (TextBox)this.FindName("r2stk_" + rID);
                        TextBox Type02Cell011 = (TextBox)this.FindName("r2gpreis_" + rID);
                        TextBox Type02Cell012 = (TextBox)this.FindName("r2rab_" + rID);
                        CheckBox Type02Cell013 = (CheckBox)this.FindName("r2akonto_" + rID);
                        //Row type 03
                        TextBox Type03Cell01 = (TextBox)this.FindName("r3First_" + rID);
                        Button Type03Cell02 = (Button)this.FindName("row3Btn_" + rID);

                        if (Type01Cell001 != null)
                        {
                            //For row type 01
                            var currentTopPosition = Type01Cell001.Margin.Top;
                            var newTopPosition = currentTopPosition - 30;
                            int lblValue = Convert.ToInt32(Type01Cell004.Content);
                            Type01Cell001.Margin = new Thickness(730, newTopPosition, 0, 0);
                            Type01Cell002.Margin = new Thickness(680, newTopPosition, 0, 0);
                            Type01Cell003.Margin = new Thickness(1110, newTopPosition, 0, 0);
                            Type01Cell004.Content = lblValue - 1;
                            Type01Cell004.Margin = new Thickness(5, newTopPosition, 0, 0);
                            Type01Cell005.Margin = new Thickness(1190, newTopPosition, 0, 0);
                            Type01Cell006.Margin = new Thickness(1230, newTopPosition, 0, 0);
                            Type01Cell007.Margin = new Thickness(30, newTopPosition, 0, 0);
                            Type01Cell008.Margin = new Thickness(120, newTopPosition, 0, 0);
                            Type01Cell009.Margin = new Thickness(210, newTopPosition, 0, 0);
                            Type01Cell0010.Margin = new Thickness(300, newTopPosition, 0, 0);
                            Type01Cell0011.Margin = new Thickness(390, newTopPosition, 0, 0);
                            Type01Cell0012.Margin = new Thickness(500, newTopPosition, 0, 0);
                            Type01Cell0013.Margin = new Thickness(590, newTopPosition, 0, 0);
                            Type01Cell0014.Margin = new Thickness(780, newTopPosition, 0, 0);
                            Type01Cell0015.Margin = new Thickness(830, newTopPosition, 0, 0);
                            Type01Cell0016.Margin = new Thickness(900, newTopPosition, 0, 0);
                            Type01Cell0017.Margin = new Thickness(950, newTopPosition, 0, 0);
                            Type01Cell0018.Margin = new Thickness(1020, newTopPosition, 0, 0);
                            Type01Cell0019.Margin = new Thickness(1075, newTopPosition + 5, 0, 0);
                        }
                        else if (Type02Cell001 != null)
                        {
                            //For row type 02
                            var currentTopPosition = Type02Cell001.Margin.Top;
                            var newTopPosition = currentTopPosition - 30;
                            int lblValue = Convert.ToInt32(Type01Cell004.Content);
                            Type02Cell001.Margin = new Thickness(30, newTopPosition, 0, 0);
                            Type02Cell002.Margin = new Thickness(1110, newTopPosition, 0, 0);
                            Type01Cell004.Content = lblValue - 1;
                            Type01Cell004.Margin = new Thickness(5, newTopPosition, 0, 0);
                            Type01Cell005.Margin = new Thickness(1190, newTopPosition, 0, 0);
                            Type01Cell006.Margin = new Thickness(1230, newTopPosition, 0, 0);
                            Type02Cell003.Margin = new Thickness(30, newTopPosition, 0, 0);
                            Type02Cell004.Margin = new Thickness(120, newTopPosition, 0, 0);
                            Type02Cell005.Margin = new Thickness(730, newTopPosition, 0, 0);
                            Type02Cell006.Margin = new Thickness(680, newTopPosition, 0, 0);
                            Type02Cell007.Margin = new Thickness(590, newTopPosition, 0, 0);
                            Type02Cell008.Margin = new Thickness(780, newTopPosition, 0, 0);
                            Type02Cell009.Margin = new Thickness(830, newTopPosition, 0, 0);
                            Type02Cell010.Margin = new Thickness(900, newTopPosition, 0, 0);
                            Type02Cell011.Margin = new Thickness(950, newTopPosition, 0, 0);
                            Type02Cell012.Margin = new Thickness(1020, newTopPosition, 0, 0);
                            Type02Cell013.Margin = new Thickness(1075, newTopPosition + 5, 0, 0);
                        }
                        //For row type 03
                        else if (Type03Cell01 != null)
                        {
                            var currentTopPosition = Type03Cell01.Margin.Top;
                            var newTopPosition = currentTopPosition - 30;
                            int lblValue = Convert.ToInt32(Type01Cell004.Content);
                            Type01Cell004.Content = lblValue - 1;
                            Type01Cell004.Margin = new Thickness(5, newTopPosition, 0, 0);
                            Type03Cell01.Margin = new Thickness(30, newTopPosition, 0, 0);
                            Type03Cell02.Margin = new Thickness(1110, newTopPosition, 0, 0);
                            Type01Cell005.Margin = new Thickness(1190, newTopPosition, 0, 0);
                            Type01Cell006.Margin = new Thickness(1230, newTopPosition, 0, 0);
                        }
                    }
                }
            }
            vertRowPosition = vertRowPosition - 30;
            lastRowId = lastRowId - 1;
            if (lastRowId < 7)
            {
                if (grdHeaders.Margin.Left == -14)
                    grdHeaders.Margin = new Thickness(0, grdHeaders.Margin.Top, 0, 0);
            }
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
            ComboBox Type01Cell0012 = (ComboBox)this.FindName("gehr_" + btnIndex);
            ComboBox Type01Cell0013 = (ComboBox)this.FindName("einh_" + btnIndex);
            TextBox Type01Cell0014 = (TextBox)this.FindName("men_" + btnIndex);
            TextBox Type01Cell0015 = (TextBox)this.FindName("einz_" + btnIndex);
            TextBox Type01Cell0016 = (TextBox)this.FindName("stk_" + btnIndex);
            TextBox Type01Cell0017 = (TextBox)this.FindName("gpreis_" + btnIndex);
            TextBox Type01Cell0018 = (TextBox)this.FindName("rab_" + btnIndex);
            CheckBox Type01Cell0019 = (CheckBox)this.FindName("akonto_" + btnIndex);

            TextBox Type02Cell001 = (TextBox)this.FindName("row2txtBox_" + btnIndex);
            Button Type02Cell002 = (Button)this.FindName("row2Btn_" + btnIndex);
            ComboBox Type02Cell003 = (ComboBox)this.FindName("r2First_" + btnIndex);
            ComboBox Type02Cell004 = (ComboBox)this.FindName("r2Second_" + btnIndex);
            TextBox Type02Cell005 = (TextBox)this.FindName("r2brei_" + btnIndex);
            TextBox Type02Cell006 = (TextBox)this.FindName("r2lng_" + btnIndex);
            TextBox Type02Cell007 = (TextBox)this.FindName("r2einh_" + btnIndex);
            TextBox Type02Cell008 = (TextBox)this.FindName("r2men_" + btnIndex);
            TextBox Type02Cell009 = (TextBox)this.FindName("r2einz_" + btnIndex);
            TextBox Type02Cell010 = (TextBox)this.FindName("r2stk_" + btnIndex);
            TextBox Type02Cell011 = (TextBox)this.FindName("r2gpreis_" + btnIndex);
            TextBox Type02Cell012 = (TextBox)this.FindName("r2rab_" + btnIndex);
            CheckBox Type02Cell013 = (CheckBox)this.FindName("r2akonto_" + btnIndex);

            TextBox Type03Cell001 = (TextBox)this.FindName("r3First_" + btnIndex);
            Button Type03Cell002 = (Button)this.FindName("row3Btn_" + btnIndex);

            var rowMargin = btn.Margin.Top + 30;
            for (int i = 0; i <= rowId; i++)
            {
                TextBox rowNumType01 = (TextBox)this.FindName("txtBoxPrva_" + i);
                TextBox rowNumType02 = (TextBox)this.FindName("row2txtBox_" + i);
                TextBox rowNumType03 = (TextBox)this.FindName("r3First_" + i);
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
                else if (rowNumType03 != null)
                {
                    var curRowMargin03 = rowNumType03.Margin.Top;
                    if (curRowMargin03 == rowMargin)
                    {
                        btnIndexBelow = Convert.ToInt32(rowNumType03.Name.Split('_').Last());
                        tipReda = 3;
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
            ComboBox Type01Cell0012Below = (ComboBox)this.FindName("gehr_" + btnIndexBelow);
            ComboBox Type01Cell0013Below = (ComboBox)this.FindName("einh_" + btnIndexBelow);
            TextBox Type01Cell0014Below = (TextBox)this.FindName("men_" + btnIndexBelow);
            TextBox Type01Cell0015Below = (TextBox)this.FindName("einz_" + btnIndexBelow);
            TextBox Type01Cell0016Below = (TextBox)this.FindName("stk_" + btnIndexBelow);
            TextBox Type01Cell0017Below = (TextBox)this.FindName("gpreis_" + btnIndexBelow);
            TextBox Type01Cell0018Below = (TextBox)this.FindName("rab_" + btnIndexBelow);
            CheckBox Type01Cell0019Below = (CheckBox)this.FindName("akonto_" + btnIndexBelow);
            //Row type 2
            TextBox Type02Cell001btnIndexBelow = (TextBox)this.FindName("row2txtBox_" + btnIndexBelow);
            Button Type02Cell002btnIndexBelow = (Button)this.FindName("row2Btn_" + btnIndexBelow);
            ComboBox Type02Cell003btnIndexBelow = (ComboBox)this.FindName("r2First_" + btnIndexBelow);
            ComboBox Type02Cell004btnIndexBelow = (ComboBox)this.FindName("r2Second_" + btnIndexBelow);
            TextBox Type02Cell005btnIndexBelow = (TextBox)this.FindName("r2brei_" + btnIndexBelow);
            TextBox Type02Cell006btnIndexBelow = (TextBox)this.FindName("r2lng_" + btnIndexBelow);
            TextBox Type02Cell007btnIndexBelow = (TextBox)this.FindName("r2einh_" + btnIndexBelow);
            TextBox Type02Cell008btnIndexBelow = (TextBox)this.FindName("r2men_" + btnIndexBelow);
            TextBox Type02Cell009btnIndexBelow = (TextBox)this.FindName("r2einz_" + btnIndexBelow);
            TextBox Type02Cell0010btnIndexBelow = (TextBox)this.FindName("r2stk_" + btnIndexBelow);
            TextBox Type02Cell0011btnIndexBelow = (TextBox)this.FindName("r2gpreis_" + btnIndexBelow);
            TextBox Type02Cell0012btnIndexBelow = (TextBox)this.FindName("r2rab_" + btnIndexBelow);
            CheckBox Type02Cell0013btnIndexBelow = (CheckBox)this.FindName("r2akonto_" + btnIndexBelow);
            //Row type 3
            TextBox Type03Cell001btnIndexBelow = (TextBox)this.FindName("r3First_" + btnIndexBelow);
            Button Type03Cell002btnIndexBelow = (Button)this.FindName("row3Btn_" + btnIndexBelow);

            if (Type01Cell001 != null)
            {
                var currentTopPosition = Type01Cell001.Margin.Top;
                var newTopPositionDown = currentTopPosition + 30;
                int lblValue = Convert.ToInt32(Type01Cell004.Content);
                Type01Cell001.Margin = new Thickness(730, newTopPositionDown, 0, 0);
                Type01Cell002.Margin = new Thickness(680, newTopPositionDown, 0, 0);
                Type01Cell003.Margin = new Thickness(1110, newTopPositionDown, 0, 0);
                Type01Cell004.Content = lblValue + 1;
                Type01Cell004.Margin = new Thickness(5, newTopPositionDown, 0, 0);
                Type01Cell005.Margin = new Thickness(1190, newTopPositionDown, 0, 0);
                Type01Cell006.Margin = new Thickness(1230, newTopPositionDown, 0, 0);
                Type01Cell007.Margin = new Thickness(30, newTopPositionDown, 0, 0);
                Type01Cell008.Margin = new Thickness(120, newTopPositionDown, 0, 0);
                Type01Cell009.Margin = new Thickness(210, newTopPositionDown, 0, 0);
                Type01Cell0010.Margin = new Thickness(300, newTopPositionDown, 0, 0);
                Type01Cell0011.Margin = new Thickness(390, newTopPositionDown, 0, 0);
                Type01Cell0012.Margin = new Thickness(500, newTopPositionDown, 0, 0);
                Type01Cell0013.Margin = new Thickness(590, newTopPositionDown, 0, 0);
                Type01Cell0014.Margin = new Thickness(780, newTopPositionDown, 0, 0);
                Type01Cell0015.Margin = new Thickness(830, newTopPositionDown, 0, 0);
                Type01Cell0016.Margin = new Thickness(900, newTopPositionDown, 0, 0);
                Type01Cell0017.Margin = new Thickness(950, newTopPositionDown, 0, 0);
                Type01Cell0018.Margin = new Thickness(1020, newTopPositionDown, 0, 0);
                Type01Cell0019.Margin = new Thickness(1075, newTopPositionDown + 5, 0, 0);
                if (tipReda == 1)
                {
                    var currentTopPositionBelow = Type01Cell001Below.Margin.Top;
                    var newTopPositionUp = currentTopPositionBelow - 30;
                    int lblValueBelow = Convert.ToInt32(Type01Cell004Below.Content);
                    Type01Cell001Below.Margin = new Thickness(730, newTopPositionUp, 0, 0);
                    Type01Cell002Below.Margin = new Thickness(680, newTopPositionUp, 0, 0);
                    Type01Cell003Below.Margin = new Thickness(1110, newTopPositionUp, 0, 0);
                    Type01Cell004Below.Content = lblValueBelow - 1;
                    Type01Cell004Below.Margin = new Thickness(5, newTopPositionUp, 0, 0);
                    Type01Cell005Below.Margin = new Thickness(1190, newTopPositionUp, 0, 0);
                    Type01Cell006Below.Margin = new Thickness(1230, newTopPositionUp, 0, 0);
                    Type01Cell007Below.Margin = new Thickness(30, newTopPositionUp, 0, 0);
                    Type01Cell008Below.Margin = new Thickness(120, newTopPositionUp, 0, 0);
                    Type01Cell009Below.Margin = new Thickness(210, newTopPositionUp, 0, 0);
                    Type01Cell0010Below.Margin = new Thickness(300, newTopPositionUp, 0, 0);
                    Type01Cell0011Below.Margin = new Thickness(390, newTopPositionUp, 0, 0);
                    Type01Cell0012Below.Margin = new Thickness(500, newTopPositionUp, 0, 0);
                    Type01Cell0013Below.Margin = new Thickness(590, newTopPositionUp, 0, 0);
                    Type01Cell0014Below.Margin = new Thickness(780, newTopPositionUp, 0, 0);
                    Type01Cell0015Below.Margin = new Thickness(830, newTopPositionUp, 0, 0);
                    Type01Cell0016Below.Margin = new Thickness(900, newTopPositionUp, 0, 0);
                    Type01Cell0017Below.Margin = new Thickness(950, newTopPositionUp, 0, 0);
                    Type01Cell0018Below.Margin = new Thickness(1020, newTopPositionUp, 0, 0);
                    Type01Cell0019Below.Margin = new Thickness(1075, newTopPositionUp + 5, 0, 0);
                }
                else if (tipReda == 2)
                {
                    var currentTopPositionBelow = Type02Cell001btnIndexBelow.Margin.Top;
                    var newTopPositionUp = currentTopPositionBelow - 30;
                    int lblValueBelow = Convert.ToInt32(Type01Cell004.Content);
                    Type02Cell001btnIndexBelow.Margin = new Thickness(30, newTopPositionUp, 0, 0);
                    Type02Cell002btnIndexBelow.Margin = new Thickness(1110, newTopPositionUp, 0, 0);
                    Type01Cell004Below.Content = lblValueBelow - 1;
                    Type01Cell004Below.Margin = new Thickness(5, newTopPositionUp, 0, 0);
                    Type01Cell005Below.Margin = new Thickness(1190, newTopPositionUp, 0, 0);
                    Type01Cell006Below.Margin = new Thickness(1230, newTopPositionUp, 0, 0);
                    Type02Cell003btnIndexBelow.Margin = new Thickness(30, newTopPositionUp, 0, 0);
                    Type02Cell004btnIndexBelow.Margin = new Thickness(120, newTopPositionUp, 0, 0);
                    Type02Cell005btnIndexBelow.Margin = new Thickness(730, newTopPositionUp, 0, 0);
                    Type02Cell006btnIndexBelow.Margin = new Thickness(680, newTopPositionUp, 0, 0);
                    Type02Cell007btnIndexBelow.Margin = new Thickness(590, newTopPositionUp, 0, 0);
                    Type02Cell008btnIndexBelow.Margin = new Thickness(780, newTopPositionUp, 0, 0);
                    Type02Cell009btnIndexBelow.Margin = new Thickness(830, newTopPositionUp, 0, 0);
                    Type02Cell0010btnIndexBelow.Margin = new Thickness(900, newTopPositionUp, 0, 0);
                    Type02Cell0011btnIndexBelow.Margin = new Thickness(950, newTopPositionUp, 0, 0);
                    Type02Cell0012btnIndexBelow.Margin = new Thickness(1020, newTopPositionUp, 0, 0);
                    Type02Cell0013btnIndexBelow.Margin = new Thickness(1075, newTopPositionUp + 5, 0, 0);
                }
                else if (tipReda == 3)
                {
                    var currentTopPositionBelow = Type03Cell001btnIndexBelow.Margin.Top;
                    var newTopPositionUp = currentTopPositionBelow - 30;
                    int lblValueBelow = Convert.ToInt32(Type01Cell004.Content);
                    Type01Cell004Below.Content = lblValueBelow - 1;
                    Type01Cell004Below.Margin = new Thickness(5, newTopPositionUp, 0, 0);
                    Type03Cell001btnIndexBelow.Margin = new Thickness(30, newTopPositionUp, 0, 0);
                    Type01Cell005Below.Margin = new Thickness(1190, newTopPositionUp, 0, 0);
                    Type01Cell006Below.Margin = new Thickness(1230, newTopPositionUp, 0, 0);
                    Type03Cell002btnIndexBelow.Margin = new Thickness(1110, newTopPositionUp, 0, 0);
                }
            }
            else if (Type02Cell001 != null)
            {
                var currentTopPosition = Type02Cell001.Margin.Top;
                var newTopPositionDown = currentTopPosition + 30;
                int lblValue = Convert.ToInt32(Type01Cell004.Content);
                Type02Cell001.Margin = new Thickness(30, newTopPositionDown, 0, 0);
                Type02Cell002.Margin = new Thickness(1110, newTopPositionDown, 0, 0);
                Type01Cell004.Content = lblValue + 1;
                Type01Cell004.Margin = new Thickness(5, newTopPositionDown, 0, 0);
                Type01Cell005.Margin = new Thickness(1190, newTopPositionDown, 0, 0);
                Type01Cell006.Margin = new Thickness(1230, newTopPositionDown, 0, 0);
                Type02Cell003.Margin = new Thickness(30, newTopPositionDown, 0, 0);
                Type02Cell004.Margin = new Thickness(120, newTopPositionDown, 0, 0);
                Type02Cell005.Margin = new Thickness(730, newTopPositionDown, 0, 0);
                Type02Cell006.Margin = new Thickness(680, newTopPositionDown, 0, 0);
                Type02Cell007.Margin = new Thickness(590, newTopPositionDown, 0, 0);
                Type02Cell008.Margin = new Thickness(780, newTopPositionDown, 0, 0);
                Type02Cell009.Margin = new Thickness(830, newTopPositionDown, 0, 0);
                Type02Cell010.Margin = new Thickness(900, newTopPositionDown, 0, 0);
                Type02Cell011.Margin = new Thickness(950, newTopPositionDown, 0, 0);
                Type02Cell012.Margin = new Thickness(1020, newTopPositionDown, 0, 0);
                Type02Cell013.Margin = new Thickness(1075, newTopPositionDown + 5, 0, 0);
                if (tipReda == 1)
                {
                    var currentTopPositionBelow = Type01Cell001Below.Margin.Top;
                    var newTopPositionUp = currentTopPositionBelow - 30;
                    int lblValueBelow = Convert.ToInt32(Type01Cell004Below.Content);
                    Type01Cell001Below.Margin = new Thickness(730, newTopPositionUp, 0, 0);
                    Type01Cell002Below.Margin = new Thickness(680, newTopPositionUp, 0, 0);
                    Type01Cell003Below.Margin = new Thickness(1110, newTopPositionUp, 0, 0);
                    Type01Cell004Below.Content = lblValueBelow - 1;
                    Type01Cell004Below.Margin = new Thickness(5, newTopPositionUp, 0, 0);
                    Type01Cell005Below.Margin = new Thickness(1190, newTopPositionUp, 0, 0);
                    Type01Cell006Below.Margin = new Thickness(1230, newTopPositionUp, 0, 0);
                    Type01Cell007Below.Margin = new Thickness(30, newTopPositionUp, 0, 0);
                    Type01Cell008Below.Margin = new Thickness(120, newTopPositionUp, 0, 0);
                    Type01Cell009Below.Margin = new Thickness(210, newTopPositionUp, 0, 0);
                    Type01Cell0010Below.Margin = new Thickness(300, newTopPositionUp, 0, 0);
                    Type01Cell0011Below.Margin = new Thickness(390, newTopPositionUp, 0, 0);
                    Type01Cell0012Below.Margin = new Thickness(500, newTopPositionUp, 0, 0);
                    Type01Cell0013Below.Margin = new Thickness(590, newTopPositionUp, 0, 0);
                    Type01Cell0014Below.Margin = new Thickness(780, newTopPositionUp, 0, 0);
                    Type01Cell0015Below.Margin = new Thickness(830, newTopPositionUp, 0, 0);
                    Type01Cell0016Below.Margin = new Thickness(900, newTopPositionUp, 0, 0);
                    Type01Cell0017Below.Margin = new Thickness(950, newTopPositionUp, 0, 0);
                    Type01Cell0018Below.Margin = new Thickness(1020, newTopPositionUp, 0, 0);
                    Type01Cell0019Below.Margin = new Thickness(1075, newTopPositionUp + 5, 0, 0);
                }
                else if (tipReda == 2)
                {
                    var currentTopPositionBelow = Type02Cell001btnIndexBelow.Margin.Top;
                    var newTopPositionUp = currentTopPositionBelow - 30;
                    int lblValueBelow = Convert.ToInt32(Type01Cell004.Content);
                    Type02Cell001btnIndexBelow.Margin = new Thickness(30, newTopPositionUp, 0, 0);
                    Type02Cell002btnIndexBelow.Margin = new Thickness(1110, newTopPositionUp, 0, 0);
                    Type01Cell004Below.Content = lblValueBelow - 1;
                    Type01Cell004Below.Margin = new Thickness(5, newTopPositionUp, 0, 0);
                    Type01Cell005Below.Margin = new Thickness(1190, newTopPositionUp, 0, 0);
                    Type01Cell006Below.Margin = new Thickness(1230, newTopPositionUp, 0, 0);
                    Type02Cell003btnIndexBelow.Margin = new Thickness(30, newTopPositionUp, 0, 0);
                    Type02Cell004btnIndexBelow.Margin = new Thickness(120, newTopPositionUp, 0, 0);
                    Type02Cell005btnIndexBelow.Margin = new Thickness(730, newTopPositionUp, 0, 0);
                    Type02Cell006btnIndexBelow.Margin = new Thickness(680, newTopPositionUp, 0, 0);
                    Type02Cell007btnIndexBelow.Margin = new Thickness(590, newTopPositionUp, 0, 0);
                    Type02Cell008btnIndexBelow.Margin = new Thickness(780, newTopPositionUp, 0, 0);
                    Type02Cell009btnIndexBelow.Margin = new Thickness(830, newTopPositionUp, 0, 0);
                    Type02Cell0010btnIndexBelow.Margin = new Thickness(900, newTopPositionUp, 0, 0);
                    Type02Cell0011btnIndexBelow.Margin = new Thickness(950, newTopPositionUp, 0, 0);
                    Type02Cell0012btnIndexBelow.Margin = new Thickness(1020, newTopPositionUp, 0, 0);
                    Type02Cell0013btnIndexBelow.Margin = new Thickness(1075, newTopPositionUp + 5, 0, 0);
                }
                else if (tipReda == 3)
                {
                    var currentTopPositionBelow = Type03Cell001btnIndexBelow.Margin.Top;
                    var newTopPositionUp = currentTopPositionBelow - 30;
                    int lblValueBelow = Convert.ToInt32(Type01Cell004.Content);
                    Type01Cell004Below.Content = lblValueBelow - 1;
                    Type01Cell004Below.Margin = new Thickness(5, newTopPositionUp, 0, 0);
                    Type03Cell001btnIndexBelow.Margin = new Thickness(30, newTopPositionUp, 0, 0);
                    Type01Cell005Below.Margin = new Thickness(1190, newTopPositionUp, 0, 0);
                    Type01Cell006Below.Margin = new Thickness(1230, newTopPositionUp, 0, 0);
                    Type03Cell002btnIndexBelow.Margin = new Thickness(1110, newTopPositionUp, 0, 0);
                }
            }
            else if (Type03Cell001 != null)
            {
                var currentTopPosition = Type03Cell001.Margin.Top;
                var newTopPositionDown = currentTopPosition + 30;
                int lblValue = Convert.ToInt32(Type01Cell004.Content);
                Type03Cell001.Margin = new Thickness(30, newTopPositionDown, 0, 0);
                Type03Cell002.Margin = new Thickness(1110, newTopPositionDown, 0, 0);
                Type01Cell004.Content = lblValue + 1;
                Type01Cell004.Margin = new Thickness(5, newTopPositionDown, 0, 0);
                Type01Cell005.Margin = new Thickness(1190, newTopPositionDown, 0, 0);
                Type01Cell006.Margin = new Thickness(1230, newTopPositionDown, 0, 0);

                if (tipReda == 1)
                {
                    var currentTopPositionBelow = Type01Cell001Below.Margin.Top;
                    var newTopPositionUp = currentTopPositionBelow - 30;
                    int lblValueBelow = Convert.ToInt32(Type01Cell004Below.Content);
                    Type01Cell001Below.Margin = new Thickness(730, newTopPositionUp, 0, 0);
                    Type01Cell002Below.Margin = new Thickness(680, newTopPositionUp, 0, 0);
                    Type01Cell003Below.Margin = new Thickness(1110, newTopPositionUp, 0, 0);
                    Type01Cell004Below.Content = lblValueBelow - 1;
                    Type01Cell004Below.Margin = new Thickness(5, newTopPositionUp, 0, 0);
                    Type01Cell005Below.Margin = new Thickness(1190, newTopPositionUp, 0, 0);
                    Type01Cell006Below.Margin = new Thickness(1230, newTopPositionUp, 0, 0);
                    Type01Cell007Below.Margin = new Thickness(30, newTopPositionUp, 0, 0);
                    Type01Cell008Below.Margin = new Thickness(120, newTopPositionUp, 0, 0);
                    Type01Cell009Below.Margin = new Thickness(210, newTopPositionUp, 0, 0);
                    Type01Cell0010Below.Margin = new Thickness(300, newTopPositionUp, 0, 0);
                    Type01Cell0011Below.Margin = new Thickness(390, newTopPositionUp, 0, 0);
                    Type01Cell0012Below.Margin = new Thickness(500, newTopPositionUp, 0, 0);
                    Type01Cell0013Below.Margin = new Thickness(590, newTopPositionUp, 0, 0);
                    Type01Cell0014Below.Margin = new Thickness(780, newTopPositionUp, 0, 0);
                    Type01Cell0015Below.Margin = new Thickness(830, newTopPositionUp, 0, 0);
                    Type01Cell0016Below.Margin = new Thickness(900, newTopPositionUp, 0, 0);
                    Type01Cell0017Below.Margin = new Thickness(950, newTopPositionUp, 0, 0);
                    Type01Cell0018Below.Margin = new Thickness(1020, newTopPositionUp, 0, 0);
                    Type01Cell0019Below.Margin = new Thickness(1075, newTopPositionUp + 5, 0, 0);
                }
                else if (tipReda == 2)
                {
                    var currentTopPositionBelow = Type02Cell001btnIndexBelow.Margin.Top;
                    var newTopPositionUp = currentTopPositionBelow - 30;
                    int lblValueBelow = Convert.ToInt32(Type01Cell004.Content);
                    Type02Cell001btnIndexBelow.Margin = new Thickness(30, newTopPositionUp, 0, 0);
                    Type02Cell002btnIndexBelow.Margin = new Thickness(1110, newTopPositionUp, 0, 0);
                    Type01Cell004Below.Content = lblValueBelow - 1;
                    Type01Cell004Below.Margin = new Thickness(5, newTopPositionUp, 0, 0);
                    Type01Cell005Below.Margin = new Thickness(1190, newTopPositionUp, 0, 0);
                    Type01Cell006Below.Margin = new Thickness(1230, newTopPositionUp, 0, 0);
                    Type02Cell003btnIndexBelow.Margin = new Thickness(30, newTopPositionUp, 0, 0);
                    Type02Cell004btnIndexBelow.Margin = new Thickness(120, newTopPositionUp, 0, 0);
                    Type02Cell005btnIndexBelow.Margin = new Thickness(730, newTopPositionUp, 0, 0);
                    Type02Cell006btnIndexBelow.Margin = new Thickness(680, newTopPositionUp, 0, 0);
                    Type02Cell007btnIndexBelow.Margin = new Thickness(590, newTopPositionUp, 0, 0);
                    Type02Cell008btnIndexBelow.Margin = new Thickness(780, newTopPositionUp, 0, 0);
                    Type02Cell009btnIndexBelow.Margin = new Thickness(830, newTopPositionUp, 0, 0);
                    Type02Cell0010btnIndexBelow.Margin = new Thickness(900, newTopPositionUp, 0, 0);
                    Type02Cell0011btnIndexBelow.Margin = new Thickness(950, newTopPositionUp, 0, 0);
                    Type02Cell0012btnIndexBelow.Margin = new Thickness(1020, newTopPositionUp, 0, 0);
                    Type02Cell0013btnIndexBelow.Margin = new Thickness(1075, newTopPositionUp + 5, 0, 0);
                }
                else if (tipReda == 3)
                {
                    var currentTopPositionBelow = Type03Cell001btnIndexBelow.Margin.Top;
                    var newTopPositionUp = currentTopPositionBelow - 30;
                    int lblValueBelow = Convert.ToInt32(Type01Cell004.Content);
                    Type01Cell004Below.Content = lblValueBelow - 1;
                    Type01Cell004Below.Margin = new Thickness(5, newTopPositionUp, 0, 0);
                    Type03Cell001btnIndexBelow.Margin = new Thickness(30, newTopPositionUp, 0, 0);
                    Type01Cell005Below.Margin = new Thickness(1190, newTopPositionUp, 0, 0);
                    Type01Cell006Below.Margin = new Thickness(1230, newTopPositionUp, 0, 0);
                    Type03Cell002btnIndexBelow.Margin = new Thickness(1110, newTopPositionUp, 0, 0);
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
            ComboBox Type01Cell0012 = (ComboBox)this.FindName("gehr_" + btnIndex);
            ComboBox Type01Cell0013 = (ComboBox)this.FindName("einh_" + btnIndex);
            TextBox Type01Cell0014 = (TextBox)this.FindName("men_" + btnIndex);
            TextBox Type01Cell0015 = (TextBox)this.FindName("einz_" + btnIndex);
            TextBox Type01Cell0016 = (TextBox)this.FindName("stk_" + btnIndex);
            TextBox Type01Cell0017 = (TextBox)this.FindName("gpreis_" + btnIndex);
            TextBox Type01Cell0018 = (TextBox)this.FindName("rab_" + btnIndex);
            CheckBox Type01Cell0019 = (CheckBox)this.FindName("akonto_" + btnIndex);
            //Row type 2
            TextBox Type02Cell001 = (TextBox)this.FindName("row2txtBox_" + btnIndex);
            Button Type02Cell002 = (Button)this.FindName("row2Btn_" + btnIndex);
            ComboBox Type02Cell003 = (ComboBox)this.FindName("r2First_" + btnIndex);
            ComboBox Type02Cell004 = (ComboBox)this.FindName("r2Second_" + btnIndex);
            TextBox Type02Cell005 = (TextBox)this.FindName("r2brei_" + btnIndex);
            TextBox Type02Cell006 = (TextBox)this.FindName("r2lng_" + btnIndex);
            TextBox Type02Cell007 = (TextBox)this.FindName("r2einh_" + btnIndex);
            TextBox Type02Cell008 = (TextBox)this.FindName("r2men_" + btnIndex);
            TextBox Type02Cell009 = (TextBox)this.FindName("r2einz_" + btnIndex);
            TextBox Type02Cell0010 = (TextBox)this.FindName("r2stk_" + btnIndex);
            TextBox Type02Cell0011 = (TextBox)this.FindName("r2gpreis_" + btnIndex);
            TextBox Type02Cell0012 = (TextBox)this.FindName("r2rab_" + btnIndex);
            CheckBox Type02Cell0013 = (CheckBox)this.FindName("r2akonto_" + btnIndex);
            //Row type 3
            TextBox Type03Cell001 = (TextBox)this.FindName("r3First_" + btnIndex);
            Button Type03Cell002 = (Button)this.FindName("row3Btn_" + btnIndex);
            var rowMargin = btn.Margin.Top - 30;
            for (int i = 0; i <= rowId; i++)
            {
                TextBox rowNumType01 = (TextBox)this.FindName("txtBoxPrva_" + i);
                TextBox rowNumType02 = (TextBox)this.FindName("row2txtBox_" + i);
                TextBox rowNumType03 = (TextBox)this.FindName("r3First_" + i);
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
                else if (rowNumType03 != null)
                {
                    var curRowMargin03 = rowNumType03.Margin.Top;
                    if (curRowMargin03 == rowMargin)
                    {
                        btnIndexBelow = Convert.ToInt32(rowNumType03.Name.Split('_').Last());
                        tipReda = 3;
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
            ComboBox Type01Cell0012Below = (ComboBox)this.FindName("gehr_" + btnIndexBelow);
            ComboBox Type01Cell0013Below = (ComboBox)this.FindName("einh_" + btnIndexBelow);
            TextBox Type01Cell0014Below = (TextBox)this.FindName("men_" + btnIndexBelow);
            TextBox Type01Cell0015Below = (TextBox)this.FindName("einz_" + btnIndexBelow);
            TextBox Type01Cell0016Below = (TextBox)this.FindName("stk_" + btnIndexBelow);
            TextBox Type01Cell0017Below = (TextBox)this.FindName("gpreis_" + btnIndexBelow);
            TextBox Type01Cell0018Below = (TextBox)this.FindName("rab_" + btnIndexBelow);
            CheckBox Type01Cell0019Below = (CheckBox)this.FindName("akonto_" + btnIndexBelow);
            //Row Type 02
            TextBox Type02Cell001btnIndexBelow = (TextBox)this.FindName("row2txtBox_" + btnIndexBelow);
            Button Type02Cell002btnIndexBelow = (Button)this.FindName("row2Btn_" + btnIndexBelow);
            ComboBox Type02Cell003btnIndexBelow = (ComboBox)this.FindName("r2First_" + btnIndexBelow);
            ComboBox Type02Cell004btnIndexBelow = (ComboBox)this.FindName("r2Second_" + btnIndexBelow);
            TextBox Type02Cell005btnIndexBelow = (TextBox)this.FindName("r2brei_" + btnIndexBelow);
            TextBox Type02Cell006btnIndexBelow = (TextBox)this.FindName("r2lng_" + btnIndexBelow);
            TextBox Type02Cell007btnIndexBelow = (TextBox)this.FindName("r2einh_" + btnIndexBelow);
            TextBox Type02Cell008btnIndexBelow = (TextBox)this.FindName("r2men_" + btnIndexBelow);
            TextBox Type02Cell009btnIndexBelow = (TextBox)this.FindName("r2einz_" + btnIndexBelow);
            TextBox Type02Cell0010btnIndexBelow = (TextBox)this.FindName("r2stk_" + btnIndexBelow);
            TextBox Type02Cell0011btnIndexBelow = (TextBox)this.FindName("r2gpreis_" + btnIndexBelow);
            TextBox Type02Cell0012btnIndexBelow = (TextBox)this.FindName("r2rab_" + btnIndexBelow);
            CheckBox Type02Cell0013btnIndexBelow = (CheckBox)this.FindName("r2akonto_" + btnIndexBelow);
            //Row Type 03
            TextBox Type03Cell001btnIndexBelow = (TextBox)this.FindName("r3First_" + btnIndexBelow);
            Button Type03Cell002btnIndexBelow = (Button)this.FindName("row3Btn_" + btnIndexBelow);
            if (Type01Cell001 != null)
            {
                var currentTopPosition = Type01Cell001.Margin.Top;
                var newTopPositionDown = currentTopPosition - 30;
                int lblValue = Convert.ToInt32(Type01Cell004.Content);
                Type01Cell001.Margin = new Thickness(730, newTopPositionDown, 0, 0);
                Type01Cell002.Margin = new Thickness(680, newTopPositionDown, 0, 0);
                Type01Cell003.Margin = new Thickness(1110, newTopPositionDown, 0, 0);
                Type01Cell004.Content = lblValue - 1;
                Type01Cell004.Margin = new Thickness(5, newTopPositionDown, 0, 0);
                Type01Cell005.Margin = new Thickness(1190, newTopPositionDown, 0, 0);
                Type01Cell006.Margin = new Thickness(1230, newTopPositionDown, 0, 0);
                Type01Cell007.Margin = new Thickness(30, newTopPositionDown, 0, 0);
                Type01Cell008.Margin = new Thickness(120, newTopPositionDown, 0, 0);
                Type01Cell009.Margin = new Thickness(210, newTopPositionDown, 0, 0);
                Type01Cell0010.Margin = new Thickness(300, newTopPositionDown, 0, 0);
                Type01Cell0011.Margin = new Thickness(390, newTopPositionDown, 0, 0);
                Type01Cell0012.Margin = new Thickness(500, newTopPositionDown, 0, 0);
                Type01Cell0013.Margin = new Thickness(590, newTopPositionDown, 0, 0);
                Type01Cell0014.Margin = new Thickness(780, newTopPositionDown, 0, 0);
                Type01Cell0015.Margin = new Thickness(830, newTopPositionDown, 0, 0);
                Type01Cell0016.Margin = new Thickness(900, newTopPositionDown, 0, 0);
                Type01Cell0017.Margin = new Thickness(950, newTopPositionDown, 0, 0);
                Type01Cell0018.Margin = new Thickness(1020, newTopPositionDown, 0, 0);
                Type01Cell0019.Margin = new Thickness(1075, newTopPositionDown + 5, 0, 0);
                if (tipReda == 1)
                {
                    var currentTopPositionBelow = Type01Cell001Below.Margin.Top;
                    var newTopPositionUp = currentTopPositionBelow + 30;
                    int lblValueBelow = Convert.ToInt32(Type01Cell004Below.Content);
                    Type01Cell001Below.Margin = new Thickness(730, newTopPositionUp, 0, 0);
                    Type01Cell002Below.Margin = new Thickness(680, newTopPositionUp, 0, 0);
                    Type01Cell003Below.Margin = new Thickness(1110, newTopPositionUp, 0, 0);
                    Type01Cell004Below.Content = lblValueBelow + 1;
                    Type01Cell004Below.Margin = new Thickness(5, newTopPositionUp, 0, 0);
                    Type01Cell005Below.Margin = new Thickness(1190, newTopPositionUp, 0, 0);
                    Type01Cell006Below.Margin = new Thickness(1230, newTopPositionUp, 0, 0);
                    Type01Cell007Below.Margin = new Thickness(30, newTopPositionUp, 0, 0);
                    Type01Cell008Below.Margin = new Thickness(120, newTopPositionUp, 0, 0);
                    Type01Cell009Below.Margin = new Thickness(210, newTopPositionUp, 0, 0);
                    Type01Cell0010Below.Margin = new Thickness(300, newTopPositionUp, 0, 0);
                    Type01Cell0011Below.Margin = new Thickness(390, newTopPositionUp, 0, 0);
                    Type01Cell0012Below.Margin = new Thickness(500, newTopPositionUp, 0, 0);
                    Type01Cell0013Below.Margin = new Thickness(590, newTopPositionUp, 0, 0);
                    Type01Cell0014Below.Margin = new Thickness(780, newTopPositionUp, 0, 0);
                    Type01Cell0015Below.Margin = new Thickness(830, newTopPositionUp, 0, 0);
                    Type01Cell0016Below.Margin = new Thickness(900, newTopPositionUp, 0, 0);
                    Type01Cell0017Below.Margin = new Thickness(950, newTopPositionUp, 0, 0);
                    Type01Cell0018Below.Margin = new Thickness(1020, newTopPositionUp, 0, 0);
                    Type01Cell0019Below.Margin = new Thickness(1075, newTopPositionUp + 5, 0, 0);
                }
                else if (tipReda == 2)
                {
                    var currentTopPositionBelow = Type02Cell001btnIndexBelow.Margin.Top;
                    var newTopPositionUp = currentTopPositionBelow + 30;
                    int lblValueBelow = Convert.ToInt32(Type01Cell004.Content);
                    Type02Cell001btnIndexBelow.Margin = new Thickness(30, newTopPositionUp, 0, 0);
                    Type02Cell002btnIndexBelow.Margin = new Thickness(1110, newTopPositionUp, 0, 0);
                    Type01Cell004Below.Content = lblValueBelow + 1;
                    Type01Cell004Below.Margin = new Thickness(5, newTopPositionUp, 0, 0);
                    Type01Cell005Below.Margin = new Thickness(1190, newTopPositionUp, 0, 0);
                    Type01Cell006Below.Margin = new Thickness(1230, newTopPositionUp, 0, 0);
                    Type02Cell003btnIndexBelow.Margin = new Thickness(30, newTopPositionUp, 0, 0);
                    Type02Cell004btnIndexBelow.Margin = new Thickness(120, newTopPositionUp, 0, 0);
                    Type02Cell005btnIndexBelow.Margin = new Thickness(730, newTopPositionUp, 0, 0);
                    Type02Cell006btnIndexBelow.Margin = new Thickness(680, newTopPositionUp, 0, 0);
                    Type02Cell007btnIndexBelow.Margin = new Thickness(590, newTopPositionUp, 0, 0);
                    Type02Cell008btnIndexBelow.Margin = new Thickness(780, newTopPositionUp, 0, 0);
                    Type02Cell009btnIndexBelow.Margin = new Thickness(830, newTopPositionUp, 0, 0);
                    Type02Cell0010btnIndexBelow.Margin = new Thickness(900, newTopPositionUp, 0, 0);
                    Type02Cell0011btnIndexBelow.Margin = new Thickness(950, newTopPositionUp, 0, 0);
                    Type02Cell0012btnIndexBelow.Margin = new Thickness(1020, newTopPositionUp, 0, 0);
                    Type02Cell0013btnIndexBelow.Margin = new Thickness(1075, newTopPositionUp + 5, 0, 0);
                }
                else if (tipReda == 3)
                {
                    var currentTopPositionBelow = Type03Cell001btnIndexBelow.Margin.Top;
                    var newTopPositionUp = currentTopPositionBelow + 30;
                    int lblValueBelow = Convert.ToInt32(Type01Cell004.Content);
                    Type01Cell004Below.Content = lblValueBelow + 1;
                    Type01Cell004Below.Margin = new Thickness(5, newTopPositionUp, 0, 0);
                    Type03Cell001btnIndexBelow.Margin = new Thickness(30, newTopPositionUp, 0, 0);
                    Type01Cell005Below.Margin = new Thickness(1190, newTopPositionUp, 0, 0);
                    Type01Cell006Below.Margin = new Thickness(1230, newTopPositionUp, 0, 0);
                    Type03Cell002btnIndexBelow.Margin = new Thickness(1110, newTopPositionUp, 0, 0);
                }

            }
            else if (Type02Cell001 != null)
            {
                var currentTopPosition = Type02Cell001.Margin.Top;
                var newTopPositionDown = currentTopPosition - 30;
                int lblValue = Convert.ToInt32(Type01Cell004.Content);
                Type02Cell001.Margin = new Thickness(30, newTopPositionDown, 0, 0);
                Type02Cell002.Margin = new Thickness(1110, newTopPositionDown, 0, 0);
                Type01Cell004.Content = lblValue - 1;
                Type01Cell004.Margin = new Thickness(5, newTopPositionDown, 0, 0);
                Type01Cell005.Margin = new Thickness(1190, newTopPositionDown, 0, 0);
                Type01Cell006.Margin = new Thickness(1230, newTopPositionDown, 0, 0);
                Type02Cell003.Margin = new Thickness(30, newTopPositionDown, 0, 0);
                Type02Cell004.Margin = new Thickness(120, newTopPositionDown, 0, 0);
                Type02Cell005.Margin = new Thickness(730, newTopPositionDown, 0, 0);
                Type02Cell006.Margin = new Thickness(680, newTopPositionDown, 0, 0);
                Type02Cell007.Margin = new Thickness(590, newTopPositionDown, 0, 0);
                Type02Cell008.Margin = new Thickness(780, newTopPositionDown, 0, 0);
                Type02Cell009.Margin = new Thickness(830, newTopPositionDown, 0, 0);
                Type02Cell0010.Margin = new Thickness(900, newTopPositionDown, 0, 0);
                Type02Cell0011.Margin = new Thickness(950, newTopPositionDown, 0, 0);
                Type02Cell0012.Margin = new Thickness(1020, newTopPositionDown, 0, 0);
                Type02Cell0013.Margin = new Thickness(1075, newTopPositionDown + 5, 0, 0);
                if (tipReda == 1)
                {
                    var currentTopPositionBelow = Type01Cell001Below.Margin.Top;
                    var newTopPositionUp = currentTopPositionBelow + 30;
                    int lblValueBelow = Convert.ToInt32(Type01Cell004Below.Content);
                    Type01Cell001Below.Margin = new Thickness(730, newTopPositionUp, 0, 0);
                    Type01Cell002Below.Margin = new Thickness(680, newTopPositionUp, 0, 0);
                    Type01Cell003Below.Margin = new Thickness(1110, newTopPositionUp, 0, 0);
                    Type01Cell004Below.Content = lblValueBelow + 1;
                    Type01Cell004Below.Margin = new Thickness(5, newTopPositionUp, 0, 0);
                    Type01Cell005Below.Margin = new Thickness(1190, newTopPositionUp, 0, 0);
                    Type01Cell006Below.Margin = new Thickness(1230, newTopPositionUp, 0, 0);
                    Type01Cell007Below.Margin = new Thickness(30, newTopPositionUp, 0, 0);
                    Type01Cell008Below.Margin = new Thickness(120, newTopPositionUp, 0, 0);
                    Type01Cell009Below.Margin = new Thickness(210, newTopPositionUp, 0, 0);
                    Type01Cell0010Below.Margin = new Thickness(300, newTopPositionUp, 0, 0);
                    Type01Cell0011Below.Margin = new Thickness(390, newTopPositionUp, 0, 0);
                    Type01Cell0012Below.Margin = new Thickness(500, newTopPositionUp, 0, 0);
                    Type01Cell0013Below.Margin = new Thickness(590, newTopPositionUp, 0, 0);
                    Type01Cell0014Below.Margin = new Thickness(780, newTopPositionUp, 0, 0);
                    Type01Cell0015Below.Margin = new Thickness(830, newTopPositionUp, 0, 0);
                    Type01Cell0016Below.Margin = new Thickness(900, newTopPositionUp, 0, 0);
                    Type01Cell0017Below.Margin = new Thickness(950, newTopPositionUp, 0, 0);
                    Type01Cell0018Below.Margin = new Thickness(1020, newTopPositionUp, 0, 0);
                    Type01Cell0019Below.Margin = new Thickness(1075, newTopPositionUp + 5, 0, 0);
                }
                else if (tipReda == 2)
                {
                    var currentTopPositionBelow = Type02Cell001btnIndexBelow.Margin.Top;
                    var newTopPositionUp = currentTopPositionBelow + 30;
                    int lblValueBelow = Convert.ToInt32(Type01Cell004.Content);
                    Type02Cell001btnIndexBelow.Margin = new Thickness(30, newTopPositionUp, 0, 0);
                    Type02Cell002btnIndexBelow.Margin = new Thickness(1110, newTopPositionUp, 0, 0);
                    Type01Cell004Below.Content = lblValueBelow + 1;
                    Type01Cell004Below.Margin = new Thickness(5, newTopPositionUp, 0, 0);
                    Type01Cell005Below.Margin = new Thickness(1190, newTopPositionUp, 0, 0);
                    Type01Cell006Below.Margin = new Thickness(1230, newTopPositionUp, 0, 0);
                    Type02Cell003btnIndexBelow.Margin = new Thickness(30, newTopPositionUp, 0, 0);
                    Type02Cell004btnIndexBelow.Margin = new Thickness(120, newTopPositionUp, 0, 0);
                    Type02Cell005btnIndexBelow.Margin = new Thickness(730, newTopPositionUp, 0, 0);
                    Type02Cell006btnIndexBelow.Margin = new Thickness(680, newTopPositionUp, 0, 0);
                    Type02Cell007btnIndexBelow.Margin = new Thickness(590, newTopPositionUp, 0, 0);
                    Type02Cell008btnIndexBelow.Margin = new Thickness(780, newTopPositionUp, 0, 0);
                    Type02Cell009btnIndexBelow.Margin = new Thickness(830, newTopPositionUp, 0, 0);
                    Type02Cell0010btnIndexBelow.Margin = new Thickness(900, newTopPositionUp, 0, 0);
                    Type02Cell0011btnIndexBelow.Margin = new Thickness(950, newTopPositionUp, 0, 0);
                    Type02Cell0012btnIndexBelow.Margin = new Thickness(1020, newTopPositionUp, 0, 0);
                    Type02Cell0013btnIndexBelow.Margin = new Thickness(1075, newTopPositionUp + 5, 0, 0);
                }
                else if (tipReda == 3)
                {
                    var currentTopPositionBelow = Type03Cell001btnIndexBelow.Margin.Top;
                    var newTopPositionUp = currentTopPositionBelow + 30;
                    int lblValueBelow = Convert.ToInt32(Type01Cell004.Content);
                    Type01Cell004Below.Content = lblValueBelow + 1;
                    Type01Cell004Below.Margin = new Thickness(5, newTopPositionUp, 0, 0);
                    Type03Cell001btnIndexBelow.Margin = new Thickness(30, newTopPositionUp, 0, 0);
                    Type01Cell005Below.Margin = new Thickness(1190, newTopPositionUp, 0, 0);
                    Type01Cell006Below.Margin = new Thickness(1230, newTopPositionUp, 0, 0);
                    Type03Cell002btnIndexBelow.Margin = new Thickness(1110, newTopPositionUp, 0, 0);
                }
            }
            else if (Type03Cell001 != null)
            {
                var currentTopPosition = Type03Cell001.Margin.Top;
                var newTopPositionDown = currentTopPosition - 30;
                int lblValue = Convert.ToInt32(Type01Cell004.Content);
                Type03Cell001.Margin = new Thickness(30, newTopPositionDown, 0, 0);
                Type03Cell002.Margin = new Thickness(1110, newTopPositionDown, 0, 0);
                Type01Cell004.Content = lblValue - 1;
                Type01Cell004.Margin = new Thickness(5, newTopPositionDown, 0, 0);
                Type01Cell005.Margin = new Thickness(1190, newTopPositionDown, 0, 0);
                Type01Cell006.Margin = new Thickness(1230, newTopPositionDown, 0, 0);
                if (tipReda == 1)
                {
                    var currentTopPositionBelow = Type01Cell001Below.Margin.Top;
                    var newTopPositionUp = currentTopPositionBelow + 30;
                    int lblValueBelow = Convert.ToInt32(Type01Cell004Below.Content);
                    Type01Cell001Below.Margin = new Thickness(730, newTopPositionUp, 0, 0);
                    Type01Cell002Below.Margin = new Thickness(680, newTopPositionUp, 0, 0);
                    Type01Cell003Below.Margin = new Thickness(1110, newTopPositionUp, 0, 0);
                    Type01Cell004Below.Content = lblValueBelow + 1;
                    Type01Cell004Below.Margin = new Thickness(5, newTopPositionUp, 0, 0);
                    Type01Cell005Below.Margin = new Thickness(1190, newTopPositionUp, 0, 0);
                    Type01Cell006Below.Margin = new Thickness(1230, newTopPositionUp, 0, 0);
                    Type01Cell007Below.Margin = new Thickness(30, newTopPositionUp, 0, 0);
                    Type01Cell008Below.Margin = new Thickness(120, newTopPositionUp, 0, 0);
                    Type01Cell009Below.Margin = new Thickness(210, newTopPositionUp, 0, 0);
                    Type01Cell0010Below.Margin = new Thickness(300, newTopPositionUp, 0, 0);
                    Type01Cell0011Below.Margin = new Thickness(390, newTopPositionUp, 0, 0);
                    Type01Cell0012Below.Margin = new Thickness(500, newTopPositionUp, 0, 0);
                    Type01Cell0013Below.Margin = new Thickness(590, newTopPositionUp, 0, 0);
                    Type01Cell0014Below.Margin = new Thickness(780, newTopPositionUp, 0, 0);
                    Type01Cell0015Below.Margin = new Thickness(830, newTopPositionUp, 0, 0);
                    Type01Cell0016Below.Margin = new Thickness(900, newTopPositionUp, 0, 0);
                    Type01Cell0017Below.Margin = new Thickness(950, newTopPositionUp, 0, 0);
                    Type01Cell0018Below.Margin = new Thickness(1020, newTopPositionUp, 0, 0);
                    Type01Cell0019Below.Margin = new Thickness(1075, newTopPositionUp + 5, 0, 0);
                }
                else if (tipReda == 2)
                {
                    var currentTopPositionBelow = Type02Cell001btnIndexBelow.Margin.Top;
                    var newTopPositionUp = currentTopPositionBelow + 30;
                    int lblValueBelow = Convert.ToInt32(Type01Cell004.Content);
                    Type02Cell001btnIndexBelow.Margin = new Thickness(30, newTopPositionUp, 0, 0);
                    Type02Cell002btnIndexBelow.Margin = new Thickness(1110, newTopPositionUp, 0, 0);
                    Type01Cell004Below.Content = lblValueBelow + 1;
                    Type01Cell004Below.Margin = new Thickness(5, newTopPositionUp, 0, 0);
                    Type01Cell005Below.Margin = new Thickness(1190, newTopPositionUp, 0, 0);
                    Type01Cell006Below.Margin = new Thickness(1230, newTopPositionUp, 0, 0);
                    Type02Cell003btnIndexBelow.Margin = new Thickness(30, newTopPositionUp, 0, 0);
                    Type02Cell004btnIndexBelow.Margin = new Thickness(120, newTopPositionUp, 0, 0);
                    Type02Cell005btnIndexBelow.Margin = new Thickness(730, newTopPositionUp, 0, 0);
                    Type02Cell006btnIndexBelow.Margin = new Thickness(680, newTopPositionUp, 0, 0);
                    Type02Cell007btnIndexBelow.Margin = new Thickness(590, newTopPositionUp, 0, 0);
                    Type02Cell008btnIndexBelow.Margin = new Thickness(780, newTopPositionUp, 0, 0);
                    Type02Cell009btnIndexBelow.Margin = new Thickness(830, newTopPositionUp, 0, 0);
                    Type02Cell0010btnIndexBelow.Margin = new Thickness(900, newTopPositionUp, 0, 0);
                    Type02Cell0011btnIndexBelow.Margin = new Thickness(950, newTopPositionUp, 0, 0);
                    Type02Cell0012btnIndexBelow.Margin = new Thickness(1020, newTopPositionUp, 0, 0);
                    Type02Cell0013btnIndexBelow.Margin = new Thickness(1075, newTopPositionUp + 5, 0, 0);
                }
                else if (tipReda == 3)
                {
                    var currentTopPositionBelow = Type03Cell001btnIndexBelow.Margin.Top;
                    var newTopPositionUp = currentTopPositionBelow + 30;
                    int lblValueBelow = Convert.ToInt32(Type01Cell004.Content);
                    Type01Cell004Below.Content = lblValueBelow + 1;
                    Type01Cell004Below.Margin = new Thickness(5, newTopPositionUp, 0, 0);
                    Type03Cell001btnIndexBelow.Margin = new Thickness(30, newTopPositionUp, 0, 0);
                    Type01Cell005Below.Margin = new Thickness(1190, newTopPositionUp, 0, 0);
                    Type01Cell006Below.Margin = new Thickness(1230, newTopPositionUp, 0, 0);
                    Type03Cell002btnIndexBelow.Margin = new Thickness(1110, newTopPositionUp, 0, 0);
                }
            }
        }
        #endregion

        #region Material Type Changed
        private void matT_SelectionChanged(object sender, SelectionChangedEventArgs args)
        {
            Service.MassServisClient client = new MassServisClient();

            var obj = sender as ComboBox;
            int rowId = Convert.ToInt32(obj.Name.Split('_').Last());
            string materialTypeValue = obj.SelectedValue.ToString().Replace("\"","").Trim();

            var materialTypeId = client.getMatIdByName(materialTypeValue);
            var oberflacheList = client.getPovrsinaByMaterijal(materialTypeId[0].id);

            //Oberflache
            ComboBox ComboOberflache = (ComboBox)this.FindName("ober_" + rowId);
            ComboOberflache.Items.Clear();
            foreach (var p in oberflacheList) { ComboOberflache.Items.Add(p.pov); }
            ComboOberflache.SelectedIndex = 0;
            //Starke
            ComboBox ComboStarke = (ComboBox)this.FindName("stark_" + rowId);
            ComboBox ComboProdukt = (ComboBox)this.FindName("prod_" + rowId);          
            var starkeId = client.getDebljinaIdByName(ComboStarke.SelectedValue.ToString().Replace("\"", "").Trim());
            var produktId = client.getProIdByName(ComboProdukt.SelectedValue.ToString().Replace("\"", "").Trim());
            var starkeList = client.getDebljinaByProduktId(produktId[0].idprodukt);
            ComboStarke.Items.Clear();
            ComboStarke.Items.Clear();
            foreach (var p in starkeList) { ComboStarke.Items.Add(p.starke1); };
            ComboStarke.SelectedIndex = 0;
            //Materijal
            ComboBox ComboMaterijal = (ComboBox)this.FindName("mat_" + rowId);
            var mArt = client.getMaterijalByID(materialTypeId[0].id);
            ComboMaterijal.Items.Clear();
            foreach (var p in mArt) { ComboMaterijal.Items.Add(p.naziv); }
            ComboMaterijal.SelectedIndex = 0;
            //Price
           // get_price(rowId, materialTypeId[0].id, 1, ComboStarke.SelectedValue.ToString().Replace("\"", "").Trim(), ComboOberflache.SelectedValue.ToString().Replace("\"", "").Trim());
        }
        #endregion

        #region Materijal Changed
        private void mat_SelectionChanged(object sender, SelectionChangedEventArgs args)
        {
            var obj = sender as ComboBox;
            if (obj.IsDropDownOpen)
            {
                Service.MassServisClient client = new MassServisClient();
                //Materijal               
                int rowId = Convert.ToInt32(obj.Name.Split('_').Last());
                string materijalValue = obj.SelectedValue.ToString().Replace("\"", "").Trim();
                var materijalId = client.getMaterijalIDName(materijalValue);
                //Oberflache
                ComboBox ComboOberflache = (ComboBox)this.FindName("ober_" + rowId);
                string OberflacheValue = ComboOberflache.SelectedValue.ToString().Replace("\"", "").Trim();
                //Starke
                ComboBox ComboStarke = (ComboBox)this.FindName("stark_" + rowId);
                string StarkeValue = ComboStarke.SelectedValue.ToString().Replace("\"", "").Trim();
                //MaterialType
                ComboBox ComboMaterialType = (ComboBox)this.FindName("matT_" + rowId);
                var materialTypeId = client.getMatIdByName(ComboMaterialType.SelectedValue.ToString().Replace("\"", "").Trim());

                
                    //Price
                    get_price(rowId, materialTypeId[0].id, materijalId[0].id, ComboStarke.SelectedValue.ToString().Replace("\"", "").Trim(), ComboOberflache.SelectedValue.ToString().Replace("\"", "").Trim());
                }
        }
        #endregion

        #region podPozicija Changed
        private void r2Second_SelectionChanged(object sender, SelectionChangedEventArgs args)
        {
            var obj = sender as ComboBox;
            if (obj.IsDropDownOpen)
            {
                Service.MassServisClient client = new MassServisClient();
                int rowId = Convert.ToInt32(obj.Name.Split('_').Last());
                string podPozValue = obj.SelectedValue.ToString().Replace("\"", "").Trim();
                ComboBox ComboPozicija = (ComboBox)this.FindName("r2First_" + rowId); 

                var podPozicijaId = client.getPodPozicijaIdByName(podPozValue);
                get_pozicija_price(rowId, podPozicijaId[0].id);
            }
        }
        private void r2First_SelectionChanged(object sender, SelectionChangedEventArgs args)
        { 
            var obj = sender as ComboBox;
            if (obj.IsDropDownOpen)
            {
                Service.MassServisClient client = new MassServisClient();
                int rowId = Convert.ToInt32(obj.Name.Split('_').Last());
                string podPozValue = obj.SelectedValue.ToString().Replace("\"", "").Trim();
                ComboBox ComboPodPozicija = (ComboBox)this.FindName("r2Second_" + rowId); 
                var pozicijaId = client.getPozicijaNameById(podPozValue);
                var podPozicijaList = client.getPodpozicijaFromPozicija(pozicijaId[0].id);
                ComboPodPozicija.Items.Clear();
                foreach (var p in podPozicijaList) { ComboPodPozicija.Items.Add(p.naziv.Replace("\"", "").Trim()); }
                ComboPodPozicija.SelectedIndex = 0;
            }
        }
        #endregion

        #region getPrice Method
        private void get_price(int row, int idMaterialType, int idMaterijal, string valStarke, string valOberflache)
        {
            Service.MassServisClient client = new MassServisClient();
            var Results = client.getMaterialPrice(idMaterialType, idMaterijal, valStarke, valOberflache);
            TextBox TxtBoxEinz = (TextBox)this.FindName("einz_" + row);
            TxtBoxEinz.Text = "";
            if (Results.Count != 0)
            {
                TxtBoxEinz.Text = (Results[0].iznos).ToString();
            }
            else
            {
                TxtBoxEinz.Text = "0,00";
            }
        }
        private void get_pozicija_price(int row, int idPodPozicija)
        {
            Service.MassServisClient client = new MassServisClient();
            var Results = client.getPodpozicijaPrice(idPodPozicija);
            TextBox TxtBoxEinz = (TextBox)this.FindName("r2einz_" + row);
            if (Results.Count != 0) 
            {
                TxtBoxEinz.Text = (Results[0].cijena).ToString();
            }
            else
            {
                TxtBoxEinz.Text = "0,00";
            }
        }
        #endregion

        #region Produkt Changed
        private void prod_SelectionChanged(object sender, SelectionChangedEventArgs arg)
        {
            Service.MassServisClient client = new MassServisClient();
            var obj = sender as ComboBox;
            int rowId = Convert.ToInt32(obj.Name.Split('_').Last());
            string value = obj.SelectedValue.ToString();           
            var proId = client.getProIdByName(value);
            int prodVal01 = Convert.ToInt32(proId[0].idprodukt);
            var starkeList = client.getDebljinaByProduktId(prodVal01);
            ComboBox Cell01 = (ComboBox)this.FindName("stark_" + rowId);
            Cell01.Items.Clear();
            foreach (var p in starkeList) { Cell01.Items.Add(p.starke1); };
            Cell01.SelectedIndex = 0;
        }
        #endregion

        #region Einh Selection Changed
        private void einh_SelectionChanged(object sender, SelectionChangedEventArgs arg) 
        {           
            var obj = sender as ComboBox;
            int rowId = Convert.ToInt32(obj.Name.Split('_').Last());           
            if (obj.IsDropDownOpen)
            {
                string value = obj.SelectedValue.ToString();
                TextBox Breit = (TextBox)this.FindName("txtBoxPrva_" + rowId);
                TextBox Lng = (TextBox)this.FindName("txtBoxDruga_" + rowId);
                if (value == "Lfm")
                {
                    Lng.Text = "100";
                    Lng.IsReadOnly = false;
                    Breit.IsReadOnly = false;
                    Lng.Background = Brushes.White;
                    Breit.Background = Brushes.White;
                }
                else if (value == "Stk" || value == "Pau" || value == "Std.")
                {
                    Lng.IsReadOnly = true;
                    Breit.IsReadOnly = true;
                    Lng.Background = Brushes.LightGray;
                    Breit.Background = Brushes.LightGray;
                    Lng.Text = "";
                    Breit.Text = "";
                }
                else 
                {
                    Lng.IsReadOnly = false;
                    Breit.IsReadOnly = false;
                    Lng.Text = "";
                    Breit.Text = "";
                    Lng.Background = Brushes.White;
                    Breit.Background = Brushes.White;
                }
            }
        }
        #endregion

        #region Men Preracunavanje
        private void menPreracunavanje_TextChanged(object sender, TextChangedEventArgs e)        
        {
            var obj = sender as TextBox;
            int rowId = Convert.ToInt32(obj.Name.Split('_').Last());
            TextBox tbLng01 = (TextBox)this.FindName("txtBoxDruga_"+rowId);
            TextBox tbBrei01 = (TextBox)this.FindName("txtBoxPrva_" + rowId);
            TextBox tbMen01 = (TextBox)this.FindName("men_" + rowId);
            decimal dLng = 0; decimal dBrei = 0; decimal dMen = 0;
            if (tbLng01.Text == "" || tbLng01.Text.Any(c => char.IsLetter(c))) { dLng = 0; } else { dLng = Convert.ToDecimal(tbLng01.Text); }
            if (tbBrei01.Text == "" || tbBrei01.Text.Any(c => char.IsLetter(c))) { dBrei = 0; } else { dBrei = Convert.ToDecimal(tbBrei01.Text); }
            if (dLng != 0 && dBrei != 0)
            {
                dMen = (dLng/100)*(dBrei/100);
                tbMen01.Text = dMen.ToString();
            }
            else 
            {
                tbMen01.Text = "0.00";
            }
            
        }
        #endregion

        #region Akonto Changed
        private void akonto_Click(object sender, RoutedEventArgs e)
        {
            var obj = sender as CheckBox;
            int rowID = Convert.ToInt32(obj.Name.Split('_').Last());
            Label LabelBr = (Label)this.FindName("rd_" + rowID);
            if (obj.IsChecked == true)
            {
                //crvena
                LabelBr.Foreground = Brushes.Red;
            }
            else
            {
                TextBox Tipreda01 = (TextBox)this.FindName("txtBoxPrva_" + rowID);
                TextBox Tipreda02 = (TextBox)this.FindName("row2txtBox_" + rowID);
                TextBox Tipreda03 = (TextBox)this.FindName("r3First_" + rowID);
                if (Tipreda01 != null || Tipreda02 != null)
                {
                    //zelena
                    LabelBr.Foreground = Brushes.Green;
                }
                else if (Tipreda03 != null)
                {
                    //plava
                    LabelBr.Foreground = Brushes.Blue;
                }
            }
            preracunavanje();
        }
        #endregion

        #region Racunanje
        //Menge Pressed
        private void men1_TextChanged(object sender, TextChangedEventArgs e)
        {
            var obj = sender as TextBox;
            int rowId = Convert.ToInt32(obj.Name.Split('_').Last());
            TextBox TxtBoxMen = (TextBox)this.FindName("men_" + rowId);
            TextBox TxtBoxStk = (TextBox)this.FindName("stk_" + rowId);
            TextBox TxtBoxEinz = (TextBox)this.FindName("einz_" + rowId);
            TextBox TxtBoxGpreis = (TextBox)this.FindName("gpreis_" + rowId);
            decimal menValue;
            if (TxtBoxMen.Text == "" || TxtBoxMen.Text.Any(c => char.IsLetter(c))) { menValue = 1; } else { menValue = Convert.ToDecimal(TxtBoxMen.Text); }        
            decimal stkValue;
            if (TxtBoxStk.Text == "" || TxtBoxStk.Text.Any(c => char.IsLetter(c))) { stkValue = 1; } else { stkValue = Convert.ToDecimal(TxtBoxStk.Text); }
            decimal einzValue;
            if (TxtBoxEinz.Text == "" || TxtBoxEinz.Text.Any(c => char.IsLetter(c))) { einzValue = 1; } else { einzValue = Convert.ToDecimal(TxtBoxEinz.Text); }
            decimal gPreisValue;
            if (TxtBoxMen.Text != "" && TxtBoxEinz.Text != "" && TxtBoxStk.Text != "") 
            { gPreisValue = menValue * stkValue * einzValue; 
              TxtBoxGpreis.Text =  toCurrencyString(gPreisValue).ToString(); }
            else { TxtBoxGpreis.Text = toCurrencyString(Convert.ToDecimal(0)); }
        }
        string toCurrencyString(decimal d)
        {
                return d.ToString("#,##0.00");
        }
        //Menge2 Pressed
        private void men2_TextChanged(object sender, TextChangedEventArgs e)
        {
            var obj = sender as TextBox;
            int rowId = Convert.ToInt32(obj.Name.Split('_').Last());
            TextBox TxtBoxMen = (TextBox)this.FindName("r2men_" + rowId);
            TextBox TxtBoxStk = (TextBox)this.FindName("r2stk_" + rowId);
            TextBox TxtBoxEinz = (TextBox)this.FindName("r2einz_" + rowId);
            TextBox TxtBoxGpreis = (TextBox)this.FindName("r2gpreis_" + rowId);
            decimal menValue;
            if (TxtBoxMen.Text == "" || TxtBoxMen.Text.Any(c => char.IsLetter(c))) { menValue = 1; } else { menValue = Convert.ToDecimal(TxtBoxMen.Text); }
            decimal stkValue;
            if (TxtBoxStk.Text == "" || TxtBoxStk.Text.Any(c => char.IsLetter(c))) { stkValue = 1; } else { stkValue = Convert.ToDecimal(TxtBoxStk.Text); }
            decimal einzValue;
            if (TxtBoxEinz.Text == "" || TxtBoxEinz.Text.Any(c => char.IsLetter(c))) { einzValue = 1; } else { einzValue = Convert.ToDecimal(TxtBoxEinz.Text); }
            decimal gPreisValue;
            if (TxtBoxMen.Text != "" && TxtBoxEinz.Text != "" && TxtBoxStk.Text != "")
            {
                gPreisValue = menValue * stkValue * einzValue;
                TxtBoxGpreis.Text = toCurrencyString(gPreisValue).ToString();
            }
            else { TxtBoxGpreis.Text = toCurrencyString(Convert.ToDecimal(0)); }
        }
        private void gPreis_KeyDown(object sender, KeyEventArgs e)
        {
            preracunavanje();
            
        }
        private void txtBoxSonder_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
                preracunavanje();
        }
        private void preracunavanje() 
        {
            decimal value = 0;
            decimal sonder = 0;
            if (txtBoxSonder.Text.Length > 0) 
            {
                sonder = Convert.ToDecimal(txtBoxSonder.Text);
            }
            else 
            {
                sonder = 0;
            }
            for (int i = 1; i <= rowId + 1; i++)
            {
                TextBox TxtBoxGpreis01 = (TextBox)this.FindName("gpreis_" + i);
                TextBox TxtBoxGpreis02 = (TextBox)this.FindName("r2gpreis_" + i);
                Label lbl = (Label)this.FindName("rd_" + i);
                if (TxtBoxGpreis01 != null && TxtBoxGpreis01.Text != "")
                {
                    if (lbl.Foreground != Brushes.Red)
                    {
                        decimal net01 = Convert.ToDecimal(TxtBoxGpreis01.Text.ToString());
                        value = value + net01 - sonder;
                    }
                }
                else if (TxtBoxGpreis02 != null && TxtBoxGpreis02.Text != "")
                {
                    if (lbl.Foreground != Brushes.Red)
                    {
                        decimal net02 = Convert.ToDecimal(TxtBoxGpreis02.Text);
                        value = value + net02 - sonder;
                    }
                }
            }
            lblNettobetrag.Content = toCurrencyString(Convert.ToDecimal(value.ToString()));
            lblEndbetrag.Content = toCurrencyString(value * Convert.ToDecimal(1.19));
            lblMwst.Content = toCurrencyString((value * Convert.ToDecimal(1.19)) - value);
        }
        #endregion

        
        #endregion

        #region Bind KundeNr
        private void bindMethod()
        {                     
            txtAuto.TextChanged += new TextChangedEventHandler(txtAuto_TextChanged);           
        }

        private void bindSelectedKunden(string kundeNr) 
        {
            var lKunden = client.getKundenByKundeNr(kundeNr);
            //txtBoxAnrTit.Text = lKunden.
            foreach (var item in lKunden)
            {
                if (item.anreden == 0) { txtBoxAnrTit.Text = "Herr"; }
                else if (item.anreden == 1) { txtBoxAnrTit.Text = "Frau"; }
                else if (item.anreden == 2) { txtBoxAnrTit.Text = "Firma"; }
                else if (item.anreden == 3) { txtBoxAnrTit.Text = "Fam."; }
                txtBoxVorname1.Text = item.vorname;
                txtBoxVorname2.Text = item.name;
                txtBoxName2.Text = item.name2;
                txtBoxLieferant.Text = item.lieferadresse;
                txtBoxRechnung.Text = item.rechnungsadresse;
                txtBoxPrivat.Text = item.tel1;
                txtBoxHandy.Text = item.tel2;
                txtBoxEmail.Text = item.mail;
            }

        }

        #region TextBox-TextChanged-txtAuto
        private void txtAuto_TextChanged(object sender, TextChangedEventArgs e)
        {            
            if (txtAuto.Text.Trim().Length > 2)
            {
                List<string> autoList = new List<string>();
                Service.MassServisClient client = new MassServisClient();
                //var res = client.ListaKupaca();
                var res = client.KundenLike(txtAuto.Text.Trim());
                string typedString = txtAuto.Text.Trim();               
                autoList.Clear();

                foreach (var item in res)
                {
                    if (!string.IsNullOrEmpty(txtAuto.Text))
                    {
                        if (item.kundeNr.StartsWith(typedString))
                        {
                            autoList.Add(item.kundeNr);
                        }
                    }
                }

                if (autoList.Count > 0)
                {
                    lbSuggestion.ItemsSource = autoList;
                    lbSuggestion.Visibility = Visibility.Visible;
                }
                else if (txtAuto.Text.Equals(""))
                {
                    lbSuggestion.Visibility = Visibility.Collapsed;
                    lbSuggestion.ItemsSource = null;
                }
                else
                {
                    lbSuggestion.Visibility = Visibility.Collapsed;
                    lbSuggestion.ItemsSource = null;
                }
            }
            else if (txtAuto.Text.Trim().Length == 0)
            {
                lbSuggestion.Visibility = Visibility.Collapsed;
                lbSuggestion.ItemsSource = null;
            }
            if (txtAuto.Text.Trim().Length == 5)
            {
                bindSelectedKunden(txtAuto.Text.Trim().ToString());
            }
        }
        #endregion

        #region ListBox-SelectionChanged-lbSuggestion
        private void lbSuggestion_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (lbSuggestion.ItemsSource != null)
            {
                lbSuggestion.Visibility = Visibility.Collapsed;
                txtAuto.TextChanged -= new TextChangedEventHandler(txtAuto_TextChanged);
                if (lbSuggestion.SelectedIndex != -1)
                {
                    txtAuto.Text = lbSuggestion.SelectedItem.ToString();
                }
                if (txtAuto.Text.Trim().Length == 5)
                {
                    bindSelectedKunden(txtAuto.Text.Trim().ToString());
                }
                txtAuto.TextChanged += new TextChangedEventHandler(txtAuto_TextChanged);
            }
        }
        #endregion


        #endregion
    }
}
