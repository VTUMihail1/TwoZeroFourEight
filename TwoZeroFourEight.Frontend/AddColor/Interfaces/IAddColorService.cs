namespace TwoZeroFourEight.Frontend.AddColor.Interfaces
{
    /// <summary>
    /// Service class for adding colors to the console based on a given value.
    /// </summary>
    public interface IAddColorService
    {
        /// <summary>
        /// Adds color to the console based on the provided value.
        /// </summary>
        /// <param name="value">The value used to determine the console color.</param>
        void AddColor(int value);

    }
}

