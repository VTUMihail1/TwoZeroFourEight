using TwoZeroFourEight.Backend.Board.Interfaces;
using TwoZeroFourEight.Backend.Controllers.Interfaces;
using TwoZeroFourEight.Exceptions.Exceptions;

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

            
            try
            {
                bool cantPlay = StaticData.size < StaticData.minSize || StaticData.maxSize < StaticData.size;

                if (cantPlay)
                {
                    throw new InvalidSizeException("Invalid size");
                }

                int[,] array = _initializeBoardService.InitializeBoard();

                _gameController.Start(array);
            }

            catch(InvalidSizeException)
            {

            }
        }
    }
}
