namespace TwoZeroFourEight.Backend.Controllers.Interfaces
{
    /// <summary>
    /// Controller responsible for managing the game engine logic and handling user input.
    /// </summary>
    public interface IGameEngineController
    {
        /// <summary>
        /// Runs the game engine logic by processing user input and updating game states.
        /// </summary>
        /// <param name="array">The current game board as a 2D array.</param>
        void RunGame(int[,] array);

    }
}


