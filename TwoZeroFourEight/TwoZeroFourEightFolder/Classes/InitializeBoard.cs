using TwoZeroFourEight.TwoZeroFourEightFolder.Interfaces;

namespace TwoZeroFourEight.TwoZeroFourEightFolder.Classes
{
	class InitializeBoard : IInitializeBoard
	{
		public int[,] CreateBoard(int size)
		{
			int[,] array = new int[size, size];
			return array;
		}
	}
}