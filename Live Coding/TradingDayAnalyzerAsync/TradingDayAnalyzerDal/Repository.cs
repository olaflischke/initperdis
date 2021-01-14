using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace TradingDayAnalyzerDal
{
    public class Repository
    {


        public Repository(string url)
        {
            //this.TradingDays = GetDataByLinq(url);
            this.Url = url;
        }

        public async Task<List<TradingDay>> GetDataAsync()
        {
            //Thread.Sleep(3000);
            return await Task.Run(() => GetDataByLinq());
        }

        public List<TradingDay> GetDataByLinq()
        {
            List<TradingDay> days = new List<TradingDay>();

            XDocument document =  XDocument.Load(this.Url);

            var q = from nd in document.Root.Descendants()//.AsParallel()
                    where nd.Name.LocalName == "Cube" && nd.Attributes().Count() == 1
                    // Projektion auf Ergebnismenge
                    select new TradingDay(nd); // { Date = Convert.ToDateTime(nd.Attribute("time").Value) };

            //foreach (var item in q)
            //{
            //    TradingDay day = new TradingDay() { Date = Convert.ToDateTime(item.Attribute("time").Value)};
            //    days.Add(day);
            //}

            // Query wird bei Zugriff auf die Ergebnismenge ausgeführt.
            days = q.ToList();

            return days;

        }

        //[Obsolete("Use GetDataByLinq instead.")]
        //private List<TradingDay> GetData(string url)
        //{
        //    List<TradingDay> days = new List<TradingDay>();

        //    XmlReader reader = XmlReader.Create(url);

        //    TradingDay day = null;

        //    while (reader.Read())
        //    {
        //        if (reader.Name == "Cube" && reader.AttributeCount == 1)
        //        {
        //            day = new TradingDay() { Date = Convert.ToDateTime(reader.GetAttribute("time")) };
        //            days.Add(day);
        //        }
        //        if (reader.Name == "Cube" && reader.AttributeCount == 2)
        //        {
        //            ExchangeRate rate = new ExchangeRate() { Currency = reader["currency"], EuroRate = Convert.ToDouble(reader["rate"]) };
        //            day?.ExchangeRates?.Add(rate);
        //        }
        //    }

        //    return days;
        //}

        public List<TradingDay> TradingDays { get; set; }

        public string Url { get; set; }
    }
}
