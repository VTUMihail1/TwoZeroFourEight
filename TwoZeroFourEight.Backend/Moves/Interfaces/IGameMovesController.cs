namespace TwoZeroFourEight.Backend.Moves.Interfaces
{
    /// <summary>
    /// Controller responsible for handling user input moves in the game.
    /// </summary>
    public interface IGameMovesController
    {
        /// <summary>
        /// Handles the user input moves and updates the game state accordingly.
        /// </summary>
        /// <param name="key">The console key info representing the user input.</param>
        /// <param name="array">The game board array.</param>
        void InputMoves(ConsoleKeyInfo key, int[,] array);

    }
}
