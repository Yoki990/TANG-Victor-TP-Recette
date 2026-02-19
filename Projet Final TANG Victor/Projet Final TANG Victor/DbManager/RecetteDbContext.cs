using Microsoft.EntityFrameworkCore;
using Projet_Final_TANG_Victor.Models;

namespace Projet_Final_TANG_Victor.DbManager
{
    public class RecetteDbContext : DbContext
    {
        public RecetteDbContext(DbContextOptions options) : base(options) { }

        public DbSet<Recette> Recettes { get; set; }
    }
}
