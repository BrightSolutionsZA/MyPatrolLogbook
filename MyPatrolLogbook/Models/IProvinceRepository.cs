namespace MyPatrolLogbook.Models
{
    public interface IProvinceRepository
    {
        IEnumerable<Province> GetAllProvinces { get; }
    }
}
