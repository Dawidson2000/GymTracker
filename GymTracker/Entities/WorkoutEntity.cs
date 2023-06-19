namespace GymTracker.Entities
{
    public class WorkoutEntity
    {
        public Guid Id { get; set; }
        public DateTime Date { get; set; }
        public ICollection<WorkoutExerciseEntity> WorkoutExercises { get; set; }
    }
}
