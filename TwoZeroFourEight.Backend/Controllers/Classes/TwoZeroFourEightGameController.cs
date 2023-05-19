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
            StaticData.size = size;
            StaticData.numberOfSpots = size * size;

            bool canPlay = StaticData.size > StaticData.minSize || StaticData.maxSize > StaticData.size;

            if (canPlay)
            {
				int[,] array = _initializeBoardService.InitializeBoard();

				_gameController.Start(array);
			}
            
        }

    }
}
