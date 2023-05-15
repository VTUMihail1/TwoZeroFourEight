using TwoZeroFourEight.Backend.Controllers.Interfaces;

namespace TwoZeroFourEight.Backend.Controllers.Classes
{
    public class ServicesController : IServicesController
    {
        private readonly IGameMovesController _gameMovesController;
        private readonly IStateController _stateController;
        public ServicesController(IGameMovesController gameMovesController, IStateController stateController)
        {
            _gameMovesController = gameMovesController;
            _stateController = stateController;
        }
        public void RunGame(int[,] array)
        {
            var key = Console.ReadKey();
            _gameMovesController.InputMoves(key, array);
            _stateController.InputStates(key, array);

        }
    }
}

