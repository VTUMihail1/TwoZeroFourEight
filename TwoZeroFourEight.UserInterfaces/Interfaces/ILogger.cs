namespace TwoZeroFourEight.UserInterface.Interfaces
{
    public interface ILogger
    {
        void WriteLine(string? message = null);
        void Write(string? message = null);
        void Clear();
        void ReadKey();
    }
}
