using NUnit.Framework;
using TwoZeroFourEight.Services.Classes;
using TwoZeroFourEight.Services.Interfaces;

namespace TwoZeroFourEight.UnitTests.Tests
{
    [TestFixture]
    public class YouLostServiceTests
    {
        private IYouLostService service;
        [SetUp]
        public void SetUp()
        {
            service = new YouLostService();
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

            bool result = service.YouLost(array);

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

            bool result = service.YouLost(array);

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

            bool result = service.YouLost(array);

            Assert.That(result, Is.True);
        }
    }
}
