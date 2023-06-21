using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GymTracker.Entities.Configurations
{
    public class ExerciseConfiguration : IEntityTypeConfiguration<ExerciseEntity>
    {
        public void Configure(EntityTypeBuilder<ExerciseEntity> builder) 
        {
            builder.Property(e => e.Name).IsRequired();
            builder.Property(e => e.PrimaryMuscle).IsRequired();
            builder.Property(e => e.Type).IsRequired();
        }
    }
}
