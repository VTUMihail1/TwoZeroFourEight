using TwoZeroFourEight.Services.Interfaces;

namespace TwoZeroFourEight.Services.Classes
{
	public class ServicesManager : IServicesManager
    {
        private readonly IMovesManager _movesManager;
        private readonly IStateManager _stateManager;
        public ServicesManager(IMovesManager movesManager, IStateManager stateManager)
        {
            _movesManager = movesManager;
            _stateManager = stateManager;
        }
        public void Run(int[,] array)
        {
            var key = Console.ReadKey();
            _movesManager.CheckMoves(key, array);
            _stateManager.GameServices(key, array);

        }
    }
}

