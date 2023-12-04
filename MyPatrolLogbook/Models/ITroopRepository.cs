namespace MyPatrolLogbook.Models
{
    public interface ITroopRepository
    {
        IEnumerable<Troop> GetAllTroops { get; }
    }
}
