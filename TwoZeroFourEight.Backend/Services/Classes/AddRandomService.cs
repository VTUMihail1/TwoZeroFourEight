using TwoZeroFourEight.Backend.Services.Interfaces;

namespace TwoZeroFourEight.Backend.Services.Classes
{
    public class AddRandomService : IAddRandomService
    {

        private readonly Random _random;


        public AddRandomService(Random random)
        {
            _random = random;
        }


        public void AddRandomElement(int[,] array)
        {
            int size = array.GetLength(0);

            int random = _random.Next(size * size);

            while (array.Cast<int>().Any(tile => tile == 0))
            {
                random = _random.Next(16);

                if (array[random / size, random % size] == 0)
                {
                    array[random / size, random % size] = 2;

                    return;
                }

            }

        }
    }
}

