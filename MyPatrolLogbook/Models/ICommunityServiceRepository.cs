namespace MyPatrolLogbook.Models
{
    public interface ICommunityServiceRepository
    {
        IEnumerable<CommunityService> GetAllProjects { get; }
    }
}
