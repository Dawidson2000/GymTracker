using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GymTracker.Entities.Configurations
{
    public class WorkoutConfiguration : IEntityTypeConfiguration<WorkoutEntity>
    {
        public void Configure(EntityTypeBuilder<WorkoutEntity> builder) 
        {
            builder.Property(e => e.Date).IsRequired();
        }
    }
}
