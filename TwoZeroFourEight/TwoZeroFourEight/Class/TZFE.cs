using TwoZeroFourEight.TwoZeroFourEight.Interface;

class TZFE : ITZFE
{
    private readonly ITZFEMoves _moves;
    private readonly ITZFEPrint _print;
    private readonly ITZFEServices _services;
	private int _score;
    public TZFE(ITZFEMoves moves, ITZFEServices services, ITZFEPrint print)
    {
        _moves= moves;
        _services = services;
        _print = print;
    }
	private void Configuration()
	{
		int[,] array = new int[4, 4];
		_moves.GetArrayRef(array);
		_services.GetArrayRef(array);
		_print.GetArrayRef(array);
		_services.Add();
		_services.Add();
	}
    public void Start()
    {
		Configuration();
        while (true)
        {
            _print.PrintBoard(_score);
            _print.PrintMenu();
            var key = Console.ReadKey();

			if (key.Key == ConsoleKey.RightArrow)
			{
				_moves.Right(ref _score);
			}
			else if (key.Key == ConsoleKey.LeftArrow)
			{
				_moves.Left(ref _score);
			}
			else if (key.Key == ConsoleKey.UpArrow)
			{
				_moves.Up(ref _score);
			}
			else if (key.Key == ConsoleKey.DownArrow)
			{
				_moves.Down(ref _score);
			}
			else if (key.Key == ConsoleKey.R)
			{
				_score = 0;
				_services.Restart();
			}
			else if (key.Key == ConsoleKey.Escape)
			{
				return;
			}
			else
			{
				continue;
			}
			_services.Add();
        }
    }
}
