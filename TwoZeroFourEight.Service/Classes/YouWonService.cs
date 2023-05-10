using TwoZeroFourEight.Services.Interfaces;

namespace TwoZeroFourEight.Services.Classes
{
	public class YouWonService : IYouWonService
	{
		public bool YouWon(int[,] array)
		{
			int maxTile = 2048;
			bool result = array.Cast<int>().Any(tile => tile == maxTile);
			return result;
		}
	}
}
