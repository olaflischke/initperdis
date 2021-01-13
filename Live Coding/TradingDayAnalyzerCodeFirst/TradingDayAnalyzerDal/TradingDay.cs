using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;
using System.Linq;
using System.Xml.Linq;

namespace TradingDayAnalyzerDal
{
    [Table("TradingDays")]
    public class TradingDay
    {
        public TradingDay()
        {

        }

        public TradingDay(XElement tradingDayNode)
        {
            this.Date = Convert.ToDateTime(tradingDayNode.Attribute("time").Value);

            this.ExchangeRates = tradingDayNode.Descendants().Where(xe => xe.Name.LocalName == "Cube"
                                                                        && xe.Attributes().Any(at => at.Name == "currency")
                                                                        && xe.Attributes().Any(at => at.Name == "rate"))
                                                            .Select(xe => new ExchangeRate()
                                                            {
                                                                Currency = xe.Attribute("currency").Value,
                                                                EuroRate = Convert.ToDouble(xe.Attribute("rate").Value, new NumberFormatInfo() { NumberDecimalSeparator = "." }),
                                                                TradingDay = this
                                                            })
                                                            // Deferred Execution
                                                            .ToList();
        }

        public int Id { get; set; }

        public DateTime Date { get; set; }
        public List<ExchangeRate> ExchangeRates { get; set; }
    }
}