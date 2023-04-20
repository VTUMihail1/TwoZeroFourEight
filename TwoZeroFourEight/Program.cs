using Ninject;
using TwoZeroFourEight.TwoZeroFourEight.Interface;

IKernel kernel = new StandardKernel(new TZFEModule());
ITZFESetup tzfe = kernel.Get<ITZFESetup>();

tzfe.Setup();