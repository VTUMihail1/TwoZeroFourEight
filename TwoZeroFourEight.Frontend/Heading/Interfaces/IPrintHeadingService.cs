namespace TwoZeroFourEight.Frontend.Heading.Interfaces
{
    /// <summary>
    /// Service class responsible for printing the game heading.
    /// </summary>
    public interface IPrintHeadingService
    {
        /// <summary>
        /// Prints the game heading, including the current score and best score.
        /// </summary>
        void Print();

    }
}