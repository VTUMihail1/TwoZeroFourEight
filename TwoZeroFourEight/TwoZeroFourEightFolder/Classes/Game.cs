using TwoZeroFourEight.TwoZeroFourEightFolder.Interfaces;

namespace TwoZeroFourEight.TwoZeroFourEightFolder.Classes
{
	class Game : IGame
	{
		private readonly ISetup _setup;
		public Game(ISetup setup, IScore score)
		{
			_setup = setup;
		}
		public void Start()
		{
			_setup.GameSetup();
		}
	}
}
