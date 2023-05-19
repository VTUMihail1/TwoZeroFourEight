using System.Drawing;
using TwoZeroFourEight.Frontend.Services.Interfaces;

namespace TwoZeroFourEight.Frontend.Services.Classes
{
    public class PrintPressAnyButtonService : IPrintPressAnyButtonService
    {
        private readonly ILoggerService _loggerService;

        public PrintPressAnyButtonService(ILoggerService loggerService)
        {
            _loggerService = loggerService;
        }


        public void PrintPressAnyButton()
        {
            string gap = string.Concat(Enumerable.Repeat(" ", (StaticData.size - 4) * 9 / 2));

            string message = $"\n\n{gap}          PRESS ANY ARROW \n" +
                                  $"{gap}         TO START THE GAME\n\n\n\n";

            _loggerService.WriteLine(message);
        }
    }

}

