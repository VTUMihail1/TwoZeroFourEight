using TwoZeroFourEight.Frontend.Logger.Interfaces;
using TwoZeroFourEight.Frontend.Menu.Interfaces;

namespace TwoZeroFourEight.Frontend.Menu.Classes
{
    public class PrintMenuService : IPrintMenuService
    {
        private readonly ILoggerService _loggerService;

        public PrintMenuService(ILoggerService loggerService)
        {
            _loggerService = loggerService;
        }


        public void Print()
        {

            _loggerService.WriteLine(StaticData.menu);
        }

    }
}

