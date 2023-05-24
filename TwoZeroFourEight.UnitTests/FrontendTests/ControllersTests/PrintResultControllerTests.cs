using Moq;
using NUnit.Framework;
using TwoZeroFourEight.Frontend.State.Classes;
using TwoZeroFourEight.Frontend.State.Interfaces;

namespace TwoZeroFourEight.UnitTests.FrontendTests.ControllersTests
{
    [TestFixture]
    public class PrintResultControllerTests
    {

        private Mock<IPrintRestart> printRestart;

        private Mock<IPrintStateController> printStateController;

        private IPrintResultController printResultController;

        [SetUp]
        public void SetUp()
        {
            printStateController = new Mock<IPrintStateController>();

            printRestart = new Mock<IPrintRestart>();

            printResultController = new PrintResultController(printRestart.Object, printStateController.Object);
        }


        [Test]
        public void PrintGameOverScreen_StringIsEmpty_DoesntWriteTheResultInTheConsole()
        {
            printStateController.Setup(x => x.PrintGameResult()).Returns("");

            printResultController.PrintGameOverScreen();

            printRestart.Verify(x => x.Restart(""), Times.Exactly(0));
        }


        [Test]
        public void PrintGameOverScreen_StringIsNotEmpty_WritesTheResultInTheConsole()
        {
            printStateController.Setup(x => x.PrintGameResult()).Returns("message");

            printResultController.PrintGameOverScreen();

            printRestart.Verify(x => x.Restart("message"), Times.Exactly(1));
        }
    }
}
