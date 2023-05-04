using TwoZeroFourEight.TwoZeroFourEightFolder.Interfaces;

namespace TwoZeroFourEight.TwoZeroFourEightFolder.Classes
{
	class Board : IBoard
	{
		public int[,] InitialiseBoard(int size)
		{
			int[,] array = new int[size, size];
			return array;
		}
	}
}