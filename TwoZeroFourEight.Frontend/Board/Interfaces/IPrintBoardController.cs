namespace TwoZeroFourEight.Frontend.Board.Interfaces
{
    /// <summary>
    /// Controller class responsible for printing the game board and handling game over scenarios.
    /// </summary>
    public interface IPrintBoardController
    {
        /// <summary>
        /// Prints the game board.
        /// </summary>
        /// <param name="array">The two-dimensional array representing the game board.</param>
        void PrintGameBoard(int[,] array);

    }
}
