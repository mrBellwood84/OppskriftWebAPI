﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OppskriftWebAPI.Models
{

    /// <summary>
    /// Søkeord for oppskrift som ikke går under kategori
    /// </summary>
    /// <remarks>
    /// Eksempel er "søndagsmiddag", "fredagskos", "jul"
    /// </remarks>
    public class RecipeSearchTag : IDbItem
    {
        public Guid Id { get; set; }

        /// <summary>
        /// Søkeord for oppskrift
        /// </summary>
        public string Tag { get; set; }

    }
}