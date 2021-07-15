
using AnimalEngine.UI.Models;
using Microsoft.EntityFrameworkCore;

namespace AnimalEngine.UI.Context
{
    public class AnimalEngineDBContext : DbContext
    {
        public DbSet<CatViewModel> Cats { get; set; }

        protected override void OnConfiguring ( DbContextOptionsBuilder optionsBuilder ) =>
            optionsBuilder.UseSqlServer ( @"Server=(localdb)\mssqllocaldb; Database=AnimalEngineDb" );
    }
}
