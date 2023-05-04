using Ninject;
using TwoZeroFourEight.OnConfigurationFolder.Dependencies;
using TwoZeroFourEight.TwoZeroFourEightFolder.Interfaces;

IKernel kernel = new StandardKernel(new TZFEModule());
IGame tzfe = kernel.Get<IGame>();

tzfe.Start();
