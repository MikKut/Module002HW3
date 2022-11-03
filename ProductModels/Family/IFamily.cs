using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Products.ProductModels.Family
{
    /// <summary>
    /// Shows that this is a family.
    /// </summary>
    internal interface IFamily
    {
        /// <summary>
        /// Gets family name.
        /// </summary>
        static string FamilyName { get; }
    }
}
