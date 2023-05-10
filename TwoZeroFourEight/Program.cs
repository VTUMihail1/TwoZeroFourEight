using Ninject;
using TwoZeroFourEight.Services.Interfaces;
using TwoZeroFourEight.OnConfigurationFolder.Dependencies;

IKernel kernel = new StandardKernel(new TwoZeroFourEightModule());
ITwoZeroFourEightGame tzfe = kernel.Get<ITwoZeroFourEightGame>();

tzfe.Play(4);
