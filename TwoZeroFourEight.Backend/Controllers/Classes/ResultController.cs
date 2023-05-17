using TwoZeroFourEight.Backend.Services.Interfaces;
using TwoZeroFourEight.Backend.Controllers.Interfaces;

namespace TwoZeroFourEight.Backend.Controllers.Classes
{
    public class ResultController : IResultController
    {

        private readonly IYouWinService _youWinService;

        private readonly IYouLostService _youLostService;


        public ResultController(IYouWinService youWinService, IYouLostService youLostService)
        {
            _youWinService = youWinService;

            _youLostService = youLostService;
        }


        public bool Result(int[,] array)
        {
            bool result = _youWinService.YouWin(array) || _youLostService.YouLost(array);

            return result;
        }


    }
}
