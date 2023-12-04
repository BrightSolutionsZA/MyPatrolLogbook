namespace MyPatrolLogbook.Models
{
    public interface IApplicationUserRepository
    {
        IEnumerable<ApplicationUser> GetSelectedScouts { get; }
    }
}
