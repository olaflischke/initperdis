using EierfarmBl;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace EierfarmUiWpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ViewModel viewModel = new ViewModel();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            this.DataContext = viewModel;
        }

        private void btnNeueGans_Click(object sender, RoutedEventArgs e)
        {
            Gans gans = new Gans() { Name = "Neue Gans" };
            viewModel.Tiere.Add(gans);
            cbxTiere.SelectedItem = gans;
        }

        private void btnNeuesSchnabeltier_Click(object sender, RoutedEventArgs e)
        {

        }

    }
}
