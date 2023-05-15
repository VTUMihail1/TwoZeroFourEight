using TwoZeroFourEight.Backend.Services.Interfaces;
using TwoZeroFourEight.Backend.Controllers.Interfaces;
using TwoZeroFourEight.Backend.Services.Classes;

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
            if (key.Key == ConsoleKey.R || _resultController.Result(array))
            {
                _restartGameService.Restart(array);
            }
            else if (key.Key == ConsoleKey.Escape)
            {
                Environment.Exit(1);
            }
            else if (key.Key >= ConsoleKey.LeftArrow && key.Key <= ConsoleKey.DownArrow)
            {
                _addController.Add(array);
            }
        }
    }
}

