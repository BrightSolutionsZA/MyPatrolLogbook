using MyPatrolLogbook.Models;

namespace MyPatrolLogbook.ViewModels
{
    public class TroopListViewModel
    {
        public IEnumerable<Troop> Troops { get; set; }
		public IEnumerable<ApplicationUser> TroopScouters { get; set; }
	}
}
