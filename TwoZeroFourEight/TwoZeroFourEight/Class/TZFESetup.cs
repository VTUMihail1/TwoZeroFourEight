using TwoZeroFourEight.TwoZeroFourEight.Interface;

class TZFESetup : ITZFESetup
{
    private readonly ITZFEPrint _print;
    private readonly ITZFEConfiguration _config;
    private readonly ITZFEBoard _board;
    private readonly int[,] _array;

	public TZFESetup(ITZFEConfiguration config, ITZFEPrint print, ITZFEBoard board)
    {
        _config = config;
        _print = print;
        _board = board;
        _array = _board.InitialiseBoard(4);
	}
    public void Setup()
    {
        while (true)
        {
            _print.PrintBoard(_array);
            _print.PrintMenu();
            _config.Run(_array);
        }
    }
}
