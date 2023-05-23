using TwoZeroFourEight.Backend.Add.Interfaces;

namespace TwoZeroFourEight.Backend.Add.Classes
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

            int random = _random.Next(StaticData.numberOfSpots);

            bool arrayIsEmpty = array.Cast<int>().Any(tile => tile == StaticData.emptySpot);

            while (arrayIsEmpty)
            {
                random = _random.Next(StaticData.numberOfSpots);

                bool freeSpot = array[random / StaticData.size, random % StaticData.size] == StaticData.emptySpot;

                if (freeSpot)
                {
                    array[random / StaticData.size, random % StaticData.size] = StaticData.minTile;

                    return;
                }

            }

        }

    }
}

