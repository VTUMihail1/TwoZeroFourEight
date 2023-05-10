using TwoZeroFourEight.Services.Interfaces;

namespace TwoZeroFourEight.Services.Classes
{
	public class Score : IScore
    {
        private int _bestScore;
        private int _score;
        private int _highestTile;
        public int ManageLastScore { get; set; }
        public int ManageScore { get { return _score; } set { _score = value; } }
        public int HighestTileScore { get { return _highestTile; } set { _highestTile = value; } }
        public int ManageBestScore
        {
            get
            {
                if (_score > _bestScore)
                {
                    _bestScore = _score;
                }
                return _bestScore;
            }
            set { _bestScore = value; }
        }

    }
}

