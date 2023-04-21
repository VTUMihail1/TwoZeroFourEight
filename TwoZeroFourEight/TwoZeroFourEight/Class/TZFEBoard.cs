class TZFEBoard : ITZFEBoard
{
	public int[,] InitialiseBoard(int size)
	{
		int[,] array = new int[size, size];
		return array;
	}
}
