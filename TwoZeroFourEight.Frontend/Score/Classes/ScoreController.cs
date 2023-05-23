using TwoZeroFourEight.Frontend.Score.Interfaces;

namespace TwoZeroFourEight.Frontend.Score.Classes
{
    public class ScoreController : IScoreController
    {
        private readonly IScoreService _scoreService;

        public ScoreController(IScoreService scoreService)
        {
            _scoreService = scoreService;
        }

        public void UpdateCurrentScore(int number)
        {
            _scoreService.ManageCurrentScore += number;
        }

        public void UpdateBestScore()
        {
            _scoreService.ManageBestScore = _scoreService.ManageCurrentScore;
        }

        public void UpdateLastScore(int number)
        {
            _scoreService.ManageLastScore += number;
        }

        public void Calculate(int highestTile)
        {
            _scoreService.HighestTileScore = highestTile;
            _scoreService.ManageLastScore = _scoreService.ManageCurrentScore;
            _scoreService.ManageBestScore = _scoreService.ManageCurrentScore;
            _scoreService.ManageCurrentScore = StaticData.emptySpot;
        }
    }
}
