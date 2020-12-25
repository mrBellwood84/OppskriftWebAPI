using System;

namespace OppskriftWebAPI.Models
{

    /// <summary>
    /// Søkeord for oppskrift som ikke går under kategori
    /// </summary>
    /// <remarks>
    /// Eksempel er "søndagsmiddag", "fredagskos", "jul"
    /// </remarks>
    public class RecipeSearchTag
    {
        public Guid Id { get; set; }

        /// <summary>
        /// Søkeord for oppskrift
        /// </summary>
        public string Tag { get; set; }

        /// <summary>
        /// Antall ganger søkeord er tatt i bruk
        /// </summary>
        public int TimesUsed { get; set; }
    }
}
