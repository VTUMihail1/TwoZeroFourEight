namespace TwoZeroFourEight.Backend.State.Interfaces
{
    /// <summary>
    /// Service for determining if the game has been won.
    /// </summary>
    public interface IYouWinService
    {
        /// <summary>
        /// Checks if the game has been won based on the current game board.
        /// </summary>
        /// <param name="array">The game board array.</param>
        /// <returns>True if the game has been won, false otherwise.</returns>
        bool YouWin(int[,] array);

    }
}
