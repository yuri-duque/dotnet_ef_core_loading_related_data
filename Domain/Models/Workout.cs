using Domain.Enuns;
using Domain.Interfaces;

namespace Domain.Models
{
    public class Workout : IWorkout
    {
        public string Name { get; set; }
        public WorkoutTypeEnum Type { get; set; }
        public WorkoutTimeTypeEnum TimeType { get; set; }
        public int? Time { get; set; }
        public int? Series { get; set; }
        public int? Repetions { get; set; }
        public int? Weight { get; set; }
        public WorkoutRestTypeEnum RestType { get; set; }
        public int? Rest { get; set; }
    }
}
