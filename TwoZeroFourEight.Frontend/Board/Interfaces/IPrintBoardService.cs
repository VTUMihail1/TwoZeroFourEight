namespace TwoZeroFourEight.Frontend.Board.Interfaces
{
    /// <summary>
    /// Service class responsible for printing the game board.
    /// </summary>
    public interface IPrintBoardService
    {
        /// <summary>
        /// Prints the game board.
        /// </summary>
        /// <param name="array">The two-dimensional array representing the game board.</param>
        public void PrintBoard(int[,] array);

    }
}

