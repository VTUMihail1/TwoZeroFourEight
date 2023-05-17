using TwoZeroFourEight.Frontend.Controllers.Interfaces;
using TwoZeroFourEight.Frontend.Services.Interfaces;

namespace TwoZeroFourEight.Frontend.Controllers.Classes
{
    public class UIController : IUIController
    {
        private readonly IPrintHeadingService _printHeadingService;

        private readonly IPrintBoardController _printBoardController;

        private readonly IPrintMenuService _printMenuService;

        public UIController(IPrintHeadingService printHeadingService, IPrintBoardController printBoardController, IPrintMenuService printMenuService)
        {
            _printHeadingService = printHeadingService;

            _printBoardController = printBoardController;

            _printMenuService = printMenuService;
        }


        public void PrintGame(int[,] array)
        {
            int size = array.GetLength(0);

            _printHeadingService.PrintHeading(size);

            _printBoardController.PrintGameBoard(array);

            _printMenuService.PrintMenu();
        }

    }
}


