using System;
using System.Collections.Generic;
using System.Text;

namespace TradingDayAnalyzerDal
{
    public static class Extensions
    {
        /// <summary>
        /// Prüft einen String auf numerische Auswertbarkeit.
        /// </summary>
        /// <param name="text">Der zu prüfende String.</param>
        /// <returns>True, wenn der String numerisch verwendbar ist.</returns>
        public static bool IsNumeric(this string text)
        {
            return double.TryParse(text, out double zahl);
        }


    }
}
