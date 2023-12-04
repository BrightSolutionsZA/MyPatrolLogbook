namespace MyPatrolLogbook.Models
{
    public class HikeRepository : IHikeRepository
    {
        // Implements the AppDbContext

        // Private readonly variable
        private readonly AppDBContext _appDBContext;

        // Constructor 
        public HikeRepository(AppDBContext appDBContext)
        {
            this._appDBContext = appDBContext;
        }

        // Changing to Database 
        public IEnumerable<Hike> GetAllHikes => _appDBContext.Hikes;
    }
}
