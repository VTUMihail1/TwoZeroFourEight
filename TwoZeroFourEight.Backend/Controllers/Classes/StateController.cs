using TwoZeroFourEight.Backend.Services.Interfaces;
using TwoZeroFourEight.Backend.Controllers.Interfaces;

namespace TwoZeroFourEight.Backend.Controllers.Classes
{
    public class StateController : IStateController
    {

        private readonly IAddRandomController _addController;

        private readonly IResultController _resultController;

        private readonly IRestartGameService _restartGameService;

        public StateController(IResultController resultController, IAddRandomController addController, IRestartGameService restartGameService)
        {
            _addController = addController;
            _resultController = resultController;
            _restartGameService = restartGameService;
        }

        public void InputStates(ConsoleKeyInfo key, int[,] array)
        {

            bool exit = key.Key == ConsoleKey.Escape;
            bool restart = key.Key == ConsoleKey.R || _resultController.Result(array);
            bool pressedArrowKey = key.Key >= ConsoleKey.LeftArrow && key.Key <= ConsoleKey.DownArrow;


			if (restart)
            {
                _restartGameService.Restart(array);
            }

            else if (exit)
            {
                Environment.Exit(0);
            }

            else if (pressedArrowKey)
            {
                _addController.Add(array);
            }

        }

    }
}

