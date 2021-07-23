using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BandDB.Models.Configuration
{
    public class BandConfig : IEntityTypeConfiguration<Band>
    {
        public void Configure(EntityTypeBuilder<Band> entity)
        {
            entity.HasData(
                new Band { BandId = 1, Name = "The Frogs", GenreId = 2},
                new Band { BandId = 2, Name = "Ben Folds Five", GenreId = 3}
            );
            
        }
    }
}
