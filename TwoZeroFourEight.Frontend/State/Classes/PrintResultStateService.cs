using TwoZeroFourEight.Frontend.State.Interfaces;

namespace TwoZeroFourEight.Frontend.State.Classes
{
    public class PrintResultStateService : IPrintResultStateService
    {
        private IState _state;

        public void Select(IState state)
        {
            _state = state;
        }
        public string Print()
        {
            string message = _state.GetResult();

            return message;
        }
    }
}

