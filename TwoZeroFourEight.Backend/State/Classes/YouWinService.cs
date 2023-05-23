using TwoZeroFourEight.Backend.State.Interfaces;

namespace TwoZeroFourEight.Backend.State.Classes
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
