using TwoZeroFourEight.ServicesFolder.Interfaces;

namespace TwoZeroFourEight.ServicesFolder.Classes
{
	class AddRandomService : IAddRandomService
	{
		private readonly Random _random;
		public AddRandomService(Random random)
		{
			_random = random;
		}
		public void AddRandom(int[,] array)
		{
			int size = 4;
			int result = _random.Next(size * size);
			if (array.Cast<int>().All(tile => tile == 0))
			{
				array[result / size, result % size] = 2;
			}
			while (array.Cast<int>().Any(tile => tile == 0))
			{
				result = _random.Next(16);
				if (array[result / size, result % size] == 0)
				{
					array[result / size, result % size] = 2;
					return;
				}
			}
		}
	}
}

