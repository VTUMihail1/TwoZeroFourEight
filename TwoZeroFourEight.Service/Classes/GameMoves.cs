using TwoZeroFourEight.Services.Interfaces;

namespace TwoZeroFourEight.Services.Classes
{
    public class GameMoves : IGameMoves
	{
		private IScore _score;

		public GameMoves(IScore score)
        {
			_score = score;
        }
        private int _size;
		private int currentIndex;
		private int currentNumber;
		public void Left(int[,] array)
		{
			_size = array.GetLength(0);
			for (int i = 0; i < _size; i++)
			{
				currentIndex = 0;
				currentNumber = 0;

				for (int j = 0; j < _size; j++)
				{
					if (array[i, j] != 0)
					{
						if (currentNumber == array[i, j])
						{
							array[i, currentIndex++] = currentNumber * 2;
							_score.ManageScore += currentNumber;
							currentNumber = 0;
						}
						else if (currentNumber == 0)
						{
							currentNumber = array[i, j];
						}
						else
						{
							array[i, currentIndex++] = currentNumber;
							currentNumber = array[i, j];
						}
						array[i, j] = 0;
					}
				}
				if (currentNumber != 0)
				{
					array[i, currentIndex] = currentNumber;
				}
			}
		}
		public void Up(int[,] array)
		{
			_size = array.GetLength(0);
			for (int i = 0; i < _size; i++)
			{
				currentIndex = 0;
				currentNumber = 0;

				for (int j = 0; j < _size; j++)
				{
					if (array[j, i] != 0)
					{
						if (currentNumber == array[j, i])
						{
							array[currentIndex++, i] = currentNumber * 2;
							_score.ManageScore += currentNumber;
							currentNumber = 0;
						}
						else if (currentNumber == 0)
						{
							currentNumber = array[j, i];
						}
						else
						{
							array[currentIndex++, i] = currentNumber;
							currentNumber = array[j, i];
						}
						array[j, i] = 0;
					}
				}
				if (currentNumber != 0)
				{
					array[currentIndex, i] = currentNumber;
				}
			}
		}
		public void Right(int[,] array)
		{
			_size = array.GetLength(0);
			for (int i = 0; i < _size; i++)
			{
				currentIndex = _size - 1;
				currentNumber = 0;

				for (int j = _size - 1; j >= 0; j--)
				{
					if (array[i, j] != 0)
					{
						if (currentNumber == array[i, j])
						{
							array[i, currentIndex--] = currentNumber * 2;
							_score.ManageScore += currentNumber;
							currentNumber = 0;
						}
						else if (currentNumber == 0)
						{
							currentNumber = array[i, j];
						}
						else
						{
							array[i, currentIndex--] = currentNumber;
							currentNumber = array[i, j];
						}
						array[i, j] = 0;
					}
				}
				if (currentNumber != 0)
				{
					array[i, currentIndex] = currentNumber;
				}
			}
		}
		public void Down(int[,] array)
		{
			_size = array.GetLength(0);
			for (int i = 0; i < _size; i++)
			{
				currentIndex = _size - 1;
				currentNumber = 0;

				for (int j = _size - 1; j >= 0; j--)
				{
					if (array[j, i] != 0)
					{
						if (currentNumber == array[j, i])
						{
							array[currentIndex--, i] = currentNumber * 2;
							_score.ManageScore += currentNumber;
							currentNumber = 0;
						}
						else if (currentNumber == 0)
						{
							currentNumber = array[j, i];
						}
						else
						{
							array[currentIndex--, i] = currentNumber;
							currentNumber = array[j, i];
						}
						array[j, i] = 0;
					}
				}
				if (currentNumber != 0)
				{
					array[currentIndex, i] = currentNumber;
				}
			}
		}
	}
}

