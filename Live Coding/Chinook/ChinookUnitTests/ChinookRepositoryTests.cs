using ChinookDal;
using NUnit.Framework;

namespace ChinookUnitTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void GetArtistsByGenre()
        {
            ChinookRepository repo = new ChinookRepository();

            Assert.AreEqual(25, repo.GetArtistsByGenre().Count);
        }
    }
}