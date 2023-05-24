namespace TwoZeroFourEight.Frontend.Controllers.Interfaces
{
    /// <summary>
    /// Controller class responsible for managing the user interface of the game.
    /// </summary>
    public interface IUIController
    {
        /// <summary>
        /// Prints the game user interface, including the heading, game board, and menu.
        /// </summary>
        /// <param name="array">The two-dimensional array representing the game board.</param>
        void Print(int[,] array);

    }
}
