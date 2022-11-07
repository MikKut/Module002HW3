using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Products.ProductModels.Genus
{
    /// <summary>
    /// Shows that this is a genus.
    /// </summary>
    internal interface IGenus
    {
        /// <summary>
        /// Gets a genus name.
        /// </summary>
        public string GenusName { get; }
    }
}
