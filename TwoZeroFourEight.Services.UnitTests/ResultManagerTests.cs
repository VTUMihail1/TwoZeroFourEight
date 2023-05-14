using NUnit.Framework;
using TwoZeroFourEight.Services.Classes;
using TwoZeroFourEight.Services.Interfaces;

namespace TwoZeroFourEight.Services.UnitTests
{
    [TestFixture]
    public class ResultManagerTests
    {
        private IResultManager resultManager;
        [SetUp]
        public void Setup() 
        {
            IYouWonService youWon = new YouWonService();
            IYouLostService youLost = new YouLostService();
            resultManager = new ResultManager(youWon,youLost);
        }
        [Test]
        public void ManageResult_DidntWinAndDidntLose_ReturnsFalse()
        {
            int[,] array = new int[4, 4]
            {
                {0,0,0,0 },
                {2,2,2,2 },
                {2,2,2,2 },
                {2,2,2,2 }
            };

            bool result = resultManager.ManageResult(array);

            Assert.That(result, Is.False);
        }
        [Test]
        public void ManageResult_WonTheGame_ReturnsTrue()
        {
            int[,] array = new int[4, 4]
            {
                {2048,0,0,0 },
                {2,2,2,2 },
                {2,2,2,2 },
                {2,2,2,2 }
            };

            bool result = resultManager.ManageResult(array);

            Assert.That(result, Is.True);
        }
        [Test]
        public void ManageResult_LostTheGame_ReturnsTrue()
        {
            int[,] array = new int[4, 4]
            {
                {2,4,2,4 },
                {4,2,4,2 },
                {2,4,2,4 },
                {4,2,4,2 }
            };

            bool result = resultManager.ManageResult(array);

            Assert.That(result, Is.True);
        }
    }
}
