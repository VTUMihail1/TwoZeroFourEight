using Moq;
using NUnit.Framework;
using TwoZeroFourEight.Frontend.Score.Interfaces;
using TwoZeroFourEight.Frontend.State.Classes;
using TwoZeroFourEight.Frontend.State.Interfaces;

namespace TwoZeroFourEight.UnitTests.FrontendTests.ControllersTests
{
    [TestFixture]
    public class PrintStateControllerTests
    {
        private Mock<IPrintStateService> printStateService;

        private Mock<IScoreService> scoreService;

        private Mock<IPrintResultStateService> printResultState;

        private IPrintStateController printStateController;

        [SetUp]
        public void Setup()
        {
            printStateService = new Mock<IPrintStateService>();

            printResultState = new Mock<IPrintResultStateService>();

            scoreService = new Mock<IScoreService>();

            printStateController = new PrintStateController(printResultState.Object, scoreService.Object, printStateService.Object);
        }


        [Test]
        public void Print_BestScoreIsZero_ReturnsEmptyString()
        {
            scoreService.Setup(x => x.ManageBestScore).Returns(0);

            string result = printStateController.Print();

            Assert.That(result.Length, Is.EqualTo(0));
        }


        [Test]
        public void Print_BestScoreIsHigherThanZero_ReturnsNonEmptyString()
        {
            scoreService.Setup(x => x.ManageBestScore).Returns(2);
            printResultState.Setup(x => x.Print()).Returns("message");

            string result = printStateController.Print();

            Assert.That(result.Length, Is.EqualTo(7));
        }
    }
}
