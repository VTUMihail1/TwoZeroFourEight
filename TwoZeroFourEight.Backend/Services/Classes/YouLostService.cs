using TwoZeroFourEight.Backend.Services.Interfaces;

namespace TwoZeroFourEight.Backend.Services.Classes
{
    public class YouLostService : IYouLostService
    {
        public bool YouLost(int[,] array)
        {
            int size = array.GetLength(0);

			for (int i = 0; i < size; i++)
            {

                for (int j = 0; j < size; j++)
                {

                    bool youLostCheckOne = j < size - 1 && array[i, j + 1] == array[i, j];

                    bool youLostCheckTwo = i < size - 1 && array[i + 1, j] == array[i, j];

                    bool youLostCheckThree =  array[i, j] == 0;

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
