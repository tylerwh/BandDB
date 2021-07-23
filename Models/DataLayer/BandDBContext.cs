using BandDB.Models.Configuration;
using Microsoft.EntityFrameworkCore;

namespace BandDB.Models
{
    public class BandDBContext : DbContext
    {
        public BandDBContext(DbContextOptions<BandDBContext> options) : base(options) { }

        public DbSet<Artist> Artists { get; set; }
        public DbSet<Band> Bands { get; set; }
        public DbSet<Genre> Genres { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ArtistConfig());
            modelBuilder.ApplyConfiguration(new BandConfig());
            modelBuilder.ApplyConfiguration(new GenreConfig());
        }
    }
}
