﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OppskriftWebAPI.Data;
using OppskriftWebAPI.Models;

namespace OppskriftWebAPI.Controllers.Catalog
{
    [Route("api/[controller]")]
    [ApiController]
    public class IngredientCategoriesController : ControllerBase
    {
        private readonly DataContext _context;

        public IngredientCategoriesController(DataContext context)
        {
            _context = context;
        }

        // GET: api/IngredientCategories
        [HttpGet]
        public async Task<ActionResult<IEnumerable<IngredientCategory>>> GetIngredientCategories()
        {
            return await _context.IngredientCategories.ToListAsync();
        }

        // GET: api/IngredientCategories/5
        [HttpGet("{id}")]
        public async Task<ActionResult<IngredientCategory>> GetIngredientCategory(Guid id)
        {
            var ingredientCategory = await _context.IngredientCategories.FindAsync(id);

            if (ingredientCategory == null)
            {
                return NotFound();
            }

            return ingredientCategory;
        }

        // PUT: api/IngredientCategories/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutIngredientCategory(Guid id, IngredientCategory ingredientCategory)
        {
            if (id != ingredientCategory.Id)
            {
                return BadRequest();
            }

            _context.Entry(ingredientCategory).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!IngredientCategoryExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/IngredientCategories
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<IngredientCategory>> PostIngredientCategory(IngredientCategory ingredientCategory)
        {
            _context.IngredientCategories.Add(ingredientCategory);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetIngredientCategory", new { id = ingredientCategory.Id }, ingredientCategory);
        }

        // DELETE: api/IngredientCategories/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteIngredientCategory(Guid id)
        {
            var ingredientCategory = await _context.IngredientCategories.FindAsync(id);
            if (ingredientCategory == null)
            {
                return NotFound();
            }

            _context.IngredientCategories.Remove(ingredientCategory);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool IngredientCategoryExists(Guid id)
        {
            return _context.IngredientCategories.Any(e => e.Id == id);
        }
    }
}
