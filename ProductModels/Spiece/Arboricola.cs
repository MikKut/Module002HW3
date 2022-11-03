using System.Drawing;
using Products.ProductModels.Genus;

namespace Products.ProductModels.Species
{
    /// <summary>
    /// Lilium Arboricola.
    /// </summary>
    internal class Arboricola : Lilium, ISpiece
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Arboricola"/> class.
        /// </summary>
        /// <param name="size"><inheritdoc cref="Kingdoms.IPlant.Size"/></param>
        /// <param name="willBeGrownIn"><inheritdoc cref="Kingdoms.IPlant.willBeGrownIn"/></param>
        /// <param name="colour"><inheritdoc cref="IAngiospermae.ColourOfTheFlower"/></param>
        /// <param name="id"/><inheritdoc cref="IPlant.ID"/>.</param>.
        public Arboricola(int size, DateTime willBeGrownIn, Color colour, int id)
            : base(size, willBeGrownIn, colour, id)
        {
        }

        /// <summary>
        /// Gets spiece name.
        /// </summary>
        /// <returns>Name of the spiece.</returns>
        public static string SpieceName => "Arboricola";

        /// <summary>
        /// Gets full name.
        /// </summary>
        /// <returns>String with order, family, genus and spiece, separated by spaces.</returns>
        public string FullName => $"{OrderName} {FamilyName} {GenusName} {SpieceName}";
    }
}
