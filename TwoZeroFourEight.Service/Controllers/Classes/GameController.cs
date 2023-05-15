using TwoZeroFourEight.Backend.Controllers.Interfaces;
using TwoZeroFourEight.Frontend.Controllers.Interfaces;

namespace TwoZeroFourEight.Backend.Controllers.Classes
{
    public class GameController : IGameController
    {
        private readonly IGameEngineController _gameEngineController;
        private readonly IUIController _uiController;

        public GameController(IGameEngineController gameEngineController, IUIController uiController)
        {
            _gameEngineController = gameEngineController;
            _uiController = uiController;
        }
        public void Start(int[,] array)
        {
            while (true)
            {
                _uiController.PrintGame(array);
                _gameEngineController.RunGame(array);
            }
        }
    }
}

