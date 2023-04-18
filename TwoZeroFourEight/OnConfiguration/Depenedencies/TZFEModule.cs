using Ninject.Modules;
using System;
using TwoZeroFourEight.Logger.Class;
using TwoZeroFourEight.Logger.Interface;
using TwoZeroFourEight.TwoZeroFourEight.Interface;

public class TZFEModule : NinjectModule
{
	public override void Load()
	{
		Bind<ILogger>().To<Logger>();
		Bind<ITZFEPrint>().To<TZFEPrint>();
		Bind<ITZFEMoves>().To<TZFEMoves>();
		Bind<ITZFEServices>().To<TZFEServices>();
		Bind<ITZFE>().To<TZFE>();
	}
}
