using System;
using System.Collections.Generic;

namespace OppskriftWebAPI.Models
{
    /// <summary>
    /// Klasse for oppskrift objekter
    /// </summary>
    public class Recipe
    {
        public Guid Id { get; set; }

        /// <summary>
        /// Navn på oppskrift
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Beskrivelse eller kommentar av oppskrift
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Kategori for oppskrift, defineres av egen klasse.
        /// </summary>
        /// <remarks>
        /// Hver oppskrift kan kun ha en kategori
        /// </remarks>
        public RecipeCategory Category { get; set; }

        /// <summary>
        /// Søkeord for oppskrift, defineres av egen klasse.
        /// </summary>
        /// <remarks>
        /// hver oppskrift kan ha flere søkeord. 
        /// </remarks>
        public ICollection<RecipeSearchTag> SearchTags { get; set; }
    }
}
