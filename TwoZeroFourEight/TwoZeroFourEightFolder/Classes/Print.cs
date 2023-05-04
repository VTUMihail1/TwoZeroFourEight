using TwoZeroFourEight.LoggerFolder.Interfaces;
using TwoZeroFourEight.ServicesFolder.Interfaces;
using TwoZeroFourEight.TwoZeroFourEightFolder.Interfaces;

namespace TwoZeroFourEight.TwoZeroFourEightFolder.Classes
{
	class Print : IPrint
	{
		private readonly ILogger _logger;
		private readonly IAddColor _color;
		private readonly IScore _score;
		public Print(ILogger logger, IAddColor color, IScore score)
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
			int size = array.GetLength(0);
			int score = _score.ScoreCalculator(array);
			_logger.Clear();
			_logger.WriteLine($"2048 GAME       SCORE: {score}\n");
			if (!array.Cast<int>().All(tile => tile == 0))
			{
				for (int i = 0; i < size; i++)
				{
					_logger.WriteLine("-------------------------");
					_logger.Write("|  ");
					for (int j = 0; j < size; j++)
					{
						_color.AddColors(_logger, array[i, j]);
						_logger.Write("  |  ");
					}
					_logger.WriteLine("");
				}
				_logger.WriteLine("-------------------------");
            }
			else
			{
				_logger.WriteLine("\n\n      PRESS ANY ARROW \n" +
					              "     TO START THE GAME\n\n\n\n");
			}
		}
	}
}

