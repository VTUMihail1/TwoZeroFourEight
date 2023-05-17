using Moq;
using NUnit.Framework;
using TwoZeroFourEight.Backend.Controllers.Classes;
using TwoZeroFourEight.Backend.Controllers.Interfaces;
using TwoZeroFourEight.Backend.Services.Interfaces;

namespace TwoZeroFourEight.UnitTests.BackendTests.ControllersTests
{
    [TestFixture]
    public class ResultControllerTests
    {
        private Mock<IYouWinService> youWinService;

        private Mock<IYouLostService> youLostService;

        private IResultController resultController;

        [SetUp]
        public void Setup()
        {
            youWinService = new Mock<IYouWinService>();

            youLostService = new Mock<IYouLostService>();

            resultController = new ResultController(youWinService.Object, youLostService.Object);
        }


        [Test]
        public void Result_DidntWinAndDidntLose_ReturnsFalse()
        {
            youWinService.Setup(x => x.YouWin(It.IsAny<int[,]>())).Returns(false);
            youLostService.Setup(x => x.YouLost(It.IsAny<int[,]>())).Returns(false);

            bool result = resultController.Result(It.IsAny<int[,]>());

            Assert.That(result, Is.False);
        }


        [Test]
        public void Result_WonTheGame_ReturnsTrue()
        {
            youWinService.Setup(x => x.YouWin(It.IsAny<int[,]>())).Returns(true);
            youLostService.Setup(x => x.YouLost(It.IsAny<int[,]>())).Returns(false);

            bool result = resultController.Result(It.IsAny<int[,]>());

            Assert.That(result, Is.True);
        }


        [Test]
        public void Result_LostTheGame_ReturnsTrue()
        {
            youWinService.Setup(x => x.YouWin(It.IsAny<int[,]>())).Returns(false);
            youLostService.Setup(x => x.YouLost(It.IsAny<int[,]>())).Returns(true);

            bool result = resultController.Result(It.IsAny<int[,]>());

            Assert.That(result, Is.True);
        }
    }
}
