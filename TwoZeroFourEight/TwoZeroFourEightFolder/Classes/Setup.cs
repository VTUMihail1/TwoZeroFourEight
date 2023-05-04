using TwoZeroFourEight.TwoZeroFourEightFolder.Interfaces;

namespace TwoZeroFourEight.TwoZeroFourEightFolder.Classes
{
	class Setup : ISetup
	{
		private readonly IPrint _print;
		private readonly IConfiguration _config;
		private readonly IBoard _board;
		private readonly int[,] _array;

		public Setup(IConfiguration config, IPrint print, IBoard board)
		{
			_config = config;
			_print = print;
			_board = board;
			_array = _board.InitialiseBoard(4);
		}
		public void GameSetup()
		{
			while (true)
			{
				_print.PrintBoard(_array);
				_print.PrintMenu();
				_config.Run(_array);
			}
		}
	}
}

