using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GymTracker.Entities.Configurations
{
    public class WorkoutExerciseConfiguration : IEntityTypeConfiguration<WorkoutExerciseEntity>
    {
        public void Configure(EntityTypeBuilder<WorkoutExerciseEntity> builder) 
        {
            builder.Property(e => e.Date).IsRequired();
        }
    }
}
