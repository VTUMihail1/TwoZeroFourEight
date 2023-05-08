using TwoZeroFourEight.TwoZeroFourEightFolder.Interfaces;

namespace TwoZeroFourEight.TwoZeroFourEightFolder.Classes	
{
	class Score : IScore
	{
		private int _bestScore;
		private int _score;
		public int ManageLastScore { get; set; }
		public int ManageScore { get { return _score; } set { _score = value; } }
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
		}

	}
}

