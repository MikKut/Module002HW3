using Products.Extensions;
using Products.ProductModels.Kingdoms;
using Products.ProductModels.Species;

namespace Products
{
    /// <summary>
    /// Class with entry point.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Entry point.
        /// </summary>
        public static void Main()
        {
            int id = 0;
            var plants = new IPlant[]
            {
                new Arboricola(10, new DateTime(1, 10, 2), System.Drawing.Color.Pink, id++),
                new Arboricola(20, new DateTime(1, 5, 6), System.Drawing.Color.Pink, id++),
                new Arboricola(5, new DateTime(1, 6, 5), System.Drawing.Color.Pink, id++),
                new Candidum(10, new DateTime(1, 7, 3), System.Drawing.Color.AntiqueWhite, id++),
                new Candidum(24, new DateTime(1, 2, 10), System.Drawing.Color.AntiqueWhite, id++),
            };
            foreach (var plant in plants)
            {
                Console.WriteLine($"All ID of plants: " + plant.ID);
            }

            var plantsHigherThanTen = FindByCriteria.GetAllPlantsHigherThan(plants, 10);
            foreach (var plant in plantsHigherThanTen)
            {
                Console.WriteLine($"All ID of plants higher than 10: " + plant.ID);
            }
        }
    }
}