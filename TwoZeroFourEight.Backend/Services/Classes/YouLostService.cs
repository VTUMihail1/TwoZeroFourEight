using TwoZeroFourEight.Backend.Services.Interfaces;

namespace TwoZeroFourEight.Backend.Services.Classes
{
    public class YouLostService : IYouLostService
    {
        public bool YouLost(int[,] array)
        {

			for (int i = 0; i < StaticData.size; i++)
            {

                for (int j = 0; j < StaticData.size; j++)
                {

                    bool youLostCheckOne = j < StaticData.size - 1 && array[i, j + 1] == array[i, j];
                    bool youLostCheckTwo = i < StaticData.size - 1 && array[i + 1, j] == array[i, j];
                    bool youLostCheckThree =  array[i, j] == StaticData.minTile;

					if (youLostCheckOne || youLostCheckTwo || youLostCheckThree)
                    {
                        return false;
                    }

                }

            }

            return true;
        }

    }
}
