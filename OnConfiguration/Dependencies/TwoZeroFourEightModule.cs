using Ninject.Modules;
using TwoZeroFourEight.Services.Classes;
using TwoZeroFourEight.Services.Interfaces;
using TwoZeroFourEight.UserInterface.Classes;
using TwoZeroFourEight.UserInterface.Interfaces;

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
			Bind<IPrintStateManager>().To<PrintStateManager>();
			Bind<IYouLostService>().To<YouLostService>();
			Bind<IPrintBoard>().To<PrintBoard>();
			Bind<IPrintState>().To<PrintState>();
			Bind<IPrintResultManager>().To<PrintResultManager>();
			Bind<IMovesManager>().To<MovesManager>();
			Bind<IServicesManager>().To<ServicesManager>();
			Bind<IInitializeBoard>().To<InitializeBoard>();
			Bind<IScore>().To<Score>().InSingletonScope();
			Bind<IGameManager>().To<GameManager>();
			Bind<IPrintBoardManager>().To<PrintBoardManager>();
			Bind<IPrintHeading>().To<PrintHeading>();
			Bind<IPrintPressAnyButton>().To<PrintPressAnyButton>();
			Bind<IPrintMenu>().To<PrintMenu>();
			Bind<IStateManager>().To<StateManager>();
			Bind<IUIManager>().To<UIManager>();
			Bind<ITwoZeroFourEightGame>().To<TwoZeroFourEightGame>();
			Bind<IResultManager>().To<ResultManager>();
			Bind<IYouWonService>().To<YouWonService>();
		}
	}
}

