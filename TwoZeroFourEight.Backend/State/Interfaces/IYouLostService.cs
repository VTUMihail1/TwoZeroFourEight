namespace TwoZeroFourEight.Backend.State.Interfaces
{
    /// <summary>
    /// Service for determining if the game has been lost.
    /// </summary>
    public interface IYouLostService
    {
        /// <summary>
        /// Checks if the game has been lost based on the current game board.
        /// </summary>
        /// <param name="array">The game board array.</param>
        /// <returns>True if the game has been lost, false otherwise.</returns>
        bool YouLost(int[,] array);

    }
}

