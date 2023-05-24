namespace TwoZeroFourEight.Frontend.State.Interfaces
{
    /// <summary>
    /// Controller class responsible for printing the game result state.
    /// </summary>
    public interface IPrintStateController
    {
        /// <summary>
        /// Prints the game result and returns the result message.
        /// </summary>
        /// <returns>The game result message.</returns>
        string PrintGameResult();

    }
}