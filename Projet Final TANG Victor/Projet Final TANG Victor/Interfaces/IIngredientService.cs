using Projet_Final_TANG_Victor.Models;

namespace Projet_Final_TANG_Victor.Interfaces
{
    public interface IIngredientService
    {
        public List<Ingredient> GetAllIngredients();
        public Ingredient AddIngredient(Ingredient ingredient);
    }
}
