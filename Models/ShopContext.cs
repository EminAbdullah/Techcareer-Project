using Microsoft.EntityFrameworkCore;

namespace GameShop.Models
{
    public class ShopContext : DbContext
    {
        public ShopContext(DbContextOptions<ShopContext> options) : base(options)
        {
        }

        public DbSet<Game> Games { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Game>().HasData(
                new Game
                {
                    Id = 1,
                    Name = "Elden_Ring",
                    Developer = "FromSoftware",
                    Publisher = "FromSoftware,Bandai Namco Entertainment",
                    ReleaseDate = 2022,
                    Type = "Action",
                    Price = 1300,
                    ImageFileName = "EldenRing.jpg"

                },
                new Game
                {
                    Id = 2,
                    Name = "Portal_2",
                    Developer = "Valve",
                    Publisher = "Valve",
                    ReleaseDate = 2011,
                    Type = "Puzzle",
                    Price = 150,
                    ImageFileName = "Portal.jpg"

                },
                new Game
                {
                    Id = 3,
                    Name = "Hades",
                    Developer = "Supergiant Games",
                    Publisher = "Supergiant Games",
                    ReleaseDate = 2020,
                    Type = "Roguelike",
                    Price = 250,
                    ImageFileName = "Hades.jpg"

                },
                new Game
                {
                    Id = 4,
                    Name = "Ghostrunner",
                    Developer = "One More Level,3D Realms",
                    Publisher = "505 Games",
                    ReleaseDate = 2020,
                    Type = "Action",
                    Price = 480,
                    ImageFileName = "Ghostrunner.jpg"

                },
                new Game
                {
                    Id = 5,
                    Name = "Sekiro",
                    Developer = "FromSoftware",
                    Publisher = "Activision,FromSoftware",
                    ReleaseDate = 2019,
                    Type = "Action",
                    Price = 1800,
                    ImageFileName = "Sekiro.jpg"

                },
                new Game
                {
                    Id = 6,
                    Name = "The_Elder_Scrolls_V_Skyrim",
                    Developer = "Bethesda Game Studios",
                    Publisher = "Bethesda Softworks",
                    ReleaseDate = 2016,
                    Type = "Adventure",
                    Price = 720,
                    ImageFileName = "Skyrim.jpg"

                }
                );
        }
    }
}
