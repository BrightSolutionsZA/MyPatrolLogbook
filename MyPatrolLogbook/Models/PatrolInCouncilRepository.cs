namespace MyPatrolLogbook.Models
{
    public class PatrolInCouncilRepository : IPatrolInCouncilRepository
    {
        // Implements the AppDbContext

        // Private readonly variable
        private readonly AppDBContext _appDBContext;

        // Constructor 
        public PatrolInCouncilRepository(AppDBContext appDBContext)
        {
            this._appDBContext = appDBContext;
        }

        // Changing to Database 
        public IEnumerable<PatrolInCouncil> GetAllPatrolInCouncils => _appDBContext.PatrolInCouncils;
    }
}
