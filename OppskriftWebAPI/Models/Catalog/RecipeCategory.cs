using System;

namespace OppskriftWebAPI.Models
{
    /// <summary>
    /// Kategori for oppskrift.
    /// </summary>
    /// <remarks>
    /// Eksempel på kategori er "middag", "suppe", "kake"
    /// </remarks>
    public class RecipeCategory : IDbItem
    {
        public Guid Id { get; set; }

        /// <summary>
        /// Navn for kategori
        /// </summary>
        public string Name { get; set; }
    }
}
