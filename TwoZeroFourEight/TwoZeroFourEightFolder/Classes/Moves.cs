using TwoZeroFourEight.ServicesFolder.Interfaces;
using TwoZeroFourEight.TwoZeroFourEightFolder.Interfaces;

namespace TwoZeroFourEight.TwoZeroFourEightFolder.Classes
{
	public class Moves : IMoves
	{
		private IGameMoves _moves;
		public Moves(IGameMoves moves)
		{
			_moves = moves;
		}
		public void CheckMoves(ConsoleKeyInfo key, int[,] array)
		{
			if (key.Key == ConsoleKey.RightArrow)
			{
				_moves.Right(array);
			}
			else if (key.Key == ConsoleKey.LeftArrow)
			{
				_moves.Left(array);
			}
			else if (key.Key == ConsoleKey.UpArrow)
			{
				_moves.Up(array);
			}
			else if (key.Key == ConsoleKey.DownArrow)
			{
				_moves.Down(array);
			}
		}
	}
}

