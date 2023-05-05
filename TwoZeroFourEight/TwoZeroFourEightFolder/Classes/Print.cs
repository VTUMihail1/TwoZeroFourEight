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
			string message = "\n\n   Press UP ARROW to swipe up\n" +
							 "   Press RIGHT ARROW to swipe right\n" +
							 "   Press DOWN ARROW to swipe down\n" +
							 "   Press LEFT ARROW to swipe left\n\n" +
							 "   Press R to restart the game\n" +
							 "   Press ESC to exit\n";
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
				GameOverPrint(lastScore, bestScore);
				PressAnyButtonPrint();
			}
		}
		public void PrintHeading(int score, int bestScore)
		{
			string message = $"2048                   BEST SCORE: {bestScore}\n" +
							 $"                            SCORE: {score}\n";
			_logger.Clear();
			_logger.WriteLine(message);
		}
		private void PrintBoard(int[,] array)
		{
			string fullRow = "-------------------------------------";
			string startOfRow = "|  ";
			string midEndOfRow = "  |  ";
			int size = array.GetLength(0);
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
		private void PressAnyButtonPrint()
		{
			string message = "\n\n           PRESS ANY ARROW \n" +
								  "          TO START THE GAME\n\n\n\n";
			_logger.WriteLine(message);
		}
		private void GameOverPrint(int lastScore, int bestScore)
		{
			int lowestScore = 0;
			if (bestScore != lowestScore)
			{
				string message =  "\n\n\n            GAME OVER \n\n" +
								 $"       SCORE FROM LAST GAME: \n" +
								 $"                {lastScore}\n\n" +
								  "         PRESS ANY BUTTON \n" +
								  "           TO CONTINUE";
				_logger.Clear();
				_logger.WriteLine(message);
				_logger.ReadKey();
				_logger.Clear();
				PrintHeading(lowestScore, bestScore);
			}
		}
	}
}

