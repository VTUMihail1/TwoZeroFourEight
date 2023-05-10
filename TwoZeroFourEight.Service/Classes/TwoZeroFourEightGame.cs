using TwoZeroFourEight.Services.Interfaces;

namespace TwoZeroFourEight.Services.Classes
{
    public class TwoZeroFourEightGame : ITwoZeroFourEightGame
    {
        private readonly IGameManager _manager;
        private readonly IInitializeBoard _board;
        public TwoZeroFourEightGame(IGameManager manager, IInitializeBoard board)
        {
            _manager = manager;
            _board = board;
        }
        public void Play(int size)
        {
            if (size < 4 || size > 7)
            {
                return;
            }
            int[,] array = _board.CreateBoard(size);
            _manager.Start(array);
        }
    }
}
