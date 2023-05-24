using Moq;
using NUnit.Framework;
using TwoZeroFourEight.Frontend.State.Classes;
using TwoZeroFourEight.Frontend.State.Interfaces;

namespace TwoZeroFourEight.UnitTests.FrontendTests.ControllersTests
{
    [TestFixture]
    public class PrintResultControllerTests
    {

        private Mock<IPrintRestartService> printRestartService;

        private Mock<IPrintStateController> printStateController;

        private IPrintResultController printResultController;

        [SetUp]
        public void SetUp()
        {
            printStateController = new Mock<IPrintStateController>();

            printRestartService = new Mock<IPrintRestartService>();

            printResultController = new PrintResultController(printRestartService.Object, printStateController.Object);
        }


        [Test]
        public void Print_StringIsEmpty_DoesntWriteTheResultInTheConsole()
        {
            printStateController.Setup(x => x.Print()).Returns("");

            printResultController.Print();

            printRestartService.Verify(x => x.Restart(""), Times.Exactly(0));
        }


        [Test]
        public void Print_StringIsNotEmpty_WritesTheResultInTheConsole()
        {
            printStateController.Setup(x => x.Print()).Returns("message");

            printResultController.Print();

            printRestartService.Verify(x => x.Restart("message"), Times.Exactly(1));
        }
    }
}
