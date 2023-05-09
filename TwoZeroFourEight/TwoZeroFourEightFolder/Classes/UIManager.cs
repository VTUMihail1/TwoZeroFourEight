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
			int size = array.GetLength(0);
			_print.PrintHeading(_score, size);
			_print.DisplayPrint(_score, array);
			_print.PrintMenu();


		}
	}
}


