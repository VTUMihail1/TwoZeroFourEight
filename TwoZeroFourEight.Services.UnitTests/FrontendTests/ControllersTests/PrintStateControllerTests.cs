using Moq;
using NUnit.Framework;
using TwoZeroFourEight.Frontend.Controllers.Classes;
using TwoZeroFourEight.Frontend.Controllers.Interfaces;
using TwoZeroFourEight.Frontend.Services.Interfaces;

namespace TwoZeroFourEight.UnitTests.FrontendTests.ControllersTests
{
    [TestFixture]
    public class PrintStateControllerTests
    {
        private Mock<IPrintStateService> printStateService;
        private Mock<IScoreService> scoreService;
        private IPrintStateController printStateController;
        [SetUp]
        public void Setup()
        {
            printStateService = new Mock<IPrintStateService>();
            printStateService.Setup(x => x.YouLost(4)).Returns("YouLost");
            printStateService.Setup(x => x.YouWin(4)).Returns("YouWon");
            scoreService = new Mock<IScoreService>();
            printStateController = new PrintStateController(printStateService.Object, scoreService.Object);
        }
        [Test]
        public void PrintGameResult_BestScoreIsZero_ReturnsEmptyString()
        {
            scoreService.Setup(x => x.ManageBestScore).Returns(0);

            string result = printStateController.PrintGameResult(4);

            Assert.That(result.Length, Is.EqualTo(0));
        }
        [Test]
        public void PrintGameResult_BestScoreIsHigherThanZero_ReturnsNonEmptyString()
        {
            scoreService.Setup(x => x.ManageBestScore).Returns(2);

            string result = printStateController.PrintGameResult(4);

            Assert.That(result.Length, Is.AtLeast(1));
        }
    }
}
