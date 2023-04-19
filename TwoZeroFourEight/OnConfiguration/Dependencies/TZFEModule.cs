﻿using Ninject;
using Ninject.Modules;
using System;
using TwoZeroFourEight.Logger.Class;
using TwoZeroFourEight.Logger.Interface;
using TwoZeroFourEight.TwoZeroFourEight.Interface;
using TwoZeroFourEight.TwoZeroFourEight.Interface.Services;

public class TZFEModule : NinjectModule
{
	public override void Load()
	{
		Bind<Random>().ToSelf();
		Bind<IAddColorService>().To<AddColorService>();
		Bind<ILogger>().To<Logger>();
		Bind<IAddRandomService>().To<AddRandomService>();
		Bind<IRestartGameService>().To<RestartGameService>();
		Bind<IYouLostService>().To<YouLostService>();
		Bind<ITZFEPrint>().To<TZFEPrint>();
		Bind<ITZFEMoves>().To<TZFEMoves>();
		Bind<ITZFEStartUp>().To<TZFEStartUp>();
		Bind<ITZFE>().To<TZFE>();
	}
}
