using TwoZeroFourEight.TwoZeroFourEight.Interface.Services;

class TZFEConfiguration : ITZFEConfiguration
{
	private readonly ITZFEMoves _moves;
	private readonly IRestartGameService _restart;
	private readonly IAddRandomService _add;
	private readonly IYouLostService _lostChecker;
	public TZFEConfiguration(ITZFEMoves moves, IRestartGameService restart, IAddRandomService add, IYouLostService lostChecker)
	{
		_add = add;
		_moves = moves;
		_restart = restart;
		_lostChecker = lostChecker;
	}
	public void Run(int[,] array)
	{
		
		var key = Console.ReadKey();

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
		else if (key.Key == ConsoleKey.R)
		{
			_restart.RestartGame(array);
		}
		else if (key.Key == ConsoleKey.Escape)
		{
			Environment.Exit(1);
		}
		else
		{
			return;
		}
		
		if (_lostChecker.YouLost(array))
		{
			_restart.RestartGame(array);
		}
		_add.AddRandom(array);
	}
}
