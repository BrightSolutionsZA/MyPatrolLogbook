namespace MyPatrolLogbook.Models
{
	public class PatrolActivityRepository : IPatrolActivityRepository
	{
		// Implements the AppDbContext

		// Private readonly variable
		private readonly AppDBContext _appDBContext;

		// Constructor 
		public PatrolActivityRepository(AppDBContext appDBContext)
		{
			this._appDBContext = appDBContext;
		}

		// Changing to Database 
		public IEnumerable<PatrolActivity> GetAllActivities => _appDBContext.Activities;
	}
}
