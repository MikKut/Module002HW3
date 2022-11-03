using Products.ProductModels.Clade;
using Products.ProductModels.Kingdoms;

namespace Products.Extensions
{
    /// <summary>
    /// Extension class for finding certain plants by criteria.
    /// </summary>
    internal static class FindByCriteria
    {
        /// <summary>
        /// Gets all plants higher than the size.
        /// </summary>
        /// <param name="flowers">All flowers.</param>
        /// <param name="size">Higher than.</param>
        /// <returns>All the flowers that matches the condition.</returns>
        public static IPlant[] GetAllPlantsHigherThan(this IPlant[] flowers, int size)
        {
            var allFlowers = new IPlant[GetQuantityOfAllPlantsHigherThan(flowers, size)];
            int index = 0;
            foreach (var flower in flowers)
            {
                if (flower.Size > size)
                {
                    allFlowers[index++] = flower;
                }
            }

            return allFlowers;
        }

        private static int GetQuantityOfAllPlantsHigherThan(IPlant[] flowers, int size)
        {
            int quantity = 0;
            foreach (var flower in flowers)
            {
                if (flower.Size > size)
                {
                    quantity++;
                }
            }

            return quantity;
        }
    }
}
