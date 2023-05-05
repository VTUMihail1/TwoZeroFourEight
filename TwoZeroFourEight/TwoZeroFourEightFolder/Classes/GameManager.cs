using TwoZeroFourEight.TwoZeroFourEightFolder.Interfaces;

namespace TwoZeroFourEight.TwoZeroFourEightFolder.Classes
{
	class GameManager : IGameManager
	{
		private readonly IConfiguration _config;
		private readonly IUIManager _uiManager;
		private readonly IInitializeBoard _initializeBoard;

		public GameManager(IConfiguration config, IUIManager uiManager, IInitializeBoard initializeBoard)
		{
			_config = config;
			_uiManager = uiManager;
			_initializeBoard = initializeBoard;
		}
		public void Start()
		{
			int[,] array = _initializeBoard.CreateBoard(4);
			while (true)
			{
				_uiManager.PrintSetup(array);
				_config.Run(array);
			}
		}
	}
}

