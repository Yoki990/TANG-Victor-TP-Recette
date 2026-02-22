using Projet_Final_TANG_Victor.Interfaces;
using Projet_Final_TANG_Victor.Models;
using Projet_Final_TANG_Victor.Models.DTO;

namespace Projet_Final_TANG_Victor.Services
{
    public class RecipeService : IRecipeService
    {
        private readonly IRecipeRepository _recetteRepository;
        private readonly IRecipeIngredientRepository _recetteIngredientRepo;

        public RecipeService(IRecipeRepository recetteRepository, IRecipeIngredientRepository recetteIngredientRepo)
        {
            _recetteRepository = recetteRepository;
            _recetteIngredientRepo = recetteIngredientRepo;
        }

        public Recipe AddRecipe(Recipe recipe)
        {
            return _recetteRepository.AddRecipe(recipe);
        }

        public List<Recipe> GetAllRecipes()
        {
            return _recetteRepository.GetAllRecipes();
        }

        public RecipeDetailDtos GetRecipeDetail(int id)
        {
            List<RecipeIngredient> rI = _recetteIngredientRepo.GetDetailRecipe(id);
            RecipeDetailDtos rdto = new RecipeDetailDtos();
            rdto.Recipe = rI[0].Recipe;
            foreach (RecipeIngredient r1 in rI)
            {
                rdto.Ingredient.Add(new IngredientDTO(r1.Ingredient, r1.Quantity));
            }
            return rdto;
            
        }

        public Recipe DeleteRecipe(Recipe recipe)
        {
            return _recetteRepository.DeleteRecipe(recipe);
        }
    }
}
