using TwoZeroFourEight.Frontend.Controllers.Interfaces;
using TwoZeroFourEight.Frontend.Services.Interfaces;

namespace TwoZeroFourEight.Frontend.Controllers.Classes
{
    public class PrintStateController : IPrintStateController
    {
        private readonly IPrintStateService _printStateService;
        private readonly IScoreService _scoreService;
        public PrintStateController(IPrintStateService printStateService, IScoreService scoreService)
        {
            _printStateService = printStateService;
            _scoreService = scoreService;
        }
        public string PrintGameResult(int size)
        {
            int lowestScore = 0;
            string message = string.Empty;
            if (_scoreService.ManageBestScore != lowestScore)
            {
                int maxTile = 2048;
                message = _scoreService.HighestTileScore == maxTile
                    ? _printStateService.YouWin(size)
                    : _printStateService.YouLost(size);
            }
            return message;
        }
    }
}

