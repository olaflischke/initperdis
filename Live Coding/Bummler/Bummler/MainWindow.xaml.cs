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

namespace BummlerApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Bummler bummler = new Bummler();

        public MainWindow()
        {
            InitializeComponent();


        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            string result = await bummler.BummelnAsync();
            lblBummel.Content = result;
        }

        private async void Button_Click_1(object sender, RoutedEventArgs e)
        {
            lblTroedel.Content = await bummler.TroedelnAsync();
        }
    }
}
