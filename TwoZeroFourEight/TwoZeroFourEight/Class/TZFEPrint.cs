
using TwoZeroFourEight.Logger.Interface;
using TwoZeroFourEight.TwoZeroFourEight.Interface;

class TZFEPrint : ITZFEPrint
{
	private readonly ILogger _logger;
	private int[,] _array;
    public TZFEPrint(ILogger logger)
    {
		_logger = logger;
    }
	public void GetArrayRef(int[,] array)
	{
		_array = array;
	}
	public void PrintMenu()
	{
		_logger.WriteLine("\n\nPress UP ARROW to swipe up\n" +
							  "Press RIGHT ARROW to swipe right\n" +
							  "Press DOWN ARROW to swipe down\n" +
							  "Press LEFT ARROW to swipe left\n\n" +
							  "Press R to restart the game\n" +
							  "Press ESC to exit\n");
	}
	public void PrintBoard(int score)
	{
		_logger.Clear();
		_logger.WriteLine($"2048 GAME        SCORE: {score}\n");
		for (int i = 0; i < 4; i++)
		{
			_logger.WriteLine(new string('-', 25));
			_logger.Write("|  ");
			for (int j = 0; j < 4; j++)
			{
				_logger.Write(_array[i, j] + "  |  ");
			}
			_logger.WriteLine("");
		}
		_logger.WriteLine(new string('-', 25));
	}
}
