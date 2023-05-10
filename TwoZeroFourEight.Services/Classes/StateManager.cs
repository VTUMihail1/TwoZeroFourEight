using TwoZeroFourEight.Services.Interfaces;

namespace TwoZeroFourEight.Services.Classes
{
    public class StateManager : IStateManager
    {
        private readonly IResultManager _resultManager;
        private readonly IRestartGameService _restart;
        private readonly IAddRandomService _add;

        public StateManager(IResultManager resultManager, IRestartGameService restart, IAddRandomService add)
        {
            _restart = restart;
            _add = add;
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
                _add.AddRandom(array);
            }

        }
    }
}

