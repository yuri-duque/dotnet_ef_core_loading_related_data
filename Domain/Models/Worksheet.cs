using Domain.Interfaces;

namespace Domain.Models
{
    public class Worksheet : IWorkSheet
    {
        public string Name { get; set; }
        public List<IWorkout> Workouts { get; set; }
    }
}
