using TwoZeroFourEight.TwoZeroFourEightFolder.Interfaces;

namespace TwoZeroFourEight.TwoZeroFourEightFolder.Classes	
{
	class Score : IScore
	{
		public int ScoreCalculator(int[,] array)
		{
			int score = 0;
			for (int i = 0; i < 4; i++)
			{
				for (int j = 0; j < 4; j++)
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
			return score;
		}
	}
}

