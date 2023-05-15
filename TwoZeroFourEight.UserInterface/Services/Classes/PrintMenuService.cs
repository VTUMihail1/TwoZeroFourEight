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
            string message = "\n\nPress UP ARROW to swipe up\n" +
                             "Press RIGHT ARROW to swipe right\n" +
                             "Press DOWN ARROW to swipe down\n" +
                             "Press LEFT ARROW to swipe left\n\n" +
                             "Press R to restart the game\n" +
                             "Press ESC to exit\n";
            _loggerService.WriteLine(message);
        }
    }

}

