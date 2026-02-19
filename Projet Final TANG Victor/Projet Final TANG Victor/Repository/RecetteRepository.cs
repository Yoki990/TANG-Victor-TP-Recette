using Microsoft.EntityFrameworkCore;
using Projet_Final_TANG_Victor.DbManager;
using Projet_Final_TANG_Victor.Interfaces;
using Projet_Final_TANG_Victor.Models;

namespace Projet_Final_TANG_Victor.Repository
{
    public class RecetteRepository : IRecipeRepository
    {
        private readonly AppDbContext _context;
        public RecetteRepository(AppDbContext context)
        {
            _context = context;
        }

        public Recipe AddRecipe(Recipe recette)
        {
            _context.Recettes.Add(recette);
            _context.SaveChanges();
            return recette;
        }

        public List<Recipe> GetAllRecettes()
        {
            return _context.Recettes.ToList();
        }
    }
}
