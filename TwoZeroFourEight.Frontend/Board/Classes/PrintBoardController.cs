using TwoZeroFourEight.Frontend.Board.Interfaces;
using TwoZeroFourEight.Frontend.State.Interfaces;

namespace TwoZeroFourEight.Frontend.Board.Classes
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
        public void Print(int[,] array)
        {
            bool emptyArray = array.Cast<int>().All(tile => tile == StaticData.emptySpot);

            if (emptyArray)
            {
                _printResultController.Print();
                _printPressAnyButtonService.Print();
            }


            else
            {
                _printBoardService.Print(array);
            }

        }
    }

}

