using Microsoft.EntityFrameworkCore;
using Projet_Final_TANG_Victor.DbManager;
using Projet_Final_TANG_Victor.Migrations;
using Projet_Final_TANG_Victor.Models;

namespace Projet_Final_TANG_Victor.Repository
{
    public class RecetteIngredientRepository
    {
        private readonly AppDbContext _context;
        public RecetteIngredientRepository(AppDbContext context)
        {
            _context = context;
        }
        public List<RecetteIngredient> GetDetailRecipe(int id_Recette)
        {
            List<RecetteIngredient> rI = _context.RecettesIngredients
                .Where(rI => rI.RecetteId == id_Recette)
                .Include(r => r.Recette)
                .Include(i => i.Ingredient).ToList();
            return rI;
        }
    }
    
}
