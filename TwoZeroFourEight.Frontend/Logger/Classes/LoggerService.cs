using TwoZeroFourEight.Frontend.Logger.Interfaces;

namespace TwoZeroFourEight.Frontend.Logger.Classes
{
    public class LoggerService : ILoggerService
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
