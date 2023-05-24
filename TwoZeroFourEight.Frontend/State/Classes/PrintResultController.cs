using TwoZeroFourEight.Frontend.State.Interfaces;

namespace TwoZeroFourEight.Frontend.State.Classes
{
    public class PrintResultController : IPrintResultController
    {
        private readonly IPrintRestartService _printRestartService;

        private readonly IPrintStateController _printStateController;

        public PrintResultController(IPrintRestartService printRestartService, IPrintStateController printStateController)
        {
            _printRestartService = printRestartService;
            _printStateController = printStateController;
        }


        public void Print()
        {
            string message = _printStateController.Print();

            bool messageIsNotNull = !string.IsNullOrEmpty(message);

            if (messageIsNotNull)
            {
                _printRestartService.Restart(message);
            }

        }
    }
}

