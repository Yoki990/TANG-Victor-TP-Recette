using Projet_Final_TANG_Victor.Models;

namespace Projet_Final_TANG_Victor.Interfaces
{
    public interface IRecetteRepository
    {
        public List<Recette> GetAllRecettes();
        public Recette AddRecipe(Recette recette);
    }
}
