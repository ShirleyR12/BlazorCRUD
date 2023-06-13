using BlazorFullStack.Shared;
using Microsoft.EntityFrameworkCore;

namespace BlazorFullStack.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        {
            modelBuilder.Entity<Comic>().HasData(
                new Comic { Id= 1, Name = "Marvel" },
                new Comic { Id = 2, Name = "DC" }
            );

            modelBuilder.Entity<SuperHero>().HasData(
                new SuperHero { 
                    Id = 1,
                    FisrtName = "Peter" ,
                    LastName = "Park",
                    HeroName = "Homem aranha",
                    ComicId = 1,
                },
                new SuperHero
                {
                    Id = 2,
                    FisrtName = "Bruce",
                    LastName = "Will",
                    HeroName = "Batman",
                    ComicId = 2,
                }
            ); 
        }

        public DbSet<Comic> Comic { get;set; }
        public DbSet<SuperHero> SuperHero { get; set; }

    }
}
