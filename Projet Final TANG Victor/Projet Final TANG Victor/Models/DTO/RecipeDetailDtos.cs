using Projet_Final_TANG_Victor.Models;

namespace Projet_Final_TANG_Victor.Models.DTO
{
    public class RecipeDetailDtos
    {
        public Recipe Recipe { get; set; }

        public List<IngredientDTO> Ingredient { get; set; }
    }
}
