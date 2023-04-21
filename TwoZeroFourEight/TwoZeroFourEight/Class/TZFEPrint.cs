using TwoZeroFourEight.Logger.Interface;
using TwoZeroFourEight.TwoZeroFourEight.Interface;

class TZFEPrint : ITZFEPrint
{
	private readonly ILogger _logger;
	private readonly IAddColorService _color;
	private readonly ITZFEScore _score;
    public TZFEPrint(ILogger logger, IAddColorService color, ITZFEScore score)
    {
		_logger = logger;
		_color = color;
		_score = score;
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
	public void PrintBoard(int[,] array)
	{
		if(array.Cast<int>().All(tile => tile == 0))
		{
			_logger.WriteLine("\n\n\n\n      PRESS SPACE\n       TO START\n\n\n\n\n");
		}
		else
		{
			_logger.Clear();
			_logger.WriteLine($"2048 GAME       SCORE: {_score.ScoreCalculator(array)}\n");
			for (int i = 0; i < 4; i++)
			{
				_logger.WriteLine(new string('-', 25));
				_logger.Write("|  ");
				for (int j = 0; j < 4; j++)
				{
					_color.AddColor(_logger, array[i, j]);
					_logger.Write("  |  ");
				}
				_logger.WriteLine("");
			}
			_logger.WriteLine(new string('-', 25));
		}
		
	}
}
