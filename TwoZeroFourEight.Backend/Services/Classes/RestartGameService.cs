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
            int highestTile = array.Cast<int>().Max();

            _scoreService.HighestTileScore = highestTile;
            _scoreService.ManageLastScore = _scoreService.ManageCurrentScore;
            _scoreService.ManageBestScore = _scoreService.ManageCurrentScore;
            _scoreService.ManageCurrentScore = StaticData.emptySpot;

            for (int i = 0; i < StaticData.size; i++)
            {

                for (int j = 0; j < StaticData.size; j++)
                {
                    array[i, j] = StaticData.minTile;
                }

            }

        }

    }
}

