namespace TwoZeroFourEight.TwoZeroFourEightFolder.Interfaces 
{
	public interface IScore
	{
		int BestScore { get; set; }
		int LastScore { get; set; }
		int ScoreCalculator(int[,] array);
	}
}

