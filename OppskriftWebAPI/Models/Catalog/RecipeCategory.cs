﻿using System;

namespace OppskriftWebAPI.Models
{
    /// <summary>
    /// Kategori for oppskrift.
    /// </summary>
    /// <remarks>
    /// Eksempel på kategori er "middag", "suppe", "kake"
    /// </remarks>
    public class RecipeCategory
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
