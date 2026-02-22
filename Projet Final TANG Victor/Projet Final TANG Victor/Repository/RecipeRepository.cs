using Microsoft.EntityFrameworkCore;
using Projet_Final_TANG_Victor.DbManager;
using Projet_Final_TANG_Victor.Interfaces;
using Projet_Final_TANG_Victor.Models;

namespace Projet_Final_TANG_Victor.Repository
{
    public class RecipeRepository : IRecipeRepository
    {
        private readonly AppDbContext _context;
        public RecipeRepository(AppDbContext context)
        {
            _context = context;
        }

        public Recipe AddRecipe(Recipe recipe)
        {
            _context.Recipes.Add(recipe);
            _context.SaveChanges();
            return recipe;
        }

        public List<Recipe> GetAllRecipes()
        {
            return _context.Recipes.ToList();
        }

        /*public Recipe UpdateRecipe(Recipe recipe, int id)
        {
            Recipe recipeToUpdate = _context.Recipes.Find(id);
           
            x.Title = recipeToUpdate;




           _context.Recipes.Update(recipe);
           _context.SaveChanges();
           return recipe;
        }*/

        public Recipe DeleteRecipe(Recipe recipe)
        {
            
           
            _context.Recipes.Remove(recipe);
            _context.SaveChanges();
            return recipe;

        }
    }
}
