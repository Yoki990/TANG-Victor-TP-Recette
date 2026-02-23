using Projet_Final_TANG_Victor.DbManager;
using Projet_Final_TANG_Victor.Interfaces;
using Projet_Final_TANG_Victor.Models;

namespace Projet_Final_TANG_Victor.Repository
{
    public class IngredientRepository : IIngredientRepository
    {
        private readonly AppDbContext _context;
        public IngredientRepository(AppDbContext context)
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

        public Ingredient UpdateIngredient(Ingredient ingredient, int Id)
        {
            _context.Ingredients.FirstOrDefault(x => x.Id == Id);
            _context.Ingredients.Update(ingredient);
            _context.SaveChanges();
            return ingredient;
        }

        public Ingredient DeleteIngredient(Ingredient ingredient)
        {


            _context.Ingredients.Remove(ingredient);
            _context.SaveChanges();
            return ingredient;

        }
    }
}
