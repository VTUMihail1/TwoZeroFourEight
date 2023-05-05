using TwoZeroFourEight.TwoZeroFourEightFolder.Interfaces;

namespace TwoZeroFourEight.TwoZeroFourEightFolder.Classes	
{
	class Score : IScore
	{
		public int BestScore
		{
			get{return _bestScore;} 
			set{_bestScore = value;}
		}
		public int LastScore
		{
			get { return _lastScore; }
			set { _lastScore = value; }
		}
		private int _lastScore;
		private int _bestScore;
		public int ScoreCalculator(int[,] array)
		{
			int size = array.GetLength(0);
			int score = 0;
			for (int i = 0; i < size; i++)
			{
				for (int j = 0; j < size; j++)
				{
					int multiplier = 1;
					int current = array[i, j];
					while (current > 2)
					{
						score += current / 2 * multiplier;
						multiplier *= 2;
						current /= 2;
					}
				}
			}
			_bestScore = Math.Max(_bestScore, score);
			_lastScore = score;
			return score;
		}
	}
}

