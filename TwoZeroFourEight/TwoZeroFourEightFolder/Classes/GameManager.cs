using TwoZeroFourEight.TwoZeroFourEightFolder.Interfaces;

namespace TwoZeroFourEight.TwoZeroFourEightFolder.Classes
{
	class GameManager : IGameManager
	{
		private readonly IServicesManager _services;
		private readonly IUIManager _uiManager;
		private readonly IScore _score;

		public GameManager(IServicesManager services, IUIManager uiManager,IScore score)
		{
			_services = services;
			_uiManager = uiManager;
			_score = score;
		}
		public void Start(int[,] array)
		{
			while (true)
			{
				_uiManager.PrintSetup(_score, array);
				_services.Run(_score, array);
			}
		}
	}
}

