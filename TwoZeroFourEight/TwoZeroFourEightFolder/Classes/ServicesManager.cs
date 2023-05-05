using TwoZeroFourEight.ServicesFolder.Interfaces;
using TwoZeroFourEight.TwoZeroFourEightFolder.Interfaces;

namespace TwoZeroFourEight.TwoZeroFourEightFolder.Classes
{
	public class ServicesManager : IServicesManager
	{
		private readonly IRestartGameService _restart;
		private readonly IAddRandomService _add;
		private readonly IYouLostService _lostChecker;

		public ServicesManager(IRestartGameService restart, IAddRandomService add, IYouLostService lostChecker)
		{
			_restart = restart;
			_add = add;
			_lostChecker = lostChecker;
		}
		public void GameServices(ConsoleKeyInfo key, int[,] array)
		{
			if (key.Key == ConsoleKey.R || _lostChecker.YouLost(array))
			{
                _restart.RestartGame(array);
			}
			else if (key.Key == ConsoleKey.Escape)
			{
				Environment.Exit(1);
			}
			else if(key.Key >= ConsoleKey.LeftArrow && key.Key <= ConsoleKey.DownArrow)
			{
			    _add.AddRandom(array);
			}

		}
	}
}

