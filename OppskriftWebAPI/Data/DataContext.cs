using Microsoft.EntityFrameworkCore;
using OppskriftWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OppskriftWebAPI.Data
{
    public class DataContext : DbContext
    {
        // default constructor
        public DataContext(DbContextOptions options) : base(options)
        {
            // kan etterlates tom
        }

        /// <summary>
        /// Dataset for eksisterende oppskrift kategorier, til hurtigvalg ved opprettelse av ny oppskrift
        /// </summary>
        public DbSet<RecipeCategory> RecipeCategories { get; set; }

        /// <summary>
        /// Datasett for eksisterende søkeord for oppskrifter, til hurigvalg ved ny oppskrift.
        /// </summary>
        public DbSet<RecipeSearchTag> RecipeSearchTags { get; set; }

        /// <summary>
        /// Datasett for oppskrifter
        /// </summary>
        public DbSet<Recipe> Recipes { get; set; }



        /// <summary>
        /// Dataset for ingrediens kategorier
        /// </summary>
        public DbSet<IngredientCategory> IngredientCategories { get; set; }

    }
}
