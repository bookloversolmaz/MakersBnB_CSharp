// namespace MakersBnB.Models;

// using Microsoft.EntityFrameworkCore;
// public class MakersBnBDbContext : DbContext
// {

//     public DbSet<Space>? Spaces { get; set; }

//     private readonly string dbName = "makersbnb_aspdotnet_dev";

//     protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//     {
//         // Only configure if not already done in Program.cs
//         if (!optionsBuilder.IsConfigured)
//         {
//             var connectionString = $"Host=localhost;Username=solmazpurser;Database={dbName}";
//             optionsBuilder.UseNpgsql(connectionString);
//         }
//     }
// }
using Microsoft.EntityFrameworkCore;

namespace MakersBnB.Models
{
    public class MakersBnBDbContext : DbContext
    {
        public MakersBnBDbContext(DbContextOptions<MakersBnBDbContext> options)
            : base(options)
        {
        }

        public DbSet<Space> Spaces { get; set; } = null!;
    }
}
