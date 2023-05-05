using TwoZeroFourEight.TwoZeroFourEightFolder.Interfaces;

namespace TwoZeroFourEight.TwoZeroFourEightFolder.Classes
{
	class Setup : ISetup
	{
		private readonly IConfiguration _config;
		private readonly IDisplayManager _display;
		private readonly IBoard _board;

		public Setup(IConfiguration config, IDisplayManager display, IBoard board)
		{
			_config = config;
			_display = display;
			_board = board;
		}
		public void GameSetup()
		{
			int[,] array = _board.InitialiseBoard(4);
			while (true)
			{
				_display.PrintSetup(array);
				_config.Run(array);
			}
		}
	}
}

