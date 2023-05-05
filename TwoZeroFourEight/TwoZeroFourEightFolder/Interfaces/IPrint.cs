namespace TwoZeroFourEight.TwoZeroFourEightFolder.Interfaces
{
    public interface IPrint
    {
		void PrintHeading(int score, int bestScore);
		void PrintMenu();
		void DisplayPrint(int[,] array, int lastScore, int bestScore);
	}
}
