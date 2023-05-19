using Moq;
using NUnit.Framework;
using TwoZeroFourEight.Frontend.Controllers.Classes;
using TwoZeroFourEight.Frontend.Controllers.Interfaces;
using TwoZeroFourEight.Frontend.Services.Interfaces;

namespace TwoZeroFourEight.UnitTests.FrontendTests.ControllersTests
{
    [TestFixture]
    public class PrintResultControllerTests
    {
        private Mock<ILoggerService> loggerService;

        private Mock<IPrintHeadingService> printHeadingService;

        private Mock<IPrintStateController> printStateController;

        private IPrintResultController printResultController;

        [SetUp]
        public void SetUp()
        {
            printStateController = new Mock<IPrintStateController>();

            printHeadingService = new Mock<IPrintHeadingService>();

            loggerService = new Mock<ILoggerService>();

            printResultController = new PrintResultController(printStateController.Object, loggerService.Object, printHeadingService.Object);
        }


        [Test]
        public void PrintGameOverScreen_StringIsEmpty_DoesntWriteTheResultInTheConsole()
        {
            printStateController.Setup(x => x.PrintGameResult()).Returns("");

            printResultController.PrintGameOverScreen();

            printHeadingService.Verify(x => x.PrintHeading(), Times.Exactly(0));
        }


        [Test]
        public void PrintGameOverScreen_StringIsNotEmpty_WritesTheResultInTheConsole()
        {
            printStateController.Setup(x => x.PrintGameResult()).Returns("message");

            printResultController.PrintGameOverScreen();

            printHeadingService.Verify(x => x.PrintHeading(), Times.Exactly(1));
        }
    }
}
