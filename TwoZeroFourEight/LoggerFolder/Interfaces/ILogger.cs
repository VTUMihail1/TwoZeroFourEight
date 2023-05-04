namespace TwoZeroFourEight.LoggerFolder.Interfaces
{
    public interface ILogger
    {
        void WriteLine(string message);
        void Write(string message);
        void Clear();

	}
}
