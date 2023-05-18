using TwoZeroFourEight.Backend.Services.Interfaces;
using TwoZeroFourEight.Backend.Controllers.Interfaces;

namespace TwoZeroFourEight.Backend.Controllers.Classes
{
    public class GameMovesController : IGameMovesController
    {

        private IGameMovesService _gameMovesService;

        public GameMovesController(IGameMovesService gameMovesServices)
        {
            _gameMovesService = gameMovesServices;
        }

        public void InputMoves(ConsoleKeyInfo key, int[,] array)
        {
			bool moveUp = key.Key == ConsoleKey.UpArrow;
			bool moveLeft = key.Key == ConsoleKey.LeftArrow;
			bool moveDown = key.Key == ConsoleKey.DownArrow;
            bool moveRight = key.Key == ConsoleKey.RightArrow;

			if (moveRight)
            {
                _gameMovesService.MoveRight(array);
            }

            else if (moveLeft)
            {
                _gameMovesService.MoveLeft(array);
            }

            else if (moveUp)
            {
                _gameMovesService.MoveUp(array);
            }

            else if (moveDown)
            {
                _gameMovesService.MoveDown(array);
            }


        }

    }
}

