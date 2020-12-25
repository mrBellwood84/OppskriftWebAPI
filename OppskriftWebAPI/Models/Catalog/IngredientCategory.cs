using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OppskriftWebAPI.Models
{
    /// <summary>
    /// Kategori for ingredienskategori
    /// </summary>
    /// <remarks>
    /// Eksempler på kategorier er "Kjøtt", "Grønnsak", "Fisk"
    /// </remarks>
    public class IngredientCategory 
    {
        public Guid Id { get; set; }

        /// <summary>
        /// Navn for kategori
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Antall ganger kategorien er tatt i bruk
        /// </summary>
        public int TimesUsed { get; set; }
    }
}
