using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BandDB.Models.Configuration
{
    public class GenreConfig : IEntityTypeConfiguration<Genre>
    {
        public void Configure(EntityTypeBuilder<Genre> entity)
        {
            entity.HasData(
                new Genre { GenreId = 1, Name = "Jazz" },
                new Genre { GenreId = 2, Name = "Metal"},
                new Genre { GenreId = 3, Name = "Rock"},
                new Genre { GenreId = 4, Name = "Pop"},
                new Genre { GenreId = 5, Name = "Country"},
                new Genre { GenreId = 6, Name = "Rap"},
                new Genre { GenreId = 7, Name = "Punk"}
            );
        }
    }
}
