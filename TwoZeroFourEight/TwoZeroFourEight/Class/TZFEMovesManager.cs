using TwoZeroFourEight.TwoZeroFourEight.Interface.Services;

public class TZFEMovesManager : ITZFEMovesManager
{
	private ITZFEMoves _moves;
	public TZFEMovesManager(ITZFEMoves moves)
	{
		_moves = moves;
	}
	public void Moves(int[,] array, ConsoleKeyInfo key)
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
