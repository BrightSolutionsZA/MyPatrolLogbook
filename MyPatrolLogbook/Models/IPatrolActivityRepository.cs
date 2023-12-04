namespace MyPatrolLogbook.Models
{
	public interface IPatrolActivityRepository
	{
		IEnumerable<PatrolActivity> GetAllActivities { get; }
	}
}
