namespace TwoZeroFourEight.Backend.Add.Interfaces
{
    /// <summary>
    /// Service responsible for adding a random element to the array.
    /// </summary>
    public interface IAddRandomService
    {
        /// <summary>
        /// Adds a random element to the specified array.
        /// </summary>
        /// <param name="array">The array to add the random element to.</param>
        void AddRandomElement(int[,] array);

    }
}


