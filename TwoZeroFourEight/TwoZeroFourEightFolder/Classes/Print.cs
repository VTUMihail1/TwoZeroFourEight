using TwoZeroFourEight.LoggerFolder.Interfaces;
using TwoZeroFourEight.TwoZeroFourEightFolder.Interfaces;

namespace TwoZeroFourEight.TwoZeroFourEightFolder.Classes
{
	class Print : IPrint
	{
		private readonly ILogger _logger;
		private readonly IPrintBoard _board;
		private readonly IPrintResult _result;
		public Print(ILogger logger, IPrintBoard board, IPrintResult result)
		{
			_logger = logger;
			_board = board;
			_result = result;
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
		public void DisplayPrint(IScore score, int[,] array)
		{
			if (!array.Cast<int>().All(tile => tile == 0))
			{
				_board.PrintGameBoard(array);
			}
			else
			{
				int size = array.GetLength(0);
				if (_result.GameOverPrint(size))
				{
					PrintHeading(score, size);
				}
				PressAnyButtonPrint(size);
			}
		}
		public void PrintHeading(IScore score , int size)
		{
			string gap = string.Concat(Enumerable.Repeat(" ", ((size - 1) * 9) - 6));
			string message = $"2048{gap}BEST SCORE: {score.ManageBestScore}\n" +
							 $"{gap}    SCORE: {score.ManageScore}\n";
			_logger.Clear();
			_logger.WriteLine(message);
		}
		private void PressAnyButtonPrint(int size)
		{
			string gap = string.Concat(Enumerable.Repeat(" ", ((size - 4) * 9) / 2));
			string message = $"\n\n{gap}          PRESS ANY ARROW \n" +
								  $"{gap}         TO START THE GAME\n\n\n\n";
			_logger.WriteLine(message);
		}
		
	}
}

