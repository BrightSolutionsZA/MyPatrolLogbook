namespace MyPatrolLogbook.Models
{
    public class RegisterRepository : IRegisterRepository
    {
        // Implements the AppDbContext

        // Private readonly variable
        private readonly AppDBContext _appDBContext;

        // Constructor 
        public RegisterRepository(AppDBContext appDBContext)
        {
            this._appDBContext = appDBContext;
        }

        // Changing to Database 
        public IEnumerable<Register> GetAllRegisters => _appDBContext.Registers;
    }
}
