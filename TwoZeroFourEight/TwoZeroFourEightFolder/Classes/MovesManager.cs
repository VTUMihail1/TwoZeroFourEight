using TwoZeroFourEight.ServicesFolder.Interfaces;
using TwoZeroFourEight.TwoZeroFourEightFolder.Interfaces;

namespace TwoZeroFourEight.TwoZeroFourEightFolder.Classes
{
	public class MovesManager : IMovesManager
	{
		private IGameMoves _gameMoves;
		public MovesManager(IGameMoves gameMoves)
		{
			_gameMoves = gameMoves;
		}
		public void CheckMoves(ConsoleKeyInfo key, IScore score, int[,] array)
		{
			if (key.Key == ConsoleKey.RightArrow)
			{
				_gameMoves.Right(score, array);
			}
			else if (key.Key == ConsoleKey.LeftArrow)
			{
				_gameMoves.Left(score, array);
			}
			else if (key.Key == ConsoleKey.UpArrow)
			{
				_gameMoves.Up(score, array);
			}
			else if (key.Key == ConsoleKey.DownArrow)
			{
				_gameMoves.Down(score, array);
			}
		}
	}
}

