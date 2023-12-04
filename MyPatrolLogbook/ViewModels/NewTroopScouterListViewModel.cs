using MyPatrolLogbook.Models;

namespace MyPatrolLogbook.ViewModels
{
    public class NewTroopScouterListViewModel
    {
        public IEnumerable<ApplicationUser> TroopScouters { get; set; }
        public IEnumerable<Troop> Troops { get; set; }
    }
}
