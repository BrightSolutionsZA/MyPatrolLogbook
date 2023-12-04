using Microsoft.AspNetCore.Mvc;
using MyPatrolLogbook.Models;
using System.ComponentModel.DataAnnotations;

namespace MyPatrolLogbook.ViewModels
{
	public class PatrolActivityListViewModel
	{
		public IEnumerable<PatrolActivity>? Activities { get; set; }
		public IEnumerable<ApplicationUser>? PatrolMembers { get; set; }

        public IEnumerable<Patrol>? Patrols { get; set; }

        [Required]
		[Display(Name = "Activity Name")]
		public string? NameOfActivity { get; set; }

        [Required]
        [Display(Name = "Permit ID")]
        public string? PermitID { get; set; }

        [Required]
		[Display(Name = "Start Date")]
		public DateTime? StartDateAndTime { get; set; }

		[Required]
		[Display(Name = "End Date")]
		public DateTime? EndDateAndTime { get; set; }

		[Required]
		[Display(Name = "Venue Name")]
		public string? NameOfVenue { get; set; }

		[Required]
		[Display(Name = "Activity Description")]
		public string? DescriptionOfActivity { get; set; }

		[Required]
		[Display(Name = "Attendance")]
		public List<string>? SelectedScouts { get; set; }

		[BindProperty(SupportsGet = true)]
        public DateTime StartDate { get; set; }

        [BindProperty(SupportsGet = true)]
        public DateTime EndDate { get; set; }
    }
}
