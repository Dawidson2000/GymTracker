namespace GymTracker.Entities
{
    public class SetEntity
    {
        public Guid Id { get; set; }
        public DateTime Date { get; set; }
        public int? Reps { get; set; }
        public int? Weight { get; set; } 
        public TimeSpan? Time { get; set; }
        public int? Distance { get; set; }
        public Guid WorkoutExerciseId { get; set; }
        public WorkoutExerciseEntity WorkoutExercise { get; set; }
    }
}
