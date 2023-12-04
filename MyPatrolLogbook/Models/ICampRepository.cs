namespace MyPatrolLogbook.Models
{
    public interface ICampRepository
    {
        IEnumerable<Camp> GetAllCamps { get; }
    }
}
