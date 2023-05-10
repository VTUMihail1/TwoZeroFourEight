using TwoZeroFourEight.Services.Interfaces;
using TwoZeroFourEight.UserInterfaces.Interfaces;

namespace TwoZeroFourEight.UserInterfaces.Classes
{
    public class PrintStateManager : IPrintStateManager
    {
        private readonly IPrintState _state;
        private readonly IScore _score;
        public PrintStateManager(IPrintState state, IScore score)
        {
            _state = state;
            _score = score;
        }
        public string PrintGameResult(int size)
        {
            int lowestScore = 0;
            string message = string.Empty;
            if (_score.ManageBestScore != lowestScore)
            {
                int maxTile = 2048;
                message = _score.HighestTileScore == maxTile
                    ? _state.YouWon(size)
                    : _state.YouLost(size);
            }
            return message;
        }
    }
}

