using MyPatrolLogbook.Models;

namespace MyPatrolLogbook.ViewModels
{
    public class PatrolListViewModel
    {
        public IEnumerable<Patrol> Patrols { get; set; }
    }
}
