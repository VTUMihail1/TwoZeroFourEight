using TwoZeroFourEight.Exceptions.Exceptions;
using TwoZeroFourEight.Frontend.Score.Interfaces;
using TwoZeroFourEight.Frontend.State.Interfaces;

namespace TwoZeroFourEight.Frontend.State.Classes
{
    public class PrintYouWin : IState
    {

        private IScoreService _scoreService;

        public PrintYouWin(IScoreService scoreService)
        {
            _scoreService = scoreService;
        }

        public string GetResult()
        {
            try
            {
                int gapSize = StaticData.size - 4;

                if (gapSize < 0)
                {
                    throw new InvalidSizeException("Invalid size");
                }

                string gap = string.Concat(Enumerable.Repeat(" ", (StaticData.size - 4) * 9 / 2));

                string message = $"\n\n\n{gap}              YOU WON \n\n\n" +
                                 $"{gap}       SCORE FROM LAST GAME: \n" +
                                 $"{gap}                {_scoreService.ManageLastScore}\n\n" +
                                 $"{gap}    HIGHEST TILE FROM LAST GAME: \n" +
                                 $"{gap}                {_scoreService.HighestTileScore}\n\n" +
                                 $"{gap}         PRESS ANY BUTTON \n" +
                                 $"{gap}            TO CONTINUE";

                return message;
            }

            catch (InvalidSizeException)
            {
                return string.Empty;
            }
        }
    }
}

