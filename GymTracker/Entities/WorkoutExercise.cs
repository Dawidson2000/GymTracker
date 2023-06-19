namespace GymTracker.Entities
{
    public class WorkoutExerciseEntity
    {
        public Guid Id { get; set; }
        public DateTime Date { get; set; }
        public Guid ExerciseId { get; set; }
        public ExerciseEntity Exercise { get; set; }
        public ICollection<SetEntity> Sets { get; set; }
    }
}
