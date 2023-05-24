namespace TwoZeroFourEight.Backend.State.Interfaces
{
    /// <summary>
    /// Controller responsible for handling game states and user input.
    /// </summary>
    public interface IStateController
    {
        /// <summary>
        /// Handles the input states based on the user's key input and updates the game accordingly.
        /// </summary>
        /// <param name="key">The ConsoleKeyInfo representing the key input.</param>
        /// <param name="array">The game board array.</param>
        void InputStates(ConsoleKeyInfo key, int[,] array);

    }
}
