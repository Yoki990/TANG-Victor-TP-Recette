using Projet_Final_TANG_Victor.Models;

namespace Projet_Final_TANG_Victor.Interfaces
{
    public interface IRecipeRepository
    {
        public List<Recipe> GetAllRecettes();
        public Recipe AddRecipe(Recipe recipe);
    }
}
