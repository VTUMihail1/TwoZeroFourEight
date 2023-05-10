using TwoZeroFourEight.Services.Interfaces;

namespace TwoZeroFourEight.Services.Classes
{
    public partial class Score : IScore
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
                return _bestScore;
            }
            set
            {
                if (_score > _bestScore)
                {
                    _bestScore = _score;
                }
            }
        }

    }
}

