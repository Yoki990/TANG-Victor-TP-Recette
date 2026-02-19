using Projet_Final_TANG_Victor.Models;

namespace Projet_Final_TANG_Victor.Interfaces
{
    public interface IRecetteIngredientRepo
    {
        public List<RecetteIngredient> GetDetailRecipe(int id_Recette);
    }
}
