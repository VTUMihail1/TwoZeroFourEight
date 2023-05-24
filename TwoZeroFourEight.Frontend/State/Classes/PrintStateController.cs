using TwoZeroFourEight.Frontend.Score.Interfaces;
using TwoZeroFourEight.Frontend.State.Interfaces;

namespace TwoZeroFourEight.Frontend.State.Classes
{
    public class PrintStateController : IPrintStateController
    {
        private readonly IPrintResultStateService _printResultStateService;

        private readonly IPrintStateService _printStateService;

        private readonly IScoreService _scoreService;

        public PrintStateController(IPrintResultStateService printResultStateService, IScoreService scoreService, IPrintStateService printStateService)
        {
            _printResultStateService = printResultStateService;
            _scoreService = scoreService;
            _printStateService = printStateService;
        }


        public string Print()
        {
            string message = string.Empty;

            bool bestScoreIsNotZero = _scoreService.ManageBestScore != StaticData.lowestScore;

            if (bestScoreIsNotZero)
            {
                int maxTile = _scoreService.HighestTileScore;

                _printStateService.Strategy(maxTile);

                message = _printResultStateService.Print();
            }

            return message;
        }
    }
}

