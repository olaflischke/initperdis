using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;
using System.Threading.Tasks;
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
        public async Task IsRepositoryInitializing()
        {
            Repository repository = new Repository(url);
            repository.TradingDays = await repository.GetDataAsync();

            Console.WriteLine($"{repository.TradingDays.FirstOrDefault().Date:g}: {repository.TradingDays.FirstOrDefault().ExchangeRates.FirstOrDefault().ToString()} - {repository.TradingDays.FirstOrDefault().ExchangeRates.FirstOrDefault().EuroRate}");

            // Output auch in Unit Tests
            //foreach (TradingDay item in repository.TradingDays)
            //{
            //    Console.WriteLine($"{item.Date:g}");
            //}

            Assert.AreEqual(62, repository.TradingDays.Count);
        }
    }
}
