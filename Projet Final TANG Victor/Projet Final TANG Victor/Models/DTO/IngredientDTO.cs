using Projet_Final_TANG_Victor.Models;

namespace Projet_Final_TANG_Victor.Models.DTO
{
    public class IngredientDTO
    {
        public Ingredient Ingredient { get; set; }

        public int Quantity { get; set; }

        public IngredientDTO(Ingredient ingredient, int quantity)
        {
            Ingredient = ingredient;
            Quantity = quantity;
        }
    }
}
