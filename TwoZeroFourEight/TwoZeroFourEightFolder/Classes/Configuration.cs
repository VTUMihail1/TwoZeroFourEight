using TwoZeroFourEight.TwoZeroFourEightFolder.Interfaces;

namespace TwoZeroFourEight.TwoZeroFourEightFolder.Classes
{
	class Configuration : IConfiguration
	{
		private readonly IMoves _movesManager;
		private readonly IServices _services;
		public Configuration(IMoves movesManager, IServices services)
		{
			_movesManager = movesManager;
			_services = services;
		}
		public void Run(int[,] array)
		{
			var key = Console.ReadKey();
			_movesManager.CheckMoves(key, array);
			_services.ServicesManager(key, array);

		}
	}
}

