public class TZFEServices : ITZFEServices
{
	private readonly IRestartGameService _restart;
	private readonly IAddRandomService _add;
	private readonly IYouLostService _lostChecker;

	public TZFEServices(IRestartGameService restart, IAddRandomService add, IYouLostService lostChecker)
	{
		_restart = restart;
		_add = add;
		_lostChecker = lostChecker;
	}
	public void ServicesManager(ConsoleKeyInfo key, int[,] array)
	{
		if (key.Key == ConsoleKey.R)
		{
			_restart.RestartGame(array);
		}
		else if (key.Key == ConsoleKey.Escape)
		{
			Environment.Exit(1);
		}
		if (_lostChecker.YouLost(array))
		{
			_restart.RestartGame(array);
		}
		_add.AddRandom(array);
	}
}
