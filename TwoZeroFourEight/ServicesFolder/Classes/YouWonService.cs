using TwoZeroFourEight.ServicesFolder.Interfaces;
using TwoZeroFourEight.TwoZeroFourEightFolder.Interfaces;

namespace TwoZeroFourEight.ServicesFolder.Classes
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
