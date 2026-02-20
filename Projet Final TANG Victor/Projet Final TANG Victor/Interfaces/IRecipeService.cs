using Projet_Final_TANG_Victor.Models;
using Projet_Final_TANG_Victor.Models.DTO;

namespace Projet_Final_TANG_Victor.Interfaces
{
    public interface IRecipeService
    {
        public List<Recipe> GetAllRecipes();
        public Recipe AddRecipe (Recipe recipe);
        public RecipeDetailDtos GetRecipeDetail(int id);
        /*public RIDTO UpdateRecipe(Recipe recipe);*/
    }
}
