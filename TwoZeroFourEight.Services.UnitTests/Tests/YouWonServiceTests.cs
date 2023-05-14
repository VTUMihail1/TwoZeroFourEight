using NUnit.Framework;
using TwoZeroFourEight.Services.Classes;
using TwoZeroFourEight.Services.Interfaces;

namespace TwoZeroFourEight.UnitTests.Tests
{
    [TestFixture]
    public class YouWonServiceTests
    {
        private IYouWonService service;
        [SetUp]
        public void SetUp()
        {
            service = new YouWonService();
        }
        [Test]
        public void YouWon_NoMaxTileInTheArray_ReturnsFalse()
        {
            int[,] array = new int[4, 4]
            {
                {0,0,0,0 },
                {2,2,2,2 },
                {2,2,2,2 },
                {2,2,2,2 }
            };

            bool result = service.YouWon(array);

            Assert.That(result, Is.False);
        }
        [Test]
        public void YouLost_MaxTileInTheArray_ReturnsTrue()
        {
            int[,] array = new int[4, 4]
            {
                {2048,2,2,2 },
                {2,2,2,2 },
                {2,2,2,2 },
                {2,2,2,2 }
            };

            bool result = service.YouWon(array);

            Assert.That(result, Is.True);
        }
    }
}
