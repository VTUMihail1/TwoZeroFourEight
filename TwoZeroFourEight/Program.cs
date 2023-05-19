using Ninject;
using TwoZeroFourEight.Backend.Controllers.Interfaces;
using TwoZeroFourEight.OnConfigurationFolder.Dependencies;

IKernel kernel = new StandardKernel(new TwoZeroFourEightModule());
ITwoZeroFourEightGameController game = kernel.Get<ITwoZeroFourEightGameController>();

game.Play(4);