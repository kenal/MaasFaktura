﻿using System;
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
using WpfScheduler;

namespace Desktop
{
    /// <summary>
    /// Interaction logic for KalendarWindow.xaml
    /// </summary>
    public partial class KalendarWindow : Window
    {
        public KalendarWindow()
        {
            InitializeComponent();
            Scheduler s = new WpfScheduler.Scheduler();
        }

        private void scheduler1_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                //scheduler1.DeleteEvent
                //scheduler1.AddEvent
                //scheduler1.Events

                //scheduler1.SelectedDate = DateTime.Now;
                //scheduler1.Mode = Mode.Day;
                //scheduler1.StartJourney = new TimeSpan(9, 0, 0);
                //scheduler1.EndJourney = new TimeSpan(19, 0, 0);
                //scheduler1.OnEventDoubleClick += scheduler1_OnEventDoubleClick;
                //scheduler1.OnScheduleDoubleClick += scheduler1_OnScheduleDoubleClick;
                //scheduler1.Loaded += scheduler1_Loaded;



                //scheduler1.SelectedDate = new DateTime(2013, 05, 27);
                //scheduler1.StartJourney = new TimeSpan(9, 0, 0);
                //scheduler1.EndJourney = new TimeSpan(19, 0, 0);
                //scheduler1.AddEvent(new Event() { Subject = "Dev meeting", Color = Brushes.LightGreen, Start = new DateTime(2013, 05, 29, 15, 30, 00), End = new DateTime(2013, 05, 29, 15, 45, 00) });
                //scheduler1.AddEvent(new Event() { Subject = "F1 Monaco", Color = Brushes.LightGreen, Start = new DateTime(2013, 05, 30, 14, 00, 00), End = new DateTime(2013, 05, 30, 15, 45, 00) });
                //scheduler1.AddEvent(new Event() { Subject = "Dinner with Paquito", Color = Brushes.LightGreen, Start = new DateTime(2013, 06, 1, 8, 00, 00), End = new DateTime(2013, 06, 1, 17, 00, 00) });
                //scheduler1.AddEvent(new Event() { Subject = "Call RRHH", Color = Brushes.LightBlue, Start = new DateTime(2013, 06, 1, 13, 00, 00), End = new DateTime(2013, 06, 1, 19, 00, 00) });

                //scheduler1.AddEvent(new Event() { Subject = "Oscar Holidays", Color = Brushes.Yellow, Start = new DateTime(2013, 5, 30, 08, 00, 00), End = new DateTime(2013, 06, 2, 19, 00, 00) });
                //scheduler1.AddEvent(new Event() { Subject = "Patri Holidays", Color = Brushes.Green, Start = new DateTime(2013, 5, 16, 08, 00, 00), End = new DateTime(2013, 06, 1, 19, 00, 00) });

                //scheduler1.OnEventDoubleClick += scheduler1_OnEventDoubleClick;
                //scheduler1.OnScheduleDoubleClick += scheduler1_OnScheduleDoubleClick;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        void scheduler1_OnScheduleDoubleClick(object sender, DateTime e)
        {
            Console.WriteLine(e.ToShortDateString() + ((FrameworkElement)sender).Name);
        }

        void scheduler1_OnEventDoubleClick(object sender, Event e)
        {
            Console.WriteLine(e.Subject);
        }

        private void prevBtn_Click(object sender, RoutedEventArgs e)
        {
            scheduler1.PrevPage();
        }

        private void nextBtn_Click(object sender, RoutedEventArgs e)
        {
            scheduler1.NextPage();
        }

        private void modeMonthBtn_Click(object sender, RoutedEventArgs e)
        {
            scheduler1.Mode = Mode.Month;
        }

        private void modeWeekBtn_Click(object sender, RoutedEventArgs e)
        {
            scheduler1.Mode = Mode.Week;
        }

        private void modeDayBtn_Click(object sender, RoutedEventArgs e)
        {
            scheduler1.Mode = Mode.Day;
        }
    }
}
