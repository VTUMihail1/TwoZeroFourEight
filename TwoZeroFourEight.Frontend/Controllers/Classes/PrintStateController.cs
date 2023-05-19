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


        public string PrintGameResult()
        {
            string message = string.Empty;

            bool bestScoreIsNotZero = _scoreService.ManageBestScore != StaticData.lowestScore;

			if (bestScoreIsNotZero)
            {
                message = _scoreService.HighestTileScore == StaticData.maxTile
                    ? _printStateService.YouWin()
                    : _printStateService.YouLost();
            }

            return message;
        }
    }
}

