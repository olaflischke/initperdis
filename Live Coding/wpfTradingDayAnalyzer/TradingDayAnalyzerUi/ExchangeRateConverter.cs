using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Windows.Data;

namespace TradingDayAnalyzerUi
{
    public class ExchangeRateConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            if (Double.TryParse(values[0]?.ToString(), out double betrag) && double.TryParse(values[1]?.ToString(), out double rate))
            {
                betrag = System.Convert.ToDouble(values[0], culture.NumberFormat);
                rate = System.Convert.ToDouble(values[1], culture.NumberFormat);
                return (betrag / rate).ToString();
            }

            return "";

        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
