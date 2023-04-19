using TwoZeroFourEight.TwoZeroFourEight.Interface.Services;

class TZFEStartUp : ITZFEStartUp
{
	private readonly ITZFEMoves _moves;
	private readonly IRestartGameService _restart;
	private readonly IAddRandomService _add;
	private readonly IYouLostService _lostChecker;
	private readonly int _size;
	private int[,] _array;
	public TZFEStartUp(ITZFEMoves moves, IRestartGameService restart, IAddRandomService add, IYouLostService lostChecker)
	{
		_add = add;
		_moves = moves;
		_restart = restart;
		_lostChecker = lostChecker;
		_size = 4;
	}
	public int[,] Configuration()
	{
		_array = new int[_size, _size];
		_add.AddRandom(_array);
		return _array;
	}
	public void Run()
	{
		
		var key = Console.ReadKey();

		if (key.Key == ConsoleKey.RightArrow)
		{
			_moves.Right(_array);
		}
		else if (key.Key == ConsoleKey.LeftArrow)
		{
			_moves.Left(_array);
		}
		else if (key.Key == ConsoleKey.UpArrow)
		{
			_moves.Up(_array);
		}
		else if (key.Key == ConsoleKey.DownArrow)
		{
			_moves.Down(_array);
		}
		else if (key.Key == ConsoleKey.R)
		{
			_restart.RestartGame(_array);
		}
		else if (key.Key == ConsoleKey.Escape)
		{
			Environment.Exit(1);
		}
		else
		{
			return;
		}
		
		if (_lostChecker.YouLost(_array))
		{
			_restart.RestartGame(_array);
		}
		_add.AddRandom(_array);
	}
}
