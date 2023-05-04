using TwoZeroFourEight.LoggerFolder.Interfaces;

namespace TwoZeroFourEight.LoggerFolder.Classes
{
    public class Logger : ILogger
    {
        public void WriteLine(string message)
        {
            Console.WriteLine(message);
        }
        public void Write(string message)
        {
            Console.Write(message);
        }
        public void Clear()
        {
            Console.Clear();
        }

    }
}
