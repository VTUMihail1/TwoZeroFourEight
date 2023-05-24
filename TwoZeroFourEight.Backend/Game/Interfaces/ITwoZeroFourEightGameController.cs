namespace TwoZeroFourEight.Backend.Controllers.Interfaces
{
    /// <summary>
    /// Controller responsible for managing the 2048 game.
    /// </summary>
    public interface ITwoZeroFourEightGameController
    {
        /// <summary>
        /// Starts and plays the 2048 game.
        /// </summary>
        /// <param name="size">The size of the game board.</param>
        void Play(int size);

    }
}