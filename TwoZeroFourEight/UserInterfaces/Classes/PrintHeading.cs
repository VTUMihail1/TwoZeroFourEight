using TwoZeroFourEight.Services.Interfaces;
using TwoZeroFourEight.UserInterfaces.Interfaces;

namespace TwoZeroFourEight.UserInterface.Classes
{
    public class PrintHeading : IPrintHeading
    {
        private readonly ILogger _logger;
        private readonly IScore _score;
        public PrintHeading(ILogger logger, IScore score)
        {
            _logger = logger;
            _score = score;
        }
        public void PrintGameHeading(int size)
        {
            string gap = string.Concat(Enumerable.Repeat(" ", (size - 1) * 9 - 6));
            string message = $"2048{gap}BEST SCORE: {_score.ManageBestScore}\n" +
                             $"{gap}    SCORE: {_score.ManageScore}\n";
            _logger.Clear();
            _logger.WriteLine(message);
        }
    }

}

