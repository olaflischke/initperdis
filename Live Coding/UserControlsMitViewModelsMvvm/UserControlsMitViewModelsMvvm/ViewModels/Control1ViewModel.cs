using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Threading;

namespace UserControlsMitViewModelsMvvm.ViewModels
{
    public class Control1ViewModel : ViewModelBase //IViewModel
    {
        //public event PropertyChangedEventHandler PropertyChanged;

        DispatcherTimer timer;

        public Control1ViewModel()
        {
            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromMilliseconds(1000);
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            this.Zahl++;
        }

        private int _zahl;

        public int Zahl
        {
            get { return _zahl; }
            set
            {
                _zahl = value;
                OnPropertyChanged();

            }
        }

        //private void OnPropertyChanged([CallerMemberName] string name = "")
        //{
        //    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        //}
    }
}
