using Projet_Final_TANG_Victor.Models;

namespace Projet_Final_TANG_Victor.Interfaces
{
    public interface IRecipeRepository
    {
        public List<Recipe> GetAllRecipes();
        public Recipe AddRecipe(Recipe recipe);
        public Recipe UpdateRecipe(Recipe recipe);

        public Recipe DeleteRecipe(Recipe recipe);
    }
}
