using Microsoft.EntityFrameworkCore;
using Projet_Final_TANG_Victor.Models;

namespace Projet_Final_TANG_Victor.DbManager
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options) { }

        public DbSet<Ingredient> Ingredients { get; set; }

        public DbSet<Recipe> Recettes { get; set; }
    }
}
