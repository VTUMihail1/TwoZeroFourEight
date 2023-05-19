using TwoZeroFourEight.Frontend.Controllers.Interfaces;
using TwoZeroFourEight.Frontend.Services.Interfaces;

namespace TwoZeroFourEight.Frontend.Controllers.Classes
{
    public class PrintBoardController : IPrintBoardController
    {

        private readonly IPrintBoardService _printBoardService;

        private readonly IPrintPressAnyButtonService _printPressAnyButtonService;

        private readonly IPrintResultController _printResultController;

        public PrintBoardController(IPrintBoardService printBoardService, IPrintPressAnyButtonService printPressAnyButtonService, IPrintResultController printResultController)
        {
            _printPressAnyButtonService = printPressAnyButtonService;
            _printBoardService = printBoardService;
            _printResultController = printResultController;
        }
        public void PrintGameBoard(int[,] array)
        {
            bool emptyArray = array.Cast<int>().All(tile => tile == StaticData.emptySpot);

			if (emptyArray)
            {
				_printResultController.PrintGameOverScreen();
				_printPressAnyButtonService.PrintPressAnyButton();
            }


            else
            {
                _printBoardService.PrintBoard(array);
			}

        }
    }

}

