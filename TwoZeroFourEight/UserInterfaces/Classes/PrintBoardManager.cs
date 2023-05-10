using TwoZeroFourEight.UserInterfaces.Interfaces;

namespace TwoZeroFourEight.UserInterface.Classes
{
    public class PrintBoardManager : IPrintBoardManager
    {
        private readonly IPrintBoard _board;
        private readonly IPrintPressAnyButton _anybutton;
        private readonly IPrintResultManager _resultManager;
        public PrintBoardManager(IPrintResultManager resultManager, IPrintBoard board, IPrintPressAnyButton anybutton)
        {
            _anybutton = anybutton;
            _board = board;
            _resultManager = resultManager;
        }
        public void DisplayPrint(int[,] array)
        {
            if (!array.Cast<int>().All(tile => tile == 0))
            {
                _board.PrintGameBoard(array);
            }
            else
            {
                int size = array.GetLength(0);
                _resultManager.GameOverPrint(size);
                _anybutton.PressAnyButtonPrint(size);
            }
        }

    }

}

