using Microsoft.EntityFrameworkCore;
using Projet_Final_TANG_Victor.DbManager;
using Projet_Final_TANG_Victor.Interfaces;
using Projet_Final_TANG_Victor.Models;

namespace Projet_Final_TANG_Victor.Repository
{
    public class RecipeIngredientRepository : IRecipeIngredientRepository
    {
        private readonly AppDbContext _context;
        public RecipeIngredientRepository(AppDbContext context)
        {
            _context = context;
        }
        public List<RecipeIngredient> GetDetailRecipe(int id_Recipe)
        {
            List<RecipeIngredient> rI = _context.RecipesIngredients
                .Where(rI => rI.RecipeId == id_Recipe)
                .Include(r => r.Recipe)
                .Include(i => i.Ingredient).ToList();
            return rI;
        }
    }
    
}
