using TwoZeroFourEight.TwoZeroFourEight.Interface;

class TZFE : ITZFE
{
    private readonly ITZFEPrint _print;
    private readonly ITZFEStartUp _services;
    public TZFE(ITZFEStartUp services, ITZFEPrint print)
    {
        _services = services;
        _print = print;
		_print.GetArrayRef(_services.Configuration());
	}
    public void Start()
    {
        while (true)
        {
            _print.PrintBoard();
            _print.PrintMenu();
            _services.Run();
        }
    }
}
