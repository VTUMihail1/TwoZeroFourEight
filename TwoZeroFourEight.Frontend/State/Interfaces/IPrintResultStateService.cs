namespace TwoZeroFourEight.Frontend.State.Interfaces
{
    /// <summary>
    /// Class responsible for selecting and printing the result state.
    /// </summary>
    public interface IPrintResultStateService
    {
        /// <summary>
        /// Prints the result using the selected state.
        /// </summary>
        /// <returns>The result message.</returns>
        string Print();

        /// <summary>
        /// Selects the specified state.
        /// </summary>
        /// <param name="state">The state to be selected.</param>
        void Select(IState state);
    }
}