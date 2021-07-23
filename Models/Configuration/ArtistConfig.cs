using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BandDB.Models.Configuration
{
    public class ArtistConfig : IEntityTypeConfiguration<Artist>
    {
        public void Configure(EntityTypeBuilder<Artist> entity)
        {
            entity.HasOne(b => b.Band)
                  .WithMany(m => m.Artists)
                  .OnDelete(DeleteBehavior.Restrict);

            entity.HasData(
                new Artist { ArtistId = 1, FirstName = "Spencer", LastName = "Hopps", BandId = 1},
                new Artist { ArtistId = 2, FirstName = "Bull", LastName = "Frog", BandId = 1},
                new Artist { ArtistId = 3, FirstName = "Ben", LastName = "Folds", BandId = 2},
                new Artist { ArtistId = 4, FirstName = "Darren", LastName = "Jesse", BandId = 2},
                new Artist { ArtistId = 5, FirstName = "Robert", LastName = "Sledge", BandId = 2}
            );
        }
    }
}
