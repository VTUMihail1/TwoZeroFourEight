using TwoZeroFourEight.Backend.Services.Interfaces;

namespace TwoZeroFourEight.Backend.Services.Classes
{
    public class InitializeBoardService : IInitializeBoardService
    {

        public int[,] InitializeBoard()
        {
            int[,] array = new int[StaticData.size, StaticData.size];

            return array;
        }

    }
}