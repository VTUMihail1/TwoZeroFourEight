using NUnit.Framework;
using TwoZeroFourEight.Frontend.Score.Classes;
using TwoZeroFourEight.Frontend.Score.Interfaces;

namespace TwoZeroFourEight.UnitTests.FrontendTests.ServicesTests
{
    [TestFixture]
    public class ScoreServiceTests
    {
        private IScoreService scoreService;

        [SetUp]
        public void Setup()
        {
            scoreService = new ScoreService();
        }


        [Test]
        public void ManageBestScore_ScoreIsLowerOrEqualToTheBestScore_BestScoreDoesntChange()
        {
            scoreService.ManageBestScore = 8;
            scoreService.ManageCurrentScore = 4;

            scoreService.ManageBestScore = scoreService.ManageCurrentScore;

            Assert.That(scoreService.ManageBestScore, Is.Not.EqualTo(scoreService.ManageCurrentScore));
        }


        [Test]
        public void ManageBestScore_ScoreIsHigherThanBestScore_SetsTheScoreAsTheBestScore()
        {
            scoreService.ManageBestScore = 4;
            scoreService.ManageCurrentScore = 8;

            scoreService.ManageBestScore = scoreService.ManageCurrentScore;

            Assert.That(scoreService.ManageBestScore, Is.EqualTo(scoreService.ManageCurrentScore));
        }
    }
}
