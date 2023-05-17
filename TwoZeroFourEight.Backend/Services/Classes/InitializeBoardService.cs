using TwoZeroFourEight.Backend.Services.Interfaces;

namespace TwoZeroFourEight.Backend.Services.Classes
{
    public class InitializeBoardService : IInitializeBoardService
    {

        public int[,] InitializeBoard(int size)
        {
            int[,] array = new int[size, size];

            return array;
        }

    }
}