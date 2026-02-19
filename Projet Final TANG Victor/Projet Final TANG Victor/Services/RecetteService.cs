using Projet_Final_TANG_Victor.Interfaces;
using Projet_Final_TANG_Victor.Models;

namespace Projet_Final_TANG_Victor.Services
{
    public class RecetteService : IRecetteService
    {
        private readonly IRecetteRepository _recetteRepository;

        public RecetteService(IRecetteRepository recetteRepository)
        {
            _recetteRepository = recetteRepository;
        }

        public Recette AddRecipe(Recette recette)
        {
            return _recetteRepository.AddRecipe(recette);
        }

        public List<Recette> GetAllRecipes()
        {
            return _recetteRepository.GetAllRecettes();
        }
    }
}
