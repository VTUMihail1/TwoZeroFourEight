using NUnit.Framework;
using TwoZeroFourEight.Backend.Services.Classes;
using TwoZeroFourEight.Backend.Services.Interfaces;

namespace TwoZeroFourEight.UnitTests.BackendTests.ServicesTests
{
    [TestFixture]
    public class YouWInServiceTests
    {
        private IYouWinService youWinService;

        [SetUp]
        public void SetUp()
        {
            youWinService = new YouWinService();
        }


        [Test]
        public void YouWin_NoMaxTileInTheArray_ReturnsFalse()
        {
            int[,] array = new int[4, 4]
            {
                {0,0,0,0 },
                {2,2,2,2 },
                {2,2,2,2 },
                {2,2,2,2 }
            };

            bool result = youWinService.YouWin(array);

            Assert.That(result, Is.False);
        }


        [Test]
        public void YouWin_MaxTileInTheArray_ReturnsTrue()
        {
            int[,] array = new int[4, 4]
            {
                {2048,2,2,2 },
                {2,2,2,2 },
                {2,2,2,2 },
                {2,2,2,2 }
            };

            bool result = youWinService.YouWin(array);

            Assert.That(result, Is.True);
        }
    }
}
