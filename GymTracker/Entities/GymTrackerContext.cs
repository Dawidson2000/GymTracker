using Microsoft.EntityFrameworkCore;

namespace GymTracker.Entities
{
    public class GymTrackerContext : DbContext
    {
        public GymTrackerContext(DbContextOptions<GymTrackerContext> options) : base(options) { }


        public DbSet<ExerciseEntity> Exercises { get; set; }
        public DbSet<SetEntity> Sets { get; set; }
        public DbSet<WorkoutExerciseEntity> WorkoutExercises { get; set; }
        public DbSet<WorkoutEntity> Workouts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(this.GetType().Assembly);
        }
    }
}
