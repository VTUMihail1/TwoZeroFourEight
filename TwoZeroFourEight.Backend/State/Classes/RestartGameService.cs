using TwoZeroFourEight.Backend.State.Interfaces;
using TwoZeroFourEight.Frontend.Score.Interfaces;

namespace TwoZeroFourEight.Backend.State.Classes
{
    public class RestartGameService : IRestartGameService
    {

        private IScoreController _scoreController;

        public RestartGameService(IScoreController scoreController)
        {
            _scoreController = scoreController;
        }


        public void Restart(int[,] array)
        {
            int highestTile = array.Cast<int>().Max();

            _scoreController.Calculate(highestTile);

            for (int i = 0; i < StaticData.size; i++)
            {

                for (int j = 0; j < StaticData.size; j++)
                {
                    array[i, j] = StaticData.emptySpot;
                }

            }

        }

    }
}

