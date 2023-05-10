using TwoZeroFourEight.Services.Interfaces;

namespace TwoZeroFourEight.Services.Classes
{
	public class InitializeBoard : IInitializeBoard
    {
        public int[,] CreateBoard(int size)
        {
            int[,] array = new int[size, size];
            return array;
        }
    }
}