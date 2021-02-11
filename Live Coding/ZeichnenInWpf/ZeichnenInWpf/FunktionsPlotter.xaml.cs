using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Linq;

namespace ZeichnenInWpf
{
    /// <summary>
    /// Interaktionslogik für FunktionsPlotter.xaml
    /// </summary>
    public partial class FunktionsPlotter : Window
    {
        CultureInfo ciDE = new CultureInfo("de-DE");

        public FunktionsPlotter()
        {
            InitializeComponent();
        }

        private void btnPlot_Click(object sender, RoutedEventArgs e)
        {
            double a3 = Convert.ToDouble(txtA3.Text, ciDE);
            double a2 = Convert.ToDouble(txtA2.Text, ciDE);
            double a1 = Convert.ToDouble(txtA1.Text, ciDE);
            double a0 = Convert.ToDouble(txtA0.Text, ciDE);

            double x = -10;

            double xAlt = -10;
            double yAlt = a3 * Math.Pow(x, 3) + a2 * Math.Pow(x, 2) + a1 * x + a0;

            for (int i = 1; i < 100; i++)
            {
                double y = a3 * Math.Pow(x, 3) + a2 * Math.Pow(x, 2) + a1 * x + a0;

                // Line instanzieren
                Line line = new Line()
                {
                    X1 = xAlt,
                    Y1 = cvLeinwand.Height - yAlt,
                    X2 = x,
                    Y2 = cvLeinwand.Height - y,
                    Stroke = Brushes.Black,
                    StrokeThickness = 1,
                    Visibility = Visibility.Visible
                };

                // Linie auf die Leinwand
                cvLeinwand.Children.Add(line);

                x += .2;

                xAlt = x;
                yAlt = y;
            }

        }
    }
}
