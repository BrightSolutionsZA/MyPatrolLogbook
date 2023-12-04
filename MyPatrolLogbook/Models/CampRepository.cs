namespace MyPatrolLogbook.Models
{
    public class CampRepository : ICampRepository
    {
        // Implements the AppDbContext

        // Private readonly variable
        private readonly AppDBContext _appDBContext;

        // Constructor 
        public CampRepository(AppDBContext appDBContext)
        {
            this._appDBContext = appDBContext;
        }

        // Changing to Database 
        public IEnumerable<Camp> GetAllCamps => _appDBContext.Camps;
    }
}
