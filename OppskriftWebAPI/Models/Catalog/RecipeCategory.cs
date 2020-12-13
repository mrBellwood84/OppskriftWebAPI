using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OppskriftWebAPI.Models
{
    public class RecipeCategory : IDbItem
    {
        public Guid Id { get; set; }

        /// <summary>
        /// Navn for kategori
        /// </summary>
        public string Name { get; set; }
    }
}
