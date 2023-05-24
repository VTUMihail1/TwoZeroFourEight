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
    /// <summary>
    /// Ninject module for configuring the dependency injection bindings for the TwoZeroFourEight game.
    /// </summary>
    public class TwoZeroFourEightModule : NinjectModule
	{
        /// <summary>
        /// Loads the dependency injection bindings.
        /// </summary>
        public override void Load()
		{
			Bind<Random>().ToSelf().InSingletonScope();
			Bind<IUIController>().To<UIController>().InSingletonScope();
			Bind<IPrintRestart>().To<PrintRestart>().InSingletonScope();
			Bind<IScoreService>().To<ScoreService>().InSingletonScope();
			Bind<IYouWinService>().To<YouWinService>().InSingletonScope();
			Bind<ILoggerService>().To<LoggerService>().InSingletonScope();
			Bind<IYouLostService>().To<YouLostService>().InSingletonScope();
			Bind<IGameController>().To<GameController>().InSingletonScope();
			Bind<IAddColorService>().To<AddColorService>().InSingletonScope();
			Bind<IScoreController>().To<ScoreController>().InSingletonScope();
			Bind<IStateController>().To<StateController>().InSingletonScope();
			Bind<IResultController>().To<ResultController>().InSingletonScope();
			Bind<IPrintMenuService>().To<PrintMenuService>().InSingletonScope();
			Bind<IGameMovesService>().To<GameMovesService>().InSingletonScope();
			Bind<IAddRandomService>().To<AddRandomService>().InSingletonScope();
			Bind<IPrintResultState>().To<PrintResultState>().InSingletonScope();
			Bind<IState>().To<PrintYouWin>().InSingletonScope().Named("YouWin");
            Bind<IState>().To<PrintYouLose>().InSingletonScope().Named("YouLost");
			Bind<IPrintBoardService>().To<PrintBoardService>().InSingletonScope();
			Bind<IPrintStateService>().To<PrintStateService>().InSingletonScope();
			Bind<IRestartGameService>().To<RestartGameService>().InSingletonScope();
			Bind<IPrintHeadingService>().To<PrintHeadingService>().InSingletonScope();
			Bind<IGameMovesController>().To<GameMovesController>().InSingletonScope();
			Bind<IAddRandomController>().To<AddRandomController>().InSingletonScope();
			Bind<IPrintBoardController>().To<PrintBoardController>().InSingletonScope();
			Bind<IPrintStateController>().To<PrintStateController>().InSingletonScope();
            Bind<IGameEngineController>().To<GameEngineController>().InSingletonScope();
			Bind<IPrintResultController>().To<PrintResultController>().InSingletonScope();
			Bind<IInitializeBoardService>().To<InitializeBoardService>().InSingletonScope();
			Bind<IPrintPressAnyButtonService>().To<PrintPressAnyButtonService>().InSingletonScope();
			Bind<ITwoZeroFourEightGameController>().To<TwoZeroFourEightGameController>().InSingletonScope();
		}
	}
}

