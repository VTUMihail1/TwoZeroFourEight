using TwoZeroFourEight.Services.Interfaces;
using TwoZeroFourEight.UserInterface.Interfaces;

namespace TwoZeroFourEight.UserInterface.Classes
{
    public class PrintState : IPrintState
    {
        public IScore _score;
        public PrintState(IScore score)
        {
            _score = score;
        }
        public string YouLost(int size)
        {
            string gap = string.Concat(Enumerable.Repeat(" ", (size - 4) * 9 / 2));
            string message = $"\n\n\n{gap}             GAME OVER \n\n" +
                             $"{gap}       SCORE FROM LAST GAME: \n" +
                             $"{gap}                {_score.ManageLastScore}\n\n" +
                             $"{gap}    HIGHEST TILE FROM LAST GAME: \n" +
                             $"{gap}                {_score.HighestTileScore}\n\n" +
                             $"{gap}         PRESS ANY BUTTON \n" +
                             $"{gap}            TO CONTINUE";
            return message;
        }
        public string YouWon(int size)
        {
            string gap = string.Concat(Enumerable.Repeat(" ", (size - 4) * 9 / 2));
            string message = $"\n\n\n{gap}              YOU WON \n\n\n" +
                             $"{gap}       SCORE FROM LAST GAME: \n" +
                             $"{gap}                {_score.ManageLastScore}\n\n" +
                             $"{gap}    HIGHEST TILE FROM LAST GAME: \n" +
                             $"{gap}                {_score.HighestTileScore}\n\n" +
                             $"{gap}         PRESS ANY BUTTON \n" +
                             $"{gap}            TO CONTINUE";
            return message;
        }
    }
}

