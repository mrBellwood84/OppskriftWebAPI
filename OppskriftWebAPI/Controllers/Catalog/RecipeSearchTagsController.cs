using System;
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
    public class RecipeSearchTagsController : ControllerBase
    {
        private readonly DataContext _context;

        public RecipeSearchTagsController(DataContext context)
        {
            _context = context;
        }

        // GET: api/RecipeSearchTags
        [HttpGet]
        public async Task<ActionResult<IEnumerable<RecipeSearchTag>>> GetRecipeSearchTags()
        {
            return await _context.RecipeSearchTags.ToListAsync();
        }

        // GET: api/RecipeSearchTags/5
        [HttpGet("{id}")]
        public async Task<ActionResult<RecipeSearchTag>> GetRecipeSearchTag(Guid id)
        {
            var recipeSearchTag = await _context.RecipeSearchTags.FindAsync(id);

            if (recipeSearchTag == null)
            {
                return NotFound();
            }

            return recipeSearchTag;
        }

        // PUT: api/RecipeSearchTags/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRecipeSearchTag(Guid id, RecipeSearchTag recipeSearchTag)
        {
            if (id != recipeSearchTag.Id)
            {
                return BadRequest();
            }

            _context.Entry(recipeSearchTag).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RecipeSearchTagExists(id))
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

        // POST: api/RecipeSearchTags
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<RecipeSearchTag>> PostRecipeSearchTag(RecipeSearchTag recipeSearchTag)
        {
            _context.RecipeSearchTags.Add(recipeSearchTag);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetRecipeSearchTag", new { id = recipeSearchTag.Id }, recipeSearchTag);
        }

        // DELETE: api/RecipeSearchTags/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRecipeSearchTag(Guid id)
        {
            var recipeSearchTag = await _context.RecipeSearchTags.FindAsync(id);
            if (recipeSearchTag == null)
            {
                return NotFound();
            }

            _context.RecipeSearchTags.Remove(recipeSearchTag);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool RecipeSearchTagExists(Guid id)
        {
            return _context.RecipeSearchTags.Any(e => e.Id == id);
        }
    }
}
