namespace TwoZeroFourEight.Frontend.State.Interfaces
{
    public interface IPrintResultState
    {
        string Print();
        void Select(IState state);
    }
}