using TwoZeroFourEight.Backend.Services.Interfaces;

namespace TwoZeroFourEight.Backend.Services.Classes
{
    public class YouWinService : IYouWinService
    {

        public bool YouWin(int[,] array)
        {
            int maxTile = 2048;

            bool result = array.Cast<int>().Any(tile => tile == maxTile);

            return result;
        }

    }
}
