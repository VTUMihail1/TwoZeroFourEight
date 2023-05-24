using Ninject;
using TwoZeroFourEight.Frontend.State.Interfaces;

namespace TwoZeroFourEight.Frontend.State.Classes
{
    public class PrintStateService : IPrintStateService
    {

        private readonly IState _youWin;

        private readonly IState _youLost;

        private readonly IPrintResultStateService _printResultStateService;

        public PrintStateService([Named("YouWin")] IState youWin, [Named("YouLost")] IState youLost, IPrintResultStateService printResultStateService)
        {
            _youWin = youWin;
            _youLost = youLost;
            _printResultStateService = printResultStateService;
        }

        public void Strategy(int maxTile)
        {
            IState result = maxTile == StaticData.maxTile ? _youWin : _youLost;

            _printResultStateService.Select(result);
        }

    }
}

