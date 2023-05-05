using TwoZeroFourEight.TwoZeroFourEightFolder.Interfaces;

namespace TwoZeroFourEight.TwoZeroFourEightFolder.Classes
{
	public class UIManager : IUIManager
	{
		private readonly IPrint _print;
		private readonly IScore _score;

		public UIManager(IPrint print, IScore score)
		{
			_print = print;
			_score = score;
		}
		public void PrintSetup(int[,] array)
		{
			int lastScore = _score.LastScore;
			int score = _score.ScoreCalculator(array);
			int bestScore = _score.BestScore;
			_print.PrintHeading(score, bestScore);
			_print.DisplayPrint(array, lastScore, bestScore);
			_print.PrintMenu();


		}
	}
}


