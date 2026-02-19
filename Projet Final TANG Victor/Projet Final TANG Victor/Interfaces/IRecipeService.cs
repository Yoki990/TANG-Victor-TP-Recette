using Projet_Final_TANG_Victor.Models;

namespace Projet_Final_TANG_Victor.Interfaces
{
    public interface IRecipeService
    {
        public List<Recipe> GetAllRecipes();
        public Recipe AddRecipe (Recipe recipe);
    }
}
