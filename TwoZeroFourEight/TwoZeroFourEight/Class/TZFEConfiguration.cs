class TZFEConfiguration : ITZFEConfiguration
{
	private readonly ITZFEMovesManager _movesManager;
	private readonly ITZFEServices _services;
	public TZFEConfiguration(ITZFEMovesManager movesManager, ITZFEServices services)
	{
		_movesManager = movesManager;
		_services = services;
	}
	public void Run(int[,] array)
	{
		
		var key = Console.ReadKey();
		_movesManager.Moves(array, key);
		_services.ServicesManager(key, array);
	}
}
