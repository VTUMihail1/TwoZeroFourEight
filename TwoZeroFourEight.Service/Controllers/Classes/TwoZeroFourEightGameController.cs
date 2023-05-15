using TwoZeroFourEight.Backend.Controllers.Interfaces;
using TwoZeroFourEight.Backend.Services.Classes;
using TwoZeroFourEight.Backend.Services.Interfaces;

namespace TwoZeroFourEight.Backend.Controllers.Classes
{
    public class TwoZeroFourEightGameController : ITwoZeroFourEightGameController
    {
        private readonly IGameController _gameController;
        private readonly IInitializeBoardService _initializeBoardService;
        public TwoZeroFourEightGameController(IGameController gameController, IInitializeBoardService initializeBoardService)
        {
            _gameController = gameController;
            _initializeBoardService = initializeBoardService;
        }
        public void Play(int size)
        {
            if (size < 4 || size > 7)
            {
                return;
            }
            int[,] array = _initializeBoardService.InitializeBoard(size);
            _gameController.Start(array);
        }
    }
}
