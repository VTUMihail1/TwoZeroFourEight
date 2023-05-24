namespace TwoZeroFourEight.Backend.State.Interfaces
{
    /// <summary>
    /// Controller responsible for determining the game result based on the game board array.
    /// </summary>
    public interface IResultController
    {
        /// <summary>
        /// Determines the game result based on the game board array.
        /// </summary>
        /// <param name="array">The game board array.</param>
        /// <returns>True if the game is won or lost, otherwise false.</returns>
        bool Result(int[,] array);

    }
}