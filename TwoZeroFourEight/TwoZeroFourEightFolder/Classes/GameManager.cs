using TwoZeroFourEight.TwoZeroFourEightFolder.Interfaces;

namespace TwoZeroFourEight.TwoZeroFourEightFolder.Classes
{
	class GameManager : IGameManager
	{
		private readonly IServicesManager _services;
		private readonly IUIManager _uiManager;

		public GameManager(IServicesManager services, IUIManager uiManager)
		{
			_services = services;
			_uiManager = uiManager;
		}
		public void Start(int[,] array)
		{
			while (true)
			{
				_uiManager.PrintSetup(array);
				_services.Run(array);
			}
		}
	}
}

