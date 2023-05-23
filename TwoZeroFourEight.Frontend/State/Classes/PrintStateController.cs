using TwoZeroFourEight.Frontend.Score.Interfaces;
using TwoZeroFourEight.Frontend.State.Interfaces;

namespace TwoZeroFourEight.Frontend.State.Classes
{
    public class PrintStateController : IPrintStateController
    {
        private readonly IPrintResultState _printResultState;

        private readonly IPrintStateService _printStateService;

        private readonly IScoreService _scoreService;

        public PrintStateController(IPrintResultState printResultState, IScoreService scoreService, IPrintStateService printStateService)
        {
            _printResultState = printResultState;
            _scoreService = scoreService;
            _printStateService = printStateService;
        }


        public string PrintGameResult()
        {
            string message = string.Empty;

            bool bestScoreIsNotZero = _scoreService.ManageBestScore != StaticData.lowestScore;

            if (bestScoreIsNotZero)
            {
                int maxTile = _scoreService.HighestTileScore;

                _printStateService.Strategy(maxTile);

                message = _printResultState.Print();
            }

            return message;
        }
    }
}

