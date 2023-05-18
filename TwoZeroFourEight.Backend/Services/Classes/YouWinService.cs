using TwoZeroFourEight.Backend.Services.Interfaces;

namespace TwoZeroFourEight.Backend.Services.Classes
{
    public class YouWinService : IYouWinService
    {

        public bool YouWin(int[,] array)
        {

            bool result = array.Cast<int>().Any(tile => tile == StaticData.maxTile);

            return result;
        }

    }
}
