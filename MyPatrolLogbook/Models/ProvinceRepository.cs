namespace MyPatrolLogbook.Models
{
    public class ProvinceRepository : IProvinceRepository
    {
        // Implements the AppDbContext

        // Private readonly variable
        private readonly AppDBContext _appDBContext;

        // Constructor 
        public ProvinceRepository(AppDBContext appDBContext)
        {
            this._appDBContext = appDBContext;
        }

        // Changing to Database 
        public IEnumerable<Province> GetAllProvinces => _appDBContext.Provinces;
    }
}
