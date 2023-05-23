using Ninject.Modules;
using TwoZeroFourEight.Backend.Add.Classes;
using TwoZeroFourEight.Backend.Add.Interfaces;
using TwoZeroFourEight.Backend.Board.Classes;
using TwoZeroFourEight.Backend.Board.Interfaces;
using TwoZeroFourEight.Backend.Controllers.Classes;
using TwoZeroFourEight.Backend.Controllers.Interfaces;
using TwoZeroFourEight.Backend.Moves.Classes;
using TwoZeroFourEight.Backend.Moves.Interfaces;
using TwoZeroFourEight.Backend.State.Classes;
using TwoZeroFourEight.Backend.State.Interfaces;
using TwoZeroFourEight.Frontend.AddColor.Classes;
using TwoZeroFourEight.Frontend.AddColor.Interfaces;
using TwoZeroFourEight.Frontend.Board.Classes;
using TwoZeroFourEight.Frontend.Board.Interfaces;
using TwoZeroFourEight.Frontend.Controllers.Classes;
using TwoZeroFourEight.Frontend.Controllers.Interfaces;
using TwoZeroFourEight.Frontend.Heading.Classes;
using TwoZeroFourEight.Frontend.Heading.Interfaces;
using TwoZeroFourEight.Frontend.Logger.Classes;
using TwoZeroFourEight.Frontend.Logger.Interfaces;
using TwoZeroFourEight.Frontend.Menu.Classes;
using TwoZeroFourEight.Frontend.Menu.Interfaces;
using TwoZeroFourEight.Frontend.Score.Classes;
using TwoZeroFourEight.Frontend.Score.Interfaces;
using TwoZeroFourEight.Frontend.State.Classes;
using TwoZeroFourEight.Frontend.State.Interfaces;

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
			Bind<IScoreController>().To<ScoreController>();
			Bind<IStateController>().To<StateController>();
			Bind<IResultController>().To<ResultController>();
			Bind<IPrintMenuService>().To<PrintMenuService>();
			Bind<IGameMovesService>().To<GameMovesService>();
			Bind<IAddRandomService>().To<AddRandomService>();
			Bind<IPrintBoardService>().To<PrintBoardService>();
			Bind<IPrintStateController>().To<PrintStateController>();
			Bind<IPrintResultState>().To<PrintResultState>().InSingletonScope();
			Bind<IPrintStateService>().To<PrintStateService>();
			Bind<IRestartGameService>().To<RestartGameService>();
			Bind<IPrintHeadingService>().To<PrintHeadingService>();
			Bind<IGameMovesController>().To<GameMovesController>();
			Bind<IAddRandomController>().To<AddRandomController>();
			Bind<IPrintBoardController>().To<PrintBoardController>();
			Bind<IState>().To<PrintYouWin>().Named("YouWin");
            Bind<IState>().To<PrintYouLose>().Named("YouLost");
			Bind<IPrintRestart>().To<PrintRestart>();
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

