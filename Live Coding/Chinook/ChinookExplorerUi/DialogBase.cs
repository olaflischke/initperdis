using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows;

namespace ChinookExplorerUi
{
    public class DialogBase : Window, INotifyPropertyChanged
    {
        public bool? Result
        {
            get { return (bool?)GetValue(ResultProperty); }
            set
            {
                SetValue(ResultProperty, value);
                this.DialogResult = true;
            }
        }

        public static readonly DependencyProperty ResultProperty =
            DependencyProperty.Register("Result", typeof(bool?), typeof(DialogBase), new PropertyMetadata(null));

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged([CallerMemberName] string name = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

    }
}
