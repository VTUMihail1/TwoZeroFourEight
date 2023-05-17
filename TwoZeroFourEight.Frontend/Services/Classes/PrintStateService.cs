using TwoZeroFourEight.Frontend.Services.Interfaces;

namespace TwoZeroFourEight.Frontend.Services.Classes
{
    public class PrintStateService : IPrintStateService
    {
        public IScoreService _scoreService;

        public PrintStateService(IScoreService scoreService)
        {
            _scoreService = scoreService;
        }


        public string YouLost(int size)
        {
            string gap = string.Concat(Enumerable.Repeat(" ", (size - 4) * 9 / 2));

            string message = $"\n\n\n{gap}             GAME OVER \n\n" +
                             $"{gap}       SCORE FROM LAST GAME: \n" +
                             $"{gap}                {_scoreService.ManageLastScore}\n\n" +
                             $"{gap}    HIGHEST TILE FROM LAST GAME: \n" +
                             $"{gap}                {_scoreService.HighestTileScore}\n\n" +
                             $"{gap}         PRESS ANY BUTTON \n" +
                             $"{gap}            TO CONTINUE";

            return message;
        }


        public string YouWin(int size)
        {
            string gap = string.Concat(Enumerable.Repeat(" ", (size - 4) * 9 / 2));

            string message = $"\n\n\n{gap}              YOU WON \n\n\n" +
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

