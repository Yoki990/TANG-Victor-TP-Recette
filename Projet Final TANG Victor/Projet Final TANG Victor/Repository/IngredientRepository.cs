using Projet_Final_TANG_Victor.DbManager;
using Projet_Final_TANG_Victor.Interfaces;
using Projet_Final_TANG_Victor.Models;

namespace Projet_Final_TANG_Victor.Repository
{
    public class IngredientRepository : IIngredientRepository
    {
        private readonly IngredientDbContext _context;
        public IngredientRepository(IngredientDbContext context)
        {
            _context = context;
        }

        public Ingredient AddIngredient(Ingredient ingredient)
        {
            _context.Ingredients.Add(ingredient);
            _context.SaveChanges();
            return ingredient;
        }

        public List<Ingredient> GetAllIngredients()
        {
            return _context.Ingredients.ToList();
        }
    }
}
