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
            if (key.Key == ConsoleKey.RightArrow)
            {
                _gameMovesService.MoveRight(array);
            }
            else if (key.Key == ConsoleKey.LeftArrow)
            {
                _gameMovesService.MoveLeft(array);
            }
            else if (key.Key == ConsoleKey.UpArrow)
            {
                _gameMovesService.MoveUp(array);
            }
            else if (key.Key == ConsoleKey.DownArrow)
            {
                _gameMovesService.MoveDown(array);
            }
        }
    }
}

