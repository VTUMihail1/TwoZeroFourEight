using TwoZeroFourEight.UserInterfaces.Interfaces;

namespace TwoZeroFourEight.UserInterfaces.Classes
{
    public class UIManager : IUIManager
    {
        private readonly IPrintHeading _heading;
        private readonly IPrintBoardManager _boardManager;
        private readonly IPrintMenu _menu;

        public UIManager(IPrintHeading heading, IPrintBoardManager boardManager, IPrintMenu menu)
        {
            _heading = heading;
            _boardManager = boardManager;
            _menu = menu;
        }
        public void PrintSetup(int[,] array)
        {
            int size = array.GetLength(0);
            _heading.PrintGameHeading(size);
            _boardManager.DisplayPrint(array);
            _menu.PrintGameMenu();
        }
    }
}


