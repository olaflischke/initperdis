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
    /// Interaktionslogik für Control2.xaml
    /// </summary>
    public partial class Control2 : UserControl
    {
        public Control2()
        {
            InitializeComponent();

            this.DataContext = new Control2ViewModel();
        }
    }
}
