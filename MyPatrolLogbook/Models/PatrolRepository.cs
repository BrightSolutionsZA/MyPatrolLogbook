namespace MyPatrolLogbook.Models
{
    public class PatrolRepository : IPatrolRepository
    {
        // Implements the AppDbContext

        // Private readonly variable
        private readonly AppDBContext _appDBContext;

        // Constructor 
        public PatrolRepository(AppDBContext appDBContext)
        {
            this._appDBContext = appDBContext;
        }

        // Changing to Database 
        public IEnumerable<Patrol> GetAllPatrols => _appDBContext.Patrols;
    }
}
