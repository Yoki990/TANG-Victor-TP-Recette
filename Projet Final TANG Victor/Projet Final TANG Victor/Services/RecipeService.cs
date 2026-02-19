using Projet_Final_TANG_Victor.Interfaces;
using Projet_Final_TANG_Victor.Models;

namespace Projet_Final_TANG_Victor.Services
{
    public class RecipeService : IRecipeService
    {
        private readonly IRecipeRepository _recetteRepository;

        public RecipeService(IRecipeRepository recetteRepository)
        {
            _recetteRepository = recetteRepository;
        }

        public Recipe AddRecipe(Recipe recette)
        {
            return _recetteRepository.AddRecipe(recette);
        }

        public List<Recipe> GetAllRecipes()
        {
            return _recetteRepository.GetAllRecettes();
        }
    }
}
