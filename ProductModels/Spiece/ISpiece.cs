using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Products.ProductModels.Species
{
    /// <summary>
    /// Shows the spiece of the product and its full name.
    /// </summary>
    internal interface ISpiece
    {
        /// <summary>
        /// Gets spiece name.
        /// </summary>
        public static string SpieceName { get; }

        /// <summary>
        /// Gets full name of the spiece.
        /// </summary>
        public static string FullName { get; }
    }
}
