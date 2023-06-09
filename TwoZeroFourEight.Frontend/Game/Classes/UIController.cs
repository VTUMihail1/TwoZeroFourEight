﻿using TwoZeroFourEight.Frontend.Board.Interfaces;
using TwoZeroFourEight.Frontend.Controllers.Interfaces;
using TwoZeroFourEight.Frontend.Heading.Interfaces;
using TwoZeroFourEight.Frontend.Menu.Interfaces;

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


        public void Print(int[,] array)
        {
            _printHeadingService.Print();
            _printBoardController.Print(array);
            _printMenuService.Print();
        }

    }
}


