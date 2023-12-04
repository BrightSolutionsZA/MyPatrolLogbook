using MyPatrolLogbook.Models;

namespace MyPatrolLogbook.ViewModels
{
    public class MyPatrolInformationListViewModel
    {
        public IEnumerable<ApplicationUser> MyScouts { get; set; }
    }
}
