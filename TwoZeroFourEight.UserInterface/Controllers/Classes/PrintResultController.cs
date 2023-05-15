using TwoZeroFourEight.Frontend.Services.Interfaces;
using TwoZeroFourEight.Frontend.Controllers.Interfaces;

namespace TwoZeroFourEight.Frontend.Controllers.Classes
{
    public class PrintResultController : IPrintResultController
    {
        private readonly IPrintStateController _printStateController;
        private readonly ILoggerService _loggerService;
        private readonly IPrintHeadingService _printHeadingService;
        public PrintResultController(IPrintStateController printStateController, ILoggerService loggerService, IPrintHeadingService printHeadingService)
        {
            _printStateController = printStateController;
            _loggerService = loggerService;
            _printHeadingService = printHeadingService;
        }
        public void PrintGameOverScreen(int size)
        {
            string message = _printStateController.PrintGameResult(size);
            if (!string.IsNullOrEmpty(message))
            {
                _loggerService.Clear();
                _loggerService.WriteLine(message);
                _loggerService.ReadKey();
                _loggerService.Clear();
                _printHeadingService.PrintHeading(size);
            }
        }
    }
}

