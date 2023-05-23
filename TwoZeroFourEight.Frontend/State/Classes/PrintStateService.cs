using Ninject;
using TwoZeroFourEight.Frontend.State.Interfaces;

namespace TwoZeroFourEight.Frontend.State.Classes
{
    public class PrintStateService : IPrintStateService
    {

        private readonly IState _youWin;

        private readonly IState _youLost;

        private readonly IPrintResultState _printResultState;

        public PrintStateService([Named("YouWin")] IState youWin, [Named("YouLost")] IState youLost, IPrintResultState printResultState)
        {
            _youWin = youWin;
            _youLost = youLost;
            _printResultState = printResultState;
        }

        public void Strategy(int maxTile)
        {
            IState result = maxTile == StaticData.maxTile ? _youWin : _youLost;

            _printResultState.Select(result);
        }

    }
}

