namespace TwoZeroFourEight.Backend.Controllers.Interfaces
{
    /// <summary>
    /// Controller responsible for managing the game flow and interactions between the game engine and the UI.
    /// </summary>
    public interface IGameController
    {
        /// <summary>
        /// Starts the game with the specified initial game board.
        /// </summary>
        /// <param name="array">The initial game board as a 2D array.</param>
        void Start(int[,] array);

    }
}