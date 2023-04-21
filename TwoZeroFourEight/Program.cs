using Ninject;

IKernel kernel = new StandardKernel(new TZFEModule());
ITZFEGame tzfe = kernel.Get<ITZFEGame>();

tzfe.Start();
