namespace TwoZeroFourEight.Backend.Board.Interfaces
{
    /// <summary>
    /// Service responsible for initializing the game board.
    /// </summary>
    public interface IInitializeBoardService
    {
        /// <summary>
        /// Initializes the game board.
        /// </summary>
        /// <returns>The initialized game board as a 2D array.</returns>
        int[,] InitializeBoard();

    }
}

