using Projet_Final_TANG_Victor.Migrations;
using Projet_Final_TANG_Victor.Models;

namespace Projet_Final_TANG_Victor.Models.DTO
{
    public class RecetteDetailDtos
    {
        public Recette Recette { get; set; }

        public List<IngredientDTO> Ingredient { get; set; }
    }
}
