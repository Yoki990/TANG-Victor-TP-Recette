using Projet_Final_TANG_Victor.Models;

namespace Projet_Final_TANG_Victor.Interfaces
{
    public interface IRecipeIngredientRepository
    {
        public List<RecipeIngredient> GetDetailRecipe(int id_Recipe);
    }
}
