using TwoZeroFourEight.Frontend.Services.Interfaces;

namespace TwoZeroFourEight.Frontend.Services.Classes
{
    public class PrintMenuService : IPrintMenuService
    {
        private readonly ILoggerService _loggerService;

        public PrintMenuService(ILoggerService loggerService)
        {
            _loggerService = loggerService;
        }


        public void PrintMenu()
        {

            _loggerService.WriteLine(StaticData.menu);
        }

    }
}

