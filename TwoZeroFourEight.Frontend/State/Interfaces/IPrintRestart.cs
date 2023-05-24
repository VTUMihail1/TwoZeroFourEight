namespace TwoZeroFourEight.Frontend.State.Interfaces
{
    /// <summary>
    /// Service class responsible for printing the restart message and resetting the game.
    /// </summary>
    public interface IPrintRestart
    {
        /// <summary>
        /// Restarts the game with the specified message.
        /// </summary>
        /// <param name="message">The message to be displayed before restarting the game.</param>
        void Restart(string message);
    }
}