using TwoZeroFourEight.Services.Interfaces;

namespace TwoZeroFourEight.Services.Classes
{
    public class ResultManager : IResultManager
    {
        private readonly IYouWonService _winService;
        private readonly IYouLostService _lostService;
        public ResultManager(IYouWonService winService, IYouLostService lostService)
        {
            _winService = winService;
            _lostService = lostService;
        }
        public bool ManageResult(int[,] array)
        {
            bool result = _winService.YouWon(array) || _lostService.YouLost(array);
            return result;
        }
    }
}
