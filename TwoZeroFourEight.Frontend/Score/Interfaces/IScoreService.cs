namespace TwoZeroFourEight.Frontend.Score.Interfaces
{
    /// <summary>
    /// Service class responsible for managing game scores.
    /// </summary>
    public interface IScoreService
    {
        /// <summary>
        /// Gets or sets the current score.
        /// </summary>
        int ManageCurrentScore { get; set; }

        /// <summary>
        /// Gets or sets the last score achieved.
        /// </summary>
        int ManageLastScore { get; set; }

        /// <summary>
        /// Gets or sets the score corresponding to the highest tile achieved.
        /// </summary>
        int HighestTileScore { get; set; }

        /// <summary>
        /// Gets or sets the best score achieved.
        /// </summary>
        int ManageBestScore { get; set; }

    }
}

