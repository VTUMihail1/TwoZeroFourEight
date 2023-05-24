namespace TwoZeroFourEight.Frontend.Logger.Interfaces
{
    /// <summary>
    /// Service class responsible for logging messages to the console.
    /// </summary>
    public interface ILoggerService
    {
        /// <summary>
        /// Writes a line of text to the console.
        /// </summary>
        /// <param name="message">The message to be written.</param>
        void WriteLine(string? message = null);

        /// <summary>
        /// Writes text to the console.
        /// </summary>
        /// <param name="message">The message to be written.</param>
        void Write(string? message = null);

        /// <summary>
        /// Clears the console.
        /// </summary>
        void Clear();

        /// <summary>
        /// Reads a key press from the console.
        /// </summary>
        void ReadKey();
    }
}
