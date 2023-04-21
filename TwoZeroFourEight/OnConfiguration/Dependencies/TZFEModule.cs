using Ninject.Modules;
using TwoZeroFourEight.Logger.Class;
using TwoZeroFourEight.Logger.Interface;
using TwoZeroFourEight.TwoZeroFourEight.Interface;
using TwoZeroFourEight.TwoZeroFourEight.Interface.Services;

public class TZFEModule : NinjectModule
{
	public override void Load()
	{
		Bind<Random>().ToSelf();
		Bind<ITZFEBoard>().To<TZFEBoard>();
		Bind<ITZFEScore>().To<TZFEScore>();
		Bind<ITZFEGame>().To<TZFEGame>();
		Bind<IAddColorService>().To<AddColorService>();
		Bind<ILogger>().To<Logger>();
		Bind<IAddRandomService>().To<AddRandomService>();
		Bind<IRestartGameService>().To<RestartGameService>();
		Bind<IYouLostService>().To<YouLostService>();
		Bind<ITZFEPrint>().To<TZFEPrint>();
		Bind<ITZFEMoves>().To<TZFEMoves>();
		Bind<ITZFEConfiguration>().To<TZFEConfiguration>();
		Bind<ITZFESetup>().To<TZFESetup>();
	}
}
