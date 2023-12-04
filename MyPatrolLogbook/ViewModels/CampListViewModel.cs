using Microsoft.AspNetCore.Mvc;
using MyPatrolLogbook.Models;
using System.ComponentModel.DataAnnotations;

namespace MyPatrolLogbook.ViewModels
{
    public class CampListViewModel
    {
        public IEnumerable<Camp>? Camps { get; set; }
		public IEnumerable<ApplicationUser>? PatrolMembers { get; set; }

        public IEnumerable<Patrol>? Patrols { get; set; }


        [Required]
		[Display(Name = "Camp Name")]
		public string? NameOfCamp { get; set; }

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
		[Display(Name = "Venue Address")]
		public string? AddressOfVenue { get; set; }

		[Required]
		[Display(Name = "Camp Cost")]
		public int? CostOfCamp { get; set; }

		[Required]
		[Display(Name = " Camp Description")]
		public string? DescriptionOfCamp { get; set; }

		[Required]
		[Display(Name = "Attendance")]
		public List<string>? SelectedScouts { get; set; }

		[BindProperty(SupportsGet = true)]
        public DateTime StartDate { get; set; }

        [BindProperty(SupportsGet = true)]
        public DateTime EndDate { get; set; }
    }
}
