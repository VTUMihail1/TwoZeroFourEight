namespace TwoZeroFourEight.Frontend.Services.Interfaces
{
    public interface ILoggerService
    {

        void WriteLine(string? message = null);


        void Write(string? message = null);


        void Clear();


        void ReadKey();
    }
}
