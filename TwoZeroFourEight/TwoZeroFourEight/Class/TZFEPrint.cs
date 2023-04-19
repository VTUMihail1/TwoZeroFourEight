using TwoZeroFourEight.Logger.Interface;
using TwoZeroFourEight.TwoZeroFourEight.Interface;

class TZFEPrint : ITZFEPrint
{
	private readonly ILogger _logger;
	private readonly IAddColorService _color;
	private readonly int _size;
	private int[,] _array;
    public TZFEPrint(ILogger logger, IAddColorService color)
    {
		_logger = logger;
		_color = color;
		_size = 4;
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
	public void PrintBoard()
	{
		_logger.Clear();
		_logger.WriteLine($"2048 GAME\n");
		for (int i = 0; i < _size; i++)
		{
			_logger.WriteLine(new string('-', 25));
			_logger.Write("|  ");
			for (int j = 0; j < _size; j++)
			{
				_color.AddColor(_array[i, j]);
				_logger.Write("  |  ");
			}
			_logger.WriteLine("");
		}
		_logger.WriteLine(new string('-', 25));
	}
}
