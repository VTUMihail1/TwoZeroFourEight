namespace TwoZeroFourEight.TwoZeroFourEightFolder.Interfaces
{
    public interface IPrint
    {
		void PrintHeading(IScore score, int size);
		void PrintMenu();
		void DisplayPrint(IScore score, int[,] array);
	}
}
