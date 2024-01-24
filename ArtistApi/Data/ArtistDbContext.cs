using ArtistApi.Models;
using Microsoft.EntityFrameworkCore;

namespace ArtistApi.Data
{
    public class ArtistDbContext : DbContext
    {
        public ArtistDbContext(DbContextOptions<ArtistDbContext> options) : base(options)
        {
            
        }
        public DbSet<Artist> Artists { get; set; }
        
    }
}
