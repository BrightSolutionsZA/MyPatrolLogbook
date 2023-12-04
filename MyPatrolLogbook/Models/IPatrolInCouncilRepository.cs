namespace MyPatrolLogbook.Models
{
    public interface IPatrolInCouncilRepository
    {
        IEnumerable<PatrolInCouncil> GetAllPatrolInCouncils { get; }
    }
}
