using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using UserControlsMitViewModelsMvvm.ViewModels;

namespace UserControlsMitViewModelsMvvm.Views
{
    /// <summary>
    /// Interaktionslogik für Control1.xaml
    /// </summary>
    public partial class Control1 : UserControl
    {
        public Control1()
        {
            InitializeComponent();

            this.DataContext = new Control1ViewModel();
        }
    }
}
