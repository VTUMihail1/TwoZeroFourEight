namespace TwoZeroFourEight.Backend.Add.Interfaces
{
    /// <summary>
    /// Controller responsible for adding random elements to the array.
    /// </summary>
    public interface IAddRandomController
    {
        /// <summary>
        /// Adds random elements to the specified array.
        /// </summary>
        /// <param name="array">The array to add random elements to.</param>
        void Add(int[,] array);

    }
}

