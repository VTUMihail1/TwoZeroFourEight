using TwoZeroFourEight.Frontend.State.Interfaces;

namespace TwoZeroFourEight.Frontend.State.Classes
{
    public class PrintResultController : IPrintResultController
    {
        private readonly IPrintRestart _printRestart;

        private readonly IPrintStateController _printStateController;

        public PrintResultController(IPrintRestart printRestart, IPrintStateController printStateController)
        {
            _printRestart = printRestart;
            _printStateController = printStateController;
        }


        public void PrintGameOverScreen()
        {
            string message = _printStateController.PrintGameResult();

            bool messageIsNotNull = !string.IsNullOrEmpty(message);

            if (messageIsNotNull)
            {
                _printRestart.Restart(message);
            }

        }
    }
}

