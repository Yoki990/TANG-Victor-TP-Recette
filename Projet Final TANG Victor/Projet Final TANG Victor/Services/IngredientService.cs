using Projet_Final_TANG_Victor.Interfaces;
using Projet_Final_TANG_Victor.Models;
using Projet_Final_TANG_Victor.Models.DTO;
using Projet_Final_TANG_Victor.Repository;

namespace Projet_Final_TANG_Victor.Services
{
    public class IngredientService : IIngredientService
    {
        private readonly IIngredientRepository _ingredientRepository;

        public IngredientService(IIngredientRepository ingredientRepository)
        {
            _ingredientRepository = ingredientRepository;
        }

        public Ingredient AddIngredient(Ingredient ingredient)
        {
            return _ingredientRepository.AddIngredient(ingredient);
        }

        public List<Ingredient> GetAllIngredients()
        {
            return _ingredientRepository.GetAllIngredients();
        }

        public Ingredient UpdateIngredient(Ingredient ingredient, int id)
        {
            return _ingredientRepository.UpdateIngredient(ingredient, id);
        }

        public Ingredient DeleteIngredient(Ingredient ingredient)
        {
            return _ingredientRepository.DeleteIngredient(ingredient);
        }
    }
}
