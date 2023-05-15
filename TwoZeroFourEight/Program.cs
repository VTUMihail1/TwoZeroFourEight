using Ninject;
using TwoZeroFourEight.Backend.Controllers.Interfaces;
using TwoZeroFourEight.OnConfigurationFolder.Dependencies;

IKernel kernel = new StandardKernel(new TwoZeroFourEightModule());
ITwoZeroFourEightGameController tzfe = kernel.Get<ITwoZeroFourEightGameController>();

tzfe.Play(4);
