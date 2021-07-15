
using AnimalEngine.Entity;
using Microsoft.EntityFrameworkCore;

namespace AnimalEngine.UI.Context
{
    public class AnimalEngineDBContext : DbContext
    {
        public DbSet<CatDto> Cats { get; set; }
        protected override void OnConfiguring ( DbContextOptionsBuilder optionsBuilder ) =>
            optionsBuilder.UseSqlServer ( @"Server=(localdb)\mssqllocaldb; Database=AnimalEngineDb" );
    }
}
