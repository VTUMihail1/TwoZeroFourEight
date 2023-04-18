using System;
using TwoZeroFourEight.StaticRandom.Class;

class TZFEServices : ITZFEServices
{
	private int[,] _array;
	public void GetArrayRef(int[,] array)
	{
		_array = array;
	}
	public void Add()
	{
		int result = StaticRandom.RandomInt(16);
		while (_array.Cast<int>().Any(tile => tile == 0))
		{
			if (_array[result / 4, result % 4] == 0)
			{
				_array[result / 4, result % 4] = 2;
				return;
			}
			result = StaticRandom.RandomInt(16);
		}
		YouLostChecker();
	}
    public void Restart()
    {
        Array.Clear(_array, 0, 16);
        Add();
    }

	private void YouLostChecker()
	{
		for (int i = 0; i < 4; i++)
		{
			for (int j = 0; j < 4; j++)
			{
				if (j < 3 && _array[i, j + 1] == _array[i, j] || i < 3 && _array[i + 1, j] == _array[i, j] || _array[i, j] == 0)
				{
					return;
				}
			}
		}
		Restart();
	}
}
