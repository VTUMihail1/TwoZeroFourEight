using System.Drawing;
using TwoZeroFourEight.Exceptions.Exceptions;
using TwoZeroFourEight.Frontend.Logger.Interfaces;
using TwoZeroFourEight.Frontend.State.Interfaces;

namespace TwoZeroFourEight.Frontend.State.Classes
{
    public class PrintPressAnyButtonService : IPrintPressAnyButtonService
    {
        private readonly ILoggerService _loggerService;

        public PrintPressAnyButtonService(ILoggerService loggerService)
        {
            _loggerService = loggerService;
        }

        public void Print()
        {
            try
            {
                int gapSize = StaticData.size - 4;

                if (gapSize < 0)
                {
                    throw new InvalidSizeException("Invalid size");
                }

                string gap = string.Concat(Enumerable.Repeat(" ", (StaticData.size - 4) * 9 / 2));

                string message = $"\n\n{gap}          PRESS ANY ARROW \n" +
                                 $"{gap}         TO START THE GAME\n\n\n\n";

                _loggerService.WriteLine(message);
            }

            catch (InvalidSizeException)
            {
                
            }
        }
    }
}

