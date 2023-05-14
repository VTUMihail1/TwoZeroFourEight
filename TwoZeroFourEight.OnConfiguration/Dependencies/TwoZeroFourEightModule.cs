using Ninject.Modules;
using TwoZeroFourEight.Services.Classes;
using TwoZeroFourEight.Services.Interfaces;
using TwoZeroFourEight.UserInterfaces.Classes;
using TwoZeroFourEight.UserInterfaces.Interfaces;

namespace TwoZeroFourEight.OnConfigurationFolder.Dependencies
{
    public class TwoZeroFourEightModule : NinjectModule
	{
		public override void Load()
		{
			Bind<Random>().ToSelf();
			Bind<ILogger>().To<Logger>();
			Bind<IAddColor>().To<AddColor>();
			Bind<IPrintMenu>().To<PrintMenu>();
			Bind<IGameMoves>().To<GameMoves>();
			Bind<IUIManager>().To<UIManager>();
			Bind<IPrintBoard>().To<PrintBoard>();
			Bind<IPrintState>().To<PrintState>();
			Bind<IGameManager>().To<GameManager>();
			Bind<IPrintHeading>().To<PrintHeading>();
			Bind<IMovesManager>().To<MovesManager>();
			Bind<IStateManager>().To<StateManager>();
			Bind<IResultManager>().To<ResultManager>();
			Bind<IYouWonService>().To<YouWonService>();
			Bind<IYouLostService>().To<YouLostService>();
			Bind<IScore>().To<Score>().InSingletonScope();
			Bind<IServicesManager>().To<ServicesManager>();
			Bind<IInitializeBoard>().To<InitializeBoard>();
			Bind<IAddRandomManager>().To<AddRandomManager>();
			Bind<IAddRandomService>().To<AddRandomService>();
			Bind<IPrintBoardManager>().To<PrintBoardManager>();
			Bind<IPrintStateManager>().To<PrintStateManager>();
			Bind<IRestartGameService>().To<RestartGameService>();
			Bind<IPrintResultManager>().To<PrintResultManager>();
			Bind<IPrintPressAnyButton>().To<PrintPressAnyButton>();
			Bind<ITwoZeroFourEightGame>().To<TwoZeroFourEightGame>();
		}
	}
}

