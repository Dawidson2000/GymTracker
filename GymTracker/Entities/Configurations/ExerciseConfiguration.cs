using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GymTracker.Entities.Configurations
{
    public class SetConfiguration : IEntityTypeConfiguration<SetEntity>
    {
        public void Configure(EntityTypeBuilder<SetEntity> builder) 
        {
            builder.Property(e => e.Date).IsRequired();
        }
    }
}
