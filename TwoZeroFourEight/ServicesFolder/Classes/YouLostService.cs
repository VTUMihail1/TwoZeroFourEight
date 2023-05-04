using TwoZeroFourEight.ServicesFolder.Interfaces;

namespace TwoZeroFourEight.ServicesFolder.Classes
{
	class YouLostService : IYouLostService
	{
		public bool YouLost(int[,] array)
		{
			int size = 4;
			for (int i = 0; i < size; i++)
			{
				for (int j = 0; j < size; j++)
				{
					if (j < size - 1 && array[i, j + 1] == array[i, j] || i < size - 1 && array[i + 1, j] == array[i, j] || array[i, j] == 0)
					{
						return false;
					}
				}
			}
			return true;
		}
	}
}
