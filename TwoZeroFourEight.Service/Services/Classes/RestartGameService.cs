using TwoZeroFourEight.Backend.Services.Interfaces;
using TwoZeroFourEight.Frontend.Services.Interfaces;

namespace TwoZeroFourEight.Backend.Services.Classes
{
    public class RestartGameService : IRestartGameService
    {
        private IScoreService _scoreService;
        public RestartGameService(IScoreService scoreService)
        {
            _scoreService = scoreService;
        }
        public void Restart(int[,] array)
        {
            _scoreService.HighestTileScore = array.Cast<int>().Max();
            _scoreService.ManageLastScore = _scoreService.ManageCurrentScore;
            _scoreService.ManageBestScore = _scoreService.ManageCurrentScore;
            _scoreService.ManageCurrentScore = 0;
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

