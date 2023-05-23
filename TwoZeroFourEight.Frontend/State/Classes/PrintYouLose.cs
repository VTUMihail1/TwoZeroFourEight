using TwoZeroFourEight.Frontend.Score.Interfaces;
using TwoZeroFourEight.Frontend.State.Interfaces;

namespace TwoZeroFourEight.Frontend.State.Classes
{
    public class PrintYouLose : IState
    {

        private IScoreService _scoreService;

        public PrintYouLose(IScoreService scoreService)
        {
            _scoreService = scoreService;
        }

        public string GetResult()
        {
            string gap = string.Concat(Enumerable.Repeat(" ", (StaticData.size - 4) * 9 / 2));

            string message = $"\n\n\n{gap}              YOU LOST \n\n\n" +
                             $"{gap}       SCORE FROM LAST GAME: \n" +
                             $"{gap}                {_scoreService.ManageLastScore}\n\n" +
                             $"{gap}    HIGHEST TILE FROM LAST GAME: \n" +
                             $"{gap}                {_scoreService.HighestTileScore}\n\n" +
                             $"{gap}         PRESS ANY BUTTON \n" +
                             $"{gap}            TO CONTINUE";

            return message;
        }
    }
}

