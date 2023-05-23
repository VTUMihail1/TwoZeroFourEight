using Moq;
using NUnit.Framework;
using TwoZeroFourEight.Frontend.Board.Classes;
using TwoZeroFourEight.Frontend.Board.Interfaces;
using TwoZeroFourEight.Frontend.State.Interfaces;

namespace TwoZeroFourEight.UnitTests.FrontendTests.ControllersTests
{
    [TestFixture]
    public class PrintBoardControllerTests
    {
        private Mock<IPrintBoardService> printBoardService;

        private Mock<IPrintPressAnyButtonService> printPressAnyButtonService;

        private Mock<IPrintResultController> printResultController;

        private IPrintBoardController printBoardController;

        [SetUp]
        public void SetUp()
        {
            printResultController = new Mock<IPrintResultController>();

            printBoardService = new Mock<IPrintBoardService>();

            printPressAnyButtonService = new Mock<IPrintPressAnyButtonService>();

            printBoardController = new PrintBoardController(printBoardService.Object, printPressAnyButtonService.Object, printResultController.Object);
        }


        [Test]
        public void PrintGameBoard_ArrayIsEmpty_PrintsTheBoard()
        {
            int[,] array = new int[4, 4]
            {
                {0,0,0,0 },
                {0,0,0,0 },
                {0,0,0,0 },
                {0,0,0,0 }
            };

            printBoardController.PrintGameBoard(array);

            printResultController.Verify(x => x.PrintGameOverScreen(), Times.Exactly(1));
            printPressAnyButtonService.Verify(x => x.PrintPressAnyButton(), Times.Exactly(1));
        }


        [Test]
        public void PrintGameBoard_ArrayIsNotEmpty_PrintsTheBoard()
        {
            int[,] array = new int[4, 4]
            {
                {2,2,2,2 },
                {0,0,0,0 },
                {0,0,0,0 },
                {0,0,0,0 }
            };

            printBoardController.PrintGameBoard(array);

            printBoardService.Verify(x => x.PrintBoard(array), Times.Exactly(1));
        }
    }
}
