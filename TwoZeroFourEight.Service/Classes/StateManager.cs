using TwoZeroFourEight.Services.Interfaces;

namespace TwoZeroFourEight.Services.Classes
{
    public class StateManager : IStateManager
    {
        private readonly IResultManager _resultManager;
        private readonly IRestartGameService _restart;
        private readonly IAddRandomManager _addManager;

        public StateManager(IResultManager resultManager, IRestartGameService restart, IAddRandomManager addManager)
        {
            _restart = restart;
            _addManager = addManager;
            _resultManager = resultManager;
        }
        public void GameServices(ConsoleKeyInfo key, int[,] array)
        {
            if (key.Key == ConsoleKey.R || _resultManager.ManageResult(array))
            {
                _restart.RestartGame(array);
            }
            else if (key.Key == ConsoleKey.Escape)
            {
                Environment.Exit(1);
            }
            else if (key.Key >= ConsoleKey.LeftArrow && key.Key <= ConsoleKey.DownArrow)
            {
                _addManager.AddManage(array);
            }

        }
    }
}

