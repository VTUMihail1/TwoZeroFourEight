using TwoZeroFourEight.Frontend.Score.Interfaces;

namespace TwoZeroFourEight.Frontend.Score.Classes
{
    public partial class ScoreService : IScoreService
    {
        private int _bestScore;

        private int _currentScore;

        private int _highestTile;

        public int ManageLastScore { get; set; }

        public int ManageCurrentScore
        {
            get
            {
                return _currentScore;
            }
            set
            {
                _currentScore = value;
            }
        }

        public int HighestTileScore
        {
            get
            {
                return _highestTile;
            }
            set
            {
                _highestTile = value;
            }
        }

        public int ManageBestScore
        {
            get
            {
                return _bestScore;
            }
            set
            {
                bool newBestScoreOptionOne = _currentScore > _bestScore;

                bool newBestScoreOptionTwo = value > _bestScore;

                if (newBestScoreOptionOne)
                {
                    _bestScore = _currentScore;
                }


                if (newBestScoreOptionTwo)
                {
                    _bestScore = value;
                }
            }
        }

    }
}

