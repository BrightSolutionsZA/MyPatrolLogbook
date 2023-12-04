using Microsoft.AspNetCore.Mvc;
using MyPatrolLogbook.Models;

namespace MyPatrolLogbook.ViewModels
{
	public class CurrentScoutListViewModel
	{
		public IEnumerable<ApplicationUser> CurrentScouts { get; set; }
        public IEnumerable<Patrol> Patrols { get; set; }

        // Search Bar
        [BindProperty(SupportsGet = true)]
        public string SearchStringScoutName { get; set; }
/*
        // Dropdownlist 
        [BindProperty(SupportsGet = true)]
        public string FilterByPatrol { get; set; }*/
    }
}
