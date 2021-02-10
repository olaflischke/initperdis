using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;
using TradingDayAnalyzerDal;

namespace TradingDayDalUnitTests
{
    [TestClass]
    public class TestRpository
    {

        string url;

        [TestInitialize]
        public void BeforeEachTest()
        {
            url = "https://www.ecb.europa.eu/stats/eurofxref/eurofxref-hist-90d.xml";
        }

        [TestMethod]
        public void IsRepositoryInitializing()
        {
            Repository repository = new Repository(url);

            Console.WriteLine($"{repository.TradingDays.FirstOrDefault().Date:g}: {repository.TradingDays.FirstOrDefault().ExchangeRates.FirstOrDefault().Currency} - {repository.TradingDays.FirstOrDefault().ExchangeRates.FirstOrDefault().EuroRate}");

            // Output auch in Unit Tests
            //foreach (TradingDay item in repository.TradingDays)
            //{
            //    Console.WriteLine($"{item.Date:g}");
            //}

            Assert.AreEqual(62, repository.TradingDays.Count);
        }
    }
}
