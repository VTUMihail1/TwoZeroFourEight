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
			Bind<IMovesManager>().To<MovesManager>();
			Bind<IServicesManager>().To<ServicesManager>();
			Bind<IInitializeBoard>().To<InitializeBoard>();
			Bind<IScore>().To<Score>();
			Bind<IGameManager>().To<GameManager>();
			Bind<IPrint>().To<Print>();
			Bind<IConfiguration>().To<Configuration>();
			Bind<IUIManager>().To<UIManager>();
		}
	}
}

