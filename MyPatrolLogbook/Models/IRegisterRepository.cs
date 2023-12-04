namespace MyPatrolLogbook.Models
{
    public interface IRegisterRepository
    {
        IEnumerable<Register> GetAllRegisters { get; }
    }
}
