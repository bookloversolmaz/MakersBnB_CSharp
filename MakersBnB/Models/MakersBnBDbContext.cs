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
