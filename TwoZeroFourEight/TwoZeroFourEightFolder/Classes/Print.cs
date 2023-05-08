using TwoZeroFourEight.LoggerFolder.Interfaces;
using TwoZeroFourEight.ServicesFolder.Interfaces;
using TwoZeroFourEight.TwoZeroFourEightFolder.Interfaces;

namespace TwoZeroFourEight.TwoZeroFourEightFolder.Classes
{
	class Print : IPrint
	{
		private readonly ILogger _logger;
		private readonly IAddColor _color;
		public Print(ILogger logger, IAddColor color)
		{
			_logger = logger;
			_color = color;
		}
		public void PrintMenu()
		{
			string message = "\n\nPress UP ARROW to swipe up\n" +
							 "Press RIGHT ARROW to swipe right\n" +
							 "Press DOWN ARROW to swipe down\n" +
							 "Press LEFT ARROW to swipe left\n\n" +
							 "Press R to restart the game\n" +
							 "Press ESC to exit\n";
			_logger.WriteLine(message);
		}
		public void DisplayPrint(int[,] array, int lastScore, int bestScore)
		{
			if (!array.Cast<int>().All(tile => tile == 0))
			{
				PrintBoard(array);
			}
			else
			{
				int size = array.GetLength(0);
				GameOverPrint(lastScore, bestScore, size);
				PressAnyButtonPrint(size);
			}
		}
		public void PrintHeading(int score, int bestScore, int size)
		{
			string gap = string.Concat(Enumerable.Repeat(" ", ((size - 1) * 9) - 6));
			string message = $"2048{gap}BEST SCORE: {bestScore}\n" +
							 $"{gap}    SCORE: {score}\n";
			_logger.Clear();
			_logger.WriteLine(message);
		}
		private void PrintBoard(int[,] array)
		{
			int size = array.GetLength(0);
			string fullRow = string.Concat(Enumerable.Repeat("-", size * 9 + 1));
			string startOfRow = "|  ";
			string midEndOfRow = "  |  ";
			for (int i = 0; i < size; i++)
			{
				_logger.WriteLine(fullRow);
				_logger.Write(startOfRow);
				for (int j = 0; j < size; j++)
				{
					_color.AddColors(_logger, array[i, j]);
					_logger.Write(midEndOfRow);
				}
				_logger.WriteLine();
			}
			_logger.WriteLine(fullRow);
		}
		private void PressAnyButtonPrint(int size)
		{
			string gap = string.Concat(Enumerable.Repeat(" ", ((size - 4) * 9) / 2));
			string message = $"\n\n{gap}          PRESS ANY ARROW \n" +
								  $"{gap}         TO START THE GAME\n\n\n\n";
			_logger.WriteLine(message);
		}
		private void GameOverPrint(int lastScore, int bestScore, int size)
		{
			int lowestScore = 0;
			if (bestScore != lowestScore)
			{
				string gap = string.Concat(Enumerable.Repeat(" ", ((size - 4) * 9)/2));
				string message = $"\n\n\n{gap}             GAME OVER \n\n" +
								 $"{gap}       SCORE FROM LAST GAME: \n" +
								 $"{gap}                {lastScore}\n\n" +
								 $"{gap}         PRESS ANY BUTTON \n" +
								 $"{gap}            TO CONTINUE";
				_logger.Clear();
				_logger.WriteLine(message);
				_logger.ReadKey();
				_logger.Clear();
				PrintHeading(lowestScore, bestScore, size);
			}
		}
	}
}

