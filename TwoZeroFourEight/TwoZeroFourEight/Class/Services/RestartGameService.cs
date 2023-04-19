class RestartGameService : IRestartGameService
{
	public void RestartGame(int[,] array)
	{
		int size = 4;
		for (int i = 0; i < size; i++)
		{
			for (int j = 0; j < size; j++)
			{
				array[i, j] = 0;
			}
		}
	}
}
