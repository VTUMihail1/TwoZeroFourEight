namespace TwoZeroFourEight.Backend.State.Interfaces
{
    /// <summary>
    /// Service responsible for restarting the game and resetting the game board.
    /// </summary>
    public interface IRestartGameService
    {
        /// <summary>
        /// Restarts the game by resetting the game board and recalculating the score.
        /// </summary>
        /// <param name="array">The game board array.</param>
        void Restart(int[,] array);

    }
}


