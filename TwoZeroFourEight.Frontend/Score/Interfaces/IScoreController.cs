namespace TwoZeroFourEight.Frontend.Score.Interfaces
{
    /// <summary>
    /// Controller class responsible for managing game scores.
    /// </summary>
    public interface IScoreController
    {
        /// <summary>
        /// Calculates and restarts the scores based on the highest tile achieved.
        /// </summary>
        /// <param name="highestTile">The value of the highest tile achieved.</param>
        void Calculate(int highestTile);

        /// <summary>
        /// Updates the best score to match the current score.
        /// </summary>
        void UpdateBestScore();

        /// <summary>
        /// Updates the current score by adding the specified number.
        /// </summary>
        /// <param name="number">The number to be added to the current score.</param>
        void UpdateCurrentScore(int number);

        /// <summary>
        /// Updates the last score by adding the specified number.
        /// </summary>
        /// <param name="number">The number to be added to the last score.</param>
        void UpdateLastScore(int number);

    }
}