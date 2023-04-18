using TwoZeroFourEight.TwoZeroFourEight.Interface;

class TZFEMoves : ITZFEMoves
{
	private int[,] _array;
    private int currentIndex;
    private int currentNumber;

	public void GetArrayRef(int[,] array)
	{
		_array = array;
	}
	public void Left(ref int score)
	{
		for (int i = 0; i < 4; i++)
		{
			currentIndex = 0;
			currentNumber = 0;

			for (int j = 0; j < 4; j++)
			{
				if (_array[i, j] != 0)
				{
					if (currentNumber == _array[i, j])
					{
						_array[i, currentIndex++] = currentNumber * 2;
						score += currentNumber * 2;
						currentNumber = 0;
					}
					else if (currentNumber == 0)
					{
						currentNumber = _array[i, j];
					}
					else
					{
						_array[i, currentIndex++] = currentNumber;
						currentNumber = _array[i, j];
					}
					_array[i, j] = 0;
				}
			}
			if (currentNumber != 0)
			{
				_array[i, currentIndex] = currentNumber;
			}
		}
	}
	public void Up(ref int score)
	{
		for (int i = 0; i < 4; i++)
		{
			currentIndex = 0;
			currentNumber = 0;

			for (int j = 0; j < 4; j++)
			{
				if (_array[j, i] != 0)
				{
					if (currentNumber == _array[j, i])
					{
						_array[currentIndex++, i] = currentNumber * 2;
						score += currentNumber * 2;
						currentNumber = 0;
					}
					else if (currentNumber == 0)
					{
						currentNumber = _array[j, i];
					}
					else
					{
						_array[currentIndex++, i] = currentNumber;
						currentNumber = _array[j, i];
					}
					_array[j, i] = 0;
				}
			}
			if (currentNumber != 0)
			{
				_array[currentIndex, i] = currentNumber;
			}
		}
	}
	public void Right(ref int score)
	{
		for (int i = 0; i < 4; i++)
		{
			currentIndex = 4 - 1;
			currentNumber = 0;

			for (int j = 4 - 1; j >= 0; j--)
			{
				if (_array[i, j] != 0)
				{
					if (currentNumber == _array[i, j])
					{
						_array[i, currentIndex--] = currentNumber * 2;
						score += currentNumber * 2;
						currentNumber = 0;
					}
					else if (currentNumber == 0)
					{
						currentNumber = _array[i, j];
					}
					else
					{
						_array[i, currentIndex--] = currentNumber;
						currentNumber = _array[i, j];
					}
					_array[i, j] = 0;
				}
			}
			if (currentNumber != 0)
			{
				_array[i, currentIndex] = currentNumber;
			}
		}
	}
	public void Down(ref int score)
	{
		for (int i = 0; i < 4; i++)
		{
			currentIndex = 4 - 1;
			currentNumber = 0;

			for (int j = 4 - 1; j >= 0; j--)
			{
				if (_array[j, i] != 0)
				{
					if (currentNumber == _array[j, i])
					{
						_array[currentIndex--, i] = currentNumber * 2;
						score += currentNumber * 2;
						currentNumber = 0;
					}
					else if (currentNumber == 0)
					{
						currentNumber = _array[j, i];
					}
					else
					{
						_array[currentIndex--, i] = currentNumber;
						currentNumber = _array[j, i];
					}
					_array[j, i] = 0;
				}
			}
			if (currentNumber != 0)
			{
				_array[currentIndex, i] = currentNumber;
			}
		}
	}
}
