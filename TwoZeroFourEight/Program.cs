using Ninject;
using TwoZeroFourEight.TwoZeroFourEight.Interface;

IKernel kernel = new StandardKernel(new TZFEModule());
ITZFE tzfe = kernel.Get<ITZFE>();

tzfe.Start();