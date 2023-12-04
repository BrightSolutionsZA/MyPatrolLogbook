namespace MyPatrolLogbook.Models
{
    public class CommunityServiceRepository : ICommunityServiceRepository
    {
        // Implements the AppDbContext

        // Private readonly variable
        private readonly AppDBContext _appDBContext;

        // Constructor 
        public CommunityServiceRepository(AppDBContext appDBContext)
        {
            this._appDBContext = appDBContext;
        }

        // Changing to Database 
        public IEnumerable<CommunityService> GetAllProjects => _appDBContext.Projects;
    }
}
