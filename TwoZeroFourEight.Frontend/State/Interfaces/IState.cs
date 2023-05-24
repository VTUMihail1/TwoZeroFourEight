namespace TwoZeroFourEight.Frontend.State.Interfaces
{
    /// <summary>
    /// Represents a state that can provide a result.
    /// </summary>
    public interface IState
    {
        /// <summary>
        /// Gets the result associated with the state.
        /// </summary>
        /// <returns>The result string.</returns>
        string GetResult();
    }
}

