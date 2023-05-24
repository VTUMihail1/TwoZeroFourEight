using TwoZeroFourEight.Backend.Board.Interfaces;
using TwoZeroFourEight.Exceptions.Exceptions;

namespace TwoZeroFourEight.Backend.Board.Classes
{
    public class InitializeBoardService : IInitializeBoardService
    {

        public int[,] InitializeBoard()
        {
            try
            {
                bool cantPlay = StaticData.size < StaticData.minSize || StaticData.maxSize < StaticData.size;

                if (cantPlay)
                {
                    throw new InvalidSizeException("Invalid size");
                }

                int[,] array = new int[StaticData.size, StaticData.size];

                return array;
            }

            catch(InvalidSizeException)
            {
                return null;
            }
        }

    }
}