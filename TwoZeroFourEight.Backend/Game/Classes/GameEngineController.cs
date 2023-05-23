using TwoZeroFourEight.Backend.Controllers.Interfaces;
using TwoZeroFourEight.Backend.Moves.Interfaces;
using TwoZeroFourEight.Backend.State.Interfaces;

namespace TwoZeroFourEight.Backend.Controllers.Classes
{
    public class GameEngineController : IGameEngineController
    {

        private readonly IGameMovesController _gameMovesController;

        private readonly IStateController _stateController;

        public GameEngineController(IGameMovesController gameMovesController, IStateController stateController)
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

