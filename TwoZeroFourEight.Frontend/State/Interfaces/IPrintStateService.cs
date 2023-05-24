namespace TwoZeroFourEight.Frontend.State.Interfaces
{
    /// <summary>
    /// Service class responsible for selecting the print state strategy based on the maximum tile value.
    /// </summary>
    public interface IPrintStateService
    {
        /// <summary>
        /// Selects the appropriate print state strategy based on the maximum tile value.
        /// </summary>
        /// <param name="maxTile">The maximum tile value.</param>
        void Strategy(int maxTile);

    }
}

