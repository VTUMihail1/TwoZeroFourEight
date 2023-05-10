using TwoZeroFourEight.Score.Interfaces;

namespace TwoZeroFourEight.Score.Classes
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
<<<<<<< HEAD:TwoZeroFourEight.Score/Classes/Score.cs
            }
            set
            {
                if (_score > _bestScore)
                {
                    _bestScore = _score;
                }
            }
=======
            }
            set {
				if (_score > _bestScore)
				{
					_bestScore = _score;
				}
			}
>>>>>>> e6b183b92ae3b63db532bceb674ba6e87fa428e3:TwoZeroFourEight/Services/Classes/Score.cs
        }

    }
}

