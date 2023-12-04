using MyPatrolLogbook.Models;

namespace MyPatrolLogbook.ViewModels
{
    public class ScoutPatrolInformationListViewModel
    {
        public IEnumerable<ApplicationUser> Scouts { get; set; }
        public IEnumerable<Patrol> Patrols { get; set; }
    }
}
