using Ninject.Modules;
using TwoZeroFourEight.Backend.Controllers.Classes;
using TwoZeroFourEight.Backend.Controllers.Interfaces;
using TwoZeroFourEight.Backend.Services.Classes;
using TwoZeroFourEight.Backend.Services.Interfaces;
using TwoZeroFourEight.Frontend.Controllers.Classes;
using TwoZeroFourEight.Frontend.Controllers.Interfaces;
using TwoZeroFourEight.Frontend.Services.Classes;
using TwoZeroFourEight.Frontend.Services.Interfaces;

namespace TwoZeroFourEight.OnConfigurationFolder.Dependencies
{
    public class TwoZeroFourEightModule : NinjectModule
	{
		public override void Load()
		{
			Bind<Random>().ToSelf();
			Bind<IUIController>().To<UIController>();
			Bind<IYouWinService>().To<YouWinService>();
			Bind<IYouLostService>().To<YouLostService>();
			Bind<IGameController>().To<GameController>();
			Bind<IAddColorService>().To<AddColorService>();
			Bind<IStateController>().To<StateController>();
			Bind<IResultController>().To<ResultController>();
			Bind<IPrintMenuService>().To<PrintMenuService>();
			Bind<IGameMovesService>().To<GameMovesService>();
			Bind<IAddRandomService>().To<AddRandomService>();
			Bind<IPrintBoardService>().To<PrintBoardService>();
			Bind<IPrintStateService>().To<PrintStateService>();
			Bind<IRestartGameService>().To<RestartGameService>();
			Bind<IPrintHeadingService>().To<PrintHeadingService>();
			Bind<IGameMovesController>().To<GameMovesController>();
			Bind<IAddRandomController>().To<AddRandomController>();
			Bind<IPrintBoardController>().To<PrintBoardController>();
			Bind<IPrintStateController>().To<PrintStateController>();
			Bind<IGameEngineController>().To<GameEngineController>();
			Bind<IPrintResultController>().To<PrintResultController>();
			Bind<IScoreService>().To<ScoreService>().InSingletonScope();
			Bind<IInitializeBoardService>().To<InitializeBoardService>();
			Bind<ILoggerService>().To<LoggerService>().InSingletonScope();
			Bind<IPrintPressAnyButtonService>().To<PrintPressAnyButtonService>();
			Bind<ITwoZeroFourEightGameController>().To<TwoZeroFourEightGameController>();
		}
	}
}

