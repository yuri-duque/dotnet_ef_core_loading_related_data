namespace Domain.Interfaces
{
    public interface IWorkSheet
    {
        public string Name { get; set; }
        public List<IWorkout> Workouts { get; set; }
    }
}
