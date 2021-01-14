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
using System.Windows.Navigation;
using System.Windows.Shapes;
using TradingDayAnalyzerDal;

namespace TradingDayAnalyzerUi
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }

        private async void Window_Loaded(object sender, RoutedEventArgs e)
        {
            string url = "https://www.ecb.europa.eu/stats/eurofxref/eurofxref-hist.xml";
            Repository repository = new Repository(url);
            repository.TradingDays = await repository.GetDataAsync();

            this.DataContext = repository;

        }
    }
}
