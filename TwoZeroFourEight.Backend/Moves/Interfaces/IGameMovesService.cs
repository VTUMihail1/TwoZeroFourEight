namespace TwoZeroFourEight.Backend.Moves.Interfaces
{
    /// <summary>
    /// Service responsible for handling game moves and updating the game board array.
    /// </summary>
    public interface IGameMovesService
    {
        /// <summary>
        /// Moves the game tiles up.
        /// </summary>
        /// <param name="array">The game board array.</param>
        void MoveUp(int[,] array);

        /// <summary>
        /// Moves the game tiles down.
        /// </summary>
        /// <param name="array">The game board array.</param>
        void MoveDown(int[,] array);

        /// <summary>
        /// Moves the game tiles to the right.
        /// </summary>
        /// <param name="array">The game board array.</param>
        void MoveRight(int[,] array);

        /// <summary>
        /// Moves the game tiles to the left.
        /// </summary>
        /// <param name="array">The game board array.</param>
        void MoveLeft(int[,] array);

    }
}
