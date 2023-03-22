using Domain.Enuns;

namespace Domain.Interfaces
{
    public interface IWorkout
    {
        string Name { get; set; }
        WorkoutTypeEnum Type { get; set; }
        WorkoutTimeTypeEnum TimeType { get; set; }
        int? Time { get; set; }
        int? Series { get; set; }
        int? Repetions { get; set; }
        int? Weight { get; set; }
        WorkoutRestTypeEnum RestType { get; set; }
        int? Rest { get; set; }
    }
}
