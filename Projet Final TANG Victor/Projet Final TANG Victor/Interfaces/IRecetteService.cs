using Projet_Final_TANG_Victor.Models;

namespace Projet_Final_TANG_Victor.Interfaces
{
    public interface IRecetteService
    {

        public List<Recette> GetAllRecipes();
        public Recette AddRecipe (Recette recette);
    }
}
