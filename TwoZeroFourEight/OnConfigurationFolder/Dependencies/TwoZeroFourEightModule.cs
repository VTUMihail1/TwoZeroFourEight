using Ninject.Modules;
using TwoZeroFourEight.LoggerFolder.Classes;
using TwoZeroFourEight.LoggerFolder.Interfaces;
using TwoZeroFourEight.ServicesFolder.Classes;
using TwoZeroFourEight.ServicesFolder.Interfaces;
using TwoZeroFourEight.TwoZeroFourEightFolder.Classes;
using TwoZeroFourEight.TwoZeroFourEightFolder.Interfaces;

namespace TwoZeroFourEight.OnConfigurationFolder.Dependencies
{
	public class TwoZeroFourEightModule : NinjectModule
	{
		public override void Load()
		{
			Bind<Random>().ToSelf();
			Bind<ILogger>().To<Logger>();
			Bind<IGameMoves>().To<GameMoves>();
			Bind<IAddColor>().To<AddColor>();
			Bind<IAddRandomService>().To<AddRandomService>();
			Bind<IRestartGameService>().To<RestartGameService>();
			Bind<IYouLostService>().To<YouLostService>();
			Bind<IMoves>().To<Moves>();
			Bind<IServices>().To<Services>();
			Bind<IBoard>().To<Board>();
			Bind<IScore>().To<Score>();
			Bind<IGame>().To<Game>();
			Bind<IPrint>().To<Print>();
			Bind<IConfiguration>().To<Configuration>();
			Bind<ISetup>().To<Setup>();
			Bind<IDisplayManager>().To<DisplayManager>();
		}
	}
}

