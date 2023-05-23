using TwoZeroFourEight.Backend.Board.Interfaces;

namespace TwoZeroFourEight.Backend.Board.Classes
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