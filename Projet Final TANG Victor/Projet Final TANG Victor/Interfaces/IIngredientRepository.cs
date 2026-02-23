using Projet_Final_TANG_Victor.Models;

namespace Projet_Final_TANG_Victor.Interfaces
{
    public interface IIngredientRepository
    {
        public List<Ingredient> GetAllIngredients();
        public Ingredient AddIngredient(Ingredient ingredient);

        public Ingredient UpdateIngredient(Ingredient ingredient, int id);

        public Ingredient DeleteIngredient(Ingredient ingredient);
    }
}
