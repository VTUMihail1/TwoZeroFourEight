using TwoZeroFourEight.UserInterfaces.Interfaces;

namespace TwoZeroFourEight.UserInterfaces.Classes
{
    public class PrintMenu : IPrintMenu
    {
        private readonly ILogger _logger;
        public PrintMenu(ILogger logger)
        {
            _logger = logger;
        }
        public void PrintGameMenu()
        {
            string message = "\n\nPress UP ARROW to swipe up\n" +
                             "Press RIGHT ARROW to swipe right\n" +
                             "Press DOWN ARROW to swipe down\n" +
                             "Press LEFT ARROW to swipe left\n\n" +
                             "Press R to restart the game\n" +
                             "Press ESC to exit\n";
            _logger.WriteLine(message);
        }
    }

}

