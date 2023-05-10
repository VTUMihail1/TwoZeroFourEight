using TwoZeroFourEight.UserInterfaces.Interfaces;

namespace TwoZeroFourEight.UserInterface.Classes
{
    public class PrintResultManager : IPrintResultManager
    {
        private readonly IPrintStateManager _stateManager;
        private readonly ILogger _logger;
        private readonly IPrintHeading _heading;
        public PrintResultManager(IPrintStateManager stateManager, ILogger logger, IPrintHeading heading)
        {
            _stateManager = stateManager;
            _logger = logger;
            _heading = heading;
        }
        public void GameOverPrint(int size)
        {
            string message = _stateManager.PrintGameResult(size);
            if (message != string.Empty)
            {
                _logger.Clear();
                _logger.WriteLine(message);
                _logger.ReadKey();
                _logger.Clear();
                _heading.PrintGameHeading(size);
            }
        }
    }
}

