﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;

namespace Desktop.ViewModel
{
    public class AngebotViewModel: INotifyPropertyChanged
    {
        #region DateTime.Now
        public event PropertyChangedEventHandler PropertyChanged;

        private DateTime _now;

        public AngebotViewModel()
        {

            _now = DateTime.Now;

            DispatcherTimer timer = new DispatcherTimer();

            timer.Interval = TimeSpan.FromMilliseconds(100);

            timer.Tick += new EventHandler(timer_Tick);

            timer.Start();

        }

        public DateTime Now
        {

            get { return _now; }

            private set
            {

                _now = value;

                if (PropertyChanged != null)

                    PropertyChanged(this, new PropertyChangedEventArgs("Now"));

            }

        }

        void timer_Tick(object sender, EventArgs e)
        {

            Now = DateTime.Now;

        }
        #endregion
        
    }
}
