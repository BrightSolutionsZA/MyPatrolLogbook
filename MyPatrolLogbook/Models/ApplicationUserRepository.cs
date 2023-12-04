namespace MyPatrolLogbook.Models
{
    public class ApplicationUserRepository : IApplicationUserRepository
    {
        // Implements the AppDbContext

        // Private readonly variable
        private readonly AppDBContext _appDBContext;

        // Constructor 
        public ApplicationUserRepository(AppDBContext appDBContext)
        {
            this._appDBContext = appDBContext;
        }

        // Changing to Database 
        public IEnumerable<ApplicationUser> GetSelectedScouts => _appDBContext.Users.ToList();
    }
}
