namespace MyPatrolLogbook.Models
{
    public interface IPatrolRepository
    {
        IEnumerable<Patrol> GetAllPatrols { get; }
    }
}
