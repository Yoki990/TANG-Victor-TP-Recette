using Projet_Final_TANG_Victor.Interfaces;
using Projet_Final_TANG_Victor.Models;
using Projet_Final_TANG_Victor.Models.DTO;

namespace Projet_Final_TANG_Victor.Services
{
    public class RecipeService : IRecipeService
    {
        private readonly IRecipeRepository _recetteRepository;
        private readonly IRecetteIngredientRepo _recetteIngredientRepo;

        public RecipeService(IRecipeRepository recetteRepository, IRecetteIngredientRepo recetteIngredientRepo)
        {
            _recetteRepository = recetteRepository;
            _recetteIngredientRepo = recetteIngredientRepo;
        }

        public Recipe AddRecipe(Recipe recette)
        {
            return _recetteRepository.AddRecipe(recette);
        }

        public List<Recipe> GetAllRecipes()
        {
            return _recetteRepository.GetAllRecettes();
        }

        public RecetteDetailDtos GetRecipeDetail(int id)
        {
            List<RecetteIngredient> rI = _recetteIngredientRepo.GetDetailRecipe(id);
            RecetteDetailDtos rdto = new RecetteDetailDtos();
            rdto.Recette = rI[0].Recette;
            foreach (RecetteIngredient r1 in rI)
            {
                rdto.Ingredient.Add(new IngredientDTO(r1.Ingredient, r1.Quantity));
            }
            return rdto;
            
        }
    }
}
