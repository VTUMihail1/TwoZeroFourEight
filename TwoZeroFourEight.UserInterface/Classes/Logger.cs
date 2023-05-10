using TwoZeroFourEight.UserInterfaces.Interfaces;

namespace TwoZeroFourEight.UserInterfaces.Classes
{
    public class Logger : ILogger
    {
        public void WriteLine(string? message = null)
        {
            Console.WriteLine(message);
        }
        public void Write(string? message = null)
        {
            Console.Write(message);
        }
        public void Clear()
        {
            Console.Clear();
        }
        public void ReadKey()
        {
            Console.ReadKey();
        }
    }
}
