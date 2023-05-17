using TwoZeroFourEight.Frontend.Services.Interfaces;

namespace TwoZeroFourEight.Frontend.Services.Classes
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


        public void PrintHeading(int size)
        {
            string gap = string.Concat(Enumerable.Repeat(" ", (size - 1) * 9 - 6));

            string message = $"2048{gap}BEST SCORE: {_scoreService.ManageBestScore}\n" +
                             $"{gap}    SCORE: {_scoreService.ManageCurrentScore}\n";

            _loggerService.Clear();

            _loggerService.WriteLine(message);
        }

    }

}

