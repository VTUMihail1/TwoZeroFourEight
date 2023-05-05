using TwoZeroFourEight.TwoZeroFourEightFolder.Interfaces;

namespace TwoZeroFourEight.TwoZeroFourEightFolder.Classes
{
	class Configuration : IConfiguration
	{
		private readonly IMovesManager _movesManager;
		private readonly IServicesManager _servicesManager;
		public Configuration(IMovesManager movesManager, IServicesManager servicesManager)
		{
			_movesManager = movesManager;
			_servicesManager = servicesManager;
		}
		public void Run(int[,] array)
		{
			var key = Console.ReadKey();
			_movesManager.CheckMoves(key, array);
			_servicesManager.GameServices(key, array);

		}
	}
}

