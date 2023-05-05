using Ninject;
using TwoZeroFourEight.OnConfigurationFolder.Dependencies;
using TwoZeroFourEight.TwoZeroFourEightFolder.Interfaces;

IKernel kernel = new StandardKernel(new TwoZeroFourEightModule());
IGameManager tzfe = kernel.Get<IGameManager>();

tzfe.Start();
