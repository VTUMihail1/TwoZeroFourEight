using TwoZeroFourEight.Frontend.Heading.Interfaces;
using TwoZeroFourEight.Frontend.Logger.Interfaces;
using TwoZeroFourEight.Frontend.State.Interfaces;

namespace TwoZeroFourEight.Frontend.State.Classes
{
    public class PrintRestartService : IPrintRestartService
    {
        private readonly ILoggerService _loggerService;
        private readonly IPrintHeadingService _printHeadingService;
        public PrintRestartService(ILoggerService loggerService, IPrintHeadingService printHeadingService)
        {
            _loggerService = loggerService;
            _printHeadingService = printHeadingService;
        }

        public void Restart(string message)
        {
            _loggerService.Clear();
            _loggerService.WriteLine(message);
            _loggerService.ReadKey();
            _loggerService.Clear();

            _printHeadingService.Print();
        }
    }
}
