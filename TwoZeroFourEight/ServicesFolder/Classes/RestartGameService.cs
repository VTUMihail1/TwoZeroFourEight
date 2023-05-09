using TwoZeroFourEight.ServicesFolder.Interfaces;
using TwoZeroFourEight.TwoZeroFourEightFolder.Interfaces;

namespace TwoZeroFourEight.ServicesFolder.Classes
{
	class RestartGameService : IRestartGameService
	{
		private IScore _score;
        public RestartGameService(IScore score)
        {
			_score = score;
        }
        public void RestartGame(int[,] array)
		{
			_score.HighestTileScore = array.Cast<int>().Max();
			_score.ManageLastScore = _score.ManageScore;
			_score.ManageBestScore = _score.ManageLastScore;
			_score.ManageScore = 0;
			int size = array.GetLength(0);
			for (int i = 0; i < size; i++)
			{
				for (int j = 0; j < size; j++)
				{
					array[i, j] = 0;
				}
			}
		}
	}
}

