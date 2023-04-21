using TwoZeroFourEight.TwoZeroFourEight.Interface;

class TZFEGame : ITZFEGame
{
	private readonly ITZFESetup _setup;
	public TZFEGame(ITZFESetup setup, ITZFEScore score)
	{
		_setup = setup;
	}
	public void Start()
	{
		_setup.Setup();
	}
}