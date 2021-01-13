using System.ComponentModel.DataAnnotations.Schema;

namespace TradingDayAnalyzerDal
{
    [Table("ExchangeRates")]
    public class ExchangeRate
    {
        public int Id { get; set; }
        public TradingDay TradingDay { get; set; }
        public string Currency { get; set; }
        public double EuroRate { get; set; }
    }
}