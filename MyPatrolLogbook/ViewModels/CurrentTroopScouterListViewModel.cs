using Microsoft.AspNetCore.Mvc;
using MyPatrolLogbook.Models;

namespace MyPatrolLogbook.ViewModels
{
    public class CurrentTroopScouterListViewModel
    {
        public IEnumerable<ApplicationUser> CurrentTroopScouters { get; set; }
        public IEnumerable<Troop> Troops { get; set; }

        // Search Bar
        [BindProperty(SupportsGet = true)]
        public string SearchStringTSName { get; set; }
    }
}
