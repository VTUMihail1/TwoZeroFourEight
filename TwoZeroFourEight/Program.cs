using Ninject;
using TwoZeroFourEight.OnConfigurationFolder.Dependencies;
using TwoZeroFourEight.Services.Interfaces;

IKernel kernel = new StandardKernel(new TwoZeroFourEightModule());
ITwoZeroFourEightGame tzfe = kernel.Get<ITwoZeroFourEightGame>();

tzfe.Play(4);
