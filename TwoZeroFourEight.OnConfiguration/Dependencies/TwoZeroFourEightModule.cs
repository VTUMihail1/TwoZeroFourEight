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
			Bind<ILoggerService>().To<LoggerService>();
			Bind<IAddColorService>().To<AddColorService>();
			Bind<IPrintMenuService>().To<PrintMenuService>();
			Bind<IGameMovesService>().To<GameMovesService>();
			Bind<IUIController>().To<UIController>();
			Bind<IPrintBoardService>().To<PrintBoardService>();
			Bind<IPrintStateService>().To<PrintStateService>();
			Bind<IGameController>().To<GameController>();
			Bind<IPrintHeadingService>().To<PrintHeadingService>();
			Bind<IGameMovesController>().To<GameMovesController>();
			Bind<IStateController>().To<StateController>();
			Bind<IResultController>().To<ResultController>();
			Bind<IYouWinService>().To<YouWinService>();
			Bind<IYouLostService>().To<YouLostService>();
			Bind<IScoreService>().To<ScoreService>().InSingletonScope();
			Bind<IServicesController>().To<ServicesController>();
			Bind<IInitializeBoardService>().To<InitializeBoardService>();
			Bind<IAddRandomController>().To<AddRandomController>();
			Bind<IAddRandomService>().To<AddRandomService>();
			Bind<IPrintBoardController>().To<PrintBoardController>();
			Bind<IPrintStateController>().To<PrintStateController>();
			Bind<IRestartGameService>().To<RestartGameService>();
			Bind<IPrintResultController>().To<PrintResultController>();
			Bind<IPrintPressAnyButtonService>().To<PrintPressAnyButtonService>();
			Bind<ITwoZeroFourEightGameController>().To<TwoZeroFourEightGameController>();
		}
	}
}

