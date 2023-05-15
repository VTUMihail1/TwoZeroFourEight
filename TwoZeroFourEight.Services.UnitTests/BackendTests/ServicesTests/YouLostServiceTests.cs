using NUnit.Framework;
using TwoZeroFourEight.Backend.Services.Classes;
using TwoZeroFourEight.Backend.Services.Interfaces;

namespace TwoZeroFourEight.UnitTests.BackendTests.ServicesTests
{
    [TestFixture]
    public class YouLostServiceTests
    {
        private IYouLostService youLostService;
        [SetUp]
        public void SetUp()
        {
            youLostService = new YouLostService();
        }
        [Test]
        public void YouLost_ArrayIsntFull_ReturnsFalse()
        {
            int[,] array = new int[4, 4]
            {
                {0,0,0,0 },
                {2,2,2,2 },
                {2,2,2,2 },
                {2,2,2,2 }
            };

            bool result = youLostService.YouLost(array);

            Assert.That(result, Is.False);
        }
        [Test]
        public void YouLost_ArrayIsFullButMovesAreAvailable_ReturnsFalse()
        {
            int[,] array = new int[4, 4]
            {
                {2,2,2,2 },
                {2,2,2,2 },
                {2,2,2,2 },
                {2,2,2,2 }
            };

            bool result = youLostService.YouLost(array);

            Assert.That(result, Is.False);
        }
        [Test]
        public void YouLost_ArrayIsFullAndNoMovesAreAvailable_ReturnsTrue()
        {
            int[,] array = new int[4, 4]
            {
                {2,4,2,4 },
                {4,2,4,2 },
                {2,4,2,4 },
                {4,2,4,2 }
            };

            bool result = youLostService.YouLost(array);

            Assert.That(result, Is.True);
        }
    }
}
