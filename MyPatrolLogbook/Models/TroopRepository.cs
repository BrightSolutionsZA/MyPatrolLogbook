namespace MyPatrolLogbook.Models
{
    public class TroopRepository : ITroopRepository
    {
        // Implements the AppDbContext

        // Private readonly variable
        private readonly AppDBContext _appDBContext;

        // Constructor 
        public TroopRepository(AppDBContext appDBContext)
        {
            this._appDBContext = appDBContext;
        }

        // Changing to Database 
        public IEnumerable<Troop> GetAllTroops => _appDBContext.Troops;
    }
}
