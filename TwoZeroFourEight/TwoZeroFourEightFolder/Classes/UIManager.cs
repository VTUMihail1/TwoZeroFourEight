using TwoZeroFourEight.TwoZeroFourEightFolder.Interfaces;

namespace TwoZeroFourEight.TwoZeroFourEightFolder.Classes
{
	public class UIManager : IUIManager
	{
		private readonly IPrint _print;

		public UIManager(IPrint print)
		{
			_print = print;
		}
		public void PrintSetup(IScore score, int[,] array)
		{
			int size = array.GetLength(0);
			_print.PrintHeading(score.ManageScore, score.ManageBestScore, size);
			_print.DisplayPrint(array, score.ManageLastScore, score.ManageBestScore);
			_print.PrintMenu();


		}
	}
}


