using TwoZeroFourEight.UserInterfaces.Interfaces;

namespace TwoZeroFourEight.UserInterface.Classes
{
    public class PrintPressAnyButton : IPrintPressAnyButton
    {
        private readonly ILogger _logger;
        public PrintPressAnyButton(ILogger logger)
        {
            _logger = logger;
        }
        public void PressAnyButtonPrint(int size)
        {
            string gap = string.Concat(Enumerable.Repeat(" ", (size - 4) * 9 / 2));
            string message = $"\n\n{gap}          PRESS ANY ARROW \n" +
                                  $"{gap}         TO START THE GAME\n\n\n\n";
            _logger.WriteLine(message);
        }
    }

}

