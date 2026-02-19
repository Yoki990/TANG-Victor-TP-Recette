using Microsoft.EntityFrameworkCore;
using Projet_Final_TANG_Victor.Models;

namespace Projet_Final_TANG_Victor.DbManager
{
    public class IngredientDbContext : DbContext
    {
        public IngredientDbContext(DbContextOptions options) : base(options) { }

        public DbSet<Ingredient> Ingredients { get; set; }
    }
}
