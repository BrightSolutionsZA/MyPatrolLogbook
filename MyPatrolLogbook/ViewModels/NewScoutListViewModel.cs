using MyPatrolLogbook.Models;

namespace MyPatrolLogbook.ViewModels
{
    public class NewScoutListViewModel
    {
        public IEnumerable<ApplicationUser> Scouts { get; set; }
    }
}
