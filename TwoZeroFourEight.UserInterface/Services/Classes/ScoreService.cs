using TwoZeroFourEight.Frontend.Services.Interfaces;

namespace TwoZeroFourEight.Frontend.Services.Classes
{
    public partial class ScoreService : IScoreService
    {
        private int _bestScore;
        private int _currentScore;
        private int _highestTile;
        public int ManageLastScore { get; set; }
        public int ManageCurrentScore { get { return _currentScore; } set { _currentScore = value; } }
        public int HighestTileScore { get { return _highestTile; } set { _highestTile = value; } }
        public int ManageBestScore
        {
            get
            {
                return _bestScore;
            }
            set
            {
                if (_currentScore > _bestScore)
                {
                    _bestScore = _currentScore;
                }
                if (value > _bestScore)
                {
                    _bestScore = value;
                }
            }
        }

    }
}

