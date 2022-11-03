namespace Products.ProductModels.Kingdoms
{
    /// <summary>
    /// Base interface for all products.
    /// </summary>
    internal interface IPlant
    {
        /// <summary>
        /// Gets size of the plant.
        /// </summary>
        int Size { get; }

        /// <summary>
        /// Gets the time when the plant is old enough to sell.
        /// </summary>
        DateTime WillBeGrownIn { get; }

        /// <summary>
        /// Gets ID of the plant.
        /// </summary>
        public int ID { get; }
    }
}