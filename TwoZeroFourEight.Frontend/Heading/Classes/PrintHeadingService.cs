using System.Drawing;
using TwoZeroFourEight.Exceptions.Exceptions;
using TwoZeroFourEight.Frontend.Heading.Interfaces;
using TwoZeroFourEight.Frontend.Logger.Interfaces;
using TwoZeroFourEight.Frontend.Score.Interfaces;

namespace TwoZeroFourEight.Frontend.Heading.Classes
{
    public class PrintHeadingService : IPrintHeadingService
    {
        private readonly ILoggerService _loggerService;

        private readonly IScoreService _scoreService;

        public PrintHeadingService(ILoggerService loggerService, IScoreService scoreService)
        {
            _loggerService = loggerService;

            _scoreService = scoreService;
        }


        public void PrintHeading()
        {
            try
            {
                int gapSize = StaticData.size - 4;

                if (gapSize < 0)
                {
                    throw new InvalidSizeException("Invalid size");
                }

                string gap = string.Concat(Enumerable.Repeat(" ", (StaticData.size - 1) * 9 - 6));

                string message = $"2048{gap}BEST SCORE: {_scoreService.ManageBestScore}\n" +
                                 $"{gap}    SCORE: {_scoreService.ManageCurrentScore}\n";

                _loggerService.Clear();

                _loggerService.WriteLine(message);
            }
            catch(InvalidSizeException)
            {

            }
        }

    }

}

