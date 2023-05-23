using TwoZeroFourEight.Frontend.Heading.Interfaces;
using TwoZeroFourEight.Frontend.Logger.Interfaces;
using TwoZeroFourEight.Frontend.State.Interfaces;

namespace TwoZeroFourEight.Frontend.State.Classes
{
    public class PrintRestart : IPrintRestart
    {
        private readonly ILoggerService _loggerService;
        private readonly IPrintHeadingService _printHeadingService;
        public PrintRestart(ILoggerService loggerService, IPrintHeadingService printHeadingService)
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

            _printHeadingService.PrintHeading();
        }
    }
}
