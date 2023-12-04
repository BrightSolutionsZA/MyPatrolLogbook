namespace MyPatrolLogbook.Models
{
    public interface IHikeRepository
    {
        IEnumerable<Hike> GetAllHikes { get; }
    }
}
