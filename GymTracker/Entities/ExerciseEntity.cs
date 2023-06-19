using GymTrackerModels.Enums;

namespace GymTracker.Entities
{
    public class ExerciseEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public MuscleType PrimaryMuscle { get; set; }
        public MuscleType SecondaryMuscle { get; set; }
        public ExerciseType Type { get; set; }
    }
}
